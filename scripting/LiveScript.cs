/*
    sb0t ares chat server
    Copyright (C) 2017  AresChat

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

﻿using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Threading;
using iconnect;
using Newtonsoft.Json;
using System.IO.Compression;
using System.Text.RegularExpressions;
using scripting.LiveScriptAPIModels;

namespace scripting
{
    public class LiveScript
    {
        private static ConcurrentQueue<LiveScriptItem> items = new ConcurrentQueue<LiveScriptItem>();
        public static String liveScriptsEndpoint = "";
        public static void Reset()
        {
            items = new ConcurrentQueue<LiveScriptItem>();
        }

        public static void CheckTasks()
        {
            while (items.Count > 0)
            {
                LiveScriptItem i;

                if (items.TryDequeue(out i))
                {
                    switch (i.Type)
                    {
                        case ListScriptReceiveType.List:
                            ListScripts(i.Target, i.Result);
                            break;

                        case ListScriptReceiveType.Failed:
                            Server.Print("Unable to get the script with path: " + i.Args);
                            break;

                        case ListScriptReceiveType.ReadyLoad:
                            Server.Print("Successfully downloaded from live script: " + i.Args);
                            ScriptManager.Load(i.Args, true);
                            break;
                    }
                }
                else break;
            }
        }

        private static void ListScripts(IUser target, String result)
        {
            if (target != null)
            {
                String[] lines = result.Split(new String[] { "\r\n" }, StringSplitOptions.None);

                foreach (String str in lines)
                    target.Print(str);
            }
        }

        public static void GetDownload(String path)
        {
            String urlZipRelease = "";
            ManualResetEvent threadCompletedEvent = new ManualResetEvent(false);
            Server.Print("Starting download of the script from: "+path);
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    WebRequest request = WebRequest.Create(String.Format("{0}/repos/{1}/releases/latest",liveScriptsEndpoint ,path));
                    request.Headers.Set("Accept", "application/vnd.github+json");
                    request.Headers.Set("X-GitHub-Api-Version", "2022-11-28");
                    request.Headers.Set("User-Agent", "sb0t-server");
                    using (WebResponse response = request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    {
                        List<byte> receiver = new List<byte>();
                        byte[] buf = new byte[1024];
                        int size = 0;

                        while ((size = stream.Read(buf, 0, 1024)) > 0)
                            receiver.AddRange(buf.Take(size));

                        buf = receiver.ToArray();
                        String received = Encoding.Default.GetString(buf);
                        GitHubRelease releaseResponse= JsonConvert.DeserializeObject<GitHubRelease>(received);
                        urlZipRelease= releaseResponse.ZipballUrl;
                    }
                }
                catch
                {

                }
                finally
                {
                    threadCompletedEvent.Set();
                }
            })).Start();
            bool completed = threadCompletedEvent.WaitOne(TimeSpan.FromSeconds(5));
            if (completed)
            {
                if (String.IsNullOrEmpty(urlZipRelease))
                    items.Enqueue(new LiveScriptItem
                    {
                        Type = ListScriptReceiveType.Failed,
                        Args = path
                    });
                else
                {
                    String filename = path.Split('/')[1];
                    Download(urlZipRelease, filename,path);
                }
            }
            else
                items.Enqueue(new LiveScriptItem
                    {
                        Type = ListScriptReceiveType.Failed,
                        Args = path
                    });
        }

        public static void Download(String url,String filename,String pathScript)
        {
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    WebRequest request = WebRequest.Create(url);
                    request.Headers.Set("Accept", "application/vnd.github+json");
                    request.Headers.Set("X-GitHub-Api-Version", "2022-11-28");
                    request.Headers.Set("User-Agent", "sb0t-server");
                    using (WebResponse response = request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    using(ZipArchive zipArchive = new ZipArchive(stream,ZipArchiveMode.Read))
                    {
                        String path = Path.Combine(Server.DataPath, filename);
                            int index = ScriptManager.Scripts.FindIndex(x => x.ScriptName == filename + ".js");
                            if (index > 0)
                            {
                                ScriptManager.Scripts[index].KillScript();
                                ScriptManager.Scripts.RemoveAt(index);
                            }

                            if (Directory.Exists(path + ".js"))
                                Directory.Delete(path + ".js", true);
                        ZipArchiveEntry content = zipArchive.Entries.First();
                        String responsePath = Path.Combine(Server.DataPath, content.FullName.Replace("/",""));
                        zipArchive.ExtractToDirectory(Server.DataPath);
                            Directory.Move(responsePath, path + ".js");
                            items.Enqueue(new LiveScriptItem
                            {
                                Type = ListScriptReceiveType.ReadyLoad,
                                Args = filename + ".js"
                            });                            
                        }   
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    items.Enqueue(new LiveScriptItem
                    {
                        Type = ListScriptReceiveType.Failed,
                        Args = pathScript
                    });
                }
            })).Start();
        }

        public static void LiveScripts(IUser target)
        {
            new Thread(new ThreadStart(() =>
            {
                try
                {
                    WebRequest request = WebRequest.Create(String.Format("{0}/search/repositories?q=topic:areschatscript+is:public", liveScriptsEndpoint));
                    request.Headers.Set("Accept", "application/vnd.github+json");
                    request.Headers.Set("X-GitHub-Api-Version", "2022-11-28");
                    request.Headers.Set("User-Agent","sb0t-server");
                    using (WebResponse response = request.GetResponse())
                    using (Stream stream = response.GetResponseStream())
                    {
                        List<byte> receiver = new List<byte>();
                        byte[] buf = new byte[1024];
                        int size = 0;
                        while ((size = stream.Read(buf, 0, 1024)) > 0)
                            receiver.AddRange(buf.Take(size));

                        buf = receiver.ToArray();
                        String result = Encoding.Default.GetString(buf);
                        GitHubSearchResponse apiResponse = JsonConvert.DeserializeObject<GitHubSearchResponse>(result);
                        if (apiResponse!=null)
                        {
                            if (apiResponse.Items.Count == 0)
                                target.Print("No scripts available");
                            apiResponse.Items.ForEach(x =>
                            {
                                if (!x.IsPrivate)
                                    target.Print(String.Format("\x06Script: \x06{0}  \x06 Author: \x06{1}  \x06Path: \x06{2}  \x06 Description: \x06{3}", x.Name, x.Owner.Login, x.FullName, x.Description));
                            });
                        }
                        else
                            target.Print("Unable to get live scripts list");
                    }
                }
                catch (Exception e)
                {
                    System.Diagnostics.Debug.WriteLine(e);
                    target.Print("Unable to get live scripts list");
                }
            })).Start();
        }
        static string ExtractDomain(string url)
        {
            // Expresión regular para extraer el dominio y el puerto de la URL
            string pattern = @"^(https?://[^/]+)";

            // Crear un objeto Regex
            Regex regex = new Regex(pattern);

            // Utilizar el método Regex.Match para obtener la coincidencia
            Match match = regex.Match(url);

            // Verificar si hay una coincidencia y obtener el valor capturado
            if (match.Success)
            {
                return match.Groups[1].Value;
            }

            return null;
        }
    }

    class LiveScriptItem
    {
        public IUser Target { get; set; }
        public ListScriptReceiveType Type { get; set; }
        public String Result { get; set; }
        public String Args { get; set; }
    }
    enum ListScriptReceiveType
    {
        ReadyLoad,
        Failed,
        List
    }
}

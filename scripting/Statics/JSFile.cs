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
using System.Linq;
using System.Text;
using System.IO;
using Jurassic;
using Jurassic.Library;

namespace scripting.Statics
{
    class JSFile : ObjectInstance
    {
        public JSFile(ScriptEngine engine)
            : base(engine)
        {
            this.PopulateFunctions();

            DefineProperty(Engine.Symbol.ToString(), new PropertyDescriptor("File", PropertyAttributes.Sealed), true);
        }

        private static String[] bad_chars_script = new String[]
        {
            "..",
            "/",
            "\\",
            " ",
        };

        [JSFunction(Name = "load", Flags = JSFunctionFlags.HasEngineParameter, IsWritable = false, IsEnumerable = true)]
        public static String JSLoad(ScriptEngine eng, object a)
        {
            if (a is String || a is ConcatenatedString)
            {
                String filename = a.ToString();

                if (filename.Length > 1 && bad_chars_script.Count<String>(x => filename.Contains(x)) == 0)
                {
                    String path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data", filename);

                    try
                    {
                        // Leer todas las líneas del archivo
                        string[] lines = File.ReadAllLines(path);

                        // Eliminar las líneas en blanco y unir el resultado
                        string contentWithoutBlankLines = string.Join("\n", lines.Where(line => !string.IsNullOrWhiteSpace(line)));
                        return contentWithoutBlankLines;
                    }
                    catch { }
                }
            }

            return null;
        }

        [JSFunction(Name = "exists", Flags = JSFunctionFlags.HasEngineParameter, IsWritable = false, IsEnumerable = true)]
        public static bool JSExists(ScriptEngine eng, object a)
        {
            if (a is String || a is ConcatenatedString)
            {
                String filename = a.ToString();

                if (filename.Length > 1)
                    if (bad_chars_script.Count<String>(x => filename.Contains(x)) == 0)
                    {
                        String path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data", filename);

                        try
                        {
                            return File.Exists(path);
                        }
                        catch { }
                    }
            }

            return false;
        }

        [JSFunction(Name = "save", Flags = JSFunctionFlags.HasEngineParameter, IsWritable = false, IsEnumerable = true)]
        public static bool JSSave(ScriptEngine eng, object a, object b)
        {
            if (!(a is String || a is ConcatenatedString) || !(b is String || b is ConcatenatedString))
                return false;

            String file = a.ToString();
            String content = b.ToString();

            if (file.Length > 1)
                if (bad_chars_script.Count<String>(x => file.Contains(x)) == 0)
                {
                    try
                    {
                        String path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data");

                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data", file);
                        File.WriteAllText(path, content, Encoding.UTF8);
                        return true;
                    }
                    catch { }
                }

            return false;
        }

        [JSFunction(Name = "append", Flags = JSFunctionFlags.HasEngineParameter, IsWritable = false, IsEnumerable = true)]
        public static bool JSAppend(ScriptEngine eng, object a, object b) // file, content
        {
            if (!(a is String || a is ConcatenatedString) || !(b is String || b is ConcatenatedString))
                return false;

            String file = a.ToString();
            String script =  eng.GetGlobalValue("UserData").ToString();
            String content = b.ToString();

            if (file.Length > 1)
                if (bad_chars_script.Count<String>(x => file.Contains(x)) == 0)
                {
                    try
                    {
                        String path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data");

                        if (!Directory.Exists(path))
                            Directory.CreateDirectory(path);

                        path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data", file);

                        using (StreamWriter stream = File.Exists(path) ? File.AppendText(path) : File.CreateText(path))
                            stream.Write(content);

                        return true;
                    }
                    catch { }
                }

            return false;
        }

        [JSFunction(Name = "appendLine", Flags = JSFunctionFlags.HasEngineParameter, IsWritable = false, IsEnumerable = true)]
        public static bool JSAppendLine(ScriptEngine eng, object a, object b)
        {
            if (!(a is String || a is ConcatenatedString) || !(b is String || b is ConcatenatedString))
                return false;

            String file = a.ToString();
            String script = eng.GetGlobalValue("UserData").ToString();
            String content = b.ToString();

            if (file.Length > 1 && bad_chars_script.Count<String>(x => file.Contains(x)) == 0)
            {
                try
                {
                    String path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data");

                    if (!Directory.Exists(path))
                        Directory.CreateDirectory(path);

                    path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data", file);

                    // Agregar el contenido a una nueva línea
                    content = content.TrimEnd('\r', '\n') + "\n";

                    using (StreamWriter stream = File.AppendText(path))
                        stream.Write(content);

                    return true;
                }
                catch { }
            }

            return false;
        }

        [JSFunction(Name = "kill", Flags = JSFunctionFlags.HasEngineParameter, IsWritable = false, IsEnumerable = true)]
        public static bool JDDelete(ScriptEngine eng, object a)
        {
            if (a is String || a is ConcatenatedString)
            {
                String file = a.ToString();
                String script = eng.GetGlobalValue("UserData").ToString();

                if (file.Length > 1)
                    if (bad_chars_script.Count<String>(x => file.Contains(x)) == 0)
                    {
                        String path = Path.Combine(Server.DataPath, eng.GetGlobalValue("UserData").ToString(), "data", file);

                        try
                        {
                            if (File.Exists(path))
                            {
                                File.Delete(path);
                                return true;
                            }
                        }
                        catch { }
                    }
            }

            return false;
        }
    }
}

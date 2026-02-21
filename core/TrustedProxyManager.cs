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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.Win32;

namespace core
{
    public class TrustedProxyManager
    {
        private static readonly string RegistryPath =
            "Software\\sb0t\\" + AppDomain.CurrentDomain.FriendlyName + "\\trusted_proxies";

        public static List<string> GetTrustedProxies()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath))
            {
                if (key == null)
                    return new List<string>();

                string value = key.GetValue("proxy_list") as string;

                if (string.IsNullOrEmpty(value))
                    return new List<string>();

                return value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(x => x.Trim())
                            .Where(x => !string.IsNullOrEmpty(x))
                            .ToList();
            }
        }

        public static void AddTrustedProxy(string ip)
        {
            IPAddress parsed;

            if (!IPAddress.TryParse(ip, out parsed))
                return;

            List<string> proxies = GetTrustedProxies();

            if (!proxies.Contains(parsed.ToString()))
                proxies.Add(parsed.ToString());

            SaveProxyList(proxies);
        }

        public static void RemoveTrustedProxy(string ip)
        {
            List<string> proxies = GetTrustedProxies();
            proxies.Remove(ip);
            SaveProxyList(proxies);
        }

        public static bool IsTrustedProxy(IPAddress ip)
        {
            if (IPAddress.IsLoopback(ip))
                return true;

            string ipStr = ip.ToString();
            return GetTrustedProxies().Contains(ipStr);
        }

        private static void SaveProxyList(List<string> proxies)
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(RegistryPath, true) ??
                                     Registry.CurrentUser.CreateSubKey(RegistryPath))
                key.SetValue("proxy_list", string.Join(",", proxies), RegistryValueKind.String);
        }
    }
}

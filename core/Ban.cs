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
using System.Net;
using iconnect;

namespace core
{
    class Ban : IBan
    {
        public String Name { get; set; }
        public String Version { get; set; }
        public Guid Guid { get; set; }
        public IPAddress ExternalIP { get; set; }
        public IPAddress LocalIP { get; set; }
        public ushort Port { get; set; }
        public ushort Ident { get; set; }

        private bool Unbanned { get; set; }
        
        public void Unban()
        {
            if (!this.Unbanned)
            {
                this.Unbanned = true;
                BanSystem.RemoveBan(this.Ident);
            }
        }
    }
}

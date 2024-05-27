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
using Jurassic;
using Jurassic.Library;
using iconnect;

namespace scripting.Objects
{
    class JSHashlinkResult : ObjectInstance
    {
        internal IHashlinkRoom parent;

        internal JSHashlinkResult(ScriptEngine eng)
            : base(eng)
        {
            this.PopulateFunctions();

            DefineProperty(Engine.Symbol.ToString(), new PropertyDescriptor("HashlinkResult", PropertyAttributes.Sealed), true);
        }

        public JSHashlinkResult(ObjectInstance prototype, IHashlinkRoom obj)
            : base(prototype.Engine, ((ClrFunction)prototype.Engine.Global["HashlinkResult"]).InstancePrototype)
        {
            this.PopulateFunctions();
            this.parent = obj;
        }

        [JSProperty(Name = "name")]
        public String Name
        {
            get { return this.parent.Name; }
            set { }
        }

        [JSProperty(Name = "ip")]
        public String ExternalIP
        {
            get { return this.parent.IP.ToString(); }
            set { }
        }

        [JSProperty(Name = "port")]
        public int Port
        {
            get { return this.parent.Port; }
            set { }
        }
    }
}

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
using iconnect;

namespace core.Extensions
{
    class ExSpelling : ISpell
    {
        public String Check(String text)
        {
            return SpellCheck.Correct(text);
        }

        public String[] Suggest(String text)
        {
            return SpellCheck.Suggest(text);
        }

        public bool Confirm(String text)
        {
            return SpellCheck.Confirm(text);
        }
    }
}

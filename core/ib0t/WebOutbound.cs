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

namespace core.ib0t
{
    class WebOutbound
    {
        public static byte[] AckTo(ib0tClient userobj, String name)
        {
            return WebSockets.Html5TextPacket("ACK:" + name.Length + ":" + name, userobj.WebCredentials.OldProto);
        }
        public static byte[] ServerInfo(ib0tClient userobj)
        {
            return WebSockets.Html5TextPacket("SERVER_INFO:1:I" , userobj.WebCredentials.OldProto);
        }
        public static byte[] BuzzTo(ib0tClient userobj,String target)
        {
            return WebSockets.Html5TextPacket("BUZZ:"+ target.Length+":"+ target, userobj.WebCredentials.OldProto);
        }
        public static byte[] PrivateTo(ib0tClient userobj, String name, String text)
        {
            return WebSockets.Html5TextPacket("PM:" + name.Length + "," + text.Length + ":" + name + text, userobj.WebCredentials.OldProto);
        }

        public static byte[] OfflineTo(ib0tClient userobj, String name)
        {
            return WebSockets.Html5TextPacket("OFFLINE:" + name.Length + ":" + name, userobj.WebCredentials.OldProto);
        }

        public static byte[] IgnoringTo(ib0tClient userobj, String name)
        {
            return WebSockets.Html5TextPacket("IGNORING:" + name.Length + ":" + name, userobj.WebCredentials.OldProto);
        }

        public static byte[] PersMsgTo(ib0tClient userobj, String name, String text)
        {
            return WebSockets.Html5TextPacket("PERSMSG:" + name.Length + "," + text.Length + ":" + name + text, userobj.WebCredentials.OldProto);
        }

        public static byte[] LagTo(ib0tClient userobj, String args)
        {
            return WebSockets.Html5TextPacket("LAG:" + args.Length + ":" + args, userobj.WebCredentials.OldProto);
        }
        public static byte[] ScribbleGifTo(ib0tClient userobj,String sender, String args)
        {
            return WebSockets.Html5TextPacket("SCRIBBLE_GIF:" + sender.Length + "," + args.Length+
                                                                            ":" + sender + args,
                                                                            userobj.WebCredentials.OldProto);
        }
        public static byte[] PerMsgBotTo(ib0tClient userobj)
        {
            String name = Settings.Get<String>("bot");
            String text = Settings.VERSION;
            return WebSockets.Html5TextPacket("PERSMSG:" + name.Length + "," + text.Length + ":" + name + text, userobj.WebCredentials.OldProto);
        }

        public static byte[] AvatarTo(ib0tClient userobj, String name, byte[] av)
        {
            String str = "AVATAR:";
            String avstr = Convert.ToBase64String(av);
            str += name.Length + "," + avstr.Length + ":";
            str += name + avstr;
            byte[] packet = WebSockets.Html5TextPacket(str, userobj.WebCredentials.OldProto);
            return packet;
        }

        public static byte[] AvatarClearTo(ib0tClient userobj, String name)
        {
                return WebSockets.Html5TextPacket("AVATAR:" + name.Length + ":" + name, userobj.WebCredentials.OldProto);
        }
        public static byte[] PublicTo(ib0tClient userobj, String name, String text)
        {
            String str = text;

            if (str.Length > 300)
                str = str.Substring(0, 300);

            return WebSockets.Html5TextPacket("PUBLIC:" + name.Length + "," + str.Length + ":" + name + str, userobj.WebCredentials.OldProto);
        }

        public static byte[] EmoteTo(ib0tClient userobj, String name, String text)
        {
            String str = text;

            if (str.Length > 300)
                str = str.Substring(0, 300);

            return WebSockets.Html5TextPacket("EMOTE:" + name.Length + "," + str.Length + ":" + name + str, userobj.WebCredentials.OldProto);
        }

        public static byte[] NoSuchTo(ib0tClient userobj, String text)
        {
            String str = text;

            if (str.Length > 300)
                str = str.Substring(0, 300);

            return WebSockets.Html5TextPacket("NOSUCH:" + str.Length + ":" + str, userobj.WebCredentials.OldProto);
        }

        public static byte[] ScribbleHead(ib0tClient userobj, String sender, int count, String height)
        {
            return WebSockets.Html5TextPacket("SCRIBBLE_HEAD:" + sender.Length + "," +
                                                                 count.ToString().Length + "," +
                                                                 height.Length +
                                                                 ":" + sender + count + height,
                                                                 userobj.WebCredentials.OldProto);
        }
        public static byte[] ScribbleHead(ib0tClient userobj, String sender, int count)
        {
            return WebSockets.Html5TextPacket("SCRIBBLE_HEAD:" + sender.Length + "," +
                                                                 count.ToString().Length +
                                                                 ":" + sender + count,
                                                                 userobj.WebCredentials.OldProto);
        }
        public static byte[] ScribbleSourceHead(ib0tClient userobj, String sender, int count)
        {
            return WebSockets.Html5TextPacket("SCRIBBLESOURCE_HEAD:" + sender.Length + "," +
                                                                 count.ToString().Length +
                                                                 ":" + sender + count,
                                                                 userobj.WebCredentials.OldProto);
        }
        public static byte[] ScribbleBlock(ib0tClient userobj, String text)
        {
            return WebSockets.Html5TextPacket("SCRIBBLE_BLOCK:" + text.Length + ":" + text, userobj.WebCredentials.OldProto);
        }
        public static byte[] ScribbleSourceBlock(ib0tClient userobj, String text)
        {
            return WebSockets.Html5TextPacket("SCRIBBLESOURCE_BLOCK:" + text.Length + ":" + text, userobj.WebCredentials.OldProto);
        }
        public static byte[] AudioHead(ib0tClient userobj, String sender, int count)
        {
            return WebSockets.Html5TextPacket("AUDIO_HEAD:" + sender.Length + "," +
                                                                 count.ToString().Length +
                                                                 ":" + sender + count,
                                                                 userobj.WebCredentials.OldProto);
        }
        public static byte[] AudioBlock(ib0tClient userobj, String text)
        {
            return WebSockets.Html5TextPacket("AUDIO_BLOCK:" + text.Length + ":" + text, userobj.WebCredentials.OldProto);
        }
        public static byte[] UpdateTo(ib0tClient userobj, String name, ILevel level)
        {
            return WebSockets.Html5TextPacket("UPDATE:" + name.Length + ",1:" + name + ((byte)level), userobj.WebCredentials.OldProto);
        }
        public static byte[] UpdateCustomNameTo(ib0tClient userobj)
        {
            return WebSockets.Html5TextPacket("UPDATECUSTOMNAME:" + userobj.Name.Length+","+userobj.CustomName.Length + ":" + userobj.Name + userobj.CustomName, userobj.WebCredentials.OldProto);
        }

        public static byte[] UserInfoTo(ib0tClient userobj)
        {
            String avstr = Convert.ToBase64String(userobj.FullAvatar);
            String isinbizierweb = userobj.IsInbizierWeb ? "1" : "0";
            String isinbiziermobile = userobj.IsInbizierMobile ? "1" : "0";
            return WebSockets.Html5TextPacket("USERINFO:" + userobj.Name.Length + "," + userobj.PersonalMessage.Length + "," + avstr.Length + ","+userobj.ID.ToString().Length + ",1,1,1:" + userobj.Name + userobj.PersonalMessage + avstr + userobj.ID + (byte)userobj.Level + isinbizierweb + isinbiziermobile, userobj.WebCredentials.OldProto);
        }
        public static byte[] UserInfoTo(core.LinkLeaf.LinkUser userobj)
        {
            String avstr = Convert.ToBase64String(userobj.FullAvatar);
            String isinbizierweb = userobj.IsInbizierWeb ? "1" : "0";
            String isinbiziermobile = userobj.IsInbizierMobile ? "1" : "0";
            return WebSockets.Html5TextPacket("USERINFO:" + userobj.Name.Length + "," + userobj.PersonalMessage.Length + "," + avstr.Length + "," + userobj.ID.ToString().Length + ",1,1,1:" + userobj.Name + userobj.PersonalMessage + avstr + userobj.ID + (byte)userobj.Level + isinbizierweb + isinbiziermobile, false);
        }
        public static byte[] UserInfoTo(AresClient userobj,bool oldproto)
        {
            String avstr = Convert.ToBase64String(userobj.Avatar);
            String isinbizierweb = userobj.IsInbizierWeb ? "1" : "0";
            String isinbiziermobile = userobj.IsInbizierMobile ? "1" : "0";
            return WebSockets.Html5TextPacket("USERINFO:" + userobj.Name.Length + "," + userobj.PersonalMessage.Length + "," + avstr.Length + "," + userobj.ID.ToString().Length + ",1,1,1:" + userobj.Name + userobj.PersonalMessage + avstr + userobj.ID + (byte)userobj.Level+isinbizierweb+isinbiziermobile,oldproto);
        }
        public static byte[] UserInfoTo(ib0tClient userobj, String name, ILevel level, bool botHasAvatar)
        {
            String permsgBot = Settings.VERSION;
            String avatarBot = "";
            if (botHasAvatar)
            {
                avatarBot = Convert.ToBase64String(Avatars.GetServerAvatar());
            }
            return WebSockets.Html5TextPacket("USERINFO:" + name.Length +","+permsgBot.Length+","+avatarBot.Length +",1,1,1,1:" + name + permsgBot+avatarBot+ "0"+(byte)level  + "0"+"0", userobj.WebCredentials.OldProto);
        }
        public static byte[] JoinInfoTo(ib0tClient userobj)
        {
            String avstr = Convert.ToBase64String(userobj.FullAvatar);
            String isinbizierweb = userobj.IsInbizierWeb ? "1" : "0";
            String isinbiziermobile = userobj.IsInbizierMobile ? "1" : "0";
            return WebSockets.Html5TextPacket("JOININFO:" + userobj.Name.Length + "," + userobj.PersonalMessage.Length + "," + avstr.Length + ","  + userobj.ID.ToString().Length + ",1,1,1:" + userobj.Name + userobj.PersonalMessage + avstr + userobj.ID + (byte)userobj.Level+isinbizierweb+isinbiziermobile, userobj.WebCredentials.OldProto);
        }
        public static byte[] JoinInfoTo(AresClient userobj, bool oldproto)
        {
            String avstr = Convert.ToBase64String(userobj.Avatar);
            String isinbizierweb = userobj.IsInbizierWeb ? "1" : "0";
            String isinbiziermobile = userobj.IsInbizierMobile ? "1" : "0";
            return WebSockets.Html5TextPacket("JOININFO:" + userobj.Name.Length + "," + userobj.PersonalMessage.Length + "," + avstr.Length + ","  + userobj.ID.ToString().Length + ",1,1,1:" + userobj.Name + userobj.PersonalMessage + avstr + userobj.ID + (byte)userobj.Level+isinbizierweb+isinbiziermobile, oldproto);
        }
        public static byte[] UserlistItemTo(ib0tClient userobj, String name, ILevel level)
        {
            return WebSockets.Html5TextPacket("USERLIST:" + name.Length + ",1:" + name + ((byte)level), userobj.WebCredentials.OldProto);
        }
        public static byte[] UserlistItemTo(AresClient userobj, String name, ILevel level,bool oldproto)
        {
            return WebSockets.Html5TextPacket("USERLIST:" + name.Length + ",1:" + name + ((byte)level), oldproto);
        }
        public static byte[] UserlistEndTo(ib0tClient userobj)
        {
            return WebSockets.Html5TextPacket("USERLIST_END:", userobj.WebCredentials.OldProto);
        }

        public static byte[] JoinTo(ib0tClient userobj, String name, ILevel level)
        {
            return WebSockets.Html5TextPacket("JOIN:" + name.Length + ",1:" + name + ((byte)level), userobj.WebCredentials.OldProto);
        }

        public static byte[] PartTo(ib0tClient userobj, String name)
        {
            return WebSockets.Html5TextPacket("PART:" + name.Length + ":" + name, userobj.WebCredentials.OldProto);
        }

        public static byte[] FontTo(ib0tClient userobj, String name, int col1, int col2)
        {
            return WebSockets.Html5TextPacket("FONT:" + name.Length + "," + col1.ToString().Length + "," + col2.ToString().Length + ":" + name + col1.ToString() + col2.ToString(), userobj.WebCredentials.OldProto);
        }

        public static byte[] UrlTo(ib0tClient userobj, String addr, String tag)
        {
            return WebSockets.Html5TextPacket("URL:" + addr.Length + "," + tag.Length + ":" + addr + tag, userobj.WebCredentials.OldProto);
        }

        public static byte[] TopicTo(ib0tClient userobj, String text)
        {
            return WebSockets.Html5TextPacket("TOPIC:" + text.Length + ":" + text, userobj.WebCredentials.OldProto);
        }

        public static byte[] TopicFirstTo(ib0tClient userobj, String text)
        {
            return WebSockets.Html5TextPacket("TOPIC_FIRST:" + text.Length + ":" + text, userobj.WebCredentials.OldProto);
        }
    }
}

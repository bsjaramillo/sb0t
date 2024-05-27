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
using System.Text;
using System.Reflection;
using Jurassic;
using Jurassic.Library;
using iconnect;
using scripting.ObjectPrototypes;
using scripting.Statics;
using scripting.Instances;
using Jurassic.Compiler;

namespace scripting
{
    class JSScript
    {
        public String ScriptName { get; private set; }
        public ScriptEngine JS { get; private set; }
        public List<Objects.JSUser> local_users = new List<Objects.JSUser>();
        public List<Objects.JSLeaf> leaves = new List<Objects.JSLeaf>();
        public List<ulong> timer_idents = new List<ulong>();
        private void SetJSGlobalValues()
        {
            this.JS.SetGlobalValue("Base64", new JSBase64(this.JS));
            this.JS.SetGlobalValue("Channels", new JSChannels(this.JS));
            this.JS.SetGlobalValue("Crypto", new JSCrypto(this.JS));
            this.JS.SetGlobalValue("Entities", new JSEntities(this.JS));
            this.JS.SetGlobalValue("File", new JSFile(this.JS));
            this.JS.SetGlobalValue("Hashlink", new JSHashlink(this.JS));
            this.JS.SetGlobalValue("Link", new JSLink(this.JS));
            this.JS.SetGlobalValue("Registry", new JSRegistry(this.JS));
            this.JS.SetGlobalValue("Room", new JSRoom(this.JS));
            this.JS.SetGlobalValue("ScriptInclude", new JSScriptInclude(this.JS));
            this.JS.SetGlobalValue("Spelling", new JSSpelling(this.JS));
            this.JS.SetGlobalValue("Stats", new JSStats(this.JS));
            this.JS.SetGlobalValue("Users", new JSUsers(this.JS));
            this.JS.SetGlobalValue("Zip", new JSZip(this.JS));
            this.JS.SetGlobalValue("Avatar", new JSAvatar(this.JS));
            this.JS.SetGlobalValue("HttpRequest", new JSHttpRequest(this.JS));
            this.JS.SetGlobalValue("List", new JSList(this.JS));
            this.JS.SetGlobalValue("ProxyCheck", new JSProxyCheck(this.JS));
            this.JS.SetGlobalValue("Query", new JSQuery(this.JS));
            this.JS.SetGlobalValue("Scribble", new JSScribble(this.JS));
            this.JS.SetGlobalValue("Sql", new JSSql(this.JS));
            this.JS.SetGlobalValue("Timer", new JSTimer(this.JS));
            this.JS.SetGlobalValue("XmlParser", new JSXmlParser(this.JS));
            this.JS.SetGlobalValue("AvatarImage", new JSAvatarImage(this.JS));
            this.JS.SetGlobalValue("BannedUser", new JSBannedUser(this.JS));
            this.JS.SetGlobalValue("Channel", new JSChannel(this.JS));
            this.JS.SetGlobalValue("ChannelCollection", new JSChannelCollection(this.JS));
            this.JS.SetGlobalValue("CryptoResult", new JSCryptoResult(this.JS));
            this.JS.SetGlobalValue("HashlinkResult", new JSHashlinkResult(this.JS));
            this.JS.SetGlobalValue("HttpRequestResult", new JSHttpRequestResult(this.JS));
            this.JS.SetGlobalValue("IgnoreCollection", new JSIgnoreCollection(this.JS));
            this.JS.SetGlobalValue("Leaf", new JSLeaf(this.JS));
            this.JS.SetGlobalValue("Node", new JSNode(this.JS));
            this.JS.SetGlobalValue("NodeAttributes", new JSNodeAttributes(this.JS));
            this.JS.SetGlobalValue("NodeCollection", new JSNodeCollection(this.JS));
            this.JS.SetGlobalValue("PM", new JSPM(this.JS));
            this.JS.SetGlobalValue("ProxyCheckResult", new JSProxyCheckResult(this.JS));
            this.JS.SetGlobalValue("Record", new JSRecord(this.JS));
            this.JS.SetGlobalValue("RegistryKeyCollection", new JSRegistryKeyCollection(this.JS));
            this.JS.SetGlobalValue("ScribbleImage", new JSScribbleImage(this.JS));
            this.JS.SetGlobalValue("SpellingSuggestionCollection", new JSSpellingSuggestionCollection(this.JS));
            this.JS.SetGlobalValue("User", new JSUser(this.JS));
            this.JS.SetGlobalValue("UserFont", new JSUserFont(this.JS));
        }

        private void SetJSGlobalFunctions()
        {
            JSGlobal.eng = this.JS;
            this.JS.SetGlobalFunction("tickCount", JSGlobal.TickCount);
            this.JS.SetGlobalFunction("escapeUtf", JSGlobal.EscapeUTF);
            this.JS.SetGlobalFunction("scriptName", JSGlobal.ScriptName);
            this.JS.SetGlobalFunction("include", JSGlobal.Include);
            this.JS.SetGlobalFunction("includeAll", JSGlobal.IncludeAll);
            this.JS.SetGlobalFunction("byteLength", JSGlobal.ByteLength);
            this.JS.SetGlobalFunction("print", JSGlobal.Print);
            this.JS.SetGlobalFunction("clrName", JSGlobal.ClrName);
            this.JS.SetGlobalFunction("user", JSGlobal.User);
            this.JS.SetGlobalFunction("sendPM", JSGlobal.SendPM);
            this.JS.SetGlobalFunction("sendText", JSGlobal.SendText);
            this.JS.SetGlobalFunction("sendEmote", JSGlobal.SendEmote);
            this.JS.SetGlobalFunction("stripColors", JSGlobal.StripColors);
        }

        public JSScript(String name)
        {
            this.ScriptName = name;
            this.JS = new ScriptEngine();
            this.JS.SetGlobalValue("UserData", name);
            //this.JS.UserData = name;
            //this.JS.EnableDebugging = true;
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            this.SetJSGlobalFunctions();
            this.SetJSGlobalValues();
            // set up default events
            StringBuilder events = new StringBuilder();
            events.AppendLine("function onScribbleCheck(userobj, isPM) { return true }");
            events.AppendLine("function onTextReceived(userobj, text) { }");
            events.AppendLine("function onTextBefore(userobj, text) { return text; }");
            events.AppendLine("function onTextAfter(userobj, text) { }");
            events.AppendLine("function onEmoteReceived(userobj, text) { }");
            events.AppendLine("function onEmoteBefore(userobj, text) { return text; }");
            events.AppendLine("function onEmoteAfter(userobj, text) { }");
            events.AppendLine("function onJoinCheck(userobj) { return true; }");
            events.AppendLine("function onJoin(userobj) { }");
            events.AppendLine("function onPartBefore(userobj) { }");
            events.AppendLine("function onPart(userobj) { }");
            events.AppendLine("function onTimer() { }");
            events.AppendLine("function onHelp(userobj) { }");
            events.AppendLine("function onCommand(userobj, command, target, args) { }");
            events.AppendLine("function onCommand(userobj, command, args) { }");
            events.AppendLine("function onAvatar(userobj) { return true; }");
            events.AppendLine("function onPersonalMessage(userobj, msg) { return true; }");
            events.AppendLine("function onRejected(userobj) { }");
            events.AppendLine("function onLoad() { }");
            events.AppendLine("function onVroomJoinCheck(userobj, vroom) { return true; }");
            events.AppendLine("function onVroomJoin(userobj) { }");
            events.AppendLine("function onFileReceived(userobj, filename) { }");
            events.AppendLine("function onFloodBefore(userobj, msg) { return true; }");
            events.AppendLine("function onFlood(userobj) { }");
            events.AppendLine("function onBotPM(userobj, text) { return true; }");
            events.AppendLine("function onPMBefore(userobj, target, pm) { return true; }");
            events.AppendLine("function onPM(userobj, target) { }");
            events.AppendLine("function onNick(userobj, name) { return true; }");
            events.AppendLine("function onIgnoring(userobj, target) { return true; }");
            events.AppendLine("function onIgnoredStateChanged(userobj, target, ignored) { }");
            events.AppendLine("function onInvalidLoginAttempt(userobj) { }");
            events.AppendLine("function onLoginGranted(userobj) { }");
            events.AppendLine("function onAdminLevelChanged(userobj) { }");
            events.AppendLine("function onRegistering(userobj) { return true; }");
            events.AppendLine("function onRegistered(userobj) { }");
            events.AppendLine("function onUnregistered(userobj) { }");
            events.AppendLine("function onProxyDetected(userobj, reply) { return false; }"); // false by default instead of true (the built in proxy check kinda...is bad)
            events.AppendLine("function onLogout(userobj) { }");
            events.AppendLine("function onIdled(userobj) { }");
            events.AppendLine("function onUnidled(userobj, seconds) { }");
            events.AppendLine("function onBansAutoCleared() { }");
            events.AppendLine("function onLinkError(msg) { }");
            events.AppendLine("function onLinked() { }");
            events.AppendLine("function onUnlinked() { }");
            events.AppendLine("function onLeafJoin(leaf) { }");
            events.AppendLine("function onLeafPart(leaf) { }");
            events.AppendLine("function onLinkedAdminDisabled(leaf, userobj) { }");
            this.JS.Evaluate(events.ToString());
        }

        public Objects.JSUser GetUser(IUser client)
        {
            if (client == null)
                return null;

            Objects.JSUser result = null;

            if (!client.Link.IsLinked)
                result = this.local_users.Find(x => x.Name == client.Name);
            else
                this.leaves.ForEach(x =>
                {
                    if (x.Ident == client.Link.Ident)
                    {
                        result = x.users.Find(z => z.Name == client.Name);

                        if (result != null)
                            return;
                    }
                });

            return result;
        }

        public Objects.JSUser GetIgnoredUser(String name)
        {
            Objects.JSUser result = this.local_users.Find(x => x.Name == name);

            if (result == null)
                this.leaves.ForEach(x =>
                {
                    result = x.users.Find(z => z.Name == name);

                    if (result != null)
                        return;
                });

            return result;
        }

        public bool LoadScript(String path)
        {
            Server.Users.Ares(x => this.local_users.Add(new Objects.JSUser(this.JS.Object.InstancePrototype, x, this.ScriptName)));
            Server.Users.Web(x => this.local_users.Add(new Objects.JSUser(this.JS.Object.InstancePrototype, x, this.ScriptName)));

            if (Server.Link.IsLinked)
            {
                Server.Link.ForEachLeaf(x =>
                {
                    this.leaves.Add(new Objects.JSLeaf(this.JS.Object.InstancePrototype, x, this.ScriptName));

                    x.ForEachUser(z => this.leaves[this.leaves.Count - 1].users.Add(
                        new Objects.JSUser(this.JS.Object.InstancePrototype, z, this.ScriptName)));
                });
            }

            try
            {
                this.JS.ExecuteFile(path);
                return true;
            }
            catch (JavaScriptException e)
            {
                Server.Print(String.Format("Unable to load script {0} \x06{1} - LineReference: {2}", this.ScriptName, e.Message, e.LineNumber));
                ErrorDispatcher.SendError(this.ScriptName, e.Message, e.LineNumber);
            }
            catch (SyntaxErrorException e)
            {
                Server.Print(String.Format("Unable to load script {0} \x06{1} - LineReference: {2}", this.ScriptName, e.Message, e.LineNumber));
                ErrorDispatcher.SendError(this.ScriptName, e.Message, e.LineNumber);
            }
            catch { }

            return false;
        }

        public void KillScript()
        {
            this.local_users.Clear();
            this.leaves.ForEach(x => x.users.Clear());
            this.leaves.Clear();
            this.JS = null;
            ScriptManager.RemoveCallbacks(this.ScriptName);
            this.timer_idents.Clear();
            TimerList.RemoveScriptTimers(this.ScriptName);
        }
    }
}
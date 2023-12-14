# +Events List+


+**Function signatures and comments**+

```javascript
// fires when text is received (unaltered)
function onTextReceived(userobj, text) { }

// fires before text is shown
function onTextBefore(userobj, text) { return text; }

// fires after text is shown
function onTextAfter(userobj, text) { }

// fires when emote text is received (unaltered)
function onEmoteReceived(userobj, text) { }

// fires before emote text is shown
function onEmoteBefore(userobj, text) { return text; }

// fires after emote text is shown
function onEmoteAfter(userobj, text) { }

// fires before a user is allowed to join
function onJoinCheck(userobj) { return true; }

// fires after a user has joined
function onJoin(userobj) { }

// fires before a user has parted
function onPartBefore(userobj) { }

// fires after a user has parted
function onPart(userobj) { }

// fires every 1 second
function onTimer() { }

// fires when #help is used
function onHelp(userobj) { }

// fires when text starts with / or #
function onCommand(userobj, command, target, args) { }

// fires when an avatar is uploaded
function onAvatar(userobj) { return true; }

// fires when a personal message is uploaded
function onPersonalMessage(userobj, msg) { return true; }

// fires when a user was unable to join
function onRejected(userobj) { }

// fires when the script has loaded
function onLoad() { }

// fires before a user changes vroom
function onVroomJoinCheck(userobj, vroom) { return true; }

// fires after a user has changed vroom
function onVroomJoin(userobj) { }

// fires when a browse item is uploaded
function onFileReceived(userobj, filename) { }

// fires before a user floods out
function onFloodBefore(userobj, msg) { return true; }

// fires after a user floods out
function onFlood(userobj) { }

// fires when the bot name is pm'ed
function onBotPM(userobj, text) { return true; }

// fires before a pm is shown
function onPMBefore(userobj, target, pm) { return true; }

// fires after a pm is shown
function onPM(userobj, target) { }

// fires before the /nick command has completed
function onNick(userobj, name) { return true; }

// fires before a user has ignored someone
function onIgnoring(userobj, target) { return true; }

// fires after a user has ignored or unignored someone
function onIgnoredStateChanged(userobj, target, ignored) { }

// fires after a user tries to use an invalid password
function onInvalidLoginAttempt(userobj) { }

// fires after a user has logged in
function onLoginGranted(userobj) { }

// fires after a user's admin level has changed
function onAdminLevelChanged(userobj) { }

// fires before the /register command has completed
function onRegistering(userobj) { return true; }

// fires after the /register command has completed
function onRegistered(userobj) { }

// fires after the /unregister command has completed
function onUnregistered(userobj) { }

// fires before a user is disconnected for using a proxy
function onProxyDetected(userobj, reply) { return true; }

// fires after the /logout command has completed
function onLogout(userobj) { }

// fires after a user has idled
function onIdled(userobj) { }

// fires after a user has unidled
function onUnidled(userobj, seconds) { }

// fires after the auto clear bans has happened
function onBansAutoCleared() { }

// fires when a link error occurs
function onLinkError(msg) { }

// fires when the room connects to a hub
function onLinked() { }

// fires when the room disconnects from a hub
function onUnlinked() { }

// fires when another room has connected to the same hub as you
function onLeafJoin(leaf) { }

// fires when another room has disconnected from the same hub as you
function onLeafPart(leaf) { }

// fires when your admin command was refused
function onLinkedAdminDisabled(leaf, userobj) { }
```
# +Global+


+**include**+

**Type:** Function
**Return:** void
**Description:** Load a subscript into the current script

```javascript
print("loading script.js...");
include("script.js");
```

+**includeAll**+

**Type:** Function
**Return:** void
**Description:** Include all files with a .js extension in the script's folder

```javascript
print("loading all subscripts...");
includeAll();
```

+**print**+

**Type:** Function
**Return:** void
**Description:** send red text announcement to a target user or broadcast

```javascript
// to all users
print("hello");

// to a vroom (eg. vroom 0)
print(0, "hello");

// to a target user
print(user(0), "hello");
```

+**scriptName**+

**Type:** Function
**Return:** string
**Description:** The name of the script that called this function

```javascript
print("this script is called " + scriptName());
```

+**sendEmote**+

**Type:** Function
**Return:** void
**Description:** Send an emote message to a target user

```javascript
var target = user(0);
var sender = Room.botName;
var text = "hello";
sendEmote(target, sender, text);
```

+**sendPM**+

**Type:** Function
**Return:** void
**Description:** Send a private message to a target user

```javascript
var target = user(0);
var sender = Room.botName;
var text = "hello";
sendPM(target, sender, text);
```

+**sendText**+

**Type:** Function
**Return:** void
**Description:** Send a public message to a target user

```javascript
var target = user(0);
var sender = Room.botName;
var text = "hello";
sendText(target, sender, text);
```

+**tickCount**+

**Type:** Function
**Return:** double
**Description:** An accurate representation of the number of milliseconds which have passed since the server session began

```javascript
var ticks = tickCount();
```

+**user**+

**Type:** Function
**Return:** User
**Description:** Find a user by name or id

```javascript
// find user by id
var u = user(0);

// find user by name or name substring
var u = user("anon");
```
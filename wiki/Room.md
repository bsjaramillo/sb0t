# +Room+


+**botName**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the username of the bot

```javascript
print("bot is called " + Room.botName);
```

+**clearUrl**+

**Type:** Function
**Return:** void
**Description:** Clear the url tag

```javascript
Room.clearUrl();
```

+**customNames**+

**Type:** Property (read/write)
**Return:** bool
**Description:** Get or set whether or not users can have custom names

```javascript
if (!Room.customNames)
{
    Room.customNames = true;
    print("custom names are now available");
}
```

+**externalIp**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the room's ip address

```javascript
print("room ip: " + Room.externalIp);
```

+**hashlink**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the room's hashlink

```javascript
print("room hashlink: " + Room.hashlink);
```

+**name**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the room's name

```javascript
print("room name: " + Room.name);
```

+**port**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the room's port

```javascript
print("room port: " + Room.port);
```

+**setUrl**+

**Type:** Function
**Return:** void
**Description:** Set the url tag

```javascript
var address = "http://codeplex.com";
var text = "codeplex";
Room.setUrl(address, text);
```

+**startTime**+

**Type:** Property (read only)
**Return:** double
**Description:** Get the room's start time

```javascript
print("room started at " + new Date(Room.startTime * 1000));
```

+**topic**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the main room topic

```javascript
Room.topic = "hello world";
print("room topic: " + Room.topic);
```

+**version**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the script model version for this server

```javascript
print("Object model: " + Room.version);
```
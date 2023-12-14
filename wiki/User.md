# +User+


+**age**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the user's age

+**avatar**+

**Type:** Property (read/write)
**Return:** AvatarImage
**Description:** Get or set the user's avatar

```javascript
// disable avatar
user(0).avatar = null;
```

+**ban**+

**Type:** Function
**Return:** void
**Description:** Ban user from chatroom

```javascript
user(0).ban();
```

+**browsable**+

**Type:** Property (read only)
**Return:** bool
**Description:** Get the user's browse status

+**captcha**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's completed captcha status

+**cloaked**+

**Type:** Propert (read/write)
**Return:** bool
**Description:** Get or set whether this user is visible in the user list (disabled in link mode)

+**country**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's country

+**customClient**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if user is not using official Ares

+**customName**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the user's custom name

+**disconnect**+

**Type:** Function
**Return:** void
**Description:** Disconnect user from chatroom

```javascript
user(0).disconnect();
```

+**dns**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's DNS value

+**externalIp**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's external IP address

+**fastPing**+

**Type:** Property (read only)
**Return:** bool
**Description:** Get the user's Fast Ping protocol usage status

+**fileCount**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the user's file count

+**font**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the name of the user's custom font being used

+**gender**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's gender

+**ghost**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if user's join message was suppressed due to bouncing

+**guid**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's guid

+**id**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the user's ID (always -1 for linked users)

+**idle**+

**Type:** Property (read only)
**Return:** bool
**Description:** Get the user's idle status

+**ignores**+

**Type:** Property (read only)
**Return:** IgnoreCollection
**Description:** Get a collection of user objects being ignored by this user

+**joinTime**+

**Type:** Property (read only)
**Return:** double
**Description:** Get the time the user joined expressed as a unix timestamp

+**leaf**+

**Type:** Property (read only)
**Return:** Leaf
**Description:** Get the leaf associated with the user (linked users only)

+**level**+

**Type:** Property (read/write)
**Return:** int
**Description:** Get the user's admin level

+**linked**+

**Type:** Property (read only)
**Return:** bool
**Description:** Get the user's link status

+**localIp**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's local IP address

+**muzzled**+

**Type:** Property (read/write)
**Return:** bool
**Description:** Get or set the user's muzzled status

+**name**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the user's name

+**nudge**+

**Type:** Function
**Return:** void
**Description:** Nudge user (requires cb0t)

```javascript
user(0).nudge(); // sent from bot name
user(0).nudge(userobj.name); // sent from my name
```

+**orgName**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's original name when they joined

+**owner**+

**Type:** Property (read only)
**Return:** bool
**Description:** Return true if user is local host or used the owner password

+**personalMessage**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the user's personal message

+**port**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the user's port

+**redirect**+

**Type:** Function
**Return:** void
**Description:** Redirect user to a different chatroom

```javascript
user(0).redirect("arlnk://F5fPxdTq8eJeuqSVejGmq4b70iWKGh24K0yiPJVOpciNTNcRlHn6+Hj0bfk=");
```

+**region**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's regional location

+**registered**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if user has logged in

+**restoreAvatar**+

**Type:** Function
**Return:** void
**Description:** Restore user's avatar to original state

```javascript
user(0).avatar = null; // delete user's avatar
user(0).restoreAvatar(); // restore user's avatar
```

+**scribble**+

**Type:** Function
**Return:** void
**Description:** Send a scribble to this user (requires cb0t)

```javascript
var scribble = userobj.avatar.toScribble();
user(0).scribble(scribble); // sent from bot name
user(0).scribble(userobj.name, scribble); // sent from my name
```

+**sendEmote**+

**Type:** Function
**Return:** void
**Description:** Clone user with emote text

```javascript
user(0).sendEmote("hello world");
```

+**sendText**+

**Type:** Function
**Return:** void
**Description:** Clone user with regular text

```javascript
user(0).sendText("hello world");
```

+**setTopic**+

**Type:** Function
**Return:** void
**Description:** Set a personal topic for this user

```javascript
user(0).setTopic("this topic is just for " + user(0).name + " :)");
```

+**setUrl**+

**Type:** Function
**Return:** void
**Description:** Set a personal URL tag for this user

```javascript
user(0).setUrl("http://sb0t5.codeplex.com/", "a tag just for " + user(0).name);
```

+**version**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user's client version

+**visible**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if the user is visible on the user list

+**vroom**+

**Type:** Property (read/write)
**Return:** int
**Description:** Get or set the user's current vroom

+**webClient**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if the user is using ib0t
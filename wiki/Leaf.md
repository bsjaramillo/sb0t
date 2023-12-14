# +Leaf+


+**externalIp**+

**Type:** Property (read only)
**Return:** string
**Description:** The external ip address of this link leaf

```javascript
var leaf = Link.leaf("test");
print("leaf ip: " + leaf.externalIp);
```

+**hashlink**+

**Type:** Property (read only)
**Return:** string
**Description:** The hashlink of this link leaf

```javascript
var leaf = Link.leaf("test");
print("leaf hashlink: " + leaf.hashlink);
```

+**name**+

**Type:** Property (read only)
**Return:** string
**Description:** The name of this link leaf

```javascript
var leaf = Link.leaf("test");
print("leaf name: " + leaf.name);
```

+**port**+

**Type:** Property (read only)
**Return:** int
**Description:** The port of this link leaf

```javascript
var leaf = Link.leaf("test");
print("leaf port: " + leaf.port);
```

+**print**+

**Type:** Function
**Return:** void
**Description:** Print an announce to this leaf (or one of the leaf's vrooms)

```javascript
var leaf = Link.leaf("test");

// to all users in the leaf
leaf.print("hello");

// to the users in vroom 1 of the leaf
leaf.print(1, "hello");
```

+**printAdmins**+

**Type:** Function
**Return:** void
**Description:** Print an announce to the admins of this leaf

```javascript
var leaf = Link.leaf("test");

// to all admin in this leaf
leaf.printAdmins("hello");

// to all admins (level 2 and above) in this leaf
leaf.printAdmins(2, "hello");
```

+**scribble**+

**Type:** Function
**Return:** void
**Description:** Send a scribble to all users in this leaf

```javascript
var leaf = Link.leaf("test");
var scribble = userobj.avatar.toScribble();

// display who sent the scribble
leaf.scribble("oobe", scribble);

// display without saying who sent the scribble
leaf.scribble(scribble);
```

+**sendEmote**+

**Type:** Function
**Return:** void
**Description:** Send an emote message to everyone in this leaf

```javascript
var leaf = Link.leaf("test");
var sender = "oobe";
var text = "hello";
leaf.sendEmote(sender, text);
```

+**sendText**+

**Type:** Function
**Return:** void
**Description:** Send a public message to everyone in this leaf

```javascript
var leaf = Link.leaf("test");
var sender = "oobe";
var text = "hello";
leaf.sendText(sender, text);
```

+**user**+

**Type:** Function
**Return:** User
**Description:** Find a user's object in this leaf based on their name or name substring

```javascript
var leaf = Link.leaf("test");
var u = leaf.user("anon");

if (u != null)
    print("found user: " + u.name);
```

+**users**+

**Type:** Function
**Return:** void
**Description:** Perform an action on each user in this leaf

```javascript
var leaf = Link.leaf("test");

leaf.users(function (u)
{
    print(u.name + " is in leaf: " + leaf.name);
});
```
# +Users+


+**banned**+

**Type:** Function
**Return:** void
**Description:** Action each object in the banned user pool

```javascript
var text = "anon";

Users.banned(function (u)
{
    if (u.name.indexOf(text) == 0)
        u.unban();
});

print("all anons have been unbanned");
```

+**linked**+

**Type:** Function
**Return:** void
**Description:** Action each object in the linked user pool

```javascript
Users.linked(function (u)
{
    print(u.name + " is in room: " + u.leaf.name);
});
```

+**local**+

**Type:** Function
**Return:** void
**Description:** Action each object in the local user pool

```javascript
Users.local(function (u)
{
    u.sendText("hello world");
});
```

+**records**+

**Type:** Function
**Return:** void
**Description:** Action each object in the records pool

```javascript
var text = "anon";

Users.records(function (u)
{
    if (u.name.indexOf(text) == 0)
        print(u.name + " was an anon in this room");
});
```
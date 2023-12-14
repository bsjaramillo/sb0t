# +Link+


+**connect**+

**Type:** Function
**Return:** void
**Description:** Connect to a link hub

```javascript
Link.connect("arlnk://F5fPxdTq8eJeuqSVejGmq4b70iWKGh24K0yiPJVOpciNTNcRlHn6+Hj0bfk=");
```

+**disconnect**+

**Type:** Function
**Return:** void
**Description:** Disconnect from a link hub

```javascript
Link.disconnect();
```

+**externalIp**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the ip address of the link hub you are connected to

```javascript
print("hub ip: " + Link.externalIp);
```

+**hashlink**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the hashlink of the link hub you are connected to

```javascript
print("hub hashlink: " + Link.hashlink);
```

+**leaf**+

**Type:** Function
**Return:** Leaf
**Description:** Find a link leaf by name or name substring

```javascript
var leaf = Link.leaf("test room");
```

+**leaves**+

**Type:** Function
**Return:** void
**Description:** Action all leaves currently connected to the hub

```javascript
Link.leaves(function (l)
{
    print("connected to leaf: " + l.name);
});
```

+**linked**+

**Type:** Property (read only)
**Return:** bool
**Description:** Determine whether you are currently connected to a hub

```javascript
if (Link.linked)
    print("you are linking");
```

+**name**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the name of the link hub you are connected to

```javascript
print("hub name: " + Link.name);
```

+**port**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the port of the link hub you are connected to

```javascript
print("hub port: " + Link.port);
```
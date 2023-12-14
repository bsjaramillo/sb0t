# +Hashlink+


+**decode**+

**Type:** Function
**Return:** HashlinkResult
**Description:** Convert an encoded hashlink into a decoded object

```javascript
var hashlink = "arlnk://F5fPxdTq8eJeuqSVejGmq4b70iWKGh24K0yiPJVOpciNTNcRlHn6+Hj0bfk=";
var obj = Hashlink.decode(hashlink);
print(obj.name);
```

+**encode**+

**Type:** Function
**Return:** string
**Description:** Convert a decoded hashlink object into an encoded hashlink

```javascript
var obj = { ip: "127.0.0.1", port: 2468, name: "my test room" };
var hashlink = Hashlink.encode(obj);
print(hashlink);
```
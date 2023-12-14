# +Channels+


+**available**+

**Type:** Property (read only)
**Return:** bool
**Description:** Determines whether or not the server contains a database of current channels

```javascript
if (Channels.available)
    print("channel database is available");
```

+**enabled**+

**Type:** Property (read only)
**Return:** bool
**Description:** Determines whether or not the Room Search feature is enabled

```javascript
if (!Channels.enabled)
    print("room searching has been switched off");
```

+**search**+

**Type:** Function
**Return:** ChannelCollection
**Description:** Find a list of channels whose channel names contain a search criteria

```javascript
var query = "ares":
var rooms = Channels.search(query);
print("found " + rooms.length + " rooms containing " + query);
```
# +ChannelCollection+


+**length**+

**Type:** Property (read only)
**Return:** int
**Description:** The number of results contained in the collection

```javascript
var query = "ares";
var collection = Channel.search(query);

for (var i = 0; i < collection.length; i++)
    print(collection[i](i)(i).name + ": " + collection[i](i)(i).hashlink);
```
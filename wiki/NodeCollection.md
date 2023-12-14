# +NodeCollection+


+**length**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the number of nodes in this collection

```javascript
var nodes = xml.getNodesByName("foo");

for (var i = 0; i < nodes.length; i++)
    print(nodes[i](i).nodeValue);
```
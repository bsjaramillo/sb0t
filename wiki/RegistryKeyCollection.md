# +RegistryKeyCollection+


+**length**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the number of keys contained in this collection

```javascript
var keys = Registry.getKeys();

for (var i = 0; i < keys.length; i++)
{
    var k = keys[i](i);
    var v = Registry.getValue(k);
    print("key: " + k);
    print("value: " + v);
}
```
# +NodeAttributes+


+**getValue**+

**Type:** Function
**Return:** string
**Description:** Get the value for an attribute

```javascript
var foo = node.attributes.getValue("bar");
print(foo);
```

+**length**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the number of attributes in this collection

+**removeValue**+

**Type:** Function
**Return:** bool
**Description:** Remove an attribute from this collection

```javascript
node.attributes.removeValue("foo");
```

+**setValue**+

**Type:** Function
**Return:** bool
**Description:** Add or replace an attribute in this collection

```javascript
node.attributes.setValue("foo", "bar");
```
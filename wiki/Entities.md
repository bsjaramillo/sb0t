# +Entities+

+**decode**+

**Type:** Function
**Return:** string
**Description:** Convert special HTML entities back to characters

```javascript
var decoded = Entities.decode("&#169;");
```

+**encode**+

**Type:** Function
**Return:** string
**Description:** Convert all applicable characters to HTML entities

```javascript
var encoded = Entities.encode("©");
```
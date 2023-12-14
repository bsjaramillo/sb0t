# +Registry+


+**clear**+

**Type:** Function
**Return:** bool
**Description:** Deletes all registry values for this script

```javascript
if (Registry.clear())
    print("registery cleared");
```

+**exists**+

**Type:** Function
**Return:** bool
**Description:** Check if a registry key exists

```javascript
if (Registry.exists("test"))
    print("test key exists");
```

+**deleteValue**+

**Type:** Function
**Return:** bool
**Description:** Delete a value from the registry

```javascript
Registry.delete("test");
```

+**getKeys**+

**Type:** Function
**Return:** RegistryKeyCollection
**Description:** Get a collection of all the registry keys for this script

```javascript
var keys = Registry.getKeys();

for (var i = 0; i < keys.length; i++)
    print(keys[i](i));
```

+**getValue**+

**Type:** Function
**Return:** string
**Description:** Get the value from the registry given a specific key

```javascript
var value = Registry.getValue("test");
print(value);
```

+**setValue**+

**Type:** Function
**Return:** bool
**Description:** Set the value of a specific registry key

```javascript
var value = "hello world";
var key = "test";

if (Registry.setValue(key, value))
    print("value has been set");
```
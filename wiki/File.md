# +File+


+**append**+

**Type:** Function
**Return:** bool
**Description:** Add text to the end of an existing data file

```javascript
File.append("file.txt", "hello");
```

+**exists**+

**Type:** Function
**Return:** bool
**Description:** Determines whether or not a data file currently exists

```javascript
if (!File.exists("file.txt"))
    print("file not found");
```

+**kill**+

**Type:** Function
**Return:** bool
**Description:** Delete a data file

```javascript
File.kill("file.txt");
```

+**load**+

**Type:** Function
**Return:** string
**Description:** Load a data file and return the contents as a string

```javascript
var str = File.load("file.txt");
print(str);
```

+**save**+

**Type:** Function
**Return:** bool
**Description:** Save the contents of a string to a data file

```javascript
var str = "hello";
File.save("file.txt", str);
```
# +List+


+**Scenario**+

**Description:** Create a List object to contain a collection of mixed objects.

```javascript
var list = new List();
list.add(1);
list.addRange(2, 3, 4, 5);
list.addRange("foo", 6, "bar", 7);

for (var i = 0; i < list.length; i++)
    print(list[i](i));

list.clear();
list.addRange(1, 2, 3, 4, 5, 6, 7, 8);
list.removeAll(function (q) { return q > 4; });

for (var i = 0; i < list.length; i++)
    print(list[i](i));
```

+**add**+

**Type:** Function
**Return:** int
**Description:** Add a new element to the list

```javascript
list = new List();
list.add(12345);
```

+**addRange**+

**Type:** Function
**Return:** int
**Description:** Add a number of elements to the list

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 5);
```

+**clear**+

**Type:** Function
**Return:** int
**Description:** Remove all elements from the list

```javascript
list = new List();
list.add(12345);
list.clear();
```

+**count**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the number of elements contained in the list

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 5);
print("there are " + list.count + " elements in this list");
```

+**find**+

**Type:** Function
**Return:** mixed
**Description:** Get the first element matching a query

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50);
item = list.find(function (q) { return q > 4; });
print(item);
```

+**findAll**+

**Type:** Function
**Return:** List
**Description:** Get a List of all elements matching a query

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50);
list2 = list.findAll(function (q) { return q > 3; });
print("found " + list2.count + " items");
```

+**findIndex**+

**Type:** Function
**Return:** int
**Description:** Get the index of the first element matching a query

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50);
index = list.findIndex(function (q) { return q > 3; });
print(list[index](index));
```

+**findLastIndex**+

**Type:** Function
**Return:** int
**Description:** Get the index of the last element matching a query

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50);
index = list.findIndex(function (q) { return q > 3; });
print(list[index](index));
```

+**getRange**+

**Type:** Function
**Return:** List
**Description:** Get a list of elements between a certain index range

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50);
list2 = list.getRange(0, 2);

for (var i = 0; i < list2.length; i++)
    print(list2[i](i)); // 1 and 2
```

+**indexOf**+

**Type:** Function
**Return:** int
**Description:** Get the index of the first element which equals an object

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
index = list.indexOf(3);
print(index); // 2
```

+**insert**+

**Type:** Function
**Return:** int
**Description:** Insert an element into the list

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.insert(0, "foo"); // list is now ["foo", 1, 2, 3, 4, 50, 3](_foo_,-1,-2,-3,-4,-50,-3)
```

+**insertRange**+

**Type:** Function
**Return:** int
**Description:** Insert a number of elements into the list

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.insertRange(0, "foo", "bar"); // list is now ["foo", "bar", 1, 2, 3, 4, 50, 3](_foo_,-_bar_,-1,-2,-3,-4,-50,-3)
```

+**join**+

**Type:** Function
**Return:** String
**Description:** Join all the elements in the list into a string

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
print(list.join(":"); // "1:2:3:4:50:3"
```

+**lastIndexOf**+

**Type:** Function
**Return:** int
**Description:** Get the index of the last element which equals an object

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
index = list.lastIndexOf(3);
print(index); // 5
```

+**length**+

**Type:** Property (read only)
**Return:** int
**Description:** The same as count

+**remove**+

**Type:** Function
**Return:** int
**Description:** Remove the first element which equals an object

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.remove(3); // list now [1, 2, 4, 50, 3](1,-2,-4,-50,-3)
```

+**removeAll**+

**Type:** Function
**Return:** int
**Description:** Remove all elements that match a query

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.removeAll(function (q) { return q > 3; }); // list now [1, 2](1,-2)
```

+**removeAt**+

**Type:** Function
**Return:** int
**Description:** Remove an element at a specific index

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.removeAt(0); // list now [2, 3, 4, 50, 3](2,-3,-4,-50,-3)
```

+**removeRange**+

**Type:** Function
**Return:** int
**Description:** Remove a sequence of elements

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3); // remove first 4 elements
list.removeRange(0, 4); // list now [50, 3](50,-3)
```

+**reverse**+

**Type:** Function
**Return:** bool
**Description:** Reverse the list elements

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.reverse(); // list now [3, 50, 4, 3, 2, 1](3,-50,-4,-3,-2,-1)
```

+**sort**+

**Type:** Function
**Return:** bool
**Description:** Sort the list based on a comparison

```javascript
list = new List();
list.addRange(1, 2, 3, 4, 50, 3);
list.sort(function (x, y) { return x > y ? 1 : x < y ? -1 : 0; });
print(list); // list now [1, 2, 3, 3, 4, 50](1,-2,-3,-3,-4,-50)
```
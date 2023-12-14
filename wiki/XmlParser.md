# +XmlParser+


+**appendChild**+

**Type:** Function
**Return:** Node
**Description:** Add a new child element to this node

```javascript
var child = node.appendChild("foo");
child.nodeValue = "bar";
```

+**attributes**+

**Type:** Property (read only)
**Return:** NodeAttributes
**Description:** Get a collection of key/value attributes for this node

+**available**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if the XmlParser contains a valid XML document

+**childNodes**+

**Type:** Property (read only)
**Return:** NodeCollection
**Description:** Get a collection of child elements for this node

+**create**+

**Type:** Function
**Return:** bool
**Description:** Manually create a new XML document within the XmlParser object

```javascript
var xml = new XmlParser();
xml.create("rootNode");
print(xml.xml);
```

+**getNodesByName**+

**Type:** Function
**Return:** NodeCollection
**Description:** Get a collection of child elements for this node with a specific name

```javascript
var nodes = node.getNodesByName("foo");

for (var i = 0; i < nodes.length; i++)
    print(nodes[i](i).nodeValue);
```

+**load**+

**Type:** Function
**Return:** bool
**Description:** Load a XML document into the XmlParser

```javascript
var xml = new XmlParser();
xml.load("myfile.xml");
```

+**nodeName**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the XML name for this node

+**nodeValue**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the value for this node

+**parentNode**+

**Type:** Property (read only)
**Return:** Node
**Description:** Get the parent for this node

+**removeChild**+

**Type:** Function
**Return:** bool
**Description:** Remove a child from this node

```javascript
var node = xml.getNodesByName("foo")[0](0);
node.parent.removeChild(node);
```

+**xml**+

**Type:** Property (read only)
**Return:** string
**Description:** Export the XML document within this XmlParser
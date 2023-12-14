# +HttpRequest+


+**Scenario**+

**Description:** Download a HTML document and print it to the room

```javascript
var http = new HttpRequest();
http.src = "http://www.google.com/";

http.oncomplete = function (e)
{
    if (e)
    {
        var lines = this.page.split("\n");

        for (var i = 0; i < lines.length; i++)
            print(lines[i]);
    }
}

http.download();
```

+**accept**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the Http Accept string

+**download**+

**Type:** Function
**Return:** bool
**Description:** Begin async download of the source file

```javascript
// with arg
http.download("user defined message");

// without arg
http.download();
```

+**header**+

**Type:** Function
**Return:** bool
**Description:** Add a user defined Http header to your request

```javascript
http.header("connection", "keep-alive");
```

+**host**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the http host header

+**method**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the http method header (GET or POST)

+**oncomplete**+

**Type:** Property (read/write)
**Return:** UserDefinedFunction
**Description:** Get or set the async complete event

+**params**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the user defined post header data

+**src**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the hyper link address for the Http request

+**userAgent**+

**Type:** Property (read/write)
**Return:** string
**Description:** Get or set the user agent Http header

+**utf**+

**Type:** Property (read/write)
**Return:** bool
**Description:** Get or set the encoding (true for UTF8, false for ANSI)
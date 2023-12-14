# +Scribble+


+**Scenario 1**+

**Description:** Create an ScribbleImage object from a local image file

```javascript
var scribble = new Scribble().load("mypic.jpg");
user(0).scribble(scribble);
```

+**Scenario 2**+

**Description:** Create an ScribbleImage object from a remote image file

```javascript
var scribble = new Scribble();
scribble.src = "http://www.codeplex.com/mypic.jpg";

scribble.oncomplete = function (e)
{
    if (e)
        user(parseInt(this.arg)).scribble(this);
}

scribble.download(0);
```
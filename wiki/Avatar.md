# **Avatar**


### **Scenario 1**

**Description:** Create an `AvatarImage` object from a local image file

```javascript
var av = new Avatar().load("mypic.jpg");
user(0).avatar = av;
```

### **Scenario 2**

**Description:** Create an `AvatarImage` object from a remote image file

```javascript
var av = new Avatar();
av.src = "http://www.codeplex.com/mypic.jpg";

av.oncomplete = function (e)
{
    if (e)
        user(parseInt(this.arg)).avatar = this;
}

av.download(0);
```
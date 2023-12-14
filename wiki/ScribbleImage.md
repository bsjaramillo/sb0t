# +ScribbleImage+


+**arg**+

**Type:** Property (read only)
**Return:** string
**Description:** A user defined code tag

+**exists**+

**Type:** Property (read only)
**Return:** bool
**Description:** Returns true if the ScribbleImage contains a valid image

+**save**+

**Type:** Function
**Return:** bool
**Description:** Saves the image contained in this object to a local file in the script's data folder

```javascript
scribble.save("myscribble.jpg");
```

+**toAvatar**+

**Type:** Function
**Return:** AvatarImage
**Description:** Converts the ScribbleImage into an AvatarImage

```javascript
var av = scribble.toAvatar();
userobj.avatar = av;
```
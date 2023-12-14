### **arg**

**Type:** Property (read only)  
**Return:** string  
**Description:** A user defined code tag  

### **exists**

**Type:** Property (read only)  
**Return:** bool  
**Description:** Returns true if the object contains a valid avatar  

```javascript
if (userobj.avatar.exists)
    print(userobj.name + " has an avatar");
```

### **save**

**Type:** Function  
**Return:** bool  
**Description:** Save an avatar to a file  

```javascript
userobj.avatar.save("myAvatar.jpg");
```

### **toScribble**

**Type:** Function  
**Return:** ScribbleImage  
**Description:** Convert an avatar into a scribble  

```javascript
userobj.scribble(userobj.avatar.toScribble());
```
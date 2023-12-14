# +PM+


+**contains**+

**Type:** Function
**Return:** bool
**Description:** Discover if a PM contains a specific word or phrase

```javascript
function onPMBefore(userobj, target, pm)
{
    // block hashlinks in pm

    if (pm.contains("arlink"))
        return false;

    return true;
}
```

+**remove**+

**Type:** Function
**Return:** void
**Description:** Remove a specific word or phrase from a PM

```javascript
function onPMBefore(userobj, target, pm)
{
    pm.remove("foo");
    pm.remove("bar");
    return true;
}
```

+**replace**+

**Type:** Function
**Return:** void
**Description:** Replace a specific word or phease in a PM

```javascript
function onPMBefore(userobj, target, pm)
{
    pm.replace("foo", "bar");
    return true;
}
```
# +Record+


+**ban**+

**Type:** Function
**Return:** void
**Description:** Retrospectively ban a user who is no longer in the room

```javascript
// ban all anons who have been in the room
Users.records(function (u)
{
    if (u.name.indexOf("anon ") == 0)
        u.ban();
});
```

+**dns**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the DNS value for a parted user

+**externalIp**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the external IP address for a parted user

+**guid**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the guid for a parted user

+**joinTime**+

**Type:** Property (read only)
**Return:** double
**Description:** Get the time a parted user had joined expressed as unix timestamp

+**localIp**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the local IP address for a parted user

+**name**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the user name for a parted user

+**port**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the port for a parted user

+**version**+

**Type:** Property (read only)
**Return:** string
**Description:** Get the client version for a parted user
# +BannedUser+


+**externalIp**+

**Type:** Property (read only)
**Return:** string
**Description:** The external ip address for the banned user

+**guid**+

**Type:** Property (read only)
**Return:** string
**Description:** The guid for the banned user

+**localIp**+

**Type:** Property (read only)
**Return:** string
**Description:** The local ip address from the banned user

+**name**+

**Type:** Property (read only)
**Return:** string
**Description:** The user name for the banned user

+**port**+

**Type:** Property (read only)
**Return:** int
**Description:** The port for the banned user

+**unban**+

**Type:** Function
**Return:** void
**Description:** Unbans the banned user

```javascript
// unban everyone
Users.banned(function (u) { u.unban(); });
```

+**version**+

**Type:** Property (read only)
**Return:** string
**Description:** The client version for the banned user
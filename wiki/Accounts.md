# **Accounts**


With sb0t 5 your passwords remain completely secret from everyone, including the host of the room!  This means you can use the same password across multiple rooms without worrying about it being leaked.

### **Owner password**

To login as the owner of the chatroom, you must either connect locally (127.0.0.1), or login using the owner password...

![](Accounts_http://pictat.com/i/2012/12/18/18425owner.png)

Being owner gives you access to extra commands:
* `#addautologin`
* `#remautologin`
* `#autologins`
* `#listpasswords`
* `#rempassword`
* `#setlevel`

### **Auto logins**

Auto logins work exactly as in previous versions of sb0t.  The room owner can use `#addautologin` `#remautologin` and `#autologins` to manage their automatic admin logins.

Note:  Auto logins DO NOT require the admins to have a password.

### **Admin passwords**

If an admin would like to use a password, the admin must follow these steps:

1. Register their password.  For example, if they want their password to be `test11`, they would type:

`#register test11`

2. The owner can then set the admin level for that password using the `#setlevel` command.  For example, if they want the admin's password to be level 2, they would type:

`#setlevel "name here" 2`

And that's it.  sb0t will then remember the admin level associated with that password.

### **Managing passwords**

Passwords are not just for admins.  Anyone can register a password, which could be used for script or extension features, or to access "general" commands, if enabled.

The room owner can manage the passwords which have been registered by using the #listpasswords and #rempassword commands.  These commands can be used to delete password accounts from your room.  For example, here I have used #listpasswords to obtain a list of currently registered passwords in my room:

![](Accounts_http://pictat.com/i/2012/12/18/45882listpasswo.png)

If I wish to delete oobe's password, I would type:

`#rempassword 0`

Because on the list, 0 is the identity number for oobe's password.
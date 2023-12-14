# +Linking+


With sb0t 4.xx and Callisto, the room linking system was an ad-hoc server/client relationship where a maximum of 2 rooms can link together, one playing the role of server, the other playing the role of client.

sb0t 5's room linking system has been completely redesigned and reprogrammed from a blank sheet.  In this new system, one room plays the role of server (known as the Hub), while other rooms act as clients (known as Leaves) which connect to the Hub.

Notice I said "other room**s**" !!  This new room linking system offers the ability to link an infinite number of rooms together. :-)

+**Who should be the Hub?**+

Any room can decide to be a Hub, however if you are going to link many rooms together, it is advisable for the room with the best quality internet connection to play the role of Hub.

+**How do I set sb0t to be a Hub?**+

In the linking tab, set the link mode to Hub:

![](Linking_http://pictat.com/i/2012/12/18/19987hub.png)

+**How do I set sb0t to be a Leaf?**+

In the linking tab, set the link mode to Leaf:

![](Linking_http://pictat.com/i/2012/12/18/40830hub.png)

+**How do I add my Leaf to the Hub's "trusted leaves" list?**+

Before you connect to a hub you must give the Hub owner your leaf identifier.  This is a special code available in the linking tab of sb0t:

![](Linking_http://pictat.com/i/2012/12/18/24633ident.png)

This identifier is created using sb0t's individually generated signature and your room's name.  This means if you change the name of your room, your leaf identifier will change and you'll have to give the new sblnk to the Hub owner.

After you've given your leaf identifier to the Hub owner, they will then add your leaf identifier to their "trusted leaves" list, by pasting it into the textbox and clicking Add:

![](Linking_http://pictat.com/i/2012/12/18/22324add.png)

The Hub room will save your identifier, so you won't need to keep re-adding the leaf identifier each time.

+**How do I connect my Leaf room to the Hub?**+

OK, so you've given your leaf identifier to the Hub owner, and they've added you to their "trusted leaves" list.  All that's left is to connect to the Hub.  This is done simply by acquiring the Hub's hashlink, and then using the #link command.  For example:

{{#link arlnk://F5fPxdTq8eJeuqSVejGmq4b70iWKGh24K0yiPJVOpciNTNcRlHn6+Hj0bfk=}}
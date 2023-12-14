# +Timer+


+**Scenario**+

**Description:** Print a message every 2 seconds for 10 cycles

```javascript
var cycle = 0;

var timer = new Timer();
timer.interval = 2000;

timer.oncomplete = function ()
{
    print("hello world");

    if (++cycle == 10)
        timer.stop();
    else
        timer.start();
}

timer.start();
```
# +Query+


+**Scenario**+

**Description:** Create a Query object including some conditions

```javascript
// query to find rows where name starts with anon and age is over 18
var str = "select * from my_table where name like {0} and age > {1}";
var query = new Query(str, "anon%", 18);
```
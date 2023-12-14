# +Sql+


+**Scenario**+

**Description:** Create a Query object and then print the results from SQL

```javascript
// query to find rows where name starts with anon and age is over 18
var str = "select * from my_table where name like {0} and age > {1}";
var query = new Query(str, "anon%", 18);

// process query through SQL
var sql = new Sql();
sql.open("my_db");

if (sql.connected)
{
    sql.query(query);

    while (sql.read)
    {
        var name = sql.value("name");
        var age = sql.value("age");
        print(name + " is " + age + " years old");
    }

    sql.close();
}
else print("failed: " + sql.lastError);
```
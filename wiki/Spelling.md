# +Spelling+


+**check**+

**Type:** Function
**Return:** string
**Description:** Check if a word or sentence contains errors and attempt to correct any found

```javascript
var text = "hello worrld";
print("before: " + text);
text = Spelling.check(text);
print("after: " + text);
```

+**confirm**+

**Type:** Function
**Return:** bool
**Description:** Check if a word or sentence contains errors

```javascript
var text = "hello worrld";

if (Spelling.confirm(text))
    print("there are no spelling errors");
else
    print("there are spelling errors");
```

+**suggest**+

**Type:** Function
**Return:** SpellingSuggestionCollection
**Description:** Get a collection of spelling suggestions for a word

```javascript
var word = "worrld";
var suggestions = Spelling.suggest(word);

for (var i = 0; i < suggestions.length; i++)
    print(suggetsions[i](i));
```
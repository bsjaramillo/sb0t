# +SpellingSuggestionCollection+


+**length**+

**Type:** Property (read only)
**Return:** int
**Description:** Get the total number of items in this collection

```javascript
var word = "worrld";
var suggestions = Spelling.suggest(word);
print("found " + suggestions.length + " suggestions");
```
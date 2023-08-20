
<mark style="background: #FFB8EBA6;">print specific character from string:</mark>

```python
mystring = "hello world"
lookingfor = "l"
for c in range(0, len(mystring)):
    if mystring[c] == lookingfor:
        print(str(c) + " " + mystring[c]);
```

Outputs: geeft u de index positie terug 
```python
2 l
3 l
9 l
```

<mark style="background: #FFB8EBA6;">And more along the lines of hangman:</mark>

```python
mystring = "hello world"
lookingfor = "l"
for c in range(0, len(mystring)):
    if mystring[c] == lookingfor:
        print(mystring[c], end="")
    elif mystring[c] == " ":
        print(" ", end="")
    else:
        print("-", end="")
```

produces: Haalt alles weg behalve de letter 
```python
--ll- ---l-
```
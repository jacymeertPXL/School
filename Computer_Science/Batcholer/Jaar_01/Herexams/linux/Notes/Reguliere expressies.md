`````linux
**Reguliere Expressies:**

1. **Eenvoudige zoekactie**:
    
    - Patroon: `word`
    - Beschrijving: Hiermee wordt het woord "word" gezocht in de tekst.
    - Voorbeeld met `grep`: `grep 'word' file.txt`
2. **Wildcard - één willekeurig teken**:
    
    - Patroon: `a.b`
    - Beschrijving: Hiermee wordt elke reeks met "a", gevolgd door één willekeurig teken, gevolgd door "b" gezocht.
    - Voorbeeld met `grep`: `grep 'a.b' file.txt`
3. **Wildcard - nul of meer herhalingen**:
    
    - Patroon: `ab*c`
    - Beschrijving: Hiermee wordt "ac", "abc", "abbc", enz. gezocht, waarbij "b" nul of meer keren kan voorkomen.
    - Voorbeeld met `grep`: `grep 'ab*c' file.txt`
4. **Karaktergroep**:
    
    - Patroon: `[aeiou]`
    - Beschrijving: Hiermee wordt elk klinker (a, e, i, o, u) gezocht.
    - Voorbeeld met `grep`: `grep '[aeiou]' file.txt`

**Irreguliere Expressies (Uitgebreide Reguliere Expressies):**

1. **Herhaling - één of meer herhalingen**:
    
    - Patroon: `a+`
    - Beschrijving: Hiermee wordt één of meer opeenvolgende "a"-tekens gezocht.
    - Voorbeeld met `grep`: `grep -E 'a+' file.txt`
2. **Optioneel karakter**:
    
    - Patroon: `colou?r`
    - Beschrijving: Hiermee wordt zowel "color" als "colour" gezocht, waarbij de "u" optioneel is.
    - Voorbeeld met `grep`: `grep -E 'colou?r' file.txt`
3. **Begin- en eindanker**:
    
    - Patroon: `^start.*end$`
    - Beschrijving: Hiermee wordt een regel gezocht die begint met "start" en eindigt met "end".
    - Voorbeeld met `grep`: `grep -E '^start.*end$' file.txt`
4. **Alternatieven**:
    
    - Patroon: `apple|banana`
    - Beschrijving: Hiermee wordt ofwel "apple" of "banana" gezocht.
    - Voorbeeld met `grep`: `grep -E 'apple|banana' file.txt`
`````
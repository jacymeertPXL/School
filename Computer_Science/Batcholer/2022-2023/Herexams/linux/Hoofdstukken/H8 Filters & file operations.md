````linux
head -3 test | tail -3 test --> pipes voert alle bij de commands uit
tail -3 auth.log | head -1 > /filteredlogfile

grep jane auth.log --> zoekt in het bestand ergens waar jane in staat 
cat aut.log | grep failed --> kan bv hier zijn dat door grep het woordt niet gevonden kan worden in de file en geef het niks terug

command | tee [options] file1 [file2 ...] --> De `tee`-opdracht in Linux wordt gebruikt om de uitvoer van een commando naar zowel de standaarduitvoer (gewoonlijk uw terminal) als naar een of meer bestanden te schrijven
ls -l | tee output.txt --> schrijft alles van ls in outpt.txt

grep -i [pattern] --> case insensitive
grep -v [pattern] --> wat niet het pattern in staat
grep -A1 [pattern] --> after eerste lijn
grep -B2 [pattern] --> before 2de lijn
````` 

[[Reguliere expressies]]
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
    - Voorbeeld grep 'ab*c' file.txt
4. **Karaktergroep**:
    
    - Patroon: `[aeiou]`
    - Beschrijving: Hiermee wordt elk klinker (a, e, i, o, u) gezocht.
    - Voorbeeld grep [aeiou] file.txt

5 aantal tekens
	- Patroon 'a{3}b'
	- Beschrijving: het getal of string voor de {} komt aantal keer voor
	- Voorbeel grep -E "px{3}1"

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

grep -w "test" --> waar het woord 1 keer in voor komt
`````

````
student@linux-ess:~$ cat regexlist.txt | grep -E "^.+\@[a-zA-Z0-9]+\.[a-zA-Z]{2,}"
john.doe@pxl.be


student@linux-ess:~$ cat regexlist.txt | grep -E "https?://.+\."
http://www.pxl.be
https://www.pxl.be

student@linux-ess:~$ cat regexlist.txt | grep -E "^[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}$"
192.168.1.19
192.168.5.117
172.16.0.4
127.0.0.1
`````


````linux
head [bestand] | cut-d":" -f1,2,3 --> cut af bij de derde : 
cut -d":" -f1,6 --> cut dan af bij 1 en 6

sort | uniq --> altijd eerst sorten en dan geeft het unieks weer 

wc [file] --> word count van file

head [bestand] | tr 'e' 'E' --> maakt alle e naar E 
head [bestand] | tr -s '1' --> doet requring letters of cijfers weg
head [bestand] | tr -d '1' --> doet letters of cijfers weg

student@linux-ess:~$ echo "example this is an example" | sed 's/example/test/'
test this is an example

`````

![[Pasted image 20230904144936.png]]

























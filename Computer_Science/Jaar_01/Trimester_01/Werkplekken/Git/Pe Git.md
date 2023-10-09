git-init --> Create an empty Git repository or reinitialize an existing one
git clone (https link) --> om u  repository te clonen

git add (file naam bv contact.html)
git add --all --> alle untracked en modified files stagen

git commit -a --> commit doen
git commit -m --> commit doen met een omschrijving erbij

git status --> vertel welke data untracked, modified of staged is en toon directories waarin elke file untracked is als één regel
git status -u --> hetzelfde, maar toon elke untracked file altijd op een eigen regel

git log --> timeline met de commits 
git log --graph --> meer detail timeline en duidelijker

git rm --> delete een file 
gir rm -r --> file en map 
git rm --cached --> file verwijderet in stage dus kan untracked worden
git rm -r --cached -->  file en map verwijderet in stage dus kan untracked worden

git branch (naam) --> maakt branch
git branch -D (naam) --> delete branch tot deze naam 
git branch --> geef de naam van de branch waar je in zit 
git log --graph --all --> toont de history met alle branches 

git checkout (naam-van-branch) --> veranderen van branch

git branch (naam) --> maakt branch
git checkout (naam-van-branch) --> veranderen van branch
Samen gerbruiken

git log --graph --all --oneline --> geschiedenis

![[Pasted image 20231008190838.png]]

![[Pasted image 20231008191125.png]]

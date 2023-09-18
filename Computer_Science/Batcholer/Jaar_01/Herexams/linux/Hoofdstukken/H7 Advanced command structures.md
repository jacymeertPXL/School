![[Pasted image 20230903181313.png]]

[[File globbing]]

````linux
alias show='ls -lah' --> gaat dan de command uitvoeren op show
alias show --> showed wat de alias is in deze case 'ls -lah'
unalias show --> haalt alias wegrech
`````

![[Pasted image 20230903182336.png]]

````linux
ls [path - file] 1> listrootfolder --> gaat de file of directory in een file zetten
ls [path - file] > listrootfolder --> doet het zelfde default is 1

student@linux-ess:~$ find / > results.txt 2> errors.txt --> rederect error
student@linux-ess:~$ find / 2> /dev/null --> rederect errorfind
student@linux-ess:~$ find / &> results_and_errors.txt
`````

logical _AND_ operator (`&&`): The second command will only execute if the first command succeeds

logical _OR_ operator (`||`): The second command is only executed when the first command fails





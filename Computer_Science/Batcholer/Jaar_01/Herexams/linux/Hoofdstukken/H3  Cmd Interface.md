![[Pasted image 20230902150701.png]]

````linux
echo hello world --> hello world
sudo shutdown now --> shutdown van het system
man shutdown --> opent de manual van shutdown
`````

[[man(uel) command]]
	man command in linux wordt gerbruikt om de manual weer te geven van any command that can gerbuikt worden in the terminal 

Every manual is divided into the following sections:
	Executable programs or shell commands
	System calls (functions provided by the kernel)
	Library calls (functions within program libraries
	Games
	Special files (usually found in /dev)
	File formats and conventions eg /etc/passwd
	Miscellaneous (including macro packages and conventions),
	System administration commands (usually only for root)
	Kernel routines Non standard

Syntax:
````linux
man  [Section-NUM]  [COMMAND NAME]
man 1 shutdown
`````

 ````linux
whatis route --> toont wat de command route is -->
route (8) - show / manipulate the IP routing table

where is -m ls --> toont waar de location van de manpage is

!! --> doet u vorige command 

`arrow up` and `arrow down` keys after using some commands -->
You will notice that these commands will reappear after the prompt.

history 10 --> toont u 10 laaste commands
`````

[[Assignments h3]]
Task 1:
````linux
man -f ls --> -f gaat een short discription geven van de command -->
dus heer een short discription van ls
`````

Task 2:
````linuxc
sudo shutdown -r / sudo shutdown reboot --> openieuwe opstarten van het syteem
`````

Task 3:
````linux
Reboot your vm:
	sudo reboot

Change your password or another user's password:
	sudo passwd [username]

show the contents of a directory
	ls [directory_path]

Clear the terminal screen:
	clear

See who is logged in:
	who

See how much free memeory the server has:
	free -h
`````

Task 4:
````linux
ls -a --> laat u hidedn files wien
`````

Task 5:
````linux
man -f ls --> -f gaat een short discription geven van de command -->
dus heer een short discription van ls
`````

Task 6:
````linux
whereis reboot --> toont waar de manpage voor reboot is stored
`````

Task 7:
````linux
sudo apt-get install openssh-server --> install ssh server
sudo service ssh start --> start server op
sudo service ssh status --> controleer als die op staat 

ssh [username]@[remote_host] --> connect to ssh server
username --> ssh server
remote_host --> ip adress ssh server

ip route --> waar src bij staat
`````


#linux 







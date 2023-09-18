````linux
/etc/passwd --> user config en user list
head -1 /etc/passwd --> is het root account
cat 
sudo useradd -m -d /home/teacher -c "teacher comment" teacher -->
-d --> om de file path aan te geven
-m --> om de home folder aan te maken en te controleren
-c --> comment toevoegen
-s --> om elkaar files aan te kunnen passen in de zelfde group
sudo userdel -r teacher --> delete user en home folder door -r
id teacher --> id voor uid gid en groups van teacher

sudo useradd -D --> geeft default values weer van useradd

/etc/skel --> staat de default home folder versie in dus dit kan je aanpassen voor een andere default home folder te hebben bij useradd

grep teacher /etc/passwd --> zoekt user teacher in passwd

sudo usermod -aG ict liam --> gaat ze allebij adden in de zelfde group
sudo usermod -aG ict liam --> gaat ze allebij adden in de zelfde group

sudo usermod -c "teacher account" teacher --> verandert of add comment

sudo usermod -s /bin/bash teacher --> default shell aanpassen

sudo usermod -s /bin/false teacher --> zorgt er voor dat je niet kan 
sudo usermod -s /bin/nologin teacher --> zorgt er voor dat je niet kan inloggen

passwd --> laat u password veranderen op u current user 
sudo passwd --> laat u password veranderen op u root user
sudo passwd teacher--> laat u password veranderen voor de grep gegeven user

sudo tail -1 /etc/shadow --> laat u zien wat het wachtwoord is van user 

whoami; pwd --> user waar je nu bent ingelogd
su - teacher --> laat u inloggen op deze user
exit --> laat u uitloggen en logt u terug in de vorige 
sudo su - root --> root user 

id student --> toont id student
groups student --> toont groups of student
grep student /etc/group --> toont group info 

sudo groupadd ict --> maakt group aan ict
sudo groupmod -n it ict --> verandert naam van ict naar it

sudo usermod -a -G it teacher --> add teacher naar group it
-a --> toevoegen --> zorgt er ook voor dat het niet uit andere groupen delete
-G --> dat het een group is 
`````

[[Premission]]
![[Pasted image 20230905130913.png]]
eerste teken !!
	d --> staat voor directory 
	'-' --> staat voor regular file

  Volgende 3 tekens
	  r --> Read --> 4
	  w --> Wright --> 2
	  x -->executabel -- 1
	  Voorbeeld
		  rwx = 4+2+1=7
		  rw- = 4+2+0=6
		  r-- = 4+0+0=4
		  -wx = 0+2+1=3

1. **u (eigenaar)**: Dit verwijst naar de eigenaar van het bestand.
    
2. **g (groepseigenaar)**: Dit verwijst naar de groepseigenaar van het bestand.
    
3. **o (overigen)**: Dit verwijst naar gebruikers die niet de eigenaar van het bestand zijn en geen lid zijn van de groepseigenaar.
    
4. **a (alle)**: Dit verwijst naar alle gebruikerscategorieën, dat wil zeggen de eigenaar, de groepseigenaar en de overigen.

````linux
touch test
ls -l test --> premission van file zien

chmod +x test --> executable rechten teovoegen

chmod g-w test --> wright rechten weg in group

chmod go-rx test --> read end execu weg in group en ovrige weg

chmod 744 test --> rechstreeks rechten toewijsen via octale
`````

````linux
sudo groupmod -n newgroupname oldgroupname --> name change

sudo chgrp -R it course/ --> om groepseigenaar te veranderen Recursief
course/ --> pad naar de directory in hier in staan de files in die je wil veranderen van eigenaar

sudo chown teacher:root config folder --> 
- `teacher:root`: Dit geeft de nieuwe eigenaar en groepseigenaar aan die je wilt toewijzen aan de genoemde directories.
    
    - `teacher` is de nieuwe eigenaar die wordt toegewezen aan de directories.
    - `root` is de nieuwe groepseigenaar die wordt toegewezen aan de directories.
- `config` en `folder`: Dit zijn de namen van de bestanden/directories waarvoor je het eigenaarschap wilt wijzigen. Je kunt andere bestand/directories opgeven als je meerdere bestand/directories wilt aanpassen.
`````
![[Pasted image 20230905180900.png]]
````linux
unmask --> om u direcory zijn defualt waarde te bekijken (Default #0002) -->
eerste 0 telt niet meer dus 002 - 666 is default voor bestand dus 664 rechten
voor folder (Directorys) 777 --> 775 rechten 

unmask 000 --> gaat dus 666 behouden en 777 

ompermanent to maken op het `.bashrc` file en pas daar met nano de unmask aan
nano .bashrc 

umask u=rwx,g=rx,o= --> gaat ook
unmask -S --> om rechten te zien die toegewezen gaan worden
`````

````linux
sudo ipt install acl

getfacl memo -->
`````
![[Pasted image 20230905143817.png]]
````linux
setfacl -m u:teacher:rw memo --> user toevoegen aan file
setfacl -m g:it:rw memo --> group toevoegen aan memo

ls -l memo gaat er nu een extra + op einde bijstaan

setfacl -m u:teacher:rx /home/student --> geeft de teacher rechten om de studeten hun files te lezen 

setfacl -m g:teacher:rx /home/student --> geeft de teacher groep rechten om de studeten hun files te lezen 

setfacl -m m:r memo --> set een default mask dus hier is read rechten

setfacl -x g:it memo --> detele groep it van memo

setfacl -b memo --> delete alle ACL entries 

setfacl -m d:g:it:rwx memos --> door d: toetevoegen gaan het nu een stadaartpremissies toevoegen  

`````






















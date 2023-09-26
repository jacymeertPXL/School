````linux
whatis pwd --> pwd - print name of current/working directory
pwd --> /home/student
cd /etc --> verander u pad naar etc 
pwd --> /etc

cd --> om een stap terug te gaan in de folder structuur
cd ~ --> om terug te gaan naar de homefolder
cd - --> terug naar de vorige folder dat je in zat
cd.. --> een folder hoger in de directrory

touch emptyfile --> maakt emptyfile aan

tree --> toont u de tree stuctuur van de directory en de subdirectorys er in
tree -a --> toont hidden files in de structuur
tree /etc/dhco --> toont u de structuur van deze path 
`````

[[absoluut pad]] [[Relatief pad]]
````linux
cd /home/student/Downloads # Absolute path
student@linux-ess:~/Downloads$ cd ../../teacher # Relative path -->
ge gaat een path omhoog daarom ../ en dan de 2de is om in de folder te komen
waar teacher in staat 
`````

````linux
ls -alh .
	- the `-a` option will _also show hidden files and folders_. **In Linux, hidden files and folders start with a dot (.). e.g. the `.bashrc` file.**
	- the `-l` option will show a _long listing_. This means that it will show all the extra output* and not just the file and folder names.
	- the `-h` option refers to _human readable_ and will make filesizes appear with the proper measuring unit rather than showing all sizes in bytes.
`````

````linux
mkdir backups --> maakt de directory backups
mkdir -p backups/steam/games/Payday2 --> -p zorgt er voor dat je ook sub maakt

touch testfile --> maakt een bestand aan
touch "test file" --> voor met een spatie te werken 

mv testfile backups/ --> moved de file naar de dicrectory 
mv testfile ../newFileName --> verandert de naam en moved de file 
mv newFileName myFile | backups myFolder --> verandert de file en directy naam

cp myFile myFIle.backup --> copie het bestand

cp myFIle myFolder/ --> copie het bestand naar de directory
cp /home/student/emptyFile /home/student/myFolder/emptyFile.bkp --> 
copie het bestand naar de directory

cp -r myFolder/ myFolder.backup --> copie de directorie and subdirec

sudo apt -y install rename

rename 's/file/document/' *.txt --> elke file in de waarfile staat wordt document en wordt een .txt toegevoegt
rename -E 's/\.txt/.odt/' * --> overal waar .txt staat word .odt -E (case insv)

file logo.png --> wegt wat voor bestand het is hier dan een png
extensies in linux zorgen niet wat het is allen wat in de file staat 
dus een .png bestand kan een txt bestand zijn

rm logo.png --> delete bestand
rm -fr dicrectory --> delete directory 
	- `-r` will mean it will remove files & folders recursive
	- `-f` will force the command to remove non-empty directories as well. Something that wont happen out of the box.

find -name "*test" --> test het einden van het bestand
find / -name "*networkmanager*" --> zoek bestand de de search term in het bestand
find / -iname --> case insensitive

locate testfile --> zegt u waar testfile staat
locate .profile --> elk bestand met .profile er in 
locate testfile -b --> zegt u waar testfile staat en gaat geen directory zoeken
locate testfile -i --> zegt u waar testfile staat en case insensitive
`````

[[Assignments H4]]

Task 01

cd ~

Task 02

mkdir -p PXL/Courses/S1/LinuxEss

Task 03

mkdir -p PXL/Courses/S2/NetworkEss

Task 04

mkdir -p PXL/Courses/S1/WindowsEss

Task 05

mkdir -p PXL/Software/Virtualization/VMware Workstation

Task 06

Tree

Task 07

Omdat linux geen autocorrect kan doen op  de bash comment

Task 08

cd /usr/local/etc

cd PXL/Software/Virtualization/VMware Workstation

Task 09

Cd ../../../Courses/S2/NetworkEss

Task 10

cd ~/.ssh

Task 11

ls -al

Task 12

Mkdir "My Picture"

Touch Picture1.JPG picture2.JPG Picture1.JPG picture4.jpg

Task 13

rename 's/JPG/jpg/' *

's/Picture/picture/' *

Task 14

sudo cp -ra /home/student/. /backup

Task 15

Rm -rf PXL

Task 16

mkdir -p school/semester/1/courses/ubuntuserver/exercises/chapter5

Task 17

Cd school/semester/1/courses/ubuntuserver/exercises

mkdir chapter6

Task 18

rmdir chapter5

Task 19

mkdir chapter5

Task 20

cd /var/log

Task 21

cd~

Task 22

Cat .bashrc

Task 23

Shift + n

Task 24

clear

Task 25

Ssh ~/.ssh/known_hosts

Task 26

echo hello there > /dev/tty1

sl > /dev/tty1

Task 27

cd school/semester/1/courses/ubuntuserver/exercises/chapter5

touch sourcefile

tree

Task 28

whatis touch

Task 29

mv school/semester/1/courses/ubuntuserver/exercises/chapter5/sourcefile school/semester/1/courses/ubuntuserver/exercises/chapter6/sourcefile

Task 30

mv school/semester/1/courses/ubuntuserver/exercises/chapter6/sourcefile school/semester/1/courses/ubuntuserver/exercises/chapter5/SourceFile

Task 31

cp school/semester/1/courses/ubuntuserver/exercises/chapter5/SourceFile /chapter6

Task 32

mv school/semester/1/courses/ubuntuserver/exercises/chapter6/sourcefile SourceFile.backup

Task 34

file /etec/passwd File /dev/tty1 File /dev/sda

Task 35

sudo find / -iname '*SourceFile*'

Task 36

sudo find / -iname '*file*'

Task 37

Sudo locate SourceFile

sudo updatedb

Task 38

Sudo locate  -i SourceFile

Task 39

rm SourceFile.backup

Task 40

Sudo shutdown

#linux
















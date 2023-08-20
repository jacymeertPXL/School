
<mark style="background: #FFB8EBA6;">Historie</mark>

- Alle moderne computer systemen stammen af van [[UNIX]]
- [[UNIX]] werd in 1969 ontworpen in de labs van AT&T Bell
- De source code wordt voor iedreen te beschikking gesteld
- UNIX werd later commercieel verkocht terwijl de code een deel door de communitie is gemaakt
- rechszaak --> 2 versie van UNIX ---> Official AT&T Unix | Free BSD Unix

<mark style="background: #FFB8EBA6;">Manual</mark>

man whois --> Manuel opzoeken
man syslog.conf --> Config file manuel zoeken
man syslog.d --> Daemo manual opzoeken
man -k -->Zoeken in man pages via string
man 5 passwd --> Locatie binnen een manpage meteen openen
man man --> manuel van man 
mandb --> update van manuels 

<mark style="background: #FFB8EBA6;">
Directories</mark>

pwd --> huidige pad tonen
cd --> van folder veranderen 
cd ~ --> naar u homefolder
cd .. --> naar een map eer oven gaan dus de parent map 
cd - --> naar de vorige map gaan
cd /etc --> [[absoluut pad]]  | om naar etc te gaan 
cd etc --> [[Relatief pad]] | om naar etc te gaan 

ls --> bestanden weergeven in een lijst van u directorie
ls -a --> bestanden weergeven ook hidden files 
ls -l --> long listing | (=extra info zoals rechten, owner, grootte, datum)
ls -lh --> human readable format

mkdir --> map aanmaken
mkdip --> parent mappen aanmaken
rmdir --> map verwijderen
rmdir --> map en alle mappen er in nog verwijderen

ispci --> hardware informatie opvragen

<mark style="background: #FFB8EBA6;">Files</mark>

file  text.txt --> Geeft weer wat voor bestand het is (Extensie kiest niet de wat de file is)
file -s /dev/sda --> wordt gebruitk om speciale files te zien

touch text2.txt --> Maakt een bestand aan
touch text3.txt --> maakt bestand aan onthoud aanmaakdatum

rm text.txt --> bestand wissen 
rm -i text.txt --> bestand wissen maar gaat eerst vragen als je zeker bent 
rm -rf --> Recursive, Force | delete de map met de inhoud

[[cp]] text.txt -->bestand kopieren
cp -r --> Recursief kopieren, inclusief subdirs en inhoud dus.
cp file1 file2 dir1/file3 dir2/file5 --> Meerdere bestanden tegelijk kopieren naar verschillende mappen
cp -p --> Behoudt timestamps en permissies van het bronbestand

mv text.txt text.text --> bestand verplaatsen of <mark style="background: #FF5582A6;">renamen </mark>
mv text.txt /tmp --> bestand <mark style="background: #FF5582A6;">verplaatsen</mark> of renamen

rename text.txt text.text --> rename

<mark style="background: #FFB8EBA6;">File Content 
</mark>

head --> eerste lijnen van bestand opvragen | head -5
tail --> laaste lijnen van bestand opvragen | tail -5

cat text.txt --> inhoud van een bestand opvragen | Concatenate 
cat "Hallo" > text.txt --> voegt hallo toe aan het bestand 
cat > winter.txt  --> Maakt een lege file, dan kan je pas typen (CTRL-D om te stoppen)
cat > winter.txt << EOF --> Maakt een lege file (EOF (mag alles zijn) typen om te stoppen)
cat winter.txt > cold.txt --> Bestand kopieren
tac --> cat maar outpout is omgekeerd 
more | less --> laat meer of minder zien inverhouding met het scherm
strings --> zoekt text in het bestand en geeft heet weer 

<mark style="background: #FFB8EBA6;">File system</mark>

man hier -->  Manual van de hierarchy
/  --> Root folder
/bin -->  User binaries
/home/serena/bin -->  Binaries voor enkel die user
/sbin -->  System binaries, enkel voor root users
/lib -->  Libraries die gebruikt worden door /bin en /sbin
/lib/modules -->  Kernel modules
/lib32 -->  libraries voor 32-bit architecturen (ELF files, Executable Linkable Format)
/lib64 -->  libraries voor 64-bit architecturen
/opt -->  Optionele software
/boot -->  Boot files, /boot/grub/grub.cfg definieert het boot menu
/etc/init.d -->  Scripts om daemons (background processen) te starten
/etc/X11 -->  X Windows System (of X)
/etc/skel Skeleton -->  map. deze bevat de default files voor nieuwe users (bv. .bashrc)
/etc/sysconfig -->  Configuratie bestanden (booten, harddisks, firstboot, HW config, Keymapping)
/etc/passwd -->  Map van alle gebruikers
/etc/shadow -->  Gebruikerswachtwoorden die geëncrypteerd zijn.
/etc/login.defs: -->  Bevat de default settings van het password dat moet ingegegeven
moet worden.
/etc/group -->  Staan alle groepen in.
/home -->  Alle user mappen staan hier ($USER)
/root -->  Map van de root gebruiker
/srv -->  Data die gedeeld kan worden (FTP, Rsync, www)
/media -->  Camera, USB-drive en CD-ROM-drive mount points
/mnt -->  Tijdelijke moint points (bv geshared mappen tussen host en guest)
/tmp  --> Map voor tijdelijke bestanden (~RAM), is leeg na reboot.
/dev  --> Device bestanden (SATA, IDE, ATAPI, USB, SCSI)
/dev/tty /dev/tty1 -->  stelt uw terminal (CLI) voor. /dev/pts/1 (terminal in GUI)
/dev/null -->  Zwart gat, hier kan je bv de stderr naar toe sturen
/proc -->  Schijnbaar lege bestanden die met de kernel communiceren
/proc/interrupts -->  BIOS interrupts
/proc/kcore --> Enkel leesbaar met debugger, stelt uw RAM geheugen voor
/sys --> Hot plug devices (USB, IEEE 1394 Firewire)
/usr -->  Unix System Resources (read only via NFS protocol)
/usr/bin -->  Unix commando’s
/usr/include -->  Algemene bestanden die dienen voor C
/usr/lib -->  Libraries die niet voor users of scripts dienen
/usr/local -->  Map waar een admin software lokaal in kan installeren
/usr/src -->  Kernel Source Files
/var -->  Centrale map voor log files
/var/log/messages -->  Bestand dat info bevat over de laatste gebeurtenissen
/var/cache -->  Cache Data voor apps
/var/spool --> Printer, mail en cron spool
/var/lib  --> App toestand info
/var/... --> PID bestanden (Process ID), file lock

<mark style="background: #FFB8EBA6;">Argumenten
</mark>

▪ Voegt extra functionaliteit aan commando’s toe
▪ Dit gebeurt door de Command Line Scan
▪ Na het scannen van de lijn knipt dit het commando in stukjes op
▪ Dit hele process heet Shell Expansion
▪ White spaces (spaties, tabs, etc) worden automatisch verwijderen
▪ Om dit te vermijden moet je enkele of dubbele quotes gebruiken
	o bv echo Hallo Hallo Hallo wordt Hallo Hallo Hallo
	o bv echo "Hallo Hallo Hallo" wordt Hallo Hallo Hallo
	o Alles tussen de quotes wordt als 1 argument bekeken
▪ Escape karakters kunnen gebruikt worden bij echo met de optie -e
	o bv echo -e "Hallo \n Hallo" wordt Hallo
	Hallo
	o \t -> tab
[[Interne commandos]]

<mark style="background: #FFB8EBA6;">Aliassen</mark>

- Een alias aanmaken gebeurt met het alias commando
	Bv alias mm- 'ls lh --color=auto'
	Bv. alias c='clear
- Met aliassen kan je bepaalde opties van een commando als standaard instellen
- Aliassen bekijken doe je ook met het alias commando
- Een alias wissen doe je met unalias
	- Bv. unalias rm
- Als je wil zien of een commando als alias werkt of niet kan je de Shell Expansions bekijken
 ▪ Dit doe je met het commando set-x om het aan te zetten, set +x is om het uit te schakele
 
<mark style="background: #FFB8EBA6;">Control Operators</mark>

Deze dienen om meer dan 1 command op 1 regel te typen
▪ ; commandos scheiden
▪ & commandos naar de achtergrond sturen (de shell wacht dus niet)
▪ $? Laatste exit code van het vorige commando
		o Bv. rm fileblablabla
		o echo $?
		o 0 -> Gelukt
		o 1 -> Niet gelukt
▪ && Logische EN. Het tweede commando wordt enkel uitgevoerd als het eerste lukt
▪ || Logische OF. Het tweede commando wordt enkel uitgevoerd als het eerste mislukt
▪ && en || If-Then-Else
▪ # Commentaar, alles na dit teken wordt genegeerd door de shell
▪ \ Karakters escapen -> Het eerst volgende teken is dus een speciaal teken
▪ \ Kan ook een EOL (End-Of-Line) betekenen op het einde van een echo
	o Hierdoor kan je 1 commando over verschillende regels typen


<mark style="background: #FFB8EBA6;">Shell Options / Shell History</mark>

Met echo $- kan je alle opties zien die momenteel actief zijn voor de shell.
	Bv. echo $-
		himbh
		set -C ; set -u
		echo $-
		himuBCH


!! --> Herhaal het laaste commando
!string --> Herhaal laaste commando startend met de string die je getypt hebt.
history --> laast u history zijn van commandos | history -5
!5 --> voert de laaste 5 commandos uit
CTRL-R --> Zoeken in de history
$HISTSIZE --> Hoeveel commandos er in de history bijgehouden worden
$HISTFILE --> Het bestand waar de history in opgeslaan is
$HISTFILESIZE --> Bepalen hoeveel commandos er bijgehouden moeten worden

<mark style="background: #FFB8EBA6;">File Globbing</mark>

![[Pasted image 20230720130603.png]]

<mark style="background: #FFB8EBA6;">Pipes and Commands</mark>

![[Pasted image 20230720130632.png]]

'>' --> output naar stdout sturen(Identiek aan 1>)
2> --> stderr bv naar /dev/null sturen
2>&1 --> zowel stdout als stderr samen naar een file sturen
'>filename --> Snel leegmaken van een bestand
'>|filename --> Snel leegmaken van een bestand wanneer noclobber actief i

<mark style="background: #FFB8EBA6;">Filters</mark>

| --> output doorsturen naar volgende command bv. cat file.txt | rm file.txt file.jpg
who | wc -l  -->Geeft weer hoeveel users er ingelogd zijn
who | cut -d' '-f1 | sort --> Een gesorteerde lijst van ingelogde users
grep bash /etc/passwd | cut -d: -f1  --> Geeft alle bash user accounts weer

grep --> Lijnen filteren uit tekst | zoek operator
grep -i --> case insensitive
grep -v --> not-matching (NIET-functie)
grep -A1 --> Neemt het resultaat en de eerst volgende lijn
grep -B1 --> Neemt het resultaat en de lijn voordien
grep -C1 --> Neemt het resultaat, de lijn voordien en de lijn nadien

cut --> Kolommen uit tekst nemen op basis van een delimiter
	Bv. cut -d: -f1,3
	Bv. cut -d" " -f1
	Je kan ook ook een aantal karakters uit een tekst halen:
		Bv. cut -c2-7 /etc/passwd

tr --> translate karakters
	Bv. cat tennis.txt | tr 'e' 'E
	Bv. cat tennis.txt | tr 'a-z' 'A-Z'
	Bv. cat count.txt | tr '\n' ' '
	Bv. cat spaces.txt | tr -s ' '      -s = squeeze spaties
	Bv. cat tennis.txt | tr -d e       -d = delete karakter

wc --> Word count.
	Bv. wc -l tennis.txt                 lijnen tellen
	Bv. wc -w tennis.txt                woorden tellen
	Bv. wc -c tennis.txt                 karakters tellen

sort sorteren
	Bv. sort -k1 country.txt           sorteer op kolom 1
	Bv. sort -n -k3 country.txt       sorteer numeriek op kolom 3

uniq duplicaten verwijderen
	Bv. sort music.txt | uniq          sorteren
	Bv. sort music.txt | uniq -c      sorteren en aantal keren
												   ervoor printen

<mark style="background: #FFB8EBA6;">Basic Unix Tools</mark>

Find /etc > etcfiles.txt --> Alles bestanden in /etc in etcfiles.txt plaatsen
find -iname -->  NIET hoofdlettergevoelig zoeken
find . -type f -name "*.conf"  --> Alle *.conf bestanden (geen mappen)
find . -name "*.conf"  --> Alle *.conf bestanden (incl mappen)
find /date -type d -name "*.bak"  --> Alle *.bak mappen
find . -newer file42.txt  --> Alle bestanden nieuwer dan file42.txt
find /date -name "*.odf" -exec cp {} /backup/ \;  --> Alle *.odf bestanden en kopieren naar /backup
find /date -name "*.odf" -ok rm {} \;  --> Alle *.odf bestanden verwijderen na
bevestiging
find /data -name "*.txt"  --> Alle txt files, ook in submappen
find /data -name *.txt --> Alle txt files in huidige map én alle files in .txt
mappen

locate --> Zoekt via index = sneller
updatedb --> Index updaten
date --> Datum oproepen
date +'%A %d-%m-%Y'  -->Saturday 17-04-2010
date +%s --> Seconden sinds 1969
cal --> Kalendar oproepen
cal 2 1970 --> Kalendar van Februari 1970
sleep --> Aantal seconden wachten
time --> Duur van een commando testen
gzip - gunzip  -->Zippen/unzippen met gzip
zcat - zmore  -->Gzip bestanden bekijken
bzip2 - bunzip2 --> Zippen/unzippen met bzip2
bzcat - bzmore --> Bzip2 bestanden bekijke 

tar -->  Backup van folders bv tar -c -z -v -f
			backuphomefolder.tar.gz /home/
			-c create new archive, -v verbose, -z compress
			de archive met gzip, -f file name van het
			bestand

<mark style="background: #FFB8EBA6;">Regular Expressions</mark>

![[Pasted image 20230720141458.png]]

grep u --> names Alle lijnen die u bevatten
grep in --> names Alle lijnen die 'ia' bevatten
grep -E 'i|a' --> list Alle lijnen die een i of een a bevatten
in BRE moet dit als: grep 'i\|a' list

grep -E 'o*' list --> Alle lijnen die 0, 1 of meer o's bevatten
grep -E 'o+' list --> Alle lijnen die 1 of meer o's bevatten
grep -E 'a$ names --> Alle lijnen die op a eindigen
grep -E ^F names -->Alle lijnen die met een f beginnen
Het $ en ^ teken worden anchors genoed in een regex

grep '\bover\b' test --> Alle lijnen waar het woord 'over' in staat (geen spaties,
letters, cijfers, punten, kommas,etc er voor of erna)

grep -w over text --> Identiek
grep -i v Case insensitive
grep -v --> Exclude
grep -w --> Woord
grep -A5 --> 5 regels erna
grep -B5 --> 5 regels ervoor
grep -C5 --> 5 regels ervoor en erna

![[Pasted image 20230720141712.png]]

sed -->stream editor met regex
echo Sunday | sed 's/Sun/Mon/' output --> Monday
echo Sunday | sed 's/Sun/&&/' output --> SunSunday
echo Sunday | sed 's_\(Sun\)_\1ny_' output --> Sunnyday
echo 2014-01-01 | sed 's/....-..-../YYYY-MM-DD/' output --> YYYY-MM-DD
echo 2014-04-01 | sed 's/\(....\)-\(..\)-\(..\)/\1+\2+\3/' output --> 2014+04+01

echo -e 'today\tis\twarm'  --> output -> today is warm
echo -e 'today\tis\twarm' | sed 's_\s_ _g  -->' output -> today is warm
cat list2 | sed 's/ooo\?/A/'  -->? betekent optioneel
cat list2 | sed 's/o\{3\}/A/'  --> Exact 3 o's
cat list2 | sed 's/o\{2,3\}/A/'  -->Minimaal 2, maximaal 3 o'

<mark style="background: #FFB8EBA6;">Users</mark>

whoami: --> geeft de username waarmee u bent aangemeld
who: --> geeft een lijst van welke is aangemeld op het systeem
who am i: --> geef u terug wie u bent
w: --> geeft een lijst en laat zien wat ze aan het doen zijn
id: --> geeft uw userid, primary group id, en laat de groups zien waar jij lid van ben

<mark style="background: #D2B3FFA6;">useradd: </mark>voegt een user toe. useradd -m -d /home/yanina -c "yanina wickmayer"
-m geeft aan om een home folder te maken. -d is om de locatie van de homefolder in te
stellen. -c (niet van groot belang) is om een descriptie toe te voegen

<mark style="background: #D2B3FFA6;">usermod:</mark> veranderd de descriptie van een gebruiker -c heeft geen nut geeft gewoon wat informatie.

<mark style="background: #D2B3FFA6;">passwd: </mark>commando om het wachtwoord van een gebruiker te veranderen. Eerst het oud
wachtwoord daarna 2x het nieuwe wachtwoord. Er zit ook een sterkte meter op het
passwd. De root gebruiker heeft dit allemaal niet als die een wachtwoord wilt wijzigen
van een gebruiker.

<mark style="background: #D2B3FFA6;">chage:</mark> wordt gebruikt om ‘expire’ date toe te voegen aan uw user account (-E), (-m) zet een
minimum en (-M) maximum passwoord leeftijd (de leeftijd dat een paswoord mag
gebruikt worden), en zet het aantal dagen voor de ‘expire’ date van het paswoord.

mkdir /home/laura: --> maak een home directorie voor de gebruiker laura aan. 
Als er nog geen gebruiker laura is wordt root de user van map laura.

chown: --> veranderd de eigenaar van een map. Bv. chown laura:laura /home/laura

userdel -r:  --> verwijderd de home folder van de gebruiker samen met de gebruiker.

usermod -s /bin/bash laura:  --> veranderd de shell van de gebruiker in dit geval wordt de shell van de
gebruiker laura veranderd naar /bin/bash
usermod -L laura:  -->Disabled het account van de gebruiker Laura.(-U om het terug te activeren)

shadow file: alle gebruikers wachtwoorden die geëncrypteerd zijn.

openssl passwd: genereert verschillende afzonderlijke hashes hetzelfde wachtwoorde,
hiervoor wordt een salt gebruikt. (encryptie).
<mark style="background: #ADCCFFA6;">openssl passwd -salt 42</mark>: salt kan gekozen worden. Nu laat hij de eerste 2 characters van de hash zien.

<mark style="background: #D2B3FFA6;">useradd -m -p $(openssl passwd hunter2) Jacy </mark>--> voorbeeld met openssl. -p laat u een
gehashte passwoord ingeven

<mark style="background: #FFB8EBA6;">Groepen</mark>

groupadd: --> wordt gebruikt om een gebruikersgroep aan te maken

groups --> laat de groepen zien waartoe een gebruiker behoort

usermod--> kan je ook gebruik maken om users toe te voegen aan een groep wel
oppassen zonder parameters zal de user verwijderd worden uit alle
groepen waar hij toe hoort. usermod -a -G tennis inge -> -a staat voor
append.

groupmod --> verander de gegevens van een groep zoals groep naam. groupmod -n darts
snooker -> verander de groep naam van darts naar snooker

groupdel --> verwijderd een groep bv. groupdel tennis

gpasswd --> hoofdgebruiker van een groep aanmaken. Bv gpasswd -A serena sports
-> serena kan nu mensen toevoegen en verwijderen uit de groep
sports.

gpasswd -a harry sports --> nieuwe user in groep toevoegen kan nu ook door administrator serena van het vorige commando

<mark style="background: #FFB8EBA6;">Scripting</mark>

![[Pasted image 20230720144255.png]]

	test
	test 10 -gt 55 ; echo $? output -> 1
	[ 56 -gt 55 ] && echo true || echo false output -> true
	test geeft altijd een true of false terug
	if then else
	if [ -f isist.txt ]
	then echo isit.txt exists!
	else echo isit.txt not found!
	fi
	for loop
	for i in 1 2 4
	do
	echo $i
	done
	for counter in `seq 1 20`
	do
	echo counting from a to 20, now at $counter
	sleep 1
	done
	for counter in {1...20}
	do
	echo counting from 1 to 20, now at $counter
	sleep 1
	done
	for (( counter = 1; counter <= 20; counter++ ))
	do
	echo counting from 1 to 20, now at $counter
	sleep 1
	done
	while loop
	i=100;
	while [ $i -ge 0 ]
	do
	echo Counting down from 100 to 0, now at $i;
	let i--;
	done
	until loop
	let i=100;
	until [ $i -le 0 ]
	do
	echo Counting down from 100 to 1, now at $i;
	let i++;
	done
	Scripting Parameters
	Een bash shell script kan parameters hebben. Deze worden in het script opgeroepen dmv het $ teken.
	$0 is de naam van het script
	$1 is het eerste argument
	$2 is het tweede argument
	...
	Het shift commando kan in een loop door deze parameters lopen.
	if [ "$#" == "0" ]
	then
	echo You have to give at least one parameter.
	exit 1
	fi
	while (( $# ))
	do
	echo You gave me $1
	shift
	done
	Met het read commando kan je een gebruiker iets laten intypen (zoals de Invoer klasse bij Java).
	echo -n Enter a number:
	read number
	Een Script kan ook script options hebben, deze verschillende tov parameters.
	while getopts ":afz" option;
	do
	case $option in
	a)
	echo received -a
	;; f)
	echo received -f
	;; z)
	echo received -z
	;; *)
	echo "invalid option -$OPTARG"
	;; esac
	done
	Je geeft vervolgens bij het runnen van het script 0, 1 of meerdere opties mee.
	Bv. ./test.sh -afz
	Een option kan ook een eigen parameter hebben.
	while getopts ":af:z" option;
	do
	case $option in
	a)
	echo received -a
	;; f)
	echo received -f with $OPTARG
	;; z)
	echo received -z
	;; :)
	echo "option -$OPTARG needs an argument"
	;; *)
	echo "invalid option -$OPTARG"
	;; esac
	done
	Je geeft vervolgens bij het runnen van het script 0, 1 of meerdere opties mee, inclusief een
	argument indien een optie deze nodig heeft.
	Bv. ./test.sh -zaf 42
	De shell zelf heeft ook opties, met het shopt commando kan je aan de shell vragen of deze opties geset
	zijn of niet.
	shopt -q cdspell ; echo $?

#linux
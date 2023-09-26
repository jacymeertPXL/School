▪ Externe commandos staan in /sbin of /bin
▪ Interne commandos maken deel van de shell zelf
▪ Met type kan je bepalen of het commando intern of extern is
	o Bv. type cd geeft als output -> cd is a shell builtin >>> INTERN
	o Bv. type cat geeft als output -> cat is /bin/cat >>> EXTERN
▪ Sommige commandos hebben zowel een interne als externe versie
▪ Met -a kan je kan zien of een commando zowel een interne als externe versie heeft
	o Bv. -a echo geeft als output -> echo is a shell builtin
	echo is /bin/echo
▪ Om expliciet het externe commando te gebruiken moet je het volledige pad intypen
▪ Met which kan je naar binaries zoeken in de $PATH variabele
o Bv. which cp ls cd mkdir pwd geeft als output ->
o /bin/cp
o /bin/ls
o /usr/bin/which: no cd in (/usr/kerberos/sbin:/usr/kerberos/bin:...)
o /bin/mkdir
o /bin/pwd

#linux

````linux
man apt --> advanced package system 
sudo apt update --> update van u repssitories
sudo apt install zip --> install zip command
sudo apt remove zip --> removed zip

gzip text.txt --> compressed de file 
gunzip text.txt --> compressed de file 

tar -cf Downloads.tar Downloads --> downloads directory in 1 file 
tar -tf Downloads.tar --> geef de content van de file weer 

tarball
	tar -czf Downloads.tar Downloads --> downloads directory in 1 file 
	tar -tzf Downloads.tar --> geef de content van de file weer 
	gaat het compressen 

Extract a tar
	tar -xzf Downloads.tar.gz -C backup --> unpack de gzip
	tar -xf Downloads.tar -C /tm --> unpack de tar

`````

De opdracht `tar -xzf Downloads.tar.gz -C backup` voert de volgende taken uit:

1. `tar`: Dit is het commando voor het werken met tar-archieven (tarballs).
    
2. `-xzf`: Dit zijn de opties voor het `tar`-commando:
    
    - `-x`: Geeft aan dat je bestanden uit het archief wilt extraheren (uitpakken).
    - `-z`: Geeft aan dat het archief is gecomprimeerd met gzip.
    - `-f`: Geeft aan dat je het volgende argument als de naam van het archief wilt beschouwen.
3. `Downloads.tar.gz`: Dit is het naam van het archiefbestand dat je wilt uitpakken. In dit geval, `Downloads.tar.gz`.
    
4. `-C backup`: Dit is een optie voor het `tar`-commando die aangeeft dat je de bestanden wilt uitpakken in een specifieke doeldirectory, in dit geval, "backup."
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
tar
Extract a tar
	tar -xzf Downloads.tar.gz -C backup --> unpack de gzip
	tar -xf Downloads.tar -C /tm --> unpack de tar

snap search [packages] --> zoekt voor een package 
sudo snap install [package] --> install package

`````

## [zip vs gzip](https://d-ries.github.io/linux-essentials/#/./06_software/01_course?id=zip-vs-gzip)
	`gzip` compresses only one file and therefore is used with `tar` which brings multiple files into one file.  
	`zip` is used when you want to compress a bunch of files into one file in one step.

[[tar]]

#linux 

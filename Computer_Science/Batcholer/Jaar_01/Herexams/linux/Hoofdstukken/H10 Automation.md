````linux
nano helloworld.sh --> bash script aanmaken

#!/bin/bash --> OPLETTEN ZONDER DIT WERKT U SCRIPT NIET
echo "hello world"
echo "this is our first bash script"

chmod u+x helloworld.sh -->OPLETTENZONDER DIT WERKT U SCRIPT NIET RECHTEN GEVEN

./helloworld.sh --> Script uit voeren
`````

````linux
"$(date)" --> date 
"$USER" --> user
"HOME" --> homefolder
$(ls -A1 ~ | wc -l) --> commands kunnen ook

# This will create a variable with the current date as value
createdate=$(date +"%Y-%m-%d")
!!!
touch ~/${createdate}-superfile && echo "File ${createdate}-superfile created/touched in homedir."

echo "Enter the absolute path of a folder you want to check:"
read folder
echo "The selected folder is $folder." 


student@linux-ess:~$ nano params.sh
student@linux-ess:~$ cat params.sh
echo Param one is: $1
echo Param two is: $2
student@linux-ess:~$ chmod u+x params.sh
student@linux-ess:~$ ./params.sh first 2nd
Param one was: first
Param two was: 2nd

echo "hello world" | at now + 1 minutes --> binnen 1 minute uitvoeren
echo "hello world" | at 14:00 --> om 2 uur

at -l --> om te kijken wanneer er timings zijn
at -d [timing] --> om timing weg te halen
at -d 2 --> timing 2 weg

KIJK VOOR CONTRAB NAAR DE CURSUS
`````
[[Crontab]]

#linux 
**user**

Task 3
	Create a user with following characteristics:  
	User-name: john  
	User-ID: 1111  
	Group-ID: 100 (=users)  
	Description: John Doe  
	Home-dir: /home/john  
	Shell: /bin/bash
````linux
sudo useradd -u 1111 -g 100 -c "John Doe" -m -d /home/john -s /bin/bash john
`````
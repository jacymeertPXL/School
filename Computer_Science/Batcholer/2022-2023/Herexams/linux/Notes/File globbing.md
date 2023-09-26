1. `*` (Asterisk):
    
    - Description: Matches zero or more characters in a filename.
    - Example: `*.txt` matches all files with a ".txt" extension.
2. `?` (Question Mark):
    
    - Description: Matches any single character in a filename.
    - Example: `file?.txt` matches "file1.txt," "file2.txt," etc.
3. `[ ]` (Square Brackets):
    
    - Description: Matches a single character from a specified set or range of characters.
    - Example: `[abc]file.txt` matches "afile.txt," "bfile.txt," or "cfile.txt."
    - Example with a range: `[1-5]file.txt` matches "1file.txt," "2file.txt," and so on up to "5file.txt."
4. `!` (Exclamation Mark):
    
    - Description: Negates a pattern, meaning it matches anything that doesn't match the pattern.
    - Example: `!*.txt` matches all files except those with a ".txt" extension.
5. `{ }` (Curly Braces):
    
    - Description: Specifies alternative patterns to match.
    - Example: `{file1,file2}.txt` matches "file1.txt" or "file2.txt."
6. `~` (Tilde):
    
    - Description: Represents a user's home directory.
    - Example: `~/Documents` refers to the "Documents" directory in the user's home directory.
7. `./` (Dot Slash):
    
    - Description: Represents the current directory.
    - Example: `./file.txt` refers to the file "file.txt" in the current directory.
8. `../` (Double Dot Slash):
    
    - Description: Represents the parent directory (one level up from the current directory).
    - Example: `../folder/file.txt` refers to the "file.txt" in the "folder" directory, which is one level up from the current directory.

![[Pasted image 20230903181903.png]]

![[Pasted image 20230903181926.png]]

#linux 
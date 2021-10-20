# wewillrockyou

I have heard of the password list rockyou.txt before. I quickly searched it up on github and got a copy onto my machine.
I already had john the ripper installed. From there, I just ran the following.
```
office2john we_will_rockyou.xls > hash.txt
john hash.txt --wordlist=rockyou.txt
john --show --format=oldoffice hash.txt
```
The password was "obietcool".

Using libreoffice calc, I see that opening the file gives a sheet that just says "not that simple :p", but then I 
just clicked on "Sheet -> Show Sheet -> Sheet 2" and it gave me the flag. Guess it is that simple.

Flag: `fsF4r0khBul54rAcyber`

# sus\_cmd.bin

One thing I want to get out of the way- I don't actually think this is an exe file. I think this is a memory dump at some point. But it
has enough information to disassemble and decompile. This challenge took me the longest, and I went through many false leads as I kept assuming it was some weird exe file.

One problem I had was that ghidra was not decompiling this for some reason. It turned out this was an open unresolved issue on the github
that was opened a few weeks prior to the competition. *Sigh*. They gave a temporary solution, and it worked. 

Anyway, I just looked around for suspicious functions around, and foudn fcn009a1c40.
You can see `sus.txt` for my decompilation efforts, but the gist of it is that it
was XOR-ing some values  together in a loop, and whenever I see xoring that isn't some
optimisation to clear a register, I get...._suspicious_. I figured it was
xoring with fixed values, which were being padded by being repeated (e.g: Xoring with a key of "AB", if you want to XOR with "XYZW", it would pad out the key to "ABAB".). 

I still couldn't figure out where the ciphertext was though.

Since I knew the key now, and I could guess the first two characters of the flag (It usually has the format `fs{flag}cyber` or `fs{flag}cyberx`), I decided to exclusive or the first byte of the key with 'f', and the second byte of the key with 's', then searched for it in the sus\_cmd.bin file. Miraculously, that worked. There was only one instance of that particular pattern. I did the decryption on the rest of the values following that, and got the flag. You can see the code in `solver.py`

Flag: `fsb4clC2BasZb0icyberx`
Side-Note: Usually the flag means something. What is this? Back2bassboi?

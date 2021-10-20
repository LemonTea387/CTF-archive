#!/usr/bin/env python

# Decompilation showed that it was being xored with this (see: sus.txt, fcn009a1c40)

xorry = [0x5b, 0x3c, 0x4d, 0x6f, 0xd2, 0xe5, 0x66]

# We know the flag is 21 bytes from the decompilation (same function, see the loop)
flag = "?"*21

# Okay, this was stupid, but I knew it had to start with a "fs", so I XORED
# ord('f') with xorry[0], and ord('s') with xorry[1], which have 0x3d and 0x4f.
# Then in Okteta (my hex editor), I searched for these values. (I was also prepared
# to search for "cyber" xored since I know the flag is 21 bytes, but STUPIDLY 
# this particular challenges ends with cyberx not cyber. Sigh. Lucky I didn't need it)
# Finally, I saw that only one instance of 0x3d followed by 0x4f existed, took a chance,
# and copied the 21 bytes in there to a C array, converted it to a python list,
# and xored it together now.

target = [ 0x3d, 0x4f, 0x2f, 0x5b,
    0xb1, 0x89, 0x25, 0x69,
    0x7e, 0x2c, 0x1c, 0x88,
    0x87, 0x56, 0x32, 0x5f,
    0x34, 0x0d, 0xb7, 0x97,
    0x1e ]

flag = ''.join([chr(target[_] ^ xorry[_ % len(xorry)]) for _ in range(len(target))])
print("Flag: {}".format(flag))

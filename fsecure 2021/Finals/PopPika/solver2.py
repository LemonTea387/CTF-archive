#!/usr/bin/env python

heh = [33, 59, 0, 117, 32, 0, 44, 1, 23, 121, 15, 114, 32, 56, 32, 32, 53, 48]

arg1 = "GHDFCABE"
i = len(arg1)
sb = ''
for i2 in range(len(heh)):
    sb= sb + (chr(ord(arg1[i2 % i]) ^ heh[i2]))

print(sb)

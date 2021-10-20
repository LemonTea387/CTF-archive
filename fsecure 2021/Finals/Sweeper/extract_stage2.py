#!/usr/bin/env python

file = open("stage2_enc_bin.txt")
fileWrite = open("stage2_func.bin", "wb")

# Genius idea of replacing a newline with a space I found in stackoverflow
# lol
# https://stackoverflow.com/a/16926952
hexpairs = file.read().replace('\n', ' ').split(" ")
hexpairs = [_.strip() for _ in hexpairs]
hexpairs = [_ for _ in hexpairs if _ != '']
file.close()

xorry =  b"\xaa\x74\x0d\xf1\xe8\x08"

index = 0
for pair in hexpairs:
    first = pair[:2]
    second = pair[2:]
    fileWrite.write((xorry[(index + 0) % 6] ^ int(first, 16)).to_bytes(1, byteorder='big'))
    fileWrite.write((xorry[(index+1) % 6] ^int(second, 16)).to_bytes(1, byteorder='big'))
    index += 2


fileWrite.close()

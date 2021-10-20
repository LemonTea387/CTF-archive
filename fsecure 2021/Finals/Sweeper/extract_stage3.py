#!/usr/bin/env python

file = open("stage2_func.bin", 'rb')
fileWrite = open("stage3_func.bin", "wb")

xorry =  0x4a

hexbytes = file.read()[0x2c:0x3e]
flag = ""
for cur_byte in hexbytes:
    flag += chr(cur_byte ^ xorry)

fileWrite.write(bytes(flag, 'utf8'))
print(flag)


fileWrite.close()

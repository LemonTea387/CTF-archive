# Psimpley

It is immediately obvious by looking at the file or using a tool like detect it easy that it is a compiled
python binary. I opted to use [pyinstxtractor](https://github.com/extremecoders-re/pyinstxtractor) to
extract the python code. Very frustratingly, I kept running into errors. Eventually, I realised that the challenge
code was written in python 3.7, and older version of python that I couldn't decompiler with my python3.9 binaries.
So I installed python3.7, created a `virtualenv`, ran pyinstxtractor, and got the python file.

```
# uncompyle6 version 3.7.4
# Python bytecode 3.7 (3394)
# Decompiled from: Python 3.7.11 (default, Sep 22 2021, 10:50:49) 
# [GCC 11.1.0]
# Embedded file name: psimpley.py
import sys, struct

def kjcvnlvvlk():
    if not sys.executable:
        return
    with open(sys.executable, 'rb') as (fi):
        sdfsafasdf = fi.read(500)
        if not sdfsafasdf:
            return
        njkldfgzsjldkvb = 'HHHHHHHHHHHHHH4HHH10Hi'
        zdswerfkjzsdcmnfsd = 'IHHIIIHHHBBIIIIIQIIHHHHHHIIIIHHQQQQII'
        vndjkfnklzfds = struct.unpack(njkldfgzsjldkvb, sdfsafasdf[0:struct.calcsize(njkldfgzsjldkvb)])
        hjbkdsfzsdfkjhb = struct.unpack(zdswerfkjzsdcmnfsd, sdfsafasdf[vndjkfnklzfds[(-1)]:vndjkfnklzfds[(-1)] + struct.calcsize(zdswerfkjzsdcmnfsd)])
        return [
         vndjkfnklzfds[0] >> 8,
         vndjkfnklzfds[0] & 255,
         vndjkfnklzfds[1] & 255,
         vndjkfnklzfds[(-1)] & 255,
         hjbkdsfzsdfkjhb[0] >> 8,
         hjbkdsfzsdfkjhb[0] & 255,
         hjbkdsfzsdfkjhb[1] >> 8,
         hjbkdsfzsdfkjhb[1] & 255,
         hjbkdsfzsdfkjhb[2] & 255,
         hjbkdsfzsdfkjhb[7] & 255,
         hjbkdsfzsdfkjhb[9] & 255]


def nldjkfvljnksdzv(sDFjnklsdWEDC, sdvjkdweKLJN):
    return [sDFjnklsdWEDC[qqqq] ^ sdvjkdweKLJN[(qqqq % len(sdvjkdweKLJN))] for qqqq, _ in enumerate(sDFjnklsdWEDC)]


jhbdkfflkj = b'<>\xe0\x81t>\xf5\x103Nbi?\xf4\xcb&?\xeb\x146N=(.\xe9\x9a "'

def main():
    dvdflzkvjnlvn = input('Please enter the password: ')
    if len(dvdflzkvjnlvn) != 28:
        print('Wrong password!')
        return
    dvdflzkvjnlvn = list((ord(qqqqq) for qqqqq in dvdflzkvjnlvn))
    for lllll, aaaaaa in zip(jhbdkfflkj, nldjkfvljnksdzv(dvdflzkvjnlvn, kjcvnlvvlk())):
        if lllll != aaaaaa:
            print('Wrong password!')
            return

    print('All good!')


if __name__ == '__main__':
    main()
# okay decompiling psimpley.exe_extracted/psimpley.pyc
```

Note that at one point, it will read itself (sys.executable) and use it as a key of sorts.
Usually, this will be `psimpley.exe`, but if running the python file directly, that won't be the case.
To fix this, I changed sys.executable to point to 'psimpley.exe'.

Here is my solver.

```
import sys, struct
import string

def kjcvnlvvlk():
    if not sys.executable:
        return
    with open(sys.executable, 'rb') as (fi):
        sdfsafasdf = fi.read(500)
        if not sdfsafasdf:
            return
        njkldfgzsjldkvb = 'HHHHHHHHHHHHHH4HHH10Hi'
        zdswerfkjzsdcmnfsd = 'IHHIIIHHHBBIIIIIQIIHHHHHHIIIIHHQQQQII'
        vndjkfnklzfds = struct.unpack(njkldfgzsjldkvb, sdfsafasdf[0:struct.calcsize(njkldfgzsjldkvb)])
        hjbkdsfzsdfkjhb = struct.unpack(zdswerfkjzsdcmnfsd, sdfsafasdf[vndjkfnklzfds[(-1)]:vndjkfnklzfds[(-1)] + struct.calcsize(zdswerfkjzsdcmnfsd)])
        return [
         vndjkfnklzfds[0] >> 8,
         vndjkfnklzfds[0] & 255,
         vndjkfnklzfds[1] & 255,
         vndjkfnklzfds[(-1)] & 255,
         hjbkdsfzsdfkjhb[0] >> 8,
         hjbkdsfzsdfkjhb[0] & 255,
         hjbkdsfzsdfkjhb[1] >> 8,
         hjbkdsfzsdfkjhb[1] & 255,
         hjbkdsfzsdfkjhb[2] & 255,
         hjbkdsfzsdfkjhb[7] & 255,
         hjbkdsfzsdfkjhb[9] & 255]


def nldjkfvljnksdzv(sDFjnklsdWEDC, sdvjkdweKLJN):
    return [sDFjnklsdWEDC[qqqq] ^ sdvjkdweKLJN[(qqqq % len(sdvjkdweKLJN))] for qqqq, _ in enumerate(sDFjnklsdWEDC)]


target_bytearray = b'<>\xe0\x81t>\xf5\x103Nbi?\xf4\xcb&?\xeb\x146N=(.\xe9\x9a "'

def main():
    sys.executable = "psimpley.exe"
    print (sys.executable)
    # flag_input = input('Please enter the password: ')
    # if len(flag_input) != 28:
        # print('Wrong password!')
        # return
    # Convert to list of numbers
    # flag_input = list((ord(cur_char) for cur_char in flag_input))

    flag = ''
    for target_index in range(len(target_bytearray)):
        target = target_bytearray[target_index]
        for possibility in string.printable:
            flag = flag[:-1] + possibility
            flag_input = list((ord(cur_char) for cur_char in flag))
            if nldjkfvljnksdzv(flag_input, kjcvnlvvlk())[target_index] == target:
                flag += possibility
                break
    print(flag)

    # for lllll, aaaaaa in zip(target_bytearray, nldjkfvljnksdzv(flag_input, kjcvnlvvlk())):
        # if lllll != aaaaaa:
            # print('Wrong password!')
            # return

    print('All good!')


if __name__ == '__main__':
    main()
# okay decompiling psimpley.exe_extracted/psimpley.pyc

```
Flag: `fspy1nst4ll3rd3comp1l3rcyberr`
No, I do not know why there are two rs at the end.

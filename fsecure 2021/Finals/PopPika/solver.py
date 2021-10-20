#!/usr/bin/env python
import itertools
import hashlib
# GHDFCABE
possibilities = list(itertools.product(list("ABCDEFGH"), repeat=8))

target= "d8e3887ffadf22b9e8dbc3f52fe0b372"
for pos in possibilities:
    pos = ''.join(pos)
    print(pos)
    if hashlib.md5(pos.encode()).hexdigest() == target:
        print(pos)
        break

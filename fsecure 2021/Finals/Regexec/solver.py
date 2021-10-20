#!/usr/bin/env python

ciphertext = [
  47,
  54,
  16,
  33,
  126,
  2,
  61,
  12,
  57,
  61,
  38,
  4,
  27,
  32,
  48,
  120,
  61,
  0,
  59,
  28,
  52,
  48,
  44,
  82,
  59
  ]

# There's probably a cleaner way to do this but eh.


must_start_with = chr(ciphertext[0] ^ ord('f')) + chr(ciphertext[1] ^ ord('s'))

# Assuming cyber and not cyberx
must_contain =  chr(ciphertext[-5] ^ ord('c')) + \
                chr(ciphertext[-4] ^ ord('y')) + \
                chr(ciphertext[-3] ^ ord('b')) + \
                chr(ciphertext[-2] ^ ord('e')) + \
                chr(ciphertext[-1] ^ ord('r')) 

print("must start with " + must_start_with)
print("must contain " + must_contain)

# Assume we got the flag already from the above and an educated guess that the I is
# the  same one being wrapped around.
key = 'IEWIN7'

plaintext = ''
for idx, c in enumerate(ciphertext):
    plaintext += chr(c ^ ord(key[idx % len(key)]))
print("Flag: " + plaintext)

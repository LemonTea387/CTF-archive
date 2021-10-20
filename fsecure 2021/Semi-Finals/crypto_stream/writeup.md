# Cryptostream

We are given encrypt.py and flag.enc

It's very short code, but let's just trace through it first.
Looking at the code, we can see the main code that is actually executed is on line 31 onwards.
```
e = encrypt(flag, generate_key(key))
with open('flag.enc', 'w') as f:
	f.write(e)
```

Okay, so it's encryption. The flag variable, which is the first argument, and the
key variable, are both imported from a file called "secret", which you can see on line 2.
We don't have access to that unfortunately, but let's quickly look at the generate\_key function.

```
def generate_key(s):
    assert len(s) == 16, "The key must be 16 bytes long"

    k = [0, 0]
    for i in range(len(s)):
        if i == 0:
            k[0] = k[0] ^ s[i]
            k[1] = (k[1] + s[i]) & 0xFF
        else:
            k[0] = (k[0] ^ (s[i] - s[i - 1])) & 0xFF
            k[1] = (k[1] + s[i] ^ s[i - 1]) & 0xFF

    return k
```
Just quickly look at it to get an idea of what's happening. 
First off, you can see by the assert it will be a 16 byte key. Second off, it seems
it will return a list with just 2 integers, and each integer must fall without the 8-byte range
(not the masking with 0xFF). Seems like a good candidate for brute-forcing, the key is 16-bytes
but its being shrunk down into just 2 bytes. It will turn out that there would be an even simpler
way of finding the flag, but it would still be a very fast way of figuring out the flag.


Now, let's take a look at the encrypt function

```
def encrypt(s, k):
    n1 = k[0]
    n2 = k[1]

    encrypted = []
    for c in s:
        encrypted.append(c ^ n1)
        random.seed(n1)
        n1 = n2
        n2 = random.randint(0, 255)

    return bytes(encrypted).hex()
```

Before panicking when seeing the randint, because you think that introducing randomness into the situation
would make it impossible to decrypt, note how just a couple lines prior, random is being seeded with n1. This effectively gets rid of any randomness, and would be analogous to "hashing" the n1 value and using that for n2.

We can see that the first character is going to be exclusive or-ed with the first byte in the key. XOR has a property, where if P XOR K = C, it is also the case that K = C XOR P. Thinking of P as the plaintext, K as the key, and C as the ciphertext, we can see how a known-plaintext attack could work here. 

Generally, flags for this competition is in the form "fs{flag}cyber" or "fs{flag}cyberx". 
Knowing the first two characters, and having access we can figure out n1 and n2.

We can see the encrypted value is first being appended with the XOR of the plaintext's first character, then the key.
After that, n1 is set to n2's value, and n2 is set to a "random" value. In the next iteration, the next plaintext
character is XOR-ed with n1, which is actually the old value of n2, which is k[1].

Hence, we can figure out the k variable they used to generate the 'flag.enc' file by xoring
'f' with the first byte of the encrypted file, and xoring 's' with the second byte of the encrypted file,
and putting that into a list.

Looking at the cipher, we can also see that it seems to be similar to an exclusive-or cipher. As previously mentioned,
P XOR K = C, and K = C XOR P, but it is also the case that P = C XOR K. This is useful, as this is exactly the same
algorithm used for encryption as for decryption, just changing the plaintext to a ciphertext. From there, since
we already have the k variable, we can run encrypt on the encrypted file and our found keys, and then print it out.

```
import random
# from secret import flag, key

def generate_key(s):
    assert len(s) == 16, "The key must be 16 bytes long"

    k = [0, 0]
    for i in range(len(s)):
        if i == 0:
            k[0] = k[0] ^ s[i]
            k[1] = (k[1] + s[i]) & 0xFF
        else:
            k[0] = (k[0] ^ (s[i] - s[i - 1])) & 0xFF
            k[1] = (k[1] + s[i] ^ s[i - 1]) & 0xFF

    return k

def encrypt(s, k):
    n1 = k[0]
    n2 = k[1]

    encrypted = []
    for c in s:
        encrypted.append(c ^ n1)
        random.seed(n1)
        n1 = n2
        n2 = random.randint(0, 255)

    return bytes(encrypted).hex()

# e = encrypt(flag, generate_key(key))
# 
# with open('flag.enc', 'w') as f:
    # f.write(e)

with open('flag.enc', 'r') as f:
    encrypted = f.read()
    encrypted = bytes.fromhex(encrypted)

    k_0 = ord('f') ^ encrypted[0]
    k_1 = ord('s') ^ encrypted[1]
    decrypted = encrypt(encrypted, [k_0, k_1])
    decrypted = bytes.fromhex(decrypted).decode()
    print(decrypted)

```

Flag: `fsKn0wnPl41NTextA77ackcyber`

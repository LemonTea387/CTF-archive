f = open("code.txt")

lines = f.readlines()

def chunky(word):
    ret = []
    for i in range(0, len(word), 2):
        ret.append(word[i:i+2])
    return ret

write_to = open("code2.bin", 'wb')
for line in lines:
    line = line.strip()
    # write_to.write(line.to_bytes(len(line)/2, byteorder='big'))
    chunks = chunky(line)
    for i in range(len(chunks)):
        write_to.write(int(chunks[i],16).to_bytes(1, byteorder='big'))

write_to.close()
f.close()

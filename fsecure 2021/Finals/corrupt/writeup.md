# png

You simply need to change in a hex editor the width to 200 and the height to 100. Currently it is only 1 pixel by 1 pixel large. Additionally, there is a checksum in the file that needs to be fixed. You can either calculate this CRC manually or use a tool like pngcheck, then edit it in the hex editor directly.

As for how to figure out the size of the file (How do we know it's 200 by 100 bytes?), my teammate figured it out by
decopressing the image data (binwalk can do this, or you can do it manually. It's just zlib compressed data at a specific chunk), and seeing that every 200 bytes (of which are mostly 0s), there is a non-zero byte. 
Looking at the PNG specification, there is something called PNG Filters that specify some filter-type for every scanline. Each scanline is the width of the image, so we now know it is 200 bytes long. We can then do this 100 times until
we finish. Boom, now we know it is a 200 by 100 image.

Flag: `fspNg1sN1c3cyber`
Side-note: Very convenient that the file "corrupted" in such a way that the checksum was still valid :P

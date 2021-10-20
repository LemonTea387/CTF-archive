# Sweeper

Fun challenge, just time-consuming.
First off, in neovim I quickly made some macros to extract the hex data of both
the main disassembly instructions and the hexdump they gave, and then I wrote a python script to place it into a binary file. I could then re-disassemble it with `objdump -D -b binary -mi386 code2.bin -M intel --adjust-vma=0x08049186`, or with radare (or rizin) itself, with `r2 -a x86 -m 0x08049186 -b 32 code2.bin`

The 0x08049186 is just to tell objdump or radare where the starting address is.

With it loaded in radare2, I had installed the [r2ghidra](https://github.com/radareorg/r2ghidra) extension, and typing in 'af' and then 'pdg' gave a nice decompiled output.

```
void fcn.08049186(void)

{
    undefined4 uStack31;
    int32_t var_17h;
    int32_t var_13h;
    int32_t var_ch;
    int32_t var_8h;
    
    var_ch = (int32_t)&stack0x00000004;
    uStack31 = 0xf10d74aa;
    var_17h._0_2_ = 0x8e8;
    var_17h._2_1_ = 0;
    for (stack0xffffffec = 0; stack0xffffffec < 0x3e; stack0xffffffec = stack0xffffffec + 1) {
        *(uint8_t *)(stack0xffffffec + 0x804c040) =
             *(uint8_t *)((int32_t)&uStack31 + stack0xffffffec % 6) ^ *(uint8_t *)(stack0xffffffec + 0x804c040);
    }
    *NULL = func_0x08049050(0x1e);
    func_0x08049040(-*NULL & 0x804c040, *NULL, 7);
    (*(code *)0x804c040)();
    // WARNING: Bad instruction - Truncating control flow here
    halt_baddata();
}

```

I cleaned it up a little, and got to this point.
```
void fcn.08049186(void)

{
    undefined4 uStack31;
    int32_t var_17h;
    int32_t var_13h;
    int32_t var_ch;
    int32_t var_8h;
    
    var_ch = (int32_t)&stack0x00000004;
    uStack31 = 0xf10d74aa;
    var_17h._0_2_ = 0x8e8;
    var_17h._2_1_ = 0;
    for (stack0xffffffec = 0; stack0xffffffec < 0x3e; stack0xffffffec = stack0xffffffec + 1) {
        *(uint8_t *)(stack0xffffffec + 0x804c040) =
             *(uint8_t *)((int32_t)&uStack31 + stack0xffffffec % 6) ^ *(uint8_t *)(stack0xffffffec + 0x804c040);
    }
    *NULL = func_0x08049050(0x1e);
    func_0x08049040(-*NULL & 0x804c040, *NULL, 7);
    (*(code *)0x804c040)();
    // WARNING: Bad instruction - Truncating control flow here
    halt_baddata();
}

```

So, it seems like inside the loop, the code in stage 2 (0x804c040) is being xored with some other value, so I'm thinking it's decrypting this code to be executed next.

I wrote some code to extract stage 2 in 'extract\_stage2.py' (I extracted `stage_2_enc_bin.txt` from the hexdump of Sweeper.txt). 
Now on to stage 2, I ran `r2 -a x86 -m 0x0804c040 -b 32 stage2_func.bin`

It seems like a lot of junk instructions, but first the few instructions make sense. The first instruction is `jmp 0x804c067`, and the second instruction
(which is at 0x804c067) is `call fcn.0804c042`.

Printing it out, we see a bit of normal code, and then some junk code that is likely wrong.
```
void fcn.0804c042(void)
{
    code *pcVar1;
    char cVar2;
    char extraout_CH;
    int32_t iVar3;
    int32_t extraout_EDX;
    int32_t unaff_EBP;
    int32_t unaff_ESI;
    char *unaff_EDI;
    uint8_t *unaff_retaddr;
    
    iVar3 = 0x12;
    do {
        *unaff_retaddr = *unaff_retaddr ^ 0x4a;
        unaff_retaddr = unaff_retaddr + 1;
        iVar3 = iVar3 + -1;
    } while (iVar3 != 0)
    // After this is weird stuff
}
```

Okay, it seems to be doing a XOR with 0x4a, with a length of 0x12. unaff\_retaddr is the return address of the function. So it now makes sense why
the code after the call to this function looked ridiculous earlier. It was encrypted! As it turns out, it is not more code there after all. Xoring those values 
after the function call with 0x4a will give the flag, which I put in `extract_stage3.py`.

Flag: `fsL1n3ar5we3pcyber`

Side-Note: rizin/radare is great! Also, I wonder if it would be useful to have a general-purpose tool in the future to see XOR everything with a particular value to search for a flag.
It wouldn't have worked here since stage2 was encrypted though.

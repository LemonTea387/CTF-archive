# overthewire

Looking through the code in ghidra, it seems to have a server and a client thread, and the client sends the input to the server. The checking function is called FUN\_00101299.

```

bool FUN_00101299(byte *param_1,long param_2)

{
  byte bVar1;
  byte bVar2;
  byte bVar3;
  byte bVar4;
  byte bVar5;
  byte bVar6;
  byte bVar7;
  char cVar8;
  byte bVar9;
  byte bVar10;
  byte bVar11;
  byte bVar12;
  byte bVar13;
  byte bVar14;
  byte bVar15;
  byte bVar16;
  byte bVar17;
  byte bVar18;
  byte bVar19;
  byte bVar20;
  byte bVar21;
  char cVar22;
  byte bVar23;
  byte bVar24;
  byte bVar25;
  byte bVar26;
  byte bVar27;
  byte bVar28;
  byte bVar29;
  byte bVar30;
  byte bVar31;
  byte bVar32;
  byte bVar33;
  byte bVar34;
  byte bVar35;
  byte bVar36;
  byte bVar37;
  byte bVar38;
  byte bVar39;
  byte bVar40;
  byte bVar41;
  byte bVar42;
  byte bVar43;
  byte bVar44;
  byte bVar45;
  byte bVar46;
  byte bVar47;
  byte bVar48;
  byte bVar49;
  byte bVar50;
  byte bVar51;
  byte bVar52;
  byte bVar53;
  byte bVar54;
  byte bVar55;
  byte bVar56;
  byte bVar57;
  byte bVar58;
  byte bVar59;
  byte bVar60;
  byte bVar61;
  byte bVar62;
  byte bVar63;
  byte bVar64;
  byte bVar65;
  byte bVar66;
  byte bVar67;
  byte bVar68;
  byte bVar69;
  byte bVar70;
  byte bVar71;
  long lVar72;
  
  lVar72 = random();
  bVar71 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7)) >> 5 & 1;
  bVar1 = *param_1; // COMMENT FROM ME: same as param_1[0]
  bVar2 = param_1[2];
  bVar3 = param_1[5];
  lVar72 = random();
  bVar4 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar5 = param_1[1];
  bVar6 = param_1[6];
  bVar7 = param_1[0xf];
  lVar72 = random();
  cVar8 = *(char *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar9 = param_1[2];
  bVar10 = param_1[0x11];
  bVar11 = param_1[10];
  bVar12 = param_1[3];
  bVar13 = param_1[4];
  bVar14 = param_1[0x13];
  lVar72 = random();
  bVar15 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar16 = param_1[4];
  bVar17 = param_1[0xf];
  bVar18 = param_1[0xb];
  bVar19 = param_1[5];
  bVar20 = param_1[7];
  bVar21 = param_1[0xe];
  lVar72 = random();
  cVar22 = *(char *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar23 = param_1[6];
  bVar24 = param_1[0xd];
  bVar25 = param_1[9];
  bVar26 = param_1[7];
  bVar27 = param_1[0xc];
  bVar28 = param_1[0x11];
  lVar72 = random();
  bVar29 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar30 = param_1[8];
  bVar31 = param_1[0x10];
  bVar32 = param_1[2];
  bVar33 = param_1[9];
  bVar34 = param_1[0x12];
  bVar35 = param_1[5];
  bVar36 = param_1[10];
  bVar37 = param_1[0xd];
  bVar38 = param_1[9];
  lVar72 = random();
  bVar39 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar40 = param_1[0xb];
  bVar41 = param_1[3];
  bVar42 = param_1[1];
  bVar43 = param_1[0xc];
  bVar44 = *param_1;
  bVar45 = param_1[10];
  lVar72 = random();
  bVar46 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar47 = param_1[0xd];
  bVar48 = param_1[0xc];
  bVar49 = param_1[0xe];
  bVar50 = param_1[0xe];
  bVar51 = param_1[0x12];
  bVar52 = param_1[7];
  lVar72 = random();
  bVar53 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar54 = param_1[0xf];
  bVar55 = param_1[6];
  bVar56 = param_1[0x10];
  bVar57 = param_1[0x10];
  bVar58 = *param_1;
  bVar59 = param_1[4];
  lVar72 = random();
  bVar60 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar61 = param_1[0x11];
  bVar62 = param_1[3];
  bVar63 = param_1[0xb];
  bVar64 = param_1[0x12];
  bVar65 = param_1[0x13];
  bVar66 = param_1[8];
  lVar72 = random();
  bVar67 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7));
  bVar68 = param_1[0x13];
  bVar69 = param_1[1];
  bVar70 = param_1[8];
  lVar72 = random();
  return (uint)(((uint)*(byte *)(param_2 + (ulong)((uint)lVar72 & 7)) * (uint)bVar71 + (uint)bVar70
                ^ (uint)(bVar69 ^ bVar68)) == 0x69) +
         (uint)(((uint)bVar4 * (uint)bVar71 | (uint)(byte)(bVar3 ^ bVar1 ^ bVar2)) == 0x50) +
         (uint)((byte)(~(cVar8 * bVar71) & (bVar7 ^ bVar5 ^ bVar6)) == 100) +
         (uint)((byte)(bVar11 ^ bVar9 ^ bVar10) == 0x55) +
         (uint)(((uint)bVar15 * (uint)bVar71 ^ (uint)(byte)(bVar14 ^ bVar12 ^ bVar13)) == 0x74) +
         (uint)((byte)(bVar18 ^ bVar16 ^ bVar17) == 0x46) +
         (uint)((byte)(~(cVar22 * bVar71) & bVar21 ^ bVar20 ^ bVar19) == 0x35) +
         (uint)((byte)(bVar25 ^ bVar23 ^ bVar24) == 0x35) +
         (uint)((1 - (uint)bVar71 * (uint)bVar29) * (uint)(byte)(bVar28 ^ bVar26 ^ bVar27) == 0x30)
         + (uint)((byte)(bVar32 ^ bVar30 ^ bVar31) == 0x42) +
         (uint)((byte)(bVar35 ^ bVar33 ^ bVar34) == 0x33) +
         (uint)((uint)(byte)(bVar38 ^ bVar36 ^ bVar37) - (uint)bVar71 * (uint)bVar39 == 0x25) +
         (uint)((byte)(bVar42 ^ bVar40 ^ bVar41) == 0x50) +
         (uint)(((uint)bVar46 * (uint)bVar71 ^ (uint)(byte)(bVar45 ^ bVar43 ^ bVar44)) == 0x33) +
         (uint)((byte)(bVar49 ^ bVar47 ^ bVar48) == 0x70) +
         (uint)((uint)(byte)(bVar52 ^ bVar50 ^ bVar51) - (uint)bVar71 * (uint)bVar53 == 0x35) +
         (uint)((byte)(bVar56 ^ bVar54 ^ bVar55) == 0x6e) +
         (uint)(((uint)bVar60 * (uint)bVar71 ^ (uint)(byte)(bVar59 ^ bVar57 ^ bVar58)) == 0x6d) +
         (uint)((byte)(bVar63 ^ bVar61 ^ bVar62) == 0x41) +
         (uint)(((uint)bVar67 * (uint)bVar71 + (uint)bVar66 ^ (uint)(bVar65 ^ bVar64)) == 0x7f) ==
         0x14;
}
```

At first, the random() might scare you, but realise that 7 in binary is 0b111.
So `bVar71 = *(byte *)(param_2 + (ulong)((uint)lVar72 & 7)) >> 5 & 1;`, will always be zero, 
That cuts off a lot of the checks.

I believed param\_1 is the user input by the way.

My initial efforts at changing this to compile-able C++ Code can be seen at the a.cpp file, adding comments
and changing the byte to char, etc.

Eventually, I more or less understood what was going on.

a) user input is being spread across different variables.

```
  RANDOMMMMMMMMMMMMMlVar72 = random();
  bVar71 = *(char *)(param_2 + (ulong)((uint)RANDOMMMMMMMMMMMMMlVar72 & 7)) >> 5 & 1;
  bVar1 = *param_1;
  bVar2 = param_1[2];
  bVar3 = param_1[5];
  RANDOMMMMMMMMMMMMMlVar72 = random();
  bVar4 = *(char *)(param_2 + (ulong)((uint)RANDOMMMMMMMMMMMMMlVar72 & 7));
  bVar5 = param_1[1];
  bVar6 = param_1[6];
  bVar7 = param_1[0xf];
```
The values with "RANDOMMMMMMMMMMMMMlVar72" evaluate to 0 eventually are just a distraction.

b) Later on, these variables are used to check if they XOR to a particular value.
```
 return (uint)(((uint)*(char *)(param_2 + (ulong)((uint)RANDOMMMMMMMMMMMMMlVar72 & 7)) *
                 (uint)bVar71 + (uint)bVar70 ^ (uint)(bVar69 ^ bVar68)) == 0x69) +
         (uint)(((uint)bVar4 * (uint)bVar71 | (uint)(char)(bVar3 ^ bVar1 ^ bVar2)) == 0x50) +
         (uint)((char)(~(cVar8 * bVar71) & (bVar7 ^ bVar5 ^ bVar6)) == 100) +
         (uint)((char)(bVar11 ^ bVar9 ^ bVar10) == 0x55) +
         (uint)(((uint)bVar15 * (uint)bVar71 ^ (uint)(char)(bVar14 ^ bVar12 ^ bVar13)) == 0x74) +
         (uint)((char)(bVar18 ^ bVar16 ^ bVar17) == 0x46) +
         (uint)((char)(~(cVar22 * bVar71) & bVar21 ^ bVar20 ^ bVar19) == 0x35) +
         (uint)((char)(bVar25 ^ bVar23 ^ bVar24) == 0x35) +
         (uint)((1 - (uint)bVar71 * (uint)bVar29) * (uint)(char)(bVar28 ^ bVar26 ^ bVar27) == 0x30)
         + (uint)((char)(bVar32 ^ bVar30 ^ bVar31) == 0x42) +
         (uint)((char)(bVar35 ^ bVar33 ^ bVar34) == 0x33) +
         (uint)((uint)(char)(bVar38 ^ bVar36 ^ bVar37) - (uint)bVar71 * (uint)bVar39 == 0x25) +
         (uint)((char)(bVar42 ^ bVar40 ^ bVar41) == 0x50) +
         (uint)(((uint)bVar46 * (uint)bVar71 ^ (uint)(char)(bVar45 ^ bVar43 ^ bVar44)) == 0x33) +
         (uint)((char)(bVar49 ^ bVar47 ^ bVar48) == 0x70) +
         (uint)((uint)(char)(bVar52 ^ bVar50 ^ bVar51) - (uint)bVar71 * (uint)bVar53 == 0x35) +
         (uint)((char)(bVar56 ^ bVar54 ^ bVar55) == 0x6e) +
         (uint)(((uint)bVar60 * (uint)bVar71 ^ (uint)(char)(bVar59 ^ bVar57 ^ bVar58)) == 0x6d) +
         (uint)((char)(bVar63 ^ bVar61 ^ bVar62) == 0x41) +
         (uint)(((uint)bVar67 * (uint)bVar71 + (uint)bVar66 ^ (uint)(bVar65 ^ bVar64)) == 0x7f) ==
         0x14;
```
 Note that true is 1 in C, so the `== 0x14` is just making sure they all evaluate to true.
 Getting rid of the useless "Random" variables which were obfuscation, we get this cleaner code, where I additionally
 use a vector to store the solved cases.

 ```

	// RANDOMMMMMMMMMMMMMlVar72 is gone
	checks.emplace_back((bVar70 ^ bVar69 ^ bVar68) == 0x69);
    
    	// bVar71 is gone
	checks.emplace_back((bVar3 ^ bVar1 ^ bVar2) == 0x50);
    
    	// (~(cVar8 * bVar71) is gone
	checks.emplace_back((bVar7 ^ bVar5 ^ bVar6) == 100);
    
	checks.emplace_back((bVar11 ^ bVar9 ^ bVar10) == 0x55);
    
	checks.emplace_back((bVar14 ^ bVar12 ^ bVar13) == 0x74);
    
	checks.emplace_back((bVar18 ^ bVar16 ^ bVar17) == 0x46);
    
	checks.emplace_back((bVar21 ^ bVar20 ^ bVar19) == 0x35);
    
	checks.emplace_back((bVar25 ^ bVar23 ^ bVar24) == 0x35);
    
	checks.emplace_back((bVar28 ^ bVar26 ^ bVar27) == 0x30);
    
	checks.emplace_back((bVar32 ^ bVar30 ^ bVar31) == 0x42);
    
	checks.emplace_back((bVar35 ^ bVar33 ^ bVar34) == 0x33);
    
	checks.emplace_back((bVar38 ^ bVar36 ^ bVar37) == 0x25);
    
	checks.emplace_back((bVar42 ^ bVar40 ^ bVar41) == 0x50);
    
	checks.emplace_back((bVar45 ^ bVar43 ^ bVar44) == 0x33);
    
	checks.emplace_back((bVar49 ^ bVar47 ^ bVar48) == 0x70);
    
    
	checks.emplace_back((bVar52 ^ bVar50 ^ bVar51) == 0x35);
    
	checks.emplace_back((bVar56 ^ bVar54 ^ bVar55) == 0x6e);
    
	checks.emplace_back((bVar59 ^ bVar57 ^ bVar58) == 0x6d);
    
    
	checks.emplace_back((bVar63 ^ bVar61 ^ bVar62) == 0x41);
    
	checks.emplace_back((bVar66 ^ (uint)(bVar65 ^ bVar64)) == 0x7f);
 ```

 In hindsight, changing the variables to the user\_param values directly would probably have been beneficial.
 e.g: changing bVar41 to param\_1[3] directly. This would have saved a lot of scrolling. Additionally, use of a
 SAT solver would also have helped, I could just plug the values in and it should solved it. Instead, I tried
 doing it manually for a long time, and that cost my team a much higher place :'( Oh well, it's a learning experience.

 My brute-forcer I eventually made (because I kept making mistakes when doing it manually) 
 is in b.cpp, you can compile it with `g++ b.cpp` then run it with `./a.out`.

 Flag: `fsStretch3dW1r3cyber`

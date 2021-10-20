
#include <stdio.h>
#include <stdlib.h>
#include <iostream>
#include <vector>
#include <string>

typedef unsigned long ulong;
typedef unsigned int uint;


int checker (char* param_1);
int encryption_maybe(char*, char*);
int main(int argc, char ** argv){
	char buffer[500] = {0};
	//char * hello = "Hello World!!!!";
	//Got 0xf+
	//Got 0, 1
	//Got 2/0x2
	//Got 8/0x8
	//Got 5/0x5
//	char hello[21] = "fsSkmet?h3d1?r?cyber";
	//char hello[21] = "fsStretch3dW1r3cyber";
    char hello[21]   = "fs?????????????cyber";
	//std::cout << std::hex << hello[1] << " " << hello[0xf] << std::endl;

//     std::cout << 
//	int a = encryption_maybe(hello, buffer);
    if (argc != 2){
        while (std::string(hello).find("?") != std::string::npos )
            int lengthh = checker(hello);
//         std::cout << lengthh << std::endl;
    }
    else {
        int lengthh = checker(argv[1]);
        std::cout << lengthh << std::endl;
        
    }
    /*
    int initial = checker(hello);
    for (int ii = 2; ii < 0x13;ii++) {
        char before = hello[ii];
        for (int i = '0'; i < 'Z' ; i++) {
            hello[ii] = i;
            int newLength = checker(hello);
            if (newLength < initial) {
                    std::cout << "Got something: " << i << std::endl;
            }
        }
        hello[ii] = before;
    }
    
    */

	printf("%s\n", buffer);
}
  
  int countKnown(char* c, int index1, int index2, int index3, int target) {
      
      int ret = -1;
      int xorry = 0;
      int length = 0;
      if (c[index1] != '?') {length++;}
      if (c[index2] != '?') {length++;}
      if (c[index3] != '?') {length++;}
      if (length != 2) {return ret;}
      else{
    
      if (c[index1] == '?') {ret = index1; xorry = c[index2] ^ c[index3] ^ target;}
      if (c[index2] == '?') {ret =index2; xorry = c[index1] ^ c[index3] ^ target;}
      if (c[index3] == '?') {ret= index3; xorry = c[index1] ^ c[index2] ^ target;}
      }
      
      c[ret] = xorry;
      std::cout << c << std::endl;
      // Don't want output
      return -1;
      return ret;
  }

int checker (char* param_1){
  char bVar1;
  char bVar2;
  char bVar3;
  char bVar4;
  char bVar5;
  char bVar6;
  char bVar7;
  char cVar8;
  char bVar9;
  char bVar10;
  char bVar11;
  char bVar12;
  char bVar13;
  char bVar14;
  char bVar15;
  char bVar16;
  char bVar17;
  char bVar18;
  char bVar19;
  char bVar20;
  char bVar21;
  char cVar22;
  char bVar23;
  char bVar24;
  char bVar25;
  char bVar26;
  char bVar27;
  char bVar28;
  char bVar29;
  char bVar30;
  char bVar31;
  char bVar32;
  char bVar33;
  char bVar34;
  char bVar35;
  char bVar36;
  char bVar37;
  char bVar38;
  char bVar39;
  char bVar40;
  char bVar41;
  char bVar42;
  char bVar43;
  char bVar44;
  char bVar45;
  char bVar46;
  char bVar47;
  char bVar48;
  char bVar49;
  char bVar50;
  char bVar51;
  char bVar52;
  char bVar53;
  char bVar54;
  char bVar55;
  char bVar56;
  char bVar57;
  char bVar58;
  char bVar59;
  char bVar60;
  char bVar61;
  char bVar62;
  char bVar63;
  char bVar64;
  char bVar65;
  char bVar66;
  char bVar67;
  char bVar68;
  char bVar69;
  char bVar70;
  char bVar71;
  
  int unknown;
  int current=1;
  bVar1 = *param_1;
  bVar2 = param_1[2];
  bVar3 = param_1[5];
  unknown = countKnown(param_1, 0, 2, 5, 0x50);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar5 = param_1[1];
  bVar6 = param_1[6];
  bVar7 = param_1[0xf];
  unknown = countKnown(param_1, 1, 6, 0xf, 100);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar9 = param_1[2];
  bVar10 = param_1[0x11];
  bVar11 = param_1[10];
  unknown = countKnown(param_1, 2, 0x11, 10, 0x55);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar12 = param_1[3];
  bVar13 = param_1[4];
  bVar14 = param_1[0x13];
  unknown = countKnown(param_1, 3, 4, 0x13, 0x74);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar16 = param_1[4];
  bVar17 = param_1[0xf];
  bVar18 = param_1[0xb];
  unknown = countKnown(param_1, 4, 0xf, 0xb, 0x46);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar19 = param_1[5];
  bVar20 = param_1[7];
  bVar21 = param_1[0xe];
  unknown = countKnown(param_1, 5, 7, 0xe, 0x35);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar23 = param_1[6];
  bVar24 = param_1[0xd];
  bVar25 = param_1[9];
  unknown = countKnown(param_1, 6, 0xd, 9, 0x35);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar26 = param_1[7];
  bVar27 = param_1[0xc];
  bVar28 = param_1[0x11];
  unknown = countKnown(param_1, 7, 0xc, 0x11, 0x30);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar30 = param_1[8];
  bVar31 = param_1[0x10];
  bVar32 = param_1[2];
  unknown = countKnown(param_1, 8, 0x10, 2, 0x42);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar33 = param_1[9];
  bVar34 = param_1[0x12];
  bVar35 = param_1[5];
  unknown = countKnown(param_1, 9, 0x12, 5, 0x33);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar36 = param_1[10];
  bVar37 = param_1[0xd];
  bVar38 = param_1[9];
  unknown = countKnown(param_1, 10, 0xd, 9, 0x25);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar40 = param_1[0xb];
  bVar41 = param_1[3];
  bVar42 = param_1[1];
  unknown = countKnown(param_1, 0xb, 3, 1, 0x50);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar43 = param_1[0xc];
  bVar44 = *param_1;
  bVar45 = param_1[10];
  unknown = countKnown(param_1, 0xc, 0, 10, 0x33);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar47 = param_1[0xd];
  bVar48 = param_1[0xc];
  bVar49 = param_1[0xe];
  unknown = countKnown(param_1, 0xd, 0xc, 0xe, 0x70);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar50 = param_1[0xe];
  bVar51 = param_1[0x12];
  bVar52 = param_1[7];
  unknown = countKnown(param_1, 0xe, 0x12, 7, 0x35);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar54 = param_1[0xf];
  bVar55 = param_1[6];
  bVar56 = param_1[0x10];
  unknown = countKnown(param_1, 0xf, 6, 0x10, 0x6e);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar57 = param_1[0x10];
  bVar58 = *param_1;
  bVar59 = param_1[4];
  unknown = countKnown(param_1, 0x10, 0, 4, 0x6d);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar61 = param_1[0x11];
  bVar62 = param_1[3];
  bVar63 = param_1[0xb];
  unknown = countKnown(param_1, 0x11, 3, 0xb, 0x41);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar64 = param_1[0x12];
  bVar65 = param_1[0x13];
  bVar66 = param_1[8];
  unknown = countKnown(param_1, 0x12, 0x13, 8, 0x7f);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  
  bVar68 = param_1[0x13];
  bVar69 = param_1[1];
  bVar70 = param_1[8];
  unknown = countKnown(param_1, 0x13, 1, 8, 0x69);
  if (unknown != -1) {
      std::cout << "Potential: " << unknown << " at index " << current << std::endl;
  }
  current++;
  	std::vector<bool> checks; 
    
    
    
    
    
	checks.emplace_back((bVar3 ^ bVar1 ^ bVar2) == 0x50);
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
	checks.emplace_back((bVar70 ^ bVar69 ^ bVar68) == 0x69);
    
    
    
    
    
    
    
    
    
    
    int length = 0;
    int ind=1;
//     for (auto i: checks){
//             if (i){
//                 std::cout << ind << " - YES" << std::endl;
//                 length++;
//             }
//             else {
//                 std::cout << ind << " - NO" << std::endl;   
//             }
//             ind++;
//     }
        return length;
}

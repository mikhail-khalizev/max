using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6144-ed57ae37")]
        public void Method_100d_6144()
        {
            ii(0x100d_6144, 5);  push(0x90);                           /* push 0x90 */
            ii(0x100d_6149, 5);  call(Definitions.sys_check_available_stack_size, 0x8_fc04);/* call 0x10165d52 */
            ii(0x100d_614e, 1);  push(esi);                            /* push esi */
            ii(0x100d_614f, 1);  push(edi);                            /* push edi */
            ii(0x100d_6150, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_6151, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_6153, 6);  sub(esp, 0x80);                       /* sub esp, 0x80 */
            ii(0x100d_6159, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_615c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_615f, 3);  mov(memd[ss, ebp - 12], ebx);         /* mov [ebp-0xc], ebx */
            ii(0x100d_6162, 3);  mov(memd[ss, ebp - 8], ecx);          /* mov [ebp-0x8], ecx */
            ii(0x100d_6165, 7);  mov(memd[ss, ebp - 20], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x100d_616c, 7);  mov(memd[ss, ebp - 24], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100d_6173, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6177, 4);  movsx(edx, memw[ss, ebp + 24]);       /* movsx edx, word [ebp+0x18] */
            ii(0x100d_617b, 3);  imul(eax, edx);                       /* imul eax, edx */
            ii(0x100d_617e, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_6181, 7);  mov(memd[ss, ebp - 32], 0);           /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_6188, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x100d_618b, 2);  add(edx, edx);                        /* add edx, edx */
            ii(0x100d_618d, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6191, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_6194, 3);  mov(memd[ss, ebp - 36], edx);         /* mov [ebp-0x24], edx */
            ii(0x100d_6197, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_619b, 3);  mov(ebx, memd[ss, ebp - 28]);         /* mov ebx, [ebp-0x1c] */
            ii(0x100d_619e, 3);  imul(ebx, eax);                       /* imul ebx, eax */
            ii(0x100d_61a1, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_61a4, 3);  mov(edx, memd[ss, ebp - 28]);         /* mov edx, [ebp-0x1c] */
            ii(0x100d_61a7, 3);  sar(edx, 0x1f);                       /* sar edx, 0x1f */
            ii(0x100d_61aa, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x100d_61ad, 2);  sbb(eax, edx);                        /* sbb eax, edx */
            ii(0x100d_61af, 3);  sar(eax, 2);                          /* sar eax, 0x2 */
            ii(0x100d_61b2, 2);  sub(eax, ebx);                        /* sub eax, ebx */
            ii(0x100d_61b4, 3);  mov(memd[ss, ebp - 40], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_61b7, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61bb, 6);  imul(eax, eax, 0xb505);               /* imul eax, eax, 0xb505 */
            ii(0x100d_61c1, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100d_61c4, 3);  mov(memd[ss, ebp - 44], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100d_61c7, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100d_61cb, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61cf, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_61d1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_61d3, 2);  if(jl(0x100d_61e7, 0x12)) goto l_0x100d_61e7;/* jl 0x100d61e7 */
            ii(0x100d_61d5, 4);  movsx(edx, memw[ss, ebp + 16]);       /* movsx edx, word [ebp+0x10] */
            ii(0x100d_61d9, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61dd, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100d_61df, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_61e3, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_61e5, 2);  if(jl(0x100d_61e9, 2)) goto l_0x100d_61e9;/* jl 0x100d61e9 */
        l_0x100d_61e7:
            ii(0x100d_61e7, 2);  jmp(0x100d_61f7, 0xe); goto l_0x100d_61f7;/* jmp 0x100d61f7 */
        l_0x100d_61e9:
            ii(0x100d_61e9, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100d_61ed, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_61f1, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_61f3, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_61f5, 2);  if(jge(0x100d_61f9, 2)) goto l_0x100d_61f9;/* jge 0x100d61f9 */
        l_0x100d_61f7:
            ii(0x100d_61f7, 2);  jmp(0x100d_620b, 0x12); goto l_0x100d_620b;/* jmp 0x100d620b */
        l_0x100d_61f9:
            ii(0x100d_61f9, 4);  movsx(edx, memw[ss, ebp + 20]);       /* movsx edx, word [ebp+0x14] */
            ii(0x100d_61fd, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6201, 2);  sub(edx, eax);                        /* sub edx, eax */
            ii(0x100d_6203, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_6207, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_6209, 2);  if(jl(0x100d_620d, 2)) goto l_0x100d_620d;/* jl 0x100d620d */
        l_0x100d_620b:
            ii(0x100d_620b, 2);  jmp(0x100d_6215, 8); goto l_0x100d_6215;/* jmp 0x100d6215 */
        l_0x100d_620d:
            ii(0x100d_620d, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6211, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_6213, 2);  if(jg(0x100d_621a, 5)) goto l_0x100d_621a;/* jg 0x100d621a */
        l_0x100d_6215:
            ii(0x100d_6215, 5);  jmp(0x100d_66ac, 0x492); goto l_0x100d_66ac;/* jmp 0x100d66ac */
        l_0x100d_621a:
            ii(0x100d_621a, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100d_621e, 3);  sub(eax, memd[ss, ebp - 44]);         /* sub eax, [ebp-0x2c] */
            ii(0x100d_6221, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_6223, 2);  if(jge(0x100d_6236, 0x11)) goto l_0x100d_6236;/* jge 0x100d6236 */
            ii(0x100d_6225, 4);  movsx(eax, memw[ss, ebp + 16]);       /* movsx eax, word [ebp+0x10] */
            ii(0x100d_6229, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x100d_622c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_622e, 4);  movsx(eax, memw[ss, ebp - 12]);       /* movsx eax, word [ebp-0xc] */
            ii(0x100d_6232, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_6234, 2);  if(jge(0x100d_6238, 2)) goto l_0x100d_6238;/* jge 0x100d6238 */
        l_0x100d_6236:
            ii(0x100d_6236, 2);  jmp(0x100d_6243, 0xb); goto l_0x100d_6243;/* jmp 0x100d6243 */
        l_0x100d_6238:
            ii(0x100d_6238, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100d_623c, 3);  sub(eax, memd[ss, ebp - 44]);         /* sub eax, [ebp-0x2c] */
            ii(0x100d_623f, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_6241, 2);  if(jl(0x100d_6245, 2)) goto l_0x100d_6245;/* jl 0x100d6245 */
        l_0x100d_6243:
            ii(0x100d_6243, 2);  jmp(0x100d_6256, 0x11); goto l_0x100d_6256;/* jmp 0x100d6256 */
        l_0x100d_6245:
            ii(0x100d_6245, 4);  movsx(eax, memw[ss, ebp + 20]);       /* movsx eax, word [ebp+0x14] */
            ii(0x100d_6249, 3);  mov(edx, memd[ss, ebp - 44]);         /* mov edx, [ebp-0x2c] */
            ii(0x100d_624c, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x100d_624e, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100d_6252, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x100d_6254, 2);  if(jge(0x100d_6258, 2)) goto l_0x100d_6258;/* jge 0x100d6258 */
        l_0x100d_6256:
            ii(0x100d_6256, 2);  jmp(0x100d_625d, 5); goto l_0x100d_625d;/* jmp 0x100d625d */
        l_0x100d_6258:
            ii(0x100d_6258, 5);  jmp(0x100d_66ac, 0x44f); goto l_0x100d_66ac;/* jmp 0x100d66ac */
        l_0x100d_625d:
            ii(0x100d_625d, 4);  movsx(eax, memw[ss, ebp + 24]);       /* movsx eax, word [ebp+0x18] */
            ii(0x100d_6261, 5);  call(Definitions.sys_malloc, 0x9_4d78);/* call 0x1016afde */
            ii(0x100d_6266, 3);  mov(memd[ss, ebp - 48], eax);         /* mov [ebp-0x30], eax */
            ii(0x100d_6269, 4);  cmp(memd[ss, ebp - 48], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100d_626d, 6);  if(jz(0x100d_66ac, 0x439)) goto l_0x100d_66ac;/* jz 0x100d66ac */
            ii(0x100d_6273, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_6276, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
        l_0x100d_6279:
            ii(0x100d_6279, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_627c, 3);  cmp(eax, memd[ss, ebp - 36]);         /* cmp eax, [ebp-0x24] */
            ii(0x100d_627f, 2);  if(jge(0x100d_62c8, 0x47)) goto l_0x100d_62c8;/* jge 0x100d62c8 */
            ii(0x100d_6281, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x100d_6284, 3);  add(eax, memd[ss, ebp - 28]);         /* add eax, [ebp-0x1c] */
            ii(0x100d_6287, 3);  add(memd[ss, ebp - 40], eax);         /* add [ebp-0x28], eax */
            ii(0x100d_628a, 4);  cmp(memd[ss, ebp - 40], 0);           /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_628e, 2);  if(jl(0x100d_62af, 0x1f)) goto l_0x100d_62af;/* jl 0x100d62af */
            ii(0x100d_6290, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_6293, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_6295, 3);  sub(memd[ss, ebp - 36], eax);         /* sub [ebp-0x24], eax */
            ii(0x100d_6298, 3);  mov(eax, memd[ss, ebp - 36]);         /* mov eax, [ebp-0x24] */
            ii(0x100d_629b, 3);  sub(memd[ss, ebp - 40], eax);         /* sub [ebp-0x28], eax */
            ii(0x100d_629e, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_62a1, 3);  inc(memd[ss, ebp - 52]);              /* inc dword [ebp-0x34] */
            ii(0x100d_62a4, 3);  mov(memb[ds, eax], 1);                /* mov byte [eax], 0x1 */
            ii(0x100d_62a7, 3);  mov(eax, memd[ss, ebp - 24]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_62aa, 3);  inc(memd[ss, ebp - 24]);              /* inc dword [ebp-0x18] */
            ii(0x100d_62ad, 2);  jmp(0x100d_62b8, 9); goto l_0x100d_62b8;/* jmp 0x100d62b8 */
        l_0x100d_62af:
            ii(0x100d_62af, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_62b2, 3);  inc(memd[ss, ebp - 52]);              /* inc dword [ebp-0x34] */
            ii(0x100d_62b5, 3);  mov(memb[ds, eax], 0);                /* mov byte [eax], 0x0 */
        l_0x100d_62b8:
            ii(0x100d_62b8, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100d_62bb, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_62bd, 3);  add(memd[ss, ebp - 32], eax);         /* add [ebp-0x20], eax */
            ii(0x100d_62c0, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_62c3, 3);  inc(memd[ss, ebp - 20]);              /* inc dword [ebp-0x14] */
            ii(0x100d_62c6, 2);  jmp(0x100d_6279, -0x4f); goto l_0x100d_6279;/* jmp 0x100d6279 */
        l_0x100d_62c8:
            ii(0x100d_62c8, 7);  mov(memd[ss, ebp - 56], 0);           /* mov dword [ebp-0x38], 0x0 */
            ii(0x100d_62cf, 2);  jmp(0x100d_62d7, 6); goto l_0x100d_62d7;/* jmp 0x100d62d7 */
        l_0x100d_62d1:
            ii(0x100d_62d1, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_62d4, 3);  inc(memd[ss, ebp - 56]);              /* inc dword [ebp-0x38] */
        l_0x100d_62d7:
            ii(0x100d_62d7, 4);  movsx(eax, memw[ss, ebp - 56]);       /* movsx eax, word [ebp-0x38] */
            ii(0x100d_62db, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x100d_62de, 6);  if(jge(0x100d_66a4, 0x3c0)) goto l_0x100d_66a4;/* jge 0x100d66a4 */
            ii(0x100d_62e4, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100d_62e7, 3);  mov(memd[ss, ebp - 60], eax);         /* mov [ebp-0x3c], eax */
            ii(0x100d_62ea, 4);  mov(memb[ss, ebp - 64], 0);           /* mov byte [ebp-0x40], 0x0 */
            ii(0x100d_62ee, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_62f1, 3);  mov(memd[ss, ebp - 68], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_62f4, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_62f7, 3);  mov(memd[ss, ebp - 72], eax);         /* mov [ebp-0x48], eax */
            ii(0x100d_62fa, 5);  jmp(0x100d_6524, 0x225); goto l_0x100d_6524;/* jmp 0x100d6524 */
        l_0x100d_62ff:
            ii(0x100d_62ff, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6302, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_6305, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_6308, 3);  sub(eax, memd[ss, ebp + 24]);         /* sub eax, [ebp+0x18] */
            ii(0x100d_630b, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_630e, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6311, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_6314, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_6317, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_631a, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_631d, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100d_6320, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_6323, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_6326, 3);  add(eax, memd[ss, ebp - 24]);         /* add eax, [ebp-0x18] */
            ii(0x100d_6329, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_632c, 7);  mov(memd[ss, ebp - 100], 1);          /* mov dword [ebp-0x64], 0x1 */
            ii(0x100d_6333, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6336, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100d_6339, 5);  jmp(0x100d_6541, 0x203); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_633e:
            ii(0x100d_633e, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6341, 3);  add(eax, memd[ss, ebp + 24]);         /* add eax, [ebp+0x18] */
            ii(0x100d_6344, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_6347, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_634a, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_634d, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6350, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_6353, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_6356, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_6359, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_635c, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100d_635f, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_6362, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_6365, 3);  sub(eax, memd[ss, ebp - 20]);         /* sub eax, [ebp-0x14] */
            ii(0x100d_6368, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_636b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_636e, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100d_6371, 3);  neg(memd[ss, ebp - 100]);             /* neg dword [ebp-0x64] */
            ii(0x100d_6374, 7);  mov(memd[ss, ebp - 104], 0xffff_ffff);/* mov dword [ebp-0x68], 0xffffffff */
            ii(0x100d_637b, 5);  jmp(0x100d_6541, 0x1c1); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_6380:
            ii(0x100d_6380, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6383, 3);  add(eax, memd[ss, ebp + 24]);         /* add eax, [ebp+0x18] */
            ii(0x100d_6386, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_6389, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_638c, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_638f, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6392, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_6395, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_6398, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_639b, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_639e, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100d_63a1, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_63a4, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_63a7, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100d_63aa, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_63ad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_63b0, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100d_63b3, 7);  mov(memd[ss, ebp - 104], 0xffff_ffff);/* mov dword [ebp-0x68], 0xffffffff */
            ii(0x100d_63ba, 5);  jmp(0x100d_6541, 0x182); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_63bf:
            ii(0x100d_63bf, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_63c2, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_63c5, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_63c8, 3);  add(eax, memd[ss, ebp + 24]);         /* add eax, [ebp+0x18] */
            ii(0x100d_63cb, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_63ce, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_63d1, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_63d4, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_63d7, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_63da, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_63dd, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100d_63e0, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_63e3, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_63e6, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100d_63e9, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_63ec, 7);  mov(memd[ss, ebp - 100], 1);          /* mov dword [ebp-0x64], 0x1 */
            ii(0x100d_63f3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_63f6, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100d_63f9, 3);  neg(memd[ss, ebp - 104]);             /* neg dword [ebp-0x68] */
            ii(0x100d_63fc, 5);  jmp(0x100d_6541, 0x140); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_6401:
            ii(0x100d_6401, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6404, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_6407, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_640a, 3);  add(eax, memd[ss, ebp + 24]);         /* add eax, [ebp+0x18] */
            ii(0x100d_640d, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_6410, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6413, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_6416, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_6419, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_641c, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_641f, 3);  sub(eax, memd[ss, ebp - 20]);         /* sub eax, [ebp-0x14] */
            ii(0x100d_6422, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_6425, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_6428, 3);  sub(eax, memd[ss, ebp - 24]);         /* sub eax, [ebp-0x18] */
            ii(0x100d_642b, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_642e, 7);  mov(memd[ss, ebp - 100], 0xffff_ffff);/* mov dword [ebp-0x64], 0xffffffff */
            ii(0x100d_6435, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6438, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100d_643b, 3);  neg(memd[ss, ebp - 104]);             /* neg dword [ebp-0x68] */
            ii(0x100d_643e, 5);  jmp(0x100d_6541, 0xfe); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_6443:
            ii(0x100d_6443, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6446, 3);  sub(eax, memd[ss, ebp + 24]);         /* sub eax, [ebp+0x18] */
            ii(0x100d_6449, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_644c, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_644f, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_6452, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6455, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_6458, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_645b, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_645e, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_6461, 3);  add(eax, memd[ss, ebp - 24]);         /* add eax, [ebp-0x18] */
            ii(0x100d_6464, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_6467, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_646a, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x100d_646d, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_6470, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6473, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100d_6476, 7);  mov(memd[ss, ebp - 104], 1);          /* mov dword [ebp-0x68], 0x1 */
            ii(0x100d_647d, 5);  jmp(0x100d_6541, 0xbf); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_6482:
            ii(0x100d_6482, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_6485, 3);  sub(eax, memd[ss, ebp + 24]);         /* sub eax, [ebp+0x18] */
            ii(0x100d_6488, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_648b, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_648e, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_6491, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6494, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_6497, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_649a, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_649d, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_64a0, 3);  add(eax, memd[ss, ebp - 24]);         /* add eax, [ebp-0x18] */
            ii(0x100d_64a3, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_64a6, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_64a9, 3);  sub(eax, memd[ss, ebp - 20]);         /* sub eax, [ebp-0x14] */
            ii(0x100d_64ac, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_64af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_64b2, 3);  mov(memd[ss, ebp - 100], eax);        /* mov [ebp-0x64], eax */
            ii(0x100d_64b5, 3);  neg(memd[ss, ebp - 100]);             /* neg dword [ebp-0x64] */
            ii(0x100d_64b8, 7);  mov(memd[ss, ebp - 104], 1);          /* mov dword [ebp-0x68], 0x1 */
            ii(0x100d_64bf, 5);  jmp(0x100d_6541, 0x7d); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_64c4:
            ii(0x100d_64c4, 3);  mov(eax, memd[ss, ebp + 16]);         /* mov eax, [ebp+0x10] */
            ii(0x100d_64c7, 3);  mov(memd[ss, ebp - 76], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100d_64ca, 3);  mov(eax, memd[ss, ebp + 20]);         /* mov eax, [ebp+0x14] */
            ii(0x100d_64cd, 3);  sub(eax, memd[ss, ebp + 24]);         /* sub eax, [ebp+0x18] */
            ii(0x100d_64d0, 3);  mov(memd[ss, ebp - 80], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_64d3, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_64d6, 3);  mov(memd[ss, ebp - 92], eax);         /* mov [ebp-0x5c], eax */
            ii(0x100d_64d9, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_64dc, 3);  mov(memd[ss, ebp - 88], eax);         /* mov [ebp-0x58], eax */
            ii(0x100d_64df, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_64e2, 3);  sub(eax, memd[ss, ebp - 20]);         /* sub eax, [ebp-0x14] */
            ii(0x100d_64e5, 3);  mov(memd[ss, ebp - 84], eax);         /* mov [ebp-0x54], eax */
            ii(0x100d_64e8, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_64eb, 3);  add(eax, memd[ss, ebp - 24]);         /* add eax, [ebp-0x18] */
            ii(0x100d_64ee, 3);  mov(memd[ss, ebp - 96], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_64f1, 7);  mov(memd[ss, ebp - 100], 0xffff_ffff);/* mov dword [ebp-0x64], 0xffffffff */
            ii(0x100d_64f8, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_64fb, 3);  mov(memd[ss, ebp - 104], eax);        /* mov [ebp-0x68], eax */
            ii(0x100d_64fe, 2);  jmp(0x100d_6541, 0x41); goto l_0x100d_6541;/* jmp 0x100d6541 */
        l_0x100d_6500:
            ii(0x100d_6500, 2);  jmp(0x100d_6541, 0x3f); goto l_0x100d_6541;/* jmp 0x100d6541 */
        //  ii(0x100d_6502, 2);  mov(eax, eax);                        /* mov eax, eax */
        //  ii(0x100d_6504, 32);  /* Служебная область с абсолютными адресами переходов. (0x100d_62ff, 0x100d_633e, 0x100d_6380, 0x100d_63bf, 0x100d_6401, 0x100d_6443, 0x100d_6482, 0x100d_64c4). */
        l_0x100d_6524:
            ii(0x100d_6524, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x100d_6527, 3);  mov(memd[ss, ebp - 108], eax);        /* mov [ebp-0x6c], eax */
            ii(0x100d_652a, 5);  cmp(memw[ss, ebp - 108], 7);          /* cmp word [ebp-0x6c], 0x7 */
            ii(0x100d_652f, 2);  if(ja(0x100d_6500, -0x31)) goto l_0x100d_6500;/* ja 0x100d6500 */
            ii(0x100d_6531, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100d_6533, 4);  mov(ax, memw[ss, ebp - 108]);         /* mov ax, [ebp-0x6c] */
            ii(0x100d_6537, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_653a, 7);  
            switch (jmp_abs_switch(memd[cs, eax + 0x100d_6504]))
            {
                case 0x100d_62ff:
                    goto l_0x100d_62ff;
                case 0x100d_633e:
                    goto l_0x100d_633e;
                case 0x100d_6380:
                    goto l_0x100d_6380;
                case 0x100d_63bf:
                    goto l_0x100d_63bf;
                case 0x100d_6401:
                    goto l_0x100d_6401;
                case 0x100d_6443:
                    goto l_0x100d_6443;
                case 0x100d_6482:
                    goto l_0x100d_6482;
                case 0x100d_64c4:
                    goto l_0x100d_64c4;
                default:
                    throw new NotImplementedException();
            }/* jmp dword [cs:eax+0x100d6504] */
        l_0x100d_6541:
            ii(0x100d_6541, 4);  movsx(eax, memw[ss, ebp - 92]);       /* movsx eax, word [ebp-0x5c] */
            ii(0x100d_6545, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_6547, 2);  if(jl(0x100d_6552, 9)) goto l_0x100d_6552;/* jl 0x100d6552 */
            ii(0x100d_6549, 3);  mov(eax, memd[ss, ebp - 84]);         /* mov eax, [ebp-0x54] */
            ii(0x100d_654c, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_6550, 2);  if(jl(0x100d_6554, 2)) goto l_0x100d_6554;/* jl 0x100d6554 */
        l_0x100d_6552:
            ii(0x100d_6552, 2);  jmp(0x100d_655c, 8); goto l_0x100d_655c;/* jmp 0x100d655c */
        l_0x100d_6554:
            ii(0x100d_6554, 4);  movsx(eax, memw[ss, ebp - 96]);       /* movsx eax, word [ebp-0x60] */
            ii(0x100d_6558, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_655a, 2);  if(jge(0x100d_655e, 2)) goto l_0x100d_655e;/* jge 0x100d655e */
        l_0x100d_655c:
            ii(0x100d_655c, 2);  jmp(0x100d_6567, 9); goto l_0x100d_6567;/* jmp 0x100d6567 */
        l_0x100d_655e:
            ii(0x100d_655e, 3);  mov(eax, memd[ss, ebp - 88]);         /* mov eax, [ebp-0x58] */
            ii(0x100d_6561, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100d_6565, 2);  if(jl(0x100d_656c, 5)) goto l_0x100d_656c;/* jl 0x100d656c */
        l_0x100d_6567:
            ii(0x100d_6567, 5);  jmp(0x100d_669f, 0x133); goto l_0x100d_669f;/* jmp 0x100d669f */
        l_0x100d_656c:
            ii(0x100d_656c, 4);  movsx(eax, memw[ss, ebp - 84]);       /* movsx eax, word [ebp-0x54] */
            ii(0x100d_6570, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_6572, 2);  if(jl(0x100d_657d, 9)) goto l_0x100d_657d;/* jl 0x100d657d */
            ii(0x100d_6574, 3);  mov(eax, memd[ss, ebp - 92]);         /* mov eax, [ebp-0x5c] */
            ii(0x100d_6577, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_657b, 2);  if(jl(0x100d_657f, 2)) goto l_0x100d_657f;/* jl 0x100d657f */
        l_0x100d_657d:
            ii(0x100d_657d, 2);  jmp(0x100d_6587, 8); goto l_0x100d_6587;/* jmp 0x100d6587 */
        l_0x100d_657f:
            ii(0x100d_657f, 4);  movsx(eax, memw[ss, ebp - 88]);       /* movsx eax, word [ebp-0x58] */
            ii(0x100d_6583, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_6585, 2);  if(jge(0x100d_6589, 2)) goto l_0x100d_6589;/* jge 0x100d6589 */
        l_0x100d_6587:
            ii(0x100d_6587, 2);  jmp(0x100d_6592, 9); goto l_0x100d_6592;/* jmp 0x100d6592 */
        l_0x100d_6589:
            ii(0x100d_6589, 3);  mov(eax, memd[ss, ebp - 96]);         /* mov eax, [ebp-0x60] */
            ii(0x100d_658c, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100d_6590, 2);  if(jl(0x100d_65df, 0x4d)) goto l_0x100d_65df;/* jl 0x100d65df */
        l_0x100d_6592:
            ii(0x100d_6592, 3);  mov(eax, memd[ss, ebp - 56]);         /* mov eax, [ebp-0x38] */
            ii(0x100d_6595, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x100d_6598, 3);  mov(memd[ss, ebp - 112], eax);        /* mov [ebp-0x70], eax */
            ii(0x100d_659b, 4);  movsx(eax, memw[ss, ebp - 112]);      /* movsx eax, word [ebp-0x70] */
            ii(0x100d_659f, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_65a1, 7);  mov(ax, memw[ds, eax + 0x101b_7e6c]); /* mov ax, [eax+0x101b7e6c] */
            ii(0x100d_65a8, 3);  mov(memd[ss, ebp - 116], eax);        /* mov [ebp-0x74], eax */
            ii(0x100d_65ab, 4);  movsx(eax, memw[ss, ebp - 112]);      /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65af, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_65b1, 7);  mov(ax, memw[ds, eax + 0x101b_7e6e]); /* mov ax, [eax+0x101b7e6e] */
            ii(0x100d_65b8, 3);  mov(memd[ss, ebp - 120], eax);        /* mov [ebp-0x78], eax */
            ii(0x100d_65bb, 4);  movsx(eax, memw[ss, ebp - 112]);      /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65bf, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_65c1, 7);  mov(ax, memw[ds, eax + 0x101b_7e70]); /* mov ax, [eax+0x101b7e70] */
            ii(0x100d_65c8, 3);  mov(memd[ss, ebp - 124], eax);        /* mov [ebp-0x7c], eax */
            ii(0x100d_65cb, 4);  movsx(eax, memw[ss, ebp - 112]);      /* movsx eax, word [ebp-0x70] */
            ii(0x100d_65cf, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100d_65d1, 7);  mov(ax, memw[ds, eax + 0x101b_7e72]); /* mov ax, [eax+0x101b7e72] */
            ii(0x100d_65d8, 3);  mov(memd[ss, ebp - 128], eax);        /* mov [ebp-0x80], eax */
            ii(0x100d_65db, 4);  mov(memb[ss, ebp - 64], 1);           /* mov byte [ebp-0x40], 0x1 */
        l_0x100d_65df:
            ii(0x100d_65df, 4);  movsx(edx, memw[ss, ebp - 80]);       /* movsx edx, word [ebp-0x50] */
            ii(0x100d_65e3, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100d_65e7, 3);  imul(edx, eax);                       /* imul edx, eax */
            ii(0x100d_65ea, 4);  movsx(eax, memw[ss, ebp - 76]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_65ee, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100d_65f0, 3);  add(memd[ss, ebp - 68], eax);         /* add [ebp-0x44], eax */
            ii(0x100d_65f3, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_65f6, 3);  mov(memd[ss, ebp - 52], eax);         /* mov [ebp-0x34], eax */
        l_0x100d_65f9:
            ii(0x100d_65f9, 3);  dec(memd[ss, ebp - 60]);              /* dec dword [ebp-0x3c] */
            ii(0x100d_65fc, 5);  cmp(memw[ss, ebp - 60], -1 /* 0xff */);/* cmp word [ebp-0x3c], 0xffff */
            ii(0x100d_6601, 6);  if(jz(0x100d_669f, 0x98)) goto l_0x100d_669f;/* jz 0x100d669f */
            ii(0x100d_6607, 4);  cmp(memb[ss, ebp - 64], 0);           /* cmp byte [ebp-0x40], 0x0 */
            ii(0x100d_660b, 2);  if(jnz(0x100d_6636, 0x29)) goto l_0x100d_6636;/* jnz 0x100d6636 */
            ii(0x100d_660d, 3);  mov(al, memb[ss, ebp + 28]);          /* mov al, [ebp+0x1c] */
            ii(0x100d_6610, 3);  mov(edx, memd[ss, ebp - 68]);         /* mov edx, [ebp-0x44] */
            ii(0x100d_6613, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
            ii(0x100d_6615, 4);  movsx(eax, memw[ss, ebp - 100]);      /* movsx eax, word [ebp-0x64] */
            ii(0x100d_6619, 3);  add(memd[ss, ebp - 68], eax);         /* add [ebp-0x44], eax */
            ii(0x100d_661c, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_661f, 3);  inc(memd[ss, ebp - 52]);              /* inc dword [ebp-0x34] */
            ii(0x100d_6622, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_6625, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x100d_6628, 2);  if(jz(0x100d_6631, 7)) goto l_0x100d_6631;/* jz 0x100d6631 */
            ii(0x100d_662a, 4);  movsx(eax, memw[ss, ebp - 104]);      /* movsx eax, word [ebp-0x68] */
            ii(0x100d_662e, 3);  add(memd[ss, ebp - 68], eax);         /* add [ebp-0x44], eax */
        l_0x100d_6631:
            ii(0x100d_6631, 5);  jmp(0x100d_669a, 0x64); goto l_0x100d_669a;/* jmp 0x100d669a */
        l_0x100d_6636:
            ii(0x100d_6636, 4);  movsx(eax, memw[ss, ebp - 76]);       /* movsx eax, word [ebp-0x4c] */
            ii(0x100d_663a, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_663c, 2);  if(jl(0x100d_6647, 9)) goto l_0x100d_6647;/* jl 0x100d6647 */
            ii(0x100d_663e, 3);  mov(eax, memd[ss, ebp - 76]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_6641, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x100d_6645, 2);  if(jl(0x100d_6649, 2)) goto l_0x100d_6649;/* jl 0x100d6649 */
        l_0x100d_6647:
            ii(0x100d_6647, 2);  jmp(0x100d_6651, 8); goto l_0x100d_6651;/* jmp 0x100d6651 */
        l_0x100d_6649:
            ii(0x100d_6649, 4);  movsx(eax, memw[ss, ebp - 80]);       /* movsx eax, word [ebp-0x50] */
            ii(0x100d_664d, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100d_664f, 2);  if(jge(0x100d_6653, 2)) goto l_0x100d_6653;/* jge 0x100d6653 */
        l_0x100d_6651:
            ii(0x100d_6651, 2);  jmp(0x100d_665c, 9); goto l_0x100d_665c;/* jmp 0x100d665c */
        l_0x100d_6653:
            ii(0x100d_6653, 3);  mov(eax, memd[ss, ebp - 80]);         /* mov eax, [ebp-0x50] */
            ii(0x100d_6656, 4);  cmp(ax, memw[ss, ebp - 8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100d_665a, 2);  if(jl(0x100d_665e, 2)) goto l_0x100d_665e;/* jl 0x100d665e */
        l_0x100d_665c:
            ii(0x100d_665c, 2);  jmp(0x100d_6666, 8); goto l_0x100d_6666;/* jmp 0x100d6666 */
        l_0x100d_665e:
            ii(0x100d_665e, 3);  mov(al, memb[ss, ebp + 28]);          /* mov al, [ebp+0x1c] */
            ii(0x100d_6661, 3);  mov(edx, memd[ss, ebp - 68]);         /* mov edx, [ebp-0x44] */
            ii(0x100d_6664, 2);  mov(memb[ds, edx], al);               /* mov [edx], al */
        l_0x100d_6666:
            ii(0x100d_6666, 4);  movsx(eax, memw[ss, ebp - 100]);      /* movsx eax, word [ebp-0x64] */
            ii(0x100d_666a, 3);  add(memd[ss, ebp - 68], eax);         /* add [ebp-0x44], eax */
            ii(0x100d_666d, 3);  mov(eax, memd[ss, ebp - 116]);        /* mov eax, [ebp-0x74] */
            ii(0x100d_6670, 3);  add(memd[ss, ebp - 76], eax);         /* add [ebp-0x4c], eax */
            ii(0x100d_6673, 3);  mov(eax, memd[ss, ebp - 120]);        /* mov eax, [ebp-0x78] */
            ii(0x100d_6676, 3);  add(memd[ss, ebp - 80], eax);         /* add [ebp-0x50], eax */
            ii(0x100d_6679, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_667c, 3);  inc(memd[ss, ebp - 52]);              /* inc dword [ebp-0x34] */
            ii(0x100d_667f, 3);  mov(eax, memd[ss, ebp - 52]);         /* mov eax, [ebp-0x34] */
            ii(0x100d_6682, 3);  cmp(memb[ds, eax], 0);                /* cmp byte [eax], 0x0 */
            ii(0x100d_6685, 2);  if(jz(0x100d_669a, 0x13)) goto l_0x100d_669a;/* jz 0x100d669a */
            ii(0x100d_6687, 4);  movsx(eax, memw[ss, ebp - 104]);      /* movsx eax, word [ebp-0x68] */
            ii(0x100d_668b, 3);  add(memd[ss, ebp - 68], eax);         /* add [ebp-0x44], eax */
            ii(0x100d_668e, 3);  mov(eax, memd[ss, ebp - 124]);        /* mov eax, [ebp-0x7c] */
            ii(0x100d_6691, 3);  add(memd[ss, ebp - 76], eax);         /* add [ebp-0x4c], eax */
            ii(0x100d_6694, 3);  mov(eax, memd[ss, ebp - 128]);        /* mov eax, [ebp-0x80] */
            ii(0x100d_6697, 3);  add(memd[ss, ebp - 80], eax);         /* add [ebp-0x50], eax */
        l_0x100d_669a:
            ii(0x100d_669a, 5);  jmp(0x100d_65f9, -0xa6); goto l_0x100d_65f9;/* jmp 0x100d65f9 */
        l_0x100d_669f:
            ii(0x100d_669f, 5);  jmp(0x100d_62d1, -0x3d3); goto l_0x100d_62d1;/* jmp 0x100d62d1 */
        l_0x100d_66a4:
            ii(0x100d_66a4, 3);  mov(eax, memd[ss, ebp - 48]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_66a7, 5);  call(Definitions.sys_free, 0x9_4a15); /* call 0x1016b0c1 */
        l_0x100d_66ac:
            ii(0x100d_66ac, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_66ae, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_66af, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_66b0, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_66b1, 3);  ret(0x10);                            /* ret 0x10 */
        }
    }
}

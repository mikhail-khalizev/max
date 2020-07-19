using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e344-b9608e48")]
        public void Method_1007_e344()
        {
            ii(0x1007_e344, 5);  push(0x48);                           /* push 0x48 */
            ii(0x1007_e349, 5);  call(Definitions.sys_check_available_stack_size, 0xe_7a04);/* call 0x10165d52 */
            ii(0x1007_e34e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_e34f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_e350, 1);  push(edx);                            /* push edx */
            ii(0x1007_e351, 1);  push(esi);                            /* push esi */
            ii(0x1007_e352, 1);  push(edi);                            /* push edi */
            ii(0x1007_e353, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_e354, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_e356, 6);  sub(esp, 0x28);                       /* sub esp, 0x28 */
            ii(0x1007_e35c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_e35f, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_e362, 5);  call(Definitions.my_ctor_0x101b_4184, -0x7877);/* call 0x10076af0 */
            ii(0x1007_e367, 5);  mov(eax, memd[ds, 0x101c_8172]);      /* mov eax, [0x101c8172] */
            ii(0x1007_e36c, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1007_e36f, 1);  push(eax);                            /* push eax */
            ii(0x1007_e370, 6);  mov(ecx, memd[ds, 0x101c_8170]);      /* mov ecx, [0x101c8170] */
            ii(0x1007_e376, 3);  sar(ecx, 0x10);                       /* sar ecx, 0x10 */
            ii(0x1007_e379, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_e37b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_e37d, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1007_e380, 5);  call(0x1008_b148, 0xcdc3);            /* call 0x1008b148 */
            ii(0x1007_e385, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e388, 4);  test(memb[ds, eax + 18], 0x10);       /* test byte [eax+0x12], 0x10 */
            ii(0x1007_e38c, 2);  if(jz(0x1007_e397, 9)) goto l_0x1007_e397;/* jz 0x1007e397 */
            ii(0x1007_e38e, 7);  mov(memd[ss, ebp - 20], 2);           /* mov dword [ebp-0x14], 0x2 */
            ii(0x1007_e395, 2);  jmp(0x1007_e39e, 7); goto l_0x1007_e39e;/* jmp 0x1007e39e */
        l_0x1007_e397:
            ii(0x1007_e397, 7);  mov(memd[ss, ebp - 20], 1);           /* mov dword [ebp-0x14], 0x1 */
        l_0x1007_e39e:
            ii(0x1007_e39e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e3a1, 4);  mov(ax, memw[ds, eax + 26]);          /* mov ax, [eax+0x1a] */
            ii(0x1007_e3a5, 1);  dec(eax);                             /* dec eax */
            ii(0x1007_e3a6, 4);  mov(memw[ss, ebp - 24], ax);          /* mov [ebp-0x18], ax */
            ii(0x1007_e3aa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_e3ad, 4);  mov(ax, memw[ds, eax + 28]);          /* mov ax, [eax+0x1c] */
            ii(0x1007_e3b1, 3);  add(eax, memd[ss, ebp - 20]);         /* add eax, [ebp-0x14] */
            ii(0x1007_e3b4, 4);  mov(memw[ss, ebp - 22], ax);          /* mov [ebp-0x16], ax */
            ii(0x1007_e3b8, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1007_e3bf, 2);  jmp(0x1007_e3c5, 4); goto l_0x1007_e3c5;/* jmp 0x1007e3c5 */
        l_0x1007_e3c1:
            ii(0x1007_e3c1, 4);  add(memd[ss, ebp - 16], 2);           /* add dword [ebp-0x10], 0x2 */
        l_0x1007_e3c5:
            ii(0x1007_e3c5, 4);  movsx(eax, memw[ss, ebp - 16]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1007_e3c9, 3);  cmp(eax, 8);                          /* cmp eax, 0x8 */
            ii(0x1007_e3cc, 6);  if(jge(0x1007_e436, 0x64)) goto l_0x1007_e436;/* jge 0x1007e436 */
            ii(0x1007_e3d2, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1007_e3d9, 2);  jmp(0x1007_e3e1, 6); goto l_0x1007_e3e1;/* jmp 0x1007e3e1 */
        l_0x1007_e3db:
            ii(0x1007_e3db, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_e3de, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1007_e3e1:
            ii(0x1007_e3e1, 4);  movsx(eax, memw[ss, ebp - 20]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1007_e3e5, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1007_e3e9, 1);  inc(eax);                             /* inc eax */
            ii(0x1007_e3ea, 2);  cmp(edx, eax);                        /* cmp edx, eax */
            ii(0x1007_e3ec, 2);  if(jge(0x1007_e434, 0x46)) goto l_0x1007_e434;/* jge 0x1007e434 */
            ii(0x1007_e3ee, 4);  movsx(edx, memw[ss, ebp - 16]);       /* movsx edx, word [ebp-0x10] */
            ii(0x1007_e3f2, 3);  shl(edx, 2);                          /* shl edx, 0x2 */
            ii(0x1007_e3f5, 5);  mov(eax, 0x101c_5348);                /* mov eax, 0x101c5348 */
            ii(0x1007_e3fa, 2);  add(edx, eax);                        /* add edx, eax */
            ii(0x1007_e3fc, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1007_e3ff, 5);  call(0x1008_b1a4, 0xcda0);            /* call 0x1008b1a4 */
            ii(0x1007_e404, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1007_e407, 3);  lea(eax, memd[ss, ebp - 40]);         /* lea eax, [ebp-0x28] */
            ii(0x1007_e40a, 5);  call(0x1010_82ce, 0x8_9ebf);          /* call 0x101082ce */
            ii(0x1007_e40f, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_e411, 2);  if(jz(0x1007_e42a, 0x17)) goto l_0x1007_e42a;/* jz 0x1007e42a */
            ii(0x1007_e413, 4);  movsx(edx, memw[ss, ebp - 22]);       /* movsx edx, word [ebp-0x16] */
            ii(0x1007_e417, 4);  movsx(eax, memw[ss, ebp - 24]);       /* movsx eax, word [ebp-0x18] */
            ii(0x1007_e41b, 5);  call(0x1007_3d48, -0xa6d8);           /* call 0x10073d48 */
            ii(0x1007_e420, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x1007_e425, 3);  cmp(eax, 2);                          /* cmp eax, 0x2 */
            ii(0x1007_e428, 2);  if(jz(0x1007_e42c, 2)) goto l_0x1007_e42c;/* jz 0x1007e42c */
        l_0x1007_e42a:
            ii(0x1007_e42a, 2);  jmp(0x1007_e432, 6); goto l_0x1007_e432;/* jmp 0x1007e432 */
        l_0x1007_e42c:
            ii(0x1007_e42c, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_e430, 2);  jmp(0x1007_e43a, 8); goto l_0x1007_e43a;/* jmp 0x1007e43a */
        l_0x1007_e432:
            ii(0x1007_e432, 2);  jmp(0x1007_e3db, -0x59); goto l_0x1007_e3db;/* jmp 0x1007e3db */
        l_0x1007_e434:
            ii(0x1007_e434, 2);  jmp(0x1007_e3c1, -0x75); goto l_0x1007_e3c1;/* jmp 0x1007e3c1 */
        l_0x1007_e436:
            ii(0x1007_e436, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
        l_0x1007_e43a:
            ii(0x1007_e43a, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_e43d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_e43f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_e440, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_e441, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_e442, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_e443, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_e444, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_e445, 1);  ret();                                /* ret */
        }
    }
}

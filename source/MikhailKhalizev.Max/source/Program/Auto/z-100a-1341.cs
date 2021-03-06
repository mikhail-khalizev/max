using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_1341-62e487bb")]
        public void Method_100a_1341()
        {
            ii(0x100a_1341, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x100a_1346, 5);  call(Definitions.sys_check_available_stack_size, 0xc_4a07);/* call 0x10165d52 */
            ii(0x100a_134b, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_134c, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_134d, 1);  push(edx);                            /* push edx */
            ii(0x100a_134e, 1);  push(esi);                            /* push esi */
            ii(0x100a_134f, 1);  push(edi);                            /* push edi */
            ii(0x100a_1350, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_1351, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_1353, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_1359, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_135c, 4);  or(memb[ss, ebp - 8], 1);             /* or byte [ebp-0x8], 0x1 */
            ii(0x100a_1360, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_1363, 5);  call(0x1007_64fc, -0x2_ae6c);         /* call 0x100764fc */
            ii(0x100a_1368, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_136b, 4);  and(memb[ss, ebp - 8], -2 /* 0xfe */);/* and byte [ebp-0x8], 0xfe */
            ii(0x100a_136f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_1371, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_1374, 3);  add(eax, 0x44);                       /* add eax, 0x44 */
            ii(0x100a_1377, 5);  call(0x1013_ad71, 0x9_99f5);          /* call 0x1013ad71 */
            ii(0x100a_137c, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_137e, 2);  if(jz(0x100a_1395, 0x15)) goto l_0x100a_1395;/* jz 0x100a1395 */
            ii(0x100a_1380, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_1383, 3);  add(eax, 0x44);                       /* add eax, 0x44 */
            ii(0x100a_1386, 5);  call(0x1007_6600, -0x2_ad8b);         /* call 0x10076600 */
            ii(0x100a_138b, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_138d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_1390, 5);  call(0x100a_125d, -0x138);            /* call 0x100a125d */
        l_0x100a_1395:
            ii(0x100a_1395, 5);  mov(eax, 0x101c_819c);                /* mov eax, 0x101c819c */
            ii(0x100a_139a, 5);  call(0x1007_6338, -0x2_b067);         /* call 0x10076338 */
            ii(0x100a_139f, 3);  lea(ebx, memd[ss, ebp - 16]);         /* lea ebx, [ebp-0x10] */
            ii(0x100a_13a2, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_13a4, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x100a_13a6, 5);  call(0x1007_643c, -0x2_af6f);         /* call 0x1007643c */
        l_0x100a_13ab:
            ii(0x100a_13ab, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_13ad, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_13b0, 5);  call(0x1013_ad71, 0x9_99bc);          /* call 0x1013ad71 */
            ii(0x100a_13b5, 2);  test(al, al);                         /* test al, al */
            ii(0x100a_13b7, 2);  if(jz(0x100a_13c6, 0xd)) goto l_0x100a_13c6;/* jz 0x100a13c6 */
            ii(0x100a_13b9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_13bc, 3);  mov(eax, memd[ds, eax + 48]);         /* mov eax, [eax+0x30] */
            ii(0x100a_13bf, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100a_13c2, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100a_13c4, 2);  if(jl(0x100a_13c8, 2)) goto l_0x100a_13c8;/* jl 0x100a13c8 */
        l_0x100a_13c6:
            ii(0x100a_13c6, 2);  jmp(0x100a_13e4, 0x1c); goto l_0x100a_13e4;/* jmp 0x100a13e4 */
        l_0x100a_13c8:
            ii(0x100a_13c8, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_13cb, 5);  call(0x1007_6408, -0x2_afc8);         /* call 0x10076408 */
            ii(0x100a_13d0, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x100a_13d2, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_13d5, 5);  call(0x100a_125d, -0x17d);            /* call 0x100a125d */
            ii(0x100a_13da, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_13dd, 5);  call(0x1007_6bf8, -0x2_a7ea);         /* call 0x10076bf8 */
            ii(0x100a_13e2, 2);  jmp(0x100a_13ab, -0x39); goto l_0x100a_13ab;/* jmp 0x100a13ab */
        l_0x100a_13e4:
            ii(0x100a_13e4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_13e6, 3);  lea(eax, memd[ss, ebp - 16]);         /* lea eax, [ebp-0x10] */
            ii(0x100a_13e9, 5);  call(0x1007_5f6c, -0x2_b482);         /* call 0x10075f6c */
            ii(0x100a_13ee, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_13f0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_13f1, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_13f2, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_13f3, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_13f4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_13f5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_13f6, 1);  ret();                                /* ret */
        }
    }
}

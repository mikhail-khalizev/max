using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4a6c-1e251c05")]
        public void Method_1007_4a6c()
        {
            ii(0x1007_4a6c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_4a71, 5);  call(Definitions.sys_check_available_stack_size, 0xf_12dc);/* call 0x10165d52 */
            ii(0x1007_4a76, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_4a77, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_4a78, 1);  push(edx);                            /* push edx */
            ii(0x1007_4a79, 1);  push(esi);                            /* push esi */
            ii(0x1007_4a7a, 1);  push(edi);                            /* push edi */
            ii(0x1007_4a7b, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_4a7c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_4a7e, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_4a84, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_4a87, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_4a8a, 3);  mov(ebx, memd[ds, eax + 26]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_4a8d, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1007_4a90, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_4a93, 3);  mov(edx, memd[ds, eax + 24]);         /* mov edx, [eax+0x18] */
            ii(0x1007_4a96, 3);  sar(edx, 0x10);                       /* sar edx, 0x10 */
            ii(0x1007_4a99, 5);  mov(eax, 0x101c_39b8);                /* mov eax, 0x101c39b8 */
            ii(0x1007_4a9e, 5);  call(0x1010_3541, 0x8_ea9e);          /* call 0x10103541 */
            ii(0x1007_4aa3, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_4aa5, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4aa8, 5);  call(0x1007_64b8, 0x1a0b);            /* call 0x100764b8 */
        l_0x1007_4aad:
            ii(0x1007_4aad, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_4aaf, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4ab2, 5);  call(0x1013_ad71, 0xc_62ba);          /* call 0x1013ad71 */
            ii(0x1007_4ab7, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_4ab9, 2);  if(jz(0x1007_4b05, 0x4a)) goto l_0x1007_4b05;/* jz 0x10074b05 */
            ii(0x1007_4abb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4abe, 5);  call(0x1007_63a0, 0x18dd);            /* call 0x100763a0 */
            ii(0x1007_4ac3, 6);  test(memw[ds, eax + 18], 0x380);      /* test word [eax+0x12], 0x380 */
            ii(0x1007_4ac9, 2);  if(jz(0x1007_4ad9, 0xe)) goto l_0x1007_4ad9;/* jz 0x10074ad9 */
            ii(0x1007_4acb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4ace, 5);  call(0x1007_63a0, 0x18cd);            /* call 0x100763a0 */
            ii(0x1007_4ad3, 4);  test(memb[ds, eax + 18], 1);          /* test byte [eax+0x12], 0x1 */
            ii(0x1007_4ad7, 2);  if(jz(0x1007_4adb, 2)) goto l_0x1007_4adb;/* jz 0x10074adb */
        l_0x1007_4ad9:
            ii(0x1007_4ad9, 2);  jmp(0x1007_4ae9, 0xe); goto l_0x1007_4ae9;/* jmp 0x10074ae9 */
        l_0x1007_4adb:
            ii(0x1007_4adb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4ade, 5);  call(0x1007_63a0, 0x18bd);            /* call 0x100763a0 */
            ii(0x1007_4ae3, 4);  cmp(memb[ds, eax + 61], 0x10);        /* cmp byte [eax+0x3d], 0x10 */
            ii(0x1007_4ae7, 2);  if(jnz(0x1007_4aeb, 2)) goto l_0x1007_4aeb;/* jnz 0x10074aeb */
        l_0x1007_4ae9:
            ii(0x1007_4ae9, 2);  jmp(0x1007_4afb, 0x10); goto l_0x1007_4afb;/* jmp 0x10074afb */
        l_0x1007_4aeb:
            ii(0x1007_4aeb, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x1007_4aef, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_4af1, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4af4, 5);  call(0x1007_5f6c, 0x1473);            /* call 0x10075f6c */
            ii(0x1007_4af9, 2);  jmp(0x1007_4b1f, 0x24); goto l_0x1007_4b1f;/* jmp 0x10074b1f */
        l_0x1007_4afb:
            ii(0x1007_4afb, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4afe, 5);  call(0x1007_6bf8, 0x20f5);            /* call 0x10076bf8 */
            ii(0x1007_4b03, 2);  jmp(0x1007_4aad, -0x58); goto l_0x1007_4aad;/* jmp 0x10074aad */
        l_0x1007_4b05:
            ii(0x1007_4b05, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_4b09, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_4b0b, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1007_4b0e, 5);  call(0x1007_5f6c, 0x1459);            /* call 0x10075f6c */
            ii(0x1007_4b13, 2);  jmp(0x1007_4b1f, 0xa); goto l_0x1007_4b1f;/* jmp 0x10074b1f */
        //  ii(0x1007_4b15, 2);  xor(edx, edx);                        /* xor edx, edx */
        //  ii(0x1007_4b17, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
        //  ii(0x1007_4b1a, 5);  call(0x1007_5f6c, 0x144d);            /* call 0x10075f6c */
        l_0x1007_4b1f:
            ii(0x1007_4b1f, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_4b22, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_4b24, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_4b25, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_4b26, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_4b27, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_4b28, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_4b29, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_4b2a, 1);  ret();                                /* ret */
        }
    }
}

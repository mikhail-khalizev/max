using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_625c-8c70d215")]
        public void Method_1014_625c()
        {
            ii(0x1014_625c, 5);  push(0x34);                           /* push 0x34 */
            ii(0x1014_6261, 5);  call(Definitions.sys_check_available_stack_size, 0x1_faec);/* call 0x10165d52 */
            ii(0x1014_6266, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_6267, 1);  push(esi);                            /* push esi */
            ii(0x1014_6268, 1);  push(edi);                            /* push edi */
            ii(0x1014_6269, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_626a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_626c, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x1014_6272, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_6275, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1014_6278, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1014_627b, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1014_627e, 3);  lea(edx, memd[ss, ebp - 28]);         /* lea edx, [ebp-0x1c] */
            ii(0x1014_6281, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_6284, 5);  call(0x1014_630a, 0x81);              /* call 0x1014630a */
            ii(0x1014_6289, 4);  or(memb[ss, ebp - 16], 1);            /* or byte [ebp-0x10], 0x1 */
            ii(0x1014_628d, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_6290, 5);  call(0x100e_0720, -0x6_5b75);         /* call 0x100e0720 */
            ii(0x1014_6295, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1014_6298, 4);  and(memb[ss, ebp - 16], -2 /* 0xfe */);/* and byte [ebp-0x10], 0xfe */
            ii(0x1014_629c, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_629e, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_62a1, 5);  call(0x1013_ad71, -0xb535);           /* call 0x1013ad71 */
            ii(0x1014_62a6, 2);  test(al, al);                         /* test al, al */
            ii(0x1014_62a8, 2);  if(jz(0x1014_62cb, 0x21)) goto l_0x1014_62cb;/* jz 0x101462cb */
            ii(0x1014_62aa, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_62ad, 5);  call(0x100e_0760, -0x6_5b52);         /* call 0x100e0760 */
            ii(0x1014_62b2, 3);  mov(memd[ss, ebp - 32], eax);         /* mov [ebp-0x20], eax */
            ii(0x1014_62b5, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_62b8, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x1014_62bb, 3);  mov(eax, memd[ss, ebp - 32]);         /* mov eax, [ebp-0x20] */
            ii(0x1014_62be, 3);  call_abs(memd[ds, edx + 20]);         /* call dword [edx+0x14] */
            ii(0x1014_62c1, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1014_62c3, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_62c6, 5);  call(0x1014_7b94, 0x18c9);            /* call 0x10147b94 */
        l_0x1014_62cb:
            ii(0x1014_62cb, 3);  lea(edx, memd[ss, ebp - 24]);         /* lea edx, [ebp-0x18] */
            ii(0x1014_62ce, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_62d1, 5);  call(0x100e_06dc, -0x6_5bfa);         /* call 0x100e06dc */
            ii(0x1014_62d6, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_62d8, 3);  lea(eax, memd[ss, ebp - 24]);         /* lea eax, [ebp-0x18] */
            ii(0x1014_62db, 5);  call(0x100e_03fc, -0x6_5ee4);         /* call 0x100e03fc */
            ii(0x1014_62e0, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1014_62e2, 3);  lea(eax, memd[ss, ebp - 28]);         /* lea eax, [ebp-0x1c] */
            ii(0x1014_62e5, 5);  call(0x100e_03bc, -0x6_5f2e);         /* call 0x100e03bc */
            ii(0x1014_62ea, 2);  jmp(0x1014_6300, 0x14); goto l_0x1014_6300;/* jmp 0x10146300 */
        //  ii(0x1014_62ec, 20);  Недостижимый код.
        l_0x1014_6300:
            ii(0x1014_6300, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_6303, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_6305, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_6306, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_6307, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_6308, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_6309, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_8192-af9f93b1")]
        public void Method_1010_8192()
        {
            ii(0x1010_8192, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1010_8197, 5);  call(Definitions.sys_check_available_stack_size, 0x5_dbb6);/* call 0x10165d52 */
            ii(0x1010_819c, 1);  push(esi);                            /* push esi */
            ii(0x1010_819d, 1);  push(edi);                            /* push edi */
            ii(0x1010_819e, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_819f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_81a1, 6);  sub(esp, 0x18);                       /* sub esp, 0x18 */
            ii(0x1010_81a7, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_81aa, 3);  mov(memd[ss, ebp - 12], edx);         /* mov [ebp-0xc], edx */
            ii(0x1010_81ad, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1010_81b0, 3);  mov(memd[ss, ebp - 4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1010_81b3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_81b6, 3);  cmp(memd[ds, eax], 0);                /* cmp dword [eax], 0x0 */
            ii(0x1010_81b9, 2);  if(jz(0x1010_81db, 0x20)) goto l_0x1010_81db;/* jz 0x101081db */
            ii(0x1010_81bb, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1010_81be, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1010_81c1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_81c4, 5);  call(0x1010_7853, -0x976);            /* call 0x10107853 */
            ii(0x1010_81c9, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1010_81cb, 3);  lea(ebx, memd[ss, ebp - 24]);         /* lea ebx, [ebp-0x18] */
            ii(0x1010_81ce, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_81d1, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_81d4, 5);  call(0x1010_7e6a, -0x36f);            /* call 0x10107e6a */
            ii(0x1010_81d9, 2);  jmp(0x1010_81eb, 0x10); goto l_0x1010_81eb;/* jmp 0x101081eb */
        l_0x1010_81db:
            ii(0x1010_81db, 2);  xor(ecx, ecx);                        /* xor ecx, ecx */
            ii(0x1010_81dd, 3);  mov(ebx, memd[ss, ebp - 4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1010_81e0, 3);  mov(edx, memd[ss, ebp - 12]);         /* mov edx, [ebp-0xc] */
            ii(0x1010_81e3, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_81e6, 5);  call(0x1010_7e6a, -0x381);            /* call 0x10107e6a */
        l_0x1010_81eb:
            ii(0x1010_81eb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_81ed, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_81ee, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_81ef, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_81f0, 1);  ret();                                /* ret */
        }
    }
}

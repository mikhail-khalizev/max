using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_12a6-c40bd61f")]
        public void Method_1013_12a6()
        {
            ii(0x1013_12a6, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_12ab, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4aa2);/* call 0x10165d52 */
            ii(0x1013_12b0, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_12b1, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_12b2, 1);  push(esi);                            /* push esi */
            ii(0x1013_12b3, 1);  push(edi);                            /* push edi */
            ii(0x1013_12b4, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_12b5, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_12b7, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_12bd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_12c0, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_12c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_12c6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_12c9, 7);  mov(memb[ds, 0x101c_61b2], 0);        /* mov byte [0x101c61b2], 0x0 */
            ii(0x1013_12d0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_12d3, 5);  call(0x1012_f003, -0x22d5);           /* call 0x1012f003 */
            ii(0x1013_12d8, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_12db, 4);  cmp(memb[ds, eax + 23], 0);           /* cmp byte [eax+0x17], 0x0 */
            ii(0x1013_12df, 2);  if(jnz(0x1013_12ee, 0xd)) goto l_0x1013_12ee;/* jnz 0x101312ee */
            ii(0x1013_12e1, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1013_12e6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_12e9, 5);  call(0x1013_0c16, -0x6d8);            /* call 0x10130c16 */
        l_0x1013_12ee:
            ii(0x1013_12ee, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_12f0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_12f1, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_12f2, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_12f3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_12f4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_12f5, 1);  ret();                                /* ret */
        }
    }
}

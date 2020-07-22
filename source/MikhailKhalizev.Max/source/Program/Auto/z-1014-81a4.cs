using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_81a4-d648af1a")]
        public void Method_1014_81a4()
        {
            ii(0x1014_81a4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_81a9, 5);  call(Definitions.sys_check_available_stack_size, 0x1_dba4);/* call 0x10165d52 */
            ii(0x1014_81ae, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_81af, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_81b0, 1);  push(edx);                            /* push edx */
            ii(0x1014_81b1, 1);  push(esi);                            /* push esi */
            ii(0x1014_81b2, 1);  push(edi);                            /* push edi */
            ii(0x1014_81b3, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_81b4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_81b6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_81bc, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_81bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_81c2, 3);  mov(eax, memd[ds, eax + 4]);          /* mov eax, [eax+0x4] */
            ii(0x1014_81c5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_81c8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_81cb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_81cd, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_81ce, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_81cf, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_81d0, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_81d1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_81d2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_81d3, 1);  ret();                                /* ret */
        }
    }
}

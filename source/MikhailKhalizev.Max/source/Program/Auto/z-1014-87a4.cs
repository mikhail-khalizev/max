using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_87a4-4a5e6e0f")]
        public void Method_1014_87a4()
        {
            ii(0x1014_87a4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_87a9, 5);  call(Definitions.sys_check_available_stack_size, 0x1_d5a4);/* call 0x10165d52 */
            ii(0x1014_87ae, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_87af, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_87b0, 1);  push(esi);                            /* push esi */
            ii(0x1014_87b1, 1);  push(edi);                            /* push edi */
            ii(0x1014_87b2, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_87b3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_87b5, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_87bb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_87be, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_87c1, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_87c6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_87c9, 5);  call(0x1013_a1be, -0xe610);           /* call 0x1013a1be */
            ii(0x1014_87ce, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_87d1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_87d4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_87d7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_87da, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_87dc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_87dd, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_87de, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_87df, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_87e0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_87e1, 1);  ret();                                /* ret */
        }
    }
}

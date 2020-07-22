using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3afc-4d105472")]
        public void Method_100b_3afc()
        {
            ii(0x100b_3afc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_3b01, 5);  call(Definitions.sys_check_available_stack_size, 0xb_224c);/* call 0x10165d52 */
            ii(0x100b_3b06, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_3b07, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_3b08, 1);  push(edx);                            /* push edx */
            ii(0x100b_3b09, 1);  push(esi);                            /* push esi */
            ii(0x100b_3b0a, 1);  push(edi);                            /* push edi */
            ii(0x100b_3b0b, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_3b0c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_3b0e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_3b14, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_3b17, 4);  mov(memb[ss, ebp - 8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100b_3b1b, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_3b1e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_3b20, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_3b21, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_3b22, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_3b23, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_3b24, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_3b25, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_3b26, 1);  ret();                                /* ret */
        }
    }
}

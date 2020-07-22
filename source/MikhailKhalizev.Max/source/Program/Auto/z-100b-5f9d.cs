using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5f9d-b8c0ffea")]
        public void Method_100b_5f9d()
        {
            ii(0x100b_5f9d, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_5fa2, 5);  call(Definitions.sys_check_available_stack_size, 0xa_fdab);/* call 0x10165d52 */
            ii(0x100b_5fa7, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_5fa8, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_5fa9, 1);  push(edx);                            /* push edx */
            ii(0x100b_5faa, 1);  push(esi);                            /* push esi */
            ii(0x100b_5fab, 1);  push(edi);                            /* push edi */
            ii(0x100b_5fac, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_5fad, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_5faf, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_5fb5, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_5fb8, 4);  mov(memb[ss, ebp - 8], 1);            /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_5fbc, 3);  mov(al, memb[ss, ebp - 8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_5fbf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_5fc1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_5fc2, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_5fc3, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_5fc4, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_5fc5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_5fc6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_5fc7, 1);  ret();                                /* ret */
        }
    }
}

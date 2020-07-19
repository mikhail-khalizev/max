using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7f74-d80f0c63")]
        public void Method_100b_7f74()
        {
            ii(0x100b_7f74, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_7f79, 5);  call(Definitions.sys_check_available_stack_size, 0xa_ddd4);/* call 0x10165d52 */
            ii(0x100b_7f7e, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7f7f, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7f80, 1);  push(edx);                            /* push edx */
            ii(0x100b_7f81, 1);  push(esi);                            /* push esi */
            ii(0x100b_7f82, 1);  push(edi);                            /* push edi */
            ii(0x100b_7f83, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7f84, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7f86, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_7f8c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7f8f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7f92, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100b_7f94, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7f97, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7f9a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7f9c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7f9d, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7f9e, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7f9f, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_7fa0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7fa1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7fa2, 1);  ret();                                /* ret */
        }
    }
}
using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_9183-7bf1d92c")]
        public void Method_100b_9183()
        {
            ii(0x100b_9183, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_9188, 5);  call(Definitions.sys_check_available_stack_size, 0xa_cbc5);/* call 0x10165d52 */
            ii(0x100b_918d, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_918e, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_918f, 1);  push(esi);                            /* push esi */
            ii(0x100b_9190, 1);  push(edi);                            /* push edi */
            ii(0x100b_9191, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_9192, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_9194, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_919a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_919d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_91a0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_91a3, 5);  call(0x100b_91b9, 0x11);              /* call 0x100b91b9 */
            ii(0x100b_91a8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_91ab, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_91ae, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_91b1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_91b3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_91b4, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_91b5, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_91b6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_91b7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_91b8, 1);  ret();                                /* ret */
        }
    }
}

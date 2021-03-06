using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_827c-45dd8c5f")]
        public void Method_100b_827c()
        {
            ii(0x100b_827c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_8281, 5);  call(Definitions.sys_check_available_stack_size, 0xa_dacc);/* call 0x10165d52 */
            ii(0x100b_8286, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_8287, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_8288, 1);  push(esi);                            /* push esi */
            ii(0x100b_8289, 1);  push(edi);                            /* push edi */
            ii(0x100b_828a, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_828b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_828d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_8293, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_8296, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_8299, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100b_829d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_82a0, 5);  call(0x1008_b410, -0x2_ce95);         /* call 0x1008b410 */
            ii(0x100b_82a5, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100b_82a8, 5);  call(0x1008_b440, -0x2_ce6d);         /* call 0x1008b440 */
            ii(0x100b_82ad, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_82b0, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_82b3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_82b5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_82b6, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_82b7, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_82b8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_82b9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_82ba, 1);  ret();                                /* ret */
        }
    }
}

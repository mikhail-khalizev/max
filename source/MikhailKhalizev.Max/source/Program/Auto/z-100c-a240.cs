using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a240-1b7e5ec9")]
        public void Method_100c_a240()
        {
            ii(0x100c_a240, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_a245, 5);  call(Definitions.sys_check_available_stack_size, 0x9_bb08);/* call 0x10165d52 */
            ii(0x100c_a24a, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_a24b, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_a24c, 1);  push(esi);                            /* push esi */
            ii(0x100c_a24d, 1);  push(edi);                            /* push edi */
            ii(0x100c_a24e, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_a24f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_a251, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_a257, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a25a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a25d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_a260, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a263, 5);  call(0x100c_a1a4, -0xc4);             /* call 0x100ca1a4 */
            ii(0x100c_a268, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a26b, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_a26e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_a271, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a274, 7);  mov(memd[ds, eax + 2], 0x101b_5768);  /* mov dword [eax+0x2], 0x101b5768 */
            ii(0x100c_a27b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a27e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_a281, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_a284, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_a286, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_a287, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_a288, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_a289, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_a28a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_a28b, 1);  ret();                                /* ret */
        }
    }
}

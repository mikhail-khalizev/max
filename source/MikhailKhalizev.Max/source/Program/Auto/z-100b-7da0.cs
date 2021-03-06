using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7da0-31e9f4")]
        public void Method_100b_7da0()
        {
            ii(0x100b_7da0, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_7da5, 5);  call(Definitions.sys_check_available_stack_size, 0xa_dfa8);/* call 0x10165d52 */
            ii(0x100b_7daa, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7dab, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7dac, 1);  push(esi);                            /* push esi */
            ii(0x100b_7dad, 1);  push(edi);                            /* push edi */
            ii(0x100b_7dae, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7daf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7db1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100b_7db7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7dba, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7dbd, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100b_7dc0, 3);  add(edx, 0x28);                       /* add edx, 0x28 */
            ii(0x100b_7dc3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7dc6, 5);  call(0x1007_5e64, -0x4_1f67);         /* call 0x10075e64 */
            ii(0x100b_7dcb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7dce, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7dd0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7dd1, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7dd2, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7dd3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7dd4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7dd5, 1);  ret();                                /* ret */
        }
    }
}

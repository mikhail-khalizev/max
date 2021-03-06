using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7c78-93da0a33")]
        public void Method_100b_7c78()
        {
            ii(0x100b_7c78, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100b_7c7d, 5);  call(Definitions.sys_check_available_stack_size, 0xa_e0d0);/* call 0x10165d52 */
            ii(0x100b_7c82, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_7c83, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_7c84, 1);  push(esi);                            /* push esi */
            ii(0x100b_7c85, 1);  push(edi);                            /* push edi */
            ii(0x100b_7c86, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_7c87, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_7c89, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100b_7c8f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7c92, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_7c95, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_7c98, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7c9b, 5);  call(0x1013_a112, 0x8_2472);          /* call 0x1013a112 */
            ii(0x100b_7ca0, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7ca3, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100b_7ca6, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_7ca9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7cac, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_7caf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100b_7cb2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_7cb4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_7cb5, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_7cb6, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_7cb7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_7cb8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_7cb9, 1);  ret();                                /* ret */
        }
    }
}

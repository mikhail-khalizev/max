using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8104-7f9227f4")]
        public void Method_100e_8104()
        {
            ii(0x100e_8104, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_8109, 5);  call(Definitions.sys_check_available_stack_size, 0x7_dc44);/* call 0x10165d52 */
            ii(0x100e_810e, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_810f, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_8110, 1);  push(esi);                            /* push esi */
            ii(0x100e_8111, 1);  push(edi);                            /* push edi */
            ii(0x100e_8112, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_8113, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_8115, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_811b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_811e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_8121, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100e_8126, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8129, 5);  call(0x1013_b0a5, 0x5_2f77);          /* call 0x1013b0a5 */
            ii(0x100e_812e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_8131, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8134, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_8137, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_813a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_813c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_813d, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_813e, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_813f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_8140, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_8141, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_aedc-d74a0aa5")]
        public void Method_100a_aedc()
        {
            ii(0x100a_aedc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_aee1, 5);  call(Definitions.sys_check_available_stack_size, 0xb_ae6c);/* call 0x10165d52 */
            ii(0x100a_aee6, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_aee7, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_aee8, 1);  push(edx);                            /* push edx */
            ii(0x100a_aee9, 1);  push(esi);                            /* push esi */
            ii(0x100a_aeea, 1);  push(edi);                            /* push edi */
            ii(0x100a_aeeb, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_aeec, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_aeee, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_aef4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_aef7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_aefa, 5);  call(0x1007_6c30, -0x3_42cf);         /* call 0x10076c30 */
            ii(0x100a_aeff, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_af02, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_af05, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_af07, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_af08, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_af09, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_af0a, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_af0b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_af0c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_af0d, 1);  ret();                                /* ret */
        }
    }
}

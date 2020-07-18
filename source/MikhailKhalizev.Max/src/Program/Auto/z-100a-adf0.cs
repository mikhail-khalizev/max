using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_adf0-cd92491c")]
        public void Method_100a_adf0()
        {
            ii(0x100a_adf0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_adf5, 5);  call(Definitions.sys_check_available_stack_size, 0xb_af58);/* call 0x10165d52 */
            ii(0x100a_adfa, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_adfb, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_adfc, 1);  push(edx);                            /* push edx */
            ii(0x100a_adfd, 1);  push(esi);                            /* push esi */
            ii(0x100a_adfe, 1);  push(edi);                            /* push edi */
            ii(0x100a_adff, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_ae00, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_ae02, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_ae08, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_ae0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_ae0e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100a_ae10, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_ae13, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ae16, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_ae18, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_ae19, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_ae1a, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_ae1b, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_ae1c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_ae1d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_ae1e, 1);  ret();                                /* ret */
        }
    }
}

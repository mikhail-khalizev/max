using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c808-4e9b047d")]
        public void Method_1013_c808()
        {
            ii(0x1013_c808, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_c80d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9540);/* call 0x10165d52 */
            ii(0x1013_c812, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c813, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c814, 1);  push(edx);                            /* push edx */
            ii(0x1013_c815, 1);  push(esi);                            /* push esi */
            ii(0x1013_c816, 1);  push(edi);                            /* push edi */
            ii(0x1013_c817, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c818, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c81a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_c820, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_c823, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c826, 3);  call_abs(memd[ds, eax + 14]);         /* call dword [eax+0xe] */
            ii(0x1013_c829, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c82c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c82f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c831, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c832, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c833, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c834, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_c835, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c836, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c837, 1);  ret();                                /* ret */
        }
    }
}

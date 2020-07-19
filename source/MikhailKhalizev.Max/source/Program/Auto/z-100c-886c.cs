using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_886c-a199ffd")]
        public void Method_100c_886c()
        {
            ii(0x100c_886c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_8871, 5);  call(Definitions.sys_check_available_stack_size, 0x9_d4dc);/* call 0x10165d52 */
            ii(0x100c_8876, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_8877, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_8878, 1);  push(edx);                            /* push edx */
            ii(0x100c_8879, 1);  push(esi);                            /* push esi */
            ii(0x100c_887a, 1);  push(edi);                            /* push edi */
            ii(0x100c_887b, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_887c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_887e, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100c_8884, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_8887, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_888a, 3);  mov(eax, memd[ds, eax + 7]);          /* mov eax, [eax+0x7] */
            ii(0x100c_888d, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100c_8890, 6);  imul(edx, eax, 0xc5);                 /* imul edx, eax, 0xc5 */
            ii(0x100c_8896, 5);  mov(eax, 0x101c_31c4);                /* mov eax, 0x101c31c4 */
            ii(0x100c_889b, 2);  add(eax, edx);                        /* add eax, edx */
            ii(0x100c_889d, 5);  call(0x100b_d398, -0xb50a);           /* call 0x100bd398 */
            ii(0x100c_88a2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_88a4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_88a5, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_88a6, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_88a7, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_88a8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_88a9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_88aa, 1);  ret();                                /* ret */
        }
    }
}

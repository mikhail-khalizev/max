using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_afd0-6752cdd4")]
        public void Method_100c_afd0()
        {
            ii(0x100c_afd0, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_afd5, 5);  call(Definitions.sys_check_available_stack_size, 0x9_ad78);/* call 0x10165d52 */
            ii(0x100c_afda, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_afdb, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_afdc, 1);  push(esi);                            /* push esi */
            ii(0x100c_afdd, 1);  push(edi);                            /* push edi */
            ii(0x100c_afde, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_afdf, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_afe1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_afe7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_afea, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_afed, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_aff0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_aff3, 5);  call(0x1013_a2ab, 0x6_f2b3);          /* call 0x1013a2ab */
            ii(0x100c_aff8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_affa, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_affb, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_affc, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_affd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_affe, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_afff, 1);  ret();                                /* ret */
        }
    }
}

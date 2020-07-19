using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ac03-57357117")]
        public void Method_1013_ac03()
        {
            ii(0x1013_ac03, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_ac08, 5);  call(Definitions.sys_check_available_stack_size, 0x2_b145);/* call 0x10165d52 */
            ii(0x1013_ac0d, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_ac0e, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_ac0f, 1);  push(esi);                            /* push esi */
            ii(0x1013_ac10, 1);  push(edi);                            /* push edi */
            ii(0x1013_ac11, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_ac12, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_ac14, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_ac1a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_ac1d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_ac20, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ac23, 2);  mov(edx, memd[ds, eax]);              /* mov edx, [eax] */
            ii(0x1013_ac25, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ac28, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1013_ac2a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ac2d, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1013_ac2f, 5);  call(0x1013_ae28, 0x1f4);             /* call 0x1013ae28 */
            ii(0x1013_ac34, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_ac37, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_ac3a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_ac3d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_ac3f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_ac40, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_ac41, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_ac42, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_ac43, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_ac44, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_abfc-7fb4ef72")]
        public void Method_100a_abfc()
        {
            ii(0x100a_abfc, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_ac01, 5); call(Definitions.sys_check_available_stack_size, 0xb_b14c); /* call 0x10165d52 */
            ii(0x100a_ac06, 1); push(ebx);                              /* push ebx */
            ii(0x100a_ac07, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ac08, 1); push(esi);                              /* push esi */
            ii(0x100a_ac09, 1); push(edi);                              /* push edi */
            ii(0x100a_ac0a, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ac0b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ac0d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_ac13, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_ac16, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_ac19, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100a_ac1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_ac1f, 5); call(0x1007_6d14, -0x3_3f10);           /* call 0x10076d14 */
            ii(0x100a_ac24, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_ac27, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100a_ac2a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_ac2d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_ac30, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_ac33, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_ac36, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ac38, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_ac39, 1); pop(edi);                               /* pop edi */
            ii(0x100a_ac3a, 1); pop(esi);                               /* pop esi */
            ii(0x100a_ac3b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_ac3c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_ac3d, 1); ret();                                  /* ret */
        }
    }
}

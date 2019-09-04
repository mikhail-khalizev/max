using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ac00-ce6e763f")]
        public void Method_100c_ac00()
        {
            ii(0x100c_ac00, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_ac05, 5); call(Definitions.sys_check_available_stack_size, 0x9_b148); /* call 0x10165d52 */
            ii(0x100c_ac0a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ac0b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ac0c, 1); push(edx);                              /* push edx */
            ii(0x100c_ac0d, 1); push(esi);                              /* push esi */
            ii(0x100c_ac0e, 1); push(edi);                              /* push edi */
            ii(0x100c_ac0f, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ac10, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ac12, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100c_ac18, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100c_ac1b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_ac1e, 4); mov(ax, memw[ds, eax + 9]);             /* mov ax, [eax+0x9] */
            ii(0x100c_ac22, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_ac25, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_ac28, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ac2a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ac2b, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ac2c, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ac2d, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ac2e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ac2f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ac30, 1); ret();                                  /* ret */
        }
    }
}

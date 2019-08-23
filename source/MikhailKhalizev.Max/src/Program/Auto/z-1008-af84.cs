using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_af84-e7fb9544")]
        public void Method_1008_af84()
        {
            ii(0x1008_af84, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_af89, 5); call(Definitions.sys_check_available_stack_size, 0xd_adc4); /* call 0x10165d52 */
            ii(0x1008_af8e, 1); push(ebx);                              /* push ebx */
            ii(0x1008_af8f, 1); push(ecx);                              /* push ecx */
            ii(0x1008_af90, 1); push(edx);                              /* push edx */
            ii(0x1008_af91, 1); push(esi);                              /* push esi */
            ii(0x1008_af92, 1); push(edi);                              /* push edi */
            ii(0x1008_af93, 1); push(ebp);                              /* push ebp */
            ii(0x1008_af94, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_af96, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_af9c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_af9f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_afa2, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1008_afa4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_afa7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_afaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_afac, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_afad, 1); pop(edi);                               /* pop edi */
            ii(0x1008_afae, 1); pop(esi);                               /* pop esi */
            ii(0x1008_afaf, 1); pop(edx);                               /* pop edx */
            ii(0x1008_afb0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_afb1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_afb2, 1); ret();                                  /* ret */
        }
    }
}

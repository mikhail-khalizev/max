using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ab38-6d23043d")]
        public void Method_100c_ab38()
        {
            ii(0x100c_ab38, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_ab3d, 5); call(Definitions.sys_check_available_stack_size, 0x9_b210); /* call 0x10165d52 */
            ii(0x100c_ab42, 1); push(ebx);                              /* push ebx */
            ii(0x100c_ab43, 1); push(ecx);                              /* push ecx */
            ii(0x100c_ab44, 1); push(edx);                              /* push edx */
            ii(0x100c_ab45, 1); push(esi);                              /* push esi */
            ii(0x100c_ab46, 1); push(edi);                              /* push edi */
            ii(0x100c_ab47, 1); push(ebp);                              /* push ebp */
            ii(0x100c_ab48, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_ab4a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_ab50, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_ab53, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_ab56, 4); mov(ax, memw[ds, eax + 0x10]);          /* mov ax, [eax+0x10] */
            ii(0x100c_ab5a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_ab5d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_ab60, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_ab62, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_ab63, 1); pop(edi);                               /* pop edi */
            ii(0x100c_ab64, 1); pop(esi);                               /* pop esi */
            ii(0x100c_ab65, 1); pop(edx);                               /* pop edx */
            ii(0x100c_ab66, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_ab67, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_ab68, 1); ret();                                  /* ret */
        }
    }
}

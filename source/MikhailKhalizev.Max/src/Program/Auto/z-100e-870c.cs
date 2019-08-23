using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_870c-eccb3e6d")]
        public void Method_100e_870c()
        {
            ii(0x100e_870c, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_8711, 5); call(Definitions.sys_check_available_stack_size, 0x7_d63c); /* call 0x10165d52 */
            ii(0x100e_8716, 1); push(ebx);                              /* push ebx */
            ii(0x100e_8717, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8718, 1); push(edx);                              /* push edx */
            ii(0x100e_8719, 1); push(esi);                              /* push esi */
            ii(0x100e_871a, 1); push(edi);                              /* push edi */
            ii(0x100e_871b, 1); push(ebp);                              /* push ebp */
            ii(0x100e_871c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_871e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_8724, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_8727, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_872a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_872c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_872f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_8732, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8734, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8735, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8736, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8737, 1); pop(edx);                               /* pop edx */
            ii(0x100e_8738, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_8739, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_873a, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9666-f640552a")]
        public void Method_100e_9666()
        {
            ii(0x100e_9666, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_966b, 5); call(Definitions.sys_check_available_stack_size, 0x7_c6e2); /* call 0x10165d52 */
            ii(0x100e_9670, 1); push(ebx);                              /* push ebx */
            ii(0x100e_9671, 1); push(ecx);                              /* push ecx */
            ii(0x100e_9672, 1); push(edx);                              /* push edx */
            ii(0x100e_9673, 1); push(esi);                              /* push esi */
            ii(0x100e_9674, 1); push(edi);                              /* push edi */
            ii(0x100e_9675, 1); push(ebp);                              /* push ebp */
            ii(0x100e_9676, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_9678, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_967e, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_9681, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_9684, 3); mov(edx, memd[ds, eax + 0x4]);          /* mov edx, [eax+0x4] */
            ii(0x100e_9687, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_968a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100e_968c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100e_968f, 5); call(/* sys */ 0x1016_9a78, 0x8_03e4);  /* call 0x10169a78 */
            ii(0x100e_9694, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9696, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_9697, 1); pop(edi);                               /* pop edi */
            ii(0x100e_9698, 1); pop(esi);                               /* pop esi */
            ii(0x100e_9699, 1); pop(edx);                               /* pop edx */
            ii(0x100e_969a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_969b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_969c, 1); ret();                                  /* ret */
        }
    }
}

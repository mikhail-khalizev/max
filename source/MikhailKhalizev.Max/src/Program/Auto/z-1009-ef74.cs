using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ef74-b4c8144b")]
        public void Method_1009_ef74()
        {
            ii(0x1009_ef74, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_ef79, 5); call(Definitions.sys_check_available_stack_size, 0xc_6dd4); /* call 0x10165d52 */
            ii(0x1009_ef7e, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ef7f, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ef80, 1); push(edx);                              /* push edx */
            ii(0x1009_ef81, 1); push(esi);                              /* push esi */
            ii(0x1009_ef82, 1); push(edi);                              /* push edi */
            ii(0x1009_ef83, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ef84, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ef86, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_ef8c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_ef8f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ef92, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ef95, 5); call(0x1013_a794, 0x9_b7fa);            /* call 0x1013a794 */
            ii(0x1009_ef9a, 3); sub(eax, 6);                            /* sub eax, 0x6 */
            ii(0x1009_ef9d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_efa0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_efa3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_efa5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_efa6, 1); pop(edi);                               /* pop edi */
            ii(0x1009_efa7, 1); pop(esi);                               /* pop esi */
            ii(0x1009_efa8, 1); pop(edx);                               /* pop edx */
            ii(0x1009_efa9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_efaa, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_efab, 1); ret();                                  /* ret */
        }
    }
}

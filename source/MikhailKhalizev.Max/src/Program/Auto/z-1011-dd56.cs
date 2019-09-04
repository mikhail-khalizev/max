using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_dd56-849f0c48")]
        public void Method_1011_dd56()
        {
            ii(0x1011_dd56, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_dd5b, 5); call(Definitions.sys_check_available_stack_size, 0x4_7ff2); /* call 0x10165d52 */
            ii(0x1011_dd60, 1); push(ebx);                              /* push ebx */
            ii(0x1011_dd61, 1); push(ecx);                              /* push ecx */
            ii(0x1011_dd62, 1); push(esi);                              /* push esi */
            ii(0x1011_dd63, 1); push(edi);                              /* push edi */
            ii(0x1011_dd64, 1); push(ebp);                              /* push ebp */
            ii(0x1011_dd65, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_dd67, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1011_dd6d, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_dd70, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_dd73, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_dd76, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1011_dd79, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1011_dd7c, 5); call(0x1012_0864, 0x2ae3);              /* call 0x10120864 */
            ii(0x1011_dd81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_dd83, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_dd84, 1); pop(edi);                               /* pop edi */
            ii(0x1011_dd85, 1); pop(esi);                               /* pop esi */
            ii(0x1011_dd86, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_dd87, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_dd88, 1); ret();                                  /* ret */
        }
    }
}

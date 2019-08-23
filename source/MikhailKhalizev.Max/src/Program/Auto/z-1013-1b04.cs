using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1b04-66602b45")]
        public void Method_1013_1b04()
        {
            ii(0x1013_1b04, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_1b09, 5); call(Definitions.sys_check_available_stack_size, 0x3_4244); /* call 0x10165d52 */
            ii(0x1013_1b0e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1b0f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1b10, 1); push(edx);                              /* push edx */
            ii(0x1013_1b11, 1); push(esi);                              /* push esi */
            ii(0x1013_1b12, 1); push(edi);                              /* push edi */
            ii(0x1013_1b13, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1b14, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1b16, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_1b1c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_1b1f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1b22, 4); mov(ax, memw[ds, eax + 0x6]);           /* mov ax, [eax+0x6] */
            ii(0x1013_1b26, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1b29, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1b2c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1b2e, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_1b2f, 1); pop(edi);                               /* pop edi */
            ii(0x1013_1b30, 1); pop(esi);                               /* pop esi */
            ii(0x1013_1b31, 1); pop(edx);                               /* pop edx */
            ii(0x1013_1b32, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_1b33, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_1b34, 1); ret();                                  /* ret */
        }
    }
}

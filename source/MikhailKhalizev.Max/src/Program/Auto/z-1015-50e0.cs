using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_50e0-6e6eb7c")]
        public void Method_1015_50e0()
        {
            ii(0x1015_50e0, 5); push(0x20);                             /* push 0x20 */
            ii(0x1015_50e5, 5); call(Definitions.sys_check_available_stack_size, 0x1_0c68); /* call 0x10165d52 */
            ii(0x1015_50ea, 1); push(ebx);                              /* push ebx */
            ii(0x1015_50eb, 1); push(ecx);                              /* push ecx */
            ii(0x1015_50ec, 1); push(edx);                              /* push edx */
            ii(0x1015_50ed, 1); push(esi);                              /* push esi */
            ii(0x1015_50ee, 1); push(edi);                              /* push edi */
            ii(0x1015_50ef, 1); push(ebp);                              /* push ebp */
            ii(0x1015_50f0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_50f2, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1015_50f8, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_50fb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_50fe, 7); mov(memb[ds, eax + 0x9e], 0);           /* mov byte [eax+0x9e], 0x0 */
            ii(0x1015_5105, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_5107, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_5108, 1); pop(edi);                               /* pop edi */
            ii(0x1015_5109, 1); pop(esi);                               /* pop esi */
            ii(0x1015_510a, 1); pop(edx);                               /* pop edx */
            ii(0x1015_510b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_510c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_510d, 1); ret();                                  /* ret */
        }
    }
}

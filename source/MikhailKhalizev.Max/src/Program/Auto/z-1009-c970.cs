using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c970-e290b4b5")]
        public void Method_1009_c970()
        {
            ii(0x1009_c970, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_c975, 5); call(Definitions.sys_check_available_stack_size, 0xc_93d8); /* call 0x10165d52 */
            ii(0x1009_c97a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c97b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c97c, 1); push(esi);                              /* push esi */
            ii(0x1009_c97d, 1); push(edi);                              /* push edi */
            ii(0x1009_c97e, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c97f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c981, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_c987, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c98a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_c98d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_c990, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_c993, 4); mov(memw[ds, edx + 0x78], ax);          /* mov [edx+0x78], ax */
            ii(0x1009_c997, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c999, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c99a, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c99b, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c99c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c99d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c99e, 1); ret();                                  /* ret */
        }
    }
}

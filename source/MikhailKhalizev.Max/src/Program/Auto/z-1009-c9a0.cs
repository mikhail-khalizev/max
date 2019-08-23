using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c9a0-2835c869")]
        public void Method_1009_c9a0()
        {
            ii(0x1009_c9a0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c9a5, 5); call(Definitions.sys_check_available_stack_size, 0xc_93a8); /* call 0x10165d52 */
            ii(0x1009_c9aa, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c9ab, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c9ac, 1); push(edx);                              /* push edx */
            ii(0x1009_c9ad, 1); push(esi);                              /* push esi */
            ii(0x1009_c9ae, 1); push(edi);                              /* push edi */
            ii(0x1009_c9af, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c9b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c9b2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c9b8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c9bb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c9be, 4); mov(ax, memw[ds, eax + 0x78]);          /* mov ax, [eax+0x78] */
            ii(0x1009_c9c2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c9c5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c9c8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c9ca, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c9cb, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c9cc, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c9cd, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c9ce, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c9cf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c9d0, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a9f8-d1206bd7")]
        public void Method_100a_a9f8()
        {
            ii(0x100a_a9f8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a9fd, 5); call(Definitions.sys_check_available_stack_size, 0xb_b350); /* call 0x10165d52 */
            ii(0x100a_aa02, 1); push(ebx);                              /* push ebx */
            ii(0x100a_aa03, 1); push(ecx);                              /* push ecx */
            ii(0x100a_aa04, 1); push(edx);                              /* push edx */
            ii(0x100a_aa05, 1); push(esi);                              /* push esi */
            ii(0x100a_aa06, 1); push(edi);                              /* push edi */
            ii(0x100a_aa07, 1); push(ebp);                              /* push ebp */
            ii(0x100a_aa08, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_aa0a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100a_aa10, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100a_aa13, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100a_aa16, 3); mov(al, memb[ds, eax + 30]);            /* mov al, [eax+0x1e] */
            ii(0x100a_aa19, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x100a_aa1c, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x100a_aa1f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_aa21, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_aa22, 1); pop(edi);                               /* pop edi */
            ii(0x100a_aa23, 1); pop(esi);                               /* pop esi */
            ii(0x100a_aa24, 1); pop(edx);                               /* pop edx */
            ii(0x100a_aa25, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_aa26, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_aa27, 1); ret();                                  /* ret */
        }
    }
}

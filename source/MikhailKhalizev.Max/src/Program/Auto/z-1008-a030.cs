using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a030-4a095b8b")]
        public void Method_1008_a030()
        {
            ii(0x1008_a030, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_a035, 5); call(Definitions.sys_check_available_stack_size, 0xd_bd18); /* call 0x10165d52 */
            ii(0x1008_a03a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a03b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a03c, 1); push(edx);                              /* push edx */
            ii(0x1008_a03d, 1); push(esi);                              /* push esi */
            ii(0x1008_a03e, 1); push(edi);                              /* push edi */
            ii(0x1008_a03f, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a040, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a042, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a048, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a04b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a04e, 4); mov(ax, memw[ds, eax + 0x25]);          /* mov ax, [eax+0x25] */
            ii(0x1008_a052, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a055, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_a058, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a05a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a05b, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a05c, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a05d, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a05e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a05f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a060, 1); ret();                                  /* ret */
        }
    }
}

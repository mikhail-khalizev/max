using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f7ec-10c678fe")]
        public void Method_100c_f7ec()
        {
            ii(0x100c_f7ec, 5); push(0x20);                             /* push 0x20 */
            ii(0x100c_f7f1, 5); call(Definitions.sys_check_available_stack_size, 0x9_655c); /* call 0x10165d52 */
            ii(0x100c_f7f6, 1); push(ecx);                              /* push ecx */
            ii(0x100c_f7f7, 1); push(esi);                              /* push esi */
            ii(0x100c_f7f8, 1); push(edi);                              /* push edi */
            ii(0x100c_f7f9, 1); push(ebp);                              /* push ebp */
            ii(0x100c_f7fa, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f7fc, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_f802, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_f805, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_f808, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_f80b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_f80e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_f811, 3); mov(memd[ds, edx + 0x29], eax);         /* mov [edx+0x29], eax */
            ii(0x100c_f814, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_f817, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100c_f81a, 3); mov(memd[ds, edx + 0x1c], eax);         /* mov [edx+0x1c], eax */
            ii(0x100c_f81d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f81f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_f820, 1); pop(edi);                               /* pop edi */
            ii(0x100c_f821, 1); pop(esi);                               /* pop esi */
            ii(0x100c_f822, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_f823, 1); ret();                                  /* ret */
        }
    }
}

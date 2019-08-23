using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6c98-9e1aa2ad")]
        public void Method_1007_6c98()
        {
            ii(0x1007_6c98, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_6c9d, 5); call(Definitions.sys_check_available_stack_size, 0xe_f0b0); /* call 0x10165d52 */
            ii(0x1007_6ca2, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6ca3, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6ca4, 1); push(esi);                              /* push esi */
            ii(0x1007_6ca5, 1); push(edi);                              /* push edi */
            ii(0x1007_6ca6, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6ca7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6ca9, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6caf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6cb2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6cb5, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_6cb8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6cbb, 5); call(0x1013_ac7d, 0xc_3fbd);            /* call 0x1013ac7d */
            ii(0x1007_6cc0, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_6cc3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_6cc6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6cc8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6cc9, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6cca, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6ccb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6ccc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6ccd, 1); ret();                                  /* ret */
        }
    }
}

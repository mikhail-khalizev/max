using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c2d4-4a60c08e")]
        public void Method_1009_c2d4()
        {
            ii(0x1009_c2d4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c2d9, 5); call(Definitions.sys_check_available_stack_size, 0xc_9a74); /* call 0x10165d52 */
            ii(0x1009_c2de, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c2df, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c2e0, 1); push(esi);                              /* push esi */
            ii(0x1009_c2e1, 1); push(edi);                              /* push edi */
            ii(0x1009_c2e2, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c2e3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c2e5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c2eb, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c2ee, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_c2f1, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_c2f4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c2f7, 5); call(0x1013_ac7d, 0x9_e981);            /* call 0x1013ac7d */
            ii(0x1009_c2fc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_c2ff, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_c302, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c304, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c305, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c306, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c307, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c308, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c309, 1); ret();                                  /* ret */
        }
    }
}

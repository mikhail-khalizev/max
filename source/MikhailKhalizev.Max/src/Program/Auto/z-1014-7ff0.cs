using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7ff0-51a77be0")]
        public void Method_1014_7ff0()
        {
            ii(0x1014_7ff0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_7ff5, 5); call(Definitions.sys_check_available_stack_size, 0x1_dd58); /* call 0x10165d52 */
            ii(0x1014_7ffa, 1); push(ebx);                              /* push ebx */
            ii(0x1014_7ffb, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7ffc, 1); push(esi);                              /* push esi */
            ii(0x1014_7ffd, 1); push(edi);                              /* push edi */
            ii(0x1014_7ffe, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7fff, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8001, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_8007, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_800a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_800d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_8010, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_8013, 5); call(0x1013_ac7d, -0xd39b);             /* call 0x1013ac7d */
            ii(0x1014_8018, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_801b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_801e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8020, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_8021, 1); pop(edi);                               /* pop edi */
            ii(0x1014_8022, 1); pop(esi);                               /* pop esi */
            ii(0x1014_8023, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_8024, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_8025, 1); ret();                                  /* ret */
        }
    }
}

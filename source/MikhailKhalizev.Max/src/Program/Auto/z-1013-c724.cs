using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c724-7695c1ea")]
        public void Method_1013_c724()
        {
            ii(0x1013_c724, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c729, 5); call(Definitions.sys_check_available_stack_size, 0x2_9624); /* call 0x10165d52 */
            ii(0x1013_c72e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c72f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c730, 1); push(edx);                              /* push edx */
            ii(0x1013_c731, 1); push(esi);                              /* push esi */
            ii(0x1013_c732, 1); push(edi);                              /* push edi */
            ii(0x1013_c733, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c734, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c736, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1013_c73c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_c73f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c742, 5); call(0x1007_6b58, -0xc_5bef);           /* call 0x10076b58 */
            ii(0x1013_c747, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c74a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c74d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c74f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c750, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c751, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c752, 1); pop(edx);                               /* pop edx */
            ii(0x1013_c753, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c754, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c755, 1); ret();                                  /* ret */
        }
    }
}

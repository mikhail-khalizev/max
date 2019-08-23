using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1cb4-701a3e10")]
        public void Method_1013_1cb4()
        {
            ii(0x1013_1cb4, 1); push(ebx);                              /* push ebx */
            ii(0x1013_1cb5, 1); push(ecx);                              /* push ecx */
            ii(0x1013_1cb6, 1); push(edx);                              /* push edx */
            ii(0x1013_1cb7, 1); push(esi);                              /* push esi */
            ii(0x1013_1cb8, 1); push(edi);                              /* push edi */
            ii(0x1013_1cb9, 1); push(ebp);                              /* push ebp */
            ii(0x1013_1cba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_1cbc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_1cc2, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_1cc5, 5); mov(edx, 0x101c_3678);                  /* mov edx, 0x101c3678 */
            ii(0x1013_1cca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1ccd, 5); call(0x100d_4d78, -0x5_cf5a);           /* call 0x100d4d78 */
            ii(0x1013_1cd2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1cd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_1cd7, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_1cd8, 1); pop(edi);                               /* pop edi */
            ii(0x1013_1cd9, 1); pop(esi);                               /* pop esi */
            ii(0x1013_1cda, 1); pop(edx);                               /* pop edx */
            ii(0x1013_1cdb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_1cdc, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_1cdd, 1); ret();                                  /* ret */
        }
    }
}

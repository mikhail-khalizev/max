using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2aac-b70b8a0f")]
        public void Method_1010_2aac()
        {
            ii(0x1010_2aac, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2aad, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2aae, 1); push(edx);                              /* push edx */
            ii(0x1010_2aaf, 1); push(esi);                              /* push esi */
            ii(0x1010_2ab0, 1); push(edi);                              /* push edi */
            ii(0x1010_2ab1, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2ab2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2ab4, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_2aba, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_2abe, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1010_2ac1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2ac3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2ac4, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2ac5, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2ac6, 1); pop(edx);                               /* pop edx */
            ii(0x1010_2ac7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2ac8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2ac9, 1); ret();                                  /* ret */
        }
    }
}

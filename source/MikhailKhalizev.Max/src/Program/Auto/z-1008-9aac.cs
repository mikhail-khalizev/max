using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9aac-44b9eb0e")]
        public void Method_1008_9aac()
        {
            ii(0x1008_9aac, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9aad, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9aae, 1); push(edx);                              /* push edx */
            ii(0x1008_9aaf, 1); push(esi);                              /* push esi */
            ii(0x1008_9ab0, 1); push(edi);                              /* push edi */
            ii(0x1008_9ab1, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9ab2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9ab4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_9aba, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1008_9abe, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1008_9ac1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9ac3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9ac4, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9ac5, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9ac6, 1); pop(edx);                               /* pop edx */
            ii(0x1008_9ac7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9ac8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9ac9, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b0e4-b70b8a0f")]
        public void Method_1008_b0e4()
        {
            ii(0x1008_b0e4, 1); push(ebx);                              /* push ebx */
            ii(0x1008_b0e5, 1); push(ecx);                              /* push ecx */
            ii(0x1008_b0e6, 1); push(edx);                              /* push edx */
            ii(0x1008_b0e7, 1); push(esi);                              /* push esi */
            ii(0x1008_b0e8, 1); push(edi);                              /* push edi */
            ii(0x1008_b0e9, 1); push(ebp);                              /* push ebp */
            ii(0x1008_b0ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b0ec, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1008_b0f2, 4); mov(memb[ss, ebp - 4], 0);              /* mov byte [ebp-0x4], 0x0 */
            ii(0x1008_b0f6, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1008_b0f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b0fb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_b0fc, 1); pop(edi);                               /* pop edi */
            ii(0x1008_b0fd, 1); pop(esi);                               /* pop esi */
            ii(0x1008_b0fe, 1); pop(edx);                               /* pop edx */
            ii(0x1008_b0ff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_b100, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_b101, 1); ret();                                  /* ret */
        }
    }
}

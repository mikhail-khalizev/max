using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a6d4-6f3a482f")]
        public void Method_1008_a6d4()
        {
            ii(0x1008_a6d4, 1); push(ebx);                              /* push ebx */
            ii(0x1008_a6d5, 1); push(ecx);                              /* push ecx */
            ii(0x1008_a6d6, 1); push(edx);                              /* push edx */
            ii(0x1008_a6d7, 1); push(esi);                              /* push esi */
            ii(0x1008_a6d8, 1); push(edi);                              /* push edi */
            ii(0x1008_a6d9, 1); push(ebp);                              /* push ebp */
            ii(0x1008_a6da, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a6dc, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1008_a6e2, 7); mov(memd[ss, ebp - 4], 0xffff_ffff);    /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x1008_a6e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_a6ec, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a6ee, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_a6ef, 1); pop(edi);                               /* pop edi */
            ii(0x1008_a6f0, 1); pop(esi);                               /* pop esi */
            ii(0x1008_a6f1, 1); pop(edx);                               /* pop edx */
            ii(0x1008_a6f2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_a6f3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_a6f4, 1); ret();                                  /* ret */
        }
    }
}

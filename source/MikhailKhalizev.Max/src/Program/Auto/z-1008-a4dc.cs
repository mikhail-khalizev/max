using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a4dc-b70b8a0f")]
        public void Method_1008_a4dc()
        {
            ii(0x1008_a4dc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a4dd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a4de, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a4df, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a4e0, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a4e1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a4e2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a4e4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1008_a4ea, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1008_a4ee, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1008_a4f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a4f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a4f4, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a4f5, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a4f6, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a4f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a4f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a4f9, 1); retd();                                 /* ret */
        }
    }
}

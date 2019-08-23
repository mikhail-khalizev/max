using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5204-44b9eb0e")]
        public void Method_100d_5204()
        {
            ii(0x100d_5204, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_5205, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_5206, 1); pushd(edx);                             /* push edx */
            ii(0x100d_5207, 1); pushd(esi);                             /* push esi */
            ii(0x100d_5208, 1); pushd(edi);                             /* push edi */
            ii(0x100d_5209, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_520a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_520c, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_5212, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_5216, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_5219, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_521b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_521c, 1); popd(edi);                              /* pop edi */
            ii(0x100d_521d, 1); popd(esi);                              /* pop esi */
            ii(0x100d_521e, 1); popd(edx);                              /* pop edx */
            ii(0x100d_521f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_5220, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_5221, 1); retd();                                 /* ret */
        }
    }
}

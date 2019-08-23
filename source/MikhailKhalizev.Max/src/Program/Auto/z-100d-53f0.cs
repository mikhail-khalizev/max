using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_53f0-b70b8a0f")]
        public void Method_100d_53f0()
        {
            ii(0x100d_53f0, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_53f1, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_53f2, 1); pushd(edx);                             /* push edx */
            ii(0x100d_53f3, 1); pushd(esi);                             /* push esi */
            ii(0x100d_53f4, 1); pushd(edi);                             /* push edi */
            ii(0x100d_53f5, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_53f6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_53f8, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_53fe, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100d_5402, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_5405, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5407, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_5408, 1); popd(edi);                              /* pop edi */
            ii(0x100d_5409, 1); popd(esi);                              /* pop esi */
            ii(0x100d_540a, 1); popd(edx);                              /* pop edx */
            ii(0x100d_540b, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_540c, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_540d, 1); retd();                                 /* ret */
        }
    }
}

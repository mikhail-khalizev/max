using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_50b4-b70b8a0f")]
        public void Method_100d_50b4()
        {
            ii(0x100d_50b4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_50b5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_50b6, 1); pushd(edx);                             /* push edx */
            ii(0x100d_50b7, 1); pushd(esi);                             /* push esi */
            ii(0x100d_50b8, 1); pushd(edi);                             /* push edi */
            ii(0x100d_50b9, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_50ba, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_50bc, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_50c2, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x100d_50c6, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_50c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_50cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_50cc, 1); popd(edi);                              /* pop edi */
            ii(0x100d_50cd, 1); popd(esi);                              /* pop esi */
            ii(0x100d_50ce, 1); popd(edx);                              /* pop edx */
            ii(0x100d_50cf, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_50d0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_50d1, 1); retd();                                 /* ret */
        }
    }
}

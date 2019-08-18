using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_85dc-44b9eb0e")]
        public void Method_100e_85dc()
        {
            ii(0x100e_85dc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_85dd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_85de, 1); pushd(edx);                             /* push edx */
            ii(0x100e_85df, 1); pushd(esi);                             /* push esi */
            ii(0x100e_85e0, 1); pushd(edi);                             /* push edi */
            ii(0x100e_85e1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_85e2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_85e4, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_85ea, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x100e_85ee, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100e_85f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_85f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_85f4, 1); popd(edi);                              /* pop edi */
            ii(0x100e_85f5, 1); popd(esi);                              /* pop esi */
            ii(0x100e_85f6, 1); popd(edx);                              /* pop edx */
            ii(0x100e_85f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_85f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_85f9, 1); retd(); return;                         /* ret */
        }
    }
}

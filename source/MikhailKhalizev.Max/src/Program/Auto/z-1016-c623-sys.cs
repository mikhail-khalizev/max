using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("814ba8fe-24f7-4d38-a2f6-a782ed629b3e")]
        public void /* sys */ Method_1016_c623()
        {
            ii(0x1016_c623, 1); pushd(esi);                             /* push esi */
            ii(0x1016_c624, 1); pushd(edi);                             /* push edi */
            ii(0x1016_c625, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_c626, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_c628, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1016_c62a, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
            ii(0x1016_c62c, 2); mov(edx, ebp);                          /* mov edx, ebp */
            ii(0x1016_c62e, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1016_c630, 5); calld(/* sys */ 0x1018_79b4, 0x1_b37f); /* call 0x101879b4 */
            ii(0x1016_c635, 3); mov(eax, memd_a32[ss, ebp + 0]);        /* mov eax, [ebp] */
            ii(0x1016_c638, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_c639, 1); popd(edi);                              /* pop edi */
            ii(0x1016_c63a, 1); popd(esi);                              /* pop esi */
            ii(0x1016_c63b, 1); retd(); return;                         /* ret */
        }
    }
}

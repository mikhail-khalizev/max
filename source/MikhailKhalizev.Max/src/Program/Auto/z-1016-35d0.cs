using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_35d0-fff56977")]
        public void Method_1016_35d0()
        {
            ii(0x1016_35d0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_35d5, 5); calld(Definitions.sys_check_available_stack_size, 0x2778); /* call 0x10165d52 */
            ii(0x1016_35da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_35db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_35dc, 1); pushd(edx);                             /* push edx */
            ii(0x1016_35dd, 1); pushd(esi);                             /* push esi */
            ii(0x1016_35de, 1); pushd(edi);                             /* push edi */
            ii(0x1016_35df, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_35e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_35e2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_35e8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_35eb, 5); mov(eax, 0x101c_b100);                  /* mov eax, 0x101cb100 */
            ii(0x1016_35f0, 5); calld(0x1012_0d64, -0x4_2891);          /* call 0x10120d64 */
            ii(0x1016_35f5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_35f8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_35fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_35fd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_35fe, 1); popd(edi);                              /* pop edi */
            ii(0x1016_35ff, 1); popd(esi);                              /* pop esi */
            ii(0x1016_3600, 1); popd(edx);                              /* pop edx */
            ii(0x1016_3601, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_3602, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_3603, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f1557e7-d665-47f2-aed2-26dd7b402962")]
        public void Method_100e_0cf0()
        {
            ii(0x100e_0cf0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0cf5, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5058); /* call 0x10165d52 */
            ii(0x100e_0cfa, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0cfb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0cfc, 1); pushd(edx);                             /* push edx */
            ii(0x100e_0cfd, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0cfe, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0cff, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0d00, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0d02, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0d08, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_0d0b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_0d0e, 5); calld(0x1007_6b58, -0x6_a1bb);          /* call 0x10076b58 */
            ii(0x100e_0d13, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0d16, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0d19, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0d1b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0d1c, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0d1d, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0d1e, 1); popd(edx);                              /* pop edx */
            ii(0x100e_0d1f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0d20, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0d21, 1); retd(); return;                         /* ret */
        }
    }
}

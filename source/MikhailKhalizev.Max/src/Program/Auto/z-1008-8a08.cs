using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5697a70d-beef-4cc8-a5d1-2c73da12571b")]
        public void Method_1008_8a08()
        {
            ii(0x1008_8a08, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8a0d, 5); calld(Definitions.sys_check_available_stack_size, 0xd_d340); /* call 0x10165d52 */
            ii(0x1008_8a12, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8a13, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8a14, 1); pushd(edx);                             /* push edx */
            ii(0x1008_8a15, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8a16, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8a17, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8a18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8a1a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_8a20, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_8a23, 5); calld(0x1008_a4fc, 0x1ad4);             /* call 0x1008a4fc */
            ii(0x1008_8a28, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1008_8a2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_8a2e, 5); calld(0x100b_84c2, 0x2_fa8f);           /* call 0x100b84c2 */
            ii(0x1008_8a33, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8a36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8a39, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8a3b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8a3c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8a3d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8a3e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_8a3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8a40, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8a41, 1); retd(); return;                         /* ret */
        }
    }
}

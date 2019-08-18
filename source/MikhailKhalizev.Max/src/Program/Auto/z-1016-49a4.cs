using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("028ea186-f912-47d4-9db4-f7fe859cf0bd")]
        public void Method_1016_49a4()
        {
            ii(0x1016_49a4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_49a9, 5); calld(Definitions.sys_check_available_stack_size, 0x13a4); /* call 0x10165d52 */
            ii(0x1016_49ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_49af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_49b0, 1); pushd(edx);                             /* push edx */
            ii(0x1016_49b1, 1); pushd(esi);                             /* push esi */
            ii(0x1016_49b2, 1); pushd(edi);                             /* push edi */
            ii(0x1016_49b3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_49b4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_49b6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_49bc, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_49bf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_49c2, 5); calld(0x1007_6c30, -0xe_dd97);          /* call 0x10076c30 */
            ii(0x1016_49c7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_49ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_49cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_49cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_49d0, 1); popd(edi);                              /* pop edi */
            ii(0x1016_49d1, 1); popd(esi);                              /* pop esi */
            ii(0x1016_49d2, 1); popd(edx);                              /* pop edx */
            ii(0x1016_49d3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_49d4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_49d5, 1); retd(); return;                         /* ret */
        }
    }
}

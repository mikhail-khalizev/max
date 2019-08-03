using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b241ccb2-ee21-4cbe-adc6-4b9efac69d06")]
        public void Method_1011_7d24()
        {
            ii(0x1011_7d24, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_7d29, 5); calld(Definitions.sys_check_available_stack_size, 0x4e024); /* call 0x10165d52 */
            ii(0x1011_7d2e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7d2f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7d30, 1); pushd(edx);                             /* push edx */
            ii(0x1011_7d31, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7d32, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7d33, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7d34, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7d36, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_7d3c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_7d3f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7d42, 5); calld(0x1007_6c30, -0xa1117);           /* call 0x10076c30 */
            ii(0x1011_7d47, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7d4a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7d4d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7d4f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7d50, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7d51, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7d52, 1); popd(edx);                              /* pop edx */
            ii(0x1011_7d53, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7d54, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7d55, 1); retd(); return;                         /* ret */
        }
    }
}

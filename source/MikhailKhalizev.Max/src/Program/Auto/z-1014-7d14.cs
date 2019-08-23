using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7d14-4ee380c")]
        public void Method_1014_7d14()
        {
            ii(0x1014_7d14, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7d19, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e034); /* call 0x10165d52 */
            ii(0x1014_7d1e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7d1f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7d20, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7d21, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7d22, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7d23, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7d24, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7d26, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7d2c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7d2f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7d32, 5); calld(0x1007_6c30, -0xd_1107);          /* call 0x10076c30 */
            ii(0x1014_7d37, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7d3a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7d3d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7d3f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7d40, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7d41, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7d42, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7d43, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7d44, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7d45, 1); retd();                                 /* ret */
        }
    }
}

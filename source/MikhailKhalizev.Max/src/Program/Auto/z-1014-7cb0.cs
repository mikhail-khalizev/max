using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7cb0-cf326317")]
        public void Method_1014_7cb0()
        {
            ii(0x1014_7cb0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7cb5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e098); /* call 0x10165d52 */
            ii(0x1014_7cba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7cbb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7cbc, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7cbd, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7cbe, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7cbf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7cc0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7cc2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7cc8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7ccb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7cce, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_7cd1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7cd4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7cd7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7cd9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7cda, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7cdb, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7cdc, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7cdd, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7cde, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7cdf, 1); retd(); return;                         /* ret */
        }
    }
}

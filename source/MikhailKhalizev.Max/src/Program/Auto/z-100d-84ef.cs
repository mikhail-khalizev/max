using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9eb814c0-553b-44da-8c6a-7dea4b69205b")]
        public void Method_100d_84ef()
        {
            ii(0x100d_84ef, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_84f4, 5); calld(Definitions.sys_check_available_stack_size, 0x8_d859); /* call 0x10165d52 */
            ii(0x100d_84f9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_84fa, 1); pushd(esi);                             /* push esi */
            ii(0x100d_84fb, 1); pushd(edi);                             /* push edi */
            ii(0x100d_84fc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_84fd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_84ff, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_8505, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_8508, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_850b, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_850e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_8511, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_8514, 4); mov(memw_a32[ds, edx + 0x19], ax);      /* mov [edx+0x19], ax */
            ii(0x100d_8518, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_851b, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_851e, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x100d_8521, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8523, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8524, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8525, 1); popd(esi);                              /* pop esi */
            ii(0x100d_8526, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_8527, 1); retd(); return;                         /* ret */
        }
    }
}
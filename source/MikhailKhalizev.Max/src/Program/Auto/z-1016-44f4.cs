using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_44f4-7236c0eb")]
        public void Method_1016_44f4()
        {
            ii(0x1016_44f4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_44f9, 5); calld(Definitions.sys_check_available_stack_size, 0x1854); /* call 0x10165d52 */
            ii(0x1016_44fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_44ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4500, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4501, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4502, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4503, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4505, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_450b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_450e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_4511, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4514, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4517, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_451a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_451c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_451d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_451e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_451f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4520, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4521, 1); retd(); return;                         /* ret */
        }
    }
}

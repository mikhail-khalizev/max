using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04329e00-49b3-4751-92e9-23c15058f7c9")]
        public void Method_100c_b77c()
        {
            ii(0x100c_b77c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b781, 5); calld(Definitions.sys_check_available_stack_size, 0x9a5cc); /* call 0x10165d52 */
            ii(0x100c_b786, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b787, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b788, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b789, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b78a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b78b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b78d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b793, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b796, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b799, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_b79c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b79f, 5); calld(0x1013_ac7d, 0x6f4d9);            /* call 0x1013ac7d */
            ii(0x100c_b7a4, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b7a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b7aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b7ac, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b7ad, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b7ae, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b7af, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b7b0, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b7b1, 1); retd(); return;                         /* ret */
        }
    }
}

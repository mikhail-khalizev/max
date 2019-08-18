using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f253b0a4-d399-495c-aff9-8da73354bc66")]
        public void Method_1014_7ea0()
        {
            ii(0x1014_7ea0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7ea5, 5); calld(Definitions.sys_check_available_stack_size, 0x1_dea8); /* call 0x10165d52 */
            ii(0x1014_7eaa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7eab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7eac, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7ead, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7eae, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7eaf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7eb0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7eb2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7eb8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7ebb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7ebe, 5); calld(0x1007_6b58, -0xd_136b);          /* call 0x10076b58 */
            ii(0x1014_7ec3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7ec6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7ec9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7ecb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7ecc, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7ecd, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7ece, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7ecf, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7ed0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7ed1, 1); retd(); return;                         /* ret */
        }
    }
}

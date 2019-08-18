using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("795e8880-3007-492b-9d0c-ca726c8d5858")]
        public void Method_1008_8dcc()
        {
            ii(0x1008_8dcc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_8dd1, 5); calld(Definitions.sys_check_available_stack_size, 0xd_cf7c); /* call 0x10165d52 */
            ii(0x1008_8dd6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_8dd7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_8dd8, 1); pushd(esi);                             /* push esi */
            ii(0x1008_8dd9, 1); pushd(edi);                             /* push edi */
            ii(0x1008_8dda, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_8ddb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8ddd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8de3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8de6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_8de9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8dee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8df1, 5); calld(0x1008_8d8c, -0x6a);              /* call 0x10088d8c */
            ii(0x1008_8df6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_8df9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_8dfc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8dff, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_8e02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8e04, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8e05, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8e06, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8e07, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8e08, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8e09, 1); retd(); return;                         /* ret */
        }
    }
}

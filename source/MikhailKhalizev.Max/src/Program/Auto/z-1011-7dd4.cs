using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f1202a6-21be-47cd-a887-09fa20efd1b0")]
        public void Method_1011_7dd4()
        {
            ii(0x1011_7dd4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1011_7dd9, 5); calld(Definitions.sys_check_available_stack_size, 0x4_df74); /* call 0x10165d52 */
            ii(0x1011_7dde, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7ddf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7de0, 1); pushd(edx);                             /* push edx */
            ii(0x1011_7de1, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7de2, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7de3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7de4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_7de6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_7dec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_7def, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7df2, 5); calld(0x1007_6d58, -0xa_109f);          /* call 0x10076d58 */
            ii(0x1011_7df7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_7dfa, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1011_7dfd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7e00, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_7e03, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_7e06, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_7e09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_7e0b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_7e0c, 1); popd(edi);                              /* pop edi */
            ii(0x1011_7e0d, 1); popd(esi);                              /* pop esi */
            ii(0x1011_7e0e, 1); popd(edx);                              /* pop edx */
            ii(0x1011_7e0f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_7e10, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_7e11, 1); retd(); return;                         /* ret */
        }
    }
}

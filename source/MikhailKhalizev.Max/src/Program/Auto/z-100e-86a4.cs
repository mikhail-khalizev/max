using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dd43a172-77fe-4c6f-bd71-62eab9aa2492")]
        public void Method_100e_86a4()
        {
            ii(0x100e_86a4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_86a9, 5); calld(Definitions.sys_check_available_stack_size, 0x7d6a4); /* call 0x10165d52 */
            ii(0x100e_86ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_86af, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_86b0, 1); pushd(esi);                             /* push esi */
            ii(0x100e_86b1, 1); pushd(edi);                             /* push edi */
            ii(0x100e_86b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_86b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_86b5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_86bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_86be, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_86c1, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100e_86c5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_86c8, 5); calld(0x1013_b052, 0x52985);            /* call 0x1013b052 */
            ii(0x100e_86cd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_86d0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_86d3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_86d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_86d9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_86dc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_86df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_86e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_86e2, 1); popd(edi);                              /* pop edi */
            ii(0x100e_86e3, 1); popd(esi);                              /* pop esi */
            ii(0x100e_86e4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_86e5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_86e6, 1); retd(); return;                         /* ret */
        }
    }
}

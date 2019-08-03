using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("330b941e-dde6-432b-b68a-784ae47c6a03")]
        public void Method_100b_84c2()
        {
            ii(0x100b_84c2, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100b_84c7, 5); calld(Definitions.sys_check_available_stack_size, 0xad886); /* call 0x10165d52 */
            ii(0x100b_84cc, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_84cd, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_84ce, 1); pushd(esi);                             /* push esi */
            ii(0x100b_84cf, 1); pushd(edi);                             /* push edi */
            ii(0x100b_84d0, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_84d1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_84d3, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100b_84d9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_84dc, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_84df, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100b_84e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_84e6, 5); calld(0x100c_b418, 0x12f2d);            /* call 0x100cb418 */
            ii(0x100b_84eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_84ee, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100b_84f1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_84f4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_84f7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_84fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_84fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_84ff, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_8500, 1); popd(edi);                              /* pop edi */
            ii(0x100b_8501, 1); popd(esi);                              /* pop esi */
            ii(0x100b_8502, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_8503, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_8504, 1); retd(); return;                         /* ret */
        }
    }
}

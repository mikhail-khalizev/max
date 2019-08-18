using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b3a4-6e581a6d")]
        public void Method_1008_b3a4()
        {
            ii(0x1008_b3a4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_b3a9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_a9a4); /* call 0x10165d52 */
            ii(0x1008_b3ae, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b3af, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b3b0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b3b1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b3b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b3b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b3b5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_b3bb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b3be, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_b3c1, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1008_b3c6, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1008_b3ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b3cd, 5); calld(0x1013_af3b, 0xa_fb69);           /* call 0x1013af3b */
            ii(0x1008_b3d2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b3d5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_b3d8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_b3db, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b3de, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_b3e1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_b3e4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b3e6, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b3e7, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b3e8, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b3e9, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b3ea, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b3eb, 1); retd(); return;                         /* ret */
        }
    }
}

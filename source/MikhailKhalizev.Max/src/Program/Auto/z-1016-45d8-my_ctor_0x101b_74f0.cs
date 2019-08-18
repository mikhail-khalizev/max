using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_45d8-24d6c3b8")]
        public void my_ctor_0x101b_74f0()
        {
            ii(0x1016_45d8, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1016_45dd, 5); calld(Definitions.sys_check_available_stack_size, 0x1770); /* call 0x10165d52 */
            ii(0x1016_45e2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_45e3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_45e4, 1); pushd(edx);                             /* push edx */
            ii(0x1016_45e5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_45e6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_45e7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_45e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_45ea, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_45f0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_45f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_45f6, 5); add(eax, 0xfe);                         /* add eax, 0xfe */
            ii(0x1016_45fb, 5); calld(Definitions.my_ctor_0x101b_38f8, -0xe_df10); /* call 0x100766f0 */
            ii(0x1016_4600, 5); sub(eax, 0xfe);                         /* sub eax, 0xfe */
            ii(0x1016_4605, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1016_4608, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1016_460b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_460e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4611, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4614, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4617, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4619, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_461a, 1); popd(edi);                              /* pop edi */
            ii(0x1016_461b, 1); popd(esi);                              /* pop esi */
            ii(0x1016_461c, 1); popd(edx);                              /* pop edx */
            ii(0x1016_461d, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_461e, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_461f, 1); retd(); return;                         /* ret */
        }
    }
}

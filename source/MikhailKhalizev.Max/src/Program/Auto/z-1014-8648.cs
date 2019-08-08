using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9c114321-80ae-40f3-b2f6-ecee1bcee2e5")]
        public void Method_1014_8648()
        {
            ii(0x1014_8648, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_864d, 5); calld(Definitions.sys_check_available_stack_size, 0x1_d700); /* call 0x10165d52 */
            ii(0x1014_8652, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8653, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8654, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8655, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8656, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8657, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8659, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_865f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8662, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_8665, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8668, 5); calld(0x1013_aaa8, -0xdbc5);            /* call 0x1013aaa8 */
            ii(0x1014_866d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8670, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8673, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_8676, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8679, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_867c, 5); calld(Definitions.my_ctor_0x101b38f8, -0xd_1f91); /* call 0x100766f0 */
            ii(0x1014_8681, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1014_8684, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8687, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_868a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_868d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_8690, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_730c); /* mov dword [eax+0x2], 0x101b730c */
            ii(0x1014_8697, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_869a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_869d, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_86a0, 5); calld(0x1007_6630, -0xd_2075);          /* call 0x10076630 */
            ii(0x1014_86a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_86a8, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_86ab, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_86ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_86b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_86b1, 1); popd(edi);                              /* pop edi */
            ii(0x1014_86b2, 1); popd(esi);                              /* pop esi */
            ii(0x1014_86b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_86b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_86b5, 1); retd(); return;                         /* ret */
        }
    }
}

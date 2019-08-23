using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_47a0-b0a4d41a")]
        public void Method_1014_47a0()
        {
            ii(0x1014_47a0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_47a5, 5); calld(Definitions.sys_check_available_stack_size, 0x2_15a8); /* call 0x10165d52 */
            ii(0x1014_47aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_47ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_47ac, 1); pushd(esi);                             /* push esi */
            ii(0x1014_47ad, 1); pushd(edi);                             /* push edi */
            ii(0x1014_47ae, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_47af, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_47b1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_47b7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_47ba, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_47bd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_47c0, 3); mov(eax, memd_a32[ds, eax + 0x42]);     /* mov eax, [eax+0x42] */
            ii(0x1014_47c3, 5); calld(0x100c_fbbe, -0x7_4c0a);          /* call 0x100cfbbe */
            ii(0x1014_47c8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_47cb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_47ce, 7); add(memw_a32[ds, edx + 0x152], ax);     /* add [edx+0x152], ax */
            ii(0x1014_47d5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_47d8, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_47db, 7); sub(memw_a32[ds, edx + 0x15c], ax);     /* sub [edx+0x15c], ax */
            ii(0x1014_47e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_47e5, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_47e8, 5); calld(0x1007_6884, -0xc_df69);          /* call 0x10076884 */
            ii(0x1014_47ed, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_47ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_47f2, 4); add(memw_a32[ds, edx + 0xc], ax);       /* add [edx+0xc], ax */
            ii(0x1014_47f6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_47f9, 5); calld(0x1014_3d54, -0xaaa);             /* call 0x10143d54 */
            ii(0x1014_47fe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4800, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_4801, 1); popd(edi);                              /* pop edi */
            ii(0x1014_4802, 1); popd(esi);                              /* pop esi */
            ii(0x1014_4803, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_4804, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_4805, 1); retd();                                 /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2786-817fe14c")]
        public void Method_100a_2786()
        {
            ii(0x100a_2786, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_278b, 5); calld(Definitions.sys_check_available_stack_size, 0xc_35c2); /* call 0x10165d52 */
            ii(0x100a_2790, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2791, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2792, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2793, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2794, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2795, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2797, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_279d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_27a0, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_27a3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_27a6, 5); calld(0x1013_aaa8, 0x9_82fd);           /* call 0x1013aaa8 */
            ii(0x100a_27ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_27ae, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_27b1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_27b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_27b7, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_27ba, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x1_771b); /* call 0x1008b0a4 */
            ii(0x100a_27bf, 3); sub(eax, 0xf);                          /* sub eax, 0xf */
            ii(0x100a_27c2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_27c5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_27c8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_27cb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_27ce, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4f54); /* mov dword [eax+0x2], 0x101b4f54 */
            ii(0x100a_27d5, 7); inc(memw_a32[ds, 0x101c_31b6]);         /* inc word [0x101c31b6] */
            ii(0x100a_27dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_27df, 3); mov(dl, memb_a32[ds, eax + 0x6]);       /* mov dl, [eax+0x6] */
            ii(0x100a_27e2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_27e5, 3); mov(memb_a32[ds, eax + 0x6], dl);       /* mov [eax+0x6], dl */
            ii(0x100a_27e8, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_27eb, 3); mov(dl, memb_a32[ds, eax + 0x7]);       /* mov dl, [eax+0x7] */
            ii(0x100a_27ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_27f1, 3); mov(memb_a32[ds, eax + 0x7], dl);       /* mov [eax+0x7], dl */
            ii(0x100a_27f4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_27f7, 3); mov(dl, memb_a32[ds, eax + 0x8]);       /* mov dl, [eax+0x8] */
            ii(0x100a_27fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_27fd, 3); mov(memb_a32[ds, eax + 0x8], dl);       /* mov [eax+0x8], dl */
            ii(0x100a_2800, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2803, 4); mov(dx, memw_a32[ds, eax + 0x9]);       /* mov dx, [eax+0x9] */
            ii(0x100a_2807, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_280a, 4); mov(memw_a32[ds, eax + 0x9], dx);       /* mov [eax+0x9], dx */
            ii(0x100a_280e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2811, 4); mov(dx, memw_a32[ds, eax + 0xb]);       /* mov dx, [eax+0xb] */
            ii(0x100a_2815, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2818, 4); mov(memw_a32[ds, eax + 0xb], dx);       /* mov [eax+0xb], dx */
            ii(0x100a_281c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_281f, 4); mov(dx, memw_a32[ds, eax + 0xd]);       /* mov dx, [eax+0xd] */
            ii(0x100a_2823, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2826, 4); mov(memw_a32[ds, eax + 0xd], dx);       /* mov [eax+0xd], dx */
            ii(0x100a_282a, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_282d, 3); add(edx, 0xf);                          /* add edx, 0xf */
            ii(0x100a_2830, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_2833, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2836, 5); calld(0x100a_b230, 0x89f5);             /* call 0x100ab230 */
            ii(0x100a_283b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_283e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_2841, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_2844, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2846, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2847, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2848, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2849, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_284a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_284b, 1); retd();                                 /* ret */
        }
    }
}

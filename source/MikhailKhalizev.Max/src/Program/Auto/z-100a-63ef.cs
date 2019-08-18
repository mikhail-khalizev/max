using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_63ef-42244d84")]
        public void Method_100a_63ef()
        {
            ii(0x100a_63ef, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100a_63f4, 5); calld(Definitions.sys_check_available_stack_size, 0xb_f959); /* call 0x10165d52 */
            ii(0x100a_63f9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_63fa, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_63fb, 1); pushd(esi);                             /* push esi */
            ii(0x100a_63fc, 1); pushd(edi);                             /* push edi */
            ii(0x100a_63fd, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_63fe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_6400, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100a_6406, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_6409, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_640c, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_640f, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x100a_6412, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6415, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6418, 5); calld(0x1008_b268, -0x1_b1b5);          /* call 0x1008b268 */
            ii(0x100a_641d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_6420, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_6423, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100a_6426, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_6429, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_642c, 5); calld(0x100a_6125, -0x30c);             /* call 0x100a6125 */
            ii(0x100a_6431, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_6434, 6); if(jzd(0x100a_64be, 0x84)) goto l_0x100a_64be; /* jz 0x100a64be */
            ii(0x100a_643a, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100a_643e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6441, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_6444, 5); calld(0x1008_b32c, -0x1_b11d);          /* call 0x1008b32c */
            ii(0x100a_6449, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_644c, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_644f, 5); calld(0x1008_af28, -0x1_b52c);          /* call 0x1008af28 */
            ii(0x100a_6454, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_6457, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_645a, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_645d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_6460, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_6463, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
            ii(0x100a_6466, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_6469, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_646c, 5); calld(Definitions.my_2_get_count, -0x1_b109); /* call 0x1008b368 */
            ii(0x100a_6471, 1); cwde();                                 /* cwde */
            ii(0x100a_6472, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_6474, 2); if(jnzd(0x100a_64be, 0x48)) goto l_0x100a_64be; /* jnz 0x100a64be */
            ii(0x100a_6476, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_6478, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_647b, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_647e, 5); calld(0x1013_ad71, 0x9_48ee);           /* call 0x1013ad71 */
            ii(0x100a_6483, 2); test(al, al);                           /* test al, al */
            ii(0x100a_6485, 2); if(jzd(0x100a_64a4, 0x1d)) goto l_0x100a_64a4; /* jz 0x100a64a4 */
            ii(0x100a_6487, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_648a, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_648d, 5); calld(0x1008_af28, -0x1_b56a);          /* call 0x1008af28 */
            ii(0x100a_6492, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_6495, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_6498, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100a_649b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_649e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100a_64a1, 3); calld_abs(memd_a32[ds, ebx + 0x38]);    /* call dword [ebx+0x38] */
        l_0x100a_64a4:
            ii(0x100a_64a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_64a6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_64a9, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_64ac, 5); calld(0x1008_afe4, -0x1_b4cd);          /* call 0x1008afe4 */
            ii(0x100a_64b1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_64b4, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_64b9, 5); calld(0x100a_5e27, -0x697);             /* call 0x100a5e27 */
        l_0x100a_64be:
            ii(0x100a_64be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_64c0, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_64c1, 1); popd(edi);                              /* pop edi */
            ii(0x100a_64c2, 1); popd(esi);                              /* pop esi */
            ii(0x100a_64c3, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_64c4, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_64c5, 1); retd(); return;                         /* ret */
        }
    }
}

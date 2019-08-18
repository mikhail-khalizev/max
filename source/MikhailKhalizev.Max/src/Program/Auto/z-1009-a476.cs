using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a476-434085cb")]
        public void Method_1009_a476()
        {
            ii(0x1009_a476, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_a47b, 5); calld(Definitions.sys_check_available_stack_size, 0xc_b8d2); /* call 0x10165d52 */
            ii(0x1009_a480, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a481, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a482, 1); pushd(edx);                             /* push edx */
            ii(0x1009_a483, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a484, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a485, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a486, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a488, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_a48e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_a491, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_a494, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_a497, 5); calld(0x1008_b060, -0xf43c);            /* call 0x1008b060 */
            ii(0x1009_a49c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a49e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a4a1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a4a4, 5); calld(0x1013_ad71, 0xa_08c8);           /* call 0x1013ad71 */
            ii(0x1009_a4a9, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a4ab, 2); if(jzd(0x1009_a4da, 0x2d)) goto l_0x1009_a4da; /* jz 0x1009a4da */
            ii(0x1009_a4ad, 5); calld(0x1008_a79c, -0xfd16);            /* call 0x1008a79c */
            ii(0x1009_a4b2, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_a4b4, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1009_a4b6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a4b9, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a4bc, 5); calld(0x1007_65d0, -0x2_3ef1);          /* call 0x100765d0 */
            ii(0x1009_a4c1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_a4c3, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_a4c8, 5); calld(0x100a_53ac, 0xaedf);             /* call 0x100a53ac */
            ii(0x1009_a4cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a4cf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a4d2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a4d5, 5); calld(0x1007_6630, -0x2_3eaa);          /* call 0x10076630 */
        l_0x1009_a4da:
            ii(0x1009_a4da, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a4dc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a4df, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_a4e2, 5); calld(0x1013_ad71, 0xa_088a);           /* call 0x1013ad71 */
            ii(0x1009_a4e7, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a4e9, 2); if(jzd(0x1009_a508, 0x1d)) goto l_0x1009_a508; /* jz 0x1009a508 */
            ii(0x1009_a4eb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a4ee, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_a4f1, 5); calld(0x1008_af28, -0xf5ce);            /* call 0x1008af28 */
            ii(0x1009_a4f6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_a4f9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_a4fc, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_a4ff, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_a502, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_a505, 3); calld_abs(memd_a32[ds, ebx + 0x38]);    /* call dword [ebx+0x38] */
        l_0x1009_a508:
            ii(0x1009_a508, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a50a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a50d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a510, 5); calld(0x1007_6630, -0x2_3ee5);          /* call 0x10076630 */
            ii(0x1009_a515, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a517, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a51a, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_a51d, 5); calld(0x1008_afe4, -0xf53e);            /* call 0x1008afe4 */
            ii(0x1009_a522, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_a525, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_a52a, 5); calld(0x100a_5e27, 0xb8f8);             /* call 0x100a5e27 */
            ii(0x1009_a52f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a531, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_a534, 5); calld(0x1008_8b7c, -0x1_19bd);          /* call 0x10088b7c */
            ii(0x1009_a539, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a53b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a53c, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a53d, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a53e, 1); popd(edx);                              /* pop edx */
            ii(0x1009_a53f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a540, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a541, 1); retd(); return;                         /* ret */
        }
    }
}

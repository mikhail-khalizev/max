using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f32c5bbb-25ea-4218-8c57-0cff8b9b7f45")]
        public void Method_1009_acf2()
        {
            ii(0x1009_acf2, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1009_acf7, 5); calld(Definitions.sys_check_available_stack_size, 0xc_b056); /* call 0x10165d52 */
            ii(0x1009_acfc, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_acfd, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_acfe, 1); pushd(edx);                             /* push edx */
            ii(0x1009_acff, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ad00, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ad01, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ad02, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ad04, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1009_ad0a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_ad0d, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_ad12, 5); calld(Definitions.sys_new, 0xc_b0e9);   /* call 0x10165e00 */
            ii(0x1009_ad17, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_ad1a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ad1d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_ad20, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_ad24, 2); if(jzd(0x1009_ad49, 0x23)) goto l_0x1009_ad49; /* jz 0x1009ad49 */
            ii(0x1009_ad26, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1009_ad29, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ad2c, 5); calld(0x100a_2d3d, 0x800c);             /* call 0x100a2d3d */
            ii(0x1009_ad31, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_ad33, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_ad36, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_ad39, 5); calld(Definitions.my_ctor_c12, 0xb32e); /* call 0x100a606c */
            ii(0x1009_ad3e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_ad41, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_ad44, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ad47, 2); jmpd(0x1009_ad4f, 0x6); goto l_0x1009_ad4f; /* jmp 0x1009ad4f */
        l_0x1009_ad49:
            ii(0x1009_ad49, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_ad4c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
        l_0x1009_ad4f:
            ii(0x1009_ad4f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_ad52, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_ad55, 5); calld(0x1008_a914, -0x1_0446);          /* call 0x1008a914 */
            ii(0x1009_ad5a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ad5d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ad60, 5); calld(0x1007_6574, -0x2_47f1);          /* call 0x10076574 */
            ii(0x1009_ad65, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1009_ad68, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_ad6b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ad6e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ad71, 5); calld(0x1007_6574, -0x2_4802);          /* call 0x10076574 */
            ii(0x1009_ad76, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1009_ad79, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_ad7c, 5); calld(0x1007_3d48, -0x2_7039);          /* call 0x10073d48 */
            ii(0x1009_ad81, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_ad86, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1009_ad89, 2); if(jnzd(0x1009_ad9f, 0x14)) goto l_0x1009_ad9f; /* jnz 0x1009ad9f */
            ii(0x1009_ad8b, 5); mov(edx, 0x38);                         /* mov edx, 0x38 */
            ii(0x1009_ad90, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_ad93, 5); calld(0x1008_a7dc, -0x1_05bc);          /* call 0x1008a7dc */
            ii(0x1009_ad98, 5); calld(0x100a_63bc, 0xb61f);             /* call 0x100a63bc */
            ii(0x1009_ad9d, 2); jmpd(0x1009_adb1, 0x12); goto l_0x1009_adb1; /* jmp 0x1009adb1 */
        l_0x1009_ad9f:
            ii(0x1009_ad9f, 5); mov(edx, 0x4a);                         /* mov edx, 0x4a */
            ii(0x1009_ada4, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_ada7, 5); calld(0x1008_a7dc, -0x1_05d0);          /* call 0x1008a7dc */
            ii(0x1009_adac, 5); calld(0x100a_63bc, 0xb60b);             /* call 0x100a63bc */
        l_0x1009_adb1:
            ii(0x1009_adb1, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_adb4, 5); calld(0x1008_a838, -0x1_0581);          /* call 0x1008a838 */
            ii(0x1009_adb9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_adbb, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_adc0, 5); calld(0x100a_4d50, 0x9f8b);             /* call 0x100a4d50 */
            ii(0x1009_adc5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_adc7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x1009_adca, 5); calld(0x1008_8cbc, -0x1_2113);          /* call 0x10088cbc */
            ii(0x1009_adcf, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_add1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_add2, 1); popd(edi);                              /* pop edi */
            ii(0x1009_add3, 1); popd(esi);                              /* pop esi */
            ii(0x1009_add4, 1); popd(edx);                              /* pop edx */
            ii(0x1009_add5, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_add6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_add7, 1); retd(); return;                         /* ret */
        }
    }
}

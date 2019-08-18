using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e972bec4-ad35-45bd-a255-f203cd95657e")]
        public void Method_1008_df3e()
        {
            ii(0x1008_df3e, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1008_df43, 5); calld(Definitions.sys_check_available_stack_size, 0xd_7e0a); /* call 0x10165d52 */
            ii(0x1008_df48, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_df49, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_df4a, 1); pushd(edx);                             /* push edx */
            ii(0x1008_df4b, 1); pushd(esi);                             /* push esi */
            ii(0x1008_df4c, 1); pushd(edi);                             /* push edi */
            ii(0x1008_df4d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_df4e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_df50, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_df56, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_df59, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_df5c, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_df5f, 5); calld(0x1008_b060, -0x2f04);            /* call 0x1008b060 */
            ii(0x1008_df64, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_df67, 4); mov(memb_a32[ds, eax + 0x25], 0xb);     /* mov byte [eax+0x25], 0xb */
            ii(0x1008_df6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_df6d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_df70, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_df73, 5); calld(0x1013_ad71, 0xa_cdf9);           /* call 0x1013ad71 */
            ii(0x1008_df78, 2); test(al, al);                           /* test al, al */
            ii(0x1008_df7a, 2); if(jzd(0x1008_df99, 0x1d)) goto l_0x1008_df99; /* jz 0x1008df99 */
            ii(0x1008_df7c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_df7f, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_df82, 5); calld(0x1008_af28, -0x305f);            /* call 0x1008af28 */
            ii(0x1008_df87, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_df8a, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_df8d, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_df90, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_df93, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_df96, 3); calld_abs(memd_a32[ds, ebx + 0x38]);    /* call dword [ebx+0x38] */
        l_0x1008_df99:
            ii(0x1008_df99, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_df9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_df9e, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_dfa1, 5); calld(0x1013_ad71, 0xa_cdcb);           /* call 0x1013ad71 */
            ii(0x1008_dfa6, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dfa8, 2); if(jzd(0x1008_dfbf, 0x15)) goto l_0x1008_dfbf; /* jz 0x1008dfbf */
            ii(0x1008_dfaa, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_dfad, 3); add(edx, 0x1d);                         /* add edx, 0x1d */
            ii(0x1008_dfb0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dfb3, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_dfb6, 5); calld(0x1009_cbc4, 0xec09);             /* call 0x1009cbc4 */
            ii(0x1008_dfbb, 2); test(al, al);                           /* test al, al */
            ii(0x1008_dfbd, 2); if(jnzd(0x1008_dfc1, 0x2)) goto l_0x1008_dfc1; /* jnz 0x1008dfc1 */
        l_0x1008_dfbf:
            ii(0x1008_dfbf, 2); jmpd(0x1008_dfde, 0x1d); goto l_0x1008_dfde; /* jmp 0x1008dfde */
        l_0x1008_dfc1:
            ii(0x1008_dfc1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dfc4, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_dfc7, 5); calld(0x1008_af28, -0x30a4);            /* call 0x1008af28 */
            ii(0x1008_dfcc, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_dfcf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_dfd2, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1008_dfd5, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_dfd8, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_dfdb, 3); calld_abs(memd_a32[ds, ebx + 0x38]);    /* call dword [ebx+0x38] */
        l_0x1008_dfde:
            ii(0x1008_dfde, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dfe0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dfe3, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_dfe6, 5); calld(0x1008_afe4, -0x3007);            /* call 0x1008afe4 */
            ii(0x1008_dfeb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dfed, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dff0, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1008_dff3, 5); calld(0x1008_afe4, -0x3014);            /* call 0x1008afe4 */
            ii(0x1008_dff8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_dffa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_dffd, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x1008_e000, 5); calld(0x1007_6630, -0x1_79d5);          /* call 0x10076630 */
            ii(0x1008_e005, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_e008, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_e00b, 5); calld(0x1008_aef4, -0x311c);            /* call 0x1008aef4 */
            ii(0x1008_e010, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_e012, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_e015, 5); calld(0x1008_ae70, -0x31aa);            /* call 0x1008ae70 */
            ii(0x1008_e01a, 2); jmpd(0x1008_e024, 0x8); goto l_0x1008_e024; /* jmp 0x1008e024 */
        l_0x1008_e01c:
            ii(0x1008_e01c, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_e01f, 5); calld(0x1007_6bf8, -0x1_742c);          /* call 0x10076bf8 */
        l_0x1008_e024:
            ii(0x1008_e024, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e026, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_e029, 5); calld(0x1013_ad71, 0xa_cd43);           /* call 0x1013ad71 */
            ii(0x1008_e02e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_e030, 2); if(jzd(0x1008_e04b, 0x19)) goto l_0x1008_e04b; /* jz 0x1008e04b */
            ii(0x1008_e032, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_e035, 5); calld(0x1008_adc4, -0x3276);            /* call 0x1008adc4 */
            ii(0x1008_e03a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1008_e03d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_e040, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_e043, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_e046, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x1008_e049, 2); jmpd(0x1008_e01c, -0x2f); goto l_0x1008_e01c; /* jmp 0x1008e01c */
        l_0x1008_e04b:
            ii(0x1008_e04b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_e04e, 3); add(eax, 0x2b);                         /* add eax, 0x2b */
            ii(0x1008_e051, 5); calld(0x1013_a6f4, 0xa_c69e);           /* call 0x1013a6f4 */
            ii(0x1008_e056, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_e059, 5); calld(0x1008_e07b, 0x1d);               /* call 0x1008e07b */
            ii(0x1008_e05e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e060, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_e063, 5); calld(0x1008_8bbc, -0x54ac);            /* call 0x10088bbc */
            ii(0x1008_e068, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_e06a, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1008_e06d, 5); calld(0x1008_8b7c, -0x54f6);            /* call 0x10088b7c */
            ii(0x1008_e072, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_e074, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_e075, 1); popd(edi);                              /* pop edi */
            ii(0x1008_e076, 1); popd(esi);                              /* pop esi */
            ii(0x1008_e077, 1); popd(edx);                              /* pop edx */
            ii(0x1008_e078, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_e079, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_e07a, 1); retd(); return;                         /* ret */
        }
    }
}

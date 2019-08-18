using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c1a75ef5-f595-4369-8e9c-501d4a802697")]
        public void Method_1011_de3c()
        {
            ii(0x1011_de3c, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1011_de41, 5); calld(Definitions.sys_check_available_stack_size, 0x4_7f0c); /* call 0x10165d52 */
            ii(0x1011_de46, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_de47, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_de48, 1); pushd(esi);                             /* push esi */
            ii(0x1011_de49, 1); pushd(edi);                             /* push edi */
            ii(0x1011_de4a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_de4b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_de4d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_de53, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_de56, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_de59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_de5c, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1011_de5f, 5); calld(0x1012_0894, 0x2a30);             /* call 0x10120894 */
            ii(0x1011_de64, 3); lea(ebx, ebp - 0xc);                    /* lea ebx, [ebp-0xc] */
            ii(0x1011_de67, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1011_de69, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1011_de6b, 5); calld(0x1012_0748, 0x28d8);             /* call 0x10120748 */
            ii(0x1011_de70, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1011_de77, 2); jmpd(0x1011_de81, 0x8); goto l_0x1011_de81; /* jmp 0x1011de81 */
        l_0x1011_de79:
            ii(0x1011_de79, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_de7c, 5); calld(0x1007_6bf8, -0xa_7289);          /* call 0x10076bf8 */
        l_0x1011_de81:
            ii(0x1011_de81, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_de83, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_de86, 5); calld(0x1013_ad71, 0x1_cee6);           /* call 0x1013ad71 */
            ii(0x1011_de8b, 2); test(al, al);                           /* test al, al */
            ii(0x1011_de8d, 2); if(jzd(0x1011_dec4, 0x35)) goto l_0x1011_dec4; /* jz 0x1011dec4 */
            ii(0x1011_de8f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_de92, 5); calld(0x1012_066c, 0x27d5);             /* call 0x1012066c */
            ii(0x1011_de97, 5); calld(Definitions.my__get_unit, -0x6_5e80); /* call 0x100b801c */
            ii(0x1011_de9c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_de9e, 2); if(jzd(0x1011_deba, 0x1a)) goto l_0x1011_deba; /* jz 0x1011deba */
            ii(0x1011_dea0, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_dea3, 5); calld(0x1012_066c, 0x27c4);             /* call 0x1012066c */
            ii(0x1011_dea8, 5); calld(Definitions.my__get_unit, -0x6_5e91); /* call 0x100b801c */
            ii(0x1011_dead, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_deaf, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1011_deb2, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_deb6, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_deb8, 2); if(jzd(0x1011_debc, 0x2)) goto l_0x1011_debc; /* jz 0x1011debc */
        l_0x1011_deba:
            ii(0x1011_deba, 2); jmpd(0x1011_dec2, 0x6); goto l_0x1011_dec2; /* jmp 0x1011dec2 */
        l_0x1011_debc:
            ii(0x1011_debc, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_debf, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1011_dec2:
            ii(0x1011_dec2, 2); jmpd(0x1011_de79, -0x4b); goto l_0x1011_de79; /* jmp 0x1011de79 */
        l_0x1011_dec4:
            ii(0x1011_dec4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_dec6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_dec9, 5); calld(0x1013_ad71, 0x1_cea3);           /* call 0x1013ad71 */
            ii(0x1011_dece, 2); test(al, al);                           /* test al, al */
            ii(0x1011_ded0, 2); if(jzd(0x1011_dee3, 0x11)) goto l_0x1011_dee3; /* jz 0x1011dee3 */
            ii(0x1011_ded2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_ded5, 5); calld(0x100b_7f18, -0x6_5fc2);          /* call 0x100b7f18 */
            ii(0x1011_deda, 5); calld(Definitions.my__get_unit, -0x6_5ec3); /* call 0x100b801c */
            ii(0x1011_dedf, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_dee1, 2); if(jnzd(0x1011_dee5, 0x2)) goto l_0x1011_dee5; /* jnz 0x1011dee5 */
        l_0x1011_dee3:
            ii(0x1011_dee3, 2); jmpd(0x1011_deff, 0x1a); goto l_0x1011_deff; /* jmp 0x1011deff */
        l_0x1011_dee5:
            ii(0x1011_dee5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_dee8, 5); calld(0x100b_7f18, -0x6_5fd5);          /* call 0x100b7f18 */
            ii(0x1011_deed, 5); calld(Definitions.my__get_unit, -0x6_5ed6); /* call 0x100b801c */
            ii(0x1011_def2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_def4, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1011_def7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_defb, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1011_defd, 2); if(jzd(0x1011_df01, 0x2)) goto l_0x1011_df01; /* jz 0x1011df01 */
        l_0x1011_deff:
            ii(0x1011_deff, 2); jmpd(0x1011_df07, 0x6); goto l_0x1011_df07; /* jmp 0x1011df07 */
        l_0x1011_df01:
            ii(0x1011_df01, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_df04, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1011_df07:
            ii(0x1011_df07, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_df0a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_df0d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_df0f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1011_df12, 5); calld(0x1012_0464, 0x254d);             /* call 0x10120464 */
            ii(0x1011_df17, 2); jmpd(0x1011_df23, 0xa); goto l_0x1011_df23; /* jmp 0x1011df23 */
        //    ii(0x1011_df19, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x1011_df1b, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
        //    ii(0x1011_df1e, 5); calld(0x1012_0464, 0x2541);             /* call 0x10120464 */
        l_0x1011_df23:
            ii(0x1011_df23, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1011_df26, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_df28, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_df29, 1); popd(edi);                              /* pop edi */
            ii(0x1011_df2a, 1); popd(esi);                              /* pop esi */
            ii(0x1011_df2b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_df2c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_df2d, 1); retd(); return;                         /* ret */
        }
    }
}

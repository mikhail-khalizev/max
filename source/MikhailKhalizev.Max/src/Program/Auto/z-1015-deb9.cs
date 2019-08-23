using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_deb9-7279455")]
        public void Method_1015_deb9()
        {
            ii(0x1015_deb9, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_debe, 5); calld(Definitions.sys_check_available_stack_size, 0x7e8f); /* call 0x10165d52 */
            ii(0x1015_dec3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_dec4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_dec5, 1); pushd(edx);                             /* push edx */
            ii(0x1015_dec6, 1); pushd(esi);                             /* push esi */
            ii(0x1015_dec7, 1); pushd(edi);                             /* push edi */
            ii(0x1015_dec8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_dec9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_decb, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_ded1, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1015_ded6, 5); calld(0x1007_6338, -0xe_7ba3);          /* call 0x10076338 */
            ii(0x1015_dedb, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1015_dede, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_dee0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_dee2, 5); calld(0x1007_64b8, -0xe_7a2f);          /* call 0x100764b8 */
            ii(0x1015_dee7, 2); jmpd(0x1015_def1, 0x8); goto l_0x1015_def1; /* jmp 0x1015def1 */
        l_0x1015_dee9:
            ii(0x1015_dee9, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_deec, 5); calld(0x1007_6bf8, -0xe_72f9);          /* call 0x10076bf8 */
        l_0x1015_def1:
            ii(0x1015_def1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_def3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_def6, 5); calld(0x1013_ad71, -0x2_318a);          /* call 0x1013ad71 */
            ii(0x1015_defb, 2); test(al, al);                           /* test al, al */
            ii(0x1015_defd, 2); if(jzd(0x1015_df22, 0x23)) goto l_0x1015_df22; /* jz 0x1015df22 */
            ii(0x1015_deff, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df02, 5); calld(0x1007_63a0, -0xe_7b67);          /* call 0x100763a0 */
            ii(0x1015_df07, 4); cmp(memb_a32[ds, eax + 0x3d], 0x3);     /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1015_df0b, 2); if(jnzd(0x1015_df20, 0x13)) goto l_0x1015_df20; /* jnz 0x1015df20 */
            ii(0x1015_df0d, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_df11, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_df13, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df16, 5); calld(0x1007_5f6c, -0xe_7faf);          /* call 0x10075f6c */
            ii(0x1015_df1b, 5); jmpd(0x1015_dfdb, 0xbb); goto l_0x1015_dfdb; /* jmp 0x1015dfdb */
        l_0x1015_df20:
            ii(0x1015_df20, 2); jmpd(0x1015_dee9, -0x39); goto l_0x1015_dee9; /* jmp 0x1015dee9 */
        l_0x1015_df22:
            ii(0x1015_df22, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1015_df27, 5); calld(0x1007_6338, -0xe_7bf4);          /* call 0x10076338 */
            ii(0x1015_df2c, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1015_df2f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_df31, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_df33, 5); calld(0x1007_643c, -0xe_7afc);          /* call 0x1007643c */
            ii(0x1015_df38, 2); jmpd(0x1015_df42, 0x8); goto l_0x1015_df42; /* jmp 0x1015df42 */
        l_0x1015_df3a:
            ii(0x1015_df3a, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df3d, 5); calld(0x1007_6bf8, -0xe_734a);          /* call 0x10076bf8 */
        l_0x1015_df42:
            ii(0x1015_df42, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_df44, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df47, 5); calld(0x1013_ad71, -0x2_31db);          /* call 0x1013ad71 */
            ii(0x1015_df4c, 2); test(al, al);                           /* test al, al */
            ii(0x1015_df4e, 2); if(jzd(0x1015_df73, 0x23)) goto l_0x1015_df73; /* jz 0x1015df73 */
            ii(0x1015_df50, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df53, 5); calld(0x1007_63a0, -0xe_7bb8);          /* call 0x100763a0 */
            ii(0x1015_df58, 4); cmp(memb_a32[ds, eax + 0x3d], 0x3);     /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1015_df5c, 2); if(jnzd(0x1015_df71, 0x13)) goto l_0x1015_df71; /* jnz 0x1015df71 */
            ii(0x1015_df5e, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_df62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_df64, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df67, 5); calld(0x1007_5f6c, -0xe_8000);          /* call 0x10075f6c */
            ii(0x1015_df6c, 5); jmpd(0x1015_dfdb, 0x6a); goto l_0x1015_dfdb; /* jmp 0x1015dfdb */
        l_0x1015_df71:
            ii(0x1015_df71, 2); jmpd(0x1015_df3a, -0x39); goto l_0x1015_df3a; /* jmp 0x1015df3a */
        l_0x1015_df73:
            ii(0x1015_df73, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1015_df78, 5); calld(0x1007_6338, -0xe_7c45);          /* call 0x10076338 */
            ii(0x1015_df7d, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1015_df80, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_df82, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1015_df84, 5); calld(0x1007_643c, -0xe_7b4d);          /* call 0x1007643c */
            ii(0x1015_df89, 2); jmpd(0x1015_df93, 0x8); goto l_0x1015_df93; /* jmp 0x1015df93 */
        l_0x1015_df8b:
            ii(0x1015_df8b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df8e, 5); calld(0x1007_6bf8, -0xe_739b);          /* call 0x10076bf8 */
        l_0x1015_df93:
            ii(0x1015_df93, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_df95, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_df98, 5); calld(0x1013_ad71, -0x2_322c);          /* call 0x1013ad71 */
            ii(0x1015_df9d, 2); test(al, al);                           /* test al, al */
            ii(0x1015_df9f, 2); if(jzd(0x1015_dfc1, 0x20)) goto l_0x1015_dfc1; /* jz 0x1015dfc1 */
            ii(0x1015_dfa1, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_dfa4, 5); calld(0x1007_63a0, -0xe_7c09);          /* call 0x100763a0 */
            ii(0x1015_dfa9, 4); cmp(memb_a32[ds, eax + 0x3d], 0x3);     /* cmp byte [eax+0x3d], 0x3 */
            ii(0x1015_dfad, 2); if(jnzd(0x1015_dfbf, 0x10)) goto l_0x1015_dfbf; /* jnz 0x1015dfbf */
            ii(0x1015_dfaf, 4); mov(memb_a32[ss, ebp - 0x4], 0x1);      /* mov byte [ebp-0x4], 0x1 */
            ii(0x1015_dfb3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dfb5, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_dfb8, 5); calld(0x1007_5f6c, -0xe_8051);          /* call 0x10075f6c */
            ii(0x1015_dfbd, 2); jmpd(0x1015_dfdb, 0x1c); goto l_0x1015_dfdb; /* jmp 0x1015dfdb */
        l_0x1015_dfbf:
            ii(0x1015_dfbf, 2); jmpd(0x1015_df8b, -0x36); goto l_0x1015_df8b; /* jmp 0x1015df8b */
        l_0x1015_dfc1:
            ii(0x1015_dfc1, 4); mov(memb_a32[ss, ebp - 0x4], 0);        /* mov byte [ebp-0x4], 0x0 */
            ii(0x1015_dfc5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_dfc7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_dfca, 5); calld(0x1007_5f6c, -0xe_8063);          /* call 0x10075f6c */
            ii(0x1015_dfcf, 2); jmpd(0x1015_dfdb, 0xa); goto l_0x1015_dfdb; /* jmp 0x1015dfdb */
        //  ii(0x1015_dfd1, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1015_dfd3, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
        //  ii(0x1015_dfd6, 5); calld(0x1007_5f6c, -0xe_806f);          /* call 0x10075f6c */
        l_0x1015_dfdb:
            ii(0x1015_dfdb, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x1015_dfde, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_dfe0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_dfe1, 1); popd(edi);                              /* pop edi */
            ii(0x1015_dfe2, 1); popd(esi);                              /* pop esi */
            ii(0x1015_dfe3, 1); popd(edx);                              /* pop edx */
            ii(0x1015_dfe4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_dfe5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_dfe6, 1); retd();                                 /* ret */
        }
    }
}

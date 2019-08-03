using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a46be9d8-eb1d-4363-bff0-56f9315fa6e0")]
        public void Method_100b_dec7()
        {
            ii(0x100b_dec7, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x100b_decc, 5); calld(Definitions.sys_check_available_stack_size, 0xa7e81); /* call 0x10165d52 */
            ii(0x100b_ded1, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_ded2, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_ded3, 1); pushd(edx);                             /* push edx */
            ii(0x100b_ded4, 1); pushd(esi);                             /* push esi */
            ii(0x100b_ded5, 1); pushd(edi);                             /* push edi */
            ii(0x100b_ded6, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_ded7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_ded9, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100b_dedf, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_dee2, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_dee6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_dee9, 5); calld(0x1007_64fc, -0x479f2);           /* call 0x100764fc */
            ii(0x100b_deee, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_def1, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_def5, 5); mov(eax, memd_a32[ds, 0x101c_31be]);    /* mov eax, [0x101c31be] */
            ii(0x100b_defa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_defd, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_df00, 2); if(jnzd(0x100b_df15, 0x13)) goto l_0x100b_df15; /* jnz 0x100bdf15 */
            ii(0x100b_df02, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_df06, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_df08, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_df0b, 5); calld(0x1007_5f6c, -0x47fa4);           /* call 0x10075f6c */
            ii(0x100b_df10, 5); jmpd(0x100b_e088, 0x173); goto l_0x100b_e088; /* jmp 0x100be088 */
        l_0x100b_df15:
            ii(0x100b_df15, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100b_df1a, 5); calld(0x1007_6338, -0x47be7);           /* call 0x10076338 */
            ii(0x100b_df1f, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100b_df22, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_df24, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_df26, 5); calld(0x1007_643c, -0x47aef);           /* call 0x1007643c */
            ii(0x100b_df2b, 2); jmpd(0x100b_df35, 0x8); goto l_0x100b_df35; /* jmp 0x100bdf35 */
        l_0x100b_df2d:
            ii(0x100b_df2d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_df30, 5); calld(0x1007_6bf8, -0x4733d);           /* call 0x10076bf8 */
        l_0x100b_df35:
            ii(0x100b_df35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_df37, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_df3a, 5); calld(0x1013_ad71, 0x7ce32);            /* call 0x1013ad71 */
            ii(0x100b_df3f, 2); test(al, al);                           /* test al, al */
            ii(0x100b_df41, 2); if(jzd(0x100b_df89, 0x46)) goto l_0x100b_df89; /* jz 0x100bdf89 */
            ii(0x100b_df43, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_df46, 5); calld(0x1007_63a0, -0x47bab);           /* call 0x100763a0 */
            ii(0x100b_df4b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_df4d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_df50, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_df53, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_df56, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_df58, 2); if(jnzd(0x100b_df87, 0x2d)) goto l_0x100b_df87; /* jnz 0x100bdf87 */
            ii(0x100b_df5a, 5); calld(0x1008_9aac, -0x344b3);           /* call 0x10089aac */
            ii(0x100b_df5f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_df61, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_df63, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_df66, 5); calld(0x1007_63d4, -0x47b97);           /* call 0x100763d4 */
            ii(0x100b_df6b, 5); calld(0x1007_8840, -0x45730);           /* call 0x10078840 */
            ii(0x100b_df70, 2); test(al, al);                           /* test al, al */
            ii(0x100b_df72, 2); if(jzd(0x100b_df87, 0x13)) goto l_0x100b_df87; /* jz 0x100bdf87 */
            ii(0x100b_df74, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_df78, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_df7a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_df7d, 5); calld(0x1007_5f6c, -0x48016);           /* call 0x10075f6c */
            ii(0x100b_df82, 5); jmpd(0x100b_e088, 0x101); goto l_0x100b_e088; /* jmp 0x100be088 */
        l_0x100b_df87:
            ii(0x100b_df87, 2); jmpd(0x100b_df2d, -0x5c); goto l_0x100b_df2d; /* jmp 0x100bdf2d */
        l_0x100b_df89:
            ii(0x100b_df89, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100b_df8e, 5); calld(0x1007_6338, -0x47c5b);           /* call 0x10076338 */
            ii(0x100b_df93, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100b_df96, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_df98, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_df9a, 5); calld(0x1007_643c, -0x47b63);           /* call 0x1007643c */
            ii(0x100b_df9f, 2); jmpd(0x100b_dfa9, 0x8); goto l_0x100b_dfa9; /* jmp 0x100bdfa9 */
        l_0x100b_dfa1:
            ii(0x100b_dfa1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_dfa4, 5); calld(0x1007_6bf8, -0x473b1);           /* call 0x10076bf8 */
        l_0x100b_dfa9:
            ii(0x100b_dfa9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dfab, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_dfae, 5); calld(0x1013_ad71, 0x7cdbe);            /* call 0x1013ad71 */
            ii(0x100b_dfb3, 2); test(al, al);                           /* test al, al */
            ii(0x100b_dfb5, 2); if(jzd(0x100b_dffd, 0x46)) goto l_0x100b_dffd; /* jz 0x100bdffd */
            ii(0x100b_dfb7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_dfba, 5); calld(0x1007_63a0, -0x47c1f);           /* call 0x100763a0 */
            ii(0x100b_dfbf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dfc1, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_dfc4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_dfc7, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_dfca, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_dfcc, 2); if(jnzd(0x100b_dffb, 0x2d)) goto l_0x100b_dffb; /* jnz 0x100bdffb */
            ii(0x100b_dfce, 5); calld(0x1008_9aac, -0x34527);           /* call 0x10089aac */
            ii(0x100b_dfd3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dfd5, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_dfd7, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_dfda, 5); calld(0x1007_63d4, -0x47c0b);           /* call 0x100763d4 */
            ii(0x100b_dfdf, 5); calld(0x1007_8840, -0x457a4);           /* call 0x10078840 */
            ii(0x100b_dfe4, 2); test(al, al);                           /* test al, al */
            ii(0x100b_dfe6, 2); if(jzd(0x100b_dffb, 0x13)) goto l_0x100b_dffb; /* jz 0x100bdffb */
            ii(0x100b_dfe8, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_dfec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_dfee, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_dff1, 5); calld(0x1007_5f6c, -0x4808a);           /* call 0x10075f6c */
            ii(0x100b_dff6, 5); jmpd(0x100b_e088, 0x8d); goto l_0x100b_e088; /* jmp 0x100be088 */
        l_0x100b_dffb:
            ii(0x100b_dffb, 2); jmpd(0x100b_dfa1, -0x5c); goto l_0x100b_dfa1; /* jmp 0x100bdfa1 */
        l_0x100b_dffd:
            ii(0x100b_dffd, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100b_e002, 5); calld(0x1007_6338, -0x47ccf);           /* call 0x10076338 */
            ii(0x100b_e007, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100b_e00a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_e00c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100b_e00e, 5); calld(0x1007_643c, -0x47bd7);           /* call 0x1007643c */
            ii(0x100b_e013, 2); jmpd(0x100b_e01d, 0x8); goto l_0x100b_e01d; /* jmp 0x100be01d */
        l_0x100b_e015:
            ii(0x100b_e015, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_e018, 5); calld(0x1007_6bf8, -0x47425);           /* call 0x10076bf8 */
        l_0x100b_e01d:
            ii(0x100b_e01d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e01f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_e022, 5); calld(0x1013_ad71, 0x7cd4a);            /* call 0x1013ad71 */
            ii(0x100b_e027, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e029, 2); if(jzd(0x100b_e06e, 0x43)) goto l_0x100b_e06e; /* jz 0x100be06e */
            ii(0x100b_e02b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_e02e, 5); calld(0x1007_63a0, -0x47c93);           /* call 0x100763a0 */
            ii(0x100b_e033, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e035, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100b_e038, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_e03b, 3); movsx(eax, memw_a32[ds, eax]);          /* movsx eax, word [eax] */
            ii(0x100b_e03e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100b_e040, 2); if(jnzd(0x100b_e06c, 0x2a)) goto l_0x100b_e06c; /* jnz 0x100be06c */
            ii(0x100b_e042, 5); calld(0x1008_9aac, -0x3459b);           /* call 0x10089aac */
            ii(0x100b_e047, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e049, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100b_e04b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_e04e, 5); calld(0x1007_63d4, -0x47c7f);           /* call 0x100763d4 */
            ii(0x100b_e053, 5); calld(0x1007_8840, -0x45818);           /* call 0x10078840 */
            ii(0x100b_e058, 2); test(al, al);                           /* test al, al */
            ii(0x100b_e05a, 2); if(jzd(0x100b_e06c, 0x10)) goto l_0x100b_e06c; /* jz 0x100be06c */
            ii(0x100b_e05c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_e060, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e062, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_e065, 5); calld(0x1007_5f6c, -0x480fe);           /* call 0x10075f6c */
            ii(0x100b_e06a, 2); jmpd(0x100b_e088, 0x1c); goto l_0x100b_e088; /* jmp 0x100be088 */
        l_0x100b_e06c:
            ii(0x100b_e06c, 2); jmpd(0x100b_e015, -0x59); goto l_0x100b_e015; /* jmp 0x100be015 */
        l_0x100b_e06e:
            ii(0x100b_e06e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100b_e072, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_e074, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_e077, 5); calld(0x1007_5f6c, -0x48110);           /* call 0x10075f6c */
            ii(0x100b_e07c, 2); jmpd(0x100b_e088, 0xa); goto l_0x100b_e088; /* jmp 0x100be088 */
        //  ii(0x100b_e07e, 10); Недостижимый код.
l_0x100b_e088:
            ii(0x100b_e088, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100b_e08b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_e08d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_e08e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_e08f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_e090, 1); popd(edx);                              /* pop edx */
            ii(0x100b_e091, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_e092, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_e093, 1); retd(); return;                         /* ret */
        }
    }
}
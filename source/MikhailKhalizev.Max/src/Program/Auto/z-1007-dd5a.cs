using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bb36a32b-59fb-4c92-9ce6-2629dd66d6cf")]
        public void Method_1007_dd5a()
        {
            ii(0x1007_dd5a, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1007_dd5f, 5); calld(Definitions.sys_check_available_stack_size, 0xe_7fee); /* call 0x10165d52 */
            ii(0x1007_dd64, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_dd65, 1); pushd(esi);                             /* push esi */
            ii(0x1007_dd66, 1); pushd(edi);                             /* push edi */
            ii(0x1007_dd67, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_dd68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_dd6a, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1007_dd70, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_dd73, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_dd76, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1007_dd79, 5); mov(ecx, 0x1900);                       /* mov ecx, 0x1900 */
            ii(0x1007_dd7e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_dd80, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1007_dd84, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dd87, 5); calld(0x100a_26d1, 0x2_4945);           /* call 0x100a26d1 */
            ii(0x1007_dd8c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_dd8f, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_dd92, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_dd95, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dd98, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_dd9b, 5); calld(Definitions.my_ctor_0x101b_56fc, 0xaedc); /* call 0x10088c7c */
            ii(0x1007_dda0, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1007_dda3, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_dda6, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_dda9, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1007_ddac, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_ddaf, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1007_ddb2, 5); calld(Definitions.my_ctor_0x101b_4184, -0x72c7); /* call 0x10076af0 */
            ii(0x1007_ddb7, 3); sub(eax, 0x1d);                         /* sub eax, 0x1d */
            ii(0x1007_ddba, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_ddbd, 5); mov(ebx, 0x101b_3acc);                  /* mov ebx, 0x101b3acc */
            ii(0x1007_ddc2, 5); mov(edx, 0x8);                          /* mov edx, 0x8 */
            ii(0x1007_ddc7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_ddca, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_ddcd, 5); calld(Definitions.sys_call_ctor_arr_v2, 0xe_819e); /* call 0x10165f70 */
            ii(0x1007_ddd2, 3); sub(eax, 0x21);                         /* sub eax, 0x21 */
            ii(0x1007_ddd5, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_ddd8, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1007_dddb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_ddde, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dde1, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_3e20); /* mov dword [eax+0x2], 0x101b3e20 */
            ii(0x1007_dde8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_ddeb, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1007_ddee, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_ddf1, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1007_ddf7, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_ddfc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_ddfe, 5); calld(0x1008_a064, 0xc261);             /* call 0x1008a064 */
            ii(0x1007_de03, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x1007_de06, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1007_de09, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_de0c, 3); add(eax, 0x1d);                         /* add eax, 0x1d */
            ii(0x1007_de0f, 5); calld(0x1008_8b44, 0xad30);             /* call 0x10088b44 */
            ii(0x1007_de14, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_de19, 5); mov(edx, 0x51);                         /* mov edx, 0x51 */
            ii(0x1007_de1e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_de21, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_de24, 5); calld(0x1007_d396, -0xa93);             /* call 0x1007d396 */
            ii(0x1007_de29, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_de2e, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x1007_de33, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_de36, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_de39, 5); calld(0x1007_d396, -0xaa8);             /* call 0x1007d396 */
            ii(0x1007_de3e, 4); cmp(memb_a32[ss, ebp - 0x10], 0x3);     /* cmp byte [ebp-0x10], 0x3 */
            ii(0x1007_de42, 2); if(jzd(0x1007_de4a, 0x6)) goto l_0x1007_de4a; /* jz 0x1007de4a */
            ii(0x1007_de44, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_de48, 2); if(jnzd(0x1007_de4c, 0x2)) goto l_0x1007_de4c; /* jnz 0x1007de4c */
        l_0x1007_de4a:
            ii(0x1007_de4a, 2); jmpd(0x1007_de52, 0x6); goto l_0x1007_de52; /* jmp 0x1007de52 */
        l_0x1007_de4c:
            ii(0x1007_de4c, 4); cmp(memb_a32[ss, ebp - 0x10], 0x5);     /* cmp byte [ebp-0x10], 0x5 */
            ii(0x1007_de50, 2); if(jnzd(0x1007_de54, 0x2)) goto l_0x1007_de54; /* jnz 0x1007de54 */
        l_0x1007_de52:
            ii(0x1007_de52, 2); jmpd(0x1007_de69, 0x15); goto l_0x1007_de69; /* jmp 0x1007de69 */
        l_0x1007_de54:
            ii(0x1007_de54, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1007_de59, 5); mov(edx, 0x33);                         /* mov edx, 0x33 */
            ii(0x1007_de5e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_de61, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_de64, 5); calld(0x1007_d396, -0xad3);             /* call 0x1007d396 */
        l_0x1007_de69:
            ii(0x1007_de69, 4); cmp(memb_a32[ss, ebp - 0x10], 0x9);     /* cmp byte [ebp-0x10], 0x9 */
            ii(0x1007_de6d, 2); if(jnzd(0x1007_de84, 0x15)) goto l_0x1007_de84; /* jnz 0x1007de84 */
            ii(0x1007_de6f, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1007_de74, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x1007_de79, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_de7c, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_de7f, 5); calld(0x1007_d396, -0xaee);             /* call 0x1007d396 */
        l_0x1007_de84:
            ii(0x1007_de84, 4); cmp(memb_a32[ss, ebp - 0x10], 0x6);     /* cmp byte [ebp-0x10], 0x6 */
            ii(0x1007_de88, 2); if(jzd(0x1007_de9f, 0x15)) goto l_0x1007_de9f; /* jz 0x1007de9f */
            ii(0x1007_de8a, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1007_de8f, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x1007_de94, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_de97, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1007_de9a, 5); calld(0x1007_d396, -0xb09);             /* call 0x1007d396 */
        l_0x1007_de9f:
            ii(0x1007_de9f, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_dea4, 5); mov(edx, 0x52);                         /* mov edx, 0x52 */
            ii(0x1007_dea9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_deac, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_deaf, 5); calld(0x1007_d396, -0xb1e);             /* call 0x1007d396 */
            ii(0x1007_deb4, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_deb9, 5); mov(edx, 0x24);                         /* mov edx, 0x24 */
            ii(0x1007_debe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dec1, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_dec4, 5); calld(0x1007_d396, -0xb33);             /* call 0x1007d396 */
            ii(0x1007_dec9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_dece, 5); mov(edx, 0x25);                         /* mov edx, 0x25 */
            ii(0x1007_ded3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_ded6, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_ded9, 5); calld(0x1007_d396, -0xb48);             /* call 0x1007d396 */
            ii(0x1007_dede, 4); cmp(memb_a32[ss, ebp - 0x10], 0x2);     /* cmp byte [ebp-0x10], 0x2 */
            ii(0x1007_dee2, 2); if(jzd(0x1007_def9, 0x15)) goto l_0x1007_def9; /* jz 0x1007def9 */
            ii(0x1007_dee4, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1007_dee9, 5); mov(edx, 0x34);                         /* mov edx, 0x34 */
            ii(0x1007_deee, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_def1, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_def4, 5); calld(0x1007_d396, -0xb63);             /* call 0x1007d396 */
        l_0x1007_def9:
            ii(0x1007_def9, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_defd, 2); if(jzd(0x1007_df05, 0x6)) goto l_0x1007_df05; /* jz 0x1007df05 */
            ii(0x1007_deff, 4); cmp(memb_a32[ss, ebp - 0x10], 0x5);     /* cmp byte [ebp-0x10], 0x5 */
            ii(0x1007_df03, 2); if(jnzd(0x1007_df07, 0x2)) goto l_0x1007_df07; /* jnz 0x1007df07 */
        l_0x1007_df05:
            ii(0x1007_df05, 2); jmpd(0x1007_df31, 0x2a); goto l_0x1007_df31; /* jmp 0x1007df31 */
        l_0x1007_df07:
            ii(0x1007_df07, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x1007_df0c, 5); mov(edx, 0x35);                         /* mov edx, 0x35 */
            ii(0x1007_df11, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df14, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_df17, 5); calld(0x1007_d396, -0xb86);             /* call 0x1007d396 */
            ii(0x1007_df1c, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1007_df21, 5); mov(edx, 0x36);                         /* mov edx, 0x36 */
            ii(0x1007_df26, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df29, 3); add(eax, 0x37);                         /* add eax, 0x37 */
            ii(0x1007_df2c, 5); calld(0x1007_d396, -0xb9b);             /* call 0x1007d396 */
        l_0x1007_df31:
            ii(0x1007_df31, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_df36, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x1007_df3b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df3e, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x1007_df41, 5); calld(0x1007_d396, -0xbb0);             /* call 0x1007d396 */
            ii(0x1007_df46, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_df4a, 2); if(jzd(0x1007_df61, 0x15)) goto l_0x1007_df61; /* jz 0x1007df61 */
            ii(0x1007_df4c, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1007_df51, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x1007_df56, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df59, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x1007_df5c, 5); calld(0x1007_d396, -0xbcb);             /* call 0x1007d396 */
        l_0x1007_df61:
            ii(0x1007_df61, 4); cmp(memb_a32[ss, ebp - 0x10], 0x3);     /* cmp byte [ebp-0x10], 0x3 */
            ii(0x1007_df65, 2); if(jzd(0x1007_df7c, 0x15)) goto l_0x1007_df7c; /* jz 0x1007df7c */
            ii(0x1007_df67, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1007_df6c, 5); mov(edx, 0x37);                         /* mov edx, 0x37 */
            ii(0x1007_df71, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df74, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x1007_df77, 5); calld(0x1007_d396, -0xbe6);             /* call 0x1007d396 */
        l_0x1007_df7c:
            ii(0x1007_df7c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_df81, 5); mov(edx, 0x53);                         /* mov edx, 0x53 */
            ii(0x1007_df86, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df89, 3); add(eax, 0x4d);                         /* add eax, 0x4d */
            ii(0x1007_df8c, 5); calld(0x1007_d396, -0xbfb);             /* call 0x1007d396 */
            ii(0x1007_df91, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1007_df96, 5); mov(edx, 0x45);                         /* mov edx, 0x45 */
            ii(0x1007_df9b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_df9e, 3); add(eax, 0x79);                         /* add eax, 0x79 */
            ii(0x1007_dfa1, 5); calld(0x1007_d396, -0xc10);             /* call 0x1007d396 */
            ii(0x1007_dfa6, 4); cmp(memb_a32[ss, ebp - 0x10], 0x3);     /* cmp byte [ebp-0x10], 0x3 */
            ii(0x1007_dfaa, 2); if(jzd(0x1007_dfb2, 0x6)) goto l_0x1007_dfb2; /* jz 0x1007dfb2 */
            ii(0x1007_dfac, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_dfb0, 2); if(jnzd(0x1007_dfb4, 0x2)) goto l_0x1007_dfb4; /* jnz 0x1007dfb4 */
        l_0x1007_dfb2:
            ii(0x1007_dfb2, 2); jmpd(0x1007_dfba, 0x6); goto l_0x1007_dfba; /* jmp 0x1007dfba */
        l_0x1007_dfb4:
            ii(0x1007_dfb4, 4); cmp(memb_a32[ss, ebp - 0x10], 0x5);     /* cmp byte [ebp-0x10], 0x5 */
            ii(0x1007_dfb8, 2); if(jnzd(0x1007_dfbc, 0x2)) goto l_0x1007_dfbc; /* jnz 0x1007dfbc */
        l_0x1007_dfba:
            ii(0x1007_dfba, 2); jmpd(0x1007_dff0, 0x34); goto l_0x1007_dff0; /* jmp 0x1007dff0 */
        l_0x1007_dfbc:
            ii(0x1007_dfbc, 4); cmp(memb_a32[ss, ebp - 0x10], 0x6);     /* cmp byte [ebp-0x10], 0x6 */
            ii(0x1007_dfc0, 2); if(jzd(0x1007_dfd9, 0x17)) goto l_0x1007_dfd9; /* jz 0x1007dfd9 */
            ii(0x1007_dfc2, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1007_dfc7, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x1007_dfcc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dfcf, 5); add(eax, 0x8f);                         /* add eax, 0x8f */
            ii(0x1007_dfd4, 5); calld(0x1007_d396, -0xc43);             /* call 0x1007d396 */
        l_0x1007_dfd9:
            ii(0x1007_dfd9, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1007_dfde, 5); mov(edx, 0x46);                         /* mov edx, 0x46 */
            ii(0x1007_dfe3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dfe6, 5); add(eax, 0x8f);                         /* add eax, 0x8f */
            ii(0x1007_dfeb, 5); calld(0x1007_d396, -0xc5a);             /* call 0x1007d396 */
        l_0x1007_dff0:
            ii(0x1007_dff0, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_dff5, 5); mov(edx, 0x22);                         /* mov edx, 0x22 */
            ii(0x1007_dffa, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_dffd, 5); add(eax, 0x8f);                         /* add eax, 0x8f */
            ii(0x1007_e002, 5); calld(0x1007_d396, -0xc71);             /* call 0x1007d396 */
            ii(0x1007_e007, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_e00c, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x1007_e011, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e014, 5); add(eax, 0x8f);                         /* add eax, 0x8f */
            ii(0x1007_e019, 5); calld(0x1007_d396, -0xc88);             /* call 0x1007d396 */
            ii(0x1007_e01e, 4); cmp(memb_a32[ss, ebp - 0x10], 0x4);     /* cmp byte [ebp-0x10], 0x4 */
            ii(0x1007_e022, 2); if(jzd(0x1007_e02a, 0x6)) goto l_0x1007_e02a; /* jz 0x1007e02a */
            ii(0x1007_e024, 4); cmp(memb_a32[ss, ebp - 0x10], 0x6);     /* cmp byte [ebp-0x10], 0x6 */
            ii(0x1007_e028, 2); if(jnzd(0x1007_e02c, 0x2)) goto l_0x1007_e02c; /* jnz 0x1007e02c */
        l_0x1007_e02a:
            ii(0x1007_e02a, 2); jmpd(0x1007_e043, 0x17); goto l_0x1007_e043; /* jmp 0x1007e043 */
        l_0x1007_e02c:
            ii(0x1007_e02c, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1007_e031, 5); mov(edx, 0x4d);                         /* mov edx, 0x4d */
            ii(0x1007_e036, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e039, 5); add(eax, 0x8f);                         /* add eax, 0x8f */
            ii(0x1007_e03e, 5); calld(0x1007_d396, -0xcad);             /* call 0x1007d396 */
        l_0x1007_e043:
            ii(0x1007_e043, 5); mov(ebx, 0x14);                         /* mov ebx, 0x14 */
            ii(0x1007_e048, 5); mov(edx, 0x49);                         /* mov edx, 0x49 */
            ii(0x1007_e04d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e050, 5); add(eax, 0xa5);                         /* add eax, 0xa5 */
            ii(0x1007_e055, 5); calld(0x1007_d396, -0xcc4);             /* call 0x1007d396 */
            ii(0x1007_e05a, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_e05f, 5); mov(edx, 0x24);                         /* mov edx, 0x24 */
            ii(0x1007_e064, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e067, 5); add(eax, 0xa5);                         /* add eax, 0xa5 */
            ii(0x1007_e06c, 5); calld(0x1007_d396, -0xcdb);             /* call 0x1007d396 */
            ii(0x1007_e071, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_e076, 5); mov(edx, 0x25);                         /* mov edx, 0x25 */
            ii(0x1007_e07b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e07e, 5); add(eax, 0xa5);                         /* add eax, 0xa5 */
            ii(0x1007_e083, 5); calld(0x1007_d396, -0xcf2);             /* call 0x1007d396 */
            ii(0x1007_e088, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_e08d, 5); mov(edx, 0x23);                         /* mov edx, 0x23 */
            ii(0x1007_e092, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e095, 5); add(eax, 0xbb);                         /* add eax, 0xbb */
            ii(0x1007_e09a, 5); calld(0x1007_d396, -0xd09);             /* call 0x1007d396 */
            ii(0x1007_e09f, 4); cmp(memb_a32[ss, ebp - 0x10], 0x3);     /* cmp byte [ebp-0x10], 0x3 */
            ii(0x1007_e0a3, 2); if(jzd(0x1007_e0bc, 0x17)) goto l_0x1007_e0bc; /* jz 0x1007e0bc */
            ii(0x1007_e0a5, 5); mov(ebx, 0x6);                          /* mov ebx, 0x6 */
            ii(0x1007_e0aa, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x1007_e0af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e0b2, 5); add(eax, 0xbb);                         /* add eax, 0xbb */
            ii(0x1007_e0b7, 5); calld(0x1007_d396, -0xd26);             /* call 0x1007d396 */
        l_0x1007_e0bc:
            ii(0x1007_e0bc, 4); cmp(memb_a32[ss, ebp - 0x10], 0x4);     /* cmp byte [ebp-0x10], 0x4 */
            ii(0x1007_e0c0, 2); if(jzd(0x1007_e0c8, 0x6)) goto l_0x1007_e0c8; /* jz 0x1007e0c8 */
            ii(0x1007_e0c2, 4); cmp(memb_a32[ss, ebp - 0x10], 0x7);     /* cmp byte [ebp-0x10], 0x7 */
            ii(0x1007_e0c6, 2); if(jnzd(0x1007_e0ca, 0x2)) goto l_0x1007_e0ca; /* jnz 0x1007e0ca */
        l_0x1007_e0c8:
            ii(0x1007_e0c8, 2); jmpd(0x1007_e0d0, 0x6); goto l_0x1007_e0d0; /* jmp 0x1007e0d0 */
        l_0x1007_e0ca:
            ii(0x1007_e0ca, 4); cmp(memb_a32[ss, ebp - 0x10], 0x5);     /* cmp byte [ebp-0x10], 0x5 */
            ii(0x1007_e0ce, 2); if(jnzd(0x1007_e0d2, 0x2)) goto l_0x1007_e0d2; /* jnz 0x1007e0d2 */
        l_0x1007_e0d0:
            ii(0x1007_e0d0, 2); jmpd(0x1007_e0e9, 0x17); goto l_0x1007_e0e9; /* jmp 0x1007e0e9 */
        l_0x1007_e0d2:
            ii(0x1007_e0d2, 5); mov(ebx, 0xc);                          /* mov ebx, 0xc */
            ii(0x1007_e0d7, 5); mov(edx, 0x4c);                         /* mov edx, 0x4c */
            ii(0x1007_e0dc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e0df, 5); add(eax, 0xbb);                         /* add eax, 0xbb */
            ii(0x1007_e0e4, 5); calld(0x1007_d396, -0xd53);             /* call 0x1007d396 */
        l_0x1007_e0e9:
            ii(0x1007_e0e9, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1007_e0ee, 5); mov(edx, 0x53);                         /* mov edx, 0x53 */
            ii(0x1007_e0f3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e0f6, 5); add(eax, 0xbb);                         /* add eax, 0xbb */
            ii(0x1007_e0fb, 5); calld(0x1007_d396, -0xd6a);             /* call 0x1007d396 */
            ii(0x1007_e100, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_e103, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_e106, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_e109, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e10b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_e10c, 1); popd(edi);                              /* pop edi */
            ii(0x1007_e10d, 1); popd(esi);                              /* pop esi */
            ii(0x1007_e10e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_e10f, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_deb5-8ba520c5")]
        public void Method_100a_deb5()
        {
            ii(0x100a_deb5, 5); push(0x50);                             /* push 0x50 */
            ii(0x100a_deba, 5); call(Definitions.sys_check_available_stack_size, 0xb_7e93); /* call 0x10165d52 */
            ii(0x100a_debf, 1); push(ebx);                              /* push ebx */
            ii(0x100a_dec0, 1); push(ecx);                              /* push ecx */
            ii(0x100a_dec1, 1); push(esi);                              /* push esi */
            ii(0x100a_dec2, 1); push(edi);                              /* push edi */
            ii(0x100a_dec3, 1); push(ebp);                              /* push ebp */
            ii(0x100a_dec4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_dec6, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100a_decc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_decf, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_ded2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_ded7, 5); call(0x1008_a768, -0x2_3774);           /* call 0x1008a768 */
            ii(0x100a_dedc, 3); lea(ebx, memd[ss, ebp - 0x14]);         /* lea ebx, [ebp-0x14] */
            ii(0x100a_dedf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_dee1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_dee3, 5); call(0x1008_ae70, -0x2_3078);           /* call 0x1008ae70 */
            ii(0x100a_dee8, 7); mov(memd[ss, ebp - 0x18], 0);           /* mov dword [ebp-0x18], 0x0 */
            ii(0x100a_deef, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_def2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_def5, 4); mov(memw[ds, edx + 0x26], ax);          /* mov [edx+0x26], ax */
            ii(0x100a_def9, 2); jmp(0x100a_df03, 0x8); goto l_0x100a_df03; /* jmp 0x100adf03 */
        l_0x100a_defb:
            ii(0x100a_defb, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_defe, 5); call(0x1007_6bf8, -0x3_730b);           /* call 0x10076bf8 */
        l_0x100a_df03:
            ii(0x100a_df03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_df05, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_df08, 5); call(0x1013_ad71, 0x8_ce64);            /* call 0x1013ad71 */
            ii(0x100a_df0d, 2); test(al, al);                           /* test al, al */
            ii(0x100a_df0f, 6); if(jz(0x100a_dfd6, 0xc1)) goto l_0x100a_dfd6; /* jz 0x100adfd6 */
            ii(0x100a_df15, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_df18, 5); call(0x1008_adc4, -0x2_3159);           /* call 0x1008adc4 */
            ii(0x100a_df1d, 5); call(0x1008_ad90, -0x2_3192);           /* call 0x1008ad90 */
            ii(0x100a_df22, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_df24, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_df27, 4); cmp(dx, memw[ds, eax + 0x9]);           /* cmp dx, [eax+0x9] */
            ii(0x100a_df2b, 2); if(jnz(0x100a_df48, 0x1b)) goto l_0x100a_df48; /* jnz 0x100adf48 */
            ii(0x100a_df2d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_df30, 5); call(0x1008_adc4, -0x2_3171);           /* call 0x1008adc4 */
            ii(0x100a_df35, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_df38, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_df3b, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_df3e, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_df41, 3); call_abs(memd[ds, edx + 0x20]);         /* call dword [edx+0x20] */
            ii(0x100a_df44, 2); cmp(al, 0x2d);                          /* cmp al, 0x2d */
            ii(0x100a_df46, 2); if(jz(0x100a_df4d, 0x5)) goto l_0x100a_df4d; /* jz 0x100adf4d */
        l_0x100a_df48:
            ii(0x100a_df48, 5); jmp(0x100a_dfd1, 0x84); goto l_0x100a_dfd1; /* jmp 0x100adfd1 */
        l_0x100a_df4d:
            ii(0x100a_df4d, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_df50, 5); call(0x1008_adf8, -0x2_315d);           /* call 0x1008adf8 */
            ii(0x100a_df55, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x100a_df58, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_df5b, 5); call(0x100b_79e0, 0x9a80);              /* call 0x100b79e0 */
            ii(0x100a_df60, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100a_df64, 2); if(jnz(0x100a_dfd1, 0x6b)) goto l_0x100a_dfd1; /* jnz 0x100adfd1 */
            ii(0x100a_df66, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_df69, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_df6c, 5); call(0x1007_6574, -0x3_79fd);           /* call 0x10076574 */
            ii(0x100a_df71, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x100a_df74, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_df77, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_df7a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_df7d, 5); call(0x1007_6574, -0x3_7a0e);           /* call 0x10076574 */
            ii(0x100a_df82, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x100a_df85, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_df88, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x100a_df8b, 5); call(0x1007_6aac, -0x3_74e4);           /* call 0x10076aac */
            ii(0x100a_df90, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100a_df92, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100a_df95, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_df98, 5); call(0x100a_2d3d, -0xb260);             /* call 0x100a2d3d */
            ii(0x100a_df9d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_df9f, 5); call(0x100a_5fca, -0x7fda);             /* call 0x100a5fca */
            ii(0x100a_dfa4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_dfa7, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100a_dfab, 2); if(jz(0x100a_dfb6, 0x9)) goto l_0x100a_dfb6; /* jz 0x100adfb6 */
            ii(0x100a_dfad, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_dfb0, 4); cmp(ax, memw[ss, ebp - 0xc]);           /* cmp ax, [ebp-0xc] */
            ii(0x100a_dfb4, 2); if(jge(0x100a_dfd1, 0x1b)) goto l_0x100a_dfd1; /* jge 0x100adfd1 */
        l_0x100a_dfb6:
            ii(0x100a_dfb6, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_dfb9, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_dfbc, 5); call(0x100b_1484, 0x34c3);              /* call 0x100b1484 */
            ii(0x100a_dfc1, 2); test(al, al);                           /* test al, al */
            ii(0x100a_dfc3, 2); if(jz(0x100a_dfd1, 0xc)) goto l_0x100a_dfd1; /* jz 0x100adfd1 */
            ii(0x100a_dfc5, 3); mov(eax, memd[ss, ebp - 0x20]);         /* mov eax, [ebp-0x20] */
            ii(0x100a_dfc8, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_dfcb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_dfce, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x100a_dfd1:
            ii(0x100a_dfd1, 5); jmp(0x100a_defb, -0xdb); goto l_0x100a_defb; /* jmp 0x100adefb */
        l_0x100a_dfd6:
            ii(0x100a_dfd6, 4); cmp(memd[ss, ebp - 0x18], 0);           /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100a_dfda, 2); if(jz(0x100a_dfe9, 0xd)) goto l_0x100a_dfe9; /* jz 0x100adfe9 */
            ii(0x100a_dfdc, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_dfdf, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_dfe2, 5); call(0x100b_187b, 0x3894);              /* call 0x100b187b */
            ii(0x100a_dfe7, 2); jmp(0x100a_e03a, 0x51); goto l_0x100a_e03a; /* jmp 0x100ae03a */
        l_0x100a_dfe9:
            ii(0x100a_dfe9, 5); mov(eax, 0x2b);                         /* mov eax, 0x2b */
            ii(0x100a_dfee, 5); call(Definitions.sys_new, 0xb_7e0d);    /* call 0x10165e00 */
            ii(0x100a_dff3, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x100a_dff6, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100a_dff9, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100a_dffc, 4); cmp(memd[ss, ebp - 0x30], 0);           /* cmp dword [ebp-0x30], 0x0 */
            ii(0x100a_e000, 2); if(jz(0x100a_e021, 0x1f)) goto l_0x100a_e021; /* jz 0x100ae021 */
            ii(0x100a_e002, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_e005, 3); mov(ebx, memd[ds, eax + 0x24]);         /* mov ebx, [eax+0x24] */
            ii(0x100a_e008, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_e00b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100a_e00e, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x100a_e011, 5); call(0x100b_074e, 0x2738);              /* call 0x100b074e */
            ii(0x100a_e016, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100a_e019, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100a_e01c, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100a_e01f, 2); jmp(0x100a_e027, 0x6); goto l_0x100a_e027; /* jmp 0x100ae027 */
        l_0x100a_e021:
            ii(0x100a_e021, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100a_e024, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
        l_0x100a_e027:
            ii(0x100a_e027, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100a_e02a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_e02d, 3); mov(edx, memd[ss, ebp - 0x18]);         /* mov edx, [ebp-0x18] */
            ii(0x100a_e030, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_e035, 5); call(0x100a_4d50, -0x92ea);             /* call 0x100a4d50 */
        l_0x100a_e03a:
            ii(0x100a_e03a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e03c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100a_e03f, 5); call(0x1008_8bbc, -0x2_5488);           /* call 0x10088bbc */
            ii(0x100a_e044, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_e046, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_e047, 1); pop(edi);                               /* pop edi */
            ii(0x100a_e048, 1); pop(esi);                               /* pop esi */
            ii(0x100a_e049, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_e04a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_e04b, 1); ret();                                  /* ret */
        }
    }
}

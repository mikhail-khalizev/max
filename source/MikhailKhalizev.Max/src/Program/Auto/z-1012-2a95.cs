using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_2a95-6f8cb82e")]
        public void Method_1012_2a95()
        {
            ii(0x1012_2a95, 5); mov(edx, 0xd);                          /* mov edx, 0xd */
            ii(0x1012_2a9a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2a9d, 5); calld(0x1012_2716, -0x38c);             /* call 0x10122716 */
            ii(0x1012_2aa2, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
            ii(0x1012_2aa9, 2); jmpd(0x1012_2ab1, 0x6); goto l_0x1012_2ab1; /* jmp 0x10122ab1 */
        l_0x1012_2aab:
            ii(0x1012_2aab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_2aae, 3); inc(memd_a32[ss, ebp - 0x10]);          /* inc dword [ebp-0x10] */
        l_0x1012_2ab1:
            ii(0x1012_2ab1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_2ab4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_2ab7, 4); cmp(ax, memw_a32[ds, edx + 0x49]);      /* cmp ax, [edx+0x49] */
            ii(0x1012_2abb, 6); if(jged(0x1012_2c4e, 0x18d)) goto l_0x1012_2c4e; /* jge 0x10122c4e */
            ii(0x1012_2ac1, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2ac5, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2ac8, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_2ace, 3); mov(memb_a32[ss, ebp - 0x20], al);      /* mov [ebp-0x20], al */
            ii(0x1012_2ad1, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2ad5, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2ad8, 6); mov(al, memb_a32[ds, eax + 0x101b_b05c]); /* mov al, [eax+0x101bb05c] */
            ii(0x1012_2ade, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1012_2ae1, 5); jmpd(0x1012_2c2c, 0x146); goto l_0x1012_2c2c; /* jmp 0x10122c2c */
        //  ii(0x1012_2ae6, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
        //  ii(0x1012_2aea, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
        //  ii(0x1012_2aed, 6); mov(edx, memd_a32[ds, edx + 0x101b_b072]); /* mov edx, [edx+0x101bb072] */
        //  ii(0x1012_2af3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
        //  ii(0x1012_2af6, 4); movsx(eax, memb_a32[ss, ebp - 0x20]);   /* movsx eax, byte [ebp-0x20] */
        //  ii(0x1012_2afa, 5); calld(0x100c_aafc, -0x5_8003);          /* call 0x100caafc */
        //  ii(0x1012_2aff, 5); jmpd(0x1012_2c49, 0x145); goto l_0x1012_2c49; /* jmp 0x10122c49 */
        //  ii(0x1012_2b04, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
        //  ii(0x1012_2b08, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
        //  ii(0x1012_2b0b, 6); mov(eax, memd_a32[ds, eax + 0x101b_b070]); /* mov eax, [eax+0x101bb070] */
        //  ii(0x1012_2b11, 5); calld(/* sys */ 0x1017_90ce, 0x5_65b8); /* call 0x101790ce */
        //  ii(0x1012_2b16, 2); mov(edx, eax);                          /* mov edx, eax */
        //  ii(0x1012_2b18, 4); movsx(eax, memb_a32[ss, ebp - 0x20]);   /* movsx eax, byte [ebp-0x20] */
        //  ii(0x1012_2b1c, 5); calld(0x100c_aafc, -0x5_8025);          /* call 0x100caafc */
        //  ii(0x1012_2b21, 5); jmpd(0x1012_2c49, 0x123); goto l_0x1012_2c49; /* jmp 0x10122c49 */
        //  ii(0x1012_2b26, 5); mov(edx, StringDefinitions._0x2);       /* mov edx, 0x101a7f0e */
        //  ii(0x1012_2b2b, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
        //  ii(0x1012_2b2e, 5); calld(Definitions.sys_strcpy, 0x4_339c); /* call 0x10165ecf */
        //  ii(0x1012_2b33, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
        //  ii(0x1012_2b37, 3); imul(edx, edx, 0x1c);                   /* imul edx, edx, 0x1c */
        //  ii(0x1012_2b3a, 6); mov(edx, memd_a32[ds, edx + 0x101b_b070]); /* mov edx, [edx+0x101bb070] */
        //  ii(0x1012_2b40, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
        //  ii(0x1012_2b43, 5); calld(Definitions.sys_strcat, 0x4_33e9); /* call 0x10165f31 */
        //  ii(0x1012_2b48, 3); lea(ebx, ebp - 0x38);                   /* lea ebx, [ebp-0x38] */
        //  ii(0x1012_2b4b, 4); movsx(edx, memb_a32[ss, ebp - 0x20]);   /* movsx edx, byte [ebp-0x20] */
        //  ii(0x1012_2b4f, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
        //  ii(0x1012_2b54, 5); calld(0x1010_6205, -0x1_c954);          /* call 0x10106205 */
        //  ii(0x1012_2b59, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
        //  ii(0x1012_2b5d, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
        //  ii(0x1012_2b60, 6); mov(eax, memd_a32[ds, eax + 0x101b_b070]); /* mov eax, [eax+0x101bb070] */
        //  ii(0x1012_2b66, 5); calld(0x1012_47af, 0x1c44);             /* call 0x101247af */
        //  ii(0x1012_2b6b, 2); mov(edx, eax);                          /* mov edx, eax */
        //  ii(0x1012_2b6d, 4); movsx(eax, memb_a32[ss, ebp - 0x20]);   /* movsx eax, byte [ebp-0x20] */
        //  ii(0x1012_2b71, 5); calld(0x100c_aafc, -0x5_807a);          /* call 0x100caafc */
        //  ii(0x1012_2b76, 5); jmpd(0x1012_2c49, 0xce); goto l_0x1012_2c49; /* jmp 0x10122c49 */
        //  ii(0x1012_2b7b, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
        //  ii(0x1012_2b7f, 3); imul(ebx, ebx, 0x1c);                   /* imul ebx, ebx, 0x1c */
        //  ii(0x1012_2b82, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_b070]); /* mov ebx, [ebx+0x101bb070] */
        //  ii(0x1012_2b88, 4); movsx(edx, memb_a32[ss, ebp - 0x20]);   /* movsx edx, byte [ebp-0x20] */
        //  ii(0x1012_2b8c, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
        //  ii(0x1012_2b91, 5); calld(0x1010_6205, -0x1_c991);          /* call 0x10106205 */
        //  ii(0x1012_2b96, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
        //  ii(0x1012_2b99, 6); cmp(memw_a32[ds, eax + 0x40], 0x6cd);   /* cmp word [eax+0x40], 0x6cd */
        //  ii(0x1012_2b9f, 2); if(jnzd(0x1012_2bde, 0x3d)) goto l_0x1012_2bde; /* jnz 0x10122bde */
        //  ii(0x1012_2ba1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
        //  ii(0x1012_2ba4, 3); mov(al, memb_a32[ds, eax + 0x3e]);      /* mov al, [eax+0x3e] */
        //  ii(0x1012_2ba7, 2); add(al, 0x63);                          /* add al, 0x63 */
        //  ii(0x1012_2ba9, 3); mov(memb_a32[ss, ebp - 0x20], al);      /* mov [ebp-0x20], al */
        //  ii(0x1012_2bac, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
        //  ii(0x1012_2bb0, 3); imul(ebx, ebx, 0x1c);                   /* imul ebx, ebx, 0x1c */
        //  ii(0x1012_2bb3, 6); mov(ebx, memd_a32[ds, ebx + 0x101b_b070]); /* mov ebx, [ebx+0x101bb070] */
        //  ii(0x1012_2bb9, 4); movsx(edx, memb_a32[ss, ebp - 0x20]);   /* movsx edx, byte [ebp-0x20] */
        //  ii(0x1012_2bbd, 5); mov(eax, 0x101c_39c8);                  /* mov eax, 0x101c39c8 */
        //  ii(0x1012_2bc2, 5); calld(0x1010_6205, -0x1_c9c2);          /* call 0x10106205 */
        //  ii(0x1012_2bc7, 7); cmp(memd_a32[ds, 0x101c_5624], 0);      /* cmp dword [0x101c5624], 0x0 */
        //  ii(0x1012_2bce, 2); if(jzd(0x1012_2bde, 0xe)) goto l_0x1012_2bde; /* jz 0x10122bde */
        //  ii(0x1012_2bd0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
        //  ii(0x1012_2bd3, 3); mov(eax, memd_a32[ds, eax + 0x3c]);     /* mov eax, [eax+0x3c] */
        //  ii(0x1012_2bd6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
        //  ii(0x1012_2bd9, 5); calld(0x1012_894c, 0x5d6e);             /* call 0x1012894c */
        l_0x1012_2bde:
            ii(0x1012_2bde, 2); jmpd(0x1012_2c49, 0x69); goto l_0x1012_2c49; /* jmp 0x10122c49 */
        //  ii(0x1012_2be0, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
        //  ii(0x1012_2be4, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
        //  ii(0x1012_2be7, 7); cmp(memd_a32[ds, eax + 0x101b_b068], 0); /* cmp dword [eax+0x101bb068], 0x0 */
        //  ii(0x1012_2bee, 2); if(jzd(0x1012_2c12, 0x22)) goto l_0x1012_2c12; /* jz 0x10122c12 */
        //  ii(0x1012_2bf0, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
        //  ii(0x1012_2bf4, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
        //  ii(0x1012_2bf7, 6); mov(eax, memd_a32[ds, eax + 0x101b_b068]); /* mov eax, [eax+0x101bb068] */
        //  ii(0x1012_2bfd, 5); calld(0x100d_5104, -0x4_dafe);          /* call 0x100d5104 */
        //  ii(0x1012_2c02, 5); calld(/* sys */ 0x1016_8de8, 0x4_61e1); /* call 0x10168de8 */
        //  ii(0x1012_2c07, 2); mov(edx, eax);                          /* mov edx, eax */
        //  ii(0x1012_2c09, 4); movsx(eax, memb_a32[ss, ebp - 0x20]);   /* movsx eax, byte [ebp-0x20] */
        //  ii(0x1012_2c0d, 5); calld(0x100c_aafc, -0x5_8116);          /* call 0x100caafc */
        l_0x1012_2c12:
            ii(0x1012_2c12, 2); jmpd(0x1012_2c49, 0x35); goto l_0x1012_2c49; /* jmp 0x10122c49 */
        l_0x1012_2c14:
            ii(0x1012_2c14, 2); jmpd(0x1012_2c49, 0x33); goto l_0x1012_2c49; /* jmp 0x10122c49 */
        //  ii(0x1012_2c16, 2); mov(eax, eax);                          /* mov eax, eax */
        //  ii(0x1012_2c18, 2); outb(0x2a, al);                         /* out 0x2a, al */
        //  ii(0x1012_2c1a, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        //  ii(0x1012_2c1c, 2); add(al, 0x2b);                          /* add al, 0x2b */
        //  ii(0x1012_2c1e, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        //  ii(0x1012_2c20, 3); sub(edx, memd_a32[es, edx]);            /* sub edx, [es:edx] */
        //  ii(0x1012_2c23, 3); adc(memb_a32[ds, ebx + 0x2b], bh);      /* adc [ebx+0x2b], bh */
        //  ii(0x1012_2c26, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        //  ii(0x1012_2c28, 2); if(loopned_a32_func(0x1012_2c55, 0x2b)) return; /* loopne 0x10122c55 */
        //  ii(0x1012_2c2a, 2); adc(dl, memb_a32[ds, eax]);             /* adc dl, [eax] */
        l_0x1012_2c2c:
            ii(0x1012_2c2c, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x1012_2c2f, 2); dec(al);                                /* dec al */
            ii(0x1012_2c31, 3); mov(memb_a32[ss, ebp - 0x3c], al);      /* mov [ebp-0x3c], al */
            ii(0x1012_2c34, 4); cmp(memb_a32[ss, ebp - 0x3c], 0x4);     /* cmp byte [ebp-0x3c], 0x4 */
            ii(0x1012_2c38, 2); if(jad(0x1012_2c14, -0x26)) goto l_0x1012_2c14; /* ja 0x10122c14 */
            ii(0x1012_2c3a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_2c3c, 3); mov(al, memb_a32[ss, ebp - 0x3c]);      /* mov al, [ebp-0x3c] */
            ii(0x1012_2c3f, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_2c42, 7); if(jmpd_abs(memd_a32[cs, eax + 0x1012_2c18])) return; /* jmp dword [cs:eax+0x10122c18] */
        l_0x1012_2c49:
            ii(0x1012_2c49, 5); jmpd(0x1012_2aab, -0x1a3); goto l_0x1012_2aab; /* jmp 0x10122aab */
        l_0x1012_2c4e:
            ii(0x1012_2c4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
        }
    }
}

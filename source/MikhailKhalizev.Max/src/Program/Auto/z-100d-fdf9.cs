using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fcc19c21-417f-4b4c-86dd-899c9d6688fa")]
        public void Method_100d_fdf9()
        {
            ii(0x100d_fdf9, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100d_fdfe, 5); calld(Definitions.sys_check_available_stack_size, 0x85f4f); /* call 0x10165d52 */
            ii(0x100d_fe03, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_fe04, 1); pushd(esi);                             /* push esi */
            ii(0x100d_fe05, 1); pushd(edi);                             /* push edi */
            ii(0x100d_fe06, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_fe07, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_fe09, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100d_fe0f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_fe12, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100d_fe15, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100d_fe18, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_fe1c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_fe20, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100d_fe26, 6); mov(ebx, memd_a32[ds, edx + 0x101c_a562]); /* mov ebx, [edx+0x101ca562] */
            ii(0x100d_fe2c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fe2e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_fe30, 5); calld(0x100c_b6b0, -0x14785);           /* call 0x100cb6b0 */
            ii(0x100d_fe35, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100d_fe38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fe3a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_fe3c, 5); calld(0x1007_6800, -0x69641);           /* call 0x10076800 */
            ii(0x100d_fe41, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fe45, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe49, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_fe4f, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100d_fe55, 5); calld(0x1008_b104, -0x54d56);           /* call 0x1008b104 */
            ii(0x100d_fe5a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fe5c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_fe5f, 5); calld(0x1007_6800, -0x69664);           /* call 0x10076800 */
            ii(0x100d_fe64, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x100d_fe68, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fe6c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe70, 5); calld(0x100d_fd69, -0x10c);             /* call 0x100dfd69 */
            ii(0x100d_fe75, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_fe78, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_fe7b, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100d_fe7e, 5); jmpd(0x100d_ff58, 0xd5); goto l_0x100d_ff58; /* jmp 0x100dff58 */
        //  ii(0x100d_fe83, 171); Недостижимый код.
l_0x100d_ff2e:
            ii(0x100d_ff2e, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
            ii(0x100d_ff35, 2); jmpd(0x100d_ff75, 0x3e); goto l_0x100d_ff75; /* jmp 0x100dff75 */
        //  ii(0x100d_ff37, 33); Недостижимый код.
l_0x100d_ff58:
            ii(0x100d_ff58, 3); mov(al, memb_a32[ss, ebp - 0x10]);      /* mov al, [ebp-0x10] */
            ii(0x100d_ff5b, 2); dec(al);                                /* dec al */
            ii(0x100d_ff5d, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x100d_ff60, 4); cmp(memb_a32[ss, ebp - 0x24], 0x7);     /* cmp byte [ebp-0x24], 0x7 */
            ii(0x100d_ff64, 2); if(jad(0x100d_ff2e, -0x38)) goto l_0x100d_ff2e; /* ja 0x100dff2e */
            ii(0x100d_ff66, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100d_ff68, 3); mov(al, memb_a32[ss, ebp - 0x24]);      /* mov al, [ebp-0x24] */
            ii(0x100d_ff6b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_ff6e, 7); jmpd_abs(memd_a32[cs, eax + 0x100d_ff38]); return; /* jmp dword [cs:eax+0x100dff38] */
        l_0x100d_ff75:
            ii(0x100d_ff75, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ff79, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_ff7c, 5); calld(0x1007_6730, -0x69851);           /* call 0x10076730 */
            ii(0x100d_ff81, 5); calld(0x1016_3b41, 0x83bbb);            /* call 0x10163b41 */
            ii(0x100d_ff86, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_ff89, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_ff8c, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ff90, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_ff93, 5); calld(0x1007_6730, -0x69868);           /* call 0x10076730 */
            ii(0x100d_ff98, 5); calld(0x1016_3b41, 0x83ba4);            /* call 0x10163b41 */
            ii(0x100d_ff9d, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_ffa0, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_ffa3, 4); movsx(ecx, memw_a32[ss, ebp - 0x28]);   /* movsx ecx, word [ebp-0x28] */
            ii(0x100d_ffa7, 4); movsx(ebx, memw_a32[ss, ebp - 0x20]);   /* movsx ebx, word [ebp-0x20] */
            ii(0x100d_ffab, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x100d_ffaf, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_ffb3, 5); calld(0x100d_8248, -0x7d70);            /* call 0x100d8248 */
            ii(0x100d_ffb8, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_ffbb, 4); cmp(memb_a32[ss, ebp - 0x4], 0x9);      /* cmp byte [ebp-0x4], 0x9 */
            ii(0x100d_ffbf, 2); if(jnzd(0x100d_ffc9, 0x8)) goto l_0x100d_ffc9; /* jnz 0x100dffc9 */
            ii(0x100d_ffc1, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_ffc4, 3); sub(memd_a32[ss, ebp - 0x2c], eax);     /* sub [ebp-0x2c], eax */
            ii(0x100d_ffc7, 2); jmpd(0x100d_ffcf, 0x6); goto l_0x100d_ffcf; /* jmp 0x100dffcf */
        l_0x100d_ffc9:
            ii(0x100d_ffc9, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_ffcc, 3); add(memd_a32[ss, ebp - 0x2c], eax);     /* add [ebp-0x2c], eax */
        l_0x100d_ffcf:
            ii(0x100d_ffcf, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ffd3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_ffd6, 5); calld(0x1007_6730, -0x698ab);           /* call 0x10076730 */
            ii(0x100d_ffdb, 5); calld(0x1016_3b41, 0x83b61);            /* call 0x10163b41 */
            ii(0x100d_ffe0, 3); movsx(ecx, memw_a32[ds, eax]);          /* movsx ecx, word [eax] */
            ii(0x100d_ffe3, 4); movsx(ebx, memw_a32[ss, ebp - 0x20]);   /* movsx ebx, word [ebp-0x20] */
            ii(0x100d_ffe7, 4); movsx(edx, memw_a32[ss, ebp - 0x2c]);   /* movsx edx, word [ebp-0x2c] */
            ii(0x100d_ffeb, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100d_ffef, 5); calld(0x100d_8248, -0x7dac);            /* call 0x100d8248 */
            ii(0x100d_fff4, 3); sub(eax, memd_a32[ss, ebp - 0x30]);     /* sub eax, [ebp-0x30] */
            ii(0x100d_fff7, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_fffa, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fffe, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_0004, 6); mov(al, memb_a32[ds, eax + 0x101c_a490]); /* mov al, [eax+0x101ca490] */
            ii(0x100e_000a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_000f, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100e_0012, 6); if(jnzd(0x100e_008d, 0x75)) goto l_0x100e_008d; /* jnz 0x100e008d */
            ii(0x100e_0018, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x100e_001d, 5); calld(0x1007_5fdc, -0x6a046);           /* call 0x10075fdc */
            ii(0x100e_0022, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_0025, 2); jmpd(0x100e_0071, 0x4a); goto l_0x100e_0071; /* jmp 0x100e0071 */
        l_0x100e_0027:
            ii(0x100e_0027, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100e_002b, 3); lea(edx, edx + edx * 4);                /* lea edx, [edx+edx*4] */
            ii(0x100e_002e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_0030, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_0033, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100e_0036, 2); sbb(eax, edx);                          /* sbb eax, edx */
            ii(0x100e_0038, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x100e_003b, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_003e, 2); jmpd(0x100e_008d, 0x4d); goto l_0x100e_008d; /* jmp 0x100e008d */
        l_0x100e_0040:
            ii(0x100e_0040, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100e_0044, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100e_0047, 5); mov(ebx, 0x5);                          /* mov ebx, 0x5 */
            ii(0x100e_004c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_004e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_0051, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_0053, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_0056, 2); jmpd(0x100e_008d, 0x35); goto l_0x100e_008d; /* jmp 0x100e008d */
        l_0x100e_0058:
            ii(0x100e_0058, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100e_005c, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x100e_005e, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x100e_0063, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_0065, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_0068, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x100e_006a, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100e_006d, 2); jmpd(0x100e_008d, 0x1e); goto l_0x100e_008d; /* jmp 0x100e008d */
        l_0x100e_006f:
            ii(0x100e_006f, 2); jmpd(0x100e_008d, 0x1c); goto l_0x100e_008d; /* jmp 0x100e008d */
        l_0x100e_0071:
            ii(0x100e_0071, 4); cmp(memd_a32[ss, ebp - 0x34], 0x4);     /* cmp dword [ebp-0x34], 0x4 */
            ii(0x100e_0075, 2); if(jbd(0x100e_0085, 0xe)) goto l_0x100e_0085; /* jb 0x100e0085 */
            ii(0x100e_0077, 4); cmp(memd_a32[ss, ebp - 0x34], 0x4);     /* cmp dword [ebp-0x34], 0x4 */
            ii(0x100e_007b, 2); if(jbed(0x100e_0040, -0x3d)) goto l_0x100e_0040; /* jbe 0x100e0040 */
            ii(0x100e_007d, 4); cmp(memd_a32[ss, ebp - 0x34], 0x5);     /* cmp dword [ebp-0x34], 0x5 */
            ii(0x100e_0081, 2); if(jzd(0x100e_0058, -0x2b)) goto l_0x100e_0058; /* jz 0x100e0058 */
            ii(0x100e_0083, 2); jmpd(0x100e_006f, -0x16); goto l_0x100e_006f; /* jmp 0x100e006f */
        l_0x100e_0085:
            ii(0x100e_0085, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100e_0089, 2); if(jzd(0x100e_0027, -0x64)) goto l_0x100e_0027; /* jz 0x100e0027 */
            ii(0x100e_008b, 2); jmpd(0x100e_006f, -0x1e); goto l_0x100e_006f; /* jmp 0x100e006f */
        l_0x100e_008d:
            ii(0x100e_008d, 4); movsx(eax, memw_a32[ss, ebp - 0x30]);   /* movsx eax, word [ebp-0x30] */
            ii(0x100e_0091, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100e_0094, 2); if(jged(0x100e_009d, 0x7)) goto l_0x100e_009d; /* jge 0x100e009d */
            ii(0x100e_0096, 7); mov(memd_a32[ss, ebp - 0x30], 0x1);     /* mov dword [ebp-0x30], 0x1 */
        l_0x100e_009d:
            ii(0x100e_009d, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_00a0, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_00a3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_00a5, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100e_00a8, 5); calld(0x1007_5eec, -0x6a1c1);           /* call 0x10075eec */
            ii(0x100e_00ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_00af, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_00b2, 5); calld(0x1007_5eec, -0x6a1cb);           /* call 0x10075eec */
            ii(0x100e_00b7, 2); jmpd(0x100e_00cd, 0x14); goto l_0x100e_00cd; /* jmp 0x100e00cd */
        //  ii(0x100e_00b9, 20); Недостижимый код.
l_0x100e_00cd:
            ii(0x100e_00cd, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100e_00d0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_00d2, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_00d3, 1); popd(edi);                              /* pop edi */
            ii(0x100e_00d4, 1); popd(esi);                              /* pop esi */
            ii(0x100e_00d5, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_00d6, 1); retd(); return;                         /* ret */
        }
    }
}

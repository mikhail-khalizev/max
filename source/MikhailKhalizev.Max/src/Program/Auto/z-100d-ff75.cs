using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4210594b-50bc-4027-9c3d-57591c0ab108")]
        public void Method_100d_ff75()
        {
            ii(0x100d_ff75, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ff79, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_ff7c, 5); calld(0x1007_6730, -0x6_9851);          /* call 0x10076730 */
            ii(0x100d_ff81, 5); calld(0x1016_3b41, 0x8_3bbb);           /* call 0x10163b41 */
            ii(0x100d_ff86, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100d_ff89, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_ff8c, 4); movsx(edx, memb_a32[ss, ebp - 0x4]);    /* movsx edx, byte [ebp-0x4] */
            ii(0x100d_ff90, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_ff93, 5); calld(0x1007_6730, -0x6_9868);          /* call 0x10076730 */
            ii(0x100d_ff98, 5); calld(0x1016_3b41, 0x8_3ba4);           /* call 0x10163b41 */
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
            ii(0x100d_ffd6, 5); calld(0x1007_6730, -0x6_98ab);          /* call 0x10076730 */
            ii(0x100d_ffdb, 5); calld(0x1016_3b41, 0x8_3b61);           /* call 0x10163b41 */
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
            ii(0x100e_001d, 5); calld(0x1007_5fdc, -0x6_a046);          /* call 0x10075fdc */
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
            ii(0x100e_00a8, 5); calld(0x1007_5eec, -0x6_a1c1);          /* call 0x10075eec */
            ii(0x100e_00ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100e_00af, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100e_00b2, 5); calld(0x1007_5eec, -0x6_a1cb);          /* call 0x10075eec */
            ii(0x100e_00b7, 2); jmpd(0x100e_00cd, 0x14); goto l_0x100e_00cd; /* jmp 0x100e00cd */
        //    ii(0x100e_00b9, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100e_00bb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
        //    ii(0x100e_00be, 5); calld(0x1007_5eec, -0x6_a1d7);          /* call 0x10075eec */
        //    ii(0x100e_00c3, 2); xor(edx, edx);                          /* xor edx, edx */
        //    ii(0x100e_00c5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //    ii(0x100e_00c8, 5); calld(0x1007_5eec, -0x6_a1e1);          /* call 0x10075eec */
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

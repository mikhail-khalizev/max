using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_ff95-7a949299")]
        public void Method_100f_ff95()
        {
            ii(0x100f_ff95, 5); pushd(0x80);                            /* push 0x80 */
            ii(0x100f_ff9a, 5); calld(Definitions.sys_check_available_stack_size, 0x6_5db3); /* call 0x10165d52 */
            ii(0x100f_ff9f, 1); pushd(esi);                             /* push esi */
            ii(0x100f_ffa0, 1); pushd(edi);                             /* push edi */
            ii(0x100f_ffa1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_ffa2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_ffa4, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x100f_ffaa, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_ffad, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100f_ffb0, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x100f_ffb3, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x100f_ffb6, 4); movsx(eax, memb_a32[ss, ebp - 0x4]);    /* movsx eax, byte [ebp-0x4] */
            ii(0x100f_ffba, 5); calld(0x100e_883d, -0x1_7782);          /* call 0x100e883d */
            ii(0x100f_ffbf, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100f_ffc2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_ffc5, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x100f_ffc9, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_ffcc, 3); sub(ax, memw_a32[ds, edx]);             /* sub ax, [edx] */
            ii(0x100f_ffcf, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_ffd2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_ffd5, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100f_ffd9, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100f_ffdc, 4); sub(ax, memw_a32[ds, edx + 0x4]);       /* sub ax, [edx+0x4] */
            ii(0x100f_ffe0, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100f_ffe3, 4); cmp(memb_a32[ss, ebp - 0x4], 0xd);      /* cmp byte [ebp-0x4], 0xd */
            ii(0x100f_ffe7, 2); if(jzd(0x1010_000f, 0x26)) goto l_0x1010_000f; /* jz 0x1010000f */
            ii(0x100f_ffe9, 2); pushd(0x3c);                            /* push 0x3c */
            ii(0x100f_ffeb, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x100f_ffef, 1); pushd(eax);                             /* push eax */
            ii(0x100f_fff0, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_fff4, 1); pushd(eax);                             /* push eax */
            ii(0x100f_fff5, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x100f_fff9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_fffb, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_fffe, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1010_0001, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_0004, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_0007, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_000a, 5); calld(/* sys */ 0x1016_a5a0, 0x6_a591); /* call 0x1016a5a0 */
        l_0x1010_000f:
            ii(0x1010_000f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0011, 4); mov(ax, memw_a32[ss, ebp + 0x10]);      /* mov ax, [ebp+0x10] */
            ii(0x1010_0015, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_0017, 2); if(jzd(0x1010_0021, 0x8)) goto l_0x1010_0021; /* jz 0x10100021 */
            ii(0x1010_0019, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1010_001d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_001f, 2); if(jnzd(0x1010_0026, 0x5)) goto l_0x1010_0026; /* jnz 0x10100026 */
        l_0x1010_0021:
            ii(0x1010_0021, 5); jmpd(0x1010_01f0, 0x1ca); goto l_0x1010_01f0; /* jmp 0x101001f0 */
        l_0x1010_0026:
            ii(0x1010_0026, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0028, 4); mov(dx, memw_a32[ss, ebp + 0x10]);      /* mov dx, [ebp+0x10] */
            ii(0x1010_002c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_002e, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_0032, 5); calld(Definitions.my_min, -0x7_68b3);   /* call 0x10089784 */
            ii(0x1010_0037, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_003a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_003c, 4); mov(ax, memw_a32[ss, ebp + 0x10]);      /* mov ax, [ebp+0x10] */
            ii(0x1010_0040, 3); sar(eax, 0x2);                          /* sar eax, 0x2 */
            ii(0x1010_0043, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0045, 4); mov(dx, memw_a32[ss, ebp - 0x8]);       /* mov dx, [ebp-0x8] */
            ii(0x1010_0049, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_004b, 2); if(jgd(0x1010_0065, 0x18)) goto l_0x1010_0065; /* jg 0x10100065 */
            ii(0x1010_004d, 7); mov(memd_a32[ss, ebp - 0x20], 0x1);     /* mov dword [ebp-0x20], 0x1 */
            ii(0x1010_0054, 6); cmp(memw_a32[ss, ebp - 0xc], 0x276);    /* cmp word [ebp-0xc], 0x276 */
            ii(0x1010_005a, 2); if(jnzd(0x1010_0063, 0x7)) goto l_0x1010_0063; /* jnz 0x10100063 */
            ii(0x1010_005c, 7); mov(memd_a32[ss, ebp - 0xc], 0x27a);    /* mov dword [ebp-0xc], 0x27a */
        l_0x1010_0063:
            ii(0x1010_0063, 2); jmpd(0x1010_0096, 0x31); goto l_0x1010_0096; /* jmp 0x10100096 */
        l_0x1010_0065:
            ii(0x1010_0065, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0067, 4); mov(ax, memw_a32[ss, ebp + 0x10]);      /* mov ax, [ebp+0x10] */
            ii(0x1010_006b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1010_006d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_006f, 4); mov(dx, memw_a32[ss, ebp - 0x8]);       /* mov dx, [ebp-0x8] */
            ii(0x1010_0073, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1010_0075, 2); if(jgd(0x1010_008f, 0x18)) goto l_0x1010_008f; /* jg 0x1010008f */
            ii(0x1010_0077, 7); mov(memd_a32[ss, ebp - 0x20], 0x4);     /* mov dword [ebp-0x20], 0x4 */
            ii(0x1010_007e, 6); cmp(memw_a32[ss, ebp - 0xc], 0x276);    /* cmp word [ebp-0xc], 0x276 */
            ii(0x1010_0084, 2); if(jnzd(0x1010_008d, 0x7)) goto l_0x1010_008d; /* jnz 0x1010008d */
            ii(0x1010_0086, 7); mov(memd_a32[ss, ebp - 0xc], 0x278);    /* mov dword [ebp-0xc], 0x278 */
        l_0x1010_008d:
            ii(0x1010_008d, 2); jmpd(0x1010_0096, 0x7); goto l_0x1010_0096; /* jmp 0x10100096 */
        l_0x1010_008f:
            ii(0x1010_008f, 7); mov(memd_a32[ss, ebp - 0x20], 0x2);     /* mov dword [ebp-0x20], 0x2 */
        l_0x1010_0096:
            ii(0x1010_0096, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x1010_009b, 5); calld(/* sys */ 0x1016_a24c, 0x6_a1ac); /* call 0x1016a24c */
            ii(0x1010_00a0, 7); mov(memd_a32[ss, ebp - 0x24], 0x19);    /* mov dword [ebp-0x24], 0x19 */
            ii(0x1010_00a7, 6); cmp(memw_a32[ss, ebp - 0xc], 0x280);    /* cmp word [ebp-0xc], 0x280 */
            ii(0x1010_00ad, 2); if(jzd(0x1010_00b7, 0x8)) goto l_0x1010_00b7; /* jz 0x101000b7 */
            ii(0x1010_00af, 6); cmp(memw_a32[ss, ebp - 0xc], 0x282);    /* cmp word [ebp-0xc], 0x282 */
            ii(0x1010_00b5, 2); if(jnzd(0x1010_00be, 0x7)) goto l_0x1010_00be; /* jnz 0x101000be */
        l_0x1010_00b7:
            ii(0x1010_00b7, 7); mov(memd_a32[ss, ebp - 0x24], 0x14);    /* mov dword [ebp-0x24], 0x14 */
        l_0x1010_00be:
            ii(0x1010_00be, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_00c0, 4); mov(ax, memw_a32[ss, ebp + 0x10]);      /* mov ax, [ebp+0x10] */
            ii(0x1010_00c4, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x1010_00c8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_00ca, 4); movsx(ebx, memw_a32[ss, ebp + 0x14]);   /* movsx ebx, word [ebp+0x14] */
            ii(0x1010_00ce, 1); dec(edx);                               /* dec edx */
            ii(0x1010_00cf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_00d1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_00d4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_00d6, 4); movsx(edx, memw_a32[ss, ebp - 0x24]);   /* movsx edx, word [ebp-0x24] */
            ii(0x1010_00da, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1010_00dc, 2); if(jled(0x1010_00f9, 0x1b)) goto l_0x1010_00f9; /* jle 0x101000f9 */
            ii(0x1010_00de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_00e0, 4); mov(dx, memw_a32[ss, ebp + 0x10]);      /* mov dx, [ebp+0x10] */
            ii(0x1010_00e4, 4); movsx(eax, memw_a32[ss, ebp - 0x24]);   /* movsx eax, word [ebp-0x24] */
            ii(0x1010_00e8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_00ea, 4); movsx(ebx, memw_a32[ss, ebp - 0x24]);   /* movsx ebx, word [ebp-0x24] */
            ii(0x1010_00ee, 1); dec(edx);                               /* dec edx */
            ii(0x1010_00ef, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_00f1, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_00f4, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_00f6, 3); mov(memd_a32[ss, ebp + 0x14], eax);     /* mov [ebp+0x14], eax */
        l_0x1010_00f9:
            ii(0x1010_00f9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_00fb, 4); mov(ax, memw_a32[ss, ebp + 0x10]);      /* mov ax, [ebp+0x10] */
            ii(0x1010_00ff, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0100, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0102, 4); mov(ax, memw_a32[ss, ebp - 0x8]);       /* mov ax, [ebp-0x8] */
            ii(0x1010_0106, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0107, 5); mov(eax, StringDefinitions.II);         /* mov eax, 0x101a2b25 */
            ii(0x1010_010c, 1); pushd(eax);                             /* push eax */
            ii(0x1010_010d, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x1010_0110, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0111, 5); calld(Definitions.sys_sprintf, 0x6_5deb); /* call 0x10165f01 */
            ii(0x1010_0116, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1010_0119, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_011e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_011f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_0124, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0125, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1010_0128, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0129, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_012d, 1); pushd(eax);                             /* push eax */
            ii(0x1010_012e, 5); mov(eax, 0x2d);                         /* mov eax, 0x2d */
            ii(0x1010_0133, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0134, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_0136, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0137, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1010_0139, 3); lea(ebx, ebp - 0x58);                   /* lea ebx, [ebp-0x58] */
            ii(0x1010_013c, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1010_013f, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x1010_0142, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_0145, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_0148, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_014b, 5); calld(0x100e_9ae5, -0x1_666b);          /* call 0x100e9ae5 */
            ii(0x1010_0150, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_0152, 4); mov(dx, memw_a32[ss, ebp - 0x8]);       /* mov dx, [ebp-0x8] */
            ii(0x1010_0156, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1010_015a, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_015c, 4); movsx(ebx, memw_a32[ss, ebp + 0x14]);   /* movsx ebx, word [ebp+0x14] */
            ii(0x1010_0160, 1); dec(edx);                               /* dec edx */
            ii(0x1010_0161, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_0163, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_0166, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_0168, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_016b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_016d, 4); mov(dx, memw_a32[ss, ebp + 0x10]);      /* mov dx, [ebp+0x10] */
            ii(0x1010_0171, 4); movsx(eax, memw_a32[ss, ebp + 0x14]);   /* movsx eax, word [ebp+0x14] */
            ii(0x1010_0175, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1010_0177, 4); movsx(ebx, memw_a32[ss, ebp + 0x14]);   /* movsx ebx, word [ebp+0x14] */
            ii(0x1010_017b, 1); dec(edx);                               /* dec edx */
            ii(0x1010_017c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1010_017e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1010_0181, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1010_0183, 3); mov(memd_a32[ss, ebp + 0x10], eax);     /* mov [ebp+0x10], eax */
            ii(0x1010_0186, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_018b, 1); pushd(eax);                             /* push eax */
            ii(0x1010_018c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_018e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_018f, 5); pushd(0xa2);                            /* push 0xa2 */
            ii(0x1010_0194, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1010_0198, 1); pushd(eax);                             /* push eax */
            ii(0x1010_0199, 5); mov(eax, 0x1e);                         /* mov eax, 0x1e */
            ii(0x1010_019e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_019f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_01a1, 1); pushd(eax);                             /* push eax */
            ii(0x1010_01a2, 5); mov(ecx, 0x2d);                         /* mov ecx, 0x2d */
            ii(0x1010_01a7, 3); mov(ebx, memd_a32[ss, ebp - 0x10]);     /* mov ebx, [ebp-0x10] */
            ii(0x1010_01aa, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1010_01ad, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x1010_01b0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_01b3, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_01b6, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_01b9, 5); calld(0x100e_9ae5, -0x1_66d9);          /* call 0x100e9ae5 */
            ii(0x1010_01be, 4); add(memd_a32[ss, ebp - 0x18], -0x4b /* 0xb5 */); /* add dword [ebp-0x18], 0xffffffb5 */
            ii(0x1010_01c2, 4); movsx(eax, memw_a32[ss, ebp + 0x10]);   /* movsx eax, word [ebp+0x10] */
            ii(0x1010_01c6, 1); pushd(eax);                             /* push eax */
            ii(0x1010_01c7, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x1010_01cb, 1); pushd(eax);                             /* push eax */
            ii(0x1010_01cc, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x1010_01d0, 1); pushd(eax);                             /* push eax */
            ii(0x1010_01d1, 4); movsx(ecx, memw_a32[ss, ebp - 0x1c]);   /* movsx ecx, word [ebp-0x1c] */
            ii(0x1010_01d5, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x1010_01d9, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x1010_01dc, 3); mov(edx, memd_a32[ds, edx + 0xe]);      /* mov edx, [edx+0xe] */
            ii(0x1010_01df, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_01e2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1010_01e5, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_01e8, 3); add(eax, 0x4b);                         /* add eax, 0x4b */
            ii(0x1010_01eb, 5); calld(0x100f_fd62, -0x48e);             /* call 0x100ffd62 */
        l_0x1010_01f0:
            ii(0x1010_01f0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_01f2, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_01f3, 1); popd(edi);                              /* pop edi */
            ii(0x1010_01f4, 1); popd(esi);                              /* pop esi */
            ii(0x1010_01f5, 3); retd(0x8); return;                      /* ret 0x8 */
        }
    }
}

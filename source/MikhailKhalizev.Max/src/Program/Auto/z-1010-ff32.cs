using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_ff32-1c210158")]
        public void Method_1010_ff32()
        {
            ii(0x1010_ff32, 5); push(0x4c);                             /* push 0x4c */
            ii(0x1010_ff37, 5); call(Definitions.sys_check_available_stack_size, 0x5_5e16); /* call 0x10165d52 */
            ii(0x1010_ff3c, 1); push(ebx);                              /* push ebx */
            ii(0x1010_ff3d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_ff3e, 1); push(edx);                              /* push edx */
            ii(0x1010_ff3f, 1); push(esi);                              /* push esi */
            ii(0x1010_ff40, 1); push(edi);                              /* push edi */
            ii(0x1010_ff41, 1); push(ebp);                              /* push ebp */
            ii(0x1010_ff42, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_ff44, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x1010_ff4a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_ff4c, 5); call(0x100e_883d, -0x2_7714);           /* call 0x100e883d */
            ii(0x1010_ff51, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_ff54, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_ff58, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
        l_0x1010_ff5f:
            ii(0x1010_ff5f, 4); cmp(memd[ss, ebp - 0x8], 0x1b);         /* cmp dword [ebp-0x8], 0x1b */
            ii(0x1010_ff63, 2); if(jz(0x1010_ff6e, 0x9)) goto l_0x1010_ff6e; /* jz 0x1010ff6e */
            ii(0x1010_ff65, 7); cmp(memd[ss, ebp - 0x8], 0x2328);       /* cmp dword [ebp-0x8], 0x2328 */
            ii(0x1010_ff6c, 2); if(jnz(0x1010_ff73, 0x5)) goto l_0x1010_ff73; /* jnz 0x1010ff73 */
        l_0x1010_ff6e:
            ii(0x1010_ff6e, 5); jmp(0x1011_026b, 0x2f8); goto l_0x1011_026b; /* jmp 0x1011026b */
        l_0x1010_ff73:
            ii(0x1010_ff73, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
            ii(0x1010_ff77, 5); call(/* sys */ 0x1016_be34, 0x5_beb8);  /* call 0x1016be34 */
            ii(0x1010_ff7c, 5); call(0x100d_533c, -0x3_ac45);           /* call 0x100d533c */
            ii(0x1010_ff81, 1); cwde();                                 /* cwde */
            ii(0x1010_ff82, 1); push(eax);                              /* push eax */
            ii(0x1010_ff83, 5); call(0x100d_5360, -0x3_ac28);           /* call 0x100d5360 */
            ii(0x1010_ff88, 1); cwde();                                 /* cwde */
            ii(0x1010_ff89, 1); push(eax);                              /* push eax */
            ii(0x1010_ff8a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_ff8c, 1); push(eax);                              /* push eax */
            ii(0x1010_ff8d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_ff8f, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1010_ff92, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1010_ff95, 5); mov(ebx, 0x280);                        /* mov ebx, 0x280 */
            ii(0x1010_ff9a, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1010_ff9d, 5); mov(eax, 0x6c0);                        /* mov eax, 0x6c0 */
            ii(0x1010_ffa2, 5); call(0x100e_8c51, -0x2_7356);           /* call 0x100e8c51 */
            ii(0x1010_ffa7, 5); mov(edx, StringDefinitions.MultiplayerMenu); /* mov edx, 0x101a465a */
            ii(0x1010_ffac, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_ffaf, 5); call(0x1010_c628, -0x398c);             /* call 0x1010c628 */
            ii(0x1010_ffb4, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_ffb6, 6); mov(edx, memd[ds, 0x101c_4e4c]);        /* mov edx, [0x101c4e4c] */
            ii(0x1010_ffbc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_ffbf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_ffc2, 5); call(0x1010_c693, -0x3934);             /* call 0x1010c693 */
            ii(0x1010_ffc7, 5); call(0x1011_52f4, 0x5328);              /* call 0x101152f4 */
            ii(0x1010_ffcc, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1010_ffcf, 5); mov(edx, 0x9);                          /* mov edx, 0x9 */
            ii(0x1010_ffd4, 5); mov(eax, 0x101b_914c);                  /* mov eax, 0x101b914c */
            ii(0x1010_ffd9, 5); call(0x1010_9cee, -0x62f0);             /* call 0x10109cee */
            ii(0x1010_ffde, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1010_ffe3, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1010_ffe8, 5); call(0x100c_aafc, -0x4_54f1);           /* call 0x100caafc */
            ii(0x1010_ffed, 4); mov(memb[ss, ebp - 0x4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1010_fff1, 5); call(/* sys */ 0x1016_bcc4, 0x5_bcce);  /* call 0x1016bcc4 */
            ii(0x1010_fff6, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
        l_0x1010_fffa:
            ii(0x1010_fffa, 5); call(/* sys */ 0x1016_b208, 0x5_b209);  /* call 0x1016b208 */
            ii(0x1010_ffff, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_0002, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0005, 5); call(Definitions.sys_tolower, 0x6_2a8b); /* call 0x10172a95 */
            ii(0x1011_000a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_000d, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1011_0011, 2); if(jle(0x1011_001c, 0x9)) goto l_0x1011_001c; /* jle 0x1011001c */
            ii(0x1011_0013, 7); cmp(memd[ss, ebp - 0x8], 0x7000);       /* cmp dword [ebp-0x8], 0x7000 */
            ii(0x1011_001a, 2); if(jl(0x1011_001e, 0x2)) goto l_0x1011_001e; /* jl 0x1011001e */
        l_0x1011_001c:
            ii(0x1011_001c, 2); jmp(0x1011_0022, 0x4); goto l_0x1011_0022; /* jmp 0x10110022 */
        l_0x1011_001e:
            ii(0x1011_001e, 4); mov(memb[ss, ebp - 0x18], 0);           /* mov byte [ebp-0x18], 0x0 */
        l_0x1011_0022:
            ii(0x1011_0022, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_0025, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1011_0028, 5); jmp(0x1011_01bf, 0x192); goto l_0x1011_01bf; /* jmp 0x101101bf */
        l_0x1011_002d:
            ii(0x1011_002d, 5); call(0x1010_9b8a, -0x64a8);             /* call 0x10109b8a */
            ii(0x1011_0032, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_0037, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1011_003c, 5); call(0x1010_e8be, -0x1783);             /* call 0x1010e8be */
            ii(0x1011_0041, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_0043, 2); if(jz(0x1011_004c, 0x7)) goto l_0x1011_004c; /* jz 0x1011004c */
            ii(0x1011_0045, 7); mov(memd[ss, ebp - 0x8], 0x2328);       /* mov dword [ebp-0x8], 0x2328 */
        l_0x1011_004c:
            ii(0x1011_004c, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_0050, 5); jmp(0x1011_0257, 0x202); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_0055:
            ii(0x1011_0055, 5); call(0x1010_9b8a, -0x64d0);             /* call 0x10109b8a */
            ii(0x1011_005a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_005c, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1011_0061, 5); call(0x1010_e8be, -0x17a8);             /* call 0x1010e8be */
            ii(0x1011_0066, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_0068, 2); if(jz(0x1011_0071, 0x7)) goto l_0x1011_0071; /* jz 0x10110071 */
            ii(0x1011_006a, 7); mov(memd[ss, ebp - 0x8], 0x2328);       /* mov dword [ebp-0x8], 0x2328 */
        l_0x1011_0071:
            ii(0x1011_0071, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_0075, 5); jmp(0x1011_0257, 0x1dd); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_007a:
            ii(0x1011_007a, 5); call(0x1010_9b8a, -0x64f5);             /* call 0x10109b8a */
            ii(0x1011_007f, 4); cmp(memd[ss, ebp - 0x8], 0x4d);         /* cmp dword [ebp-0x8], 0x4d */
            ii(0x1011_0083, 2); if(jnz(0x1011_008e, 0x9)) goto l_0x1011_008e; /* jnz 0x1011008e */
            ii(0x1011_0085, 7); mov(memd[ss, ebp - 0x20], 0x2);         /* mov dword [ebp-0x20], 0x2 */
            ii(0x1011_008c, 2); jmp(0x1011_0095, 0x7); goto l_0x1011_0095; /* jmp 0x10110095 */
        l_0x1011_008e:
            ii(0x1011_008e, 7); mov(memd[ss, ebp - 0x20], 0x1);         /* mov dword [ebp-0x20], 0x1 */
        l_0x1011_0095:
            ii(0x1011_0095, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_0097, 3); mov(al, memb[ss, ebp - 0x20]);          /* mov al, [ebp-0x20] */
            ii(0x1011_009a, 5); call(0x1010_fccd, -0x3d2);              /* call 0x1010fccd */
            ii(0x1011_009f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_00a1, 2); if(jz(0x1011_00aa, 0x7)) goto l_0x1011_00aa; /* jz 0x101100aa */
            ii(0x1011_00a3, 7); mov(memd[ss, ebp - 0x8], 0x2328);       /* mov dword [ebp-0x8], 0x2328 */
        l_0x1011_00aa:
            ii(0x1011_00aa, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_00ae, 5); jmp(0x1011_0257, 0x1a4); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_00b3:
            ii(0x1011_00b3, 5); call(0x1010_9b8a, -0x652e);             /* call 0x10109b8a */
            ii(0x1011_00b8, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1011_00bd, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_00c2, 5); call(0x100c_aafc, -0x4_55cb);           /* call 0x100caafc */
            ii(0x1011_00c7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_00c9, 5); call(0x1010_e7df, -0x18ef);             /* call 0x1010e7df */
            ii(0x1011_00ce, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_00d0, 2); if(jz(0x1011_00d9, 0x7)) goto l_0x1011_00d9; /* jz 0x101100d9 */
            ii(0x1011_00d2, 7); mov(memd[ss, ebp - 0x8], 0x2328);       /* mov dword [ebp-0x8], 0x2328 */
        l_0x1011_00d9:
            ii(0x1011_00d9, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_00dd, 5); jmp(0x1011_0257, 0x175); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_00e2:
            ii(0x1011_00e2, 5); call(0x1010_9b8a, -0x655d);             /* call 0x10109b8a */
            ii(0x1011_00e7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_00e9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_00ee, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1011_00f3, 5); call(0x1011_1386, 0x128e);              /* call 0x10111386 */
            ii(0x1011_00f8, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1011_00fa, 2); if(jz(0x1011_0103, 0x7)) goto l_0x1011_0103; /* jz 0x10110103 */
            ii(0x1011_00fc, 7); mov(memd[ss, ebp - 0x8], 0x2328);       /* mov dword [ebp-0x8], 0x2328 */
        l_0x1011_0103:
            ii(0x1011_0103, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_0107, 5); jmp(0x1011_0257, 0x14b); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_010c:
            ii(0x1011_010c, 5); call(0x1010_9b8a, -0x6587);             /* call 0x10109b8a */
            ii(0x1011_0111, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1011_0116, 5); mov(eax, 0x3e);                         /* mov eax, 0x3e */
            ii(0x1011_011b, 5); call(0x100c_aafc, -0x4_5624);           /* call 0x100caafc */
            ii(0x1011_0120, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_0122, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_0124, 5); call(0x1013_843f, 0x2_8316);            /* call 0x1013843f */
            ii(0x1011_0129, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_012c, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1011_0130, 2); if(jz(0x1011_0150, 0x1e)) goto l_0x1011_0150; /* jz 0x10110150 */
            ii(0x1011_0132, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1011_0135, 5); mov(eax, 0x3d);                         /* mov eax, 0x3d */
            ii(0x1011_013a, 5); call(0x100c_aafc, -0x4_5643);           /* call 0x100caafc */
            ii(0x1011_013f, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1011_0144, 5); call(0x100f_f0ba, -0x1_108f);           /* call 0x100ff0ba */
            ii(0x1011_0149, 7); mov(memd[ss, ebp - 0x8], 0x2328);       /* mov dword [ebp-0x8], 0x2328 */
        l_0x1011_0150:
            ii(0x1011_0150, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_0154, 4); mov(memb[ss, ebp - 0x4], 0x1);          /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_0158, 5); jmp(0x1011_0257, 0xfa); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_015d:
            ii(0x1011_015d, 5); call(0x1010_9b8a, -0x65d8);             /* call 0x10109b8a */
            ii(0x1011_0162, 7); mov(memd[ss, ebp - 0x8], 0x1b);         /* mov dword [ebp-0x8], 0x1b */
            ii(0x1011_0169, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
            ii(0x1011_016d, 5); jmp(0x1011_0257, 0xe5); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_0172:
            ii(0x1011_0172, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1011_0177, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1011_017c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_017f, 5); call(0x1010_c693, -0x3af1);             /* call 0x1010c693 */
            ii(0x1011_0184, 5); jmp(0x1011_0257, 0xce); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_0189:
            ii(0x1011_0189, 7); cmp(memd[ss, ebp - 0x8], 0x7000);       /* cmp dword [ebp-0x8], 0x7000 */
            ii(0x1011_0190, 2); if(jl(0x1011_01ba, 0x28)) goto l_0x1011_01ba; /* jl 0x101101ba */
            ii(0x1011_0192, 7); add(memd[ss, ebp - 0x8], 0xffff_9000);  /* add dword [ebp-0x8], 0xffff9000 */
            ii(0x1011_0199, 4); cmp(memb[ss, ebp - 0x18], 0);           /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1011_019d, 2); if(jnz(0x1011_01a5, 0x6)) goto l_0x1011_01a5; /* jnz 0x101101a5 */
            ii(0x1011_019f, 4); cmp(memd[ss, ebp - 0x8], 0x9);          /* cmp dword [ebp-0x8], 0x9 */
            ii(0x1011_01a3, 2); if(jb(0x1011_01a7, 0x2)) goto l_0x1011_01a7; /* jb 0x101101a7 */
        l_0x1011_01a5:
            ii(0x1011_01a5, 2); jmp(0x1011_01b6, 0xf); goto l_0x1011_01b6; /* jmp 0x101101b6 */
        l_0x1011_01a7:
            ii(0x1011_01a7, 4); imul(eax, memd[ss, ebp - 0x8], 0x13);   /* imul eax, [ebp-0x8], 0x13 */
            ii(0x1011_01ab, 6); mov(eax, memd[ds, eax + 0x101b_914c]);  /* mov eax, [eax+0x101b914c] */
            ii(0x1011_01b1, 5); call(0x100c_fbbe, -0x4_05f8);           /* call 0x100cfbbe */
        l_0x1011_01b6:
            ii(0x1011_01b6, 4); mov(memb[ss, ebp - 0x18], 0x1);         /* mov byte [ebp-0x18], 0x1 */
        l_0x1011_01ba:
            ii(0x1011_01ba, 5); jmp(0x1011_0257, 0x98); goto l_0x1011_0257; /* jmp 0x10110257 */
        l_0x1011_01bf:
            ii(0x1011_01bf, 4); cmp(memd[ss, ebp - 0x1c], 0x4c);        /* cmp dword [ebp-0x1c], 0x4c */
            ii(0x1011_01c3, 2); if(jb(0x1011_0214, 0x4f)) goto l_0x1011_0214; /* jb 0x10110214 */
            ii(0x1011_01c5, 4); cmp(memd[ss, ebp - 0x1c], 0x4c);        /* cmp dword [ebp-0x1c], 0x4c */
            ii(0x1011_01c9, 6); if(jbe(0x1011_010c, -0xc3)) goto l_0x1011_010c; /* jbe 0x1011010c */
            ii(0x1011_01cf, 4); cmp(memd[ss, ebp - 0x1c], 0x53);        /* cmp dword [ebp-0x1c], 0x53 */
            ii(0x1011_01d3, 2); if(jb(0x1011_01f6, 0x21)) goto l_0x1011_01f6; /* jb 0x101101f6 */
            ii(0x1011_01d5, 4); cmp(memd[ss, ebp - 0x1c], 0x53);        /* cmp dword [ebp-0x1c], 0x53 */
            ii(0x1011_01d9, 6); if(jbe(0x1011_007a, -0x165)) goto l_0x1011_007a; /* jbe 0x1011007a */
            ii(0x1011_01df, 4); cmp(memd[ss, ebp - 0x1c], 0x54);        /* cmp dword [ebp-0x1c], 0x54 */
            ii(0x1011_01e3, 6); if(jbe(0x1011_00e2, -0x107)) goto l_0x1011_00e2; /* jbe 0x101100e2 */
            ii(0x1011_01e9, 7); cmp(memd[ss, ebp - 0x1c], 0x148);       /* cmp dword [ebp-0x1c], 0x148 */
            ii(0x1011_01f0, 2); if(jz(0x1011_0172, -0x80)) goto l_0x1011_0172; /* jz 0x10110172 */
            ii(0x1011_01f2, 2); jmp(0x1011_0189, -0x6b); goto l_0x1011_0189; /* jmp 0x10110189 */
        //  ii(0x1011_01f4, 2); jmp(0x1011_0189, -0x6d); goto l_0x1011_0189; /* jmp 0x10110189 */
        l_0x1011_01f6:
            ii(0x1011_01f6, 4); cmp(memd[ss, ebp - 0x1c], 0x4d);        /* cmp dword [ebp-0x1c], 0x4d */
            ii(0x1011_01fa, 6); if(jbe(0x1011_007a, -0x186)) goto l_0x1011_007a; /* jbe 0x1011007a */
            ii(0x1011_0200, 4); cmp(memd[ss, ebp - 0x1c], 0x4f);        /* cmp dword [ebp-0x1c], 0x4f */
            ii(0x1011_0204, 6); if(jz(0x1011_00b3, -0x157)) goto l_0x1011_00b3; /* jz 0x101100b3 */
            ii(0x1011_020a, 5); jmp(0x1011_0189, -0x86); goto l_0x1011_0189; /* jmp 0x10110189 */
        //  ii(0x1011_020f, 5); jmp(0x1011_0189, -0x8b); goto l_0x1011_0189; /* jmp 0x10110189 */
        l_0x1011_0214:
            ii(0x1011_0214, 4); cmp(memd[ss, ebp - 0x1c], 0x43);        /* cmp dword [ebp-0x1c], 0x43 */
            ii(0x1011_0218, 2); if(jb(0x1011_0248, 0x2e)) goto l_0x1011_0248; /* jb 0x10110248 */
            ii(0x1011_021a, 4); cmp(memd[ss, ebp - 0x1c], 0x43);        /* cmp dword [ebp-0x1c], 0x43 */
            ii(0x1011_021e, 6); if(jbe(0x1011_015d, -0xc7)) goto l_0x1011_015d; /* jbe 0x1011015d */
            ii(0x1011_0224, 4); cmp(memd[ss, ebp - 0x1c], 0x48);        /* cmp dword [ebp-0x1c], 0x48 */
            ii(0x1011_0228, 2); if(jb(0x1011_0243, 0x19)) goto l_0x1011_0243; /* jb 0x10110243 */
            ii(0x1011_022a, 4); cmp(memd[ss, ebp - 0x1c], 0x48);        /* cmp dword [ebp-0x1c], 0x48 */
            ii(0x1011_022e, 6); if(jbe(0x1011_002d, -0x207)) goto l_0x1011_002d; /* jbe 0x1011002d */
            ii(0x1011_0234, 4); cmp(memd[ss, ebp - 0x1c], 0x4a);        /* cmp dword [ebp-0x1c], 0x4a */
            ii(0x1011_0238, 6); if(jz(0x1011_0055, -0x1e9)) goto l_0x1011_0055; /* jz 0x10110055 */
            ii(0x1011_023e, 5); jmp(0x1011_0189, -0xba); goto l_0x1011_0189; /* jmp 0x10110189 */
        l_0x1011_0243:
            ii(0x1011_0243, 5); jmp(0x1011_0189, -0xbf); goto l_0x1011_0189; /* jmp 0x10110189 */
        l_0x1011_0248:
            ii(0x1011_0248, 4); cmp(memd[ss, ebp - 0x1c], 0x1b);        /* cmp dword [ebp-0x1c], 0x1b */
            ii(0x1011_024c, 6); if(jz(0x1011_015d, -0xf5)) goto l_0x1011_015d; /* jz 0x1011015d */
            ii(0x1011_0252, 5); jmp(0x1011_0189, -0xce); goto l_0x1011_0189; /* jmp 0x10110189 */
        l_0x1011_0257:
            ii(0x1011_0257, 4); cmp(memb[ss, ebp - 0x14], 0);           /* cmp byte [ebp-0x14], 0x0 */
            ii(0x1011_025b, 6); if(jz(0x1010_fffa, -0x267)) goto l_0x1010_fffa; /* jz 0x1010fffa */
            ii(0x1011_0261, 5); call(0x1012_9cc6, 0x1_9a60);            /* call 0x10129cc6 */
            ii(0x1011_0266, 5); jmp(0x1010_ff5f, -0x30c); goto l_0x1010_ff5f; /* jmp 0x1010ff5f */
        l_0x1011_026b:
            ii(0x1011_026b, 7); cmp(memd[ss, ebp - 0x8], 0x2328);       /* cmp dword [ebp-0x8], 0x2328 */
            ii(0x1011_0272, 2); if(jnz(0x1011_027d, 0x9)) goto l_0x1011_027d; /* jnz 0x1011027d */
            ii(0x1011_0274, 7); mov(memd[ss, ebp - 0x24], 0x1);         /* mov dword [ebp-0x24], 0x1 */
            ii(0x1011_027b, 2); jmp(0x1011_0284, 0x7); goto l_0x1011_0284; /* jmp 0x10110284 */
        l_0x1011_027d:
            ii(0x1011_027d, 7); mov(memd[ss, ebp - 0x24], 0);           /* mov dword [ebp-0x24], 0x0 */
        l_0x1011_0284:
            ii(0x1011_0284, 3); mov(eax, memd[ss, ebp - 0x24]);         /* mov eax, [ebp-0x24] */
            ii(0x1011_0287, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1011_028a, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1011_028d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_028f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_0290, 1); pop(edi);                               /* pop edi */
            ii(0x1011_0291, 1); pop(esi);                               /* pop esi */
            ii(0x1011_0292, 1); pop(edx);                               /* pop edx */
            ii(0x1011_0293, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_0294, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_0295, 1); ret();                                  /* ret */
        }
    }
}

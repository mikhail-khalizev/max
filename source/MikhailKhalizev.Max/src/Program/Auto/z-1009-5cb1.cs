using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f36f3e93-7b6a-4b42-9d72-b6a52f99fed3")]
        public void Method_1009_5cb1()
        {
            ii(0x1009_5cb1, 5); pushd(0x5c);                            /* push 0x5c */
            ii(0x1009_5cb6, 5); calld(Definitions.sys_check_available_stack_size, 0xd_0097); /* call 0x10165d52 */
            ii(0x1009_5cbb, 1); pushd(esi);                             /* push esi */
            ii(0x1009_5cbc, 1); pushd(edi);                             /* push edi */
            ii(0x1009_5cbd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_5cbe, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_5cc0, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1009_5cc6, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_5cc9, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_5ccc, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_5ccf, 3); mov(memd_a32[ss, ebp - 0x8], ecx);      /* mov [ebp-0x8], ecx */
            ii(0x1009_5cd2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5cd5, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_5cd8, 5); calld(0x1007_6338, -0x1_f9a5);          /* call 0x10076338 */
            ii(0x1009_5cdd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5cdf, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5ce2, 5); calld(0x1007_64b8, -0x1_f82f);          /* call 0x100764b8 */
            ii(0x1009_5ce7, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_5cea, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_f1ff); /* call 0x10076af0 */
            ii(0x1009_5cef, 2); jmpd(0x1009_5cf9, 0x8); goto l_0x1009_5cf9; /* jmp 0x10095cf9 */
        l_0x1009_5cf1:
            ii(0x1009_5cf1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5cf4, 5); calld(0x1007_6bf8, -0x1_f101);          /* call 0x10076bf8 */
        l_0x1009_5cf9:
            ii(0x1009_5cf9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5cfb, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5cfe, 5); calld(0x1013_ad71, 0xa_506e);           /* call 0x1013ad71 */
            ii(0x1009_5d03, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5d05, 6); if(jzd(0x1009_5dca, 0xbf)) goto l_0x1009_5dca; /* jz 0x10095dca */
            ii(0x1009_5d0b, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5d0e, 5); calld(0x1007_63a0, -0x1_f973);          /* call 0x100763a0 */
            ii(0x1009_5d13, 4); mov(ax, memw_a32[ds, eax + 0x8]);       /* mov ax, [eax+0x8] */
            ii(0x1009_5d17, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1009_5d1b, 6); if(jnzd(0x1009_5dc5, 0xa4)) goto l_0x1009_5dc5; /* jnz 0x10095dc5 */
            ii(0x1009_5d21, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5d24, 5); calld(0x1007_63a0, -0x1_f989);          /* call 0x100763a0 */
            ii(0x1009_5d29, 5); calld(0x1007_623c, -0x1_faf2);          /* call 0x1007623c */
            ii(0x1009_5d2e, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1009_5d32, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_5d35, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5d38, 5); calld(0x1007_63a0, -0x1_f99d);          /* call 0x100763a0 */
            ii(0x1009_5d3d, 4); mov(ax, memw_a32[ds, eax + 0x1a]);      /* mov ax, [eax+0x1a] */
            ii(0x1009_5d41, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1009_5d45, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5d48, 5); calld(0x1007_63a0, -0x1_f9ad);          /* call 0x100763a0 */
            ii(0x1009_5d4d, 4); mov(ax, memw_a32[ds, eax + 0x1c]);      /* mov ax, [eax+0x1c] */
            ii(0x1009_5d51, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1009_5d55, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1009_5d59, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1009_5d5c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1009_5d5f, 5); calld(0x1007_5e64, -0x1_ff00);          /* call 0x10075e64 */
            ii(0x1009_5d64, 3); lea(ecx, ebp - 0x30);                   /* lea ecx, [ebp-0x30] */
            ii(0x1009_5d67, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5d69, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1009_5d6b, 5); calld(0x100a_95c1, 0x1_3851);           /* call 0x100a95c1 */
        l_0x1009_5d70:
            ii(0x1009_5d70, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5d73, 5); calld(0x1008_9860, -0xc518);            /* call 0x10089860 */
            ii(0x1009_5d78, 1); cwde();                                 /* cwde */
            ii(0x1009_5d79, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_5d7c, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5d7f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_5d81, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5d84, 5); calld(0x1008_982c, -0xc55d);            /* call 0x1008982c */
            ii(0x1009_5d89, 1); cwde();                                 /* cwde */
            ii(0x1009_5d8a, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_5d8c, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_5d8e, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_5d90, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_5d95, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5d97, 2); if(jled(0x1009_5db9, 0x20)) goto l_0x1009_5db9; /* jle 0x10095db9 */
            ii(0x1009_5d99, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5d9c, 5); calld(0x1008_9860, -0xc541);            /* call 0x10089860 */
            ii(0x1009_5da1, 1); cwde();                                 /* cwde */
            ii(0x1009_5da2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_5da5, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5da8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_5daa, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5dad, 5); calld(0x1008_982c, -0xc586);            /* call 0x1008982c */
            ii(0x1009_5db2, 1); cwde();                                 /* cwde */
            ii(0x1009_5db3, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_5db5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_5db7, 2); dec(memb_a32[ds, eax]);                 /* dec byte [eax] */
        l_0x1009_5db9:
            ii(0x1009_5db9, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5dbc, 5); calld(0x100a_96db, 0x1_391a);           /* call 0x100a96db */
            ii(0x1009_5dc1, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5dc3, 2); if(jnzd(0x1009_5d70, -0x55)) goto l_0x1009_5d70; /* jnz 0x10095d70 */
        l_0x1009_5dc5:
            ii(0x1009_5dc5, 5); jmpd(0x1009_5cf1, -0xd9); goto l_0x1009_5cf1; /* jmp 0x10095cf1 */
        l_0x1009_5dca:
            ii(0x1009_5dca, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5dcd, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_5dd0, 5); calld(0x1009_c6c8, 0x68f3);             /* call 0x1009c6c8 */
            ii(0x1009_5dd5, 3); lea(ebx, ebp - 0x34);                   /* lea ebx, [ebp-0x34] */
            ii(0x1009_5dd8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5dda, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_5ddc, 5); calld(0x1009_c5dc, 0x67fb);             /* call 0x1009c5dc */
            ii(0x1009_5de1, 2); jmpd(0x1009_5deb, 0x8); goto l_0x1009_5deb; /* jmp 0x10095deb */
        l_0x1009_5de3:
            ii(0x1009_5de3, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5de6, 5); calld(0x1007_6bf8, -0x1_f1f3);          /* call 0x10076bf8 */
        l_0x1009_5deb:
            ii(0x1009_5deb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5ded, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5df0, 5); calld(0x1013_ad71, 0xa_4f7c);           /* call 0x1013ad71 */
            ii(0x1009_5df5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5df7, 6); if(jzd(0x1009_5eee, 0xf1)) goto l_0x1009_5eee; /* jz 0x10095eee */
            ii(0x1009_5dfd, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5e00, 5); calld(0x1009_c4f8, 0x66f3);             /* call 0x1009c4f8 */
            ii(0x1009_5e05, 5); calld(0x1009_c4c4, 0x66ba);             /* call 0x1009c4c4 */
            ii(0x1009_5e0a, 4); cmp(ax, memw_a32[ss, ebp - 0x4]);       /* cmp ax, [ebp-0x4] */
            ii(0x1009_5e0e, 2); if(jnzd(0x1009_5e1d, 0xd)) goto l_0x1009_5e1d; /* jnz 0x10095e1d */
            ii(0x1009_5e10, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5e13, 5); calld(0x1009_c52c, 0x6714);             /* call 0x1009c52c */
            ii(0x1009_5e18, 3); cmp(eax, memd_a32[ss, ebp - 0x8]);      /* cmp eax, [ebp-0x8] */
            ii(0x1009_5e1b, 2); if(jnzd(0x1009_5e1f, 0x2)) goto l_0x1009_5e1f; /* jnz 0x10095e1f */
        l_0x1009_5e1d:
            ii(0x1009_5e1d, 2); jmpd(0x1009_5e35, 0x16); goto l_0x1009_5e35; /* jmp 0x10095e35 */
        l_0x1009_5e1f:
            ii(0x1009_5e1f, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x1009_5e23, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5e26, 5); calld(0x1009_c4f8, 0x66cd);             /* call 0x1009c4f8 */
            ii(0x1009_5e2b, 5); calld(0x100a_2bc4, 0xcd94);             /* call 0x100a2bc4 */
            ii(0x1009_5e30, 1); cwde();                                 /* cwde */
            ii(0x1009_5e31, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5e33, 2); if(jled(0x1009_5e3a, 0x5)) goto l_0x1009_5e3a; /* jle 0x10095e3a */
        l_0x1009_5e35:
            ii(0x1009_5e35, 5); jmpd(0x1009_5ee9, 0xaf); goto l_0x1009_5ee9; /* jmp 0x10095ee9 */
        l_0x1009_5e3a:
            ii(0x1009_5e3a, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1009_5e3e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5e41, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_5e44, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_5e47, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1009_5e4d, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x1009_5e53, 5); calld(0x1008_b104, -0xad54);            /* call 0x1008b104 */
            ii(0x1009_5e58, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x1009_5e5c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_5e5f, 3); lea(edx, ebp - 0x38);                   /* lea edx, [ebp-0x38] */
            ii(0x1009_5e62, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5e65, 5); calld(0x1009_c4f8, 0x668e);             /* call 0x1009c4f8 */
            ii(0x1009_5e6a, 5); calld(0x100a_2d3d, 0xcece);             /* call 0x100a2d3d */
            ii(0x1009_5e6f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5e71, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_5e74, 5); calld(0x1008_8b44, -0xd335);            /* call 0x10088b44 */
            ii(0x1009_5e79, 4); movsx(ebx, memw_a32[ss, ebp - 0x1c]);   /* movsx ebx, word [ebp-0x1c] */
            ii(0x1009_5e7d, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x1009_5e80, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x1009_5e83, 5); calld(0x1007_5e64, -0x2_0024);          /* call 0x10075e64 */
            ii(0x1009_5e88, 3); lea(ecx, ebp - 0x4c);                   /* lea ecx, [ebp-0x4c] */
            ii(0x1009_5e8b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5e8d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1009_5e8f, 5); calld(0x100a_95c1, 0x1_372d);           /* call 0x100a95c1 */
        l_0x1009_5e94:
            ii(0x1009_5e94, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_5e97, 5); calld(0x1008_9860, -0xc63c);            /* call 0x10089860 */
            ii(0x1009_5e9c, 1); cwde();                                 /* cwde */
            ii(0x1009_5e9d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_5ea0, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5ea3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_5ea5, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_5ea8, 5); calld(0x1008_982c, -0xc681);            /* call 0x1008982c */
            ii(0x1009_5ead, 1); cwde();                                 /* cwde */
            ii(0x1009_5eae, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_5eb0, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_5eb2, 2); mov(al, memb_a32[ds, eax]);             /* mov al, [eax] */
            ii(0x1009_5eb4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_5eb9, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_5ebb, 2); if(jled(0x1009_5edd, 0x20)) goto l_0x1009_5edd; /* jle 0x10095edd */
            ii(0x1009_5ebd, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_5ec0, 5); calld(0x1008_9860, -0xc665);            /* call 0x10089860 */
            ii(0x1009_5ec5, 1); cwde();                                 /* cwde */
            ii(0x1009_5ec6, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_5ec9, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5ecc, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_5ece, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_5ed1, 5); calld(0x1008_982c, -0xc6aa);            /* call 0x1008982c */
            ii(0x1009_5ed6, 1); cwde();                                 /* cwde */
            ii(0x1009_5ed7, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x1009_5ed9, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_5edb, 2); dec(memb_a32[ds, eax]);                 /* dec byte [eax] */
        l_0x1009_5edd:
            ii(0x1009_5edd, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x1009_5ee0, 5); calld(0x100a_96db, 0x1_37f6);           /* call 0x100a96db */
            ii(0x1009_5ee5, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5ee7, 2); if(jnzd(0x1009_5e94, -0x55)) goto l_0x1009_5e94; /* jnz 0x10095e94 */
        l_0x1009_5ee9:
            ii(0x1009_5ee9, 5); jmpd(0x1009_5de3, -0x10b); goto l_0x1009_5de3; /* jmp 0x10095de3 */
        l_0x1009_5eee:
            ii(0x1009_5eee, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5ef0, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_5ef3, 5); calld(0x1009_ba6c, 0x5b74);             /* call 0x1009ba6c */
            ii(0x1009_5ef8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5efa, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5efd, 5); calld(0x1007_5f6c, -0x1_ff96);          /* call 0x10075f6c */
            ii(0x1009_5f02, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_5f04, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_5f05, 1); popd(edi);                              /* pop edi */
            ii(0x1009_5f06, 1); popd(esi);                              /* pop esi */
            ii(0x1009_5f07, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
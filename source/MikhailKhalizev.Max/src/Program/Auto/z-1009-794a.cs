using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_794a-99960ebf")]
        public void Method_1009_794a()
        {
            ii(0x1009_794a, 5); push(0x64);                             /* push 0x64 */
            ii(0x1009_794f, 5); call(Definitions.sys_check_available_stack_size, 0xc_e3fe); /* call 0x10165d52 */
            ii(0x1009_7954, 1); push(esi);                              /* push esi */
            ii(0x1009_7955, 1); push(edi);                              /* push edi */
            ii(0x1009_7956, 1); push(ebp);                              /* push ebp */
            ii(0x1009_7957, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_7959, 6); sub(esp, 0x50);                         /* sub esp, 0x50 */
            ii(0x1009_795f, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_7962, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1009_7965, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1009_7968, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x1009_796b, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_796e, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_0e83); /* call 0x10076af0 */
            ii(0x1009_7973, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1009_7978, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_797b, 1); push(eax);                              /* push eax */
            ii(0x1009_797c, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x1009_7982, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_7985, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_7987, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_7989, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_798c, 5); call(0x1008_b148, -0xc849);             /* call 0x1008b148 */
            ii(0x1009_7991, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x1009_7994, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_0ea9); /* call 0x10076af0 */
        l_0x1009_7999:
            ii(0x1009_7999, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_799c, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_799f, 5); call(0x1008_b1a4, -0xc800);             /* call 0x1008b1a4 */
            ii(0x1009_79a4, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_79a7, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_79aa, 5); call(0x1010_82ce, 0x7_091f);            /* call 0x101082ce */
            ii(0x1009_79af, 2); test(al, al);                           /* test al, al */
            ii(0x1009_79b1, 2); if(jnz(0x1009_79bf, 0xc)) goto l_0x1009_79bf; /* jnz 0x100979bf */
            ii(0x1009_79b3, 7); mov(memd[ss, ebp - 0x2c], 0x3e8);       /* mov dword [ebp-0x2c], 0x3e8 */
            ii(0x1009_79ba, 5); jmp(0x1009_7c8c, 0x2cd); goto l_0x1009_7c8c; /* jmp 0x10097c8c */
        l_0x1009_79bf:
            ii(0x1009_79bf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_79c2, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_79c5, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_79c8, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1009_79cb, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_79cd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_79d0, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_79d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_79d5, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_79d7, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_79d9, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_79db, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_79e0, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x1009_79e3, 2); if(jz(0x1009_7a09, 0x24)) goto l_0x1009_7a09; /* jz 0x10097a09 */
            ii(0x1009_79e5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_79e8, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1009_79eb, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x1009_79ee, 3); add(edx, memd[ss, ebp - 0x10]);         /* add edx, [ebp-0x10] */
            ii(0x1009_79f1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_79f4, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_79f6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_79f9, 2); mov(edx, memd[ds, edx]);                /* mov edx, [edx] */
            ii(0x1009_79fb, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_79fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_79ff, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1009_7a01, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1009_7a05, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1009_7a07, 2); if(jnz(0x1009_7a0b, 0x2)) goto l_0x1009_7a0b; /* jnz 0x10097a0b */
        l_0x1009_7a09:
            ii(0x1009_7a09, 2); jmp(0x1009_7999, -0x72); goto l_0x1009_7999; /* jmp 0x10097999 */
        l_0x1009_7a0b:
            ii(0x1009_7a0b, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7a0e, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_7a11, 5); call(0x1008_8b44, -0xeed2);             /* call 0x10088b44 */
        l_0x1009_7a16:
            ii(0x1009_7a16, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_7a1a, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7a1d, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7a20, 4); movsx(edx, memw[ss, ebp - 0x12]);       /* movsx edx, word [ebp-0x12] */
            ii(0x1009_7a24, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7a26, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7a28, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7a2a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7a2f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_7a31, 2); if(jnz(0x1009_7a4d, 0x1a)) goto l_0x1009_7a4d; /* jnz 0x10097a4d */
            ii(0x1009_7a33, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_7a37, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1009_7a3a, 3); lea(eax, memd[ss, ebp - 0x30]);         /* lea eax, [ebp-0x30] */
            ii(0x1009_7a3d, 5); call(0x1007_5e64, -0x2_1bde);           /* call 0x10075e64 */
            ii(0x1009_7a42, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_7a44, 5); call(0x1008_b934, -0xc115);             /* call 0x1008b934 */
            ii(0x1009_7a49, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7a4b, 2); if(jz(0x1009_7a4f, 0x2)) goto l_0x1009_7a4f; /* jz 0x10097a4f */
        l_0x1009_7a4d:
            ii(0x1009_7a4d, 2); jmp(0x1009_7a66, 0x17); goto l_0x1009_7a66; /* jmp 0x10097a66 */
        l_0x1009_7a4f:
            ii(0x1009_7a4f, 4); movsx(edx, memw[ss, ebp - 0x12]);       /* movsx edx, word [ebp-0x12] */
            ii(0x1009_7a53, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_7a57, 5); call(0x1007_3d48, -0x2_3d14);           /* call 0x10073d48 */
            ii(0x1009_7a5c, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1009_7a61, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1009_7a64, 2); if(jnz(0x1009_7a6b, 0x5)) goto l_0x1009_7a6b; /* jnz 0x10097a6b */
        l_0x1009_7a66:
            ii(0x1009_7a66, 5); jmp(0x1009_7bf6, 0x18b); goto l_0x1009_7bf6; /* jmp 0x10097bf6 */
        l_0x1009_7a6b:
            ii(0x1009_7a6b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_7a6e, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_7a71, 5); call(0x1008_b1a4, -0xc8d2);             /* call 0x1008b1a4 */
            ii(0x1009_7a76, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1009_7a79, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_7a7c, 5); call(0x1010_82ce, 0x7_084d);            /* call 0x101082ce */
            ii(0x1009_7a81, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7a83, 2); if(jnz(0x1009_7a91, 0xc)) goto l_0x1009_7a91; /* jnz 0x10097a91 */
            ii(0x1009_7a85, 7); mov(memd[ss, ebp - 0x2c], 0x3e8);       /* mov dword [ebp-0x2c], 0x3e8 */
            ii(0x1009_7a8c, 5); jmp(0x1009_7c8c, 0x1fb); goto l_0x1009_7c8c; /* jmp 0x10097c8c */
        l_0x1009_7a91:
            ii(0x1009_7a91, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7a94, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_7a97, 5); call(/* sys */ 0x1016_5df8, 0xc_e35c);  /* call 0x10165df8 */
            ii(0x1009_7a9c, 3); mov(edx, memd[ss, ebp - 0x12]);         /* mov edx, [ebp-0x12] */
            ii(0x1009_7a9f, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_7aa1, 4); mov(memw[ss, ebp - 0x26], dx);          /* mov [ebp-0x26], dx */
            ii(0x1009_7aa5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7aa8, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7aaa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_7aad, 5); call(/* sys */ 0x1016_5df8, 0xc_e346);  /* call 0x10165df8 */
            ii(0x1009_7ab2, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1009_7ab5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1009_7ab7, 4); mov(memw[ss, ebp - 0x28], dx);          /* mov [ebp-0x28], dx */
            ii(0x1009_7abb, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x1009_7abe, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_7ac1, 5); call(0x1010_82ce, 0x7_0808);            /* call 0x101082ce */
            ii(0x1009_7ac6, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7ac8, 6); if(jz(0x1009_7b41, 0x73)) goto l_0x1009_7b41; /* jz 0x10097b41 */
            ii(0x1009_7ace, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_7ad2, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7ad5, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7ad8, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1009_7adc, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7ade, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7ae0, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7ae2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7ae7, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1009_7aea, 2); if(jz(0x1009_7b15, 0x29)) goto l_0x1009_7b15; /* jz 0x10097b15 */
            ii(0x1009_7aec, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_7af0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7af3, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7af6, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1009_7afa, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7afc, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7afe, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7b00, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7b05, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1009_7b08, 2); if(jnz(0x1009_7b13, 0x9)) goto l_0x1009_7b13; /* jnz 0x10097b13 */
            ii(0x1009_7b0a, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1009_7b0e, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_7b11, 2); if(jz(0x1009_7b15, 0x2)) goto l_0x1009_7b15; /* jz 0x10097b15 */
        l_0x1009_7b13:
            ii(0x1009_7b13, 2); jmp(0x1009_7b41, 0x2c); goto l_0x1009_7b41; /* jmp 0x10097b41 */
        l_0x1009_7b15:
            ii(0x1009_7b15, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7b18, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1009_7b1b, 5); call(0x1007_5e64, -0x2_1cbc);           /* call 0x10075e64 */
            ii(0x1009_7b20, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7b22, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1009_7b25, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x1009_7b28, 5); call(0x1007_5e64, -0x2_1cc9);           /* call 0x10075e64 */
            ii(0x1009_7b2d, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_7b2f, 5); call(0x100a_5fca, 0xe496);              /* call 0x100a5fca */
            ii(0x1009_7b34, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_7b39, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_7b3c, 5); jmp(0x1009_7c8c, 0x14b); goto l_0x1009_7c8c; /* jmp 0x10097c8c */
        l_0x1009_7b41:
            ii(0x1009_7b41, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7b44, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x1009_7b47, 5); call(/* sys */ 0x1016_5df8, 0xc_e2ac);  /* call 0x10165df8 */
            ii(0x1009_7b4c, 3); mov(edx, memd[ss, ebp - 0x12]);         /* mov edx, [ebp-0x12] */
            ii(0x1009_7b4f, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1009_7b51, 4); mov(memw[ss, ebp - 0x26], dx);          /* mov [ebp-0x26], dx */
            ii(0x1009_7b55, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_7b58, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7b5a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_7b5d, 5); call(/* sys */ 0x1016_5df8, 0xc_e296);  /* call 0x10165df8 */
            ii(0x1009_7b62, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1009_7b65, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x1009_7b67, 4); mov(memw[ss, ebp - 0x28], dx);          /* mov [ebp-0x28], dx */
            ii(0x1009_7b6b, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x1009_7b6e, 3); lea(eax, memd[ss, ebp - 0x24]);         /* lea eax, [ebp-0x24] */
            ii(0x1009_7b71, 5); call(0x1010_82ce, 0x7_0758);            /* call 0x101082ce */
            ii(0x1009_7b76, 2); test(al, al);                           /* test al, al */
            ii(0x1009_7b78, 6); if(jz(0x1009_7bf1, 0x73)) goto l_0x1009_7bf1; /* jz 0x10097bf1 */
            ii(0x1009_7b7e, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_7b82, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7b85, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7b88, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1009_7b8c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7b8e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7b90, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7b92, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7b97, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1009_7b9a, 2); if(jz(0x1009_7bc5, 0x29)) goto l_0x1009_7bc5; /* jz 0x10097bc5 */
            ii(0x1009_7b9c, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x1009_7ba0, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7ba3, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7ba6, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x1009_7baa, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7bac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7bae, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7bb0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7bb5, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1009_7bb8, 2); if(jnz(0x1009_7bc3, 0x9)) goto l_0x1009_7bc3; /* jnz 0x10097bc3 */
            ii(0x1009_7bba, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1009_7bbe, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_7bc1, 2); if(jz(0x1009_7bc5, 0x2)) goto l_0x1009_7bc5; /* jz 0x10097bc5 */
        l_0x1009_7bc3:
            ii(0x1009_7bc3, 2); jmp(0x1009_7bf1, 0x2c); goto l_0x1009_7bf1; /* jmp 0x10097bf1 */
        l_0x1009_7bc5:
            ii(0x1009_7bc5, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7bc8, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x1009_7bcb, 5); call(0x1007_5e64, -0x2_1d6c);           /* call 0x10075e64 */
            ii(0x1009_7bd0, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7bd2, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1009_7bd5, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x1009_7bd8, 5); call(0x1007_5e64, -0x2_1d79);           /* call 0x10075e64 */
            ii(0x1009_7bdd, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_7bdf, 5); call(0x100a_5fca, 0xe3e6);              /* call 0x100a5fca */
            ii(0x1009_7be4, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_7be9, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_7bec, 5); jmp(0x1009_7c8c, 0x9b); goto l_0x1009_7c8c; /* jmp 0x10097c8c */
        l_0x1009_7bf1:
            ii(0x1009_7bf1, 5); jmp(0x1009_7a16, -0x1e0); goto l_0x1009_7a16; /* jmp 0x10097a16 */
        l_0x1009_7bf6:
            ii(0x1009_7bf6, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_7bfa, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7bfd, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7c00, 4); movsx(edx, memw[ss, ebp - 0x12]);       /* movsx edx, word [ebp-0x12] */
            ii(0x1009_7c04, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7c06, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7c08, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7c0a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7c0f, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1009_7c12, 2); if(jnz(0x1009_7c38, 0x24)) goto l_0x1009_7c38; /* jnz 0x10097c38 */
            ii(0x1009_7c14, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7c17, 3); lea(eax, memd[ss, ebp - 0x44]);         /* lea eax, [ebp-0x44] */
            ii(0x1009_7c1a, 5); call(0x1007_5e64, -0x2_1dbb);           /* call 0x10075e64 */
            ii(0x1009_7c1f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7c21, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1009_7c24, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1009_7c27, 5); call(0x1007_5e64, -0x2_1dc8);           /* call 0x10075e64 */
            ii(0x1009_7c2c, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_7c2e, 5); call(0x100a_5fca, 0xe397);              /* call 0x100a5fca */
            ii(0x1009_7c33, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_7c36, 2); jmp(0x1009_7c8c, 0x54); goto l_0x1009_7c8c; /* jmp 0x10097c8c */
        l_0x1009_7c38:
            ii(0x1009_7c38, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1009_7c3c, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_7c3f, 3); add(eax, memd[ss, ebp - 0x10]);         /* add eax, [ebp-0x10] */
            ii(0x1009_7c42, 4); movsx(edx, memw[ss, ebp - 0x12]);       /* movsx edx, word [ebp-0x12] */
            ii(0x1009_7c46, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1009_7c48, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1009_7c4a, 2); mov(al, memb[ds, eax]);                 /* mov al, [eax] */
            ii(0x1009_7c4c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1009_7c51, 3); cmp(eax, 0x5);                          /* cmp eax, 0x5 */
            ii(0x1009_7c54, 2); if(jnz(0x1009_7c5f, 0x9)) goto l_0x1009_7c5f; /* jnz 0x10097c5f */
            ii(0x1009_7c56, 4); movsx(eax, memw[ss, ebp + 0x10]);       /* movsx eax, word [ebp+0x10] */
            ii(0x1009_7c5a, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1009_7c5d, 2); if(jz(0x1009_7c61, 0x2)) goto l_0x1009_7c61; /* jz 0x10097c61 */
        l_0x1009_7c5f:
            ii(0x1009_7c5f, 2); jmp(0x1009_7c85, 0x24); goto l_0x1009_7c85; /* jmp 0x10097c85 */
        l_0x1009_7c61:
            ii(0x1009_7c61, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_7c64, 3); lea(eax, memd[ss, ebp - 0x4c]);         /* lea eax, [ebp-0x4c] */
            ii(0x1009_7c67, 5); call(0x1007_5e64, -0x2_1e08);           /* call 0x10075e64 */
            ii(0x1009_7c6c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1009_7c6e, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x1009_7c71, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x1009_7c74, 5); call(0x1007_5e64, -0x2_1e15);           /* call 0x10075e64 */
            ii(0x1009_7c79, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1009_7c7b, 5); call(0x100a_5fca, 0xe34a);              /* call 0x100a5fca */
            ii(0x1009_7c80, 3); mov(memd[ss, ebp - 0x2c], eax);         /* mov [ebp-0x2c], eax */
            ii(0x1009_7c83, 2); jmp(0x1009_7c8c, 0x7); goto l_0x1009_7c8c; /* jmp 0x10097c8c */
        l_0x1009_7c85:
            ii(0x1009_7c85, 7); mov(memd[ss, ebp - 0x2c], 0x3e8);       /* mov dword [ebp-0x2c], 0x3e8 */
        l_0x1009_7c8c:
            ii(0x1009_7c8c, 3); mov(eax, memd[ss, ebp - 0x2c]);         /* mov eax, [ebp-0x2c] */
            ii(0x1009_7c8f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_7c91, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_7c92, 1); pop(edi);                               /* pop edi */
            ii(0x1009_7c93, 1); pop(esi);                               /* pop esi */
            ii(0x1009_7c94, 3); ret(0x4);                               /* ret 0x4 */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bf2a8bc2-24a2-463b-9ef8-861ae31217a1")]
        public void Method_100c_993c()
        {
            ii(0x100c_993c, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x100c_9941, 5); calld(Definitions.sys_check_available_stack_size, 0x9_c40c); /* call 0x10165d52 */
            ii(0x100c_9946, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_9947, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_9948, 1); pushd(esi);                             /* push esi */
            ii(0x100c_9949, 1); pushd(edi);                             /* push edi */
            ii(0x100c_994a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_994b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_994d, 6); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x100c_9953, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_9956, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_9959, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_995c, 5); calld(0x1007_623c, -0x5_3725);          /* call 0x1007623c */
            ii(0x100c_9961, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_9964, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9967, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100c_996a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_996d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9970, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100c_9973, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_9976, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100c_9979, 5); calld(0x1007_6aac, -0x5_2ed2);          /* call 0x10076aac */
            ii(0x100c_997e, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_9981, 4); mov(ax, memw_a32[ds, eax + 0x12]);      /* mov ax, [eax+0x12] */
            ii(0x100c_9985, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_9988, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_998b, 5); cmp(memw_a32[ds, eax + 0x8], 0x47);     /* cmp word [eax+0x8], 0x47 */
            ii(0x100c_9990, 2); if(jzd(0x100c_999c, 0xa)) goto l_0x100c_999c; /* jz 0x100c999c */
            ii(0x100c_9992, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_9995, 5); cmp(memw_a32[ds, eax + 0x8], 0x45);     /* cmp word [eax+0x8], 0x45 */
            ii(0x100c_999a, 2); if(jnzd(0x100c_99a2, 0x6)) goto l_0x100c_99a2; /* jnz 0x100c99a2 */
        l_0x100c_999c:
            ii(0x100c_999c, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_99a0, 2); jmpd(0x100c_99a6, 0x4); goto l_0x100c_99a6; /* jmp 0x100c99a6 */
        l_0x100c_99a2:
            ii(0x100c_99a2, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
        l_0x100c_99a6:
            ii(0x100c_99a6, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100c_99a9, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100c_99ac, 4); cmp(memb_a32[ss, ebp - 0x10], 0);       /* cmp byte [ebp-0x10], 0x0 */
            ii(0x100c_99b0, 6); if(jzd(0x100c_9a2e, 0x78)) goto l_0x100c_9a2e; /* jz 0x100c9a2e */
            ii(0x100c_99b6, 4); movsx(ebx, memw_a32[ss, ebp - 0x14]);   /* movsx ebx, word [ebp-0x14] */
            ii(0x100c_99ba, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100c_99bd, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100c_99c0, 5); calld(0x1007_5e64, -0x5_3b61);          /* call 0x10075e64 */
            ii(0x100c_99c5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_99c7, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_99ca, 5); calld(0x100a_95c1, -0x2_040e);          /* call 0x100a95c1 */
        l_0x100c_99cf:
            ii(0x100c_99cf, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_99d2, 5); calld(0x1008_982c, -0x4_01ab);          /* call 0x1008982c */
            ii(0x100c_99d7, 1); cwde();                                 /* cwde */
            ii(0x100c_99d8, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100c_99de, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_99e1, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_99e4, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_99e7, 5); calld(0x1008_9860, -0x4_018c);          /* call 0x10089860 */
            ii(0x100c_99ec, 1); cwde();                                 /* cwde */
            ii(0x100c_99ed, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_99ef, 6); mov(edx, memd_a32[ds, 0x101c_9454]);    /* mov edx, [0x101c9454] */
            ii(0x100c_99f5, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_99f7, 3); test(memb_a32[ds, eax], 0x6);           /* test byte [eax], 0x6 */
            ii(0x100c_99fa, 2); if(jzd(0x100c_9a1d, 0x21)) goto l_0x100c_9a1d; /* jz 0x100c9a1d */
            ii(0x100c_99fc, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_99ff, 5); calld(0x1008_9860, -0x4_01a4);          /* call 0x10089860 */
            ii(0x100c_9a04, 1); cwde();                                 /* cwde */
            ii(0x100c_9a05, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_9a08, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_9a0b, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_9a0d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_9a10, 5); calld(0x1008_982c, -0x4_01e9);          /* call 0x1008982c */
            ii(0x100c_9a15, 1); cwde();                                 /* cwde */
            ii(0x100c_9a16, 2); mov(edx, memd_a32[ds, edx]);            /* mov edx, [edx] */
            ii(0x100c_9a18, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100c_9a1a, 3); mov(memb_a32[ds, eax], 0);              /* mov byte [eax], 0x0 */
        l_0x100c_9a1d:
            ii(0x100c_9a1d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100c_9a20, 5); calld(0x100a_96db, -0x2_034a);          /* call 0x100a96db */
            ii(0x100c_9a25, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9a27, 2); if(jnzd(0x100c_99cf, -0x5a)) goto l_0x100c_99cf; /* jnz 0x100c99cf */
            ii(0x100c_9a29, 5); jmpd(0x100c_9b3a, 0x10c); goto l_0x100c_9b3a; /* jmp 0x100c9b3a */
        l_0x100c_9a2e:
            ii(0x100c_9a2e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x100c_9a31, 5); calld(Definitions.my_ctor_0x101b4184, -0x5_2f46); /* call 0x10076af0 */
            ii(0x100c_9a36, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x100c_9a39, 5); calld(Definitions.my_ctor_0x101b4184, -0x5_2f4e); /* call 0x10076af0 */
            ii(0x100c_9a3e, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_9a41, 4); imul(eax, memd_a32[ss, ebp - 0x14]);    /* imul eax, [ebp-0x14] */
            ii(0x100c_9a45, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100c_9a48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9a4a, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100c_9a4e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_9a52, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100c_9a54, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100c_9a56, 5); calld(0x1007_6e7c, -0x5_2bdf);          /* call 0x10076e7c */
            ii(0x100c_9a5b, 4); mov(memw_a32[ss, ebp - 0x34], ax);      /* mov [ebp-0x34], ax */
            ii(0x100c_9a5f, 5); mov(eax, memd_a32[ds, 0x101c_8170]);    /* mov eax, [0x101c8170] */
            ii(0x100c_9a64, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_9a67, 3); lea(edx, eax - 0x1);                    /* lea edx, [eax-0x1] */
            ii(0x100c_9a6a, 4); movsx(ebx, memw_a32[ss, ebp - 0x18]);   /* movsx ebx, word [ebp-0x18] */
            ii(0x100c_9a6e, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100c_9a72, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_9a74, 5); calld(Definitions.my_min, -0x4_02f5);   /* call 0x10089784 */
            ii(0x100c_9a79, 4); mov(memw_a32[ss, ebp - 0x38], ax);      /* mov [ebp-0x38], ax */
        l_0x100c_9a7d:
            ii(0x100c_9a7d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100c_9a80, 4); cmp(ax, memw_a32[ss, ebp - 0x38]);      /* cmp ax, [ebp-0x38] */
            ii(0x100c_9a84, 6); if(jgd(0x100c_9b3a, 0xb0)) goto l_0x100c_9b3a; /* jg 0x100c9b3a */
            ii(0x100c_9a8a, 3); mov(edx, memd_a32[ss, ebp - 0x34]);     /* mov edx, [ebp-0x34] */
            ii(0x100c_9a8d, 3); sub(edx, memd_a32[ss, ebp - 0x18]);     /* sub edx, [ebp-0x18] */
            ii(0x100c_9a90, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100c_9a93, 3); sub(eax, memd_a32[ss, ebp - 0x18]);     /* sub eax, [ebp-0x18] */
            ii(0x100c_9a96, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_9a99, 3); mov(memd_a32[ss, ebp - 0x40], edx);     /* mov [ebp-0x40], edx */
            ii(0x100c_9a9c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_9a9f, 4); mov(memw_a32[ss, ebp - 0x32], ax);      /* mov [ebp-0x32], ax */
            ii(0x100c_9aa3, 2); jmpd(0x100c_9aac, 0x7); goto l_0x100c_9aac; /* jmp 0x100c9aac */
        l_0x100c_9aa5:
            ii(0x100c_9aa5, 3); mov(eax, memd_a32[ss, ebp - 0x32]);     /* mov eax, [ebp-0x32] */
            ii(0x100c_9aa8, 4); dec(memw_a32[ss, ebp - 0x32]);          /* dec word [ebp-0x32] */
        l_0x100c_9aac:
            ii(0x100c_9aac, 4); movsx(eax, memw_a32[ss, ebp - 0x32]);   /* movsx eax, word [ebp-0x32] */
            ii(0x100c_9ab0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_9ab2, 2); if(jld(0x100c_9acd, 0x19)) goto l_0x100c_9acd; /* jl 0x100c9acd */
            ii(0x100c_9ab4, 4); movsx(edx, memw_a32[ss, ebp - 0x32]);   /* movsx edx, word [ebp-0x32] */
            ii(0x100c_9ab8, 4); movsx(eax, memw_a32[ss, ebp - 0x32]);   /* movsx eax, word [ebp-0x32] */
            ii(0x100c_9abc, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x100c_9abf, 4); movsx(eax, memw_a32[ss, ebp - 0x40]);   /* movsx eax, word [ebp-0x40] */
            ii(0x100c_9ac3, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100c_9ac5, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100c_9ac9, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_9acb, 2); if(jgd(0x100c_9aa5, -0x28)) goto l_0x100c_9aa5; /* jg 0x100c9aa5 */
        l_0x100c_9acd:
            ii(0x100c_9acd, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100c_9ad3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_9ad6, 1); dec(edx);                               /* dec edx */
            ii(0x100c_9ad7, 4); movsx(ebx, memw_a32[ss, ebp - 0x16]);   /* movsx ebx, word [ebp-0x16] */
            ii(0x100c_9adb, 4); movsx(eax, memw_a32[ss, ebp - 0x32]);   /* movsx eax, word [ebp-0x32] */
            ii(0x100c_9adf, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100c_9ae1, 5); calld(Definitions.my_min, -0x4_0362);   /* call 0x10089784 */
            ii(0x100c_9ae6, 4); mov(memw_a32[ss, ebp - 0x36], ax);      /* mov [ebp-0x36], ax */
            ii(0x100c_9aea, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9aec, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x100c_9af0, 4); movsx(ebx, memw_a32[ss, ebp - 0x32]);   /* movsx ebx, word [ebp-0x32] */
            ii(0x100c_9af4, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x100c_9af6, 5); calld(0x1007_6e7c, -0x5_2c7f);          /* call 0x10076e7c */
            ii(0x100c_9afb, 4); mov(memw_a32[ss, ebp - 0x32], ax);      /* mov [ebp-0x32], ax */
            ii(0x100c_9aff, 3); mov(eax, memd_a32[ss, ebp - 0x36]);     /* mov eax, [ebp-0x36] */
            ii(0x100c_9b02, 4); cmp(ax, memw_a32[ss, ebp - 0x32]);      /* cmp ax, [ebp-0x32] */
            ii(0x100c_9b06, 2); if(jld(0x100c_9b2e, 0x26)) goto l_0x100c_9b2e; /* jl 0x100c9b2e */
            ii(0x100c_9b08, 4); movsx(eax, memw_a32[ss, ebp - 0x36]);   /* movsx eax, word [ebp-0x36] */
            ii(0x100c_9b0c, 4); movsx(edx, memw_a32[ss, ebp - 0x32]);   /* movsx edx, word [ebp-0x32] */
            ii(0x100c_9b10, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_9b12, 3); lea(ebx, eax + 0x1);                    /* lea ebx, [eax+0x1] */
            ii(0x100c_9b15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_9b17, 4); movsx(eax, memw_a32[ss, ebp - 0x34]);   /* movsx eax, word [ebp-0x34] */
            ii(0x100c_9b1b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100c_9b1e, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x100c_9b21, 4); movsx(ecx, memw_a32[ss, ebp - 0x32]);   /* movsx ecx, word [ebp-0x32] */
            ii(0x100c_9b25, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100c_9b27, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x100c_9b29, 5); calld(Definitions.sys_memset, 0x9_c2b2); /* call 0x10165de0 */
        l_0x100c_9b2e:
            ii(0x100c_9b2e, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100c_9b31, 4); inc(memw_a32[ss, ebp - 0x34]);          /* inc word [ebp-0x34] */
            ii(0x100c_9b35, 5); jmpd(0x100c_9a7d, -0xbd); goto l_0x100c_9a7d; /* jmp 0x100c9a7d */
        l_0x100c_9b3a:
            ii(0x100c_9b3a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9b3c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_9b3d, 1); popd(edi);                              /* pop edi */
            ii(0x100c_9b3e, 1); popd(esi);                              /* pop esi */
            ii(0x100c_9b3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_9b40, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_9b41, 1); retd(); return;                         /* ret */
        }
    }
}

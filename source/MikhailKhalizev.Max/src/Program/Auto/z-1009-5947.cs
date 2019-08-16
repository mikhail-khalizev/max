using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6ec5d28d-a48a-4da2-b7b6-b678b6f57842")]
        public void Method_1009_5947()
        {
            ii(0x1009_5947, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1009_594c, 5); calld(Definitions.sys_check_available_stack_size, 0xd_0401); /* call 0x10165d52 */
            ii(0x1009_5951, 1); pushd(esi);                             /* push esi */
            ii(0x1009_5952, 1); pushd(edi);                             /* push edi */
            ii(0x1009_5953, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_5954, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_5956, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1009_595c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_595f, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_5962, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_5965, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_5968, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_596b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_596e, 5); calld(0x1007_6338, -0x1_f63b);          /* call 0x10076338 */
            ii(0x1009_5973, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x1009_5976, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5978, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_597a, 5); calld(0x1007_64b8, -0x1_f4c7);          /* call 0x100764b8 */
            ii(0x1009_597f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1009_5982, 5); calld(Definitions.my_ctor_0x101b_4184, -0x1_ee97); /* call 0x10076af0 */
            ii(0x1009_5987, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_598a, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_598d, 5); calld(0x1007_6338, -0x1_f65a);          /* call 0x10076338 */
            ii(0x1009_5992, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5994, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5997, 5); calld(0x1007_643c, -0x1_f560);          /* call 0x1007643c */
            ii(0x1009_599c, 2); jmpd(0x1009_59a6, 0x8); goto l_0x1009_59a6; /* jmp 0x100959a6 */
        l_0x1009_599e:
            ii(0x1009_599e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_59a1, 5); calld(0x1007_6bf8, -0x1_edae);          /* call 0x10076bf8 */
        l_0x1009_59a6:
            ii(0x1009_59a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_59a8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_59ab, 5); calld(0x1013_ad71, 0xa_53c1);           /* call 0x1013ad71 */
            ii(0x1009_59b0, 2); test(al, al);                           /* test al, al */
            ii(0x1009_59b2, 6); if(jzd(0x1009_5b06, 0x14e)) goto l_0x1009_5b06; /* jz 0x10095b06 */
            ii(0x1009_59b8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_59bb, 5); calld(0x1007_63a0, -0x1_f620);          /* call 0x100763a0 */
            ii(0x1009_59c0, 4); test(memb_a32[ds, eax + 0x12], 0x10);   /* test byte [eax+0x12], 0x10 */
            ii(0x1009_59c4, 2); if(jnzd(0x1009_59d9, 0x13)) goto l_0x1009_59d9; /* jnz 0x100959d9 */
            ii(0x1009_59c6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_59c9, 5); calld(0x1007_63a0, -0x1_f62e);          /* call 0x100763a0 */
            ii(0x1009_59ce, 5); cmp(memw_a32[ds, eax + 0x8], 0x5);      /* cmp word [eax+0x8], 0x5 */
            ii(0x1009_59d3, 6); if(jnzd(0x1009_5b01, 0x128)) goto l_0x1009_5b01; /* jnz 0x10095b01 */
        l_0x1009_59d9:
            ii(0x1009_59d9, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_59dc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_59df, 5); calld(0x1007_63a0, -0x1_f644);          /* call 0x100763a0 */
            ii(0x1009_59e4, 5); calld(0x1015_2532, 0xb_cb49);           /* call 0x10152532 */
            ii(0x1009_59e9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1009_59ee, 1); pushd(eax);                             /* push eax */
            ii(0x1009_59ef, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_59f2, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_59f7, 1); cwde();                                 /* cwde */
            ii(0x1009_59f8, 1); pushd(eax);                             /* push eax */
            ii(0x1009_59f9, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_59fc, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_5a01, 1); cwde();                                 /* cwde */
            ii(0x1009_5a02, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5a03, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5a06, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1009_5a09, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_5a0c, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5a0f, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1009_5a12, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_5a15, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5a18, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5a1b, 5); calld(0x1009_0aaa, -0x4f76);            /* call 0x10090aaa */
            ii(0x1009_5a20, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_5a22, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5a23, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_5a26, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5a27, 1); cwde();                                 /* cwde */
            ii(0x1009_5a28, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5a29, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_5a2c, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5a2d, 1); cwde();                                 /* cwde */
            ii(0x1009_5a2e, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5a2f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5a32, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5a33, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_5a36, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5a39, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5a3a, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_5a3d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5a40, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5a43, 5); calld(0x1009_0aaa, -0x4f9e);            /* call 0x10090aaa */
            ii(0x1009_5a48, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5a4a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5a4d, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1009_5a50, 5); calld(0x1007_6e7c, -0x1_ebd9);          /* call 0x10076e7c */
            ii(0x1009_5a55, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_5a58, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1009_5a5e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_5a61, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_5a64, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_5a67, 5); calld(Definitions.my_min, -0xc2e8);     /* call 0x10089784 */
            ii(0x1009_5a6c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_5a6f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5a71, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5a74, 3); sub(eax, 0x2);                          /* sub eax, 0x2 */
            ii(0x1009_5a77, 5); calld(0x1007_6e7c, -0x1_ec00);          /* call 0x10076e7c */
            ii(0x1009_5a7c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_5a7f, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x1009_5a85, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_5a88, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_5a8b, 3); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x1009_5a8e, 5); calld(Definitions.my_min, -0xc30f);     /* call 0x10089784 */
            ii(0x1009_5a93, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_5a96, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5a99, 5); calld(0x1007_63a0, -0x1_f6fe);          /* call 0x100763a0 */
            ii(0x1009_5a9e, 5); cmp(memw_a32[ds, eax + 0x8], 0x5);      /* cmp word [eax+0x8], 0x5 */
            ii(0x1009_5aa3, 2); if(jnzd(0x1009_5aae, 0x9)) goto l_0x1009_5aae; /* jnz 0x10095aae */
            ii(0x1009_5aa5, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1009_5aa8, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5aa9, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1009_5aac, 2); jmpd(0x1009_5ab4, 0x6); goto l_0x1009_5ab4; /* jmp 0x10095ab4 */
        l_0x1009_5aae:
            ii(0x1009_5aae, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1009_5ab1, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x1009_5ab4:
            ii(0x1009_5ab4, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5ab7, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1009_5abb, 2); jmpd(0x1009_5ac4, 0x7); goto l_0x1009_5ac4; /* jmp 0x10095ac4 */
        l_0x1009_5abd:
            ii(0x1009_5abd, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_5ac0, 4); inc(memw_a32[ss, ebp - 0x18]);          /* inc word [ebp-0x18] */
        l_0x1009_5ac4:
            ii(0x1009_5ac4, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_5ac8, 3); cmp(eax, memd_a32[ss, ebp - 0x20]);     /* cmp eax, [ebp-0x20] */
            ii(0x1009_5acb, 2); if(jged(0x1009_5b01, 0x34)) goto l_0x1009_5b01; /* jge 0x10095b01 */
            ii(0x1009_5acd, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5ad0, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1009_5ad4, 2); jmpd(0x1009_5add, 0x7); goto l_0x1009_5add; /* jmp 0x10095add */
        l_0x1009_5ad6:
            ii(0x1009_5ad6, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1009_5ad9, 4); inc(memw_a32[ss, ebp - 0x16]);          /* inc word [ebp-0x16] */
        l_0x1009_5add:
            ii(0x1009_5add, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x1009_5ae1, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x1009_5ae4, 2); if(jged(0x1009_5aff, 0x19)) goto l_0x1009_5aff; /* jge 0x10095aff */
            ii(0x1009_5ae6, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_5aea, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_5aed, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_5af0, 4); movsx(ebx, memw_a32[ss, ebp - 0x16]);   /* movsx ebx, word [ebp-0x16] */
            ii(0x1009_5af4, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_5af6, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1009_5af8, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x1009_5afb, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1009_5afd, 2); jmpd(0x1009_5ad6, -0x29); goto l_0x1009_5ad6; /* jmp 0x10095ad6 */
        l_0x1009_5aff:
            ii(0x1009_5aff, 2); jmpd(0x1009_5abd, -0x44); goto l_0x1009_5abd; /* jmp 0x10095abd */
        l_0x1009_5b01:
            ii(0x1009_5b01, 5); jmpd(0x1009_599e, -0x168); goto l_0x1009_599e; /* jmp 0x1009599e */
        l_0x1009_5b06:
            ii(0x1009_5b06, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5b09, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_5b0c, 5); calld(0x1009_c6c8, 0x6bb7);             /* call 0x1009c6c8 */
            ii(0x1009_5b11, 3); lea(ebx, ebp - 0x30);                   /* lea ebx, [ebp-0x30] */
            ii(0x1009_5b14, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_5b16, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_5b18, 5); calld(0x1009_c5dc, 0x6abf);             /* call 0x1009c5dc */
            ii(0x1009_5b1d, 2); jmpd(0x1009_5b27, 0x8); goto l_0x1009_5b27; /* jmp 0x10095b27 */
        l_0x1009_5b1f:
            ii(0x1009_5b1f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b22, 5); calld(0x1007_6bf8, -0x1_ef2f);          /* call 0x10076bf8 */
        l_0x1009_5b27:
            ii(0x1009_5b27, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5b29, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b2c, 5); calld(0x1013_ad71, 0xa_5240);           /* call 0x1013ad71 */
            ii(0x1009_5b31, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5b33, 6); if(jzd(0x1009_5c95, 0x15c)) goto l_0x1009_5c95; /* jz 0x10095c95 */
            ii(0x1009_5b39, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b3c, 5); calld(0x1009_c4f8, 0x69b7);             /* call 0x1009c4f8 */
            ii(0x1009_5b41, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1009_5b44, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_5b47, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_5b4a, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1009_5b4d, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x1009_5b50, 2); test(al, al);                           /* test al, al */
            ii(0x1009_5b52, 2); if(jzd(0x1009_5b61, 0xd)) goto l_0x1009_5b61; /* jz 0x10095b61 */
            ii(0x1009_5b54, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b57, 5); calld(0x1009_c52c, 0x69d0);             /* call 0x1009c52c */
            ii(0x1009_5b5c, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1009_5b5f, 2); if(jnzd(0x1009_5b63, 0x2)) goto l_0x1009_5b63; /* jnz 0x10095b63 */
        l_0x1009_5b61:
            ii(0x1009_5b61, 2); jmpd(0x1009_5b92, 0x2f); goto l_0x1009_5b92; /* jmp 0x10095b92 */
        l_0x1009_5b63:
            ii(0x1009_5b63, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b66, 5); calld(0x1009_c4f8, 0x698d);             /* call 0x1009c4f8 */
            ii(0x1009_5b6b, 5); calld(0x1009_c4c4, 0x6954);             /* call 0x1009c4c4 */
            ii(0x1009_5b70, 1); cwde();                                 /* cwde */
            ii(0x1009_5b71, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1009_5b74, 7); test(memb_a32[ds, eax + 0x101c_81c0], 0x10); /* test byte [eax+0x101c81c0], 0x10 */
            ii(0x1009_5b7b, 2); if(jnzd(0x1009_5b90, 0x13)) goto l_0x1009_5b90; /* jnz 0x10095b90 */
            ii(0x1009_5b7d, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b80, 5); calld(0x1009_c4f8, 0x6973);             /* call 0x1009c4f8 */
            ii(0x1009_5b85, 5); calld(0x1009_c4c4, 0x693a);             /* call 0x1009c4c4 */
            ii(0x1009_5b8a, 4); cmp(ax, 0x5);                           /* cmp ax, 0x5 */
            ii(0x1009_5b8e, 2); if(jnzd(0x1009_5b92, 0x2)) goto l_0x1009_5b92; /* jnz 0x10095b92 */
        l_0x1009_5b90:
            ii(0x1009_5b90, 2); jmpd(0x1009_5b97, 0x5); goto l_0x1009_5b97; /* jmp 0x10095b97 */
        l_0x1009_5b92:
            ii(0x1009_5b92, 5); jmpd(0x1009_5c90, 0xf9); goto l_0x1009_5c90; /* jmp 0x10095c90 */
        l_0x1009_5b97:
            ii(0x1009_5b97, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5b9a, 5); calld(0x1009_c4f8, 0x6959);             /* call 0x1009c4f8 */
            ii(0x1009_5b9f, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1009_5ba2, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_5ba5, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_5ba8, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1009_5bab, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1009_5bae, 3); calld_abs(memd_a32[ds, ebx + 0x1c]);    /* call dword [ebx+0x1c] */
            ii(0x1009_5bb1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1009_5bb3, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5bb4, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_5bb7, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5bb8, 1); cwde();                                 /* cwde */
            ii(0x1009_5bb9, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5bba, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_5bbd, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5bbe, 1); cwde();                                 /* cwde */
            ii(0x1009_5bbf, 1); pushd(eax);                             /* push eax */
            ii(0x1009_5bc0, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5bc3, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5bc4, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_5bc7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5bca, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5bcb, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x1009_5bce, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1009_5bd1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_5bd4, 5); calld(0x1009_0aaa, -0x512f);            /* call 0x10090aaa */
            ii(0x1009_5bd9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5bdb, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5bde, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5bdf, 5); calld(0x1007_6e7c, -0x1_ed68);          /* call 0x10076e7c */
            ii(0x1009_5be4, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_5be7, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x1009_5bed, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_5bf0, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_5bf3, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5bf4, 5); calld(Definitions.my_min, -0xc475);     /* call 0x10089784 */
            ii(0x1009_5bf9, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_5bfc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5bfe, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5c01, 1); dec(eax);                               /* dec eax */
            ii(0x1009_5c02, 5); calld(0x1007_6e7c, -0x1_ed8b);          /* call 0x10076e7c */
            ii(0x1009_5c07, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1009_5c0a, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x1009_5c10, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_5c13, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_5c16, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5c17, 5); calld(Definitions.my_min, -0xc498);     /* call 0x10089784 */
            ii(0x1009_5c1c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_5c1f, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5c22, 5); calld(0x1009_c4f8, 0x68d1);             /* call 0x1009c4f8 */
            ii(0x1009_5c27, 5); calld(0x1009_c4c4, 0x6898);             /* call 0x1009c4c4 */
            ii(0x1009_5c2c, 4); cmp(ax, 0x5);                           /* cmp ax, 0x5 */
            ii(0x1009_5c30, 2); if(jnzd(0x1009_5c3c, 0xa)) goto l_0x1009_5c3c; /* jnz 0x10095c3c */
            ii(0x1009_5c32, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1009_5c35, 1); inc(eax);                               /* inc eax */
            ii(0x1009_5c36, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
            ii(0x1009_5c3a, 2); jmpd(0x1009_5c43, 0x7); goto l_0x1009_5c43; /* jmp 0x10095c43 */
        l_0x1009_5c3c:
            ii(0x1009_5c3c, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x1009_5c3f, 4); mov(memw_a32[ss, ebp - 0x2c], ax);      /* mov [ebp-0x2c], ax */
        l_0x1009_5c43:
            ii(0x1009_5c43, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x1009_5c46, 4); mov(memw_a32[ss, ebp - 0x18], ax);      /* mov [ebp-0x18], ax */
            ii(0x1009_5c4a, 2); jmpd(0x1009_5c53, 0x7); goto l_0x1009_5c53; /* jmp 0x10095c53 */
        l_0x1009_5c4c:
            ii(0x1009_5c4c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_5c4f, 4); inc(memw_a32[ss, ebp - 0x18]);          /* inc word [ebp-0x18] */
        l_0x1009_5c53:
            ii(0x1009_5c53, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_5c57, 3); cmp(eax, memd_a32[ss, ebp - 0x20]);     /* cmp eax, [ebp-0x20] */
            ii(0x1009_5c5a, 2); if(jged(0x1009_5c90, 0x34)) goto l_0x1009_5c90; /* jge 0x10095c90 */
            ii(0x1009_5c5c, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1009_5c5f, 4); mov(memw_a32[ss, ebp - 0x16], ax);      /* mov [ebp-0x16], ax */
            ii(0x1009_5c63, 2); jmpd(0x1009_5c6c, 0x7); goto l_0x1009_5c6c; /* jmp 0x10095c6c */
        l_0x1009_5c65:
            ii(0x1009_5c65, 3); mov(eax, memd_a32[ss, ebp - 0x16]);     /* mov eax, [ebp-0x16] */
            ii(0x1009_5c68, 4); inc(memw_a32[ss, ebp - 0x16]);          /* inc word [ebp-0x16] */
        l_0x1009_5c6c:
            ii(0x1009_5c6c, 4); movsx(eax, memw_a32[ss, ebp - 0x16]);   /* movsx eax, word [ebp-0x16] */
            ii(0x1009_5c70, 3); cmp(eax, memd_a32[ss, ebp - 0x1c]);     /* cmp eax, [ebp-0x1c] */
            ii(0x1009_5c73, 2); if(jged(0x1009_5c8e, 0x19)) goto l_0x1009_5c8e; /* jge 0x10095c8e */
            ii(0x1009_5c75, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1009_5c79, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1009_5c7c, 3); add(eax, memd_a32[ss, ebp - 0x8]);      /* add eax, [ebp-0x8] */
            ii(0x1009_5c7f, 4); movsx(ebx, memw_a32[ss, ebp - 0x16]);   /* movsx ebx, word [ebp-0x16] */
            ii(0x1009_5c83, 2); mov(edx, memd_a32[ds, eax]);            /* mov edx, [eax] */
            ii(0x1009_5c85, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x1009_5c87, 3); mov(al, memb_a32[ss, ebp - 0x2c]);      /* mov al, [ebp-0x2c] */
            ii(0x1009_5c8a, 2); mov(memb_a32[ds, edx], al);             /* mov [edx], al */
            ii(0x1009_5c8c, 2); jmpd(0x1009_5c65, -0x29); goto l_0x1009_5c65; /* jmp 0x10095c65 */
        l_0x1009_5c8e:
            ii(0x1009_5c8e, 2); jmpd(0x1009_5c4c, -0x44); goto l_0x1009_5c4c; /* jmp 0x10095c4c */
        l_0x1009_5c90:
            ii(0x1009_5c90, 5); jmpd(0x1009_5b1f, -0x176); goto l_0x1009_5b1f; /* jmp 0x10095b1f */
        l_0x1009_5c95:
            ii(0x1009_5c95, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5c97, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x1009_5c9a, 5); calld(0x1009_ba6c, 0x5dcd);             /* call 0x1009ba6c */
            ii(0x1009_5c9f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_5ca1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1009_5ca4, 5); calld(0x1007_5f6c, -0x1_fd3d);          /* call 0x10075f6c */
            ii(0x1009_5ca9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_5cab, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_5cac, 1); popd(edi);                              /* pop edi */
            ii(0x1009_5cad, 1); popd(esi);                              /* pop esi */
            ii(0x1009_5cae, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
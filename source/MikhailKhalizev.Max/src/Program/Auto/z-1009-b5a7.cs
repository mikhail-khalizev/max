using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b5a7-e1079192")]
        public void Method_1009_b5a7()
        {
            ii(0x1009_b5a7, 5); pushd(0x54);                            /* push 0x54 */
            ii(0x1009_b5ac, 5); calld(Definitions.sys_check_available_stack_size, 0xc_a7a1); /* call 0x10165d52 */
            ii(0x1009_b5b1, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b5b2, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b5b3, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b5b4, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b5b5, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b5b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b5b8, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x1009_b5be, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_b5c1, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_b5c4, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_b5c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b5ca, 5); calld(0x1015_2a52, 0xb_7483);           /* call 0x10152a52 */
            ii(0x1009_b5cf, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b5d1, 2); if(jnzd(0x1009_b5dc, 0x9)) goto l_0x1009_b5dc; /* jnz 0x1009b5dc */
            ii(0x1009_b5d3, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_b5d7, 5); jmpd(0x1009_b7c4, 0x1e8); goto l_0x1009_b7c4; /* jmp 0x1009b7c4 */
        l_0x1009_b5dc:
            ii(0x1009_b5dc, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1009_b5e1, 5); calld(0x1007_6338, -0x2_52ae);          /* call 0x10076338 */
            ii(0x1009_b5e6, 3); lea(ebx, ebp - 0x2c);                   /* lea ebx, [ebp-0x2c] */
            ii(0x1009_b5e9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b5eb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_b5ed, 5); calld(0x1007_64b8, -0x2_513a);          /* call 0x100764b8 */
            ii(0x1009_b5f2, 7); mov(memd_a32[ss, ebp - 0x28], 0);       /* mov dword [ebp-0x28], 0x0 */
            ii(0x1009_b5f9, 2); jmpd(0x1009_b603, 0x8); goto l_0x1009_b603; /* jmp 0x1009b603 */
        l_0x1009_b5fb:
            ii(0x1009_b5fb, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b5fe, 5); calld(0x1007_6bf8, -0x2_4a0b);          /* call 0x10076bf8 */
        l_0x1009_b603:
            ii(0x1009_b603, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b605, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b608, 5); calld(0x1013_ad71, 0x9_f764);           /* call 0x1013ad71 */
            ii(0x1009_b60d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b60f, 6); if(jzd(0x1009_b707, 0xf2)) goto l_0x1009_b707; /* jz 0x1009b707 */
            ii(0x1009_b615, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b618, 3); mov(edx, memd_a32[ds, eax + 0x7]);      /* mov edx, [eax+0x7] */
            ii(0x1009_b61b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_b61e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b621, 5); calld(0x1007_63a0, -0x2_5286);          /* call 0x100763a0 */
            ii(0x1009_b626, 5); calld(0x1007_6074, -0x2_55b7);          /* call 0x10076074 */
            ii(0x1009_b62b, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b62d, 2); if(jzd(0x1009_b64f, 0x20)) goto l_0x1009_b64f; /* jz 0x1009b64f */
            ii(0x1009_b62f, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b632, 5); calld(0x1007_63a0, -0x2_5297);          /* call 0x100763a0 */
            ii(0x1009_b637, 5); cmp(memw_a32[ds, eax + 0x8], 0xe);      /* cmp word [eax+0x8], 0xe */
            ii(0x1009_b63c, 2); if(jzd(0x1009_b64d, 0xf)) goto l_0x1009_b64d; /* jz 0x1009b64d */
            ii(0x1009_b63e, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b641, 5); calld(0x1007_63a0, -0x2_52a6);          /* call 0x100763a0 */
            ii(0x1009_b646, 5); cmp(memw_a32[ds, eax + 0x8], 0xd);      /* cmp word [eax+0x8], 0xd */
            ii(0x1009_b64b, 2); if(jnzd(0x1009_b64f, 0x2)) goto l_0x1009_b64f; /* jnz 0x1009b64f */
        l_0x1009_b64d:
            ii(0x1009_b64d, 2); jmpd(0x1009_b654, 0x5); goto l_0x1009_b654; /* jmp 0x1009b654 */
        l_0x1009_b64f:
            ii(0x1009_b64f, 5); jmpd(0x1009_b702, 0xae); goto l_0x1009_b702; /* jmp 0x1009b702 */
        l_0x1009_b654:
            ii(0x1009_b654, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b657, 5); calld(0x1007_63a0, -0x2_52bc);          /* call 0x100763a0 */
            ii(0x1009_b65c, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1009_b65f, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_b662, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b665, 5); calld(0x1007_63a0, -0x2_52ca);          /* call 0x100763a0 */
            ii(0x1009_b66a, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_b66d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_b670, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1009_b673, 5); calld(0x1007_6aac, -0x2_4bcc);          /* call 0x10076aac */
            ii(0x1009_b678, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b67b, 5); calld(0x1007_63d4, -0x2_52ac);          /* call 0x100763d4 */
            ii(0x1009_b680, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b682, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b685, 5); calld(0x1007_0d01, -0x2_a989);          /* call 0x10070d01 */
            ii(0x1009_b68a, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_b68d, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1009_b691, 2); if(jzd(0x1009_b69c, 0x9)) goto l_0x1009_b69c; /* jz 0x1009b69c */
            ii(0x1009_b693, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_b696, 4); cmp(ax, memw_a32[ss, ebp - 0x10]);      /* cmp ax, [ebp-0x10] */
            ii(0x1009_b69a, 2); if(jged(0x1009_b6bf, 0x23)) goto l_0x1009_b6bf; /* jge 0x1009b6bf */
        l_0x1009_b69c:
            ii(0x1009_b69c, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1009_b6a1, 5); mov(ebx, 0x3);                          /* mov ebx, 0x3 */
            ii(0x1009_b6a6, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1009_b6a9, 3); lea(eax, ebp - 0x38);                   /* lea eax, [ebp-0x38] */
            ii(0x1009_b6ac, 5); calld(0x1007_5e64, -0x2_584d);          /* call 0x10075e64 */
            ii(0x1009_b6b1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b6b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_b6b6, 5); calld(0x100a_90f9, 0xda3e);             /* call 0x100a90f9 */
            ii(0x1009_b6bb, 2); test(al, al);                           /* test al, al */
            ii(0x1009_b6bd, 2); if(jzd(0x1009_b6c1, 0x2)) goto l_0x1009_b6c1; /* jz 0x1009b6c1 */
        l_0x1009_b6bf:
            ii(0x1009_b6bf, 2); jmpd(0x1009_b6ef, 0x2e); goto l_0x1009_b6ef; /* jmp 0x1009b6ef */
        l_0x1009_b6c1:
            ii(0x1009_b6c1, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b6c4, 5); calld(0x1007_63a0, -0x2_5329);          /* call 0x100763a0 */
            ii(0x1009_b6c9, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1009_b6cc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1009_b6cf, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b6d2, 5); calld(0x1007_63a0, -0x2_5337);          /* call 0x100763a0 */
            ii(0x1009_b6d7, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1009_b6da, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_b6dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b6e0, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1009_b6e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_b6e6, 5); calld(0x1007_41dc, -0x2_750f);          /* call 0x100741dc */
            ii(0x1009_b6eb, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1009_b6ed, 2); if(jnzd(0x1009_b6f1, 0x2)) goto l_0x1009_b6f1; /* jnz 0x1009b6f1 */
        l_0x1009_b6ef:
            ii(0x1009_b6ef, 2); jmpd(0x1009_b702, 0x11); goto l_0x1009_b702; /* jmp 0x1009b702 */
        l_0x1009_b6f1:
            ii(0x1009_b6f1, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b6f4, 5); calld(0x1007_63d4, -0x2_5325);          /* call 0x100763d4 */
            ii(0x1009_b6f9, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1009_b6fc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_b6ff, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1009_b702:
            ii(0x1009_b702, 5); jmpd(0x1009_b5fb, -0x10c); goto l_0x1009_b5fb; /* jmp 0x1009b5fb */
        l_0x1009_b707:
            ii(0x1009_b707, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x1009_b70b, 2); if(jnzd(0x1009_b720, 0x13)) goto l_0x1009_b720; /* jnz 0x1009b720 */
            ii(0x1009_b70d, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x1009_b711, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b713, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b716, 5); calld(0x1007_5f6c, -0x2_57af);          /* call 0x10075f6c */
            ii(0x1009_b71b, 5); jmpd(0x1009_b7c4, 0xa4); goto l_0x1009_b7c4; /* jmp 0x1009b7c4 */
        l_0x1009_b720:
            ii(0x1009_b720, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1009_b725, 5); calld(Definitions.sys_new, 0xc_a6d6);   /* call 0x10165e00 */
            ii(0x1009_b72a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_b72d, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_b730, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1009_b733, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1009_b737, 2); if(jzd(0x1009_b757, 0x1e)) goto l_0x1009_b757; /* jz 0x1009b757 */
            ii(0x1009_b739, 5); mov(ecx, 0x2100);                       /* mov ecx, 0x2100 */
            ii(0x1009_b73e, 3); mov(ebx, memd_a32[ss, ebp - 0x28]);     /* mov ebx, [ebp-0x28] */
            ii(0x1009_b741, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_b744, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1009_b747, 5); calld(0x1009_a085, -0x16c7);            /* call 0x1009a085 */
            ii(0x1009_b74c, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_b74f, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1009_b752, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1009_b755, 2); jmpd(0x1009_b75d, 0x6); goto l_0x1009_b75d; /* jmp 0x1009b75d */
        l_0x1009_b757:
            ii(0x1009_b757, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1009_b75a, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x1009_b75d:
            ii(0x1009_b75d, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1009_b760, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_b763, 5); calld(0x1008_b060, -0x1_0708);          /* call 0x1008b060 */
            ii(0x1009_b768, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_b76b, 5); calld(0x1008_af28, -0x1_0848);          /* call 0x1008af28 */
            ii(0x1009_b770, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_b773, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_b776, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x1009_b779, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_b77c, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_b77f, 3); calld_abs(memd_a32[ds, ebx + 0x2c]);    /* call dword [ebx+0x2c] */
            ii(0x1009_b782, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_b785, 5); calld(0x1008_af84, -0x1_0806);          /* call 0x1008af84 */
            ii(0x1009_b78a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_b78c, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_b791, 5); calld(0x100a_4d50, 0x95ba);             /* call 0x100a4d50 */
            ii(0x1009_b796, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x1009_b79a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b79c, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x1009_b79f, 5); calld(0x1008_8b7c, -0x1_2c28);          /* call 0x10088b7c */
            ii(0x1009_b7a4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_b7a6, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x1009_b7a9, 5); calld(0x1007_5f6c, -0x2_5842);          /* call 0x10075f6c */
            ii(0x1009_b7ae, 2); jmpd(0x1009_b7c4, 0x14); goto l_0x1009_b7c4; /* jmp 0x1009b7c4 */
        //  ii(0x1009_b7b0, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1009_b7b2, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
        //  ii(0x1009_b7b5, 5); calld(0x1008_8b7c, -0x1_2c3e);          /* call 0x10088b7c */
        //  ii(0x1009_b7ba, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1009_b7bc, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
        //  ii(0x1009_b7bf, 5); calld(0x1007_5f6c, -0x2_5858);          /* call 0x10075f6c */
        l_0x1009_b7c4:
            ii(0x1009_b7c4, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x1009_b7c7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b7c9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b7ca, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b7cb, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b7cc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b7cd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b7ce, 1); retd(); return;                         /* ret */
        }
    }
}

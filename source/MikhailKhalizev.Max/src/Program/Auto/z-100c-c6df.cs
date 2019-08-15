using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04e04910-30b4-4d9f-b971-4f75621e8549")]
        public void Method_100c_c6df()
        {
            ii(0x100c_c6df, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100c_c6e4, 5); calld(Definitions.sys_check_available_stack_size, 0x9_9669); /* call 0x10165d52 */
            ii(0x100c_c6e9, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_c6ea, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_c6eb, 1); pushd(edx);                             /* push edx */
            ii(0x100c_c6ec, 1); pushd(esi);                             /* push esi */
            ii(0x100c_c6ed, 1); pushd(edi);                             /* push edi */
            ii(0x100c_c6ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_c6ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_c6f1, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100c_c6f7, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100c_c6fa, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100c_c6fe, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c701, 5); calld(Definitions.my_ctor_0x101b38f8, -0x5_6016); /* call 0x100766f0 */
            ii(0x100c_c706, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_c709, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100c_c70d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c70f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c712, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c715, 5); calld(0x1013_ad11, 0x6_e5f7);           /* call 0x1013ad11 */
            ii(0x100c_c71a, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c71c, 2); if(jzd(0x100c_c72d, 0xf)) goto l_0x100c_c72d; /* jz 0x100cc72d */
            ii(0x100c_c71e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c720, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c723, 5); calld(0x1007_5f2c, -0x5_67fc);          /* call 0x10075f2c */
            ii(0x100c_c728, 5); jmpd(0x100c_c82b, 0xfe); goto l_0x100c_c82b; /* jmp 0x100cc82b */
        l_0x100c_c72d:
            ii(0x100c_c72d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c72f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c732, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c735, 5); calld(0x1007_6630, -0x5_610a);          /* call 0x10076630 */
            ii(0x100c_c73a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c73d, 5); calld(0x100c_cac0, 0x37e);              /* call 0x100ccac0 */
            ii(0x100c_c742, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c744, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c747, 5); calld(0x1007_6630, -0x5_611c);          /* call 0x10076630 */
            ii(0x100c_c74c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c74f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_c752, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_c755, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100c_c758, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_c75b, 3); calld_abs(memd_a32[ds, edx + 0x70]);    /* call dword [edx+0x70] */
            ii(0x100c_c75e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c760, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c763, 5); calld(0x1013_ad71, 0x6_e609);           /* call 0x1013ad71 */
            ii(0x100c_c768, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c76a, 6); if(jzd(0x100c_c7f1, 0x81)) goto l_0x100c_c7f1; /* jz 0x100cc7f1 */
            ii(0x100c_c770, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c772, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c775, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c778, 5); calld(0x1013_ad11, 0x6_e594);           /* call 0x1013ad11 */
            ii(0x100c_c77d, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c77f, 2); if(jzd(0x100c_c791, 0x10)) goto l_0x100c_c791; /* jz 0x100cc791 */
            ii(0x100c_c781, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_c784, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c787, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c78a, 5); calld(0x1008_ac18, -0x4_1b77);          /* call 0x1008ac18 */
            ii(0x100c_c78f, 2); jmpd(0x100c_c7f1, 0x60); goto l_0x100c_c7f1; /* jmp 0x100cc7f1 */
        l_0x100c_c791:
            ii(0x100c_c791, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c794, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c797, 5); calld(0x1008_abbc, -0x4_1be0);          /* call 0x1008abbc */
            ii(0x100c_c79c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c79e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c7a1, 5); calld(0x1008_abbc, -0x4_1bea);          /* call 0x1008abbc */
            ii(0x100c_c7a6, 5); calld(0x100a_601a, -0x2_6791);          /* call 0x100a601a */
            ii(0x100c_c7ab, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_c7ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c7b1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c7b4, 5); calld(0x1008_abbc, -0x4_1bfd);          /* call 0x1008abbc */
            ii(0x100c_c7b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c7bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c7be, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c7c1, 5); calld(0x1008_abbc, -0x4_1c0a);          /* call 0x1008abbc */
            ii(0x100c_c7c6, 5); calld(0x100a_601a, -0x2_67b1);          /* call 0x100a601a */
            ii(0x100c_c7cb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_c7ce, 4); movsx(edx, memw_a32[ss, ebp - 0x1c]);   /* movsx edx, word [ebp-0x1c] */
            ii(0x100c_c7d2, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100c_c7d4, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100c_c7d7, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100c_c7d9, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100c_c7db, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100c_c7df, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100c_c7e1, 2); if(jled(0x100c_c7f1, 0xe)) goto l_0x100c_c7f1; /* jle 0x100cc7f1 */
            ii(0x100c_c7e3, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100c_c7e6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c7e9, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c7ec, 5); calld(0x1008_ac18, -0x4_1bd9);          /* call 0x1008ac18 */
        l_0x100c_c7f1:
            ii(0x100c_c7f1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c7f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c7f6, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c7f9, 5); calld(0x1013_ad11, 0x6_e513);           /* call 0x1013ad11 */
            ii(0x100c_c7fe, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c800, 2); if(jzd(0x100c_c80e, 0xc)) goto l_0x100c_c80e; /* jz 0x100cc80e */
            ii(0x100c_c802, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c804, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c807, 5); calld(0x1007_5f2c, -0x5_68e0);          /* call 0x10075f2c */
            ii(0x100c_c80c, 2); jmpd(0x100c_c82b, 0x1d); goto l_0x100c_c82b; /* jmp 0x100cc82b */
        l_0x100c_c80e:
            ii(0x100c_c80e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100c_c811, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_c814, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c817, 5); calld(0x1007_6574, -0x5_62a8);          /* call 0x10076574 */
            ii(0x100c_c81c, 5); calld(0x1015_27ed, 0x8_5fcc);           /* call 0x101527ed */
            ii(0x100c_c821, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c823, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100c_c826, 5); calld(0x1007_5f2c, -0x5_68ff);          /* call 0x10075f2c */
        l_0x100c_c82b:
            ii(0x100c_c82b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_c82d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_c82e, 1); popd(edi);                              /* pop edi */
            ii(0x100c_c82f, 1); popd(esi);                              /* pop esi */
            ii(0x100c_c830, 1); popd(edx);                              /* pop edx */
            ii(0x100c_c831, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_c832, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_c833, 1); retd(); return;                         /* ret */
        }
    }
}

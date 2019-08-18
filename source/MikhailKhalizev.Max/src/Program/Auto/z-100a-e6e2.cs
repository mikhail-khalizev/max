using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5721c691-b699-4446-803c-af0b74eac2b2")]
        public void Method_100a_e6e2()
        {
            ii(0x100a_e6e2, 5); pushd(0x58);                            /* push 0x58 */
            ii(0x100a_e6e7, 5); calld(Definitions.sys_check_available_stack_size, 0xb_7666); /* call 0x10165d52 */
            ii(0x100a_e6ec, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_e6ed, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_e6ee, 1); pushd(edx);                             /* push edx */
            ii(0x100a_e6ef, 1); pushd(esi);                             /* push esi */
            ii(0x100a_e6f0, 1); pushd(edi);                             /* push edi */
            ii(0x100a_e6f1, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_e6f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_e6f4, 6); sub(esp, 0x3c);                         /* sub esp, 0x3c */
            ii(0x100a_e6fa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_e6fd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_e700, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e703, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e706, 5); calld(0x1007_6574, -0x3_8197);          /* call 0x10076574 */
            ii(0x100a_e70b, 5); calld(0x1015_2a52, 0xa_4342);           /* call 0x10152a52 */
            ii(0x100a_e710, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e712, 2); if(jzd(0x100a_e736, 0x22)) goto l_0x100a_e736; /* jz 0x100ae736 */
            ii(0x100a_e714, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_e716, 5); mov(al, memb_a32[ds, 0x101c_37c9]);     /* mov al, [0x101c37c9] */
            ii(0x100a_e71b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e71d, 2); if(jnzd(0x100a_e734, 0x15)) goto l_0x100a_e734; /* jnz 0x100ae734 */
            ii(0x100a_e71f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e722, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_e725, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e728, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e72a, 6); mov(dl, memb_a32[ds, 0x101c_37c8]);     /* mov dl, [0x101c37c8] */
            ii(0x100a_e730, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_e732, 2); if(jnzd(0x100a_e736, 0x2)) goto l_0x100a_e736; /* jnz 0x100ae736 */
        l_0x100a_e734:
            ii(0x100a_e734, 2); jmpd(0x100a_e73b, 0x5); goto l_0x100a_e73b; /* jmp 0x100ae73b */
        l_0x100a_e736:
            ii(0x100a_e736, 5); jmpd(0x100a_eb0f, 0x3d4); goto l_0x100a_eb0f; /* jmp 0x100aeb0f */
        l_0x100a_e73b:
            ii(0x100a_e73b, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x100a_e73f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e742, 5); calld(0x1007_64fc, -0x3_824b);          /* call 0x100764fc */
            ii(0x100a_e747, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100a_e74a, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100a_e74e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_e752, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e755, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_e758, 5); calld(Definitions.my_3_get_count, -0x2_32dd); /* call 0x1008b480 */
            ii(0x100a_e75d, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x100a_e760:
            ii(0x100a_e760, 4); add(memd_a32[ss, ebp - 0x18], -0x1 /* 0xff */); /* add dword [ebp-0x18], 0xffffffff */
            ii(0x100a_e764, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_e768, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e76a, 2); if(jld(0x100a_e7a9, 0x3d)) goto l_0x100a_e7a9; /* jl 0x100ae7a9 */
            ii(0x100a_e76c, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_e770, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e773, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_e776, 5); calld(0x100a_aa28, -0x3d53);            /* call 0x100aaa28 */
            ii(0x100a_e77b, 3); mov(dx, memw_a32[ds, eax]);             /* mov dx, [eax] */
            ii(0x100a_e77e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e781, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x100a_e785, 2); if(jnzd(0x100a_e7a3, 0x1c)) goto l_0x100a_e7a3; /* jnz 0x100ae7a3 */
            ii(0x100a_e787, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100a_e78b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e78e, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_e791, 5); calld(0x100a_aa28, -0x3d6e);            /* call 0x100aaa28 */
            ii(0x100a_e796, 4); mov(dx, memw_a32[ds, eax + 0x2]);       /* mov dx, [eax+0x2] */
            ii(0x100a_e79a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e79d, 4); cmp(dx, memw_a32[ds, eax + 0x1c]);      /* cmp dx, [eax+0x1c] */
            ii(0x100a_e7a1, 2); if(jzd(0x100a_e7a5, 0x2)) goto l_0x100a_e7a5; /* jz 0x100ae7a5 */
        l_0x100a_e7a3:
            ii(0x100a_e7a3, 2); jmpd(0x100a_e7a7, 0x2); goto l_0x100a_e7a7; /* jmp 0x100ae7a7 */
        l_0x100a_e7a5:
            ii(0x100a_e7a5, 2); jmpd(0x100a_e7a9, 0x2); goto l_0x100a_e7a9; /* jmp 0x100ae7a9 */
        l_0x100a_e7a7:
            ii(0x100a_e7a7, 2); jmpd(0x100a_e760, -0x49); goto l_0x100a_e760; /* jmp 0x100ae760 */
        l_0x100a_e7a9:
            ii(0x100a_e7a9, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_e7ad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e7af, 6); if(jld(0x100a_eaa4, 0x2ef)) goto l_0x100a_eaa4; /* jl 0x100aeaa4 */
            ii(0x100a_e7b5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100a_e7b8, 3); dec(memd_a32[ss, ebp - 0x18]);          /* dec dword [ebp-0x18] */
            ii(0x100a_e7bb, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_e7be, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e7c1, 3); add(eax, 0x2c);                         /* add eax, 0x2c */
            ii(0x100a_e7c4, 5); calld(0x100a_aa28, -0x3da1);            /* call 0x100aaa28 */
            ii(0x100a_e7c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e7cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e7ce, 3); add(eax, 0x1a);                         /* add eax, 0x1a */
            ii(0x100a_e7d1, 5); calld(0x1008_8b44, -0x2_5c92);          /* call 0x10088b44 */
            ii(0x100a_e7d6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e7d9, 5); calld(0x100a_e4fd, -0x2e1);             /* call 0x100ae4fd */
            ii(0x100a_e7de, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e7e0, 6); if(jzd(0x100a_ea9f, 0x2b9)) goto l_0x100a_ea9f; /* jz 0x100aea9f */
            ii(0x100a_e7e6, 4); mov(memb_a32[ss, ebp - 0xc], 0x1);      /* mov byte [ebp-0xc], 0x1 */
            ii(0x100a_e7ea, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e7ed, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x100a_e7f0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_e7f3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e7f6, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x100a_e7f9, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_e7fc, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x100a_e801, 5); calld(0x1010_3541, 0x5_4d3b);           /* call 0x10103541 */
            ii(0x100a_e806, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e808, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e80b, 5); calld(0x1007_643c, -0x3_83d4);          /* call 0x1007643c */
            ii(0x100a_e810, 2); jmpd(0x100a_e81a, 0x8); goto l_0x100a_e81a; /* jmp 0x100ae81a */
        l_0x100a_e812:
            ii(0x100a_e812, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e815, 5); calld(0x1007_6bf8, -0x3_7c22);          /* call 0x10076bf8 */
        l_0x100a_e81a:
            ii(0x100a_e81a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e81c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e81f, 5); calld(0x1013_ad71, 0x8_c54d);           /* call 0x1013ad71 */
            ii(0x100a_e824, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e826, 6); if(jzd(0x100a_e9dd, 0x1b1)) goto l_0x100a_e9dd; /* jz 0x100ae9dd */
            ii(0x100a_e82c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e82f, 5); calld(0x1007_63a0, -0x3_8494);          /* call 0x100763a0 */
            ii(0x100a_e834, 4); test(memb_a32[ds, eax + 0x12], 0x40);   /* test byte [eax+0x12], 0x40 */
            ii(0x100a_e838, 6); if(jzd(0x100a_e9d8, 0x19a)) goto l_0x100a_e9d8; /* jz 0x100ae9d8 */
            ii(0x100a_e83e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e841, 5); calld(0x1007_63a0, -0x3_84a6);          /* call 0x100763a0 */
            ii(0x100a_e846, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100a_e84a, 2); if(jnzd(0x100a_e85a, 0xe)) goto l_0x100a_e85a; /* jnz 0x100ae85a */
            ii(0x100a_e84c, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e84f, 5); calld(0x1007_63a0, -0x3_84b4);          /* call 0x100763a0 */
            ii(0x100a_e854, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100a_e858, 2); if(jnzd(0x100a_e85c, 0x2)) goto l_0x100a_e85c; /* jnz 0x100ae85c */
        l_0x100a_e85a:
            ii(0x100a_e85a, 2); jmpd(0x100a_e8bd, 0x61); goto l_0x100a_e8bd; /* jmp 0x100ae8bd */
        l_0x100a_e85c:
            ii(0x100a_e85c, 5); calld(0x1008_a7bc, -0x2_40a5);          /* call 0x1008a7bc */
            ii(0x100a_e861, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_e866, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100a_e869, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100a_e86e, 5); calld(Definitions.sys_new, 0xb_758d);   /* call 0x10165e00 */
            ii(0x100a_e873, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_e876, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_e879, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_e87c, 4); cmp(memd_a32[ss, ebp - 0x24], 0);       /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100a_e880, 2); if(jzd(0x100a_e898, 0x16)) goto l_0x100a_e898; /* jz 0x100ae898 */
            ii(0x100a_e882, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_e885, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100a_e888, 5); calld(Definitions.my_ctor_c11, -0xafc4); /* call 0x100a38c9 */
            ii(0x100a_e88d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_e890, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_e893, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100a_e896, 2); jmpd(0x100a_e89e, 0x6); goto l_0x100a_e89e; /* jmp 0x100ae89e */
        l_0x100a_e898:
            ii(0x100a_e898, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_e89b, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
        l_0x100a_e89e:
            ii(0x100a_e89e, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100a_e8a1, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_e8a6, 3); mov(ebx, memd_a32[ss, ebp - 0x1c]);     /* mov ebx, [ebp-0x1c] */
            ii(0x100a_e8a9, 5); calld(0x100a_4db6, -0x9af8);            /* call 0x100a4db6 */
            ii(0x100a_e8ae, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e8b0, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e8b3, 5); calld(0x1007_5f6c, -0x3_894c);          /* call 0x10075f6c */
            ii(0x100a_e8b8, 5); jmpd(0x100a_eb0f, 0x252); goto l_0x100a_eb0f; /* jmp 0x100aeb0f */
        l_0x100a_e8bd:
            ii(0x100a_e8bd, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e8c0, 5); calld(0x1007_63a0, -0x3_8525);          /* call 0x100763a0 */
            ii(0x100a_e8c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e8c7, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_e8ca, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e8cd, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_e8d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e8d3, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_e8d5, 2); if(jnzd(0x100a_e8ec, 0x15)) goto l_0x100a_e8ec; /* jnz 0x100ae8ec */
            ii(0x100a_e8d7, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e8da, 5); calld(0x1007_63a0, -0x3_853f);          /* call 0x100763a0 */
            ii(0x100a_e8df, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x100a_e8e2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100a_e8e7, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100a_e8ea, 2); if(jged(0x100a_e90c, 0x20)) goto l_0x100a_e90c; /* jge 0x100ae90c */
        l_0x100a_e8ec:
            ii(0x100a_e8ec, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_e8f0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_e8f2, 2); if(jnzd(0x100a_e903, 0xf)) goto l_0x100a_e903; /* jnz 0x100ae903 */
            ii(0x100a_e8f4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e8f6, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e8f9, 5); calld(0x1007_5f6c, -0x3_8992);          /* call 0x10075f6c */
            ii(0x100a_e8fe, 5); jmpd(0x100a_eb0f, 0x20c); goto l_0x100a_eb0f; /* jmp 0x100aeb0f */
        l_0x100a_e903:
            ii(0x100a_e903, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_e907, 5); jmpd(0x100a_e9dd, 0xd1); goto l_0x100a_e9dd; /* jmp 0x100ae9dd */
        l_0x100a_e90c:
            ii(0x100a_e90c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e90e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e911, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_e914, 5); calld(0x1013_ad11, 0x8_c3f8);           /* call 0x1013ad11 */
            ii(0x100a_e919, 2); test(al, al);                           /* test al, al */
            ii(0x100a_e91b, 6); if(jzd(0x100a_e9c9, 0xa8)) goto l_0x100a_e9c9; /* jz 0x100ae9c9 */
            ii(0x100a_e921, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_e926, 5); calld(Definitions.sys_new, 0xb_74d5);   /* call 0x10165e00 */
            ii(0x100a_e92b, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100a_e92e, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_e931, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100a_e934, 4); cmp(memd_a32[ss, ebp - 0x34], 0);       /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100a_e938, 2); if(jzd(0x100a_e95f, 0x25)) goto l_0x100a_e95f; /* jz 0x100ae95f */
            ii(0x100a_e93a, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_e93d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e940, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_e943, 5); calld(0x1007_65d0, -0x3_8378);          /* call 0x100765d0 */
            ii(0x100a_e948, 3); mov(ecx, memd_a32[ss, ebp - 0x30]);     /* mov ecx, [ebp-0x30] */
            ii(0x100a_e94b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e94d, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100a_e94f, 5); calld(0x100a_73d7, -0x757d);            /* call 0x100a73d7 */
            ii(0x100a_e954, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100a_e957, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100a_e95a, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100a_e95d, 2); jmpd(0x100a_e965, 0x6); goto l_0x100a_e965; /* jmp 0x100ae965 */
        l_0x100a_e95f:
            ii(0x100a_e95f, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100a_e962, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x100a_e965:
            ii(0x100a_e965, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x100a_e968, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e96b, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_e96e, 5); calld(0x1009_c8f8, -0x1_207b);          /* call 0x1009c8f8 */
            ii(0x100a_e973, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_e976, 3); add(edx, 0x1a);                         /* add edx, 0x1a */
            ii(0x100a_e979, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e97c, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_e97f, 5); calld(0x100a_a824, -0x4160);            /* call 0x100aa824 */
            ii(0x100a_e984, 5); calld(0x100a_7557, -0x7432);            /* call 0x100a7557 */
            ii(0x100a_e989, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e98c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e98e, 3); mov(dl, memb_a32[ds, eax + 0x45]);      /* mov dl, [eax+0x45] */
            ii(0x100a_e991, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e994, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_e997, 5); calld(0x100a_a824, -0x4178);            /* call 0x100aa824 */
            ii(0x100a_e99c, 5); calld(0x100b_81a0, 0x97ff);             /* call 0x100b81a0 */
            ii(0x100a_e9a1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e9a4, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100a_e9a7, 5); calld(0x100b_80f4, 0x9748);             /* call 0x100b80f4 */
            ii(0x100a_e9ac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e9ae, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_e9b1, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_e9b4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_e9b7, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_e9bd, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_e9c2, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_e9c4, 5); calld(0x100c_21b2, 0x1_37e9);           /* call 0x100c21b2 */
        l_0x100a_e9c9:
            ii(0x100a_e9c9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e9cb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e9ce, 5); calld(0x1007_5f6c, -0x3_8a67);          /* call 0x10075f6c */
            ii(0x100a_e9d3, 5); jmpd(0x100a_eb0f, 0x137); goto l_0x100a_eb0f; /* jmp 0x100aeb0f */
        l_0x100a_e9d8:
            ii(0x100a_e9d8, 5); jmpd(0x100a_e812, -0x1cb); goto l_0x100a_e812; /* jmp 0x100ae812 */
        l_0x100a_e9dd:
            ii(0x100a_e9dd, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100a_e9e2, 5); calld(0x1007_6338, -0x3_86af);          /* call 0x10076338 */
            ii(0x100a_e9e7, 3); lea(ebx, ebp - 0x10);                   /* lea ebx, [ebp-0x10] */
            ii(0x100a_e9ea, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_e9ec, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100a_e9ee, 5); calld(0x1007_643c, -0x3_85b7);          /* call 0x1007643c */
            ii(0x100a_e9f3, 2); jmpd(0x100a_e9fd, 0x8); goto l_0x100a_e9fd; /* jmp 0x100ae9fd */
        l_0x100a_e9f5:
            ii(0x100a_e9f5, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_e9f8, 5); calld(0x1007_6bf8, -0x3_7e05);          /* call 0x10076bf8 */
        l_0x100a_e9fd:
            ii(0x100a_e9fd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_e9ff, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea02, 5); calld(0x1013_ad71, 0x8_c36a);           /* call 0x1013ad71 */
            ii(0x100a_ea07, 2); test(al, al);                           /* test al, al */
            ii(0x100a_ea09, 6); if(jzd(0x100a_ea99, 0x8a)) goto l_0x100a_ea99; /* jz 0x100aea99 */
            ii(0x100a_ea0f, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea12, 5); calld(0x1007_63a0, -0x3_8677);          /* call 0x100763a0 */
            ii(0x100a_ea17, 4); cmp(memb_a32[ds, eax + 0x3d], 0x2);     /* cmp byte [eax+0x3d], 0x2 */
            ii(0x100a_ea1b, 2); if(jnzd(0x100a_ea2b, 0xe)) goto l_0x100a_ea2b; /* jnz 0x100aea2b */
            ii(0x100a_ea1d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea20, 5); calld(0x1007_63a0, -0x3_8685);          /* call 0x100763a0 */
            ii(0x100a_ea25, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1);     /* cmp byte [eax+0x3e], 0x1 */
            ii(0x100a_ea29, 2); if(jnzd(0x100a_ea2d, 0x2)) goto l_0x100a_ea2d; /* jnz 0x100aea2d */
        l_0x100a_ea2b:
            ii(0x100a_ea2b, 2); jmpd(0x100a_ea47, 0x1a); goto l_0x100a_ea47; /* jmp 0x100aea47 */
        l_0x100a_ea2d:
            ii(0x100a_ea2d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea30, 5); calld(0x1007_63a0, -0x3_8695);          /* call 0x100763a0 */
            ii(0x100a_ea35, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ea37, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x100a_ea3a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ea3d, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_ea40, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_ea43, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100a_ea45, 2); if(jzd(0x100a_ea49, 0x2)) goto l_0x100a_ea49; /* jz 0x100aea49 */
        l_0x100a_ea47:
            ii(0x100a_ea47, 2); jmpd(0x100a_ea5e, 0x15); goto l_0x100a_ea5e; /* jmp 0x100aea5e */
        l_0x100a_ea49:
            ii(0x100a_ea49, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea4c, 5); calld(0x1007_63a0, -0x3_86b1);          /* call 0x100763a0 */
            ii(0x100a_ea51, 4); mov(dx, memw_a32[ds, eax + 0x41]);      /* mov dx, [eax+0x41] */
            ii(0x100a_ea55, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ea58, 4); cmp(dx, memw_a32[ds, eax + 0x1a]);      /* cmp dx, [eax+0x1a] */
            ii(0x100a_ea5c, 2); if(jzd(0x100a_ea60, 0x2)) goto l_0x100a_ea60; /* jz 0x100aea60 */
        l_0x100a_ea5e:
            ii(0x100a_ea5e, 2); jmpd(0x100a_ea75, 0x15); goto l_0x100a_ea75; /* jmp 0x100aea75 */
        l_0x100a_ea60:
            ii(0x100a_ea60, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea63, 5); calld(0x1007_63a0, -0x3_86c8);          /* call 0x100763a0 */
            ii(0x100a_ea68, 4); mov(dx, memw_a32[ds, eax + 0x43]);      /* mov dx, [eax+0x43] */
            ii(0x100a_ea6c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ea6f, 4); cmp(dx, memw_a32[ds, eax + 0x1c]);      /* cmp dx, [eax+0x1c] */
            ii(0x100a_ea73, 2); if(jzd(0x100a_ea77, 0x2)) goto l_0x100a_ea77; /* jz 0x100aea77 */
        l_0x100a_ea75:
            ii(0x100a_ea75, 2); jmpd(0x100a_ea94, 0x1d); goto l_0x100a_ea94; /* jmp 0x100aea94 */
        l_0x100a_ea77:
            ii(0x100a_ea77, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100a_ea7b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_ea7d, 2); if(jnzd(0x100a_ea8e, 0xf)) goto l_0x100a_ea8e; /* jnz 0x100aea8e */
            ii(0x100a_ea7f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_ea81, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_ea84, 5); calld(0x1007_5f6c, -0x3_8b1d);          /* call 0x10075f6c */
            ii(0x100a_ea89, 5); jmpd(0x100a_eb0f, 0x81); goto l_0x100a_eb0f; /* jmp 0x100aeb0f */
        l_0x100a_ea8e:
            ii(0x100a_ea8e, 4); mov(memb_a32[ss, ebp - 0xc], 0);        /* mov byte [ebp-0xc], 0x0 */
            ii(0x100a_ea92, 2); jmpd(0x100a_ea99, 0x5); goto l_0x100a_ea99; /* jmp 0x100aea99 */
        l_0x100a_ea94:
            ii(0x100a_ea94, 5); jmpd(0x100a_e9f5, -0xa4); goto l_0x100a_e9f5; /* jmp 0x100ae9f5 */
        l_0x100a_ea99:
            ii(0x100a_ea99, 4); cmp(memb_a32[ss, ebp - 0xc], 0);        /* cmp byte [ebp-0xc], 0x0 */
            ii(0x100a_ea9d, 2); if(jnzd(0x100a_eaa4, 0x5)) goto l_0x100a_eaa4; /* jnz 0x100aeaa4 */
        l_0x100a_ea9f:
            ii(0x100a_ea9f, 5); jmpd(0x100a_e7a9, -0x2fb); goto l_0x100a_e7a9; /* jmp 0x100ae7a9 */
        l_0x100a_eaa4:
            ii(0x100a_eaa4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eaa7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eaaa, 5); calld(0x1007_6574, -0x3_853b);          /* call 0x10076574 */
            ii(0x100a_eaaf, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_eab2, 4); mov(dx, memw_a32[ds, ebx + 0x1a]);      /* mov dx, [ebx+0x1a] */
            ii(0x100a_eab6, 4); mov(memw_a32[ds, eax + 0x41], dx);      /* mov [eax+0x41], dx */
            ii(0x100a_eaba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eabd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eac0, 5); calld(0x1007_6574, -0x3_8551);          /* call 0x10076574 */
            ii(0x100a_eac5, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_eac8, 4); mov(dx, memw_a32[ds, ebx + 0x1c]);      /* mov dx, [ebx+0x1c] */
            ii(0x100a_eacc, 4); mov(memw_a32[ds, eax + 0x43], dx);      /* mov [eax+0x43], dx */
            ii(0x100a_ead0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_ead3, 4); mov(memb_a32[ds, eax + 0x46], 0x1);     /* mov byte [eax+0x46], 0x1 */
            ii(0x100a_ead7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_ead9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100a_eade, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eae1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eae4, 5); calld(0x1007_6574, -0x3_8575);          /* call 0x10076574 */
            ii(0x100a_eae9, 5); calld(0x100a_b120, -0x39ce);            /* call 0x100ab120 */
            ii(0x100a_eaee, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_eaf0, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100a_eaf5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_eaf8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_eafb, 5); calld(0x1007_65d0, -0x3_8530);          /* call 0x100765d0 */
            ii(0x100a_eb00, 5); calld(0x1016_3053, 0xb_454e);           /* call 0x10163053 */
            ii(0x100a_eb05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_eb07, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100a_eb0a, 5); calld(0x1007_5f6c, -0x3_8ba3);          /* call 0x10075f6c */
        l_0x100a_eb0f:
            ii(0x100a_eb0f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_eb11, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_eb12, 1); popd(edi);                              /* pop edi */
            ii(0x100a_eb13, 1); popd(esi);                              /* pop esi */
            ii(0x100a_eb14, 1); popd(edx);                              /* pop edx */
            ii(0x100a_eb15, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_eb16, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_eb17, 1); retd(); return;                         /* ret */
        }
    }
}

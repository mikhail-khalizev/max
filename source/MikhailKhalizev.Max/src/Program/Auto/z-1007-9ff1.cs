using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("875fbdab-86d3-44fd-98ec-f64fa47f4099")]
        public void Method_1007_9ff1()
        {
            ii(0x1007_9ff1, 5); pushd(0x64);                            /* push 0x64 */
            ii(0x1007_9ff6, 5); calld(Definitions.sys_check_available_stack_size, 0xe_bd57); /* call 0x10165d52 */
            ii(0x1007_9ffb, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_9ffc, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_9ffd, 1); pushd(edx);                             /* push edx */
            ii(0x1007_9ffe, 1); pushd(esi);                             /* push esi */
            ii(0x1007_9fff, 1); pushd(edi);                             /* push edi */
            ii(0x1007_a000, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_a001, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_a003, 6); sub(esp, 0x48);                         /* sub esp, 0x48 */
            ii(0x1007_a009, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_a00c, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_a010, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a013, 5); calld(0x1007_64fc, -0x3b1c);            /* call 0x100764fc */
            ii(0x1007_a018, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1007_a01b, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_a01f, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1007_a023, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a026, 5); calld(Definitions.my_ctor_0x101b_3b58, 0x1_1079); /* call 0x1008b0a4 */
            ii(0x1007_a02b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_a02e, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1007_a032, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_a035, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_a038, 5); calld(0x1007_6338, -0x3d05);            /* call 0x10076338 */
            ii(0x1007_a03d, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x1007_a040, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a042, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_a044, 5); calld(0x1007_643c, -0x3c0d);            /* call 0x1007643c */
            ii(0x1007_a049, 2); jmpd(0x1007_a053, 0x8); goto l_0x1007_a053; /* jmp 0x1007a053 */
        l_0x1007_a04b:
            ii(0x1007_a04b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a04e, 5); calld(0x1007_6bf8, -0x345b);            /* call 0x10076bf8 */
        l_0x1007_a053:
            ii(0x1007_a053, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a055, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a058, 5); calld(0x1013_ad71, 0xc_0d14);           /* call 0x1013ad71 */
            ii(0x1007_a05d, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a05f, 6); if(jzd(0x1007_a2a7, 0x242)) goto l_0x1007_a2a7; /* jz 0x1007a2a7 */
            ii(0x1007_a065, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a068, 5); calld(0x1007_63a0, -0x3ccd);            /* call 0x100763a0 */
            ii(0x1007_a06d, 5); calld(0x1015_26ac, 0xd_863a);           /* call 0x101526ac */
            ii(0x1007_a072, 3); cmp(eax, memd_a32[ss, ebp - 0x4]);      /* cmp eax, [ebp-0x4] */
            ii(0x1007_a075, 6); if(jnzd(0x1007_a2a2, 0x227)) goto l_0x1007_a2a2; /* jnz 0x1007a2a2 */
            ii(0x1007_a07b, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a07e, 5); calld(0x1007_63a0, -0x3ce3);            /* call 0x100763a0 */
            ii(0x1007_a083, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a085, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x1007_a088, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a08b, 5); calld(0x1007_63a0, -0x3cf0);            /* call 0x100763a0 */
            ii(0x1007_a090, 5); calld(0x1007_623c, -0x3e59);            /* call 0x1007623c */
            ii(0x1007_a095, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1007_a098, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_a09b, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_a09d, 2); if(jld(0x1007_a0e1, 0x42)) goto l_0x1007_a0e1; /* jl 0x1007a0e1 */
            ii(0x1007_a09f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a0a2, 5); calld(0x1007_63a0, -0x3d07);            /* call 0x100763a0 */
            ii(0x1007_a0a7, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1007_a0ab, 2); if(jzd(0x1007_a0df, 0x32)) goto l_0x1007_a0df; /* jz 0x1007a0df */
            ii(0x1007_a0ad, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a0b0, 5); calld(0x1007_63a0, -0x3d15);            /* call 0x100763a0 */
            ii(0x1007_a0b5, 5); calld(0x1007_623c, -0x3e7e);            /* call 0x1007623c */
            ii(0x1007_a0ba, 3); mov(edx, memd_a32[ds, eax + 0x19]);     /* mov edx, [eax+0x19] */
            ii(0x1007_a0bd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_a0c0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_a0c2, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_a0c5, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_a0c7, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1007_a0c9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a0cb, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a0ce, 5); calld(0x1007_63a0, -0x3d33);            /* call 0x100763a0 */
            ii(0x1007_a0d3, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1007_a0d6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a0db, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1007_a0dd, 2); if(jld(0x1007_a0e1, 0x2)) goto l_0x1007_a0e1; /* jl 0x1007a0e1 */
        l_0x1007_a0df:
            ii(0x1007_a0df, 2); jmpd(0x1007_a141, 0x60); goto l_0x1007_a141; /* jmp 0x1007a141 */
        l_0x1007_a0e1:
            ii(0x1007_a0e1, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1007_a0e6, 5); calld(Definitions.sys_new, 0xe_bd15);   /* call 0x10165e00 */
            ii(0x1007_a0eb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1007_a0ee, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_a0f1, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1007_a0f4, 4); cmp(memd_a32[ss, ebp - 0x20], 0);       /* cmp dword [ebp-0x20], 0x0 */
            ii(0x1007_a0f8, 2); if(jzd(0x1007_a117, 0x1d)) goto l_0x1007_a117; /* jz 0x1007a117 */
            ii(0x1007_a0fa, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a0fd, 5); calld(0x1007_63d4, -0x3d2e);            /* call 0x100763d4 */
            ii(0x1007_a102, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a104, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1007_a107, 5); calld(Definitions.my_ctor_c16, 0x5_2d1e); /* call 0x100cce2a */
            ii(0x1007_a10c, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x1007_a10f, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x1007_a112, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x1007_a115, 2); jmpd(0x1007_a11d, 0x6); goto l_0x1007_a11d; /* jmp 0x1007a11d */
        l_0x1007_a117:
            ii(0x1007_a117, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1007_a11a, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
        l_0x1007_a11d:
            ii(0x1007_a11d, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x1007_a120, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a123, 5); calld(0x1008_afe4, 0x1_0ebc);           /* call 0x1008afe4 */
            ii(0x1007_a128, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a12b, 5); calld(0x1008_af84, 0x1_0e54);           /* call 0x1008af84 */
            ii(0x1007_a130, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a132, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_a137, 5); calld(0x100a_4d50, 0x2_ac14);           /* call 0x100a4d50 */
            ii(0x1007_a13c, 5); jmpd(0x1007_a2a2, 0x161); goto l_0x1007_a2a2; /* jmp 0x1007a2a2 */
        l_0x1007_a141:
            ii(0x1007_a141, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a144, 5); calld(0x1007_63a0, -0x3da9);            /* call 0x100763a0 */
            ii(0x1007_a149, 5); calld(0x1007_623c, -0x3f12);            /* call 0x1007623c */
            ii(0x1007_a14e, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1007_a151, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_a154, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_a156, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_a159, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_a15b, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1007_a15d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a15f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a162, 5); calld(0x1007_63a0, -0x3dc7);            /* call 0x100763a0 */
            ii(0x1007_a167, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1007_a16a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a16f, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1007_a171, 2); if(jged(0x1007_a182, 0xf)) goto l_0x1007_a182; /* jge 0x1007a182 */
            ii(0x1007_a173, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_a178, 5); calld(0x1007_5fdc, -0x41a1);            /* call 0x10075fdc */
            ii(0x1007_a17d, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1007_a180, 2); if(jged(0x1007_a184, 0x2)) goto l_0x1007_a184; /* jge 0x1007a184 */
        l_0x1007_a182:
            ii(0x1007_a182, 2); jmpd(0x1007_a1e4, 0x60); goto l_0x1007_a1e4; /* jmp 0x1007a1e4 */
        l_0x1007_a184:
            ii(0x1007_a184, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1007_a189, 5); calld(Definitions.sys_new, 0xe_bc72);   /* call 0x10165e00 */
            ii(0x1007_a18e, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1007_a191, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1007_a194, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1007_a197, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1007_a19b, 2); if(jzd(0x1007_a1ba, 0x1d)) goto l_0x1007_a1ba; /* jz 0x1007a1ba */
            ii(0x1007_a19d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a1a0, 5); calld(0x1007_63d4, -0x3dd1);            /* call 0x100763d4 */
            ii(0x1007_a1a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a1a7, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1007_a1aa, 5); calld(Definitions.my_ctor_c15, 0x5_16d9); /* call 0x100cb888 */
            ii(0x1007_a1af, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x1007_a1b2, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1007_a1b5, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1007_a1b8, 2); jmpd(0x1007_a1c0, 0x6); goto l_0x1007_a1c0; /* jmp 0x1007a1c0 */
        l_0x1007_a1ba:
            ii(0x1007_a1ba, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1007_a1bd, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
        l_0x1007_a1c0:
            ii(0x1007_a1c0, 3); mov(edx, memd_a32[ss, ebp - 0x38]);     /* mov edx, [ebp-0x38] */
            ii(0x1007_a1c3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a1c6, 5); calld(0x1008_afe4, 0x1_0e19);           /* call 0x1008afe4 */
            ii(0x1007_a1cb, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a1ce, 5); calld(0x1008_af84, 0x1_0db1);           /* call 0x1008af84 */
            ii(0x1007_a1d3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a1d5, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_a1da, 5); calld(0x100a_4d50, 0x2_ab71);           /* call 0x100a4d50 */
            ii(0x1007_a1df, 5); jmpd(0x1007_a2a2, 0xbe); goto l_0x1007_a2a2; /* jmp 0x1007a2a2 */
        l_0x1007_a1e4:
            ii(0x1007_a1e4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a1e7, 5); calld(0x1007_63a0, -0x3e4c);            /* call 0x100763a0 */
            ii(0x1007_a1ec, 6); test(memw_a32[ds, eax + 0x12], 0x1c0);  /* test word [eax+0x12], 0x1c0 */
            ii(0x1007_a1f2, 2); if(jzd(0x1007_a202, 0xe)) goto l_0x1007_a202; /* jz 0x1007a202 */
            ii(0x1007_a1f4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a1f7, 5); calld(0x1007_63a0, -0x3e5c);            /* call 0x100763a0 */
            ii(0x1007_a1fc, 4); test(memb_a32[ds, eax + 0x15], 0x10);   /* test byte [eax+0x15], 0x10 */
            ii(0x1007_a200, 2); if(jzd(0x1007_a204, 0x2)) goto l_0x1007_a204; /* jz 0x1007a204 */
        l_0x1007_a202:
            ii(0x1007_a202, 2); jmpd(0x1007_a213, 0xf); goto l_0x1007_a213; /* jmp 0x1007a213 */
        l_0x1007_a204:
            ii(0x1007_a204, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1007_a209, 5); calld(0x1007_5fdc, -0x4232);            /* call 0x10075fdc */
            ii(0x1007_a20e, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1007_a211, 2); if(jged(0x1007_a215, 0x2)) goto l_0x1007_a215; /* jge 0x1007a215 */
        l_0x1007_a213:
            ii(0x1007_a213, 2); jmpd(0x1007_a245, 0x30); goto l_0x1007_a245; /* jmp 0x1007a245 */
        l_0x1007_a215:
            ii(0x1007_a215, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a218, 5); calld(0x1007_63d4, -0x3e49);            /* call 0x100763d4 */
            ii(0x1007_a21d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a21f, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a222, 5); calld(0x1007_63a0, -0x3e87);            /* call 0x100763a0 */
            ii(0x1007_a227, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1007_a22a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a22f, 6); imul(ebx, eax, 0xc5);                   /* imul ebx, eax, 0xc5 */
            ii(0x1007_a235, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_a23a, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1007_a23c, 5); calld(0x100c_343a, 0x4_91f9);           /* call 0x100c343a */
            ii(0x1007_a241, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a243, 2); if(jnzd(0x1007_a247, 0x2)) goto l_0x1007_a247; /* jnz 0x1007a247 */
        l_0x1007_a245:
            ii(0x1007_a245, 2); jmpd(0x1007_a2a2, 0x5b); goto l_0x1007_a2a2; /* jmp 0x1007a2a2 */
        l_0x1007_a247:
            ii(0x1007_a247, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1007_a24c, 5); calld(Definitions.sys_new, 0xe_bbaf);   /* call 0x10165e00 */
            ii(0x1007_a251, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1007_a254, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1007_a257, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1007_a25a, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x1007_a25e, 2); if(jzd(0x1007_a27d, 0x1d)) goto l_0x1007_a27d; /* jz 0x1007a27d */
            ii(0x1007_a260, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a263, 5); calld(0x1007_63d4, -0x3e94);            /* call 0x100763d4 */
            ii(0x1007_a268, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a26a, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1007_a26d, 5); calld(Definitions.my_ctor_c18, 0x5_30eb); /* call 0x100cd35d */
            ii(0x1007_a272, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1007_a275, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1007_a278, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1007_a27b, 2); jmpd(0x1007_a283, 0x6); goto l_0x1007_a283; /* jmp 0x1007a283 */
        l_0x1007_a27d:
            ii(0x1007_a27d, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1007_a280, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x1007_a283:
            ii(0x1007_a283, 3); mov(edx, memd_a32[ss, ebp - 0x48]);     /* mov edx, [ebp-0x48] */
            ii(0x1007_a286, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a289, 5); calld(0x1008_afe4, 0x1_0d56);           /* call 0x1008afe4 */
            ii(0x1007_a28e, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a291, 5); calld(0x1008_af84, 0x1_0cee);           /* call 0x1008af84 */
            ii(0x1007_a296, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a298, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_a29d, 5); calld(0x100a_4d50, 0x2_aaae);           /* call 0x100a4d50 */
        l_0x1007_a2a2:
            ii(0x1007_a2a2, 5); jmpd(0x1007_a04b, -0x25c); goto l_0x1007_a04b; /* jmp 0x1007a04b */
        l_0x1007_a2a7:
            ii(0x1007_a2a7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_a2aa, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_a2ad, 5); calld(0x1007_6338, -0x3f7a);            /* call 0x10076338 */
            ii(0x1007_a2b2, 3); lea(ebx, ebp - 0x18);                   /* lea ebx, [ebp-0x18] */
            ii(0x1007_a2b5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a2b7, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_a2b9, 5); calld(0x1007_643c, -0x3e82);            /* call 0x1007643c */
            ii(0x1007_a2be, 2); jmpd(0x1007_a2c8, 0x8); goto l_0x1007_a2c8; /* jmp 0x1007a2c8 */
        l_0x1007_a2c0:
            ii(0x1007_a2c0, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a2c3, 5); calld(0x1007_6bf8, -0x36d0);            /* call 0x10076bf8 */
        l_0x1007_a2c8:
            ii(0x1007_a2c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a2ca, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a2cd, 5); calld(0x1013_ad71, 0xc_0a9f);           /* call 0x1013ad71 */
            ii(0x1007_a2d2, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a2d4, 2); if(jzd(0x1007_a311, 0x3b)) goto l_0x1007_a311; /* jz 0x1007a311 */
            ii(0x1007_a2d6, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a2d9, 5); calld(0x1007_63a0, -0x3f3e);            /* call 0x100763a0 */
            ii(0x1007_a2de, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1007_a2e1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a2e6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a2e8, 2); if(jled(0x1007_a2fe, 0x14)) goto l_0x1007_a2fe; /* jle 0x1007a2fe */
            ii(0x1007_a2ea, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_a2ed, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a2f0, 5); calld(0x1007_63a0, -0x3f55);            /* call 0x100763a0 */
            ii(0x1007_a2f5, 5); calld(0x1015_2a52, 0xd_8758);           /* call 0x10152a52 */
            ii(0x1007_a2fa, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a2fc, 2); if(jnzd(0x1007_a300, 0x2)) goto l_0x1007_a300; /* jnz 0x1007a300 */
        l_0x1007_a2fe:
            ii(0x1007_a2fe, 2); jmpd(0x1007_a30f, 0xf); goto l_0x1007_a30f; /* jmp 0x1007a30f */
        l_0x1007_a300:
            ii(0x1007_a300, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a302, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a305, 5); calld(0x1007_63d4, -0x3f36);            /* call 0x100763d4 */
            ii(0x1007_a30a, 5); calld(0x100a_297d, 0x2_866e);           /* call 0x100a297d */
        l_0x1007_a30f:
            ii(0x1007_a30f, 2); jmpd(0x1007_a2c0, -0x51); goto l_0x1007_a2c0; /* jmp 0x1007a2c0 */
        l_0x1007_a311:
            ii(0x1007_a311, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a313, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1007_a316, 5); calld(0x1008_8b7c, 0xe861);             /* call 0x10088b7c */
            ii(0x1007_a31b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a31d, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1007_a320, 5); calld(0x1007_5f6c, -0x43b9);            /* call 0x10075f6c */
            ii(0x1007_a325, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_a327, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_a328, 1); popd(edi);                              /* pop edi */
            ii(0x1007_a329, 1); popd(esi);                              /* pop esi */
            ii(0x1007_a32a, 1); popd(edx);                              /* pop edx */
            ii(0x1007_a32b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_a32c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_a32d, 1); retd(); return;                         /* ret */
        }
    }
}

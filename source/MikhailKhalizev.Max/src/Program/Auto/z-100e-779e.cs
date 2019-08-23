using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_779e-b5031d46")]
        public void Method_100e_779e()
        {
            ii(0x100e_779e, 5); pushd(0xb0);                            /* push 0xb0 */
            ii(0x100e_77a3, 5); calld(Definitions.sys_check_available_stack_size, 0x7_e5aa); /* call 0x10165d52 */
            ii(0x100e_77a8, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_77a9, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_77aa, 1); pushd(esi);                             /* push esi */
            ii(0x100e_77ab, 1); pushd(edi);                             /* push edi */
            ii(0x100e_77ac, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_77ad, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_77af, 6); sub(esp, 0x84);                         /* sub esp, 0x84 */
            ii(0x100e_77b5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_77b8, 3); mov(memb_a32[ss, ebp - 0x4], dl);       /* mov [ebp-0x4], dl */
            ii(0x100e_77bb, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100e_77c0, 5); calld(0x100e_883d, 0x1078);             /* call 0x100e883d */
            ii(0x100e_77c5, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x100e_77c8, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_77cb, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_77d0, 5); calld(Definitions.my_3_get_count, -0x5_c355); /* call 0x1008b480 */
            ii(0x100e_77d5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_77d8, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100e_77dc, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_77de, 6); if(jzd(0x100e_7b42, 0x35e)) goto l_0x100e_7b42; /* jz 0x100e7b42 */
            ii(0x100e_77e4, 4); add(memd_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* add dword [ebp-0x10], 0xffffffff */
            ii(0x100e_77e8, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100e_77ec, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_77f1, 5); calld(0x100e_84b8, 0xcc2);              /* call 0x100e84b8 */
            ii(0x100e_77f6, 3); lea(edi, ebp - 0x20);                   /* lea edi, [ebp-0x20] */
            ii(0x100e_77f9, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_77fb, 1); movsd_a32();                            /* movsd */
            ii(0x100e_77fc, 1); movsd_a32();                            /* movsd */
            ii(0x100e_77fd, 1); movsd_a32();                            /* movsd */
            ii(0x100e_77fe, 1); movsd_a32();                            /* movsd */
        l_0x100e_77ff:
            ii(0x100e_77ff, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x100e_7802, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100e_7807, 2); if(jzd(0x100e_785a, 0x51)) goto l_0x100e_785a; /* jz 0x100e785a */
            ii(0x100e_7809, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100e_780d, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_7812, 5); calld(0x100e_84b8, 0xca1);              /* call 0x100e84b8 */
            ii(0x100e_7817, 3); lea(edi, ebp - 0x30);                   /* lea edi, [ebp-0x30] */
            ii(0x100e_781a, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_781c, 1); movsd_a32();                            /* movsd */
            ii(0x100e_781d, 1); movsd_a32();                            /* movsd */
            ii(0x100e_781e, 1); movsd_a32();                            /* movsd */
            ii(0x100e_781f, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7820, 3); mov(edx, memd_a32[ss, ebp - 0x20]);     /* mov edx, [ebp-0x20] */
            ii(0x100e_7823, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_7826, 5); calld(Definitions.my_min, -0x5_e0a7);   /* call 0x10089784 */
            ii(0x100e_782b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100e_782e, 3); mov(edx, memd_a32[ss, ebp - 0x1c]);     /* mov edx, [ebp-0x1c] */
            ii(0x100e_7831, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100e_7834, 5); calld(Definitions.my_min, -0x5_e0b5);   /* call 0x10089784 */
            ii(0x100e_7839, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100e_783c, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_783f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_7842, 5); calld(0x1007_6e7c, -0x7_09cb);          /* call 0x10076e7c */
            ii(0x100e_7847, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_784a, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_784d, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_7850, 5); calld(0x1007_6e7c, -0x7_09d9);          /* call 0x10076e7c */
            ii(0x100e_7855, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_7858, 2); jmpd(0x100e_77ff, -0x5b); goto l_0x100e_77ff; /* jmp 0x100e77ff */
        l_0x100e_785a:
            ii(0x100e_785a, 4); sar(memd_a32[ss, ebp - 0x20], 0x6);     /* sar dword [ebp-0x20], 0x6 */
            ii(0x100e_785e, 4); sar(memd_a32[ss, ebp - 0x1c], 0x6);     /* sar dword [ebp-0x1c], 0x6 */
            ii(0x100e_7862, 6); mov(edx, memd_a32[ds, 0x101c_8170]);    /* mov edx, [0x101c8170] */
            ii(0x100e_7868, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_786b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_786e, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_7871, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_7874, 5); calld(Definitions.my_min, -0x5_e0f5);   /* call 0x10089784 */
            ii(0x100e_7879, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100e_787c, 6); mov(edx, memd_a32[ds, 0x101c_8172]);    /* mov edx, [0x101c8172] */
            ii(0x100e_7882, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7885, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_7888, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_788b, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_788e, 5); calld(Definitions.my_min, -0x5_e10f);   /* call 0x10089784 */
            ii(0x100e_7893, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100e_7896, 3); lea(edx, ebp - 0x20);                   /* lea edx, [ebp-0x20] */
            ii(0x100e_7899, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_789c, 5); calld(0x100e_7f49, 0x6a8);              /* call 0x100e7f49 */
            ii(0x100e_78a1, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100e_78a4, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x100e_78a7, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100e_78aa, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100e_78ad, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x100e_78b0, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100e_78b3, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100e_78b6, 5); calld(Definitions.my_ctor_0x101b_4184, -0x7_0dcb); /* call 0x10076af0 */
            ii(0x100e_78bb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_78be, 5); calld(0x100e_870c, 0xe49);              /* call 0x100e870c */
            ii(0x100e_78c3, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100e_78c6, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_78cb, 5); calld(Definitions.my_3_get_count, -0x5_c450); /* call 0x1008b480 */
            ii(0x100e_78d0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x100e_78d3:
            ii(0x100e_78d3, 3); dec(memd_a32[ss, ebp - 0x10]);          /* dec dword [ebp-0x10] */
            ii(0x100e_78d6, 5); cmp(memw_a32[ss, ebp - 0x10], -0x1 /* 0xff */); /* cmp word [ebp-0x10], 0xffff */
            ii(0x100e_78db, 6); if(jzd(0x100e_7b42, 0x261)) goto l_0x100e_7b42; /* jz 0x100e7b42 */
            ii(0x100e_78e1, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100e_78e5, 5); mov(eax, 0x101c_3620);                  /* mov eax, 0x101c3620 */
            ii(0x100e_78ea, 5); calld(0x100e_84b8, 0xbc9);              /* call 0x100e84b8 */
            ii(0x100e_78ef, 3); lea(edi, ebp - 0x30);                   /* lea edi, [ebp-0x30] */
            ii(0x100e_78f2, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x100e_78f4, 1); movsd_a32();                            /* movsd */
            ii(0x100e_78f5, 1); movsd_a32();                            /* movsd */
            ii(0x100e_78f6, 1); movsd_a32();                            /* movsd */
            ii(0x100e_78f7, 1); movsd_a32();                            /* movsd */
            ii(0x100e_78f8, 3); lea(edi, ebp - 0x50);                   /* lea edi, [ebp-0x50] */
            ii(0x100e_78fb, 3); lea(esi, ebp - 0x30);                   /* lea esi, [ebp-0x30] */
            ii(0x100e_78fe, 1); movsd_a32();                            /* movsd */
            ii(0x100e_78ff, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7900, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7901, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7902, 4); sar(memd_a32[ss, ebp - 0x30], 0x6);     /* sar dword [ebp-0x30], 0x6 */
            ii(0x100e_7906, 4); sar(memd_a32[ss, ebp - 0x2c], 0x6);     /* sar dword [ebp-0x2c], 0x6 */
            ii(0x100e_790a, 3); mov(edx, memd_a32[ss, ebp - 0x18]);     /* mov edx, [ebp-0x18] */
            ii(0x100e_790d, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_7910, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_7913, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_7916, 5); calld(Definitions.my_min, -0x5_e197);   /* call 0x10089784 */
            ii(0x100e_791b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100e_791e, 3); mov(edx, memd_a32[ss, ebp - 0x14]);     /* mov edx, [ebp-0x14] */
            ii(0x100e_7921, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_7924, 3); add(eax, 0x3f);                         /* add eax, 0x3f */
            ii(0x100e_7927, 3); sar(eax, 0x6);                          /* sar eax, 0x6 */
            ii(0x100e_792a, 5); calld(Definitions.my_min, -0x5_e1ab);   /* call 0x10089784 */
            ii(0x100e_792f, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100e_7932, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_7935, 4); mov(memw_a32[ss, ebp - 0x3c], ax);      /* mov [ebp-0x3c], ax */
            ii(0x100e_7939, 2); jmpd(0x100e_7942, 0x7); goto l_0x100e_7942; /* jmp 0x100e7942 */
        l_0x100e_793b:
            ii(0x100e_793b, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100e_793e, 4); inc(memw_a32[ss, ebp - 0x3c]);          /* inc word [ebp-0x3c] */
        l_0x100e_7942:
            ii(0x100e_7942, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100e_7946, 3); cmp(eax, memd_a32[ss, ebp - 0x28]);     /* cmp eax, [ebp-0x28] */
            ii(0x100e_7949, 2); if(jged(0x100e_7972, 0x27)) goto l_0x100e_7972; /* jge 0x100e7972 */
            ii(0x100e_794b, 3); mov(ebx, memd_a32[ss, ebp - 0x24]);     /* mov ebx, [ebp-0x24] */
            ii(0x100e_794e, 3); sub(ebx, memd_a32[ss, ebp - 0x2c]);     /* sub ebx, [ebp-0x2c] */
            ii(0x100e_7951, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100e_7956, 4); movsx(eax, memw_a32[ss, ebp - 0x3c]);   /* movsx eax, word [ebp-0x3c] */
            ii(0x100e_795a, 3); sub(eax, memd_a32[ss, ebp - 0x20]);     /* sub eax, [ebp-0x20] */
            ii(0x100e_795d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100e_7960, 3); add(eax, memd_a32[ss, ebp - 0x40]);     /* add eax, [ebp-0x40] */
            ii(0x100e_7963, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x100e_7965, 3); add(eax, memd_a32[ss, ebp - 0x2c]);     /* add eax, [ebp-0x2c] */
            ii(0x100e_7968, 3); sub(eax, memd_a32[ss, ebp - 0x1c]);     /* sub eax, [ebp-0x1c] */
            ii(0x100e_796b, 5); calld(Definitions.sys_memset, 0x7_e470); /* call 0x10165de0 */
            ii(0x100e_7970, 2); jmpd(0x100e_793b, -0x37); goto l_0x100e_793b; /* jmp 0x100e793b */
        l_0x100e_7972:
            ii(0x100e_7972, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7975, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7976, 3); lea(edi, ebp - 0x60);                   /* lea edi, [ebp-0x60] */
            ii(0x100e_7979, 3); lea(esi, ebp - 0x50);                   /* lea esi, [ebp-0x50] */
            ii(0x100e_797c, 1); movsd_a32();                            /* movsd */
            ii(0x100e_797d, 1); movsd_a32();                            /* movsd */
            ii(0x100e_797e, 1); movsd_a32();                            /* movsd */
            ii(0x100e_797f, 1); movsd_a32();                            /* movsd */
            ii(0x100e_7980, 3); pushd(memd_a32[ss, ebp - 0x54]);        /* push dword [ebp-0x54] */
            ii(0x100e_7983, 3); pushd(memd_a32[ss, ebp - 0x58]);        /* push dword [ebp-0x58] */
            ii(0x100e_7986, 3); pushd(memd_a32[ss, ebp - 0x5c]);        /* push dword [ebp-0x5c] */
            ii(0x100e_7989, 3); pushd(memd_a32[ss, ebp - 0x60]);        /* push dword [ebp-0x60] */
            ii(0x100e_798c, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100e_798f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100e_7992, 5); calld(0x100e_76d8, -0x2bf);             /* call 0x100e76d8 */
            ii(0x100e_7997, 4); cmp(memb_a32[ss, ebp - 0x4], 0);        /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100e_799b, 6); if(jzd(0x100e_7b3d, 0x19c)) goto l_0x100e_7b3d; /* jz 0x100e7b3d */
            ii(0x100e_79a1, 3); mov(edx, memd_a32[ss, ebp - 0x50]);     /* mov edx, [ebp-0x50] */
            ii(0x100e_79a4, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_79a7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_79a9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_79ac, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_79b2, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_79b8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_79bb, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_79bd, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x100e_79c0, 3); mov(edx, memd_a32[ss, ebp - 0x48]);     /* mov edx, [ebp-0x48] */
            ii(0x100e_79c3, 1); dec(edx);                               /* dec edx */
            ii(0x100e_79c4, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_79c7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_79c9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_79cc, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_79d2, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_79d8, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_79db, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_79dd, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x100e_79e0, 3); mov(edx, memd_a32[ss, ebp - 0x4c]);     /* mov edx, [ebp-0x4c] */
            ii(0x100e_79e3, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_79e6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_79e8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_79eb, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_79f1, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_79f7, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_79fa, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_79fc, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x100e_79ff, 3); mov(edx, memd_a32[ss, ebp - 0x44]);     /* mov edx, [ebp-0x44] */
            ii(0x100e_7a02, 1); dec(edx);                               /* dec edx */
            ii(0x100e_7a03, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7a06, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7a08, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7a0b, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7a11, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_7a17, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7a1a, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7a1c, 3); mov(memd_a32[ss, ebp - 0x70], eax);     /* mov [ebp-0x70], eax */
            ii(0x100e_7a1f, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100e_7a22, 3); sub(eax, memd_a32[ss, ebp - 0x30]);     /* sub eax, [ebp-0x30] */
            ii(0x100e_7a25, 3); mov(memd_a32[ss, ebp - 0x74], eax);     /* mov [ebp-0x74], eax */
            ii(0x100e_7a28, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100e_7a2b, 3); sub(eax, memd_a32[ss, ebp - 0x2c]);     /* sub eax, [ebp-0x2c] */
            ii(0x100e_7a2e, 3); mov(memd_a32[ss, ebp - 0x78], eax);     /* mov [ebp-0x78], eax */
            ii(0x100e_7a31, 3); mov(edx, memd_a32[ss, ebp - 0x30]);     /* mov edx, [ebp-0x30] */
            ii(0x100e_7a34, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x100e_7a37, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7a3a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7a3c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7a3f, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7a45, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100e_7a4b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7a4e, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7a50, 3); mov(memd_a32[ss, ebp - 0x7c], eax);     /* mov [ebp-0x7c], eax */
            ii(0x100e_7a53, 3); mov(edx, memd_a32[ss, ebp - 0x2c]);     /* mov edx, [ebp-0x2c] */
            ii(0x100e_7a56, 3); shl(edx, 0x6);                          /* shl edx, 0x6 */
            ii(0x100e_7a59, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100e_7a5c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100e_7a5e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100e_7a61, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100e_7a67, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100e_7a6d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_7a70, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100e_7a72, 3); mov(memd_a32[ss, ebp - 0x80], eax);     /* mov [ebp-0x80], eax */
            ii(0x100e_7a75, 10); mov(memd_a32[ss, ebp - 0x84], 0);      /* mov dword [ebp-0x84], 0x0 */
            ii(0x100e_7a7f, 2); jmpd(0x100e_7a96, 0x15); goto l_0x100e_7a96; /* jmp 0x100e7a96 */
        l_0x100e_7a81:
            ii(0x100e_7a81, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_7a87, 6); inc(memd_a32[ss, ebp - 0x84]);          /* inc dword [ebp-0x84] */
            ii(0x100e_7a8d, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100e_7a93, 3); add(memd_a32[ss, ebp - 0x7c], eax);     /* add [ebp-0x7c], eax */
        l_0x100e_7a96:
            ii(0x100e_7a96, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_7a9c, 4); cmp(ax, memw_a32[ss, ebp - 0x74]);      /* cmp ax, [ebp-0x74] */
            ii(0x100e_7aa0, 2); if(jgd(0x100e_7ad9, 0x37)) goto l_0x100e_7ad9; /* jg 0x100e7ad9 */
            ii(0x100e_7aa2, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100e_7aa5, 4); cmp(ax, memw_a32[ss, ebp - 0x64]);      /* cmp ax, [ebp-0x64] */
            ii(0x100e_7aa9, 2); if(jld(0x100e_7ab4, 0x9)) goto l_0x100e_7ab4; /* jl 0x100e7ab4 */
            ii(0x100e_7aab, 3); mov(eax, memd_a32[ss, ebp - 0x7c]);     /* mov eax, [ebp-0x7c] */
            ii(0x100e_7aae, 4); cmp(ax, memw_a32[ss, ebp - 0x68]);      /* cmp ax, [ebp-0x68] */
            ii(0x100e_7ab2, 2); if(jled(0x100e_7ab6, 0x2)) goto l_0x100e_7ab6; /* jle 0x100e7ab6 */
        l_0x100e_7ab4:
            ii(0x100e_7ab4, 2); jmpd(0x100e_7ad7, 0x21); goto l_0x100e_7ad7; /* jmp 0x100e7ad7 */
        l_0x100e_7ab6:
            ii(0x100e_7ab6, 2); pushd(0x25);                            /* push 0x25 */
            ii(0x100e_7ab8, 4); movsx(eax, memw_a32[ss, ebp - 0x70]);   /* movsx eax, word [ebp-0x70] */
            ii(0x100e_7abc, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7abd, 4); movsx(eax, memw_a32[ss, ebp - 0x7c]);   /* movsx eax, word [ebp-0x7c] */
            ii(0x100e_7ac1, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7ac2, 4); movsx(ecx, memw_a32[ss, ebp - 0x6c]);   /* movsx ecx, word [ebp-0x6c] */
            ii(0x100e_7ac6, 4); movsx(ebx, memw_a32[ss, ebp - 0x7c]);   /* movsx ebx, word [ebp-0x7c] */
            ii(0x100e_7aca, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_7acf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7ad2, 5); calld(/* sys */ 0x1016_a5a0, 0x8_2ac9); /* call 0x1016a5a0 */
        l_0x100e_7ad7:
            ii(0x100e_7ad7, 2); jmpd(0x100e_7a81, -0x58); goto l_0x100e_7a81; /* jmp 0x100e7a81 */
        l_0x100e_7ad9:
            ii(0x100e_7ad9, 10); mov(memd_a32[ss, ebp - 0x84], 0);      /* mov dword [ebp-0x84], 0x0 */
            ii(0x100e_7ae3, 2); jmpd(0x100e_7afa, 0x15); goto l_0x100e_7afa; /* jmp 0x100e7afa */
        l_0x100e_7ae5:
            ii(0x100e_7ae5, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_7aeb, 6); inc(memd_a32[ss, ebp - 0x84]);          /* inc dword [ebp-0x84] */
            ii(0x100e_7af1, 6); mov(ax, memw_a32[ds, 0x101c_38c0]);     /* mov ax, [0x101c38c0] */
            ii(0x100e_7af7, 3); add(memd_a32[ss, ebp - 0x80], eax);     /* add [ebp-0x80], eax */
        l_0x100e_7afa:
            ii(0x100e_7afa, 6); mov(eax, memd_a32[ss, ebp - 0x84]);     /* mov eax, [ebp-0x84] */
            ii(0x100e_7b00, 4); cmp(ax, memw_a32[ss, ebp - 0x78]);      /* cmp ax, [ebp-0x78] */
            ii(0x100e_7b04, 2); if(jgd(0x100e_7b3d, 0x37)) goto l_0x100e_7b3d; /* jg 0x100e7b3d */
            ii(0x100e_7b06, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100e_7b09, 4); cmp(ax, memw_a32[ss, ebp - 0x6c]);      /* cmp ax, [ebp-0x6c] */
            ii(0x100e_7b0d, 2); if(jld(0x100e_7b18, 0x9)) goto l_0x100e_7b18; /* jl 0x100e7b18 */
            ii(0x100e_7b0f, 3); mov(eax, memd_a32[ss, ebp - 0x80]);     /* mov eax, [ebp-0x80] */
            ii(0x100e_7b12, 4); cmp(ax, memw_a32[ss, ebp - 0x70]);      /* cmp ax, [ebp-0x70] */
            ii(0x100e_7b16, 2); if(jled(0x100e_7b1a, 0x2)) goto l_0x100e_7b1a; /* jle 0x100e7b1a */
        l_0x100e_7b18:
            ii(0x100e_7b18, 2); jmpd(0x100e_7b3b, 0x21); goto l_0x100e_7b3b; /* jmp 0x100e7b3b */
        l_0x100e_7b1a:
            ii(0x100e_7b1a, 2); pushd(0x25);                            /* push 0x25 */
            ii(0x100e_7b1c, 4); movsx(eax, memw_a32[ss, ebp - 0x80]);   /* movsx eax, word [ebp-0x80] */
            ii(0x100e_7b20, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7b21, 4); movsx(eax, memw_a32[ss, ebp - 0x68]);   /* movsx eax, word [ebp-0x68] */
            ii(0x100e_7b25, 1); pushd(eax);                             /* push eax */
            ii(0x100e_7b26, 4); movsx(ecx, memw_a32[ss, ebp - 0x80]);   /* movsx ecx, word [ebp-0x80] */
            ii(0x100e_7b2a, 4); movsx(ebx, memw_a32[ss, ebp - 0x64]);   /* movsx ebx, word [ebp-0x64] */
            ii(0x100e_7b2e, 5); mov(edx, 0x280);                        /* mov edx, 0x280 */
            ii(0x100e_7b33, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100e_7b36, 5); calld(/* sys */ 0x1016_a5a0, 0x8_2a65); /* call 0x1016a5a0 */
        l_0x100e_7b3b:
            ii(0x100e_7b3b, 2); jmpd(0x100e_7ae5, -0x58); goto l_0x100e_7ae5; /* jmp 0x100e7ae5 */
        l_0x100e_7b3d:
            ii(0x100e_7b3d, 5); jmpd(0x100e_78d3, -0x26f); goto l_0x100e_78d3; /* jmp 0x100e78d3 */
        l_0x100e_7b42:
            ii(0x100e_7b42, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_7b44, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_7b45, 1); popd(edi);                              /* pop edi */
            ii(0x100e_7b46, 1); popd(esi);                              /* pop esi */
            ii(0x100e_7b47, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_7b48, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_7b49, 1); retd();                                 /* ret */
        }
    }
}

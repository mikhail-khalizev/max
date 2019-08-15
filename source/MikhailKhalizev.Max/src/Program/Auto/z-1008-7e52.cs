using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d3610f53-29a7-466e-83fd-31c6c42edaf8")]
        public void Method_1008_7e52()
        {
            ii(0x1008_7e52, 5); pushd(0x88);                            /* push 0x88 */
            ii(0x1008_7e57, 5); calld(Definitions.sys_check_available_stack_size, 0xd_def6); /* call 0x10165d52 */
            ii(0x1008_7e5c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_7e5d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_7e5e, 1); pushd(edx);                             /* push edx */
            ii(0x1008_7e5f, 1); pushd(esi);                             /* push esi */
            ii(0x1008_7e60, 1); pushd(edi);                             /* push edi */
            ii(0x1008_7e61, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_7e62, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_7e64, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x1008_7e6a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_7e6d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7e6f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7e72, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7e75, 5); calld(0x1013_ad11, 0xb_2e97);           /* call 0x1013ad11 */
            ii(0x1008_7e7a, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7e7c, 6); if(jnzd(0x1008_8370, 0x4ee)) goto l_0x1008_8370; /* jnz 0x10088370 */
            ii(0x1008_7e82, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7e85, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7e88, 5); calld(0x1007_6574, -0x1_1919);          /* call 0x10076574 */
            ii(0x1008_7e8d, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1008_7e90, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_7e95, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_7e97, 2); if(jled(0x1008_7eb6, 0x1d)) goto l_0x1008_7eb6; /* jle 0x10087eb6 */
            ii(0x1008_7e99, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7e9c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_7e9f, 5); calld(0x1007_6574, -0x1_1930);          /* call 0x10076574 */
            ii(0x1008_7ea4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7ea6, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_7ea9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7eac, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_7eaf, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7eb2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_7eb4, 2); if(jzd(0x1008_7ecd, 0x17)) goto l_0x1008_7ecd; /* jz 0x10087ecd */
        l_0x1008_7eb6:
            ii(0x1008_7eb6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7eb9, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1008_7ebc, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_7ebf, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1008_7ec2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_7ec5, 3); calld_abs(memd_a32[ds, edx + 0x48]);    /* call dword [edx+0x48] */
            ii(0x1008_7ec8, 5); jmpd(0x1008_8370, 0x4a3); goto l_0x1008_8370; /* jmp 0x10088370 */
        l_0x1008_7ecd:
            ii(0x1008_7ecd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7ecf, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7ed2, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_7ed5, 5); calld(0x1013_ad11, 0xb_2e37);           /* call 0x1013ad11 */
            ii(0x1008_7eda, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7edc, 6); if(jzd(0x1008_80fb, 0x219)) goto l_0x1008_80fb; /* jz 0x100880fb */
            ii(0x1008_7ee2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7ee5, 4); cmp(memb_a32[ds, eax + 0x1d], 0);       /* cmp byte [eax+0x1d], 0x0 */
            ii(0x1008_7ee9, 6); if(jnzd(0x1008_80f6, 0x207)) goto l_0x1008_80f6; /* jnz 0x100880f6 */
            ii(0x1008_7eef, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_7ef3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_7ef6, 5); calld(0x1008_a958, 0x2a5d);             /* call 0x1008a958 */
            ii(0x1008_7efb, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1008_7efe, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_7f02, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7f05, 5); cmp(memw_a32[ds, eax + 0x1b], 0x4c);    /* cmp word [eax+0x1b], 0x4c */
            ii(0x1008_7f0a, 2); if(jzd(0x1008_7f16, 0xa)) goto l_0x1008_7f16; /* jz 0x10087f16 */
            ii(0x1008_7f0c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7f0f, 5); cmp(memw_a32[ds, eax + 0x1b], 0x37);    /* cmp word [eax+0x1b], 0x37 */
            ii(0x1008_7f14, 2); if(jnzd(0x1008_7f18, 0x2)) goto l_0x1008_7f18; /* jnz 0x10087f18 */
        l_0x1008_7f16:
            ii(0x1008_7f16, 2); jmpd(0x1008_7f26, 0xe); goto l_0x1008_7f26; /* jmp 0x10087f26 */
        l_0x1008_7f18:
            ii(0x1008_7f18, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7f1b, 5); cmp(memw_a32[ds, eax + 0x1b], 0x44);    /* cmp word [eax+0x1b], 0x44 */
            ii(0x1008_7f20, 6); if(jnzd(0x1008_804f, 0x129)) goto l_0x1008_804f; /* jnz 0x1008804f */
        l_0x1008_7f26:
            ii(0x1008_7f26, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1008_7f2b, 5); calld(0x1007_6338, -0x1_1bf8);          /* call 0x10076338 */
            ii(0x1008_7f30, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_7f32, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7f35, 5); calld(0x1007_64b8, -0x1_1a82);          /* call 0x100764b8 */
            ii(0x1008_7f3a, 3); lea(edx, ebp - 0x28);                   /* lea edx, [ebp-0x28] */
            ii(0x1008_7f3d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7f40, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_7f43, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7f46, 5); calld(0x1007_8137, -0xfe14);            /* call 0x10078137 */
            ii(0x1008_7f4b, 2); jmpd(0x1008_7f55, 0x8); goto l_0x1008_7f55; /* jmp 0x10087f55 */
        l_0x1008_7f4d:
            ii(0x1008_7f4d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7f50, 5); calld(0x1007_6bf8, -0x1_135d);          /* call 0x10076bf8 */
        l_0x1008_7f55:
            ii(0x1008_7f55, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7f57, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7f5a, 5); calld(0x1013_ad71, 0xb_2e12);           /* call 0x1013ad71 */
            ii(0x1008_7f5f, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7f61, 2); if(jzd(0x1008_7fab, 0x48)) goto l_0x1008_7fab; /* jz 0x10087fab */
            ii(0x1008_7f63, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7f66, 5); calld(0x1007_63a0, -0x1_1bcb);          /* call 0x100763a0 */
            ii(0x1008_7f6b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7f6d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_7f70, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7f73, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_7f76, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7f79, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_7f7b, 2); if(jzd(0x1008_7f94, 0x17)) goto l_0x1008_7f94; /* jz 0x10087f94 */
            ii(0x1008_7f7d, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7f80, 5); calld(0x1007_63a0, -0x1_1be5);          /* call 0x100763a0 */
            ii(0x1008_7f85, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1008_7f88, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_7f8d, 5); cmp(memb_a32[ds, eax + ebp - 0x28], 0); /* cmp byte [eax+ebp-0x28], 0x0 */
            ii(0x1008_7f92, 2); if(jnzd(0x1008_7f96, 0x2)) goto l_0x1008_7f96; /* jnz 0x10087f96 */
        l_0x1008_7f94:
            ii(0x1008_7f94, 2); jmpd(0x1008_7fa5, 0xf); goto l_0x1008_7fa5; /* jmp 0x10087fa5 */
        l_0x1008_7f96:
            ii(0x1008_7f96, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7f99, 5); calld(0x1007_63a0, -0x1_1bfe);          /* call 0x100763a0 */
            ii(0x1008_7f9e, 5); cmp(memw_a32[ds, eax + 0x8], 0x1b);     /* cmp word [eax+0x8], 0x1b */
            ii(0x1008_7fa3, 2); if(jzd(0x1008_7fa7, 0x2)) goto l_0x1008_7fa7; /* jz 0x10087fa7 */
        l_0x1008_7fa5:
            ii(0x1008_7fa5, 2); jmpd(0x1008_7fa9, 0x2); goto l_0x1008_7fa9; /* jmp 0x10087fa9 */
        l_0x1008_7fa7:
            ii(0x1008_7fa7, 2); jmpd(0x1008_7fab, 0x2); goto l_0x1008_7fab; /* jmp 0x10087fab */
        l_0x1008_7fa9:
            ii(0x1008_7fa9, 2); jmpd(0x1008_7f4d, -0x5e); goto l_0x1008_7f4d; /* jmp 0x10087f4d */
        l_0x1008_7fab:
            ii(0x1008_7fab, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7fad, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7fb0, 5); calld(0x1013_ad11, 0xb_2d5c);           /* call 0x1013ad11 */
            ii(0x1008_7fb5, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7fb7, 2); if(jzd(0x1008_801e, 0x65)) goto l_0x1008_801e; /* jz 0x1008801e */
            ii(0x1008_7fb9, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1008_7fbe, 5); calld(0x1007_6338, -0x1_1c8b);          /* call 0x10076338 */
            ii(0x1008_7fc3, 3); lea(ebx, ebp - 0x20);                   /* lea ebx, [ebp-0x20] */
            ii(0x1008_7fc6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_7fc8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1008_7fca, 5); calld(0x1007_643c, -0x1_1b93);          /* call 0x1007643c */
            ii(0x1008_7fcf, 2); jmpd(0x1008_7fd9, 0x8); goto l_0x1008_7fd9; /* jmp 0x10087fd9 */
        l_0x1008_7fd1:
            ii(0x1008_7fd1, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7fd4, 5); calld(0x1007_6bf8, -0x1_13e1);          /* call 0x10076bf8 */
        l_0x1008_7fd9:
            ii(0x1008_7fd9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7fdb, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7fde, 5); calld(0x1013_ad71, 0xb_2d8e);           /* call 0x1013ad71 */
            ii(0x1008_7fe3, 2); test(al, al);                           /* test al, al */
            ii(0x1008_7fe5, 2); if(jzd(0x1008_801e, 0x37)) goto l_0x1008_801e; /* jz 0x1008801e */
            ii(0x1008_7fe7, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_7fea, 5); calld(0x1007_63a0, -0x1_1c4f);          /* call 0x100763a0 */
            ii(0x1008_7fef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_7ff1, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1008_7ff4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_7ff7, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_7ffa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_7ffd, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_7fff, 2); if(jzd(0x1008_8018, 0x17)) goto l_0x1008_8018; /* jz 0x10088018 */
            ii(0x1008_8001, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_8004, 5); calld(0x1007_63a0, -0x1_1c69);          /* call 0x100763a0 */
            ii(0x1008_8009, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1008_800c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_8011, 5); cmp(memb_a32[ds, eax + ebp - 0x28], 0); /* cmp byte [eax+ebp-0x28], 0x0 */
            ii(0x1008_8016, 2); if(jnzd(0x1008_801a, 0x2)) goto l_0x1008_801a; /* jnz 0x1008801a */
        l_0x1008_8018:
            ii(0x1008_8018, 2); jmpd(0x1008_801c, 0x2); goto l_0x1008_801c; /* jmp 0x1008801c */
        l_0x1008_801a:
            ii(0x1008_801a, 2); jmpd(0x1008_801e, 0x2); goto l_0x1008_801e; /* jmp 0x1008801e */
        l_0x1008_801c:
            ii(0x1008_801c, 2); jmpd(0x1008_7fd1, -0x4d); goto l_0x1008_7fd1; /* jmp 0x10087fd1 */
        l_0x1008_801e:
            ii(0x1008_801e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8020, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_8023, 5); calld(0x1013_ad11, 0xb_2ce9);           /* call 0x1013ad11 */
            ii(0x1008_8028, 2); test(al, al);                           /* test al, al */
            ii(0x1008_802a, 2); if(jzd(0x1008_8045, 0x19)) goto l_0x1008_8045; /* jz 0x10088045 */
            ii(0x1008_802c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_802e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_8031, 5); calld(0x1007_5f6c, -0x1_20ca);          /* call 0x10075f6c */
            ii(0x1008_8036, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8038, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_803b, 5); calld(0x1008_8cbc, 0xc7c);              /* call 0x10088cbc */
            ii(0x1008_8040, 5); jmpd(0x1008_8370, 0x32b); goto l_0x1008_8370; /* jmp 0x10088370 */
        l_0x1008_8045:
            ii(0x1008_8045, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8047, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x1008_804a, 5); calld(0x1007_5f6c, -0x1_20e3);          /* call 0x10075f6c */
        l_0x1008_804f:
            ii(0x1008_804f, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1008_8054, 5); calld(Definitions.sys_new, 0xd_dda7);   /* call 0x10165e00 */
            ii(0x1008_8059, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x1008_805c, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_805f, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x1008_8062, 4); cmp(memd_a32[ss, ebp - 0x30], 0);       /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1008_8066, 2); if(jzd(0x1008_80aa, 0x42)) goto l_0x1008_80aa; /* jz 0x100880aa */
            ii(0x1008_8068, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_806b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_806e, 5); calld(0x1007_6574, -0x1_1aff);          /* call 0x10076574 */
            ii(0x1008_8073, 3); mov(ebx, memd_a32[ds, eax + 0x1a]);     /* mov ebx, [eax+0x1a] */
            ii(0x1008_8076, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1008_8079, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_807c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1008_807f, 5); calld(0x1007_6574, -0x1_1b10);          /* call 0x10076574 */
            ii(0x1008_8084, 3); mov(edx, memd_a32[ds, eax + 0x18]);     /* mov edx, [eax+0x18] */
            ii(0x1008_8087, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_808a, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1008_808d, 5); calld(0x1007_6aac, -0x1_15e6);          /* call 0x10076aac */
            ii(0x1008_8092, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_8094, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_8097, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x1008_809a, 5); calld(Definitions.my_ctor_c12, 0x1_dfcd); /* call 0x100a606c */
            ii(0x1008_809f, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x1008_80a2, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x1008_80a5, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x1008_80a8, 2); jmpd(0x1008_80b0, 0x6); goto l_0x1008_80b0; /* jmp 0x100880b0 */
        l_0x1008_80aa:
            ii(0x1008_80aa, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1008_80ad, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
        l_0x1008_80b0:
            ii(0x1008_80b0, 3); mov(edx, memd_a32[ss, ebp - 0x3c]);     /* mov edx, [ebp-0x3c] */
            ii(0x1008_80b3, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_80b6, 5); calld(0x1008_a898, 0x27dd);             /* call 0x1008a898 */
            ii(0x1008_80bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_80be, 3); mov(edx, memd_a32[ds, eax + 0x19]);     /* mov edx, [eax+0x19] */
            ii(0x1008_80c1, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_80c4, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_80c7, 5); calld(0x1008_a7dc, 0x2710);             /* call 0x1008a7dc */
            ii(0x1008_80cc, 5); calld(0x100a_63bc, 0x1_e2eb);           /* call 0x100a63bc */
            ii(0x1008_80d1, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_80d4, 5); calld(0x1008_a838, 0x275f);             /* call 0x1008a838 */
            ii(0x1008_80d9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_80db, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_80e0, 5); calld(0x100a_4d50, 0x1_cc6b);           /* call 0x100a4d50 */
            ii(0x1008_80e5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_80e8, 4); mov(memb_a32[ds, eax + 0x1d], 0x1);     /* mov byte [eax+0x1d], 0x1 */
            ii(0x1008_80ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_80ee, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x1008_80f1, 5); calld(0x1008_8cbc, 0xbc6);              /* call 0x10088cbc */
        l_0x1008_80f6:
            ii(0x1008_80f6, 5); jmpd(0x1008_8370, 0x275); goto l_0x1008_8370; /* jmp 0x10088370 */
        l_0x1008_80fb:
            ii(0x1008_80fb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_80fe, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_8101, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_8104, 5); calld(0x1007_6574, -0x1_1b95);          /* call 0x10076574 */
            ii(0x1008_8109, 5); calld(0x1015_2a52, 0xc_a944);           /* call 0x10152a52 */
            ii(0x1008_810e, 2); test(al, al);                           /* test al, al */
            ii(0x1008_8110, 6); if(jzd(0x1008_8370, 0x25a)) goto l_0x1008_8370; /* jz 0x10088370 */
            ii(0x1008_8116, 4); or(memb_a32[ss, ebp - 0x8], 0x1);       /* or byte [ebp-0x8], 0x1 */
            ii(0x1008_811a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_811d, 5); calld(Definitions.my_ctor_0x101b_3b58, 0x2f82); /* call 0x1008b0a4 */
            ii(0x1008_8122, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_8125, 4); and(memb_a32[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x1008_8129, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_812c, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_812f, 5); calld(0x1007_6574, -0x1_1bc0);          /* call 0x10076574 */
            ii(0x1008_8134, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8136, 3); mov(dl, memb_a32[ds, eax + 0x54]);      /* mov dl, [eax+0x54] */
            ii(0x1008_8139, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_813c, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_813f, 5); calld(0x1007_6574, -0x1_1bd0);          /* call 0x10076574 */
            ii(0x1008_8144, 5); calld(0x1007_623c, -0x1_1f0d);          /* call 0x1007623c */
            ii(0x1008_8149, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1008_814c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_814f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1008_8151, 2); if(jged(0x1008_81c0, 0x6d)) goto l_0x1008_81c0; /* jge 0x100881c0 */
            ii(0x1008_8153, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1008_8158, 5); calld(Definitions.sys_new, 0xd_dca3);   /* call 0x10165e00 */
            ii(0x1008_815d, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x1008_8160, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1008_8163, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1008_8166, 4); cmp(memd_a32[ss, ebp - 0x44], 0);       /* cmp dword [ebp-0x44], 0x0 */
            ii(0x1008_816a, 2); if(jzd(0x1008_818c, 0x20)) goto l_0x1008_818c; /* jz 0x1008818c */
            ii(0x1008_816c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_816f, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_8172, 5); calld(0x1007_65d0, -0x1_1ba7);          /* call 0x100765d0 */
            ii(0x1008_8177, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_8179, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1008_817c, 5); calld(Definitions.my_ctor_c16, 0x4_4ca9); /* call 0x100cce2a */
            ii(0x1008_8181, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1008_8184, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x1008_8187, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x1008_818a, 2); jmpd(0x1008_8192, 0x6); goto l_0x1008_8192; /* jmp 0x10088192 */
        l_0x1008_818c:
            ii(0x1008_818c, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x1008_818f, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
        l_0x1008_8192:
            ii(0x1008_8192, 3); mov(edx, memd_a32[ss, ebp - 0x4c]);     /* mov edx, [ebp-0x4c] */
            ii(0x1008_8195, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_8198, 5); calld(0x1008_afe4, 0x2e47);             /* call 0x1008afe4 */
            ii(0x1008_819d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_81a0, 5); calld(0x1008_af84, 0x2ddf);             /* call 0x1008af84 */
            ii(0x1008_81a5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_81a7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_81ac, 5); calld(0x100a_4d50, 0x1_cb9f);           /* call 0x100a4d50 */
            ii(0x1008_81b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_81b3, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_81b6, 5); calld(0x1008_8b7c, 0x9c1);              /* call 0x10088b7c */
            ii(0x1008_81bb, 5); jmpd(0x1008_8370, 0x1b0); goto l_0x1008_8370; /* jmp 0x10088370 */
        l_0x1008_81c0:
            ii(0x1008_81c0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_81c3, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_81c6, 5); calld(0x1007_6574, -0x1_1c57);          /* call 0x10076574 */
            ii(0x1008_81cb, 5); calld(0x1007_623c, -0x1_1f94);          /* call 0x1007623c */
            ii(0x1008_81d0, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1008_81d3, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1008_81d6, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1008_81d8, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1008_81db, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1008_81dd, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x1008_81df, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_81e1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_81e4, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_81e7, 5); calld(0x1007_6574, -0x1_1c78);          /* call 0x10076574 */
            ii(0x1008_81ec, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1008_81ef, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_81f4, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1008_81f6, 2); if(jged(0x1008_8207, 0xf)) goto l_0x1008_8207; /* jge 0x10088207 */
            ii(0x1008_81f8, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1008_81fd, 5); calld(0x1007_5fdc, -0x1_2226);          /* call 0x10075fdc */
            ii(0x1008_8202, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x1008_8205, 2); if(jged(0x1008_8209, 0x2)) goto l_0x1008_8209; /* jge 0x10088209 */
        l_0x1008_8207:
            ii(0x1008_8207, 2); jmpd(0x1008_8276, 0x6d); goto l_0x1008_8276; /* jmp 0x10088276 */
        l_0x1008_8209:
            ii(0x1008_8209, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1008_820e, 5); calld(Definitions.sys_new, 0xd_dbed);   /* call 0x10165e00 */
            ii(0x1008_8213, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x1008_8216, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1008_8219, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x1008_821c, 4); cmp(memd_a32[ss, ebp - 0x54], 0);       /* cmp dword [ebp-0x54], 0x0 */
            ii(0x1008_8220, 2); if(jzd(0x1008_8242, 0x20)) goto l_0x1008_8242; /* jz 0x10088242 */
            ii(0x1008_8222, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_8225, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_8228, 5); calld(0x1007_65d0, -0x1_1c5d);          /* call 0x100765d0 */
            ii(0x1008_822d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_822f, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x1008_8232, 5); calld(Definitions.my_ctor_c15, 0x4_3651); /* call 0x100cb888 */
            ii(0x1008_8237, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x1008_823a, 3); mov(eax, memd_a32[ss, ebp - 0x58]);     /* mov eax, [ebp-0x58] */
            ii(0x1008_823d, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
            ii(0x1008_8240, 2); jmpd(0x1008_8248, 0x6); goto l_0x1008_8248; /* jmp 0x10088248 */
        l_0x1008_8242:
            ii(0x1008_8242, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x1008_8245, 3); mov(memd_a32[ss, ebp - 0x5c], eax);     /* mov [ebp-0x5c], eax */
        l_0x1008_8248:
            ii(0x1008_8248, 3); mov(edx, memd_a32[ss, ebp - 0x5c]);     /* mov edx, [ebp-0x5c] */
            ii(0x1008_824b, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_824e, 5); calld(0x1008_afe4, 0x2d91);             /* call 0x1008afe4 */
            ii(0x1008_8253, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_8256, 5); calld(0x1008_af84, 0x2d29);             /* call 0x1008af84 */
            ii(0x1008_825b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_825d, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_8262, 5); calld(0x100a_4d50, 0x1_cae9);           /* call 0x100a4d50 */
            ii(0x1008_8267, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8269, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_826c, 5); calld(0x1008_8b7c, 0x90b);              /* call 0x10088b7c */
            ii(0x1008_8271, 5); jmpd(0x1008_8370, 0xfa); goto l_0x1008_8370; /* jmp 0x10088370 */
        l_0x1008_8276:
            ii(0x1008_8276, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_8279, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_827c, 5); calld(0x1007_6574, -0x1_1d0d);          /* call 0x10076574 */
            ii(0x1008_8281, 4); test(memb_a32[ds, eax + 0x15], 0x10);   /* test byte [eax+0x15], 0x10 */
            ii(0x1008_8285, 2); if(jnzd(0x1008_8296, 0xf)) goto l_0x1008_8296; /* jnz 0x10088296 */
            ii(0x1008_8287, 5); mov(eax, 0x4c);                         /* mov eax, 0x4c */
            ii(0x1008_828c, 5); calld(0x1007_5fdc, -0x1_22b5);          /* call 0x10075fdc */
            ii(0x1008_8291, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x1008_8294, 2); if(jged(0x1008_8298, 0x2)) goto l_0x1008_8298; /* jge 0x10088298 */
        l_0x1008_8296:
            ii(0x1008_8296, 2); jmpd(0x1008_82ce, 0x36); goto l_0x1008_82ce; /* jmp 0x100882ce */
        l_0x1008_8298:
            ii(0x1008_8298, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_829b, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_829e, 5); calld(0x1007_65d0, -0x1_1cd3);          /* call 0x100765d0 */
            ii(0x1008_82a3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_82a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_82a8, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_82ab, 5); calld(0x1007_6574, -0x1_1d3c);          /* call 0x10076574 */
            ii(0x1008_82b0, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1008_82b3, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_82b8, 6); imul(ebx, eax, 0xc5);                   /* imul ebx, eax, 0xc5 */
            ii(0x1008_82be, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_82c3, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_82c5, 5); calld(0x100c_343a, 0x3_b170);           /* call 0x100c343a */
            ii(0x1008_82ca, 2); test(al, al);                           /* test al, al */
            ii(0x1008_82cc, 2); if(jnzd(0x1008_82d0, 0x2)) goto l_0x1008_82d0; /* jnz 0x100882d0 */
        l_0x1008_82ce:
            ii(0x1008_82ce, 2); jmpd(0x1008_833a, 0x6a); goto l_0x1008_833a; /* jmp 0x1008833a */
        l_0x1008_82d0:
            ii(0x1008_82d0, 5); mov(eax, 0x1b);                         /* mov eax, 0x1b */
            ii(0x1008_82d5, 5); calld(Definitions.sys_new, 0xd_db26);   /* call 0x10165e00 */
            ii(0x1008_82da, 3); mov(memd_a32[ss, ebp - 0x60], eax);     /* mov [ebp-0x60], eax */
            ii(0x1008_82dd, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1008_82e0, 3); mov(memd_a32[ss, ebp - 0x64], eax);     /* mov [ebp-0x64], eax */
            ii(0x1008_82e3, 4); cmp(memd_a32[ss, ebp - 0x64], 0);       /* cmp dword [ebp-0x64], 0x0 */
            ii(0x1008_82e7, 2); if(jzd(0x1008_8309, 0x20)) goto l_0x1008_8309; /* jz 0x10088309 */
            ii(0x1008_82e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_82ec, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_82ef, 5); calld(0x1007_65d0, -0x1_1d24);          /* call 0x100765d0 */
            ii(0x1008_82f4, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_82f6, 3); mov(eax, memd_a32[ss, ebp - 0x60]);     /* mov eax, [ebp-0x60] */
            ii(0x1008_82f9, 5); calld(Definitions.my_ctor_c18, 0x4_505f); /* call 0x100cd35d */
            ii(0x1008_82fe, 3); mov(memd_a32[ss, ebp - 0x68], eax);     /* mov [ebp-0x68], eax */
            ii(0x1008_8301, 3); mov(eax, memd_a32[ss, ebp - 0x68]);     /* mov eax, [ebp-0x68] */
            ii(0x1008_8304, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
            ii(0x1008_8307, 2); jmpd(0x1008_830f, 0x6); goto l_0x1008_830f; /* jmp 0x1008830f */
        l_0x1008_8309:
            ii(0x1008_8309, 3); mov(eax, memd_a32[ss, ebp - 0x64]);     /* mov eax, [ebp-0x64] */
            ii(0x1008_830c, 3); mov(memd_a32[ss, ebp - 0x6c], eax);     /* mov [ebp-0x6c], eax */
        l_0x1008_830f:
            ii(0x1008_830f, 3); mov(edx, memd_a32[ss, ebp - 0x6c]);     /* mov edx, [ebp-0x6c] */
            ii(0x1008_8312, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_8315, 5); calld(0x1008_afe4, 0x2cca);             /* call 0x1008afe4 */
            ii(0x1008_831a, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_831d, 5); calld(0x1008_af84, 0x2c62);             /* call 0x1008af84 */
            ii(0x1008_8322, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_8324, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_8329, 5); calld(0x100a_4d50, 0x1_ca22);           /* call 0x100a4d50 */
            ii(0x1008_832e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8330, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_8333, 5); calld(0x1008_8b7c, 0x844);              /* call 0x10088b7c */
            ii(0x1008_8338, 2); jmpd(0x1008_8370, 0x36); goto l_0x1008_8370; /* jmp 0x10088370 */
        l_0x1008_833a:
            ii(0x1008_833a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_833d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_8340, 5); calld(0x1007_6574, -0x1_1dd1);          /* call 0x10076574 */
            ii(0x1008_8345, 3); mov(al, memb_a32[ds, eax + 0x4e]);      /* mov al, [eax+0x4e] */
            ii(0x1008_8348, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1008_834d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_834f, 2); if(jled(0x1008_8366, 0x15)) goto l_0x1008_8366; /* jle 0x10088366 */
            ii(0x1008_8351, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8356, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_8359, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1008_835c, 5); calld(0x1007_65d0, -0x1_1d91);          /* call 0x100765d0 */
            ii(0x1008_8361, 5); calld(0x100a_297d, 0x1_a617);           /* call 0x100a297d */
        l_0x1008_8366:
            ii(0x1008_8366, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_8368, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1008_836b, 5); calld(0x1008_8b7c, 0x80c);              /* call 0x10088b7c */
        l_0x1008_8370:
            ii(0x1008_8370, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8372, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_8373, 1); popd(edi);                              /* pop edi */
            ii(0x1008_8374, 1); popd(esi);                              /* pop esi */
            ii(0x1008_8375, 1); popd(edx);                              /* pop edx */
            ii(0x1008_8376, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_8377, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_8378, 1); retd(); return;                         /* ret */
        }
    }
}

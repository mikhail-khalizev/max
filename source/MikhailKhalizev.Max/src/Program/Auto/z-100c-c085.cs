using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_c085-e4a6d3e2")]
        public void Method_100c_c085()
        {
            ii(0x100c_c085, 5); push(0x88);                             /* push 0x88 */
            ii(0x100c_c08a, 5); call(Definitions.sys_check_available_stack_size, 0x9_9cc3); /* call 0x10165d52 */
            ii(0x100c_c08f, 1); push(ebx);                              /* push ebx */
            ii(0x100c_c090, 1); push(ecx);                              /* push ecx */
            ii(0x100c_c091, 1); push(esi);                              /* push esi */
            ii(0x100c_c092, 1); push(edi);                              /* push edi */
            ii(0x100c_c093, 1); push(ebp);                              /* push ebp */
            ii(0x100c_c094, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_c096, 6); sub(esp, 0x6c);                         /* sub esp, 0x6c */
            ii(0x100c_c09c, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_c09f, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_c0a2, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_c0a5, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_c0a8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_c0ab, 5); call(0x1007_6d98, -0x5_5318);           /* call 0x10076d98 */
            ii(0x100c_c0b0, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c0b2, 6); if(jz(0x100c_c5d6, 0x51e)) goto l_0x100c_c5d6; /* jz 0x100cc5d6 */
            ii(0x100c_c0b8, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c0bb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c0be, 5); call(0x1007_6574, -0x5_5b4f);           /* call 0x10076574 */
            ii(0x100c_c0c3, 5); call(0x1015_26ac, 0x8_65e4);            /* call 0x101526ac */
            ii(0x100c_c0c8, 3); cmp(eax, memd[ss, ebp - 8]);            /* cmp eax, [ebp-0x8] */
            ii(0x100c_c0cb, 2); if(jz(0x100c_c0d6, 9)) goto l_0x100c_c0d6; /* jz 0x100cc0d6 */
            ii(0x100c_c0cd, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_c0d1, 5); jmp(0x100c_c5da, 0x504); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c0d6:
            ii(0x100c_c0d6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c0d9, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_c0dc, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_c0df, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_c0e2, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_c0e5, 3); call_abs(memd[ds, edx + 120]);          /* call dword [edx+0x78] */
            ii(0x100c_c0e8, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c0ea, 6); if(jz(0x100c_c1fa, 0x10a)) goto l_0x100c_c1fa; /* jz 0x100cc1fa */
            ii(0x100c_c0f0, 4); or(memb[ss, ebp - 16], 1);              /* or byte [ebp-0x10], 0x1 */
            ii(0x100c_c0f4, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100c_c0f7, 5); call(Definitions.my_ctor_0x101b_3b58, -0x4_1058); /* call 0x1008b0a4 */
            ii(0x100c_c0fc, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_c0ff, 4); and(memb[ss, ebp - 16], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x100c_c103, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c106, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c109, 5); call(0x1007_6574, -0x5_5b9a);           /* call 0x10076574 */
            ii(0x100c_c10e, 4); cmp(memb[ds, eax + 62], 3);             /* cmp byte [eax+0x3e], 0x3 */
            ii(0x100c_c112, 6); if(jnz(0x100c_c19e, 0x86)) goto l_0x100c_c19e; /* jnz 0x100cc19e */
            ii(0x100c_c118, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100c_c11d, 5); call(Definitions.sys_new, 0x9_9cde);    /* call 0x10165e00 */
            ii(0x100c_c122, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_c125, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_c128, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x100c_c12b, 4); cmp(memd[ss, ebp - 36], 0);             /* cmp dword [ebp-0x24], 0x0 */
            ii(0x100c_c12f, 2); if(jz(0x100c_c166, 0x35)) goto l_0x100c_c166; /* jz 0x100cc166 */
            ii(0x100c_c131, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c134, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c137, 5); call(0x1007_6574, -0x5_5bc8);           /* call 0x10076574 */
            ii(0x100c_c13c, 5); call(0x1007_611c, -0x5_6025);           /* call 0x1007611c */
            ii(0x100c_c141, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100c_c143, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100c_c146, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c149, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c14c, 5); call(0x1007_65d0, -0x5_5b81);           /* call 0x100765d0 */
            ii(0x100c_c151, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c153, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x100c_c156, 5); call(0x100b_3871, -0x1_88ea);           /* call 0x100b3871 */
            ii(0x100c_c15b, 3); mov(memd[ss, ebp - 40], eax);           /* mov [ebp-0x28], eax */
            ii(0x100c_c15e, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x100c_c161, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x100c_c164, 2); jmp(0x100c_c16c, 6); goto l_0x100c_c16c; /* jmp 0x100cc16c */
        l_0x100c_c166:
            ii(0x100c_c166, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x100c_c169, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
        l_0x100c_c16c:
            ii(0x100c_c16c, 3); mov(edx, memd[ss, ebp - 44]);           /* mov edx, [ebp-0x2c] */
            ii(0x100c_c16f, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100c_c172, 5); call(0x1008_afe4, -0x4_1193);           /* call 0x1008afe4 */
            ii(0x100c_c177, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100c_c17a, 5); call(0x1008_af84, -0x4_11fb);           /* call 0x1008af84 */
            ii(0x100c_c17f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c181, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_c186, 5); call(0x100a_4d50, -0x2_743b);           /* call 0x100a4d50 */
            ii(0x100c_c18b, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c18f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c191, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100c_c194, 5); call(0x1008_8b7c, -0x4_361d);           /* call 0x10088b7c */
            ii(0x100c_c199, 5); jmp(0x100c_c5da, 0x43c); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c19e:
            ii(0x100c_c19e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_c1a1, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100c_c1a4, 5); call(0x1008_afe4, -0x4_11c5);           /* call 0x1008afe4 */
            ii(0x100c_c1a9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c1ac, 5); call(0x100c_cd68, 0xbb7);               /* call 0x100ccd68 */
            ii(0x100c_c1b1, 5); call(0x1008_ac50, -0x4_1566);           /* call 0x1008ac50 */
            ii(0x100c_c1b6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_c1b8, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100c_c1ba, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_c1bd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c1c0, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c1c3, 5); call(0x1007_6574, -0x5_5c54);           /* call 0x10076574 */
            ii(0x100c_c1c8, 5); call(0x1015_2962, 0x8_6795);            /* call 0x10152962 */
            ii(0x100c_c1cd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c1cf, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c1d2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c1d5, 5); call(0x1007_6630, -0x5_5baa);           /* call 0x10076630 */
            ii(0x100c_c1da, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_c1dd, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_c1e2, 5); call(0x100a_5e27, -0x2_63c0);           /* call 0x100a5e27 */
            ii(0x100c_c1e7, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c1eb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c1ed, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x100c_c1f0, 5); call(0x1008_8b7c, -0x4_3679);           /* call 0x10088b7c */
            ii(0x100c_c1f5, 5); jmp(0x100c_c5da, 0x3e0); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c1fa:
            ii(0x100c_c1fa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c1fc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c1ff, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c202, 5); call(0x1013_ad11, 0x6_eb0a);            /* call 0x1013ad11 */
            ii(0x100c_c207, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c209, 2); if(jz(0x100c_c213, 8)) goto l_0x100c_c213; /* jz 0x100cc213 */
            ii(0x100c_c20b, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c20e, 5); call(0x100c_c6df, 0x4cc);               /* call 0x100cc6df */
        l_0x100c_c213:
            ii(0x100c_c213, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c215, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c218, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c21b, 5); call(0x1013_ad11, 0x6_eaf1);            /* call 0x1013ad11 */
            ii(0x100c_c220, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c222, 6); if(jz(0x100c_c2d7, 0xaf)) goto l_0x100c_c2d7; /* jz 0x100cc2d7 */
            ii(0x100c_c228, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c22b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c22e, 5); call(0x1007_6574, -0x5_5cbf);           /* call 0x10076574 */
            ii(0x100c_c233, 3); mov(al, memb[ds, eax + 78]);            /* mov al, [eax+0x4e] */
            ii(0x100c_c236, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_c23b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c23d, 2); if(jle(0x100c_c256, 0x17)) goto l_0x100c_c256; /* jle 0x100cc256 */
            ii(0x100c_c23f, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_c242, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c245, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c248, 5); call(0x1007_6574, -0x5_5cd9);           /* call 0x10076574 */
            ii(0x100c_c24d, 5); call(0x1015_2a52, 0x8_6800);            /* call 0x10152a52 */
            ii(0x100c_c252, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c254, 2); if(jnz(0x100c_c258, 2)) goto l_0x100c_c258; /* jnz 0x100cc258 */
        l_0x100c_c256:
            ii(0x100c_c256, 2); jmp(0x100c_c2ce, 0x76); goto l_0x100c_c2ce; /* jmp 0x100cc2ce */
        l_0x100c_c258:
            ii(0x100c_c258, 5); mov(eax, 0x17);                         /* mov eax, 0x17 */
            ii(0x100c_c25d, 5); call(Definitions.sys_new, 0x9_9b9e);    /* call 0x10165e00 */
            ii(0x100c_c262, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x100c_c265, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x100c_c268, 3); mov(memd[ss, ebp - 52], eax);           /* mov [ebp-0x34], eax */
            ii(0x100c_c26b, 4); cmp(memd[ss, ebp - 52], 0);             /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100c_c26f, 2); if(jz(0x100c_c296, 0x25)) goto l_0x100c_c296; /* jz 0x100cc296 */
            ii(0x100c_c271, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x100c_c274, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c277, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c27a, 5); call(0x1007_65d0, -0x5_5caf);           /* call 0x100765d0 */
            ii(0x100c_c27f, 3); mov(ecx, memd[ss, ebp - 48]);           /* mov ecx, [ebp-0x30] */
            ii(0x100c_c282, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c284, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_c286, 5); call(0x100b_524c, -0x1_703f);           /* call 0x100b524c */
            ii(0x100c_c28b, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x100c_c28e, 3); mov(eax, memd[ss, ebp - 56]);           /* mov eax, [ebp-0x38] */
            ii(0x100c_c291, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
            ii(0x100c_c294, 2); jmp(0x100c_c29c, 6); goto l_0x100c_c29c; /* jmp 0x100cc29c */
        l_0x100c_c296:
            ii(0x100c_c296, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x100c_c299, 3); mov(memd[ss, ebp - 60], eax);           /* mov [ebp-0x3c], eax */
        l_0x100c_c29c:
            ii(0x100c_c29c, 3); mov(edx, memd[ss, ebp - 60]);           /* mov edx, [ebp-0x3c] */
            ii(0x100c_c29f, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x100c_c2a2, 5); call(0x1008_b060, -0x4_1247);           /* call 0x1008b060 */
            ii(0x100c_c2a7, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x100c_c2aa, 5); call(0x1008_af84, -0x4_132b);           /* call 0x1008af84 */
            ii(0x100c_c2af, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c2b1, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_c2b6, 5); call(0x100a_4d50, -0x2_756b);           /* call 0x100a4d50 */
            ii(0x100c_c2bb, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c2bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c2c1, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x100c_c2c4, 5); call(0x1008_8b7c, -0x4_374d);           /* call 0x10088b7c */
            ii(0x100c_c2c9, 5); jmp(0x100c_c5da, 0x30c); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c2ce:
            ii(0x100c_c2ce, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_c2d2, 5); jmp(0x100c_c5da, 0x303); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c2d7:
            ii(0x100c_c2d7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c2da, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c2dd, 5); call(0x1007_6574, -0x5_5d6e);           /* call 0x10076574 */
            ii(0x100c_c2e2, 4); cmp(memb[ds, eax + 62], 3);             /* cmp byte [eax+0x3e], 0x3 */
            ii(0x100c_c2e6, 2); if(jnz(0x100c_c319, 0x31)) goto l_0x100c_c319; /* jnz 0x100cc319 */
            ii(0x100c_c2e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_c2ea, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100c_c2ef, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c2f1, 2); if(jnz(0x100c_c308, 0x15)) goto l_0x100c_c308; /* jnz 0x100cc308 */
            ii(0x100c_c2f3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c2f6, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100c_c2f9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c2fc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c2fe, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100c_c304, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_c306, 2); if(jnz(0x100c_c310, 8)) goto l_0x100c_c310; /* jnz 0x100cc310 */
        l_0x100c_c308:
            ii(0x100c_c308, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c30b, 5); call(0x100c_c90c, 0x5fc);               /* call 0x100cc90c */
        l_0x100c_c310:
            ii(0x100c_c310, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c314, 5); jmp(0x100c_c5da, 0x2c1); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c319:
            ii(0x100c_c319, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c31c, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c31f, 5); call(0x1007_6574, -0x5_5db0);           /* call 0x10076574 */
            ii(0x100c_c324, 4); test(memb[ds, eax + 19], 2);            /* test byte [eax+0x13], 0x2 */
            ii(0x100c_c328, 2); if(jnz(0x100c_c33f, 0x15)) goto l_0x100c_c33f; /* jnz 0x100cc33f */
            ii(0x100c_c32a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c32d, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c330, 5); call(0x1007_6574, -0x5_5dc1);           /* call 0x10076574 */
            ii(0x100c_c335, 3); mov(eax, memd[ds, eax + 80]);           /* mov eax, [eax+0x50] */
            ii(0x100c_c338, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c33b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c33d, 2); if(jle(0x100c_c341, 2)) goto l_0x100c_c341; /* jle 0x100cc341 */
        l_0x100c_c33f:
            ii(0x100c_c33f, 2); jmp(0x100c_c356, 0x15); goto l_0x100c_c356; /* jmp 0x100cc356 */
        l_0x100c_c341:
            ii(0x100c_c341, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c344, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c347, 5); call(0x1007_6574, -0x5_5dd8);           /* call 0x10076574 */
            ii(0x100c_c34c, 5); call(0x1015_26ac, 0x8_635b);            /* call 0x101526ac */
            ii(0x100c_c351, 3); cmp(eax, memd[ss, ebp - 8]);            /* cmp eax, [ebp-0x8] */
            ii(0x100c_c354, 2); if(jz(0x100c_c35b, 5)) goto l_0x100c_c35b; /* jz 0x100cc35b */
        l_0x100c_c356:
            ii(0x100c_c356, 5); jmp(0x100c_c3e4, 0x89); goto l_0x100c_c3e4; /* jmp 0x100cc3e4 */
        l_0x100c_c35b:
            ii(0x100c_c35b, 5); mov(eax, 0x21);                         /* mov eax, 0x21 */
            ii(0x100c_c360, 5); call(Definitions.sys_new, 0x9_9a9b);    /* call 0x10165e00 */
            ii(0x100c_c365, 3); mov(memd[ss, ebp - 68], eax);           /* mov [ebp-0x44], eax */
            ii(0x100c_c368, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x100c_c36b, 3); mov(memd[ss, ebp - 72], eax);           /* mov [ebp-0x48], eax */
            ii(0x100c_c36e, 4); cmp(memd[ss, ebp - 72], 0);             /* cmp dword [ebp-0x48], 0x0 */
            ii(0x100c_c372, 2); if(jz(0x100c_c3ac, 0x38)) goto l_0x100c_c3ac; /* jz 0x100cc3ac */
            ii(0x100c_c374, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c377, 3); mov(memd[ss, ebp - 76], eax);           /* mov [ebp-0x4c], eax */
            ii(0x100c_c37a, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x100c_c37d, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x100c_c380, 3); mov(eax, memd[ss, ebp - 76]);           /* mov eax, [ebp-0x4c] */
            ii(0x100c_c383, 3); call_abs(memd[ds, edx + 116]);          /* call dword [edx+0x74] */
            ii(0x100c_c386, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100c_c389, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c38c, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c38f, 5); call(0x1007_65d0, -0x5_5dc4);           /* call 0x100765d0 */
            ii(0x100c_c394, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_c396, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100c_c399, 3); mov(eax, memd[ss, ebp - 68]);           /* mov eax, [ebp-0x44] */
            ii(0x100c_c39c, 5); call(0x1008_bd0b, -0x4_0696);           /* call 0x1008bd0b */
            ii(0x100c_c3a1, 3); mov(memd[ss, ebp - 80], eax);           /* mov [ebp-0x50], eax */
            ii(0x100c_c3a4, 3); mov(eax, memd[ss, ebp - 80]);           /* mov eax, [ebp-0x50] */
            ii(0x100c_c3a7, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x100c_c3aa, 2); jmp(0x100c_c3b2, 6); goto l_0x100c_c3b2; /* jmp 0x100cc3b2 */
        l_0x100c_c3ac:
            ii(0x100c_c3ac, 3); mov(eax, memd[ss, ebp - 72]);           /* mov eax, [ebp-0x48] */
            ii(0x100c_c3af, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
        l_0x100c_c3b2:
            ii(0x100c_c3b2, 3); mov(edx, memd[ss, ebp - 84]);           /* mov edx, [ebp-0x54] */
            ii(0x100c_c3b5, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x100c_c3b8, 5); call(0x1008_b060, -0x4_135d);           /* call 0x1008b060 */
            ii(0x100c_c3bd, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x100c_c3c0, 5); call(0x1008_af84, -0x4_1441);           /* call 0x1008af84 */
            ii(0x100c_c3c5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c3c7, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_c3cc, 5); call(0x100a_4d50, -0x2_7681);           /* call 0x100a4d50 */
            ii(0x100c_c3d1, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c3d5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c3d7, 3); lea(eax, memd[ss, ebp - 88]);           /* lea eax, [ebp-0x58] */
            ii(0x100c_c3da, 5); call(0x1008_8b7c, -0x4_3863);           /* call 0x10088b7c */
            ii(0x100c_c3df, 5); jmp(0x100c_c5da, 0x1f6); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c3e4:
            ii(0x100c_c3e4, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c3e7, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c3ea, 5); call(0x1007_6574, -0x5_5e7b);           /* call 0x10076574 */
            ii(0x100c_c3ef, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x100c_c3f2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_c3f5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c3f8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c3fb, 5); call(0x1007_6574, -0x5_5e8c);           /* call 0x10076574 */
            ii(0x100c_c400, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x100c_c403, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_c406, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c409, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c40c, 5); call(0x1008_abbc, -0x4_1855);           /* call 0x1008abbc */
            ii(0x100c_c411, 5); call(0x100a_30a2, -0x2_9374);           /* call 0x100a30a2 */
            ii(0x100c_c416, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c418, 6); if(jz(0x100c_c52e, 0x110)) goto l_0x100c_c52e; /* jz 0x100cc52e */
            ii(0x100c_c41e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_c420, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100c_c425, 3); cmp(eax, 2);                            /* cmp eax, 0x2 */
            ii(0x100c_c428, 2); if(jnz(0x100c_c433, 9)) goto l_0x100c_c433; /* jnz 0x100cc433 */
            ii(0x100c_c42a, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_c42e, 5); jmp(0x100c_c5da, 0x1a7); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c433:
            ii(0x100c_c433, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_c435, 5); mov(al, memb[ds, 0x101c_37c9]);         /* mov al, [0x101c37c9] */
            ii(0x100c_c43a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100c_c43c, 2); if(jnz(0x100c_c453, 0x15)) goto l_0x100c_c453; /* jnz 0x100cc453 */
            ii(0x100c_c43e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c441, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x100c_c444, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100c_c447, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c449, 6); mov(dl, memb[ds, 0x101c_37c8]);         /* mov dl, [0x101c37c8] */
            ii(0x100c_c44f, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100c_c451, 2); if(jnz(0x100c_c455, 2)) goto l_0x100c_c455; /* jnz 0x100cc455 */
        l_0x100c_c453:
            ii(0x100c_c453, 2); jmp(0x100c_c45e, 9); goto l_0x100c_c45e; /* jmp 0x100cc45e */
        l_0x100c_c455:
            ii(0x100c_c455, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
            ii(0x100c_c459, 5); jmp(0x100c_c5da, 0x17c); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c45e:
            ii(0x100c_c45e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c461, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c464, 5); call(0x1007_6574, -0x5_5ef5);           /* call 0x10076574 */
            ii(0x100c_c469, 4); test(memb[ds, eax + 19], 2);            /* test byte [eax+0x13], 0x2 */
            ii(0x100c_c46d, 6); if(jz(0x100c_c521, 0xae)) goto l_0x100c_c521; /* jz 0x100cc521 */
            ii(0x100c_c473, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c476, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c479, 5); call(0x1007_6574, -0x5_5f0a);           /* call 0x10076574 */
            ii(0x100c_c47e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c480, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c483, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c486, 5); call(0x1007_6574, -0x5_5f17);           /* call 0x10076574 */
            ii(0x100c_c48b, 4); mov(dx, memw[ds, edx + 26]);            /* mov dx, [edx+0x1a] */
            ii(0x100c_c48f, 4); mov(memw[ds, eax + 65], dx);            /* mov [eax+0x41], dx */
            ii(0x100c_c493, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c496, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c499, 5); call(0x1007_6574, -0x5_5f2a);           /* call 0x10076574 */
            ii(0x100c_c49e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c4a0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c4a3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c4a6, 5); call(0x1007_6574, -0x5_5f37);           /* call 0x10076574 */
            ii(0x100c_c4ab, 4); mov(dx, memw[ds, edx + 28]);            /* mov dx, [edx+0x1c] */
            ii(0x100c_c4af, 4); mov(memw[ds, eax + 67], dx);            /* mov [eax+0x43], dx */
            ii(0x100c_c4b3, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c4b6, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c4b9, 5); call(0x1007_6574, -0x5_5f4a);           /* call 0x10076574 */
            ii(0x100c_c4be, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c4c0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c4c3, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c4c6, 5); call(0x1007_6574, -0x5_5f57);           /* call 0x10076574 */
            ii(0x100c_c4cb, 4); mov(dx, memw[ds, edx + 65]);            /* mov dx, [edx+0x41] */
            ii(0x100c_c4cf, 4); cmp(dx, memw[ds, eax + 26]);            /* cmp dx, [eax+0x1a] */
            ii(0x100c_c4d3, 2); if(jnz(0x100c_c4f7, 0x22)) goto l_0x100c_c4f7; /* jnz 0x100cc4f7 */
            ii(0x100c_c4d5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c4d8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c4db, 5); call(0x1007_6574, -0x5_5f6c);           /* call 0x10076574 */
            ii(0x100c_c4e0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c4e2, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c4e5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c4e8, 5); call(0x1007_6574, -0x5_5f79);           /* call 0x10076574 */
            ii(0x100c_c4ed, 4); mov(dx, memw[ds, edx + 67]);            /* mov dx, [edx+0x43] */
            ii(0x100c_c4f1, 4); cmp(dx, memw[ds, eax + 28]);            /* cmp dx, [eax+0x1c] */
            ii(0x100c_c4f5, 2); if(jz(0x100c_c4f9, 2)) goto l_0x100c_c4f9; /* jz 0x100cc4f9 */
        l_0x100c_c4f7:
            ii(0x100c_c4f7, 2); jmp(0x100c_c508, 0xf); goto l_0x100c_c508; /* jmp 0x100cc508 */
        l_0x100c_c4f9:
            ii(0x100c_c4f9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c4fc, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c4ff, 5); call(0x1007_6574, -0x5_5f90);           /* call 0x10076574 */
            ii(0x100c_c504, 4); inc(memw[ds, eax + 65]);                /* inc word [eax+0x41] */
        l_0x100c_c508:
            ii(0x100c_c508, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100c_c50a, 5); mov(edx, 0x1b);                         /* mov edx, 0x1b */
            ii(0x100c_c50f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c512, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c515, 5); call(0x1007_65d0, -0x5_5f4a);           /* call 0x100765d0 */
            ii(0x100c_c51a, 5); call(0x1016_3053, 0x9_6b34);            /* call 0x10163053 */
            ii(0x100c_c51f, 2); jmp(0x100c_c529, 8); goto l_0x100c_c529; /* jmp 0x100cc529 */
        l_0x100c_c521:
            ii(0x100c_c521, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c524, 5); call(0x100c_c90c, 0x3e3);               /* call 0x100cc90c */
        l_0x100c_c529:
            ii(0x100c_c529, 5); jmp(0x100c_c5d0, 0xa2); goto l_0x100c_c5d0; /* jmp 0x100cc5d0 */
        l_0x100c_c52e:
            ii(0x100c_c52e, 5); mov(ebx, 3);                            /* mov ebx, 0x3 */
            ii(0x100c_c533, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c536, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c539, 5); call(0x1007_65d0, -0x5_5f6e);           /* call 0x100765d0 */
            ii(0x100c_c53e, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x100c_c541, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c543, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_c545, 5); call(0x100a_3671, -0x2_8ed9);           /* call 0x100a3671 */
            ii(0x100c_c54a, 2); test(al, al);                           /* test al, al */
            ii(0x100c_c54c, 6); if(jnz(0x100c_c5d0, 0x7e)) goto l_0x100c_c5d0; /* jnz 0x100cc5d0 */
            ii(0x100c_c552, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100c_c557, 5); call(Definitions.sys_new, 0x9_98a4);    /* call 0x10165e00 */
            ii(0x100c_c55c, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x100c_c55f, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x100c_c562, 3); mov(memd[ss, ebp - 96], eax);           /* mov [ebp-0x60], eax */
            ii(0x100c_c565, 4); cmp(memd[ss, ebp - 96], 0);             /* cmp dword [ebp-0x60], 0x0 */
            ii(0x100c_c569, 2); if(jz(0x100c_c5a1, 0x36)) goto l_0x100c_c5a1; /* jz 0x100cc5a1 */
            ii(0x100c_c56b, 5); mov(eax, 0x100c_cdd6);                  /* mov eax, 0x100ccdd6 */
            ii(0x100c_c570, 1); push(eax);                              /* push eax */
            ii(0x100c_c571, 3); mov(ecx, memd[ss, ebp - 8]);            /* mov ecx, [ebp-0x8] */
            ii(0x100c_c574, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c577, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100c_c57a, 5); call(0x1007_65d0, -0x5_5faf);           /* call 0x100765d0 */
            ii(0x100c_c57f, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100c_c581, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_c584, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_c587, 5); call(0x1007_65d0, -0x5_5fbc);           /* call 0x100765d0 */
            ii(0x100c_c58c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c58e, 3); mov(eax, memd[ss, ebp - 92]);           /* mov eax, [ebp-0x5c] */
            ii(0x100c_c591, 5); call(0x100b_43b0, -0x1_81e6);           /* call 0x100b43b0 */
            ii(0x100c_c596, 3); mov(memd[ss, ebp - 100], eax);          /* mov [ebp-0x64], eax */
            ii(0x100c_c599, 3); mov(eax, memd[ss, ebp - 100]);          /* mov eax, [ebp-0x64] */
            ii(0x100c_c59c, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
            ii(0x100c_c59f, 2); jmp(0x100c_c5a7, 6); goto l_0x100c_c5a7; /* jmp 0x100cc5a7 */
        l_0x100c_c5a1:
            ii(0x100c_c5a1, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x100c_c5a4, 3); mov(memd[ss, ebp - 104], eax);          /* mov [ebp-0x68], eax */
        l_0x100c_c5a7:
            ii(0x100c_c5a7, 3); mov(edx, memd[ss, ebp - 104]);          /* mov edx, [ebp-0x68] */
            ii(0x100c_c5aa, 3); lea(eax, memd[ss, ebp - 108]);          /* lea eax, [ebp-0x6c] */
            ii(0x100c_c5ad, 5); call(0x1008_b060, -0x4_1552);           /* call 0x1008b060 */
            ii(0x100c_c5b2, 3); lea(eax, memd[ss, ebp - 108]);          /* lea eax, [ebp-0x6c] */
            ii(0x100c_c5b5, 5); call(0x1008_af84, -0x4_1636);           /* call 0x1008af84 */
            ii(0x100c_c5ba, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_c5bc, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_c5c1, 5); call(0x100a_4d50, -0x2_7876);           /* call 0x100a4d50 */
            ii(0x100c_c5c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_c5c8, 3); lea(eax, memd[ss, ebp - 108]);          /* lea eax, [ebp-0x6c] */
            ii(0x100c_c5cb, 5); call(0x1008_8b7c, -0x4_3a54);           /* call 0x10088b7c */
        l_0x100c_c5d0:
            ii(0x100c_c5d0, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x100c_c5d4, 2); jmp(0x100c_c5da, 4); goto l_0x100c_c5da; /* jmp 0x100cc5da */
        l_0x100c_c5d6:
            ii(0x100c_c5d6, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
        l_0x100c_c5da:
            ii(0x100c_c5da, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x100c_c5dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_c5df, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_c5e0, 1); pop(edi);                               /* pop edi */
            ii(0x100c_c5e1, 1); pop(esi);                               /* pop esi */
            ii(0x100c_c5e2, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_c5e3, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_c5e4, 1); ret();                                  /* ret */
        }
    }
}

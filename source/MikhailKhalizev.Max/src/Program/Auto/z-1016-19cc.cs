using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_19cc-d8a9b0ac")]
        public void Method_1016_19cc()
        {
            ii(0x1016_19cc, 5); push(0x9c);                             /* push 0x9c */
            ii(0x1016_19d1, 5); call(Definitions.sys_check_available_stack_size, 0x437c); /* call 0x10165d52 */
            ii(0x1016_19d6, 1); push(ebx);                              /* push ebx */
            ii(0x1016_19d7, 1); push(ecx);                              /* push ecx */
            ii(0x1016_19d8, 1); push(edx);                              /* push edx */
            ii(0x1016_19d9, 1); push(esi);                              /* push esi */
            ii(0x1016_19da, 1); push(edi);                              /* push edi */
            ii(0x1016_19db, 1); push(ebp);                              /* push ebp */
            ii(0x1016_19dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_19de, 6); sub(esp, 0x80);                         /* sub esp, 0x80 */
            ii(0x1016_19e4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1016_19e7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_19ea, 4); test(memb[ds, eax + 21], 8);            /* test byte [eax+0x15], 0x8 */
            ii(0x1016_19ee, 2); if(jz(0x1016_19f9, 9)) goto l_0x1016_19f9; /* jz 0x101619f9 */
            ii(0x1016_19f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_19f3, 4); cmp(memb[ds, eax + 61], 0x1a);          /* cmp byte [eax+0x3d], 0x1a */
            ii(0x1016_19f7, 2); if(jnz(0x1016_19fb, 2)) goto l_0x1016_19fb; /* jnz 0x101619fb */
        l_0x1016_19f9:
            ii(0x1016_19f9, 2); jmp(0x1016_1a09, 0xe); goto l_0x1016_1a09; /* jmp 0x10161a09 */
        l_0x1016_19fb:
            ii(0x1016_19fb, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1016_1a00, 5); call(0x1007_5fdc, -0xe_ba29);           /* call 0x10075fdc */
            ii(0x1016_1a05, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1a07, 2); if(jnz(0x1016_1a0b, 2)) goto l_0x1016_1a0b; /* jnz 0x10161a0b */
        l_0x1016_1a09:
            ii(0x1016_1a09, 2); jmp(0x1016_1a13, 8); goto l_0x1016_1a13; /* jmp 0x10161a13 */
        l_0x1016_1a0b:
            ii(0x1016_1a0b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a0e, 5); call(0x1015_4853, -0xd1c0);             /* call 0x10154853 */
        l_0x1016_1a13:
            ii(0x1016_1a13, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a16, 4); test(memb[ds, eax + 18], 0x20);         /* test byte [eax+0x12], 0x20 */
            ii(0x1016_1a1a, 2); if(jnz(0x1016_1a25, 9)) goto l_0x1016_1a25; /* jnz 0x10161a25 */
            ii(0x1016_1a1c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a1f, 4); cmp(memb[ds, eax + 62], 0xe);           /* cmp byte [eax+0x3e], 0xe */
            ii(0x1016_1a23, 2); if(jnz(0x1016_1a33, 0xe)) goto l_0x1016_1a33; /* jnz 0x10161a33 */
        l_0x1016_1a25:
            ii(0x1016_1a25, 7); mov(memb[ds, 0x101c_9447], 1);          /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1a2c, 7); mov(memb[ds, 0x101c_9448], 1);          /* mov byte [0x101c9448], 0x1 */
        l_0x1016_1a33:
            ii(0x1016_1a33, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a36, 3); mov(al, memb[ds, eax + 61]);            /* mov al, [eax+0x3d] */
            ii(0x1016_1a39, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
            ii(0x1016_1a3c, 5); jmp(0x1016_2988, 0xf47); goto l_0x1016_2988; /* jmp 0x10162988 */
        l_0x1016_1a41:
            ii(0x1016_1a41, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a44, 5); cmp(memw[ds, eax + 8], 0x15);           /* cmp word [eax+0x8], 0x15 */
            ii(0x1016_1a49, 2); if(jz(0x1016_1a55, 0xa)) goto l_0x1016_1a55; /* jz 0x10161a55 */
            ii(0x1016_1a4b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a4e, 5); cmp(memw[ds, eax + 8], 0x21);           /* cmp word [eax+0x8], 0x21 */
            ii(0x1016_1a53, 2); if(jnz(0x1016_1a5a, 5)) goto l_0x1016_1a5a; /* jnz 0x10161a5a */
        l_0x1016_1a55:
            ii(0x1016_1a55, 5); jmp(0x1016_29a7, 0xf4d); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_1a5a:
            ii(0x1016_1a5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a5d, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_1a60, 3); mov(memb[ss, ebp - 12], al);            /* mov [ebp-0xc], al */
            ii(0x1016_1a63, 5); jmp(0x1016_1af8, 0x90); goto l_0x1016_1af8; /* jmp 0x10161af8 */
        l_0x1016_1a68:
            ii(0x1016_1a68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1a6a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a6d, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_1a70, 5); call(0x1007_6a34, -0xe_b041);           /* call 0x10076a34 */
            ii(0x1016_1a75, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a78, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1016_1a7c, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1a81, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a84, 5); call(0x1007_6d98, -0xe_acf1);           /* call 0x10076d98 */
            ii(0x1016_1a89, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1a8b, 2); if(jz(0x1016_1a9a, 0xd)) goto l_0x1016_1a9a; /* jz 0x10161a9a */
            ii(0x1016_1a8d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a90, 5); call(0x1010_094d, -0x6_1148);           /* call 0x1010094d */
            ii(0x1016_1a95, 5); call(0x100f_f5c1, -0x6_24d9);           /* call 0x100ff5c1 */
        l_0x1016_1a9a:
            ii(0x1016_1a9a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1a9d, 5); cmp(memw[ds, eax + 8], 0x27);           /* cmp word [eax+0x8], 0x27 */
            ii(0x1016_1aa2, 2); if(jnz(0x1016_1ab0, 0xc)) goto l_0x1016_1ab0; /* jnz 0x10161ab0 */
            ii(0x1016_1aa4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1aa7, 5); call(0x1015_2b8c, -0xef20);             /* call 0x10152b8c */
            ii(0x1016_1aac, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1aae, 2); if(jnz(0x1016_1ab2, 2)) goto l_0x1016_1ab2; /* jnz 0x10161ab2 */
        l_0x1016_1ab0:
            ii(0x1016_1ab0, 2); jmp(0x1016_1ae4, 0x32); goto l_0x1016_1ae4; /* jmp 0x10161ae4 */
        l_0x1016_1ab2:
            ii(0x1016_1ab2, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x1016_1ab7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1aba, 3); mov(edx, memd[ds, eax + 26]);           /* mov edx, [eax+0x1a] */
            ii(0x1016_1abd, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_1ac0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ac3, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1016_1ac6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_1ac9, 5); call(0x1007_36d8, -0xe_e3f6);           /* call 0x100736d8 */
            ii(0x1016_1ace, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1ad0, 2); if(jnz(0x1016_1ae4, 0x12)) goto l_0x1016_1ae4; /* jnz 0x10161ae4 */
            ii(0x1016_1ad2, 5); mov(ebx, 0x27);                         /* mov ebx, 0x27 */
            ii(0x1016_1ad7, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1016_1adc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1adf, 5); call(0x1016_2f96, 0x14b2);              /* call 0x10162f96 */
        l_0x1016_1ae4:
            ii(0x1016_1ae4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ae7, 5); call(0x1016_18c2, -0x22a);              /* call 0x101618c2 */
            ii(0x1016_1aec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1aef, 5); call(0x1016_1499, -0x65b);              /* call 0x10161499 */
            ii(0x1016_1af4, 2); jmp(0x1016_1b22, 0x2c); goto l_0x1016_1b22; /* jmp 0x10161b22 */
        l_0x1016_1af6:
            ii(0x1016_1af6, 2); jmp(0x1016_1b22, 0x2a); goto l_0x1016_1b22; /* jmp 0x10161b22 */
        l_0x1016_1af8:
            ii(0x1016_1af8, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1016_1afb, 3); mov(memb[ss, ebp - 16], al);            /* mov [ebp-0x10], al */
            ii(0x1016_1afe, 4); cmp(memb[ss, ebp - 16], 2);             /* cmp byte [ebp-0x10], 0x2 */
            ii(0x1016_1b02, 2); if(jb(0x1016_1b16, 0x12)) goto l_0x1016_1b16; /* jb 0x10161b16 */
            ii(0x1016_1b04, 4); cmp(memb[ss, ebp - 16], 2);             /* cmp byte [ebp-0x10], 0x2 */
            ii(0x1016_1b08, 2); if(jbe(0x1016_1ae4, -0x26)) goto l_0x1016_1ae4; /* jbe 0x10161ae4 */
            ii(0x1016_1b0a, 4); cmp(memb[ss, ebp - 16], 0x18);          /* cmp byte [ebp-0x10], 0x18 */
            ii(0x1016_1b0e, 6); if(jz(0x1016_1a68, -0xac)) goto l_0x1016_1a68; /* jz 0x10161a68 */
            ii(0x1016_1b14, 2); jmp(0x1016_1af6, -0x20); goto l_0x1016_1af6; /* jmp 0x10161af6 */
        l_0x1016_1b16:
            ii(0x1016_1b16, 4); cmp(memb[ss, ebp - 16], 1);             /* cmp byte [ebp-0x10], 0x1 */
            ii(0x1016_1b1a, 6); if(jz(0x1016_1a9a, -0x86)) goto l_0x1016_1a9a; /* jz 0x10161a9a */
            ii(0x1016_1b20, 2); jmp(0x1016_1af6, -0x2c); goto l_0x1016_1af6; /* jmp 0x10161af6 */
        l_0x1016_1b22:
            ii(0x1016_1b22, 5); jmp(0x1016_29a7, 0xe80); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_1b27:
            ii(0x1016_1b27, 5); mov(eax, StringDefinitions.Transform);  /* mov eax, 0x101b28e2 */
            ii(0x1016_1b2c, 5); call(0x100a_8b4a, -0xb_8fe7);           /* call 0x100a8b4a */
            ii(0x1016_1b31, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b34, 5); call(0x1014_9fa8, -0x1_7b91);           /* call 0x10149fa8 */
            ii(0x1016_1b39, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b3c, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_1b3f, 3); mov(memb[ss, ebp - 20], al);            /* mov [ebp-0x14], al */
            ii(0x1016_1b42, 5); jmp(0x1016_1bc5, 0x7e); goto l_0x1016_1bc5; /* jmp 0x10161bc5 */
        l_0x1016_1b47:
            ii(0x1016_1b47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b4a, 5); call(0x1015_f4a2, -0x26ad);             /* call 0x1015f4a2 */
            ii(0x1016_1b4f, 5); jmp(0x1016_1bef, 0x9b); goto l_0x1016_1bef; /* jmp 0x10161bef */
        l_0x1016_1b54:
            ii(0x1016_1b54, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b57, 5); call(0x1015_f502, -0x265a);             /* call 0x1015f502 */
            ii(0x1016_1b5c, 5); jmp(0x1016_1bef, 0x8e); goto l_0x1016_1bef; /* jmp 0x10161bef */
        l_0x1016_1b61:
            ii(0x1016_1b61, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b64, 4); mov(memb[ds, eax + 61], 7);             /* mov byte [eax+0x3d], 0x7 */
            ii(0x1016_1b68, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b6b, 4); mov(memb[ds, eax + 62], 0);             /* mov byte [eax+0x3e], 0x0 */
            ii(0x1016_1b6f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b72, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1016_1b75, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1b7a, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_1b80, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1016_1b86, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1b8b, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1016_1b8e, 2); if(jnz(0x1016_1bc1, 0x31)) goto l_0x1016_1bc1; /* jnz 0x10161bc1 */
            ii(0x1016_1b90, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1016_1b95, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1016_1b9a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1b9d, 5); call(0x1007_6204, -0xe_b99e);           /* call 0x10076204 */
            ii(0x1016_1ba2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1ba4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ba7, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1016_1baa, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_1bac, 1); cwde();                                 /* cwde */
            ii(0x1016_1bad, 5); call(0x1010_11ff, -0x6_09b3);           /* call 0x101011ff */
            ii(0x1016_1bb2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1bb5, 5); call(0x1010_19b8, -0x6_0202);           /* call 0x101019b8 */
            ii(0x1016_1bba, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_1bbc, 5); call(0x100f_fa70, -0x6_2151);           /* call 0x100ffa70 */
        l_0x1016_1bc1:
            ii(0x1016_1bc1, 2); jmp(0x1016_1bef, 0x2c); goto l_0x1016_1bef; /* jmp 0x10161bef */
        l_0x1016_1bc3:
            ii(0x1016_1bc3, 2); jmp(0x1016_1bef, 0x2a); goto l_0x1016_1bef; /* jmp 0x10161bef */
        l_0x1016_1bc5:
            ii(0x1016_1bc5, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1016_1bc8, 3); mov(memb[ss, ebp - 24], al);            /* mov [ebp-0x18], al */
            ii(0x1016_1bcb, 4); cmp(memb[ss, ebp - 24], 0x16);          /* cmp byte [ebp-0x18], 0x16 */
            ii(0x1016_1bcf, 2); if(jb(0x1016_1be3, 0x12)) goto l_0x1016_1be3; /* jb 0x10161be3 */
            ii(0x1016_1bd1, 4); cmp(memb[ss, ebp - 24], 0x16);          /* cmp byte [ebp-0x18], 0x16 */
            ii(0x1016_1bd5, 6); if(jbe(0x1016_1b54, -0x87)) goto l_0x1016_1b54; /* jbe 0x10161b54 */
            ii(0x1016_1bdb, 4); cmp(memb[ss, ebp - 24], 0x17);          /* cmp byte [ebp-0x18], 0x17 */
            ii(0x1016_1bdf, 2); if(jz(0x1016_1b61, -0x80)) goto l_0x1016_1b61; /* jz 0x10161b61 */
            ii(0x1016_1be1, 2); jmp(0x1016_1bc3, -0x20); goto l_0x1016_1bc3; /* jmp 0x10161bc3 */
        l_0x1016_1be3:
            ii(0x1016_1be3, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1016_1be7, 6); if(jz(0x1016_1b47, -0xa6)) goto l_0x1016_1b47; /* jz 0x10161b47 */
            ii(0x1016_1bed, 2); jmp(0x1016_1bc3, -0x2c); goto l_0x1016_1bc3; /* jmp 0x10161bc3 */
        l_0x1016_1bef:
            ii(0x1016_1bef, 5); jmp(0x1016_29a7, 0xdb3); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_1bf4:
            ii(0x1016_1bf4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1bf7, 4); cmp(memb[ds, eax + 62], 7);             /* cmp byte [eax+0x3e], 0x7 */
            ii(0x1016_1bfb, 2); if(jnz(0x1016_1c0c, 0xf)) goto l_0x1016_1c0c; /* jnz 0x10161c0c */
            ii(0x1016_1bfd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c00, 5); call(0x1015_48ba, -0xd34b);             /* call 0x101548ba */
            ii(0x1016_1c05, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c08, 4); mov(memb[ds, eax + 62], 5);             /* mov byte [eax+0x3e], 0x5 */
        l_0x1016_1c0c:
            ii(0x1016_1c0c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c0f, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_1c12, 3); mov(memb[ss, ebp - 28], al);            /* mov [ebp-0x1c], al */
            ii(0x1016_1c15, 5); jmp(0x1016_1e15, 0x1fb); goto l_0x1016_1e15; /* jmp 0x10161e15 */
        l_0x1016_1c1a:
            ii(0x1016_1c1a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_1c1c, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x1016_1c21, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1c24, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c27, 5); call(0x1007_6074, -0xe_bbb8);           /* call 0x10076074 */
            ii(0x1016_1c2c, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1c2e, 2); if(jz(0x1016_1c5a, 0x2a)) goto l_0x1016_1c5a; /* jz 0x10161c5a */
            ii(0x1016_1c30, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1c35, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c38, 5); call(0x1007_6d98, -0xe_aea5);           /* call 0x10076d98 */
            ii(0x1016_1c3d, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1c3f, 2); if(jnz(0x1016_1c4a, 9)) goto l_0x1016_1c4a; /* jnz 0x10161c4a */
            ii(0x1016_1c41, 7); cmp(memb[ds, 0x101c_3889], 0);          /* cmp byte [0x101c3889], 0x0 */
            ii(0x1016_1c48, 2); if(jz(0x1016_1c4c, 2)) goto l_0x1016_1c4c; /* jz 0x10161c4c */
        l_0x1016_1c4a:
            ii(0x1016_1c4a, 2); jmp(0x1016_1c55, 9); goto l_0x1016_1c55; /* jmp 0x10161c55 */
        l_0x1016_1c4c:
            ii(0x1016_1c4c, 7); cmp(memb[ds, 0x101c_388a], 0);          /* cmp byte [0x101c388a], 0x0 */
            ii(0x1016_1c53, 2); if(jz(0x1016_1c5a, 5)) goto l_0x1016_1c5a; /* jz 0x10161c5a */
        l_0x1016_1c55:
            ii(0x1016_1c55, 5); call(0x100f_f5c1, -0x6_2699);           /* call 0x100ff5c1 */
        l_0x1016_1c5a:
            ii(0x1016_1c5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c5d, 5); call(0x1016_0283, -0x19df);             /* call 0x10160283 */
            ii(0x1016_1c62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1c64, 6); if(jz(0x1016_1ebf, 0x255)) goto l_0x1016_1ebf; /* jz 0x10161ebf */
        l_0x1016_1c6a:
            ii(0x1016_1c6a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c6d, 5); call(0x1014_ac97, -0x1_6fdb);           /* call 0x1014ac97 */
            ii(0x1016_1c72, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1c74, 6); if(jz(0x1016_1ebf, 0x245)) goto l_0x1016_1ebf; /* jz 0x10161ebf */
        l_0x1016_1c7a:
            ii(0x1016_1c7a, 5); mov(eax, StringDefinitions.Moving3);    /* mov eax, 0x101b28ec */
            ii(0x1016_1c7f, 5); call(0x100a_8b4a, -0xb_913a);           /* call 0x100a8b4a */
            ii(0x1016_1c84, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c87, 5); call(0x1014_af42, -0x1_6d4a);           /* call 0x1014af42 */
            ii(0x1016_1c8c, 5); jmp(0x1016_1ebf, 0x22e); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1c91:
            ii(0x1016_1c91, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c94, 4); test(memb[ds, eax + 18], 0x40);         /* test byte [eax+0x12], 0x40 */
            ii(0x1016_1c98, 2); if(jz(0x1016_1cd6, 0x3c)) goto l_0x1016_1cd6; /* jz 0x10161cd6 */
            ii(0x1016_1c9a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1c9d, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1016_1ca0, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1ca5, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1016_1cab, 6); mov(al, memb[ds, eax + 0x101c_a490]);   /* mov al, [eax+0x101ca490] */
            ii(0x1016_1cb1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_1cb6, 3); cmp(eax, 1);                            /* cmp eax, 0x1 */
            ii(0x1016_1cb9, 2); if(jnz(0x1016_1cc7, 0xc)) goto l_0x1016_1cc7; /* jnz 0x10161cc7 */
            ii(0x1016_1cbb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1cbe, 5); call(0x1007_61d4, -0xe_baef);           /* call 0x100761d4 */
            ii(0x1016_1cc3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1cc5, 2); if(jnz(0x1016_1cc9, 2)) goto l_0x1016_1cc9; /* jnz 0x10161cc9 */
        l_0x1016_1cc7:
            ii(0x1016_1cc7, 2); jmp(0x1016_1cd6, 0xd); goto l_0x1016_1cd6; /* jmp 0x10161cd6 */
        l_0x1016_1cc9:
            ii(0x1016_1cc9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_1ccc, 5); mov(eax, 0x101c_9478);                  /* mov eax, 0x101c9478 */
            ii(0x1016_1cd1, 5); call(0x1007_6630, -0xe_b6a6);           /* call 0x10076630 */
        l_0x1016_1cd6:
            ii(0x1016_1cd6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1cd9, 5); call(0x1015_dfe7, -0x3cf7);             /* call 0x1015dfe7 */
            ii(0x1016_1cde, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1ce0, 2); if(jnz(0x1016_1cf2, 0x10)) goto l_0x1016_1cf2; /* jnz 0x10161cf2 */
            ii(0x1016_1ce2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ce5, 5); call(0x1016_18c2, -0x428);              /* call 0x101618c2 */
            ii(0x1016_1cea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ced, 5); call(0x1016_1499, -0x859);              /* call 0x10161499 */
        l_0x1016_1cf2:
            ii(0x1016_1cf2, 5); jmp(0x1016_1ebf, 0x1c8); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1cf7:
            ii(0x1016_1cf7, 5); mov(eax, StringDefinitions.Storing);    /* mov eax, 0x101b28f3 */
            ii(0x1016_1cfc, 5); call(0x100a_8b4a, -0xb_91b7);           /* call 0x100a8b4a */
            ii(0x1016_1d01, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d04, 5); call(0x1015_eb38, -0x31d1);             /* call 0x1015eb38 */
            ii(0x1016_1d09, 5); jmp(0x1016_1ebf, 0x1b1); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1d0e:
            ii(0x1016_1d0e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d11, 5); call(0x1012_0a5c, -0x4_12ba);           /* call 0x10120a5c */
            ii(0x1016_1d16, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1d18, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d1b, 4); cmp(dx, memw[ds, eax + 59]);            /* cmp dx, [eax+0x3b] */
            ii(0x1016_1d1f, 2); if(jz(0x1016_1d5d, 0x3c)) goto l_0x1016_1d5d; /* jz 0x10161d5d */
            ii(0x1016_1d21, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d24, 5); call(0x1015_2b8c, -0xf19d);             /* call 0x10152b8c */
            ii(0x1016_1d29, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1d2b, 2); if(jnz(0x1016_1d47, 0x1a)) goto l_0x1016_1d47; /* jnz 0x10161d47 */
            ii(0x1016_1d2d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_1d30, 5); mov(eax, 0x101c_8178);                  /* mov eax, 0x101c8178 */
            ii(0x1016_1d35, 5); call(0x1008_aab4, -0xd_7286);           /* call 0x1008aab4 */
            ii(0x1016_1d3a, 5); mov(edx, 0x40_4200);                    /* mov edx, 0x404200 */
            ii(0x1016_1d3f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d42, 5); call(0x1014_a205, -0x1_7b42);           /* call 0x1014a205 */
        l_0x1016_1d47:
            ii(0x1016_1d47, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d4a, 5); call(0x1012_0a5c, -0x4_12f3);           /* call 0x10120a5c */
            ii(0x1016_1d4f, 1); inc(eax);                               /* inc eax */
            ii(0x1016_1d50, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1d53, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d56, 5); call(0x1014_9b07, -0x1_8254);           /* call 0x10149b07 */
            ii(0x1016_1d5b, 2); jmp(0x1016_1d6c, 0xf); goto l_0x1016_1d6c; /* jmp 0x10161d6c */
        l_0x1016_1d5d:
            ii(0x1016_1d5d, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1016_1d62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1d64, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d67, 5); call(0x1016_2f96, 0x122a);              /* call 0x10162f96 */
        l_0x1016_1d6c:
            ii(0x1016_1d6c, 5); jmp(0x1016_1ebf, 0x14e); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1d71:
            ii(0x1016_1d71, 5); mov(ebx, 0x80);                         /* mov ebx, 0x80 */
            ii(0x1016_1d76, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d79, 3); mov(edx, memd[ds, eax + 26]);           /* mov edx, [eax+0x1a] */
            ii(0x1016_1d7c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_1d7f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d82, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1016_1d85, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_1d88, 5); call(0x1007_36d8, -0xe_e6b5);           /* call 0x100736d8 */
            ii(0x1016_1d8d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1d8f, 2); if(jz(0x1016_1da5, 0x14)) goto l_0x1016_1da5; /* jz 0x10161da5 */
            ii(0x1016_1d91, 5); mov(ebx, 0x26);                         /* mov ebx, 0x26 */
            ii(0x1016_1d96, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1016_1d9b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1d9e, 5); call(0x1016_2f96, 0x11f3);              /* call 0x10162f96 */
            ii(0x1016_1da3, 2); jmp(0x1016_1df2, 0x4d); goto l_0x1016_1df2; /* jmp 0x10161df2 */
        l_0x1016_1da5:
            ii(0x1016_1da5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1da8, 5); call(0x1015_2b8c, -0xf221);             /* call 0x10152b8c */
            ii(0x1016_1dad, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1daf, 2); if(jz(0x1016_1dc7, 0x16)) goto l_0x1016_1dc7; /* jz 0x10161dc7 */
            ii(0x1016_1db1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1db4, 5); call(0x1012_0a5c, -0x4_135d);           /* call 0x10120a5c */
            ii(0x1016_1db9, 1); dec(eax);                               /* dec eax */
            ii(0x1016_1dba, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_1dbd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1dc0, 5); call(0x1014_9b07, -0x1_82be);           /* call 0x10149b07 */
            ii(0x1016_1dc5, 2); jmp(0x1016_1df2, 0x2b); goto l_0x1016_1df2; /* jmp 0x10161df2 */
        l_0x1016_1dc7:
            ii(0x1016_1dc7, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_1dca, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1016_1dcf, 5); call(0x1008_aab4, -0xd_7320);           /* call 0x1008aab4 */
            ii(0x1016_1dd4, 5); call(0x1015_50bc, -0xcd1d);             /* call 0x101550bc */
            ii(0x1016_1dd9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_1ddb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1dde, 5); call(0x1014_a205, -0x1_7bde);           /* call 0x1014a205 */
            ii(0x1016_1de3, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1016_1de8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1dea, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ded, 5); call(0x1016_2f96, 0x11a4);              /* call 0x10162f96 */
        l_0x1016_1df2:
            ii(0x1016_1df2, 5); jmp(0x1016_1ebf, 0xc8); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1df7:
            ii(0x1016_1df7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1df9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1dfc, 5); call(0x1007_60ac, -0xe_bd55);           /* call 0x100760ac */
            ii(0x1016_1e01, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_1e03, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1e06, 5); call(0x1014_f017, -0x1_2df4);           /* call 0x1014f017 */
            ii(0x1016_1e0b, 5); jmp(0x1016_1ebf, 0xaf); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1e10:
            ii(0x1016_1e10, 5); jmp(0x1016_1ebf, 0xaa); goto l_0x1016_1ebf; /* jmp 0x10161ebf */
        l_0x1016_1e15:
            ii(0x1016_1e15, 3); mov(al, memb[ss, ebp - 28]);            /* mov al, [ebp-0x1c] */
            ii(0x1016_1e18, 3); mov(memb[ss, ebp - 32], al);            /* mov [ebp-0x20], al */
            ii(0x1016_1e1b, 4); cmp(memb[ss, ebp - 32], 0xc);           /* cmp byte [ebp-0x20], 0xc */
            ii(0x1016_1e1f, 2); if(jb(0x1016_1e6d, 0x4c)) goto l_0x1016_1e6d; /* jb 0x10161e6d */
            ii(0x1016_1e21, 4); cmp(memb[ss, ebp - 32], 0xc);           /* cmp byte [ebp-0x20], 0xc */
            ii(0x1016_1e25, 2); if(jbe(0x1016_1df7, -0x30)) goto l_0x1016_1df7; /* jbe 0x10161df7 */
            ii(0x1016_1e27, 4); cmp(memb[ss, ebp - 32], 0x26);          /* cmp byte [ebp-0x20], 0x26 */
            ii(0x1016_1e2b, 2); if(jb(0x1016_1e4f, 0x22)) goto l_0x1016_1e4f; /* jb 0x10161e4f */
            ii(0x1016_1e2d, 4); cmp(memb[ss, ebp - 32], 0x26);          /* cmp byte [ebp-0x20], 0x26 */
            ii(0x1016_1e31, 6); if(jbe(0x1016_1d0e, -0x129)) goto l_0x1016_1d0e; /* jbe 0x10161d0e */
            ii(0x1016_1e37, 4); cmp(memb[ss, ebp - 32], 0x27);          /* cmp byte [ebp-0x20], 0x27 */
            ii(0x1016_1e3b, 6); if(jbe(0x1016_1d71, -0xd0)) goto l_0x1016_1d71; /* jbe 0x10161d71 */
            ii(0x1016_1e41, 4); cmp(memb[ss, ebp - 32], 0x2a);          /* cmp byte [ebp-0x20], 0x2a */
            ii(0x1016_1e45, 6); if(jz(0x1016_1c91, -0x1ba)) goto l_0x1016_1c91; /* jz 0x10161c91 */
            ii(0x1016_1e4b, 2); jmp(0x1016_1e10, -0x3d); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        //  ii(0x1016_1e4d, 2); jmp(0x1016_1e10, -0x3f); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e4f:
            ii(0x1016_1e4f, 4); cmp(memb[ss, ebp - 32], 0x1c);          /* cmp byte [ebp-0x20], 0x1c */
            ii(0x1016_1e53, 2); if(jb(0x1016_1e6b, 0x16)) goto l_0x1016_1e6b; /* jb 0x10161e6b */
            ii(0x1016_1e55, 4); cmp(memb[ss, ebp - 32], 0x1c);          /* cmp byte [ebp-0x20], 0x1c */
            ii(0x1016_1e59, 6); if(jbe(0x1016_1c1a, -0x245)) goto l_0x1016_1c1a; /* jbe 0x10161c1a */
            ii(0x1016_1e5f, 4); cmp(memb[ss, ebp - 32], 0x1d);          /* cmp byte [ebp-0x20], 0x1d */
            ii(0x1016_1e63, 6); if(jz(0x1016_1cd6, -0x193)) goto l_0x1016_1cd6; /* jz 0x10161cd6 */
            ii(0x1016_1e69, 2); jmp(0x1016_1e10, -0x5b); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e6b:
            ii(0x1016_1e6b, 2); jmp(0x1016_1e10, -0x5d); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e6d:
            ii(0x1016_1e6d, 4); cmp(memb[ss, ebp - 32], 3);             /* cmp byte [ebp-0x20], 0x3 */
            ii(0x1016_1e71, 2); if(jb(0x1016_1ea1, 0x2e)) goto l_0x1016_1ea1; /* jb 0x10161ea1 */
            ii(0x1016_1e73, 4); cmp(memb[ss, ebp - 32], 3);             /* cmp byte [ebp-0x20], 0x3 */
            ii(0x1016_1e77, 6); if(jbe(0x1016_1cf7, -0x186)) goto l_0x1016_1cf7; /* jbe 0x10161cf7 */
            ii(0x1016_1e7d, 4); cmp(memb[ss, ebp - 32], 5);             /* cmp byte [ebp-0x20], 0x5 */
            ii(0x1016_1e81, 2); if(jb(0x1016_1e9c, 0x19)) goto l_0x1016_1e9c; /* jb 0x10161e9c */
            ii(0x1016_1e83, 4); cmp(memb[ss, ebp - 32], 5);             /* cmp byte [ebp-0x20], 0x5 */
            ii(0x1016_1e87, 6); if(jbe(0x1016_1c6a, -0x223)) goto l_0x1016_1c6a; /* jbe 0x10161c6a */
            ii(0x1016_1e8d, 4); cmp(memb[ss, ebp - 32], 6);             /* cmp byte [ebp-0x20], 0x6 */
            ii(0x1016_1e91, 6); if(jz(0x1016_1c7a, -0x21d)) goto l_0x1016_1c7a; /* jz 0x10161c7a */
            ii(0x1016_1e97, 5); jmp(0x1016_1e10, -0x8c); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1e9c:
            ii(0x1016_1e9c, 5); jmp(0x1016_1e10, -0x91); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1ea1:
            ii(0x1016_1ea1, 4); cmp(memb[ss, ebp - 32], 0);             /* cmp byte [ebp-0x20], 0x0 */
            ii(0x1016_1ea5, 6); if(jbe(0x1016_1c1a, -0x291)) goto l_0x1016_1c1a; /* jbe 0x10161c1a */
            ii(0x1016_1eab, 4); cmp(memb[ss, ebp - 32], 1);             /* cmp byte [ebp-0x20], 0x1 */
            ii(0x1016_1eaf, 6); if(jz(0x1016_1cd6, -0x1df)) goto l_0x1016_1cd6; /* jz 0x10161cd6 */
            ii(0x1016_1eb5, 5); jmp(0x1016_1e10, -0xaa); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        //  ii(0x1016_1eba, 5); jmp(0x1016_1e10, -0xaf); goto l_0x1016_1e10; /* jmp 0x10161e10 */
        l_0x1016_1ebf:
            ii(0x1016_1ebf, 5); jmp(0x1016_29a7, 0xae3); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_1ec4:
            ii(0x1016_1ec4, 5); mov(eax, StringDefinitions.Firing);     /* mov eax, 0x101b28fb */
            ii(0x1016_1ec9, 5); call(0x100a_8b4a, -0xb_9384);           /* call 0x100a8b4a */
            ii(0x1016_1ece, 7); mov(memb[ds, 0x101c_9448], 1);          /* mov byte [0x101c9448], 0x1 */
            ii(0x1016_1ed5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ed8, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_1edb, 3); mov(memb[ss, ebp - 36], al);            /* mov [ebp-0x24], al */
            ii(0x1016_1ede, 5); jmp(0x1016_1f91, 0xae); goto l_0x1016_1f91; /* jmp 0x10161f91 */
        l_0x1016_1ee3:
            ii(0x1016_1ee3, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_1ee6, 5); mov(eax, 0x101c_81b4);                  /* mov eax, 0x101c81b4 */
            ii(0x1016_1eeb, 5); call(0x1008_ab1c, -0xd_73d4);           /* call 0x1008ab1c */
            ii(0x1016_1ef0, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1016_1ef5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1ef8, 3); mov(ebx, memd[ds, eax + 65]);           /* mov ebx, [eax+0x41] */
            ii(0x1016_1efb, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_1efe, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f01, 3); mov(edx, memd[ds, eax + 63]);           /* mov edx, [eax+0x3f] */
            ii(0x1016_1f04, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_1f07, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f0a, 5); call(0x1014_e906, -0x1_3609);           /* call 0x1014e906 */
            ii(0x1016_1f0f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f12, 4); mov(memb[ds, eax + 62], 0x28);          /* mov byte [eax+0x3e], 0x28 */
            ii(0x1016_1f16, 5); jmp(0x1016_1fdf, 0xc4); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f1b:
            ii(0x1016_1f1b, 5); jmp(0x1016_1fdf, 0xbf); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f20:
            ii(0x1016_1f20, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f23, 4); mov(memb[ds, eax + 62], 5);             /* mov byte [eax+0x3e], 0x5 */
            ii(0x1016_1f27, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_1f2c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f2f, 5); call(0x1007_6d98, -0xe_b19c);           /* call 0x10076d98 */
            ii(0x1016_1f34, 2); test(al, al);                           /* test al, al */
            ii(0x1016_1f36, 2); if(jz(0x1016_1f53, 0x1b)) goto l_0x1016_1f53; /* jz 0x10161f53 */
            ii(0x1016_1f38, 5); call(0x1010_2bf8, -0x5_f345);           /* call 0x10102bf8 */
            ii(0x1016_1f3d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_1f3f, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_1f41, 5); mov(ebx, 0xb);                          /* mov ebx, 0xb */
            ii(0x1016_1f46, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_1f49, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_1f4e, 5); call(0x1013_d5c0, -0x2_4993);           /* call 0x1013d5c0 */
        l_0x1016_1f53:
            ii(0x1016_1f53, 7); mov(memb[ds, 0x101c_9447], 1);          /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1f5a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f5d, 5); call(0x1016_0d16, -0x124c);             /* call 0x10160d16 */
            ii(0x1016_1f62, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_1f64, 6); if(jz(0x1016_1fdf, 0x75)) goto l_0x1016_1fdf; /* jz 0x10161fdf */
        l_0x1016_1f6a:
            ii(0x1016_1f6a, 7); mov(memb[ds, 0x101c_9447], 1);          /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1f71, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f74, 5); call(0x1015_4355, -0xdc24);             /* call 0x10154355 */
            ii(0x1016_1f79, 5); jmp(0x1016_1fdf, 0x61); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f7e:
            ii(0x1016_1f7e, 7); mov(memb[ds, 0x101c_9447], 1);          /* mov byte [0x101c9447], 0x1 */
            ii(0x1016_1f85, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1f88, 5); call(0x1015_46ce, -0xd8bf);             /* call 0x101546ce */
            ii(0x1016_1f8d, 2); jmp(0x1016_1fdf, 0x50); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f8f:
            ii(0x1016_1f8f, 2); jmp(0x1016_1fdf, 0x4e); goto l_0x1016_1fdf; /* jmp 0x10161fdf */
        l_0x1016_1f91:
            ii(0x1016_1f91, 3); mov(al, memb[ss, ebp - 36]);            /* mov al, [ebp-0x24] */
            ii(0x1016_1f94, 3); mov(memb[ss, ebp - 40], al);            /* mov [ebp-0x28], al */
            ii(0x1016_1f97, 4); cmp(memb[ss, ebp - 40], 8);             /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1016_1f9b, 2); if(jb(0x1016_1fc7, 0x2a)) goto l_0x1016_1fc7; /* jb 0x10161fc7 */
            ii(0x1016_1f9d, 4); cmp(memb[ss, ebp - 40], 8);             /* cmp byte [ebp-0x28], 0x8 */
            ii(0x1016_1fa1, 2); if(jbe(0x1016_1f6a, -0x39)) goto l_0x1016_1f6a; /* jbe 0x10161f6a */
            ii(0x1016_1fa3, 4); cmp(memb[ss, ebp - 40], 0x28);          /* cmp byte [ebp-0x28], 0x28 */
            ii(0x1016_1fa7, 2); if(jb(0x1016_1fbf, 0x16)) goto l_0x1016_1fbf; /* jb 0x10161fbf */
            ii(0x1016_1fa9, 4); cmp(memb[ss, ebp - 40], 0x28);          /* cmp byte [ebp-0x28], 0x28 */
            ii(0x1016_1fad, 6); if(jbe(0x1016_1f1b, -0x98)) goto l_0x1016_1f1b; /* jbe 0x10161f1b */
            ii(0x1016_1fb3, 4); cmp(memb[ss, ebp - 40], 0x29);          /* cmp byte [ebp-0x28], 0x29 */
            ii(0x1016_1fb7, 6); if(jz(0x1016_1f20, -0x9d)) goto l_0x1016_1f20; /* jz 0x10161f20 */
            ii(0x1016_1fbd, 2); jmp(0x1016_1f8f, -0x30); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        l_0x1016_1fbf:
            ii(0x1016_1fbf, 4); cmp(memb[ss, ebp - 40], 9);             /* cmp byte [ebp-0x28], 0x9 */
            ii(0x1016_1fc3, 2); if(jz(0x1016_1f7e, -0x47)) goto l_0x1016_1f7e; /* jz 0x10161f7e */
            ii(0x1016_1fc5, 2); jmp(0x1016_1f8f, -0x38); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        l_0x1016_1fc7:
            ii(0x1016_1fc7, 4); cmp(memb[ss, ebp - 40], 0);             /* cmp byte [ebp-0x28], 0x0 */
            ii(0x1016_1fcb, 6); if(jbe(0x1016_1ee3, -0xee)) goto l_0x1016_1ee3; /* jbe 0x10161ee3 */
            ii(0x1016_1fd1, 4); cmp(memb[ss, ebp - 40], 5);             /* cmp byte [ebp-0x28], 0x5 */
            ii(0x1016_1fd5, 6); if(jz(0x1016_1f53, -0x88)) goto l_0x1016_1f53; /* jz 0x10161f53 */
            ii(0x1016_1fdb, 2); jmp(0x1016_1f8f, -0x4e); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        //  ii(0x1016_1fdd, 2); jmp(0x1016_1f8f, -0x50); goto l_0x1016_1f8f; /* jmp 0x10161f8f */
        l_0x1016_1fdf:
            ii(0x1016_1fdf, 5); jmp(0x1016_29a7, 0x9c3); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_1fe4:
            ii(0x1016_1fe4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1fe7, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_1fea, 3); mov(memb[ss, ebp - 44], al);            /* mov [ebp-0x2c], al */
            ii(0x1016_1fed, 5); jmp(0x1016_2135, 0x143); goto l_0x1016_2135; /* jmp 0x10162135 */
        l_0x1016_1ff2:
            ii(0x1016_1ff2, 5); mov(eax, StringDefinitions.BuildStart); /* mov eax, 0x101b2902 */
            ii(0x1016_1ff7, 5); call(0x100a_8b4a, -0xb_94b2);           /* call 0x100a8b4a */
            ii(0x1016_1ffc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_1fff, 5); call(0x1015_1565, -0x1_0a9f);           /* call 0x10151565 */
            ii(0x1016_2004, 5); jmp(0x1016_21a9, 0x1a0); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2009:
            ii(0x1016_2009, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1016_200e, 5); call(0x1007_5fdc, -0xe_c037);           /* call 0x10075fdc */
            ii(0x1016_2013, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2015, 2); if(jz(0x1016_2021, 0xa)) goto l_0x1016_2021; /* jz 0x10162021 */
            ii(0x1016_2017, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_201a, 5); cmp(memw[ds, eax + 8], 0x31);           /* cmp word [eax+0x8], 0x31 */
            ii(0x1016_201f, 2); if(jz(0x1016_2023, 2)) goto l_0x1016_2023; /* jz 0x10162023 */
        l_0x1016_2021:
            ii(0x1016_2021, 2); jmp(0x1016_2073, 0x50); goto l_0x1016_2073; /* jmp 0x10162073 */
        l_0x1016_2023:
            ii(0x1016_2023, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2026, 4); test(memb[ds, eax + 94], 1);            /* test byte [eax+0x5e], 0x1 */
            ii(0x1016_202a, 2); if(jz(0x1016_206d, 0x41)) goto l_0x1016_206d; /* jz 0x1016206d */
            ii(0x1016_202c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_202f, 5); call(0x1012_0a5c, -0x4_15d8);           /* call 0x10120a5c */
            ii(0x1016_2034, 1); cwde();                                 /* cwde */
            ii(0x1016_2035, 3); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1016_2038, 3); cmp(eax, 0x28);                         /* cmp eax, 0x28 */
            ii(0x1016_203b, 2); if(jl(0x1016_2055, 0x18)) goto l_0x1016_2055; /* jl 0x10162055 */
            ii(0x1016_203d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2040, 5); call(0x1012_0a5c, -0x4_15e9);           /* call 0x10120a5c */
            ii(0x1016_2045, 3); sub(eax, 0x10);                         /* sub eax, 0x10 */
            ii(0x1016_2048, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_204b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_204e, 5); call(0x1014_9b07, -0x1_854c);           /* call 0x10149b07 */
            ii(0x1016_2053, 2); jmp(0x1016_206d, 0x18); goto l_0x1016_206d; /* jmp 0x1016206d */
        l_0x1016_2055:
            ii(0x1016_2055, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2058, 5); call(0x1012_0a5c, -0x4_1601);           /* call 0x10120a5c */
            ii(0x1016_205d, 5); add(eax, 8);                            /* add eax, 0x8 */
            ii(0x1016_2062, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_2065, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2068, 5); call(0x1014_9b07, -0x1_8566);           /* call 0x10149b07 */
        l_0x1016_206d:
            ii(0x1016_206d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2070, 3); inc(memb[ds, eax + 94]);                /* inc byte [eax+0x5e] */
        l_0x1016_2073:
            ii(0x1016_2073, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_2078, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_207b, 5); call(0x1007_6d98, -0xe_b2e8);           /* call 0x10076d98 */
            ii(0x1016_2080, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2082, 2); if(jz(0x1016_209f, 0x1b)) goto l_0x1016_209f; /* jz 0x1016209f */
            ii(0x1016_2084, 5); call(0x1010_2bf8, -0x5_f491);           /* call 0x10102bf8 */
            ii(0x1016_2089, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_208b, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_208d, 5); mov(ebx, 8);                            /* mov ebx, 0x8 */
            ii(0x1016_2092, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_2095, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_209a, 5); call(0x1013_d5c0, -0x2_4adf);           /* call 0x1013d5c0 */
        l_0x1016_209f:
            ii(0x1016_209f, 5); jmp(0x1016_21a9, 0x105); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20a4:
            ii(0x1016_20a4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_20a7, 5); call(0x1014_ac97, -0x1_7415);           /* call 0x1014ac97 */
            ii(0x1016_20ac, 2); test(al, al);                           /* test al, al */
            ii(0x1016_20ae, 6); if(jz(0x1016_21a9, 0xf5)) goto l_0x1016_21a9; /* jz 0x101621a9 */
        l_0x1016_20b4:
            ii(0x1016_20b4, 5); mov(eax, StringDefinitions.Moving4);    /* mov eax, 0x101b290e */
            ii(0x1016_20b9, 5); call(0x100a_8b4a, -0xb_9574);           /* call 0x100a8b4a */
            ii(0x1016_20be, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_20c1, 5); call(0x1014_af42, -0x1_7184);           /* call 0x1014af42 */
            ii(0x1016_20c6, 5); jmp(0x1016_21a9, 0xde); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20cb:
            ii(0x1016_20cb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_20ce, 5); call(0x1016_1499, -0xc3a);              /* call 0x10161499 */
            ii(0x1016_20d3, 5); jmp(0x1016_21a9, 0xd1); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20d8:
            ii(0x1016_20d8, 5); mov(eax, StringDefinitions.BuildClearing); /* mov eax, 0x101b2915 */
            ii(0x1016_20dd, 5); call(0x100a_8b4a, -0xb_9598);           /* call 0x100a8b4a */
            ii(0x1016_20e2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_20e4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_20e7, 5); call(0x1016_07bf, -0x192d);             /* call 0x101607bf */
            ii(0x1016_20ec, 5); jmp(0x1016_21a9, 0xb8); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_20f1:
            ii(0x1016_20f1, 5); mov(eax, StringDefinitions.BuildCancel); /* mov eax, 0x101b2924 */
            ii(0x1016_20f6, 5); call(0x100a_8b4a, -0xb_95b1);           /* call 0x100a8b4a */
            ii(0x1016_20fb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_20fe, 5); call(0x1015_0b1a, -0x1_15e9);           /* call 0x10150b1a */
            ii(0x1016_2103, 5); jmp(0x1016_21a9, 0xa1); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2108:
            ii(0x1016_2108, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_210a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_210d, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1016_2110, 5); call(0x1013_ad71, -0x2_73a4);           /* call 0x1013ad71 */
            ii(0x1016_2115, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2117, 2); if(jz(0x1016_2123, 0xa)) goto l_0x1016_2123; /* jz 0x10162123 */
            ii(0x1016_2119, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_211c, 5); call(0x1015_f7cf, -0x2952);             /* call 0x1015f7cf */
            ii(0x1016_2121, 2); jmp(0x1016_212b, 8); goto l_0x1016_212b; /* jmp 0x1016212b */
        l_0x1016_2123:
            ii(0x1016_2123, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2126, 5); call(0x1016_1499, -0xc92);              /* call 0x10161499 */
        l_0x1016_212b:
            ii(0x1016_212b, 5); jmp(0x1016_21a9, 0x79); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2130:
            ii(0x1016_2130, 5); jmp(0x1016_21a9, 0x74); goto l_0x1016_21a9; /* jmp 0x101621a9 */
        l_0x1016_2135:
            ii(0x1016_2135, 3); mov(al, memb[ss, ebp - 44]);            /* mov al, [ebp-0x2c] */
            ii(0x1016_2138, 3); mov(memb[ss, ebp - 48], al);            /* mov [ebp-0x30], al */
            ii(0x1016_213b, 4); cmp(memb[ss, ebp - 48], 0xd);           /* cmp byte [ebp-0x30], 0xd */
            ii(0x1016_213f, 2); if(jb(0x1016_2175, 0x34)) goto l_0x1016_2175; /* jb 0x10162175 */
            ii(0x1016_2141, 4); cmp(memb[ss, ebp - 48], 0xd);           /* cmp byte [ebp-0x30], 0xd */
            ii(0x1016_2145, 2); if(jbe(0x1016_20f1, -0x56)) goto l_0x1016_20f1; /* jbe 0x101620f1 */
            ii(0x1016_2147, 4); cmp(memb[ss, ebp - 48], 0x1a);          /* cmp byte [ebp-0x30], 0x1a */
            ii(0x1016_214b, 2); if(jb(0x1016_2169, 0x1c)) goto l_0x1016_2169; /* jb 0x10162169 */
            ii(0x1016_214d, 4); cmp(memb[ss, ebp - 48], 0x1a);          /* cmp byte [ebp-0x30], 0x1a */
            ii(0x1016_2151, 2); if(jbe(0x1016_20d8, -0x7b)) goto l_0x1016_20d8; /* jbe 0x101620d8 */
            ii(0x1016_2153, 4); cmp(memb[ss, ebp - 48], 0x1f);          /* cmp byte [ebp-0x30], 0x1f */
            ii(0x1016_2157, 2); if(jb(0x1016_2167, 0xe)) goto l_0x1016_2167; /* jb 0x10162167 */
            ii(0x1016_2159, 4); cmp(memb[ss, ebp - 48], 0x1f);          /* cmp byte [ebp-0x30], 0x1f */
            ii(0x1016_215d, 2); if(jbe(0x1016_2108, -0x57)) goto l_0x1016_2108; /* jbe 0x10162108 */
            ii(0x1016_215f, 4); cmp(memb[ss, ebp - 48], 0x2e);          /* cmp byte [ebp-0x30], 0x2e */
            ii(0x1016_2163, 2); if(jz(0x1016_20f1, -0x74)) goto l_0x1016_20f1; /* jz 0x101620f1 */
            ii(0x1016_2165, 2); jmp(0x1016_2130, -0x37); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_2167:
            ii(0x1016_2167, 2); jmp(0x1016_2130, -0x39); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_2169:
            ii(0x1016_2169, 4); cmp(memb[ss, ebp - 48], 0x19);          /* cmp byte [ebp-0x30], 0x19 */
            ii(0x1016_216d, 6); if(jz(0x1016_20cb, -0xa8)) goto l_0x1016_20cb; /* jz 0x101620cb */
            ii(0x1016_2173, 2); jmp(0x1016_2130, -0x45); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_2175:
            ii(0x1016_2175, 4); cmp(memb[ss, ebp - 48], 5);             /* cmp byte [ebp-0x30], 0x5 */
            ii(0x1016_2179, 2); if(jb(0x1016_219d, 0x22)) goto l_0x1016_219d; /* jb 0x1016219d */
            ii(0x1016_217b, 4); cmp(memb[ss, ebp - 48], 5);             /* cmp byte [ebp-0x30], 0x5 */
            ii(0x1016_217f, 6); if(jbe(0x1016_20a4, -0xe1)) goto l_0x1016_20a4; /* jbe 0x101620a4 */
            ii(0x1016_2185, 4); cmp(memb[ss, ebp - 48], 6);             /* cmp byte [ebp-0x30], 0x6 */
            ii(0x1016_2189, 6); if(jbe(0x1016_20b4, -0xdb)) goto l_0x1016_20b4; /* jbe 0x101620b4 */
            ii(0x1016_218f, 4); cmp(memb[ss, ebp - 48], 0xb);           /* cmp byte [ebp-0x30], 0xb */
            ii(0x1016_2193, 6); if(jz(0x1016_2009, -0x190)) goto l_0x1016_2009; /* jz 0x10162009 */
            ii(0x1016_2199, 2); jmp(0x1016_2130, -0x6b); goto l_0x1016_2130; /* jmp 0x10162130 */
        //  ii(0x1016_219b, 2); jmp(0x1016_2130, -0x6d); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_219d:
            ii(0x1016_219d, 4); cmp(memb[ss, ebp - 48], 0);             /* cmp byte [ebp-0x30], 0x0 */
            ii(0x1016_21a1, 6); if(jz(0x1016_1ff2, -0x1b5)) goto l_0x1016_1ff2; /* jz 0x10161ff2 */
            ii(0x1016_21a7, 2); jmp(0x1016_2130, -0x79); goto l_0x1016_2130; /* jmp 0x10162130 */
        l_0x1016_21a9:
            ii(0x1016_21a9, 5); jmp(0x1016_29a7, 0x7f9); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_21ae:
            ii(0x1016_21ae, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_21b1, 4); cmp(memb[ds, eax + 62], 0xd);           /* cmp byte [eax+0x3e], 0xd */
            ii(0x1016_21b5, 2); if(jnz(0x1016_21c9, 0x12)) goto l_0x1016_21c9; /* jnz 0x101621c9 */
            ii(0x1016_21b7, 5); mov(eax, StringDefinitions.BuildHalting); /* mov eax, 0x101b2931 */
            ii(0x1016_21bc, 5); call(0x100a_8b4a, -0xb_9677);           /* call 0x100a8b4a */
            ii(0x1016_21c1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_21c4, 5); call(0x1015_0b1a, -0x1_16af);           /* call 0x10150b1a */
        l_0x1016_21c9:
            ii(0x1016_21c9, 5); jmp(0x1016_29a7, 0x7d9); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_21ce:
            ii(0x1016_21ce, 5); mov(eax, StringDefinitions.Activation); /* mov eax, 0x101b293f */
            ii(0x1016_21d3, 5); call(0x100a_8b4a, -0xb_968e);           /* call 0x100a8b4a */
            ii(0x1016_21d8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_21db, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_21de, 3); mov(memb[ss, ebp - 52], al);            /* mov [ebp-0x34], al */
            ii(0x1016_21e1, 2); jmp(0x1016_222e, 0x4b); goto l_0x1016_222e; /* jmp 0x1016222e */
        l_0x1016_21e3:
            ii(0x1016_21e3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_21e6, 5); call(0x1015_fc49, -0x25a2);             /* call 0x1015fc49 */
            ii(0x1016_21eb, 5); jmp(0x1016_2250, 0x60); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_21f0:
            ii(0x1016_21f0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_21f3, 5); call(0x1007_611c, -0xe_c0dc);           /* call 0x1007611c */
            ii(0x1016_21f8, 5); call(0x1014_9fa8, -0x1_8255);           /* call 0x10149fa8 */
            ii(0x1016_21fd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2200, 5); cmp(memw[ds, eax + 8], 0x31);           /* cmp word [eax+0x8], 0x31 */
            ii(0x1016_2205, 2); if(jnz(0x1016_2222, 0x1b)) goto l_0x1016_2222; /* jnz 0x10162222 */
            ii(0x1016_2207, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_220a, 4); mov(memb[ds, eax + 62], 0xb);           /* mov byte [eax+0x3e], 0xb */
            ii(0x1016_220e, 5); mov(ebx, 0x24);                         /* mov ebx, 0x24 */
            ii(0x1016_2213, 5); mov(edx, 0x17);                         /* mov edx, 0x17 */
            ii(0x1016_2218, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_221b, 5); call(0x1016_2f96, 0xd76);               /* call 0x10162f96 */
            ii(0x1016_2220, 2); jmp(0x1016_2250, 0x2e); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_2222:
            ii(0x1016_2222, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2225, 5); call(0x1015_f933, -0x28f7);             /* call 0x1015f933 */
            ii(0x1016_222a, 2); jmp(0x1016_2250, 0x24); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_222c:
            ii(0x1016_222c, 2); jmp(0x1016_2250, 0x22); goto l_0x1016_2250; /* jmp 0x10162250 */
        l_0x1016_222e:
            ii(0x1016_222e, 3); mov(al, memb[ss, ebp - 52]);            /* mov al, [ebp-0x34] */
            ii(0x1016_2231, 3); mov(memb[ss, ebp - 56], al);            /* mov [ebp-0x38], al */
            ii(0x1016_2234, 4); cmp(memb[ss, ebp - 56], 6);             /* cmp byte [ebp-0x38], 0x6 */
            ii(0x1016_2238, 2); if(jb(0x1016_2248, 0xe)) goto l_0x1016_2248; /* jb 0x10162248 */
            ii(0x1016_223a, 4); cmp(memb[ss, ebp - 56], 6);             /* cmp byte [ebp-0x38], 0x6 */
            ii(0x1016_223e, 2); if(jbe(0x1016_21f0, -0x50)) goto l_0x1016_21f0; /* jbe 0x101621f0 */
            ii(0x1016_2240, 4); cmp(memb[ss, ebp - 56], 0xb);           /* cmp byte [ebp-0x38], 0xb */
            ii(0x1016_2244, 2); if(jz(0x1016_2222, -0x24)) goto l_0x1016_2222; /* jz 0x10162222 */
            ii(0x1016_2246, 2); jmp(0x1016_222c, -0x1c); goto l_0x1016_222c; /* jmp 0x1016222c */
        l_0x1016_2248:
            ii(0x1016_2248, 4); cmp(memb[ss, ebp - 56], 1);             /* cmp byte [ebp-0x38], 0x1 */
            ii(0x1016_224c, 2); if(jz(0x1016_21e3, -0x6b)) goto l_0x1016_21e3; /* jz 0x101621e3 */
            ii(0x1016_224e, 2); jmp(0x1016_222c, -0x24); goto l_0x1016_222c; /* jmp 0x1016222c */
        l_0x1016_2250:
            ii(0x1016_2250, 5); jmp(0x1016_29a7, 0x752); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2255:
            ii(0x1016_2255, 5); mov(eax, StringDefinitions.NewAllocation); /* mov eax, 0x101b294a */
            ii(0x1016_225a, 5); call(0x100a_8b4a, -0xb_9715);           /* call 0x100a8b4a */
            ii(0x1016_225f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2262, 5); call(0x1014_f08b, -0x1_31dc);           /* call 0x1014f08b */
            ii(0x1016_2267, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_226c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_226f, 5); call(0x1007_6d98, -0xe_b4dc);           /* call 0x10076d98 */
            ii(0x1016_2274, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2276, 2); if(jz(0x1016_2280, 8)) goto l_0x1016_2280; /* jz 0x10162280 */
            ii(0x1016_2278, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_227b, 5); call(0x100f_f637, -0x6_2c49);           /* call 0x100ff637 */
        l_0x1016_2280:
            ii(0x1016_2280, 5); jmp(0x1016_29a7, 0x722); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2285:
            ii(0x1016_2285, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2288, 4); cmp(memb[ds, eax + 62], 0);             /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1016_228c, 6); if(jnz(0x1016_230e, 0x7c)) goto l_0x1016_230e; /* jnz 0x1016230e */
            ii(0x1016_2292, 5); mov(eax, StringDefinitions.PowerUp);    /* mov eax, 0x101b2959 */
            ii(0x1016_2297, 5); call(0x100a_8b4a, -0xb_9752);           /* call 0x100a8b4a */
            ii(0x1016_229c, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1016_22a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_22a4, 5); call(0x1007_6d98, -0xe_b511);           /* call 0x10076d98 */
            ii(0x1016_22a9, 2); test(al, al);                           /* test al, al */
            ii(0x1016_22ab, 2); if(jz(0x1016_22c8, 0x1b)) goto l_0x1016_22c8; /* jz 0x101622c8 */
            ii(0x1016_22ad, 5); call(0x1010_2bf8, -0x5_f6ba);           /* call 0x10102bf8 */
            ii(0x1016_22b2, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_22b4, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1016_22b6, 5); mov(ebx, 0xf);                          /* mov ebx, 0xf */
            ii(0x1016_22bb, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_22be, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1016_22c3, 5); call(0x1013_d5c0, -0x2_4d08);           /* call 0x1013d5c0 */
        l_0x1016_22c8:
            ii(0x1016_22c8, 5); mov(edx, 0xffff_ffff);                  /* mov edx, 0xffffffff */
            ii(0x1016_22cd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_22d0, 5); call(0x1015_cbca, -0x570b);             /* call 0x1015cbca */
            ii(0x1016_22d5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_22d8, 4); mov(ax, memw[ds, eax + 51]);            /* mov ax, [eax+0x33] */
            ii(0x1016_22dc, 1); inc(eax);                               /* inc eax */
            ii(0x1016_22dd, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_22e0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_22e3, 5); call(0x1014_9b07, -0x1_87e1);           /* call 0x10149b07 */
            ii(0x1016_22e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_22eb, 5); cmp(memw[ds, eax + 8], 0x1d);           /* cmp word [eax+0x8], 0x1d */
            ii(0x1016_22f0, 2); if(jnz(0x1016_230e, 0x1c)) goto l_0x1016_230e; /* jnz 0x1016230e */
            ii(0x1016_22f2, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x1016_22f7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_22fa, 3); mov(edx, memd[ds, eax + 90]);           /* mov edx, [eax+0x5a] */
            ii(0x1016_22fd, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x1016_2300, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2303, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1016_2306, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_2308, 1); cwde();                                 /* cwde */
            ii(0x1016_2309, 5); call(0x1013_322d, -0x2_f0e1);           /* call 0x1013322d */
        l_0x1016_230e:
            ii(0x1016_230e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2311, 5); call(0x1016_1499, -0xe7d);              /* call 0x10161499 */
            ii(0x1016_2316, 5); jmp(0x1016_29a7, 0x68c); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_231b:
            ii(0x1016_231b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_231e, 4); cmp(memb[ds, eax + 62], 0);             /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1016_2322, 2); if(jnz(0x1016_232c, 8)) goto l_0x1016_232c; /* jnz 0x1016232c */
            ii(0x1016_2324, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2327, 5); call(0x1015_ccd1, -0x565b);             /* call 0x1015ccd1 */
        l_0x1016_232c:
            ii(0x1016_232c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_232f, 5); call(0x1016_1499, -0xe9b);              /* call 0x10161499 */
            ii(0x1016_2334, 5); jmp(0x1016_29a7, 0x66e); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2339:
            ii(0x1016_2339, 5); mov(eax, StringDefinitions.Exploding3); /* mov eax, 0x101b2962 */
            ii(0x1016_233e, 5); call(0x100a_8b4a, -0xb_97f9);           /* call 0x100a8b4a */
            ii(0x1016_2343, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2346, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_2349, 3); mov(memb[ss, ebp - 60], al);            /* mov [ebp-0x3c], al */
            ii(0x1016_234c, 2); jmp(0x1016_2395, 0x47); goto l_0x1016_2395; /* jmp 0x10162395 */
        l_0x1016_234e:
            ii(0x1016_234e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2351, 4); mov(memb[ds, eax + 77], 0);             /* mov byte [eax+0x4d], 0x0 */
            ii(0x1016_2355, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2358, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_235a, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1016_235d, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1016_2363, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2366, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1016_2369, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_236c, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1016_236e, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1016_2370, 7); inc(memw[ds, eax + 0x101c_a5e9]);       /* inc word [eax+0x101ca5e9] */
            ii(0x1016_2377, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_237a, 5); call(0x1016_15c9, -0xdb6);              /* call 0x101615c9 */
        l_0x1016_237f:
            ii(0x1016_237f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2382, 5); call(0x1016_0ec3, -0x14c4);             /* call 0x10160ec3 */
            ii(0x1016_2387, 2); jmp(0x1016_23b7, 0x2e); goto l_0x1016_23b7; /* jmp 0x101623b7 */
        l_0x1016_2389:
            ii(0x1016_2389, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_238c, 5); call(0x1016_11db, -0x11b6);             /* call 0x101611db */
            ii(0x1016_2391, 2); jmp(0x1016_23b7, 0x24); goto l_0x1016_23b7; /* jmp 0x101623b7 */
        l_0x1016_2393:
            ii(0x1016_2393, 2); jmp(0x1016_23b7, 0x22); goto l_0x1016_23b7; /* jmp 0x101623b7 */
        l_0x1016_2395:
            ii(0x1016_2395, 3); mov(al, memb[ss, ebp - 60]);            /* mov al, [ebp-0x3c] */
            ii(0x1016_2398, 3); mov(memb[ss, ebp - 64], al);            /* mov [ebp-0x40], al */
            ii(0x1016_239b, 4); cmp(memb[ss, ebp - 64], 0xe);           /* cmp byte [ebp-0x40], 0xe */
            ii(0x1016_239f, 2); if(jb(0x1016_23af, 0xe)) goto l_0x1016_23af; /* jb 0x101623af */
            ii(0x1016_23a1, 4); cmp(memb[ss, ebp - 64], 0xe);           /* cmp byte [ebp-0x40], 0xe */
            ii(0x1016_23a5, 2); if(jbe(0x1016_2389, -0x1e)) goto l_0x1016_2389; /* jbe 0x10162389 */
            ii(0x1016_23a7, 4); cmp(memb[ss, ebp - 64], 0x1b);          /* cmp byte [ebp-0x40], 0x1b */
            ii(0x1016_23ab, 2); if(jz(0x1016_234e, -0x5f)) goto l_0x1016_234e; /* jz 0x1016234e */
            ii(0x1016_23ad, 2); jmp(0x1016_2393, -0x1c); goto l_0x1016_2393; /* jmp 0x10162393 */
        l_0x1016_23af:
            ii(0x1016_23af, 4); cmp(memb[ss, ebp - 64], 0);             /* cmp byte [ebp-0x40], 0x0 */
            ii(0x1016_23b3, 2); if(jz(0x1016_237f, -0x36)) goto l_0x1016_237f; /* jz 0x1016237f */
            ii(0x1016_23b5, 2); jmp(0x1016_2393, -0x24); goto l_0x1016_2393; /* jmp 0x10162393 */
        l_0x1016_23b7:
            ii(0x1016_23b7, 5); jmp(0x1016_29a7, 0x5eb); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_23bc:
            ii(0x1016_23bc, 5); mov(eax, StringDefinitions.Unloading);  /* mov eax, 0x101b296c */
            ii(0x1016_23c1, 5); call(0x100a_8b4a, -0xb_987c);           /* call 0x100a8b4a */
            ii(0x1016_23c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_23c9, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_23cc, 3); mov(memb[ss, ebp - 68], al);            /* mov [ebp-0x44], al */
            ii(0x1016_23cf, 2); jmp(0x1016_242d, 0x5c); goto l_0x1016_242d; /* jmp 0x1016242d */
        l_0x1016_23d1:
            ii(0x1016_23d1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_23d4, 4); mov(memb[ds, eax + 94], 0);             /* mov byte [eax+0x5e], 0x0 */
            ii(0x1016_23d8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_23db, 4); mov(memb[ds, eax + 62], 0x11);          /* mov byte [eax+0x3e], 0x11 */
            ii(0x1016_23df, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_23e2, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1016_23e5, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1016_23e7, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1016_23ea, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_23ec, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_23ef, 3); mov(edx, memd[ds, eax + 26]);           /* mov edx, [eax+0x1a] */
            ii(0x1016_23f2, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_23f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_23f8, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1016_23fb, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_23fe, 5); call(0x1011_a3f7, -0x4_800c);           /* call 0x1011a3f7 */
            ii(0x1016_2403, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2405, 2); if(jz(0x1016_2417, 0x10)) goto l_0x1016_2417; /* jz 0x10162417 */
            ii(0x1016_2407, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_240a, 4); mov(memb[ds, eax + 61], 0);             /* mov byte [eax+0x3d], 0x0 */
            ii(0x1016_240e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2411, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1016_2415, 2); jmp(0x1016_244f, 0x38); goto l_0x1016_244f; /* jmp 0x1016244f */
        l_0x1016_2417:
            ii(0x1016_2417, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_241a, 5); call(0x1015_e900, -0x3b1f);             /* call 0x1015e900 */
            ii(0x1016_241f, 2); jmp(0x1016_244f, 0x2e); goto l_0x1016_244f; /* jmp 0x1016244f */
        l_0x1016_2421:
            ii(0x1016_2421, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2424, 5); call(0x1015_ea25, -0x3a04);             /* call 0x1015ea25 */
            ii(0x1016_2429, 2); jmp(0x1016_244f, 0x24); goto l_0x1016_244f; /* jmp 0x1016244f */
        l_0x1016_242b:
            ii(0x1016_242b, 2); jmp(0x1016_244f, 0x22); goto l_0x1016_244f; /* jmp 0x1016244f */
        l_0x1016_242d:
            ii(0x1016_242d, 3); mov(al, memb[ss, ebp - 68]);            /* mov al, [ebp-0x44] */
            ii(0x1016_2430, 3); mov(memb[ss, ebp - 72], al);            /* mov [ebp-0x48], al */
            ii(0x1016_2433, 4); cmp(memb[ss, ebp - 72], 0x11);          /* cmp byte [ebp-0x48], 0x11 */
            ii(0x1016_2437, 2); if(jb(0x1016_2447, 0xe)) goto l_0x1016_2447; /* jb 0x10162447 */
            ii(0x1016_2439, 4); cmp(memb[ss, ebp - 72], 0x11);          /* cmp byte [ebp-0x48], 0x11 */
            ii(0x1016_243d, 2); if(jbe(0x1016_2417, -0x28)) goto l_0x1016_2417; /* jbe 0x10162417 */
            ii(0x1016_243f, 4); cmp(memb[ss, ebp - 72], 0x12);          /* cmp byte [ebp-0x48], 0x12 */
            ii(0x1016_2443, 2); if(jz(0x1016_2421, -0x24)) goto l_0x1016_2421; /* jz 0x10162421 */
            ii(0x1016_2445, 2); jmp(0x1016_242b, -0x1c); goto l_0x1016_242b; /* jmp 0x1016242b */
        l_0x1016_2447:
            ii(0x1016_2447, 4); cmp(memb[ss, ebp - 72], 0);             /* cmp byte [ebp-0x48], 0x0 */
            ii(0x1016_244b, 2); if(jz(0x1016_23d1, -0x7c)) goto l_0x1016_23d1; /* jz 0x101623d1 */
            ii(0x1016_244d, 2); jmp(0x1016_242b, -0x24); goto l_0x1016_242b; /* jmp 0x1016242b */
        l_0x1016_244f:
            ii(0x1016_244f, 5); jmp(0x1016_29a7, 0x553); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2454:
            ii(0x1016_2454, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2457, 4); cmp(memb[ds, eax + 62], 0);             /* cmp byte [eax+0x3e], 0x0 */
            ii(0x1016_245b, 2); if(jnz(0x1016_246f, 0x12)) goto l_0x1016_246f; /* jnz 0x1016246f */
            ii(0x1016_245d, 5); mov(eax, StringDefinitions.ClearStart); /* mov eax, 0x101b2976 */
            ii(0x1016_2462, 5); call(0x100a_8b4a, -0xb_991d);           /* call 0x100a8b4a */
            ii(0x1016_2467, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_246a, 5); call(0x1016_12d0, -0x119f);             /* call 0x101612d0 */
        l_0x1016_246f:
            ii(0x1016_246f, 5); jmp(0x1016_29a7, 0x533); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2474:
            ii(0x1016_2474, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2477, 4); test(memb[ds, eax + 18], 4);            /* test byte [eax+0x12], 0x4 */
            ii(0x1016_247b, 2); if(jz(0x1016_248b, 0xe)) goto l_0x1016_248b; /* jz 0x1016248b */
            ii(0x1016_247d, 5); mov(eax, 0x52);                         /* mov eax, 0x52 */
            ii(0x1016_2482, 5); call(0x1007_5fdc, -0xe_c4ab);           /* call 0x10075fdc */
            ii(0x1016_2487, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2489, 2); if(jnz(0x1016_248d, 2)) goto l_0x1016_248d; /* jnz 0x1016248d */
        l_0x1016_248b:
            ii(0x1016_248b, 2); jmp(0x1016_24cf, 0x42); goto l_0x1016_24cf; /* jmp 0x101624cf */
        l_0x1016_248d:
            ii(0x1016_248d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2490, 5); call(0x1012_0a5c, -0x4_1a39);           /* call 0x10120a5c */
            ii(0x1016_2495, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_2498, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_249b, 3); mov(eax, memd[ds, eax + 57]);           /* mov eax, [eax+0x39] */
            ii(0x1016_249e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_24a1, 1); inc(edx);                               /* inc edx */
            ii(0x1016_24a2, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_24a4, 2); if(jle(0x1016_24b9, 0x13)) goto l_0x1016_24b9; /* jle 0x101624b9 */
            ii(0x1016_24a6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24a9, 3); mov(edx, memd[ds, eax + 49]);           /* mov edx, [eax+0x31] */
            ii(0x1016_24ac, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_24af, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24b2, 5); call(0x1014_9b07, -0x1_89b0);           /* call 0x10149b07 */
            ii(0x1016_24b7, 2); jmp(0x1016_24cd, 0x14); goto l_0x1016_24cd; /* jmp 0x101624cd */
        l_0x1016_24b9:
            ii(0x1016_24b9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24bc, 5); call(0x1012_0a5c, -0x4_1a65);           /* call 0x10120a5c */
            ii(0x1016_24c1, 1); inc(eax);                               /* inc eax */
            ii(0x1016_24c2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1016_24c5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24c8, 5); call(0x1014_9b07, -0x1_89c6);           /* call 0x10149b07 */
        l_0x1016_24cd:
            ii(0x1016_24cd, 2); jmp(0x1016_24d7, 8); goto l_0x1016_24d7; /* jmp 0x101624d7 */
        l_0x1016_24cf:
            ii(0x1016_24cf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24d2, 5); call(0x1016_1499, -0x103e);             /* call 0x10161499 */
        l_0x1016_24d7:
            ii(0x1016_24d7, 5); jmp(0x1016_29a7, 0x4cb); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_24dc:
            ii(0x1016_24dc, 5); mov(eax, StringDefinitions.Landing);    /* mov eax, 0x101b2982 */
            ii(0x1016_24e1, 5); call(0x100a_8b4a, -0xb_999c);           /* call 0x100a8b4a */
            ii(0x1016_24e6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24e9, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_24ec, 3); mov(memb[ss, ebp - 76], al);            /* mov [ebp-0x4c], al */
            ii(0x1016_24ef, 2); jmp(0x1016_250b, 0x1a); goto l_0x1016_250b; /* jmp 0x1016250b */
        l_0x1016_24f1:
            ii(0x1016_24f1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24f4, 4); mov(memb[ds, eax + 94], 0);             /* mov byte [eax+0x5e], 0x0 */
            ii(0x1016_24f8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_24fb, 4); mov(memb[ds, eax + 62], 0x13);          /* mov byte [eax+0x3e], 0x13 */
        l_0x1016_24ff:
            ii(0x1016_24ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2502, 5); call(0x1015_e566, -0x3fa1);             /* call 0x1015e566 */
            ii(0x1016_2507, 2); jmp(0x1016_2521, 0x18); goto l_0x1016_2521; /* jmp 0x10162521 */
        l_0x1016_2509:
            ii(0x1016_2509, 2); jmp(0x1016_2521, 0x16); goto l_0x1016_2521; /* jmp 0x10162521 */
        l_0x1016_250b:
            ii(0x1016_250b, 3); mov(al, memb[ss, ebp - 76]);            /* mov al, [ebp-0x4c] */
            ii(0x1016_250e, 3); mov(memb[ss, ebp - 80], al);            /* mov [ebp-0x50], al */
            ii(0x1016_2511, 4); cmp(memb[ss, ebp - 80], 0);             /* cmp byte [ebp-0x50], 0x0 */
            ii(0x1016_2515, 2); if(jbe(0x1016_24f1, -0x26)) goto l_0x1016_24f1; /* jbe 0x101624f1 */
            ii(0x1016_2517, 4); cmp(memb[ss, ebp - 80], 0x13);          /* cmp byte [ebp-0x50], 0x13 */
            ii(0x1016_251b, 2); if(jz(0x1016_24ff, -0x1e)) goto l_0x1016_24ff; /* jz 0x101624ff */
            ii(0x1016_251d, 2); jmp(0x1016_2509, -0x16); goto l_0x1016_2509; /* jmp 0x10162509 */
        //  ii(0x1016_251f, 2); jmp(0x1016_2509, -0x18); goto l_0x1016_2509; /* jmp 0x10162509 */
        l_0x1016_2521:
            ii(0x1016_2521, 5); jmp(0x1016_29a7, 0x481); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2526:
            ii(0x1016_2526, 5); mov(eax, StringDefinitions.TakingOff);  /* mov eax, 0x101b298a */
            ii(0x1016_252b, 5); call(0x100a_8b4a, -0xb_99e6);           /* call 0x100a8b4a */
            ii(0x1016_2530, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2533, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_2536, 3); mov(memb[ss, ebp - 84], al);            /* mov [ebp-0x54], al */
            ii(0x1016_2539, 2); jmp(0x1016_257a, 0x3f); goto l_0x1016_257a; /* jmp 0x1016257a */
        l_0x1016_253b:
            ii(0x1016_253b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_253e, 4); mov(memb[ds, eax + 94], 0);             /* mov byte [eax+0x5e], 0x0 */
            ii(0x1016_2542, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2545, 4); mov(memb[ds, eax + 62], 0x14);          /* mov byte [eax+0x3e], 0x14 */
        l_0x1016_2549:
            ii(0x1016_2549, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_254c, 5); call(0x1015_41da, -0xe377);             /* call 0x101541da */
            ii(0x1016_2551, 2); test(al, al);                           /* test al, al */
            ii(0x1016_2553, 2); if(jz(0x1016_2576, 0x21)) goto l_0x1016_2576; /* jz 0x10162576 */
            ii(0x1016_2555, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2558, 5); call(0x1016_1621, -0xf3c);              /* call 0x10161621 */
            ii(0x1016_255d, 5); call(0x1015_50bc, -0xd4a6);             /* call 0x101550bc */
            ii(0x1016_2562, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1016_2565, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2567, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1016_2569, 5); call(0x1014_a205, -0x1_8369);           /* call 0x1014a205 */
            ii(0x1016_256e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2571, 5); call(0x1014_f08b, -0x1_34eb);           /* call 0x1014f08b */
        l_0x1016_2576:
            ii(0x1016_2576, 2); jmp(0x1016_2590, 0x18); goto l_0x1016_2590; /* jmp 0x10162590 */
        l_0x1016_2578:
            ii(0x1016_2578, 2); jmp(0x1016_2590, 0x16); goto l_0x1016_2590; /* jmp 0x10162590 */
        l_0x1016_257a:
            ii(0x1016_257a, 3); mov(al, memb[ss, ebp - 84]);            /* mov al, [ebp-0x54] */
            ii(0x1016_257d, 3); mov(memb[ss, ebp - 88], al);            /* mov [ebp-0x58], al */
            ii(0x1016_2580, 4); cmp(memb[ss, ebp - 88], 0);             /* cmp byte [ebp-0x58], 0x0 */
            ii(0x1016_2584, 2); if(jbe(0x1016_253b, -0x4b)) goto l_0x1016_253b; /* jbe 0x1016253b */
            ii(0x1016_2586, 4); cmp(memb[ss, ebp - 88], 0x14);          /* cmp byte [ebp-0x58], 0x14 */
            ii(0x1016_258a, 2); if(jz(0x1016_2549, -0x43)) goto l_0x1016_2549; /* jz 0x10162549 */
            ii(0x1016_258c, 2); jmp(0x1016_2578, -0x16); goto l_0x1016_2578; /* jmp 0x10162578 */
        //  ii(0x1016_258e, 2); jmp(0x1016_2578, -0x18); goto l_0x1016_2578; /* jmp 0x10162578 */
        l_0x1016_2590:
            ii(0x1016_2590, 5); jmp(0x1016_29a7, 0x412); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2595:
            ii(0x1016_2595, 5); mov(eax, StringDefinitions.Loading);    /* mov eax, 0x101b2995 */
            ii(0x1016_259a, 5); call(0x100a_8b4a, -0xb_9a55);           /* call 0x100a8b4a */
            ii(0x1016_259f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_25a2, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_25a5, 3); mov(memb[ss, ebp - 92], al);            /* mov [ebp-0x5c], al */
            ii(0x1016_25a8, 2); jmp(0x1016_25e0, 0x36); goto l_0x1016_25e0; /* jmp 0x101625e0 */
        l_0x1016_25aa:
            ii(0x1016_25aa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_25ad, 4); mov(memb[ds, eax + 94], 0);             /* mov byte [eax+0x5e], 0x0 */
            ii(0x1016_25b1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_25b4, 4); mov(memb[ds, eax + 62], 0xf);           /* mov byte [eax+0x3e], 0xf */
            ii(0x1016_25b8, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1016_25bd, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_25c0, 5); call(0x1007_611c, -0xe_c4a9);           /* call 0x1007611c */
            ii(0x1016_25c5, 5); call(0x1016_2f0a, 0x940);               /* call 0x10162f0a */
        l_0x1016_25ca:
            ii(0x1016_25ca, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_25cd, 5); call(0x1015_e611, -0x3fc1);             /* call 0x1015e611 */
            ii(0x1016_25d2, 2); jmp(0x1016_2602, 0x2e); goto l_0x1016_2602; /* jmp 0x10162602 */
        l_0x1016_25d4:
            ii(0x1016_25d4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_25d7, 5); call(0x1015_e7ed, -0x3def);             /* call 0x1015e7ed */
            ii(0x1016_25dc, 2); jmp(0x1016_2602, 0x24); goto l_0x1016_2602; /* jmp 0x10162602 */
        l_0x1016_25de:
            ii(0x1016_25de, 2); jmp(0x1016_2602, 0x22); goto l_0x1016_2602; /* jmp 0x10162602 */
        l_0x1016_25e0:
            ii(0x1016_25e0, 3); mov(al, memb[ss, ebp - 92]);            /* mov al, [ebp-0x5c] */
            ii(0x1016_25e3, 3); mov(memb[ss, ebp - 96], al);            /* mov [ebp-0x60], al */
            ii(0x1016_25e6, 4); cmp(memb[ss, ebp - 96], 0xf);           /* cmp byte [ebp-0x60], 0xf */
            ii(0x1016_25ea, 2); if(jb(0x1016_25fa, 0xe)) goto l_0x1016_25fa; /* jb 0x101625fa */
            ii(0x1016_25ec, 4); cmp(memb[ss, ebp - 96], 0xf);           /* cmp byte [ebp-0x60], 0xf */
            ii(0x1016_25f0, 2); if(jbe(0x1016_25ca, -0x28)) goto l_0x1016_25ca; /* jbe 0x101625ca */
            ii(0x1016_25f2, 4); cmp(memb[ss, ebp - 96], 0x10);          /* cmp byte [ebp-0x60], 0x10 */
            ii(0x1016_25f6, 2); if(jz(0x1016_25d4, -0x24)) goto l_0x1016_25d4; /* jz 0x101625d4 */
            ii(0x1016_25f8, 2); jmp(0x1016_25de, -0x1c); goto l_0x1016_25de; /* jmp 0x101625de */
        l_0x1016_25fa:
            ii(0x1016_25fa, 4); cmp(memb[ss, ebp - 96], 0);             /* cmp byte [ebp-0x60], 0x0 */
            ii(0x1016_25fe, 2); if(jz(0x1016_25aa, -0x56)) goto l_0x1016_25aa; /* jz 0x101625aa */
            ii(0x1016_2600, 2); jmp(0x1016_25de, -0x24); goto l_0x1016_25de; /* jmp 0x101625de */
        l_0x1016_2602:
            ii(0x1016_2602, 5); jmp(0x1016_29a7, 0x3a0); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2607:
            ii(0x1016_2607, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_260a, 4); cmp(memb[ds, eax + 62], 0x1e);          /* cmp byte [eax+0x3e], 0x1e */
            ii(0x1016_260e, 2); if(jnz(0x1016_2618, 8)) goto l_0x1016_2618; /* jnz 0x10162618 */
            ii(0x1016_2610, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2613, 5); call(0x1015_f9ae, -0x2c6a);             /* call 0x1015f9ae */
        l_0x1016_2618:
            ii(0x1016_2618, 5); jmp(0x1016_29a7, 0x38a); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_261d:
            ii(0x1016_261d, 5); mov(eax, StringDefinitions.Repairing);  /* mov eax, 0x101b299d */
            ii(0x1016_2622, 5); call(0x100a_8b4a, -0xb_9add);           /* call 0x100a8b4a */
            ii(0x1016_2627, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_262a, 5); call(0x1016_031e, -0x2311);             /* call 0x1016031e */
            ii(0x1016_262f, 5); jmp(0x1016_29a7, 0x373); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2634:
            ii(0x1016_2634, 5); mov(eax, StringDefinitions.Refuelling); /* mov eax, 0x101b29a7 */
            ii(0x1016_2639, 5); call(0x100a_8b4a, -0xb_9af4);           /* call 0x100a8b4a */
            ii(0x1016_263e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2641, 5); call(0x1007_611c, -0xe_c52a);           /* call 0x1007611c */
            ii(0x1016_2646, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2648, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_264b, 5); call(0x1015_1f87, -0x1_06c9);           /* call 0x10151f87 */
            ii(0x1016_2650, 5); jmp(0x1016_29a7, 0x352); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2655:
            ii(0x1016_2655, 5); mov(eax, StringDefinitions.Reloading);  /* mov eax, 0x101b29b2 */
            ii(0x1016_265a, 5); call(0x100a_8b4a, -0xb_9b15);           /* call 0x100a8b4a */
            ii(0x1016_265f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2662, 5); call(0x1007_611c, -0xe_c54b);           /* call 0x1007611c */
            ii(0x1016_2667, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_2669, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_266c, 5); call(0x1015_2023, -0x1_064e);           /* call 0x10152023 */
            ii(0x1016_2671, 5); jmp(0x1016_29a7, 0x331); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2676:
            ii(0x1016_2676, 5); mov(eax, StringDefinitions.LayMines);   /* mov eax, 0x101b29bc */
            ii(0x1016_267b, 5); call(0x100a_8b4a, -0xb_9b36);           /* call 0x100a8b4a */
            ii(0x1016_2680, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2683, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_2686, 3); mov(memb[ss, ebp - 100], al);           /* mov [ebp-0x64], al */
            ii(0x1016_2689, 2); jmp(0x1016_26c7, 0x3c); goto l_0x1016_26c7; /* jmp 0x101626c7 */
        l_0x1016_268b:
            ii(0x1016_268b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_268d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2690, 5); call(0x1016_4ad4, 0x243f);              /* call 0x10164ad4 */
            ii(0x1016_2695, 2); jmp(0x1016_26e9, 0x52); goto l_0x1016_26e9; /* jmp 0x101626e9 */
        l_0x1016_2697:
            ii(0x1016_2697, 5); mov(edx, 2);                            /* mov edx, 0x2 */
            ii(0x1016_269c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_269f, 5); call(0x1016_4ad4, 0x2430);              /* call 0x10164ad4 */
            ii(0x1016_26a4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_26a7, 5); call(0x1015_3997, -0xed15);             /* call 0x10153997 */
            ii(0x1016_26ac, 2); jmp(0x1016_26e9, 0x3b); goto l_0x1016_26e9; /* jmp 0x101626e9 */
        l_0x1016_26ae:
            ii(0x1016_26ae, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_26b3, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_26b6, 5); call(0x1016_4ad4, 0x2419);              /* call 0x10164ad4 */
            ii(0x1016_26bb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_26be, 5); call(0x1015_3c48, -0xea7b);             /* call 0x10153c48 */
            ii(0x1016_26c3, 2); jmp(0x1016_26e9, 0x24); goto l_0x1016_26e9; /* jmp 0x101626e9 */
        l_0x1016_26c5:
            ii(0x1016_26c5, 2); jmp(0x1016_26e9, 0x22); goto l_0x1016_26e9; /* jmp 0x101626e9 */
        l_0x1016_26c7:
            ii(0x1016_26c7, 3); mov(al, memb[ss, ebp - 100]);           /* mov al, [ebp-0x64] */
            ii(0x1016_26ca, 3); mov(memb[ss, ebp - 104], al);           /* mov [ebp-0x68], al */
            ii(0x1016_26cd, 4); cmp(memb[ss, ebp - 104], 0x2c);         /* cmp byte [ebp-0x68], 0x2c */
            ii(0x1016_26d1, 2); if(jb(0x1016_26e1, 0xe)) goto l_0x1016_26e1; /* jb 0x101626e1 */
            ii(0x1016_26d3, 4); cmp(memb[ss, ebp - 104], 0x2c);         /* cmp byte [ebp-0x68], 0x2c */
            ii(0x1016_26d7, 2); if(jbe(0x1016_2697, -0x42)) goto l_0x1016_2697; /* jbe 0x10162697 */
            ii(0x1016_26d9, 4); cmp(memb[ss, ebp - 104], 0x2d);         /* cmp byte [ebp-0x68], 0x2d */
            ii(0x1016_26dd, 2); if(jz(0x1016_26ae, -0x31)) goto l_0x1016_26ae; /* jz 0x101626ae */
            ii(0x1016_26df, 2); jmp(0x1016_26c5, -0x1c); goto l_0x1016_26c5; /* jmp 0x101626c5 */
        l_0x1016_26e1:
            ii(0x1016_26e1, 4); cmp(memb[ss, ebp - 104], 0x2b);         /* cmp byte [ebp-0x68], 0x2b */
            ii(0x1016_26e5, 2); if(jz(0x1016_268b, -0x5c)) goto l_0x1016_268b; /* jz 0x1016268b */
            ii(0x1016_26e7, 2); jmp(0x1016_26c5, -0x24); goto l_0x1016_26c5; /* jmp 0x101626c5 */
        l_0x1016_26e9:
            ii(0x1016_26e9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_26ec, 5); call(0x1014_f08b, -0x1_3666);           /* call 0x1014f08b */
            ii(0x1016_26f1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_26f6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_26f9, 5); call(0x1015_2605, -0x1_00f9);           /* call 0x10152605 */
            ii(0x1016_26fe, 5); jmp(0x1016_29a7, 0x2a4); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2703:
            ii(0x1016_2703, 5); mov(eax, StringDefinitions.Tranferring); /* mov eax, 0x101b29c6 */
            ii(0x1016_2708, 5); call(0x100a_8b4a, -0xb_9bc3);           /* call 0x100a8b4a */
            ii(0x1016_270d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2710, 5); call(0x1016_0464, -0x22b1);             /* call 0x10160464 */
            ii(0x1016_2715, 5); jmp(0x1016_29a7, 0x28d); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_271a:
            ii(0x1016_271a, 5); mov(eax, StringDefinitions.Upgrading);  /* mov eax, 0x101b29d2 */
            ii(0x1016_271f, 5); call(0x100a_8b4a, -0xb_9bda);           /* call 0x100a8b4a */
            ii(0x1016_2724, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2727, 5); call(0x1007_611c, -0xe_c610);           /* call 0x1007611c */
            ii(0x1016_272c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_272e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2731, 5); call(0x1015_2125, -0x1_0611);           /* call 0x10152125 */
            ii(0x1016_2736, 5); jmp(0x1016_29a7, 0x26c); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_273b:
            ii(0x1016_273b, 5); mov(eax, StringDefinitions.Scaling);    /* mov eax, 0x101b29dc */
            ii(0x1016_2740, 5); call(0x100a_8b4a, -0xb_9bfb);           /* call 0x100a8b4a */
            ii(0x1016_2745, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2748, 5); call(0x1014_9fa8, -0x1_87a5);           /* call 0x10149fa8 */
            ii(0x1016_274d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2750, 4); cmp(memb[ds, eax + 63], 0x18);          /* cmp byte [eax+0x3f], 0x18 */
            ii(0x1016_2754, 2); if(jz(0x1016_275f, 9)) goto l_0x1016_275f; /* jz 0x1016275f */
            ii(0x1016_2756, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2759, 4); cmp(memb[ds, eax + 63], 0x19);          /* cmp byte [eax+0x3f], 0x19 */
            ii(0x1016_275d, 2); if(jnz(0x1016_2766, 7)) goto l_0x1016_2766; /* jnz 0x10162766 */
        l_0x1016_275f:
            ii(0x1016_275f, 7); mov(memb[ds, 0x101c_9448], 1);          /* mov byte [0x101c9448], 0x1 */
        l_0x1016_2766:
            ii(0x1016_2766, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2769, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_276c, 3); mov(memb[ss, ebp - 108], al);           /* mov [ebp-0x6c], al */
            ii(0x1016_276f, 5); jmp(0x1016_27f4, 0x80); goto l_0x1016_27f4; /* jmp 0x101627f4 */
        l_0x1016_2774:
            ii(0x1016_2774, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2777, 3); mov(al, memb[ds, eax + 45]);            /* mov al, [eax+0x2d] */
            ii(0x1016_277a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_277f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_2781, 2); if(jz(0x1016_278b, 8)) goto l_0x1016_278b; /* jz 0x1016278b */
            ii(0x1016_2783, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2786, 3); dec(memb[ds, eax + 45]);                /* dec byte [eax+0x2d] */
            ii(0x1016_2789, 2); jmp(0x1016_27ce, 0x43); goto l_0x1016_27ce; /* jmp 0x101627ce */
        l_0x1016_278b:
            ii(0x1016_278b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_278e, 5); call(0x1014_f08b, -0x1_3708);           /* call 0x1014f08b */
            ii(0x1016_2793, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2796, 5); call(0x1015_ec73, -0x3b28);             /* call 0x1015ec73 */
            ii(0x1016_279b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_279e, 5); call(0x1015_26ac, -0x1_00f7);           /* call 0x101526ac */
            ii(0x1016_27a3, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_27a5, 2); if(jz(0x1016_27c1, 0x1a)) goto l_0x1016_27c1; /* jz 0x101627c1 */
            ii(0x1016_27a7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_27aa, 5); call(0x1015_26ac, -0x1_0103);           /* call 0x101526ac */
            ii(0x1016_27af, 3); mov(memd[ss, ebp - 112], eax);          /* mov [ebp-0x70], eax */
            ii(0x1016_27b2, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x1016_27b5, 3); mov(ebx, memd[ds, eax + 2]);            /* mov ebx, [eax+0x2] */
            ii(0x1016_27b8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_27bb, 3); mov(eax, memd[ss, ebp - 112]);          /* mov eax, [ebp-0x70] */
            ii(0x1016_27be, 3); call_abs(memd[ds, ebx + 44]);           /* call dword [ebx+0x2c] */
        l_0x1016_27c1:
            ii(0x1016_27c1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1016_27c6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_27c9, 5); call(0x1015_2605, -0x1_01c9);           /* call 0x10152605 */
        l_0x1016_27ce:
            ii(0x1016_27ce, 2); jmp(0x1016_2814, 0x44); goto l_0x1016_2814; /* jmp 0x10162814 */
        l_0x1016_27d0:
            ii(0x1016_27d0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_27d3, 3); mov(al, memb[ds, eax + 45]);            /* mov al, [eax+0x2d] */
            ii(0x1016_27d6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_27db, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1016_27de, 2); if(jz(0x1016_27e8, 8)) goto l_0x1016_27e8; /* jz 0x101627e8 */
            ii(0x1016_27e0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_27e3, 3); inc(memb[ds, eax + 45]);                /* inc byte [eax+0x2d] */
            ii(0x1016_27e6, 2); jmp(0x1016_27f0, 8); goto l_0x1016_27f0; /* jmp 0x101627f0 */
        l_0x1016_27e8:
            ii(0x1016_27e8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_27eb, 5); call(0x1016_16bd, -0x1133);             /* call 0x101616bd */
        l_0x1016_27f0:
            ii(0x1016_27f0, 2); jmp(0x1016_2814, 0x22); goto l_0x1016_2814; /* jmp 0x10162814 */
        l_0x1016_27f2:
            ii(0x1016_27f2, 2); jmp(0x1016_2814, 0x20); goto l_0x1016_2814; /* jmp 0x10162814 */
        l_0x1016_27f4:
            ii(0x1016_27f4, 3); mov(al, memb[ss, ebp - 108]);           /* mov al, [ebp-0x6c] */
            ii(0x1016_27f7, 3); mov(memb[ss, ebp - 116], al);           /* mov [ebp-0x74], al */
            ii(0x1016_27fa, 4); cmp(memb[ss, ebp - 116], 0x20);         /* cmp byte [ebp-0x74], 0x20 */
            ii(0x1016_27fe, 2); if(jb(0x1016_2812, 0x12)) goto l_0x1016_2812; /* jb 0x10162812 */
            ii(0x1016_2800, 4); cmp(memb[ss, ebp - 116], 0x20);         /* cmp byte [ebp-0x74], 0x20 */
            ii(0x1016_2804, 6); if(jbe(0x1016_2774, -0x96)) goto l_0x1016_2774; /* jbe 0x10162774 */
            ii(0x1016_280a, 4); cmp(memb[ss, ebp - 116], 0x21);         /* cmp byte [ebp-0x74], 0x21 */
            ii(0x1016_280e, 2); if(jz(0x1016_27d0, -0x40)) goto l_0x1016_27d0; /* jz 0x101627d0 */
            ii(0x1016_2810, 2); jmp(0x1016_27f2, -0x20); goto l_0x1016_27f2; /* jmp 0x101627f2 */
        l_0x1016_2812:
            ii(0x1016_2812, 2); jmp(0x1016_27f2, -0x22); goto l_0x1016_27f2; /* jmp 0x101627f2 */
        l_0x1016_2814:
            ii(0x1016_2814, 5); jmp(0x1016_29a7, 0x18e); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2819:
            ii(0x1016_2819, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_281c, 5); call(0x1015_3794, -0xf08d);             /* call 0x10153794 */
            ii(0x1016_2821, 5); jmp(0x1016_29a7, 0x181); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2826:
            ii(0x1016_2826, 7); mov(memb[ds, 0x101c_9448], 1);          /* mov byte [0x101c9448], 0x1 */
            ii(0x1016_282d, 5); mov(eax, StringDefinitions.DisableSteal); /* mov eax, 0x101b29e4 */
            ii(0x1016_2832, 5); call(0x100a_8b4a, -0xb_9ced);           /* call 0x100a8b4a */
            ii(0x1016_2837, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_283a, 3); mov(al, memb[ds, eax + 62]);            /* mov al, [eax+0x3e] */
            ii(0x1016_283d, 3); mov(memb[ss, ebp - 120], al);           /* mov [ebp-0x78], al */
            ii(0x1016_2840, 5); jmp(0x1016_28c7, 0x82); goto l_0x1016_28c7; /* jmp 0x101628c7 */
        l_0x1016_2845:
            ii(0x1016_2845, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2848, 4); mov(memb[ds, eax + 62], 5);             /* mov byte [eax+0x3e], 0x5 */
            ii(0x1016_284c, 5); mov(edx, 0x21);                         /* mov edx, 0x21 */
            ii(0x1016_2851, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2854, 5); call(0x1016_2f0a, 0x6b1);               /* call 0x10162f0a */
            ii(0x1016_2859, 5); jmp(0x1016_28f1, 0x93); goto l_0x1016_28f1; /* jmp 0x101628f1 */
        l_0x1016_285e:
            ii(0x1016_285e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2861, 5); call(0x1007_611c, -0xe_c74a);           /* call 0x1007611c */
            ii(0x1016_2866, 5); call(0x1015_4063, -0xe808);             /* call 0x10154063 */
            ii(0x1016_286b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_286e, 5); call(0x1007_611c, -0xe_c757);           /* call 0x1007611c */
            ii(0x1016_2873, 3); mov(al, memb[ds, eax + 107]);           /* mov al, [eax+0x6b] */
            ii(0x1016_2876, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_287b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_287d, 2); if(jnz(0x1016_2893, 0x14)) goto l_0x1016_2893; /* jnz 0x10162893 */
            ii(0x1016_287f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2882, 4); mov(memb[ds, eax + 62], 1);             /* mov byte [eax+0x3e], 0x1 */
            ii(0x1016_2886, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1016_288b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_288e, 5); call(0x1016_2f0a, 0x677);               /* call 0x10162f0a */
        l_0x1016_2893:
            ii(0x1016_2893, 2); jmp(0x1016_28f1, 0x5c); goto l_0x1016_28f1; /* jmp 0x101628f1 */
        l_0x1016_2895:
            ii(0x1016_2895, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_2898, 5); call(0x1015_c8f0, -0x5fad);             /* call 0x1015c8f0 */
            ii(0x1016_289d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_289f, 2); if(jz(0x1016_28bc, 0x1b)) goto l_0x1016_28bc; /* jz 0x101628bc */
            ii(0x1016_28a1, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_28a4, 4); cmp(memb[ds, eax + 61], 0x18);          /* cmp byte [eax+0x3d], 0x18 */
            ii(0x1016_28a8, 2); if(jnz(0x1016_28b4, 0xa)) goto l_0x1016_28b4; /* jnz 0x101628b4 */
            ii(0x1016_28aa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_28ad, 5); call(0x1015_cd6f, -0x5b43);             /* call 0x1015cd6f */
            ii(0x1016_28b2, 2); jmp(0x1016_28bc, 8); goto l_0x1016_28bc; /* jmp 0x101628bc */
        l_0x1016_28b4:
            ii(0x1016_28b4, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_28b7, 5); call(0x1015_ce8f, -0x5a2d);             /* call 0x1015ce8f */
        l_0x1016_28bc:
            ii(0x1016_28bc, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_28bf, 4); mov(memb[ds, eax + 61], 0);             /* mov byte [eax+0x3d], 0x0 */
            ii(0x1016_28c3, 2); jmp(0x1016_28f1, 0x2c); goto l_0x1016_28f1; /* jmp 0x101628f1 */
        l_0x1016_28c5:
            ii(0x1016_28c5, 2); jmp(0x1016_28f1, 0x2a); goto l_0x1016_28f1; /* jmp 0x101628f1 */
        l_0x1016_28c7:
            ii(0x1016_28c7, 3); mov(al, memb[ss, ebp - 120]);           /* mov al, [ebp-0x78] */
            ii(0x1016_28ca, 3); mov(memb[ss, ebp - 124], al);           /* mov [ebp-0x7c], al */
            ii(0x1016_28cd, 4); cmp(memb[ss, ebp - 124], 1);            /* cmp byte [ebp-0x7c], 0x1 */
            ii(0x1016_28d1, 2); if(jb(0x1016_28e5, 0x12)) goto l_0x1016_28e5; /* jb 0x101628e5 */
            ii(0x1016_28d3, 4); cmp(memb[ss, ebp - 124], 1);            /* cmp byte [ebp-0x7c], 0x1 */
            ii(0x1016_28d7, 2); if(jbe(0x1016_2895, -0x44)) goto l_0x1016_2895; /* jbe 0x10162895 */
            ii(0x1016_28d9, 4); cmp(memb[ss, ebp - 124], 5);            /* cmp byte [ebp-0x7c], 0x5 */
            ii(0x1016_28dd, 6); if(jz(0x1016_285e, -0x85)) goto l_0x1016_285e; /* jz 0x1016285e */
            ii(0x1016_28e3, 2); jmp(0x1016_28c5, -0x20); goto l_0x1016_28c5; /* jmp 0x101628c5 */
        l_0x1016_28e5:
            ii(0x1016_28e5, 4); cmp(memb[ss, ebp - 124], 0);            /* cmp byte [ebp-0x7c], 0x0 */
            ii(0x1016_28e9, 6); if(jz(0x1016_2845, -0xaa)) goto l_0x1016_2845; /* jz 0x10162845 */
            ii(0x1016_28ef, 2); jmp(0x1016_28c5, -0x2c); goto l_0x1016_28c5; /* jmp 0x101628c5 */
        l_0x1016_28f1:
            ii(0x1016_28f1, 5); jmp(0x1016_29a7, 0xb1); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_28f6:
            ii(0x1016_28f6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_28f9, 5); call(0x1016_1499, -0x1465);             /* call 0x10161499 */
            ii(0x1016_28fe, 5); jmp(0x1016_29a7, 0xa4); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        l_0x1016_2903:
            ii(0x1016_2903, 5); jmp(0x1016_29a7, 0x9f); goto l_0x1016_29a7; /* jmp 0x101629a7 */
        //  ii(0x1016_2908, 128); /* Служебная область с абсолютными адресами переходов. (0x1016_1a41, 0x1016_1b27, 0x1016_1bf4, 0x1016_1ec4, 0x1016_1fe4, 0x1016_21ce, 0x1016_2255, 0x1016_2285, 0x1016_231b, 0x1016_2339, 0x1016_23bc, 0x1016_2454, 0x1016_2474, 0x1016_24dc, 0x1016_2526, 0x1016_2595, 0x1016_2607, 0x1016_261d, 0x1016_2634, 0x1016_2655, 0x1016_2703, 0x1016_21ae, 0x1016_273b, 0x1016_2819, 0x1016_2826, 0x1016_2826, 0x1016_28f6, 0x1016_1bf4, 0x1016_271a, 0x1016_2676, 0x1016_1bf4, 0x1016_21ae). */
        l_0x1016_2988:
            ii(0x1016_2988, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1016_298b, 3); mov(memb[ss, ebp - 128], al);           /* mov [ebp-0x80], al */
            ii(0x1016_298e, 4); cmp(memb[ss, ebp - 128], 0x1f);         /* cmp byte [ebp-0x80], 0x1f */
            ii(0x1016_2992, 6); if(ja(0x1016_2903, -0x95)) goto l_0x1016_2903; /* ja 0x10162903 */
            ii(0x1016_2998, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_299a, 3); mov(al, memb[ss, ebp - 128]);           /* mov al, [ebp-0x80] */
            ii(0x1016_299d, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1016_29a0, 7); 
            switch (jmp_abs_switch(memd[cs, eax + 0x1016_2908]))
            {
                case 0x1016_1a41:
                    goto l_0x1016_1a41;
                case 0x1016_1b27:
                    goto l_0x1016_1b27;
                case 0x1016_1bf4:
                    goto l_0x1016_1bf4;
                case 0x1016_1ec4:
                    goto l_0x1016_1ec4;
                case 0x1016_1fe4:
                    goto l_0x1016_1fe4;
                case 0x1016_21ae:
                    goto l_0x1016_21ae;
                case 0x1016_21ce:
                    goto l_0x1016_21ce;
                case 0x1016_2255:
                    goto l_0x1016_2255;
                case 0x1016_2285:
                    goto l_0x1016_2285;
                case 0x1016_231b:
                    goto l_0x1016_231b;
                case 0x1016_2339:
                    goto l_0x1016_2339;
                case 0x1016_23bc:
                    goto l_0x1016_23bc;
                case 0x1016_2454:
                    goto l_0x1016_2454;
                case 0x1016_2474:
                    goto l_0x1016_2474;
                case 0x1016_24dc:
                    goto l_0x1016_24dc;
                case 0x1016_2526:
                    goto l_0x1016_2526;
                case 0x1016_2595:
                    goto l_0x1016_2595;
                case 0x1016_2607:
                    goto l_0x1016_2607;
                case 0x1016_261d:
                    goto l_0x1016_261d;
                case 0x1016_2634:
                    goto l_0x1016_2634;
                case 0x1016_2655:
                    goto l_0x1016_2655;
                case 0x1016_2676:
                    goto l_0x1016_2676;
                case 0x1016_2703:
                    goto l_0x1016_2703;
                case 0x1016_271a:
                    goto l_0x1016_271a;
                case 0x1016_273b:
                    goto l_0x1016_273b;
                case 0x1016_2819:
                    goto l_0x1016_2819;
                case 0x1016_2826:
                    goto l_0x1016_2826;
                case 0x1016_28f6:
                    goto l_0x1016_28f6;
                default:
                    throw new NotImplementedException();
            } /* jmp dword [cs:eax+0x10162908] */
        l_0x1016_29a7:
            ii(0x1016_29a7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_29a9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_29aa, 1); pop(edi);                               /* pop edi */
            ii(0x1016_29ab, 1); pop(esi);                               /* pop esi */
            ii(0x1016_29ac, 1); pop(edx);                               /* pop edx */
            ii(0x1016_29ad, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_29ae, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_29af, 1); ret();                                  /* ret */
        }
    }
}

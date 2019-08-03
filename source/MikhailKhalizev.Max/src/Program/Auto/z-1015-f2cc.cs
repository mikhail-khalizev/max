using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abd396b9-c2fc-4dd7-948e-52d1a2b4b176")]
        public void Method_1015_f2cc()
        {
            ii(0x1015_f2cc, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_f2d1, 5); calld(Definitions.sys_check_available_stack_size, 0x6a7c); /* call 0x10165d52 */
            ii(0x1015_f2d6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_f2d7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_f2d8, 1); pushd(edx);                             /* push edx */
            ii(0x1015_f2d9, 1); pushd(esi);                             /* push esi */
            ii(0x1015_f2da, 1); pushd(edi);                             /* push edi */
            ii(0x1015_f2db, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_f2dc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_f2de, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_f2e4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_f2e7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f2ea, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_f2ed, 5); calld(0x1007_66ac, -0xe8c46);           /* call 0x100766ac */
            ii(0x1015_f2f2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f2f5, 5); calld(0x1011_fe27, -0x3f4d3);           /* call 0x1011fe27 */
            ii(0x1015_f2fa, 3); lea(edx, ebp - 0x8);                    /* lea edx, [ebp-0x8] */
            ii(0x1015_f2fd, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1015_f302, 5); calld(0x1008_b530, -0xd3dd7);           /* call 0x1008b530 */
            ii(0x1015_f307, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f309, 2); if(jzd(0x1015_f36b, 0x60)) goto l_0x1015_f36b; /* jz 0x1015f36b */
            ii(0x1015_f30b, 5); calld(0x1010_2bf8, -0x5c718);           /* call 0x10102bf8 */
            ii(0x1015_f310, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f312, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_f314, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_f316, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f319, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_f31e, 5); calld(0x1013_d5c0, -0x21d63);           /* call 0x1013d5c0 */
            ii(0x1015_f323, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f325, 5); mov(eax, 0x101c_37bc);                  /* mov eax, 0x101c37bc */
            ii(0x1015_f32a, 5); calld(0x1007_6630, -0xe8cff);           /* call 0x10076630 */
            ii(0x1015_f32f, 7); cmp(memb_a32[ds, 0x101c_3916], 0);      /* cmp byte [0x101c3916], 0x0 */
            ii(0x1015_f336, 2); if(jzd(0x1015_f36b, 0x33)) goto l_0x1015_f36b; /* jz 0x1015f36b */
            ii(0x1015_f338, 5); calld(0x100f_a835, -0x64b08);           /* call 0x100fa835 */
            ii(0x1015_f33d, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_f342, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f344, 5); mov(eax, 0x6);                          /* mov eax, 0x6 */
            ii(0x1015_f349, 5); calld(0x100f_fca3, -0x5f6ab);           /* call 0x100ffca3 */
            ii(0x1015_f34e, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1015_f353, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f355, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1015_f35a, 5); calld(0x100f_fca3, -0x5f6bc);           /* call 0x100ffca3 */
            ii(0x1015_f35f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f361, 5); calld(0x100f_448c, -0x6aeda);           /* call 0x100f448c */
            ii(0x1015_f366, 5); calld(0x100f_f5c1, -0x5fdaa);           /* call 0x100ff5c1 */
        l_0x1015_f36b:
            ii(0x1015_f36b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f36e, 4); cmp(memb_a32[ds, eax + 0x3f], 0x3);     /* cmp byte [eax+0x3f], 0x3 */
            ii(0x1015_f372, 2); if(jnzd(0x1015_f37d, 0x9)) goto l_0x1015_f37d; /* jnz 0x1015f37d */
            ii(0x1015_f374, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f377, 4); cmp(memb_a32[ds, eax + 0x40], 0);       /* cmp byte [eax+0x40], 0x0 */
            ii(0x1015_f37b, 2); if(jnzd(0x1015_f37f, 0x2)) goto l_0x1015_f37f; /* jnz 0x1015f37f */
        l_0x1015_f37d:
            ii(0x1015_f37d, 2); jmpd(0x1015_f39e, 0x1f); goto l_0x1015_f39e; /* jmp 0x1015f39e */
        l_0x1015_f37f:
            ii(0x1015_f37f, 5); mov(ecx, 0xffff_ffff);                  /* mov ecx, 0xffffffff */
            ii(0x1015_f384, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f387, 3); mov(ebx, memd_a32[ds, eax + 0x41]);     /* mov ebx, [eax+0x41] */
            ii(0x1015_f38a, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_f38d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f390, 3); mov(edx, memd_a32[ds, eax + 0x3f]);     /* mov edx, [eax+0x3f] */
            ii(0x1015_f393, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_f396, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f399, 5); calld(0x1014_e906, -0x10a98);           /* call 0x1014e906 */
        l_0x1015_f39e:
            ii(0x1015_f39e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f3a1, 5); mov(eax, 0x101c_3924);                  /* mov eax, 0x101c3924 */
            ii(0x1015_f3a6, 5); calld(0x1008_aab4, -0xd48f7);           /* call 0x1008aab4 */
            ii(0x1015_f3ab, 2); test(al, al);                           /* test al, al */
            ii(0x1015_f3ad, 2); if(jzd(0x1015_f3b4, 0x5)) goto l_0x1015_f3b4; /* jz 0x1015f3b4 */
            ii(0x1015_f3af, 5); calld(0x100f_f5c1, -0x5fdf3);           /* call 0x100ff5c1 */
        l_0x1015_f3b4:
            ii(0x1015_f3b4, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f3b7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f3ba, 3); mov(al, memb_a32[ds, eax + 0x26]);      /* mov al, [eax+0x26] */
            ii(0x1015_f3bd, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_f3c2, 3); imul(ebx, eax, 0xa);                    /* imul ebx, eax, 0xa */
            ii(0x1015_f3c5, 5); mov(eax, 0x101c_9480);                  /* mov eax, 0x101c9480 */
            ii(0x1015_f3ca, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1015_f3cc, 5); calld(0x1008_aab4, -0xd491d);           /* call 0x1008aab4 */
            ii(0x1015_f3d1, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_f3d4, 5); calld(0x1007_6574, -0xe8e65);           /* call 0x10076574 */
            ii(0x1015_f3d9, 5); calld(0x1014_b6bd, -0x13d21);           /* call 0x1014b6bd */
            ii(0x1015_f3de, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f3e0, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_f3e3, 5); calld(0x1007_6574, -0xe8e74);           /* call 0x10076574 */
            ii(0x1015_f3e8, 5); calld(0x1008_a998, -0xd4a55);           /* call 0x1008a998 */
            ii(0x1015_f3ed, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f3ef, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_f3f2, 5); calld(0x1007_6574, -0xe8e83);           /* call 0x10076574 */
            ii(0x1015_f3f7, 3); add(eax, 0x65);                         /* add eax, 0x65 */
            ii(0x1015_f3fa, 5); calld(0x1007_6a34, -0xe89cb);           /* call 0x10076a34 */
            ii(0x1015_f3ff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f402, 5); calld(0x1015_287d, -0xcb8a);            /* call 0x1015287d */
            ii(0x1015_f407, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f40a, 5); calld(0x1014_a86a, -0x14ba5);           /* call 0x1014a86a */
            ii(0x1015_f40f, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f412, 5); mov(eax, 0x101c_39b8);                  /* mov eax, 0x101c39b8 */
            ii(0x1015_f417, 5); calld(0x1010_3752, -0x5bcca);           /* call 0x10103752 */
            ii(0x1015_f41c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f41f, 5); calld(0x1015_24a1, -0xcf83);            /* call 0x101524a1 */
            ii(0x1015_f424, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f427, 5); calld(0x1014_9fa8, -0x15484);           /* call 0x10149fa8 */
            ii(0x1015_f42c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f42f, 5); calld(0x1016_1621, 0x21ed);             /* call 0x10161621 */
            ii(0x1015_f434, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f437, 5); calld(0x1007_6154, -0xe92e8);           /* call 0x10076154 */
            ii(0x1015_f43c, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1015_f441, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1015_f446, 2); if(jnzd(0x1015_f451, 0x9)) goto l_0x1015_f451; /* jnz 0x1015f451 */
            ii(0x1015_f448, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f44b, 4); test(memb_a32[ds, eax + 0x12], 0x22);   /* test byte [eax+0x12], 0x22 */
            ii(0x1015_f44f, 2); if(jzd(0x1015_f45b, 0xa)) goto l_0x1015_f45b; /* jz 0x1015f45b */
        l_0x1015_f451:
            ii(0x1015_f451, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f453, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f456, 5); calld(0x1007_1838, -0xedc23);           /* call 0x10071838 */
        l_0x1015_f45b:
            ii(0x1015_f45b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f45e, 5); mov(eax, 0x101c_39c0);                  /* mov eax, 0x101c39c0 */
            ii(0x1015_f463, 5); calld(0x1010_3f75, -0x5b4f3);           /* call 0x10103f75 */
            ii(0x1015_f468, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f46b, 5); calld(0x1007_6154, -0xe931c);           /* call 0x10076154 */
            ii(0x1015_f470, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1015_f475, 5); cmp(eax, 0xffff);                       /* cmp eax, 0xffff */
            ii(0x1015_f47a, 2); if(jzd(0x1015_f485, 0x9)) goto l_0x1015_f485; /* jz 0x1015f485 */
            ii(0x1015_f47c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f47f, 4); test(memb_a32[ds, eax + 0x12], 0x22);   /* test byte [eax+0x12], 0x22 */
            ii(0x1015_f483, 2); if(jzd(0x1015_f487, 0x2)) goto l_0x1015_f487; /* jz 0x1015f487 */
        l_0x1015_f485:
            ii(0x1015_f485, 2); jmpd(0x1015_f48f, 0x8); goto l_0x1015_f48f; /* jmp 0x1015f48f */
        l_0x1015_f487:
            ii(0x1015_f487, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f48a, 5); calld(0x100a_8e92, -0xb65fd);           /* call 0x100a8e92 */
        l_0x1015_f48f:
            ii(0x1015_f48f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f491, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_f494, 5); calld(0x1007_5f2c, -0xe956d);           /* call 0x10075f2c */
            ii(0x1015_f499, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_f49b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_f49c, 1); popd(edi);                              /* pop edi */
            ii(0x1015_f49d, 1); popd(esi);                              /* pop esi */
            ii(0x1015_f49e, 1); popd(edx);                              /* pop edx */
            ii(0x1015_f49f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_f4a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_f4a1, 1); retd(); return;                         /* ret */
        }
    }
}
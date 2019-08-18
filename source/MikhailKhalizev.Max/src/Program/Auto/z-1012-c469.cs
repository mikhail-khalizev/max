using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_c469-5cb7bd6a")]
        public void Method_1012_c469()
        {
            ii(0x1012_c469, 5); pushd(0x78);                            /* push 0x78 */
            ii(0x1012_c46e, 5); calld(Definitions.sys_check_available_stack_size, 0x3_98df); /* call 0x10165d52 */
            ii(0x1012_c473, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_c474, 1); pushd(esi);                             /* push esi */
            ii(0x1012_c475, 1); pushd(edi);                             /* push edi */
            ii(0x1012_c476, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_c477, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_c479, 6); sub(esp, 0x4c);                         /* sub esp, 0x4c */
            ii(0x1012_c47f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_c482, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1012_c485, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1012_c488, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c48a, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_c48f, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_c492, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c495, 5); calld(0x1007_6074, -0xb_6426);          /* call 0x10076074 */
            ii(0x1012_c49a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1012_c49f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c4a1, 6); if(jzd(0x1012_c8c9, 0x422)) goto l_0x1012_c8c9; /* jz 0x1012c8c9 */
            ii(0x1012_c4a7, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c4aa, 5); calld(0x1007_623c, -0xb_6273);          /* call 0x1007623c */
            ii(0x1012_c4af, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_c4b1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c4b4, 5); calld(0x1007_6800, -0xb_5cb9);          /* call 0x10076800 */
            ii(0x1012_c4b9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c4be, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c4bf, 5); mov(eax, 0x4);                          /* mov eax, 0x4 */
            ii(0x1012_c4c4, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c4c5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c4c8, 5); calld(0x1007_6730, -0xb_5d9d);          /* call 0x10076730 */
            ii(0x1012_c4cd, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1012_c4d0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c4d3, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c4d4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c4d7, 3); mov(al, memb_a32[ds, eax + 0x4d]);      /* mov al, [eax+0x4d] */
            ii(0x1012_c4da, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_c4dc, 1); cwde();                                 /* cwde */
            ii(0x1012_c4dd, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c4de, 5); mov(eax, 0x277);                        /* mov eax, 0x277 */
            ii(0x1012_c4e3, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c4e4, 5); mov(eax, 0x276);                        /* mov eax, 0x276 */
            ii(0x1012_c4e9, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c4ea, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1012_c4ec, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c4ef, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c4f2, 5); mov(eax, StringDefinitions.Hits3);      /* mov eax, 0x101a8726 */
            ii(0x1012_c4f7, 5); calld(0x1012_bd39, -0x7c3);             /* call 0x1012bd39 */
            ii(0x1012_c4fc, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c4ff, 5); calld(0x1007_6730, -0xb_5dd4);          /* call 0x10076730 */
            ii(0x1012_c504, 5); cmp(memw_a32[ds, eax + 0xe], 0);        /* cmp word [eax+0xe], 0x0 */
            ii(0x1012_c509, 2); if(jzd(0x1012_c581, 0x76)) goto l_0x1012_c581; /* jz 0x1012c581 */
            ii(0x1012_c50b, 7); mov(memd_a32[ss, ebp - 0x18], 0x1);     /* mov dword [ebp-0x18], 0x1 */
            ii(0x1012_c512, 3); pushd(memd_a32[ss, ebp - 0x18]);        /* push dword [ebp-0x18] */
            ii(0x1012_c515, 7); mov(memd_a32[ss, ebp - 0x1c], 0x1);     /* mov dword [ebp-0x1c], 0x1 */
            ii(0x1012_c51c, 3); pushd(memd_a32[ss, ebp - 0x1c]);        /* push dword [ebp-0x1c] */
            ii(0x1012_c51f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c522, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c524, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_c527, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c529, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_c52e, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_c530, 2); if(jnzd(0x1012_c545, 0x13)) goto l_0x1012_c545; /* jnz 0x1012c545 */
            ii(0x1012_c532, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c535, 5); calld(0x1007_6730, -0xb_5e0a);          /* call 0x10076730 */
            ii(0x1012_c53a, 3); mov(eax, memd_a32[ds, eax + 0x19]);     /* mov eax, [eax+0x19] */
            ii(0x1012_c53d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c540, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1012_c543, 2); jmpd(0x1012_c54c, 0x7); goto l_0x1012_c54c; /* jmp 0x1012c54c */
        l_0x1012_c545:
            ii(0x1012_c545, 7); mov(memd_a32[ss, ebp - 0x20], 0);       /* mov dword [ebp-0x20], 0x0 */
        l_0x1012_c54c:
            ii(0x1012_c54c, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1012_c54f, 1); cwde();                                 /* cwde */
            ii(0x1012_c550, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c551, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c554, 3); mov(al, memb_a32[ds, eax + 0x54]);      /* mov al, [eax+0x54] */
            ii(0x1012_c557, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_c559, 1); cwde();                                 /* cwde */
            ii(0x1012_c55a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c55b, 5); mov(eax, 0x27d);                        /* mov eax, 0x27d */
            ii(0x1012_c560, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c561, 5); mov(eax, 0x27c);                        /* mov eax, 0x27c */
            ii(0x1012_c566, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c567, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_c56c, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c56f, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c572, 5); mov(eax, StringDefinitions.Ammo3);      /* mov eax, 0x101a872b */
            ii(0x1012_c577, 5); calld(0x1012_bd39, -0x843);             /* call 0x1012bd39 */
            ii(0x1012_c57c, 5); jmpd(0x1012_c655, 0xd4); goto l_0x1012_c655; /* jmp 0x1012c655 */
        l_0x1012_c581:
            ii(0x1012_c581, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c584, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c587, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c58a, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_c58d, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1012_c593, 3); mov(memb_a32[ss, ebp - 0x24], al);      /* mov [ebp-0x24], al */
            ii(0x1012_c596, 7); mov(memd_a32[ss, ebp - 0x10], 0x3);     /* mov dword [ebp-0x10], 0x3 */
            ii(0x1012_c59d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c5a0, 5); calld(0x1007_6730, -0xb_5e75);          /* call 0x10076730 */
            ii(0x1012_c5a5, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1012_c5a8, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c5ab, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1012_c5ae, 2); if(jgd(0x1012_c5b9, 0x9)) goto l_0x1012_c5b9; /* jg 0x1012c5b9 */
            ii(0x1012_c5b0, 7); mov(memd_a32[ss, ebp - 0x10], 0x1);     /* mov dword [ebp-0x10], 0x1 */
            ii(0x1012_c5b7, 2); jmpd(0x1012_c5d3, 0x1a); goto l_0x1012_c5d3; /* jmp 0x1012c5d3 */
        l_0x1012_c5b9:
            ii(0x1012_c5b9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c5bc, 5); calld(0x1007_6730, -0xb_5e91);          /* call 0x10076730 */
            ii(0x1012_c5c1, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1012_c5c4, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c5c7, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1012_c5ca, 2); if(jgd(0x1012_c5d3, 0x7)) goto l_0x1012_c5d3; /* jg 0x1012c5d3 */
            ii(0x1012_c5cc, 7); mov(memd_a32[ss, ebp - 0x10], 0x2);     /* mov dword [ebp-0x10], 0x2 */
        l_0x1012_c5d3:
            ii(0x1012_c5d3, 4); cmp(memb_a32[ss, ebp - 0x24], 0x4);     /* cmp byte [ebp-0x24], 0x4 */
            ii(0x1012_c5d7, 2); if(jged(0x1012_c5e0, 0x7)) goto l_0x1012_c5e0; /* jge 0x1012c5e0 */
            ii(0x1012_c5d9, 7); mov(memd_a32[ss, ebp - 0x10], 0xa);     /* mov dword [ebp-0x10], 0xa */
        l_0x1012_c5e0:
            ii(0x1012_c5e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c5e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c5e5, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_c5e8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c5ea, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_c5ef, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_c5f1, 2); if(jzd(0x1012_c5fa, 0x7)) goto l_0x1012_c5fa; /* jz 0x1012c5fa */
            ii(0x1012_c5f3, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1012_c5fa:
            ii(0x1012_c5fa, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c5ff, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c600, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c604, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c605, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c608, 5); calld(0x1007_6730, -0xb_5edd);          /* call 0x10076730 */
            ii(0x1012_c60d, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1012_c610, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c613, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c614, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c617, 3); mov(eax, memd_a32[ds, eax + 0x50]);     /* mov eax, [eax+0x50] */
            ii(0x1012_c61a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c61d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c61e, 4); movsx(eax, memb_a32[ss, ebp - 0x24]);   /* movsx eax, byte [ebp-0x24] */
            ii(0x1012_c622, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_c625, 6); mov(eax, memd_a32[ds, eax + 0x101b_d33c]); /* mov eax, [eax+0x101bd33c] */
            ii(0x1012_c62b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c62e, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c62f, 4); movsx(eax, memb_a32[ss, ebp - 0x24]);   /* movsx eax, byte [ebp-0x24] */
            ii(0x1012_c633, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_c636, 6); mov(eax, memd_a32[ds, eax + 0x101b_d33a]); /* mov eax, [eax+0x101bd33a] */
            ii(0x1012_c63c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c63f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c640, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1012_c645, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c648, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c64b, 5); mov(eax, StringDefinitions.Cargo4);     /* mov eax, 0x101a8730 */
            ii(0x1012_c650, 5); calld(0x1012_bd39, -0x91c);             /* call 0x1012bd39 */
        l_0x1012_c655:
            ii(0x1012_c655, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c65a, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c65b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c660, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c661, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c664, 5); calld(0x1007_6730, -0xb_5f39);          /* call 0x10076730 */
            ii(0x1012_c669, 3); mov(eax, memd_a32[ds, eax + 0xe]);      /* mov eax, [eax+0xe] */
            ii(0x1012_c66c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c66f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c670, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_c673, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c675, 3); mov(al, memb_a32[ds, edx + 0x4e]);      /* mov al, [edx+0x4e] */
            ii(0x1012_c678, 1); cwde();                                 /* cwde */
            ii(0x1012_c679, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c67a, 5); mov(eax, 0x28d);                        /* mov eax, 0x28d */
            ii(0x1012_c67f, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c680, 5); mov(eax, 0x28c);                        /* mov eax, 0x28c */
            ii(0x1012_c685, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c686, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1012_c68b, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c68e, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c691, 5); mov(eax, StringDefinitions.Speed3);     /* mov eax, 0x101a8736 */
            ii(0x1012_c696, 5); calld(0x1012_bd39, -0x962);             /* call 0x1012bd39 */
            ii(0x1012_c69b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c69d, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c69e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1012_c6a3, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c6a4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c6a7, 5); calld(0x1007_6730, -0xb_5f7c);          /* call 0x10076730 */
            ii(0x1012_c6ac, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x1012_c6af, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c6b2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c6b3, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x1012_c6b6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c6b8, 3); mov(al, memb_a32[ds, edx + 0x50]);      /* mov al, [edx+0x50] */
            ii(0x1012_c6bb, 1); cwde();                                 /* cwde */
            ii(0x1012_c6bc, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c6bd, 5); mov(eax, 0x28f);                        /* mov eax, 0x28f */
            ii(0x1012_c6c2, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c6c3, 5); mov(eax, 0x28e);                        /* mov eax, 0x28e */
            ii(0x1012_c6c8, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c6c9, 5); mov(ecx, 0x3);                          /* mov ecx, 0x3 */
            ii(0x1012_c6ce, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c6d1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c6d4, 5); mov(eax, StringDefinitions.Shots3);     /* mov eax, 0x101a873c */
            ii(0x1012_c6d9, 5); calld(0x1012_bd39, -0x9a5);             /* call 0x1012bd39 */
            ii(0x1012_c6de, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c6e1, 5); calld(0x1007_6730, -0xb_5fb6);          /* call 0x10076730 */
            ii(0x1012_c6e6, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1012_c6e9, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c6ec, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c6ee, 2); if(jnzd(0x1012_c6fe, 0xe)) goto l_0x1012_c6fe; /* jnz 0x1012c6fe */
            ii(0x1012_c6f0, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c6f3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c6f6, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c6f9, 5); calld(0x1012_bdf9, -0x905);             /* call 0x1012bdf9 */
        l_0x1012_c6fe:
            ii(0x1012_c6fe, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c701, 5); cmp(memw_a32[ds, eax + 0x8], 0x1e);     /* cmp word [eax+0x8], 0x1e */
            ii(0x1012_c706, 2); if(jnzd(0x1012_c71b, 0x13)) goto l_0x1012_c71b; /* jnz 0x1012c71b */
            ii(0x1012_c708, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c70b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c70d, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_c710, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c712, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_c717, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_c719, 2); if(jzd(0x1012_c71d, 0x2)) goto l_0x1012_c71d; /* jz 0x1012c71d */
        l_0x1012_c71b:
            ii(0x1012_c71b, 2); jmpd(0x1012_c72d, 0x10); goto l_0x1012_c72d; /* jmp 0x1012c72d */
        l_0x1012_c71d:
            ii(0x1012_c71d, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c720, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c723, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c726, 5); calld(0x1012_c302, -0x429);             /* call 0x1012c302 */
            ii(0x1012_c72b, 2); jmpd(0x1012_c73b, 0xe); goto l_0x1012_c73b; /* jmp 0x1012c73b */
        l_0x1012_c72d:
            ii(0x1012_c72d, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c730, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c733, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c736, 5); calld(0x1012_c088, -0x6b3);             /* call 0x1012c088 */
        l_0x1012_c73b:
            ii(0x1012_c73b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c73e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c740, 3); mov(dl, memb_a32[ds, eax + 0x26]);      /* mov dl, [eax+0x26] */
            ii(0x1012_c743, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c745, 5); mov(al, memb_a32[ds, 0x101c_37da]);     /* mov al, [0x101c37da] */
            ii(0x1012_c74a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1012_c74c, 2); if(jnzd(0x1012_c760, 0x12)) goto l_0x1012_c760; /* jnz 0x1012c760 */
            ii(0x1012_c74e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c751, 5); calld(0x1007_6730, -0xb_6026);          /* call 0x10076730 */
            ii(0x1012_c756, 3); mov(eax, memd_a32[ds, eax + 0x17]);     /* mov eax, [eax+0x17] */
            ii(0x1012_c759, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c75c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1012_c75e, 2); if(jgd(0x1012_c762, 0x2)) goto l_0x1012_c762; /* jg 0x1012c762 */
        l_0x1012_c760:
            ii(0x1012_c760, 2); jmpd(0x1012_c76b, 0x9); goto l_0x1012_c76b; /* jmp 0x1012c76b */
        l_0x1012_c762:
            ii(0x1012_c762, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c765, 4); test(memb_a32[ds, eax + 0x13], 0x2);    /* test byte [eax+0x13], 0x2 */
            ii(0x1012_c769, 2); if(jnzd(0x1012_c76d, 0x2)) goto l_0x1012_c76d; /* jnz 0x1012c76d */
        l_0x1012_c76b:
            ii(0x1012_c76b, 2); jmpd(0x1012_c782, 0x15); goto l_0x1012_c782; /* jmp 0x1012c782 */
        l_0x1012_c76d:
            ii(0x1012_c76d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c770, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c773, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c776, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_c779, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x1); /* cmp byte [eax+0x101c81d5], 0x1 */
            ii(0x1012_c780, 2); if(jged(0x1012_c784, 0x2)) goto l_0x1012_c784; /* jge 0x1012c784 */
        l_0x1012_c782:
            ii(0x1012_c782, 2); jmpd(0x1012_c799, 0x15); goto l_0x1012_c799; /* jmp 0x1012c799 */
        l_0x1012_c784:
            ii(0x1012_c784, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c787, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c78a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c78d, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_c790, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x4); /* cmp byte [eax+0x101c81d5], 0x4 */
            ii(0x1012_c797, 2); if(jld(0x1012_c79e, 0x5)) goto l_0x1012_c79e; /* jl 0x1012c79e */
        l_0x1012_c799:
            ii(0x1012_c799, 5); jmpd(0x1012_c8bf, 0x121); goto l_0x1012_c8bf; /* jmp 0x1012c8bf */
        l_0x1012_c79e:
            ii(0x1012_c79e, 3); lea(eax, ebp - 0x34);                   /* lea eax, [ebp-0x34] */
            ii(0x1012_c7a1, 5); calld(0x1007_20b1, -0xb_a6f5);          /* call 0x100720b1 */
            ii(0x1012_c7a6, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x1012_c7a9, 5); calld(0x1007_20b1, -0xb_a6fd);          /* call 0x100720b1 */
            ii(0x1012_c7ae, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x1012_c7b1, 3); lea(edx, ebp - 0x34);                   /* lea edx, [ebp-0x34] */
            ii(0x1012_c7b4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c7b7, 5); calld(0x1007_6204, -0xb_65b8);          /* call 0x10076204 */
            ii(0x1012_c7bc, 5); calld(0x1014_3616, 0x1_6e55);           /* call 0x10143616 */
            ii(0x1012_c7c1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c7c4, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c7c7, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c7ca, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_c7cd, 6); mov(al, memb_a32[ds, eax + 0x101c_81d5]); /* mov al, [eax+0x101c81d5] */
            ii(0x1012_c7d3, 3); mov(memb_a32[ss, ebp - 0x28], al);      /* mov [ebp-0x28], al */
            ii(0x1012_c7d6, 2); jmpd(0x1012_c804, 0x2c); goto l_0x1012_c804; /* jmp 0x1012c804 */
        l_0x1012_c7d8:
            ii(0x1012_c7d8, 3); mov(eax, memd_a32[ss, ebp - 0x32]);     /* mov eax, [ebp-0x32] */
            ii(0x1012_c7db, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1012_c7de, 3); mov(eax, memd_a32[ss, ebp - 0x3e]);     /* mov eax, [ebp-0x3e] */
            ii(0x1012_c7e1, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_c7e4, 2); jmpd(0x1012_c826, 0x40); goto l_0x1012_c826; /* jmp 0x1012c826 */
        l_0x1012_c7e6:
            ii(0x1012_c7e6, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x1012_c7e9, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1012_c7ec, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x1012_c7ef, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_c7f2, 2); jmpd(0x1012_c826, 0x32); goto l_0x1012_c826; /* jmp 0x1012c826 */
        l_0x1012_c7f4:
            ii(0x1012_c7f4, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x1012_c7f7, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x1012_c7fa, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x1012_c7fd, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_c800, 2); jmpd(0x1012_c826, 0x24); goto l_0x1012_c826; /* jmp 0x1012c826 */
        l_0x1012_c802:
            ii(0x1012_c802, 2); jmpd(0x1012_c826, 0x22); goto l_0x1012_c826; /* jmp 0x1012c826 */
        l_0x1012_c804:
            ii(0x1012_c804, 3); mov(al, memb_a32[ss, ebp - 0x28]);      /* mov al, [ebp-0x28] */
            ii(0x1012_c807, 3); mov(memb_a32[ss, ebp - 0x4c], al);      /* mov [ebp-0x4c], al */
            ii(0x1012_c80a, 4); cmp(memb_a32[ss, ebp - 0x4c], 0x2);     /* cmp byte [ebp-0x4c], 0x2 */
            ii(0x1012_c80e, 2); if(jbd(0x1012_c81e, 0xe)) goto l_0x1012_c81e; /* jb 0x1012c81e */
            ii(0x1012_c810, 4); cmp(memb_a32[ss, ebp - 0x4c], 0x2);     /* cmp byte [ebp-0x4c], 0x2 */
            ii(0x1012_c814, 2); if(jbed(0x1012_c7e6, -0x30)) goto l_0x1012_c7e6; /* jbe 0x1012c7e6 */
            ii(0x1012_c816, 4); cmp(memb_a32[ss, ebp - 0x4c], 0x3);     /* cmp byte [ebp-0x4c], 0x3 */
            ii(0x1012_c81a, 2); if(jzd(0x1012_c7f4, -0x28)) goto l_0x1012_c7f4; /* jz 0x1012c7f4 */
            ii(0x1012_c81c, 2); jmpd(0x1012_c802, -0x1c); goto l_0x1012_c802; /* jmp 0x1012c802 */
        l_0x1012_c81e:
            ii(0x1012_c81e, 4); cmp(memb_a32[ss, ebp - 0x4c], 0x1);     /* cmp byte [ebp-0x4c], 0x1 */
            ii(0x1012_c822, 2); if(jzd(0x1012_c7d8, -0x4c)) goto l_0x1012_c7d8; /* jz 0x1012c7d8 */
            ii(0x1012_c824, 2); jmpd(0x1012_c802, -0x24); goto l_0x1012_c802; /* jmp 0x1012c802 */
        l_0x1012_c826:
            ii(0x1012_c826, 7); mov(memd_a32[ss, ebp - 0x10], 0xa);     /* mov dword [ebp-0x10], 0xa */
            ii(0x1012_c82d, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1012_c831, 4); movsx(ebx, memw_a32[ss, ebp - 0x10]);   /* movsx ebx, word [ebp-0x10] */
            ii(0x1012_c835, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_c837, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_c83a, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_c83c, 3); cmp(eax, 0x19);                         /* cmp eax, 0x19 */
            ii(0x1012_c83f, 2); if(jled(0x1012_c854, 0x13)) goto l_0x1012_c854; /* jle 0x1012c854 */
            ii(0x1012_c841, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1012_c845, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1012_c84a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1012_c84c, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1012_c84f, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1012_c851, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1012_c854:
            ii(0x1012_c854, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_c856, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c857, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_c85b, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c85c, 4); movsx(eax, memw_a32[ss, ebp - 0x48]);   /* movsx eax, word [ebp-0x48] */
            ii(0x1012_c860, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c861, 4); movsx(eax, memw_a32[ss, ebp - 0x44]);   /* movsx eax, word [ebp-0x44] */
            ii(0x1012_c865, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c866, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c869, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c86c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c86f, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_c872, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d2]); /* mov eax, [eax+0x101c81d2] */
            ii(0x1012_c878, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_c87b, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_c87e, 6); mov(eax, memd_a32[ds, eax + 0x101b_d33c]); /* mov eax, [eax+0x101bd33c] */
            ii(0x1012_c884, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c887, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c888, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_c88b, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_c88e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c891, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1012_c894, 6); mov(eax, memd_a32[ds, eax + 0x101c_81d2]); /* mov eax, [eax+0x101c81d2] */
            ii(0x1012_c89a, 3); sar(eax, 0x18);                         /* sar eax, 0x18 */
            ii(0x1012_c89d, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1012_c8a0, 6); mov(eax, memd_a32[ds, eax + 0x101b_d33a]); /* mov eax, [eax+0x101bd33a] */
            ii(0x1012_c8a6, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_c8a9, 1); pushd(eax);                             /* push eax */
            ii(0x1012_c8aa, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x1012_c8af, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_c8b2, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_c8b5, 5); mov(eax, StringDefinitions.Total9);     /* mov eax, 0x101a8742 */
            ii(0x1012_c8ba, 5); calld(0x1012_bd39, -0xb86);             /* call 0x1012bd39 */
        l_0x1012_c8bf:
            ii(0x1012_c8bf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_c8c1, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x1012_c8c4, 5); calld(0x1007_5eec, -0xb_69dd);          /* call 0x10075eec */
        l_0x1012_c8c9:
            ii(0x1012_c8c9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_c8cb, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_c8cc, 1); popd(edi);                              /* pop edi */
            ii(0x1012_c8cd, 1); popd(esi);                              /* pop esi */
            ii(0x1012_c8ce, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_c8cf, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_d2cc-2b43935e")]
        public void Method_100a_d2cc()
        {
            ii(0x100a_d2cc, 5); pushd(0x74);                            /* push 0x74 */
            ii(0x100a_d2d1, 5); calld(Definitions.sys_check_available_stack_size, 0xb_8a7c); /* call 0x10165d52 */
            ii(0x100a_d2d6, 1); pushd(esi);                             /* push esi */
            ii(0x100a_d2d7, 1); pushd(edi);                             /* push edi */
            ii(0x100a_d2d8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_d2d9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_d2db, 6); sub(esp, 0x60);                         /* sub esp, 0x60 */
            ii(0x100a_d2e1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_d2e4, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100a_d2e7, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100a_d2ea, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100a_d2ed, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100a_d2f0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d2f3, 5); calld(0x1008_a5f0, -0x2_2d08);          /* call 0x1008a5f0 */
            ii(0x100a_d2f8, 4); cmp(memd_a32[ss, ebp - 0x4], 0);        /* cmp dword [ebp-0x4], 0x0 */
            ii(0x100a_d2fc, 6); if(jnzd(0x100a_d447, 0x145)) goto l_0x100a_d447; /* jnz 0x100ad447 */
            ii(0x100a_d302, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d305, 5); calld(0x1008_a520, -0x2_2dea);          /* call 0x1008a520 */
            ii(0x100a_d30a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d30c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d30f, 5); calld(0x100b_80c4, 0xadb0);             /* call 0x100b80c4 */
            ii(0x100a_d314, 3); cmp(al, memb_a32[ds, edx + 0x19]);      /* cmp al, [edx+0x19] */
            ii(0x100a_d317, 2); if(jnzd(0x100a_d33a, 0x21)) goto l_0x100a_d33a; /* jnz 0x100ad33a */
            ii(0x100a_d319, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d31c, 5); calld(0x1008_a520, -0x2_2e01);          /* call 0x1008a520 */
            ii(0x100a_d321, 5); cmp(memw_a32[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_d326, 2); if(jnzd(0x100a_d335, 0xd)) goto l_0x100a_d335; /* jnz 0x100ad335 */
            ii(0x100a_d328, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d32b, 5); calld(0x1008_a520, -0x2_2e10);          /* call 0x1008a520 */
            ii(0x100a_d330, 5); calld(0x100a_d6e4, 0x3af);              /* call 0x100ad6e4 */
        l_0x100a_d335:
            ii(0x100a_d335, 5); jmpd(0x100a_d442, 0x108); goto l_0x100a_d442; /* jmp 0x100ad442 */
        l_0x100a_d33a:
            ii(0x100a_d33a, 4); or(memb_a32[ss, ebp - 0x18], 0x1);      /* or byte [ebp-0x18], 0x1 */
            ii(0x100a_d33e, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d341, 5); calld(Definitions.my_ctor_0x101b_3b58, -0x2_22a2); /* call 0x1008b0a4 */
            ii(0x100a_d346, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100a_d349, 4); and(memb_a32[ss, ebp - 0x18], -0x2 /* 0xfe */); /* and byte [ebp-0x18], 0xfe */
            ii(0x100a_d34d, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100a_d352, 5); calld(Definitions.sys_new, 0xb_8aa9);   /* call 0x10165e00 */
            ii(0x100a_d357, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100a_d35a, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100a_d35d, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100a_d360, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100a_d364, 2); if(jzd(0x100a_d397, 0x31)) goto l_0x100a_d397; /* jz 0x100ad397 */
            ii(0x100a_d366, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100a_d369, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d36c, 5); calld(0x100b_808c, 0xad1b);             /* call 0x100b808c */
            ii(0x100a_d371, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100a_d373, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100a_d378, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d37b, 5); calld(Definitions.my__get_unit, 0xac9c); /* call 0x100b801c */
            ii(0x100a_d380, 3); mov(esi, memd_a32[ss, ebp - 0x24]);     /* mov esi, [ebp-0x24] */
            ii(0x100a_d383, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d385, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100a_d387, 5); calld(0x100a_beeb, -0x14a1);            /* call 0x100abeeb */
            ii(0x100a_d38c, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100a_d38f, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100a_d392, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100a_d395, 2); jmpd(0x100a_d39d, 0x6); goto l_0x100a_d39d; /* jmp 0x100ad39d */
        l_0x100a_d397:
            ii(0x100a_d397, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100a_d39a, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
        l_0x100a_d39d:
            ii(0x100a_d39d, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100a_d3a0, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100a_d3a3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d3a6, 5); calld(0x1008_a520, -0x2_2e8b);          /* call 0x1008a520 */
            ii(0x100a_d3ab, 3); mov(edx, memd_a32[ds, eax + 0x15]);     /* mov edx, [eax+0x15] */
            ii(0x100a_d3ae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_d3b1, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100a_d3b4, 5); calld(0x1011_d85d, 0x7_04a4);           /* call 0x1011d85d */
            ii(0x100a_d3b9, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d3bc, 5); calld(0x1008_a520, -0x2_2ea1);          /* call 0x1008a520 */
            ii(0x100a_d3c1, 3); mov(edx, memd_a32[ds, eax + 0x16]);     /* mov edx, [eax+0x16] */
            ii(0x100a_d3c4, 3); sar(edx, 0x18);                         /* sar edx, 0x18 */
            ii(0x100a_d3c7, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100a_d3ca, 5); calld(0x1011_d801, 0x7_0432);           /* call 0x1011d801 */
            ii(0x100a_d3cf, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100a_d3d4, 5); calld(Definitions.sys_new, 0xb_8a27);   /* call 0x10165e00 */
            ii(0x100a_d3d9, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100a_d3dc, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100a_d3df, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100a_d3e2, 4); cmp(memd_a32[ss, ebp - 0x40], 0);       /* cmp dword [ebp-0x40], 0x0 */
            ii(0x100a_d3e6, 2); if(jzd(0x100a_d413, 0x2b)) goto l_0x100a_d413; /* jz 0x100ad413 */
            ii(0x100a_d3e8, 5); mov(eax, 0x100a_d995);                  /* mov eax, 0x100ad995 */
            ii(0x100a_d3ed, 1); pushd(eax);                             /* push eax */
            ii(0x100a_d3ee, 5); mov(ecx, 0x100a_d2cc);                  /* mov ecx, 0x100ad2cc */
            ii(0x100a_d3f3, 3); mov(ebx, memd_a32[ss, ebp - 0x38]);     /* mov ebx, [ebp-0x38] */
            ii(0x100a_d3f6, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d3f9, 5); calld(0x1008_a57c, -0x2_2e82);          /* call 0x1008a57c */
            ii(0x100a_d3fe, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d400, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100a_d403, 5); calld(0x100a_ba72, -0x1996);            /* call 0x100aba72 */
            ii(0x100a_d408, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100a_d40b, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100a_d40e, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100a_d411, 2); jmpd(0x100a_d419, 0x6); goto l_0x100a_d419; /* jmp 0x100ad419 */
        l_0x100a_d413:
            ii(0x100a_d413, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100a_d416, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
        l_0x100a_d419:
            ii(0x100a_d419, 3); mov(edx, memd_a32[ss, ebp - 0x48]);     /* mov edx, [ebp-0x48] */
            ii(0x100a_d41c, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d41f, 5); calld(0x1008_afe4, -0x2_2440);          /* call 0x1008afe4 */
            ii(0x100a_d424, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d427, 5); calld(0x1008_af84, -0x2_24a8);          /* call 0x1008af84 */
            ii(0x100a_d42c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d42e, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_d433, 5); calld(0x100a_4d50, -0x86e8);            /* call 0x100a4d50 */
            ii(0x100a_d438, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d43a, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_d43d, 5); calld(0x1008_8b7c, -0x2_48c6);          /* call 0x10088b7c */
        l_0x100a_d442:
            ii(0x100a_d442, 5); jmpd(0x100a_d620, 0x1d9); goto l_0x100a_d620; /* jmp 0x100ad620 */
        l_0x100a_d447:
            ii(0x100a_d447, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d44a, 5); calld(0x1008_a520, -0x2_2f2f);          /* call 0x1008a520 */
            ii(0x100a_d44f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d451, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x100a_d454, 3); mov(memb_a32[ds, edx + 0x47], al);      /* mov [edx+0x47], al */
            ii(0x100a_d457, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d45a, 5); calld(0x100b_8054, 0xabf5);             /* call 0x100b8054 */
            ii(0x100a_d45f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100a_d461, 2); if(jnzd(0x100a_d473, 0x10)) goto l_0x100a_d473; /* jnz 0x100ad473 */
            ii(0x100a_d463, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d466, 5); calld(0x1008_a520, -0x2_2f4b);          /* call 0x1008a520 */
            ii(0x100a_d46b, 6); mov(memw_a32[ds, eax + 0x26], 0xffff);  /* mov word [eax+0x26], 0xffff */
            ii(0x100a_d471, 2); jmpd(0x100a_d48d, 0x1a); goto l_0x100a_d48d; /* jmp 0x100ad48d */
        l_0x100a_d473:
            ii(0x100a_d473, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d476, 5); calld(0x100b_8054, 0xabd9);             /* call 0x100b8054 */
            ii(0x100a_d47b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d47d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d480, 5); calld(0x1008_a520, -0x2_2f65);          /* call 0x1008a520 */
            ii(0x100a_d485, 4); mov(dx, memw_a32[ds, edx + 0x8]);       /* mov dx, [edx+0x8] */
            ii(0x100a_d489, 4); mov(memw_a32[ds, eax + 0x26], dx);      /* mov [eax+0x26], dx */
        l_0x100a_d48d:
            ii(0x100a_d48d, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d490, 5); calld(0x1008_a520, -0x2_2f75);          /* call 0x1008a520 */
            ii(0x100a_d495, 3); lea(edx, eax + 0x22);                   /* lea edx, [eax+0x22] */
            ii(0x100a_d498, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d49b, 5); calld(0x1008_a520, -0x2_2f80);          /* call 0x1008a520 */
            ii(0x100a_d4a0, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100a_d4a3, 5); calld(0x1008_8b44, -0x2_4964);          /* call 0x10088b44 */
            ii(0x100a_d4a8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d4ab, 5); calld(0x1008_a520, -0x2_2f90);          /* call 0x1008a520 */
            ii(0x100a_d4b0, 3); lea(edx, eax + 0x22);                   /* lea edx, [eax+0x22] */
            ii(0x100a_d4b3, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d4b6, 5); calld(0x1008_a520, -0x2_2f9b);          /* call 0x1008a520 */
            ii(0x100a_d4bb, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_d4be, 5); calld(0x1008_8b44, -0x2_497f);          /* call 0x10088b44 */
            ii(0x100a_d4c3, 4); cmp(memb_a32[ss, ebp + 0x10], 0);       /* cmp byte [ebp+0x10], 0x0 */
            ii(0x100a_d4c7, 2); if(jnzd(0x100a_d4d5, 0xc)) goto l_0x100a_d4d5; /* jnz 0x100ad4d5 */
            ii(0x100a_d4c9, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_d4cc, 5); calld(0x100b_80c4, 0xabf3);             /* call 0x100b80c4 */
            ii(0x100a_d4d1, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x100a_d4d3, 2); if(jzd(0x100a_d4da, 0x5)) goto l_0x100a_d4da; /* jz 0x100ad4da */
        l_0x100a_d4d5:
            ii(0x100a_d4d5, 5); jmpd(0x100a_d558, 0x7e); goto l_0x100a_d558; /* jmp 0x100ad558 */
        l_0x100a_d4da:
            ii(0x100a_d4da, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d4dd, 5); calld(0x1008_a520, -0x2_2fc2);          /* call 0x1008a520 */
            ii(0x100a_d4e2, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d4e5, 5); calld(0x1007_6574, -0x3_6f76);          /* call 0x10076574 */
            ii(0x100a_d4ea, 5); calld(0x1007_623c, -0x3_72b3);          /* call 0x1007623c */
            ii(0x100a_d4ef, 3); mov(ecx, memd_a32[ds, eax + 0xe]);      /* mov ecx, [eax+0xe] */
            ii(0x100a_d4f2, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100a_d4f5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d4f8, 5); calld(0x1008_a520, -0x2_2fdd);          /* call 0x1008a520 */
            ii(0x100a_d4fd, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d500, 5); calld(0x1007_6574, -0x3_6f91);          /* call 0x10076574 */
            ii(0x100a_d505, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d507, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d50a, 5); calld(0x1008_a520, -0x2_2fef);          /* call 0x1008a520 */
            ii(0x100a_d50f, 4); mov(dx, memw_a32[ds, edx + 0x1c]);      /* mov dx, [edx+0x1c] */
            ii(0x100a_d513, 4); sub(dx, memw_a32[ds, eax + 0x24]);      /* sub dx, [eax+0x24] */
            ii(0x100a_d517, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_d519, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100a_d51c, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d51f, 5); calld(0x1008_a520, -0x2_3004);          /* call 0x1008a520 */
            ii(0x100a_d524, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d527, 5); calld(0x1007_6574, -0x3_6fb8);          /* call 0x10076574 */
            ii(0x100a_d52c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d52e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d531, 5); calld(0x1008_a520, -0x2_3016);          /* call 0x1008a520 */
            ii(0x100a_d536, 4); mov(dx, memw_a32[ds, edx + 0x1a]);      /* mov dx, [edx+0x1a] */
            ii(0x100a_d53a, 4); sub(dx, memw_a32[ds, eax + 0x22]);      /* sub dx, [eax+0x22] */
            ii(0x100a_d53e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_d540, 1); cwde();                                 /* cwde */
            ii(0x100a_d541, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x100a_d543, 5); calld(0x100a_5f65, -0x75e3);            /* call 0x100a5f65 */
            ii(0x100a_d548, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100a_d54b, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100a_d54d, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100a_d550, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100a_d552, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100a_d554, 2); cmp(eax, ecx);                          /* cmp eax, ecx */
            ii(0x100a_d556, 2); if(jgd(0x100a_d55d, 0x5)) goto l_0x100a_d55d; /* jg 0x100ad55d */
        l_0x100a_d558:
            ii(0x100a_d558, 5); jmpd(0x100a_d5d5, 0x78); goto l_0x100a_d5d5; /* jmp 0x100ad5d5 */
        l_0x100a_d55d:
            ii(0x100a_d55d, 5); mov(eax, 0x11);                         /* mov eax, 0x11 */
            ii(0x100a_d562, 5); calld(Definitions.sys_new, 0xb_8899);   /* call 0x10165e00 */
            ii(0x100a_d567, 3); mov(memd_a32[ss, ebp - 0x4c], eax);     /* mov [ebp-0x4c], eax */
            ii(0x100a_d56a, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100a_d56d, 3); mov(memd_a32[ss, ebp - 0x50], eax);     /* mov [ebp-0x50], eax */
            ii(0x100a_d570, 4); cmp(memd_a32[ss, ebp - 0x50], 0);       /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100a_d574, 2); if(jzd(0x100a_d5ac, 0x36)) goto l_0x100a_d5ac; /* jz 0x100ad5ac */
            ii(0x100a_d576, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x100a_d579, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d57c, 5); calld(0x1008_a520, -0x2_3061);          /* call 0x1008a520 */
            ii(0x100a_d581, 3); mov(ebx, memd_a32[ds, eax + 0x24]);     /* mov ebx, [eax+0x24] */
            ii(0x100a_d584, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100a_d587, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d58a, 5); calld(0x1008_a520, -0x2_306f);          /* call 0x1008a520 */
            ii(0x100a_d58f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_d592, 5); calld(0x1007_65d0, -0x3_6fc7);          /* call 0x100765d0 */
            ii(0x100a_d597, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d599, 3); mov(eax, memd_a32[ss, ebp - 0x4c]);     /* mov eax, [ebp-0x4c] */
            ii(0x100a_d59c, 5); calld(0x100b_88f0, 0xb34f);             /* call 0x100b88f0 */
            ii(0x100a_d5a1, 3); mov(memd_a32[ss, ebp - 0x54], eax);     /* mov [ebp-0x54], eax */
            ii(0x100a_d5a4, 3); mov(eax, memd_a32[ss, ebp - 0x54]);     /* mov eax, [ebp-0x54] */
            ii(0x100a_d5a7, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
            ii(0x100a_d5aa, 2); jmpd(0x100a_d5b2, 0x6); goto l_0x100a_d5b2; /* jmp 0x100ad5b2 */
        l_0x100a_d5ac:
            ii(0x100a_d5ac, 3); mov(eax, memd_a32[ss, ebp - 0x50]);     /* mov eax, [ebp-0x50] */
            ii(0x100a_d5af, 3); mov(memd_a32[ss, ebp - 0x58], eax);     /* mov [ebp-0x58], eax */
        l_0x100a_d5b2:
            ii(0x100a_d5b2, 3); mov(edx, memd_a32[ss, ebp - 0x58]);     /* mov edx, [ebp-0x58] */
            ii(0x100a_d5b5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d5b8, 5); calld(0x1008_a520, -0x2_309d);          /* call 0x1008a520 */
            ii(0x100a_d5bd, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x100a_d5c0, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_d5c3, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x100a_d5c9, 5); mov(ebx, 0x101c_31c4);                  /* mov ebx, 0x101c31c4 */
            ii(0x100a_d5ce, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100a_d5d0, 5); calld(0x100b_9c11, 0xc63c);             /* call 0x100b9c11 */
        l_0x100a_d5d5:
            ii(0x100a_d5d5, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d5d8, 5); calld(0x1008_a520, -0x2_30bd);          /* call 0x1008a520 */
            ii(0x100a_d5dd, 5); cmp(memw_a32[ds, eax + 0x26], -0x1 /* 0xff */); /* cmp word [eax+0x26], 0xffff */
            ii(0x100a_d5e2, 2); if(jzd(0x100a_d603, 0x1f)) goto l_0x100a_d603; /* jz 0x100ad603 */
            ii(0x100a_d5e4, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_d5e7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_d5ea, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100a_d5ed, 5); calld(0x1007_5e64, -0x3_778e);          /* call 0x10075e64 */
            ii(0x100a_d5f2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d5f4, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d5f7, 5); calld(0x1008_a520, -0x2_30dc);          /* call 0x1008a520 */
            ii(0x100a_d5fc, 5); calld(0x100a_daed, 0x4ec);              /* call 0x100adaed */
            ii(0x100a_d601, 2); jmpd(0x100a_d620, 0x1d); goto l_0x100a_d620; /* jmp 0x100ad620 */
        l_0x100a_d603:
            ii(0x100a_d603, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100a_d606, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100a_d609, 3); lea(eax, ebp - 0x60);                   /* lea eax, [ebp-0x60] */
            ii(0x100a_d60c, 5); calld(0x1007_5e64, -0x3_77ad);          /* call 0x10075e64 */
            ii(0x100a_d611, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_d613, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d616, 5); calld(0x1008_a520, -0x2_30fb);          /* call 0x1008a520 */
            ii(0x100a_d61b, 5); calld(0x100a_d0e3, -0x53d);             /* call 0x100ad0e3 */
        l_0x100a_d620:
            ii(0x100a_d620, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_d622, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100a_d625, 5); calld(0x1008_8d4c, -0x2_48de);          /* call 0x10088d4c */
            ii(0x100a_d62a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_d62c, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_d62d, 1); popd(edi);                              /* pop edi */
            ii(0x100a_d62e, 1); popd(esi);                              /* pop esi */
            ii(0x100a_d62f, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}

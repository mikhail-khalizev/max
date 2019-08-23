using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_0383-96a6ac6b")]
        public void Method_100b_0383()
        {
            ii(0x100b_0383, 5); push(0x78);                             /* push 0x78 */
            ii(0x100b_0388, 5); call(Definitions.sys_check_available_stack_size, 0xb_59c5); /* call 0x10165d52 */
            ii(0x100b_038d, 1); push(ebx);                              /* push ebx */
            ii(0x100b_038e, 1); push(ecx);                              /* push ecx */
            ii(0x100b_038f, 1); push(edx);                              /* push edx */
            ii(0x100b_0390, 1); push(esi);                              /* push esi */
            ii(0x100b_0391, 1); push(edi);                              /* push edi */
            ii(0x100b_0392, 1); push(ebp);                              /* push ebp */
            ii(0x100b_0393, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_0395, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x100b_039b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_039e, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100b_03a3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_03a6, 1); push(eax);                              /* push eax */
            ii(0x100b_03a7, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x100b_03ad, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100b_03b0, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_03b2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_03b4, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_03b7, 5); call(0x1008_b148, -0x2_5274);           /* call 0x1008b148 */
            ii(0x100b_03bc, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_03c0, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_03c3, 5); call(Definitions.my_ctor_0x101b_38f8, -0x3_9cd8); /* call 0x100766f0 */
            ii(0x100b_03c8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100b_03cb, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_03cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_03d2, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_03d5, 5); call(0x1007_6574, -0x3_9e66);           /* call 0x10076574 */
            ii(0x100b_03da, 5); cmp(memw[ds, eax + 0x8], 0x4e);         /* cmp word [eax+0x8], 0x4e */
            ii(0x100b_03df, 2); if(jnz(0x100b_03ea, 0x9)) goto l_0x100b_03ea; /* jnz 0x100b03ea */
            ii(0x100b_03e1, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100b_03e8, 2); jmp(0x100b_03f1, 0x7); goto l_0x100b_03f1; /* jmp 0x100b03f1 */
        l_0x100b_03ea:
            ii(0x100b_03ea, 7); mov(memd[ss, ebp - 0xc], 0x2);          /* mov dword [ebp-0xc], 0x2 */
        l_0x100b_03f1:
            ii(0x100b_03f1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_03f4, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_03f7, 5); call(0x1008_a520, -0x2_5edc);           /* call 0x1008a520 */
            ii(0x100b_03fc, 5); call(0x100b_7d68, 0x7967);              /* call 0x100b7d68 */
            ii(0x100b_0401, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_0403, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_0406, 5); call(0x1007_6630, -0x3_9ddb);           /* call 0x10076630 */
        l_0x100b_040b:
            ii(0x100b_040b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_040e, 4); mov(dx, memw[ds, eax + 0x1f]);          /* mov dx, [eax+0x1f] */
            ii(0x100b_0412, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0415, 4); dec(memw[ds, eax + 0x1f]);              /* dec word [eax+0x1f] */
            ii(0x100b_0419, 3); movsx(eax, dx);                         /* movsx eax, dx */
            ii(0x100b_041c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_041e, 2); if(jg(0x100b_047c, 0x5c)) goto l_0x100b_047c; /* jg 0x100b047c */
            ii(0x100b_0420, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0423, 5); add(memw[ds, eax + 0x1d], 0x2);         /* add word [eax+0x1d], 0x2 */
            ii(0x100b_0428, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_042b, 3); mov(eax, memd[ds, eax + 0x1b]);         /* mov eax, [eax+0x1b] */
            ii(0x100b_042e, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_0431, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100b_0434, 2); if(jl(0x100b_046e, 0x38)) goto l_0x100b_046e; /* jl 0x100b046e */
            ii(0x100b_0436, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0439, 4); cmp(memb[ds, eax + 0x25], 0);           /* cmp byte [eax+0x25], 0x0 */
            ii(0x100b_043d, 2); if(jnz(0x100b_0456, 0x17)) goto l_0x100b_0456; /* jnz 0x100b0456 */
            ii(0x100b_043f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0442, 5); call(0x100b_06da, 0x293);               /* call 0x100b06da */
            ii(0x100b_0447, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0449, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_044c, 5); call(0x1007_5f2c, -0x3_a525);           /* call 0x10075f2c */
            ii(0x100b_0451, 5); jmp(0x100b_0637, 0x1e1); goto l_0x100b_0637; /* jmp 0x100b0637 */
        l_0x100b_0456:
            ii(0x100b_0456, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0459, 5); add(memw[ds, eax + 0x1b], 0x2);         /* add word [eax+0x1b], 0x2 */
            ii(0x100b_045e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0461, 4); mov(memb[ds, eax + 0x25], 0);           /* mov byte [eax+0x25], 0x0 */
            ii(0x100b_0465, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0468, 6); mov(memw[ds, eax + 0x1d], 0);           /* mov word [eax+0x1d], 0x0 */
        l_0x100b_046e:
            ii(0x100b_046e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0471, 4); mov(dx, memw[ds, eax + 0x1b]);          /* mov dx, [eax+0x1b] */
            ii(0x100b_0475, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0478, 4); mov(memw[ds, eax + 0x1f], dx);          /* mov [eax+0x1f], dx */
        l_0x100b_047c:
            ii(0x100b_047c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_047f, 3); mov(edx, memd[ds, eax + 0x1b]);         /* mov edx, [eax+0x1b] */
            ii(0x100b_0482, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_0485, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100b_0488, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100b_048d, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100b_048f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0492, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x100b_0495, 5); call(0x1008_b1a4, -0x2_52f6);           /* call 0x1008b1a4 */
            ii(0x100b_049a, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_049d, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x100b_04a0, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100b_04a3, 5); call(0x1010_82ce, 0x5_7e26);            /* call 0x101082ce */
            ii(0x100b_04a8, 2); test(al, al);                           /* test al, al */
            ii(0x100b_04aa, 6); if(jz(0x100b_0628, 0x178)) goto l_0x100b_0628; /* jz 0x100b0628 */
            ii(0x100b_04b0, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_04b3, 4); mov(memb[ds, eax + 0x25], 0x1);         /* mov byte [eax+0x25], 0x1 */
            ii(0x100b_04b7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100b_04bc, 1); push(eax);                              /* push eax */
            ii(0x100b_04bd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_04c0, 3); mov(ecx, memd[ds, eax + 0x21]);         /* mov ecx, [eax+0x21] */
            ii(0x100b_04c3, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100b_04c6, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_04c9, 3); mov(ebx, memd[ds, eax + 0x1f]);         /* mov ebx, [eax+0x1f] */
            ii(0x100b_04cc, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100b_04cf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_04d2, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x100b_04d5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100b_04d8, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_04db, 5); call(0x1007_6574, -0x3_9f6c);           /* call 0x10076574 */
            ii(0x100b_04e0, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100b_04e3, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_04e6, 5); call(0x1007_02b9, -0x4_0232);           /* call 0x100702b9 */
            ii(0x100b_04eb, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100b_04ee, 2); if(jz(0x100b_051b, 0x2b)) goto l_0x100b_051b; /* jz 0x100b051b */
            ii(0x100b_04f0, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100b_04f5, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100b_04fa, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_04fd, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x100b_0500, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100b_0503, 5); call(0x1007_5e64, -0x3_a6a4);           /* call 0x10075e64 */
            ii(0x100b_0508, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_050a, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_050d, 5); call(0x1008_abbc, -0x2_5956);           /* call 0x1008abbc */
            ii(0x100b_0512, 5); call(0x100a_90f9, -0x741e);             /* call 0x100a90f9 */
            ii(0x100b_0517, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0519, 2); if(jz(0x100b_0520, 0x5)) goto l_0x100b_0520; /* jz 0x100b0520 */
        l_0x100b_051b:
            ii(0x100b_051b, 5); jmp(0x100b_0628, 0x108); goto l_0x100b_0628; /* jmp 0x100b0628 */
        l_0x100b_0520:
            ii(0x100b_0520, 4); or(memb[ss, ebp - 0x8], 0x1);           /* or byte [ebp-0x8], 0x1 */
            ii(0x100b_0524, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_0527, 5); call(Definitions.my_ctor_0x101b_3b58, -0x2_5488); /* call 0x1008b0a4 */
            ii(0x100b_052c, 3); mov(memd[ss, ebp - 0x30], eax);         /* mov [ebp-0x30], eax */
            ii(0x100b_052f, 4); and(memb[ss, ebp - 0x8], -0x2 /* 0xfe */); /* and byte [ebp-0x8], 0xfe */
            ii(0x100b_0533, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x100b_0538, 5); call(Definitions.sys_new, 0xb_58c3);    /* call 0x10165e00 */
            ii(0x100b_053d, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100b_0540, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100b_0543, 3); mov(memd[ss, ebp - 0x38], eax);         /* mov [ebp-0x38], eax */
            ii(0x100b_0546, 4); cmp(memd[ss, ebp - 0x38], 0);           /* cmp dword [ebp-0x38], 0x0 */
            ii(0x100b_054a, 2); if(jz(0x100b_0581, 0x35)) goto l_0x100b_0581; /* jz 0x100b0581 */
            ii(0x100b_054c, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_054f, 3); add(edx, 0x21);                         /* add edx, 0x21 */
            ii(0x100b_0552, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100b_0555, 5); call(0x1007_5e64, -0x3_a6f6);           /* call 0x10075e64 */
            ii(0x100b_055a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100b_055c, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x100b_0561, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_0564, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_0567, 5); call(0x1007_65d0, -0x3_9f9c);           /* call 0x100765d0 */
            ii(0x100b_056c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_056e, 3); mov(eax, memd[ss, ebp - 0x34]);         /* mov eax, [ebp-0x34] */
            ii(0x100b_0571, 5); call(0x100a_beeb, -0x468b);             /* call 0x100abeeb */
            ii(0x100b_0576, 3); mov(memd[ss, ebp - 0x40], eax);         /* mov [ebp-0x40], eax */
            ii(0x100b_0579, 3); mov(eax, memd[ss, ebp - 0x40]);         /* mov eax, [ebp-0x40] */
            ii(0x100b_057c, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100b_057f, 2); jmp(0x100b_0587, 0x6); goto l_0x100b_0587; /* jmp 0x100b0587 */
        l_0x100b_0581:
            ii(0x100b_0581, 3); mov(eax, memd[ss, ebp - 0x38]);         /* mov eax, [ebp-0x38] */
            ii(0x100b_0584, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
        l_0x100b_0587:
            ii(0x100b_0587, 3); mov(eax, memd[ss, ebp - 0x44]);         /* mov eax, [ebp-0x44] */
            ii(0x100b_058a, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100b_058d, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100b_0591, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100b_0594, 5); call(0x1011_d85d, 0x6_d2c4);            /* call 0x1011d85d */
            ii(0x100b_0599, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100b_059e, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100b_05a1, 5); call(0x1011_d801, 0x6_d25b);            /* call 0x1011d801 */
            ii(0x100b_05a6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_05a8, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100b_05ab, 5); call(0x1011_d88c, 0x6_d2dc);            /* call 0x1011d88c */
            ii(0x100b_05b0, 5); mov(eax, 0x1f);                         /* mov eax, 0x1f */
            ii(0x100b_05b5, 5); call(Definitions.sys_new, 0xb_5846);    /* call 0x10165e00 */
            ii(0x100b_05ba, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100b_05bd, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100b_05c0, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100b_05c3, 4); cmp(memd[ss, ebp - 0x50], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100b_05c7, 2); if(jz(0x100b_05ed, 0x24)) goto l_0x100b_05ed; /* jz 0x100b05ed */
            ii(0x100b_05c9, 5); mov(eax, 0x100b_06a7);                  /* mov eax, 0x100b06a7 */
            ii(0x100b_05ce, 1); push(eax);                              /* push eax */
            ii(0x100b_05cf, 5); mov(ecx, 0x100b_0640);                  /* mov ecx, 0x100b0640 */
            ii(0x100b_05d4, 3); mov(ebx, memd[ss, ebp - 0x48]);         /* mov ebx, [ebp-0x48] */
            ii(0x100b_05d7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_05da, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100b_05dd, 5); call(0x100a_ba72, -0x4b70);             /* call 0x100aba72 */
            ii(0x100b_05e2, 3); mov(memd[ss, ebp - 0x54], eax);         /* mov [ebp-0x54], eax */
            ii(0x100b_05e5, 3); mov(eax, memd[ss, ebp - 0x54]);         /* mov eax, [ebp-0x54] */
            ii(0x100b_05e8, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
            ii(0x100b_05eb, 2); jmp(0x100b_05f3, 0x6); goto l_0x100b_05f3; /* jmp 0x100b05f3 */
        l_0x100b_05ed:
            ii(0x100b_05ed, 3); mov(eax, memd[ss, ebp - 0x50]);         /* mov eax, [ebp-0x50] */
            ii(0x100b_05f0, 3); mov(memd[ss, ebp - 0x58], eax);         /* mov [ebp-0x58], eax */
        l_0x100b_05f3:
            ii(0x100b_05f3, 3); mov(edx, memd[ss, ebp - 0x58]);         /* mov edx, [ebp-0x58] */
            ii(0x100b_05f6, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_05f9, 5); call(0x1008_afe4, -0x2_561a);           /* call 0x1008afe4 */
            ii(0x100b_05fe, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_0601, 5); call(0x1008_af84, -0x2_5682);           /* call 0x1008af84 */
            ii(0x100b_0606, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100b_0608, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_060d, 5); call(0x100a_4d50, -0xb8c2);             /* call 0x100a4d50 */
            ii(0x100b_0612, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0614, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100b_0617, 5); call(0x1008_8b7c, -0x2_7aa0);           /* call 0x10088b7c */
            ii(0x100b_061c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_061e, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100b_0621, 5); call(0x1007_5f2c, -0x3_a6fa);           /* call 0x10075f2c */
            ii(0x100b_0626, 2); jmp(0x100b_0637, 0xf); goto l_0x100b_0637; /* jmp 0x100b0637 */
        l_0x100b_0628:
            ii(0x100b_0628, 5); jmp(0x100b_040b, -0x222); goto l_0x100b_040b; /* jmp 0x100b040b */
        //  ii(0x100b_062d, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x100b_062f, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
        //  ii(0x100b_0632, 5); call(0x1007_5f2c, -0x3_a70b);           /* call 0x10075f2c */
        l_0x100b_0637:
            ii(0x100b_0637, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_0639, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_063a, 1); pop(edi);                               /* pop edi */
            ii(0x100b_063b, 1); pop(esi);                               /* pop esi */
            ii(0x100b_063c, 1); pop(edx);                               /* pop edx */
            ii(0x100b_063d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_063e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_063f, 1); ret();                                  /* ret */
        }
    }
}

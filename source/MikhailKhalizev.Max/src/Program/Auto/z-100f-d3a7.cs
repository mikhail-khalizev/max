using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_d3a7-5a4b94f0")]
        public void Method_100f_d3a7()
        {
            ii(0x100f_d3a7, 5); push(0xd4);                             /* push 0xd4 */
            ii(0x100f_d3ac, 5); call(Definitions.sys_check_available_stack_size, 0x6_89a1); /* call 0x10165d52 */
            ii(0x100f_d3b1, 1); push(ebx);                              /* push ebx */
            ii(0x100f_d3b2, 1); push(ecx);                              /* push ecx */
            ii(0x100f_d3b3, 1); push(esi);                              /* push esi */
            ii(0x100f_d3b4, 1); push(edi);                              /* push edi */
            ii(0x100f_d3b5, 1); push(ebp);                              /* push ebp */
            ii(0x100f_d3b6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_d3b8, 6); sub(esp, 0xa8);                         /* sub esp, 0xa8 */
            ii(0x100f_d3be, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_d3c1, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_d3c4, 3); lea(edi, memd[ss, ebp - 0x14]);         /* lea edi, [ebp-0x14] */
            ii(0x100f_d3c7, 5); mov(esi, 0x101b_8ad8);                  /* mov esi, 0x101b8ad8 */
            ii(0x100f_d3cc, 1); movsd();                                /* movsd */
            ii(0x100f_d3cd, 2); movsw();                                /* movsw */
            ii(0x100f_d3cf, 3); lea(edi, memd[ss, ebp - 0x1c]);         /* lea edi, [ebp-0x1c] */
            ii(0x100f_d3d2, 5); mov(esi, 0x101b_8ade);                  /* mov esi, 0x101b8ade */
            ii(0x100f_d3d7, 1); movsd();                                /* movsd */
            ii(0x100f_d3d8, 2); movsw();                                /* movsw */
            ii(0x100f_d3da, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100f_d3de, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_d3e1, 5); call(Definitions.my_ctor_0x101b_38f8, -0x8_6cf6); /* call 0x100766f0 */
            ii(0x100f_d3e6, 3); mov(memd[ss, ebp - 0x24], eax);         /* mov [ebp-0x24], eax */
            ii(0x100f_d3e9, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100f_d3ed, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100f_d3f0, 5); call(Definitions.my_ctor_0x101b_4184, -0x8_6905); /* call 0x10076af0 */
            ii(0x100f_d3f5, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100f_d3fa, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_d3fd, 1); push(eax);                              /* push eax */
            ii(0x100f_d3fe, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x100f_d404, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100f_d407, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_d409, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_d40b, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100f_d40e, 5); call(0x1008_b148, -0x7_22cb);           /* call 0x1008b148 */
            ii(0x100f_d413, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d416, 5); call(0x100f_d1cc, -0x24f);              /* call 0x100fd1cc */
            ii(0x100f_d41b, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_d420, 1); push(eax);                              /* push eax */
            ii(0x100f_d421, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d423, 1); push(eax);                              /* push eax */
            ii(0x100f_d424, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d426, 1); push(eax);                              /* push eax */
            ii(0x100f_d427, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d42a, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_d42c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_d42f, 1); push(eax);                              /* push eax */
            ii(0x100f_d430, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d433, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_d436, 1); push(eax);                              /* push eax */
            ii(0x100f_d437, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_d439, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100f_d43e, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x100f_d443, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x100f_d446, 5); call(0x1015_a2da, 0x5_ce8f);            /* call 0x1015a2da */
            ii(0x100f_d44b, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x100f_d44e, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d450, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_d452, 5); call(0x1008_ac18, -0x7_283f);           /* call 0x1008ac18 */
            ii(0x100f_d457, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_d459, 3); lea(eax, memd[ss, ebp - 0x3c]);         /* lea eax, [ebp-0x3c] */
            ii(0x100f_d45c, 5); call(0x1007_5f2c, -0x8_7535);           /* call 0x10075f2c */
            ii(0x100f_d461, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_d466, 1); push(eax);                              /* push eax */
            ii(0x100f_d467, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d469, 1); push(eax);                              /* push eax */
            ii(0x100f_d46a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d46c, 1); push(eax);                              /* push eax */
            ii(0x100f_d46d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d470, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100f_d472, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_d475, 1); push(eax);                              /* push eax */
            ii(0x100f_d476, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d479, 3); movsx(eax, memw[ds, eax]);              /* movsx eax, word [eax] */
            ii(0x100f_d47c, 1); push(eax);                              /* push eax */
            ii(0x100f_d47d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_d47f, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100f_d484, 5); call(/* sys */ 0x1016_5e9b, 0x6_8a12);  /* call 0x10165e9b */
            ii(0x100f_d489, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x100f_d48c, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d48f, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_d491, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d493, 4); mov(edx, memd[ds, edx + ebp - 0x16]);   /* mov edx, [edx+ebp-0x16] */
            ii(0x100f_d497, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_d49a, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x100f_d49d, 5); call(0x1015_a2da, 0x5_ce38);            /* call 0x1015a2da */
            ii(0x100f_d4a2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d4a4, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_d4a7, 5); call(0x1008_ac18, -0x7_2894);           /* call 0x1008ac18 */
            ii(0x100f_d4ac, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_d4ae, 3); lea(eax, memd[ss, ebp - 0x40]);         /* lea eax, [ebp-0x40] */
            ii(0x100f_d4b1, 5); call(0x1007_5f2c, -0x8_758a);           /* call 0x10075f2c */
            ii(0x100f_d4b6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d4b9, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_d4bc, 1); dec(eax);                               /* dec eax */
            ii(0x100f_d4bd, 4); mov(memw[ss, ebp - 0x28], ax);          /* mov [ebp-0x28], ax */
            ii(0x100f_d4c1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d4c4, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100f_d4c8, 5); add(eax, 0x2);                          /* add eax, 0x2 */
            ii(0x100f_d4cd, 4); mov(memw[ss, ebp - 0x26], ax);          /* mov [ebp-0x26], ax */
            ii(0x100f_d4d1, 7); mov(memd[ss, ebp - 0x44], 0);           /* mov dword [ebp-0x44], 0x0 */
            ii(0x100f_d4d8, 2); jmp(0x100f_d4de, 0x4); goto l_0x100f_d4de; /* jmp 0x100fd4de */
        l_0x100f_d4da:
            ii(0x100f_d4da, 4); add(memd[ss, ebp - 0x44], 0x2);         /* add dword [ebp-0x44], 0x2 */
        l_0x100f_d4de:
            ii(0x100f_d4de, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x100f_d4e2, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100f_d4e5, 6); if(jge(0x100f_d597, 0xac)) goto l_0x100f_d597; /* jge 0x100fd597 */
            ii(0x100f_d4eb, 7); mov(memd[ss, ebp - 0x48], 0);           /* mov dword [ebp-0x48], 0x0 */
            ii(0x100f_d4f2, 2); jmp(0x100f_d4fa, 0x6); goto l_0x100f_d4fa; /* jmp 0x100fd4fa */
        l_0x100f_d4f4:
            ii(0x100f_d4f4, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100f_d4f7, 3); inc(memd[ss, ebp - 0x48]);              /* inc dword [ebp-0x48] */
        l_0x100f_d4fa:
            ii(0x100f_d4fa, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_d4fe, 3); cmp(eax, 0x3);                          /* cmp eax, 0x3 */
            ii(0x100f_d501, 6); if(jge(0x100f_d592, 0x8b)) goto l_0x100f_d592; /* jge 0x100fd592 */
            ii(0x100f_d507, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x100f_d50b, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_d50e, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100f_d513, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_d515, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100f_d518, 5); call(0x1008_b1a4, -0x7_2379);           /* call 0x1008b1a4 */
            ii(0x100f_d51d, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100f_d520, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100f_d523, 5); call(0x1010_82ce, 0xada6);              /* call 0x101082ce */
            ii(0x100f_d528, 2); test(al, al);                           /* test al, al */
            ii(0x100f_d52a, 2); if(jz(0x100f_d58d, 0x61)) goto l_0x100f_d58d; /* jz 0x100fd58d */
            ii(0x100f_d52c, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x100f_d530, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100f_d534, 5); call(0x1007_3cfd, -0x8_983c);           /* call 0x10073cfd */
            ii(0x100f_d539, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100f_d53e, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100f_d541, 4); cmp(memd[ss, ebp - 0x4c], 0x2);         /* cmp dword [ebp-0x4c], 0x2 */
            ii(0x100f_d545, 2); if(jz(0x100f_d54d, 0x6)) goto l_0x100f_d54d; /* jz 0x100fd54d */
            ii(0x100f_d547, 4); cmp(memd[ss, ebp - 0x4c], 0x4);         /* cmp dword [ebp-0x4c], 0x4 */
            ii(0x100f_d54b, 2); if(jnz(0x100f_d58d, 0x40)) goto l_0x100f_d58d; /* jnz 0x100fd58d */
        l_0x100f_d54d:
            ii(0x100f_d54d, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_d552, 1); push(eax);                              /* push eax */
            ii(0x100f_d553, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d555, 1); push(eax);                              /* push eax */
            ii(0x100f_d556, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d558, 1); push(eax);                              /* push eax */
            ii(0x100f_d559, 4); movsx(eax, memw[ss, ebp - 0x26]);       /* movsx eax, word [ebp-0x26] */
            ii(0x100f_d55d, 1); push(eax);                              /* push eax */
            ii(0x100f_d55e, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100f_d562, 1); push(eax);                              /* push eax */
            ii(0x100f_d563, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_d565, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100f_d56a, 5); mov(edx, 0x27);                         /* mov edx, 0x27 */
            ii(0x100f_d56f, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x100f_d572, 5); call(0x1015_a2da, 0x5_cd63);            /* call 0x1015a2da */
            ii(0x100f_d577, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x100f_d57a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d57c, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_d57e, 5); call(0x1008_ac18, -0x7_296b);           /* call 0x1008ac18 */
            ii(0x100f_d583, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_d585, 3); lea(eax, memd[ss, ebp - 0x50]);         /* lea eax, [ebp-0x50] */
            ii(0x100f_d588, 5); call(0x1007_5f2c, -0x8_7661);           /* call 0x10075f2c */
        l_0x100f_d58d:
            ii(0x100f_d58d, 5); jmp(0x100f_d4f4, -0x9e); goto l_0x100f_d4f4; /* jmp 0x100fd4f4 */
        l_0x100f_d592:
            ii(0x100f_d592, 5); jmp(0x100f_d4da, -0xbd); goto l_0x100f_d4da; /* jmp 0x100fd4da */
        l_0x100f_d597:
            ii(0x100f_d597, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100f_d59b, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d59e, 5); call(0x100c_a068, -0x3_353b);           /* call 0x100ca068 */
            ii(0x100f_d5a3, 3); mov(memd[ss, ebp - 0x64], eax);         /* mov [ebp-0x64], eax */
            ii(0x100f_d5a6, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100f_d5aa, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100f_d5ae, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d5b1, 5); call(0x100c_a068, -0x3_354e);           /* call 0x100ca068 */
            ii(0x100f_d5b6, 3); mov(memd[ss, ebp - 0x78], eax);         /* mov [ebp-0x78], eax */
            ii(0x100f_d5b9, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100f_d5bd, 5); mov(edx, 0x51);                         /* mov edx, 0x51 */
            ii(0x100f_d5c2, 5); mov(eax, 0x101c_ad84);                  /* mov eax, 0x101cad84 */
            ii(0x100f_d5c7, 5); call(0x100d_fd2c, -0x1_d8a0);           /* call 0x100dfd2c */
            ii(0x100f_d5cc, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x100f_d5d0, 3); mov(memd[ss, ebp - 0x7c], eax);         /* mov [ebp-0x7c], eax */
            ii(0x100f_d5d3, 7); mov(memd[ss, ebp - 0x80], 0x2);         /* mov dword [ebp-0x80], 0x2 */
        l_0x100f_d5da:
            ii(0x100f_d5da, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_d5dd, 4); cmp(ax, memw[ss, ebp - 0x7c]);          /* cmp ax, [ebp-0x7c] */
            ii(0x100f_d5e1, 2); if(jl(0x100f_d5eb, 0x8)) goto l_0x100f_d5eb; /* jl 0x100fd5eb */
            ii(0x100f_d5e3, 4); movsx(eax, memw[ss, ebp - 0x80]);       /* movsx eax, word [ebp-0x80] */
            ii(0x100f_d5e7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d5e9, 2); if(jg(0x100f_d5f0, 0x5)) goto l_0x100f_d5f0; /* jg 0x100fd5f0 */
        l_0x100f_d5eb:
            ii(0x100f_d5eb, 5); jmp(0x100f_da02, 0x412); goto l_0x100f_da02; /* jmp 0x100fda02 */
        l_0x100f_d5f0:
            ii(0x100f_d5f0, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d5f3, 5); call(0x1009_cb94, -0x6_0a64);           /* call 0x1009cb94 */
            ii(0x100f_d5f8, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d5fb, 5); call(0x1009_cb94, -0x6_0a6c);           /* call 0x1009cb94 */
            ii(0x100f_d600, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d603, 3); mov(ax, memw[ds, eax]);                 /* mov ax, [eax] */
            ii(0x100f_d606, 3); sub(eax, memd[ss, ebp - 0x80]);         /* sub eax, [ebp-0x80] */
            ii(0x100f_d609, 4); mov(memw[ss, ebp - 0x28], ax);          /* mov [ebp-0x28], ax */
            ii(0x100f_d60d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100f_d610, 4); mov(ax, memw[ds, eax + 0x2]);           /* mov ax, [eax+0x2] */
            ii(0x100f_d614, 3); add(eax, memd[ss, ebp - 0x80]);         /* add eax, [ebp-0x80] */
            ii(0x100f_d617, 1); inc(eax);                               /* inc eax */
            ii(0x100f_d618, 4); mov(memw[ss, ebp - 0x26], ax);          /* mov [ebp-0x26], ax */
            ii(0x100f_d61c, 7); mov(memd[ss, ebp - 0x44], 0);           /* mov dword [ebp-0x44], 0x0 */
            ii(0x100f_d623, 2); jmp(0x100f_d629, 0x4); goto l_0x100f_d629; /* jmp 0x100fd629 */
        l_0x100f_d625:
            ii(0x100f_d625, 4); add(memd[ss, ebp - 0x44], 0x2);         /* add dword [ebp-0x44], 0x2 */
        l_0x100f_d629:
            ii(0x100f_d629, 4); movsx(eax, memw[ss, ebp - 0x44]);       /* movsx eax, word [ebp-0x44] */
            ii(0x100f_d62d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100f_d630, 6); if(jge(0x100f_d6b9, 0x83)) goto l_0x100f_d6b9; /* jge 0x100fd6b9 */
            ii(0x100f_d636, 7); mov(memd[ss, ebp - 0x48], 0);           /* mov dword [ebp-0x48], 0x0 */
            ii(0x100f_d63d, 2); jmp(0x100f_d645, 0x6); goto l_0x100f_d645; /* jmp 0x100fd645 */
        l_0x100f_d63f:
            ii(0x100f_d63f, 3); mov(eax, memd[ss, ebp - 0x48]);         /* mov eax, [ebp-0x48] */
            ii(0x100f_d642, 3); inc(memd[ss, ebp - 0x48]);              /* inc dword [ebp-0x48] */
        l_0x100f_d645:
            ii(0x100f_d645, 4); movsx(eax, memw[ss, ebp - 0x80]);       /* movsx eax, word [ebp-0x80] */
            ii(0x100f_d649, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_d64b, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x100f_d64f, 1); inc(eax);                               /* inc eax */
            ii(0x100f_d650, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_d652, 2); if(jge(0x100f_d6b4, 0x60)) goto l_0x100f_d6b4; /* jge 0x100fd6b4 */
            ii(0x100f_d654, 4); movsx(edx, memw[ss, ebp - 0x44]);       /* movsx edx, word [ebp-0x44] */
            ii(0x100f_d658, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_d65b, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100f_d660, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_d662, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100f_d665, 5); call(0x1008_b1a4, -0x7_24c6);           /* call 0x1008b1a4 */
            ii(0x100f_d66a, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100f_d66d, 3); lea(eax, memd[ss, ebp - 0x38]);         /* lea eax, [ebp-0x38] */
            ii(0x100f_d670, 5); call(0x1010_82ce, 0xac59);              /* call 0x101082ce */
            ii(0x100f_d675, 2); test(al, al);                           /* test al, al */
            ii(0x100f_d677, 2); if(jz(0x100f_d6b2, 0x39)) goto l_0x100f_d6b2; /* jz 0x100fd6b2 */
            ii(0x100f_d679, 4); movsx(edx, memw[ss, ebp - 0x26]);       /* movsx edx, word [ebp-0x26] */
            ii(0x100f_d67d, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100f_d681, 5); call(0x1007_3d48, -0x8_993e);           /* call 0x10073d48 */
            ii(0x100f_d686, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100f_d68b, 3); mov(memd[ss, ebp - 0x4c], eax);         /* mov [ebp-0x4c], eax */
            ii(0x100f_d68e, 4); cmp(memd[ss, ebp - 0x4c], 0x2);         /* cmp dword [ebp-0x4c], 0x2 */
            ii(0x100f_d692, 2); if(jnz(0x100f_d6a1, 0xd)) goto l_0x100f_d6a1; /* jnz 0x100fd6a1 */
            ii(0x100f_d694, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100f_d697, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d69a, 5); call(0x100a_aa64, -0x5_2c3b);           /* call 0x100aaa64 */
            ii(0x100f_d69f, 2); jmp(0x100f_d6b2, 0x11); goto l_0x100f_d6b2; /* jmp 0x100fd6b2 */
        l_0x100f_d6a1:
            ii(0x100f_d6a1, 4); cmp(memd[ss, ebp - 0x4c], 0x1);         /* cmp dword [ebp-0x4c], 0x1 */
            ii(0x100f_d6a5, 2); if(jnz(0x100f_d6b2, 0xb)) goto l_0x100f_d6b2; /* jnz 0x100fd6b2 */
            ii(0x100f_d6a7, 3); lea(edx, memd[ss, ebp - 0x28]);         /* lea edx, [ebp-0x28] */
            ii(0x100f_d6aa, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d6ad, 5); call(0x100a_aa64, -0x5_2c4e);           /* call 0x100aaa64 */
        l_0x100f_d6b2:
            ii(0x100f_d6b2, 2); jmp(0x100f_d63f, -0x75); goto l_0x100f_d63f; /* jmp 0x100fd63f */
        l_0x100f_d6b4:
            ii(0x100f_d6b4, 5); jmp(0x100f_d625, -0x94); goto l_0x100f_d625; /* jmp 0x100fd625 */
        l_0x100f_d6b9:
            ii(0x100f_d6b9, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x100f_d6be, 5); mov(eax, 0x101c_ad84);                  /* mov eax, 0x101cad84 */
            ii(0x100f_d6c3, 5); call(0x100d_fd2c, -0x1_d99c);           /* call 0x100dfd2c */
            ii(0x100f_d6c8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d6ca, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_d6cd, 4); cmp(ax, memw[ds, edx + 0x8]);           /* cmp ax, [edx+0x8] */
            ii(0x100f_d6d1, 2); if(jge(0x100f_d6df, 0xc)) goto l_0x100f_d6df; /* jge 0x100fd6df */
            ii(0x100f_d6d3, 10); mov(memd[ss, ebp - 0x84], 0x1);        /* mov dword [ebp-0x84], 0x1 */
            ii(0x100f_d6dd, 2); jmp(0x100f_d6e9, 0xa); goto l_0x100f_d6e9; /* jmp 0x100fd6e9 */
        l_0x100f_d6df:
            ii(0x100f_d6df, 10); mov(memd[ss, ebp - 0x84], 0);          /* mov dword [ebp-0x84], 0x0 */
        l_0x100f_d6e9:
            ii(0x100f_d6e9, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_d6ed, 6); cmp(eax, memd[ss, ebp - 0x84]);         /* cmp eax, [ebp-0x84] */
            ii(0x100f_d6f3, 2); if(jge(0x100f_d6fd, 0x8)) goto l_0x100f_d6fd; /* jge 0x100fd6fd */
            ii(0x100f_d6f5, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d6f8, 5); call(0x1009_cb94, -0x6_0b69);           /* call 0x1009cb94 */
        l_0x100f_d6fd:
            ii(0x100f_d6fd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_d700, 4); cmp(ax, memw[ss, ebp - 0x7c]);          /* cmp ax, [ebp-0x7c] */
            ii(0x100f_d704, 2); if(jl(0x100f_d720, 0x1a)) goto l_0x100f_d720; /* jl 0x100fd720 */
            ii(0x100f_d706, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d709, 5); call(Definitions.my_3_get_count, -0x7_228e); /* call 0x1008b480 */
            ii(0x100f_d70e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_d711, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d714, 5); call(Definitions.my_3_get_count, -0x7_2299); /* call 0x1008b480 */
            ii(0x100f_d719, 1); cwde();                                 /* cwde */
            ii(0x100f_d71a, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100f_d71c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d71e, 2); if(jg(0x100f_d725, 0x5)) goto l_0x100f_d725; /* jg 0x100fd725 */
        l_0x100f_d720:
            ii(0x100f_d720, 5); jmp(0x100f_d9f7, 0x2d2); goto l_0x100f_d9f7; /* jmp 0x100fd9f7 */
        l_0x100f_d725:
            ii(0x100f_d725, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d728, 5); call(Definitions.my_3_get_count, -0x7_22ad); /* call 0x1008b480 */
            ii(0x100f_d72d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d72f, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d732, 5); call(Definitions.my_3_get_count, -0x7_22b7); /* call 0x1008b480 */
            ii(0x100f_d737, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_d739, 6); mov(memd[ss, ebp - 0x88], edx);         /* mov [ebp-0x88], edx */
            ii(0x100f_d73f, 7); movsx(edx, memw[ss, ebp - 0x88]);       /* movsx edx, word [ebp-0x88] */
            ii(0x100f_d746, 5); call(/* sys */ 0x1016_5e9b, 0x6_8750);  /* call 0x10165e9b */
            ii(0x100f_d74b, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_d74e, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d751, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d753, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d756, 5); call(Definitions.my_3_get_count, -0x7_22db); /* call 0x1008b480 */
            ii(0x100f_d75b, 1); cwde();                                 /* cwde */
            ii(0x100f_d75c, 1); inc(edx);                               /* inc edx */
            ii(0x100f_d75d, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_d75f, 6); if(jle(0x100f_d8a4, 0x13f)) goto l_0x100f_d8a4; /* jle 0x100fd8a4 */
            ii(0x100f_d765, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d768, 5); call(Definitions.my_3_get_count, -0x7_22ed); /* call 0x1008b480 */
            ii(0x100f_d76d, 1); cwde();                                 /* cwde */
            ii(0x100f_d76e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d770, 2); if(jle(0x100f_d77e, 0xc)) goto l_0x100f_d77e; /* jle 0x100fd77e */
            ii(0x100f_d772, 10); mov(memd[ss, ebp - 0x8c], 0);          /* mov dword [ebp-0x8c], 0x0 */
            ii(0x100f_d77c, 2); jmp(0x100f_d79a, 0x1c); goto l_0x100f_d79a; /* jmp 0x100fd79a */
        l_0x100f_d77e:
            ii(0x100f_d77e, 5); mov(ecx, 0x191e);                       /* mov ecx, 0x191e */
            ii(0x100f_d783, 5); mov(ebx, StringDefinitions.GamemgrCpp6); /* mov ebx, 0x101a2982 */
            ii(0x100f_d788, 5); mov(edx, StringDefinitions.LandTilesGetcountGreater0); /* mov edx, 0x101a298e */
            ii(0x100f_d78d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d78f, 5); call(Definitions.sys_assert, 0x6_85fe); /* call 0x10165d92 */
            ii(0x100f_d794, 6); mov(memd[ss, ebp - 0x8c], eax);         /* mov [ebp-0x8c], eax */
        l_0x100f_d79a:
            ii(0x100f_d79a, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d79d, 5); call(Definitions.my_3_get_count, -0x7_2322); /* call 0x1008b480 */
            ii(0x100f_d7a2, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_d7a5, 5); call(/* sys */ 0x1016_5e9b, 0x6_86f1);  /* call 0x10165e9b */
            ii(0x100f_d7aa, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_d7ad, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d7b0, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_d7b3, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_d7b7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d7b9, 2); if(jl(0x100f_d7c9, 0xe)) goto l_0x100f_d7c9; /* jl 0x100fd7c9 */
            ii(0x100f_d7bb, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d7be, 5); call(Definitions.my_3_get_count, -0x7_2343); /* call 0x1008b480 */
            ii(0x100f_d7c3, 4); cmp(ax, memw[ss, ebp - 0x48]);          /* cmp ax, [ebp-0x48] */
            ii(0x100f_d7c7, 2); if(jg(0x100f_d7cb, 0x2)) goto l_0x100f_d7cb; /* jg 0x100fd7cb */
        l_0x100f_d7c9:
            ii(0x100f_d7c9, 2); jmp(0x100f_d7d7, 0xc); goto l_0x100f_d7d7; /* jmp 0x100fd7d7 */
        l_0x100f_d7cb:
            ii(0x100f_d7cb, 10); mov(memd[ss, ebp - 0x90], 0);          /* mov dword [ebp-0x90], 0x0 */
            ii(0x100f_d7d5, 2); jmp(0x100f_d7f3, 0x1c); goto l_0x100f_d7f3; /* jmp 0x100fd7f3 */
        l_0x100f_d7d7:
            ii(0x100f_d7d7, 5); mov(ecx, 0x1920);                       /* mov ecx, 0x1920 */
            ii(0x100f_d7dc, 5); mov(ebx, StringDefinitions.GamemgrCpp5); /* mov ebx, 0x101a29a8 */
            ii(0x100f_d7e1, 5); mov(edx, StringDefinitions.IGreaterOrEqual0ILessLandTilesGetcount); /* mov edx, 0x101a29b4 */
            ii(0x100f_d7e6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d7e8, 5); call(Definitions.sys_assert, 0x6_85a5); /* call 0x10165d92 */
            ii(0x100f_d7ed, 6); mov(memd[ss, ebp - 0x90], eax);         /* mov [ebp-0x90], eax */
        l_0x100f_d7f3:
            ii(0x100f_d7f3, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x100f_d7f7, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d7fa, 5); call(0x100a_aa28, -0x5_2dd7);           /* call 0x100aaa28 */
            ii(0x100f_d7ff, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d801, 3); lea(eax, memd[ss, ebp - 0x28]);         /* lea eax, [ebp-0x28] */
            ii(0x100f_d804, 5); call(0x1008_8b44, -0x7_4cc5);           /* call 0x10088b44 */
            ii(0x100f_d809, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x100f_d80d, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_d810, 5); call(0x100c_db14, -0x2_fd01);           /* call 0x100cdb14 */
        l_0x100f_d815:
            ii(0x100f_d815, 5); call(/* sys */ 0x1016_5e9b, 0x6_8681);  /* call 0x10165e9b */
            ii(0x100f_d81a, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x100f_d81d, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d820, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_d822, 5); mov(ax, memw[ds, eax + ebp - 0x1c]);    /* mov ax, [eax+ebp-0x1c] */
            ii(0x100f_d827, 6); mov(memd[ss, ebp - 0x94], eax);         /* mov [ebp-0x94], eax */
            ii(0x100f_d82d, 7); movsx(edx, memw[ss, ebp - 0x94]);       /* movsx edx, word [ebp-0x94] */
            ii(0x100f_d834, 5); mov(eax, 0x101c_ad84);                  /* mov eax, 0x101cad84 */
            ii(0x100f_d839, 5); call(0x100d_fd2c, -0x1_db12);           /* call 0x100dfd2c */
            ii(0x100f_d83e, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x100f_d842, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100f_d846, 2); if(jg(0x100f_d815, -0x33)) goto l_0x100f_d815; /* jg 0x100fd815 */
            ii(0x100f_d848, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_d84d, 1); push(eax);                              /* push eax */
            ii(0x100f_d84e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d850, 1); push(eax);                              /* push eax */
            ii(0x100f_d851, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d853, 1); push(eax);                              /* push eax */
            ii(0x100f_d854, 4); movsx(eax, memw[ss, ebp - 0x26]);       /* movsx eax, word [ebp-0x26] */
            ii(0x100f_d858, 1); push(eax);                              /* push eax */
            ii(0x100f_d859, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100f_d85d, 1); push(eax);                              /* push eax */
            ii(0x100f_d85e, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_d860, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100f_d865, 5); call(/* sys */ 0x1016_5e9b, 0x6_8631);  /* call 0x10165e9b */
            ii(0x100f_d86a, 3); lea(eax, memd[ds, eax + eax * 2]);      /* lea eax, [eax+eax*2] */
            ii(0x100f_d86d, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d870, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x100f_d872, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d874, 4); mov(edx, memd[ds, edx + ebp - 0x1e]);   /* mov edx, [edx+ebp-0x1e] */
            ii(0x100f_d878, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_d87b, 6); lea(eax, memd[ss, ebp - 0x98]);         /* lea eax, [ebp-0x98] */
            ii(0x100f_d881, 5); call(0x1015_a2da, 0x5_ca54);            /* call 0x1015a2da */
            ii(0x100f_d886, 3); lea(ebx, memd[ss, ebp - 0x20]);         /* lea ebx, [ebp-0x20] */
            ii(0x100f_d889, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d88b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_d88d, 5); call(0x1008_ac18, -0x7_2c7a);           /* call 0x1008ac18 */
            ii(0x100f_d892, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_d894, 6); lea(eax, memd[ss, ebp - 0x98]);         /* lea eax, [ebp-0x98] */
            ii(0x100f_d89a, 5); call(0x1007_5f2c, -0x8_7973);           /* call 0x10075f2c */
            ii(0x100f_d89f, 5); jmp(0x100f_d99a, 0xf6); goto l_0x100f_d99a; /* jmp 0x100fd99a */
        l_0x100f_d8a4:
            ii(0x100f_d8a4, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d8a7, 5); call(Definitions.my_3_get_count, -0x7_242c); /* call 0x1008b480 */
            ii(0x100f_d8ac, 1); cwde();                                 /* cwde */
            ii(0x100f_d8ad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d8af, 2); if(jle(0x100f_d8bd, 0xc)) goto l_0x100f_d8bd; /* jle 0x100fd8bd */
            ii(0x100f_d8b1, 10); mov(memd[ss, ebp - 0x9c], 0);          /* mov dword [ebp-0x9c], 0x0 */
            ii(0x100f_d8bb, 2); jmp(0x100f_d8d9, 0x1c); goto l_0x100f_d8d9; /* jmp 0x100fd8d9 */
        l_0x100f_d8bd:
            ii(0x100f_d8bd, 5); mov(ecx, 0x192b);                       /* mov ecx, 0x192b */
            ii(0x100f_d8c2, 5); mov(ebx, StringDefinitions.GamemgrCpp8); /* mov ebx, 0x101a29d8 */
            ii(0x100f_d8c7, 5); mov(edx, StringDefinitions.WaterTilesGetcountGreater0); /* mov edx, 0x101a29e4 */
            ii(0x100f_d8cc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d8ce, 5); call(Definitions.sys_assert, 0x6_84bf); /* call 0x10165d92 */
            ii(0x100f_d8d3, 6); mov(memd[ss, ebp - 0x9c], eax);         /* mov [ebp-0x9c], eax */
        l_0x100f_d8d9:
            ii(0x100f_d8d9, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d8dc, 5); call(Definitions.my_3_get_count, -0x7_2461); /* call 0x1008b480 */
            ii(0x100f_d8e1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100f_d8e4, 5); call(/* sys */ 0x1016_5e9b, 0x6_85b2);  /* call 0x10165e9b */
            ii(0x100f_d8e9, 3); imul(eax, edx);                         /* imul eax, edx */
            ii(0x100f_d8ec, 3); shr(eax, 0xf);                          /* shr eax, 0xf */
            ii(0x100f_d8ef, 3); mov(memd[ss, ebp - 0x48], eax);         /* mov [ebp-0x48], eax */
            ii(0x100f_d8f2, 4); movsx(eax, memw[ss, ebp - 0x48]);       /* movsx eax, word [ebp-0x48] */
            ii(0x100f_d8f6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_d8f8, 2); if(jl(0x100f_d908, 0xe)) goto l_0x100f_d908; /* jl 0x100fd908 */
            ii(0x100f_d8fa, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d8fd, 5); call(Definitions.my_3_get_count, -0x7_2482); /* call 0x1008b480 */
            ii(0x100f_d902, 4); cmp(ax, memw[ss, ebp - 0x48]);          /* cmp ax, [ebp-0x48] */
            ii(0x100f_d906, 2); if(jg(0x100f_d90a, 0x2)) goto l_0x100f_d90a; /* jg 0x100fd90a */
        l_0x100f_d908:
            ii(0x100f_d908, 2); jmp(0x100f_d916, 0xc); goto l_0x100f_d916; /* jmp 0x100fd916 */
        l_0x100f_d90a:
            ii(0x100f_d90a, 10); mov(memd[ss, ebp - 0xa0], 0);          /* mov dword [ebp-0xa0], 0x0 */
            ii(0x100f_d914, 2); jmp(0x100f_d932, 0x1c); goto l_0x100f_d932; /* jmp 0x100fd932 */
        l_0x100f_d916:
            ii(0x100f_d916, 5); mov(ecx, 0x192d);                       /* mov ecx, 0x192d */
            ii(0x100f_d91b, 5); mov(ebx, StringDefinitions.GamemgrCpp7); /* mov ebx, 0x101a29ff */
            ii(0x100f_d920, 5); mov(edx, StringDefinitions.IGreaterOrEqual0ILessWaterTilesGetcount); /* mov edx, 0x101a2a0b */
            ii(0x100f_d925, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d927, 5); call(Definitions.sys_assert, 0x6_8466); /* call 0x10165d92 */
            ii(0x100f_d92c, 6); mov(memd[ss, ebp - 0xa0], eax);         /* mov [ebp-0xa0], eax */
        l_0x100f_d932:
            ii(0x100f_d932, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x100f_d936, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d939, 5); call(0x100a_aa28, -0x5_2f16);           /* call 0x100aaa28 */
            ii(0x100f_d93e, 3); lea(ebx, memd[ss, ebp - 0x28]);         /* lea ebx, [ebp-0x28] */
            ii(0x100f_d941, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d943, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100f_d945, 5); call(0x1008_8b44, -0x7_4e06);           /* call 0x10088b44 */
            ii(0x100f_d94a, 4); movsx(edx, memw[ss, ebp - 0x48]);       /* movsx edx, word [ebp-0x48] */
            ii(0x100f_d94e, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d951, 5); call(0x100c_db14, -0x2_fe42);           /* call 0x100cdb14 */
            ii(0x100f_d956, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_d95b, 1); push(eax);                              /* push eax */
            ii(0x100f_d95c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d95e, 1); push(eax);                              /* push eax */
            ii(0x100f_d95f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_d961, 1); push(eax);                              /* push eax */
            ii(0x100f_d962, 4); movsx(eax, memw[ss, ebp - 0x26]);       /* movsx eax, word [ebp-0x26] */
            ii(0x100f_d966, 1); push(eax);                              /* push eax */
            ii(0x100f_d967, 4); movsx(eax, memw[ss, ebp - 0x28]);       /* movsx eax, word [ebp-0x28] */
            ii(0x100f_d96b, 1); push(eax);                              /* push eax */
            ii(0x100f_d96c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100f_d96e, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x100f_d973, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x100f_d978, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x100f_d97e, 5); call(0x1015_a2da, 0x5_c957);            /* call 0x1015a2da */
            ii(0x100f_d983, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d985, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_d988, 5); call(0x1008_ac18, -0x7_2d75);           /* call 0x1008ac18 */
            ii(0x100f_d98d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_d98f, 6); lea(eax, memd[ss, ebp - 0xa4]);         /* lea eax, [ebp-0xa4] */
            ii(0x100f_d995, 5); call(0x1007_5f2c, -0x8_7a6e);           /* call 0x10075f2c */
        l_0x100f_d99a:
            ii(0x100f_d99a, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_d99d, 5); call(0x1007_6574, -0x8_742e);           /* call 0x10076574 */
            ii(0x100f_d9a2, 5); call(0x1007_623c, -0x8_776b);           /* call 0x1007623c */
            ii(0x100f_d9a7, 4); mov(ax, memw[ds, eax + 0x8]);           /* mov ax, [eax+0x8] */
            ii(0x100f_d9ab, 3); sub(memd[ss, ebp - 0x4], eax);          /* sub [ebp-0x4], eax */
            ii(0x100f_d9ae, 5); mov(edx, 0x50);                         /* mov edx, 0x50 */
            ii(0x100f_d9b3, 5); mov(eax, 0x101c_ad84);                  /* mov eax, 0x101cad84 */
            ii(0x100f_d9b8, 5); call(0x100d_fd2c, -0x1_dc91);           /* call 0x100dfd2c */
            ii(0x100f_d9bd, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_d9bf, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100f_d9c2, 4); cmp(ax, memw[ds, edx + 0x8]);           /* cmp ax, [edx+0x8] */
            ii(0x100f_d9c6, 2); if(jge(0x100f_d9d4, 0xc)) goto l_0x100f_d9d4; /* jge 0x100fd9d4 */
            ii(0x100f_d9c8, 10); mov(memd[ss, ebp - 0xa8], 0x1);        /* mov dword [ebp-0xa8], 0x1 */
            ii(0x100f_d9d2, 2); jmp(0x100f_d9de, 0xa); goto l_0x100f_d9de; /* jmp 0x100fd9de */
        l_0x100f_d9d4:
            ii(0x100f_d9d4, 10); mov(memd[ss, ebp - 0xa8], 0);          /* mov dword [ebp-0xa8], 0x0 */
        l_0x100f_d9de:
            ii(0x100f_d9de, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_d9e2, 6); cmp(eax, memd[ss, ebp - 0xa8]);         /* cmp eax, [ebp-0xa8] */
            ii(0x100f_d9e8, 2); if(jge(0x100f_d9f2, 0x8)) goto l_0x100f_d9f2; /* jge 0x100fd9f2 */
            ii(0x100f_d9ea, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_d9ed, 5); call(0x1009_cb94, -0x6_0e5e);           /* call 0x1009cb94 */
        l_0x100f_d9f2:
            ii(0x100f_d9f2, 5); jmp(0x100f_d6fd, -0x2fa); goto l_0x100f_d6fd; /* jmp 0x100fd6fd */
        l_0x100f_d9f7:
            ii(0x100f_d9f7, 3); mov(eax, memd[ss, ebp - 0x80]);         /* mov eax, [ebp-0x80] */
            ii(0x100f_d9fa, 3); dec(memd[ss, ebp - 0x80]);              /* dec dword [ebp-0x80] */
            ii(0x100f_d9fd, 5); jmp(0x100f_d5da, -0x428); goto l_0x100f_d5da; /* jmp 0x100fd5da */
        l_0x100f_da02:
            ii(0x100f_da02, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_da04, 3); lea(eax, memd[ss, ebp - 0x74]);         /* lea eax, [ebp-0x74] */
            ii(0x100f_da07, 5); call(0x100a_a3c0, -0x5_364c);           /* call 0x100aa3c0 */
            ii(0x100f_da0c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_da0e, 3); lea(eax, memd[ss, ebp - 0x60]);         /* lea eax, [ebp-0x60] */
            ii(0x100f_da11, 5); call(0x100a_a3c0, -0x5_3656);           /* call 0x100aa3c0 */
            ii(0x100f_da16, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_da18, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x100f_da1b, 5); call(0x1007_5f2c, -0x8_7af4);           /* call 0x10075f2c */
            ii(0x100f_da20, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_da22, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_da23, 1); pop(edi);                               /* pop edi */
            ii(0x100f_da24, 1); pop(esi);                               /* pop esi */
            ii(0x100f_da25, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_da26, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_da27, 1); ret();                                  /* ret */
        }
    }
}

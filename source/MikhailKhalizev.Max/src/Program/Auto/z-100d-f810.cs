using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_f810-a58d52f3")]
        public void Method_100d_f810()
        {
            ii(0x100d_f810, 5); push(0x88);                             /* push 0x88 */
            ii(0x100d_f815, 5); call(Definitions.sys_check_available_stack_size, 0x8_6538); /* call 0x10165d52 */
            ii(0x100d_f81a, 1); push(ebx);                              /* push ebx */
            ii(0x100d_f81b, 1); push(ecx);                              /* push ecx */
            ii(0x100d_f81c, 1); push(esi);                              /* push esi */
            ii(0x100d_f81d, 1); push(edi);                              /* push edi */
            ii(0x100d_f81e, 1); push(ebp);                              /* push ebp */
            ii(0x100d_f81f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_f821, 6); sub(esp, 0x70);                         /* sub esp, 0x70 */
            ii(0x100d_f827, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_f82a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_f82d, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_f831, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f834, 5); call(0x100e_0720, 0xee7);               /* call 0x100e0720 */
            ii(0x100d_f839, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100d_f83c, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
            ii(0x100d_f840, 5); mov(edx, StringDefinitions.Gold5);      /* mov edx, 0x101a1ab4 */
            ii(0x100d_f845, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f848, 5); call(0x1014_60aa, 0x6_685d);            /* call 0x101460aa */
            ii(0x100d_f84d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f84f, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_f852, 4); mov(memw[ds, eax + 0x6], dx);           /* mov [eax+0x6], dx */
            ii(0x100d_f856, 5); mov(ebx, StringDefinitions.BaseValues); /* mov ebx, 0x101a1ab9 */
            ii(0x100d_f85b, 3); lea(edx, ebp - 0x18);                   /* lea edx, [ebp-0x18] */
            ii(0x100d_f85e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f861, 5); call(0x1014_625c, 0x6_69f6);            /* call 0x1014625c */
            ii(0x100d_f866, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f868, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f86b, 5); call(0x100e_06a4, 0xe34);               /* call 0x100e06a4 */
            ii(0x100d_f870, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f872, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_f875, 5); call(0x100e_03fc, 0xb82);               /* call 0x100e03fc */
            ii(0x100d_f87a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f87c, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f87f, 5); call(0x1013_ad71, 0x5_b4ed);            /* call 0x1013ad71 */
            ii(0x100d_f884, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f886, 6); if(jz(0x100d_f95c, 0xd0)) goto l_0x100d_f95c; /* jz 0x100df95c */
            ii(0x100d_f88c, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_f890, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f893, 5); call(0x100e_0720, 0xe88);               /* call 0x100e0720 */
            ii(0x100d_f898, 3); mov(memd[ss, ebp - 0x28], eax);         /* mov [ebp-0x28], eax */
            ii(0x100d_f89b, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
        l_0x100d_f89f:
            ii(0x100d_f89f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_f8a1, 5); mov(ebx, StringDefinitions.Unit3);      /* mov ebx, 0x101a1ac5 */
            ii(0x100d_f8a6, 3); lea(edx, ebp - 0x2c);                   /* lea edx, [ebp-0x2c] */
            ii(0x100d_f8a9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f8ac, 5); call(0x100e_0648, 0xd97);               /* call 0x100e0648 */
            ii(0x100d_f8b1, 5); call(0x1014_625c, 0x6_69a6);            /* call 0x1014625c */
            ii(0x100d_f8b6, 3); lea(ebx, ebp - 0x24);                   /* lea ebx, [ebp-0x24] */
            ii(0x100d_f8b9, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f8bb, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f8bd, 5); call(0x100e_06a4, 0xde2);               /* call 0x100e06a4 */
            ii(0x100d_f8c2, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100d_f8c4, 5); call(0x1013_ad71, 0x5_b4a8);            /* call 0x1013ad71 */
            ii(0x100d_f8c9, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f8cb, 2); if(jz(0x100d_f8d6, 0x9)) goto l_0x100d_f8d6; /* jz 0x100df8d6 */
            ii(0x100d_f8cd, 7); mov(memd[ss, ebp - 0x30], 0x1);         /* mov dword [ebp-0x30], 0x1 */
            ii(0x100d_f8d4, 2); jmp(0x100d_f8dd, 0x7); goto l_0x100d_f8dd; /* jmp 0x100df8dd */
        l_0x100d_f8d6:
            ii(0x100d_f8d6, 7); mov(memd[ss, ebp - 0x30], 0);           /* mov dword [ebp-0x30], 0x0 */
        l_0x100d_f8dd:
            ii(0x100d_f8dd, 3); mov(eax, memd[ss, ebp - 0x30]);         /* mov eax, [ebp-0x30] */
            ii(0x100d_f8e0, 3); mov(memd[ss, ebp - 0x34], eax);         /* mov [ebp-0x34], eax */
            ii(0x100d_f8e3, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f8e5, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100d_f8e8, 5); call(0x100e_03fc, 0xb0f);               /* call 0x100e03fc */
            ii(0x100d_f8ed, 4); cmp(memd[ss, ebp - 0x34], 0);           /* cmp dword [ebp-0x34], 0x0 */
            ii(0x100d_f8f1, 2); if(jz(0x100d_f952, 0x5f)) goto l_0x100d_f952; /* jz 0x100df952 */
            ii(0x100d_f8f3, 3); lea(ecx, ebp - 0x38);                   /* lea ecx, [ebp-0x38] */
            ii(0x100d_f8f6, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x100d_f8fb, 5); mov(edx, StringDefinitions.Type3);      /* mov edx, 0x101a1aca */
            ii(0x100d_f900, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f903, 5); call(0x100e_0648, 0xd40);               /* call 0x100e0648 */
            ii(0x100d_f908, 5); call(0x1014_5eac, 0x6_659f);            /* call 0x10145eac */
            ii(0x100d_f90d, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f90f, 2); if(jz(0x100d_f94d, 0x3c)) goto l_0x100d_f94d; /* jz 0x100df94d */
            ii(0x100d_f911, 5); mov(ebx, StringDefinitions.Values2);    /* mov ebx, 0x101a1acf */
            ii(0x100d_f916, 3); lea(edx, ebp - 0x3c);                   /* lea edx, [ebp-0x3c] */
            ii(0x100d_f919, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f91c, 5); call(0x100e_0648, 0xd27);               /* call 0x100e0648 */
            ii(0x100d_f921, 5); call(0x1014_61ae, 0x6_6888);            /* call 0x101461ae */
            ii(0x100d_f926, 5); call(0x100e_0d98, 0x146d);              /* call 0x100e0d98 */
            ii(0x100d_f92b, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f92d, 4); movsx(eax, memw[ss, ebp - 0x38]);       /* movsx eax, word [ebp-0x38] */
            ii(0x100d_f931, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_f934, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_f936, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_f939, 3); add(eax, 0x8);                          /* add eax, 0x8 */
            ii(0x100d_f93c, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_f93e, 5); call(0x100c_b77c, -0x1_41c7);           /* call 0x100cb77c */
            ii(0x100d_f943, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f945, 3); lea(eax, ebp - 0x3c);                   /* lea eax, [ebp-0x3c] */
            ii(0x100d_f948, 5); call(0x100e_0158, 0x80b);               /* call 0x100e0158 */
        l_0x100d_f94d:
            ii(0x100d_f94d, 5); jmp(0x100d_f89f, -0xb3); goto l_0x100d_f89f; /* jmp 0x100df89f */
        l_0x100d_f952:
            ii(0x100d_f952, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f954, 3); lea(eax, ebp - 0x24);                   /* lea eax, [ebp-0x24] */
            ii(0x100d_f957, 5); call(0x100e_03fc, 0xaa0);               /* call 0x100e03fc */
        l_0x100d_f95c:
            ii(0x100d_f95c, 5); mov(ebx, StringDefinitions.CurrentValues); /* mov ebx, 0x101a1ad6 */
            ii(0x100d_f961, 3); lea(edx, ebp - 0x14);                   /* lea edx, [ebp-0x14] */
            ii(0x100d_f964, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_f967, 5); call(0x1014_625c, 0x6_68f0);            /* call 0x1014625c */
            ii(0x100d_f96c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f96e, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f971, 5); call(0x100e_06a4, 0xd2e);               /* call 0x100e06a4 */
            ii(0x100d_f976, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f978, 3); lea(eax, ebp - 0x14);                   /* lea eax, [ebp-0x14] */
            ii(0x100d_f97b, 5); call(0x100e_03fc, 0xa7c);               /* call 0x100e03fc */
            ii(0x100d_f980, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f982, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f985, 5); call(0x1013_ad71, 0x5_b3e7);            /* call 0x1013ad71 */
            ii(0x100d_f98a, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f98c, 6); if(jz(0x100d_fa64, 0xd2)) goto l_0x100d_fa64; /* jz 0x100dfa64 */
            ii(0x100d_f992, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_f996, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_f999, 5); call(0x100e_0720, 0xd82);               /* call 0x100e0720 */
            ii(0x100d_f99e, 3); mov(memd[ss, ebp - 0x44], eax);         /* mov [ebp-0x44], eax */
            ii(0x100d_f9a1, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
        l_0x100d_f9a5:
            ii(0x100d_f9a5, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_f9a7, 5); mov(ebx, StringDefinitions.Unit4);      /* mov ebx, 0x101a1ae5 */
            ii(0x100d_f9ac, 3); lea(edx, ebp - 0x48);                   /* lea edx, [ebp-0x48] */
            ii(0x100d_f9af, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_f9b2, 5); call(0x100e_0648, 0xc91);               /* call 0x100e0648 */
            ii(0x100d_f9b7, 5); call(0x1014_625c, 0x6_68a0);            /* call 0x1014625c */
            ii(0x100d_f9bc, 3); lea(ebx, ebp - 0x40);                   /* lea ebx, [ebp-0x40] */
            ii(0x100d_f9bf, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_f9c1, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_f9c3, 5); call(0x100e_06a4, 0xcdc);               /* call 0x100e06a4 */
            ii(0x100d_f9c8, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100d_f9ca, 5); call(0x1013_ad71, 0x5_b3a2);            /* call 0x1013ad71 */
            ii(0x100d_f9cf, 2); test(al, al);                           /* test al, al */
            ii(0x100d_f9d1, 2); if(jz(0x100d_f9dc, 0x9)) goto l_0x100d_f9dc; /* jz 0x100df9dc */
            ii(0x100d_f9d3, 7); mov(memd[ss, ebp - 0x4c], 0x1);         /* mov dword [ebp-0x4c], 0x1 */
            ii(0x100d_f9da, 2); jmp(0x100d_f9e3, 0x7); goto l_0x100d_f9e3; /* jmp 0x100df9e3 */
        l_0x100d_f9dc:
            ii(0x100d_f9dc, 7); mov(memd[ss, ebp - 0x4c], 0);           /* mov dword [ebp-0x4c], 0x0 */
        l_0x100d_f9e3:
            ii(0x100d_f9e3, 3); mov(eax, memd[ss, ebp - 0x4c]);         /* mov eax, [ebp-0x4c] */
            ii(0x100d_f9e6, 3); mov(memd[ss, ebp - 0x50], eax);         /* mov [ebp-0x50], eax */
            ii(0x100d_f9e9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_f9eb, 3); lea(eax, ebp - 0x48);                   /* lea eax, [ebp-0x48] */
            ii(0x100d_f9ee, 5); call(0x100e_03fc, 0xa09);               /* call 0x100e03fc */
            ii(0x100d_f9f3, 4); cmp(memd[ss, ebp - 0x50], 0);           /* cmp dword [ebp-0x50], 0x0 */
            ii(0x100d_f9f7, 2); if(jz(0x100d_fa5a, 0x61)) goto l_0x100d_fa5a; /* jz 0x100dfa5a */
            ii(0x100d_f9f9, 3); lea(ecx, ebp - 0x54);                   /* lea ecx, [ebp-0x54] */
            ii(0x100d_f9fc, 5); mov(ebx, 0x101c_7140);                  /* mov ebx, 0x101c7140 */
            ii(0x100d_fa01, 5); mov(edx, StringDefinitions.Type2);      /* mov edx, 0x101a1aea */
            ii(0x100d_fa06, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_fa09, 5); call(0x100e_0648, 0xc3a);               /* call 0x100e0648 */
            ii(0x100d_fa0e, 5); call(0x1014_5eac, 0x6_6499);            /* call 0x10145eac */
            ii(0x100d_fa13, 2); test(al, al);                           /* test al, al */
            ii(0x100d_fa15, 2); if(jz(0x100d_fa55, 0x3e)) goto l_0x100d_fa55; /* jz 0x100dfa55 */
            ii(0x100d_fa17, 5); mov(ebx, StringDefinitions.Values);     /* mov ebx, 0x101a1aef */
            ii(0x100d_fa1c, 3); lea(edx, ebp - 0x58);                   /* lea edx, [ebp-0x58] */
            ii(0x100d_fa1f, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_fa22, 5); call(0x100e_0648, 0xc21);               /* call 0x100e0648 */
            ii(0x100d_fa27, 5); call(0x1014_61ae, 0x6_6782);            /* call 0x101461ae */
            ii(0x100d_fa2c, 5); call(0x100e_0d98, 0x1367);              /* call 0x100e0d98 */
            ii(0x100d_fa31, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fa33, 4); movsx(eax, memw[ss, ebp - 0x54]);       /* movsx eax, word [ebp-0x54] */
            ii(0x100d_fa37, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x100d_fa3a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100d_fa3c, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_fa3f, 5); add(eax, 0x17c);                        /* add eax, 0x17c */
            ii(0x100d_fa44, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x100d_fa46, 5); call(0x100c_b77c, -0x1_42cf);           /* call 0x100cb77c */
            ii(0x100d_fa4b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fa4d, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100d_fa50, 5); call(0x100e_0158, 0x703);               /* call 0x100e0158 */
        l_0x100d_fa55:
            ii(0x100d_fa55, 5); jmp(0x100d_f9a5, -0xb5); goto l_0x100d_f9a5; /* jmp 0x100df9a5 */
        l_0x100d_fa5a:
            ii(0x100d_fa5a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fa5c, 3); lea(eax, ebp - 0x40);                   /* lea eax, [ebp-0x40] */
            ii(0x100d_fa5f, 5); call(0x100e_03fc, 0x998);               /* call 0x100e03fc */
        l_0x100d_fa64:
            ii(0x100d_fa64, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_fa67, 5); add(eax, 0x114);                        /* add eax, 0x114 */
            ii(0x100d_fa6c, 5); call(0x1007_6730, -0x6_9341);           /* call 0x10076730 */
            ii(0x100d_fa71, 4); mov(memb[ds, eax + 0x16], 0);           /* mov byte [eax+0x16], 0x0 */
            ii(0x100d_fa75, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_fa78, 5); add(eax, 0x288);                        /* add eax, 0x288 */
            ii(0x100d_fa7d, 5); call(0x1007_6730, -0x6_9352);           /* call 0x10076730 */
            ii(0x100d_fa82, 4); mov(memb[ds, eax + 0x16], 0);           /* mov byte [eax+0x16], 0x0 */
            ii(0x100d_fa86, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_fa89, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_fa8e, 5); call(0x1013_a6f4, 0x5_ac61);            /* call 0x1013a6f4 */
            ii(0x100d_fa93, 5); mov(ebx, StringDefinitions.Complexes);  /* mov ebx, 0x101a1af6 */
            ii(0x100d_fa98, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x100d_fa9b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_fa9e, 5); call(0x1014_625c, 0x6_67b9);            /* call 0x1014625c */
            ii(0x100d_faa3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_faa5, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_faa8, 5); call(0x100e_06a4, 0xbf7);               /* call 0x100e06a4 */
            ii(0x100d_faad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_faaf, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100d_fab2, 5); call(0x100e_03fc, 0x945);               /* call 0x100e03fc */
            ii(0x100d_fab7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fab9, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_fabc, 5); call(0x1013_ad71, 0x5_b2b0);            /* call 0x1013ad71 */
            ii(0x100d_fac1, 2); test(al, al);                           /* test al, al */
            ii(0x100d_fac3, 6); if(jz(0x100d_fb62, 0x99)) goto l_0x100d_fb62; /* jz 0x100dfb62 */
            ii(0x100d_fac9, 4); or(memb[ss, ebp - 0xc], 0x1);           /* or byte [ebp-0xc], 0x1 */
            ii(0x100d_facd, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100d_fad0, 5); call(0x100e_0838, 0xd63);               /* call 0x100e0838 */
            ii(0x100d_fad5, 3); mov(memd[ss, ebp - 0x60], eax);         /* mov [ebp-0x60], eax */
            ii(0x100d_fad8, 4); and(memb[ss, ebp - 0xc], -0x2 /* 0xfe */); /* and byte [ebp-0xc], 0xfe */
        l_0x100d_fadc:
            ii(0x100d_fadc, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x100d_fade, 5); mov(ebx, StringDefinitions.Complex2);   /* mov ebx, 0x101a1b00 */
            ii(0x100d_fae3, 3); lea(edx, ebp - 0x64);                   /* lea edx, [ebp-0x64] */
            ii(0x100d_fae6, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_fae9, 5); call(0x100e_0648, 0xb5a);               /* call 0x100e0648 */
            ii(0x100d_faee, 5); call(0x1014_630a, 0x6_6817);            /* call 0x1014630a */
            ii(0x100d_faf3, 3); lea(ebx, ebp - 0x5c);                   /* lea ebx, [ebp-0x5c] */
            ii(0x100d_faf6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_faf8, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_fafa, 5); call(0x100e_07bc, 0xcbd);               /* call 0x100e07bc */
            ii(0x100d_faff, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x100d_fb01, 5); call(0x1013_ad71, 0x5_b26b);            /* call 0x1013ad71 */
            ii(0x100d_fb06, 2); test(al, al);                           /* test al, al */
            ii(0x100d_fb08, 2); if(jz(0x100d_fb13, 0x9)) goto l_0x100d_fb13; /* jz 0x100dfb13 */
            ii(0x100d_fb0a, 7); mov(memd[ss, ebp - 0x68], 0x1);         /* mov dword [ebp-0x68], 0x1 */
            ii(0x100d_fb11, 2); jmp(0x100d_fb1a, 0x7); goto l_0x100d_fb1a; /* jmp 0x100dfb1a */
        l_0x100d_fb13:
            ii(0x100d_fb13, 7); mov(memd[ss, ebp - 0x68], 0);           /* mov dword [ebp-0x68], 0x0 */
        l_0x100d_fb1a:
            ii(0x100d_fb1a, 3); mov(eax, memd[ss, ebp - 0x68]);         /* mov eax, [ebp-0x68] */
            ii(0x100d_fb1d, 3); mov(memd[ss, ebp - 0x6c], eax);         /* mov [ebp-0x6c], eax */
            ii(0x100d_fb20, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fb22, 3); lea(eax, ebp - 0x64);                   /* lea eax, [ebp-0x64] */
            ii(0x100d_fb25, 5); call(0x100e_03bc, 0x892);               /* call 0x100e03bc */
            ii(0x100d_fb2a, 4); cmp(memd[ss, ebp - 0x6c], 0);           /* cmp dword [ebp-0x6c], 0x0 */
            ii(0x100d_fb2e, 2); if(jz(0x100d_fb58, 0x28)) goto l_0x100d_fb58; /* jz 0x100dfb58 */
            ii(0x100d_fb30, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100d_fb33, 5); call(0x100e_0760, 0xc28);               /* call 0x100e0760 */
            ii(0x100d_fb38, 3); mov(memd[ss, ebp - 0x70], eax);         /* mov [ebp-0x70], eax */
            ii(0x100d_fb3b, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x100d_fb3e, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x100d_fb41, 3); mov(eax, memd[ss, ebp - 0x70]);         /* mov eax, [ebp-0x70] */
            ii(0x100d_fb44, 3); call_abs(memd[ds, edx + 0x10]);         /* call dword [edx+0x10] */
            ii(0x100d_fb47, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fb49, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_fb4c, 5); add(eax, 0x2f0);                        /* add eax, 0x2f0 */
            ii(0x100d_fb51, 5); call(0x100e_0cc0, 0x116a);              /* call 0x100e0cc0 */
            ii(0x100d_fb56, 2); jmp(0x100d_fadc, -0x7c); goto l_0x100d_fadc; /* jmp 0x100dfadc */
        l_0x100d_fb58:
            ii(0x100d_fb58, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fb5a, 3); lea(eax, ebp - 0x5c);                   /* lea eax, [ebp-0x5c] */
            ii(0x100d_fb5d, 5); call(0x100e_03bc, 0x85a);               /* call 0x100e03bc */
        l_0x100d_fb62:
            ii(0x100d_fb62, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fb64, 3); lea(eax, ebp - 0x20);                   /* lea eax, [ebp-0x20] */
            ii(0x100d_fb67, 5); call(0x100e_03fc, 0x890);               /* call 0x100e03fc */
            ii(0x100d_fb6c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_fb6e, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_fb6f, 1); pop(edi);                               /* pop edi */
            ii(0x100d_fb70, 1); pop(esi);                               /* pop esi */
            ii(0x100d_fb71, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_fb72, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_fb73, 1); ret();                                  /* ret */
        }
    }
}

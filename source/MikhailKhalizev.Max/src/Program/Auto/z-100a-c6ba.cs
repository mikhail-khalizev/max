using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_c6ba-275f53db")]
        public void Method_100a_c6ba()
        {
            ii(0x100a_c6ba, 5); push(0x50);                             /* push 0x50 */
            ii(0x100a_c6bf, 5); call(Definitions.sys_check_available_stack_size, 0xb_968e); /* call 0x10165d52 */
            ii(0x100a_c6c4, 1); push(ebx);                              /* push ebx */
            ii(0x100a_c6c5, 1); push(ecx);                              /* push ecx */
            ii(0x100a_c6c6, 1); push(edx);                              /* push edx */
            ii(0x100a_c6c7, 1); push(esi);                              /* push esi */
            ii(0x100a_c6c8, 1); push(edi);                              /* push edi */
            ii(0x100a_c6c9, 1); push(ebp);                              /* push ebp */
            ii(0x100a_c6ca, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_c6cc, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x100a_c6d2, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_c6d5, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_c6d9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_c6dc, 3); add(edx, 0x28);                         /* add edx, 0x28 */
            ii(0x100a_c6df, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_c6e2, 5); call(0x1007_5e64, -0x3_6883);           /* call 0x10075e64 */
            ii(0x100a_c6e7, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x100a_c6ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c6ef, 1); push(eax);                              /* push eax */
            ii(0x100a_c6f0, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x100a_c6f6, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100a_c6f9, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100a_c6fb, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_c6fd, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100a_c700, 5); call(0x1008_b148, -0x2_15bd);           /* call 0x1008b148 */
            ii(0x100a_c705, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100a_c70a, 1); push(eax);                              /* push eax */
            ii(0x100a_c70b, 4); movsx(ecx, memw[ss, ebp - 0x1a]);       /* movsx ecx, word [ebp-0x1a] */
            ii(0x100a_c70f, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x100a_c713, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c716, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x100a_c719, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_c71c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c71f, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c722, 5); call(0x1007_6574, -0x3_61b3);           /* call 0x10076574 */
            ii(0x100a_c727, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_c72a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c72d, 5); call(0x1007_02b9, -0x3_c479);           /* call 0x100702b9 */
            ii(0x100a_c732, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_c735, 2); if(jz(0x100a_c762, 0x2b)) goto l_0x100a_c762; /* jz 0x100ac762 */
            ii(0x100a_c737, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100a_c73c, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100a_c741, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100a_c744, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100a_c747, 5); call(0x1007_5e64, -0x3_68e8);           /* call 0x10075e64 */
            ii(0x100a_c74c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_c74e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c751, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c754, 5); call(0x1008_abbc, -0x2_1b9d);           /* call 0x1008abbc */
            ii(0x100a_c759, 5); call(0x100a_90f9, -0x3665);             /* call 0x100a90f9 */
            ii(0x100a_c75e, 2); test(al, al);                           /* test al, al */
            ii(0x100a_c760, 2); if(jz(0x100a_c764, 0x2)) goto l_0x100a_c764; /* jz 0x100ac764 */
        l_0x100a_c762:
            ii(0x100a_c762, 2); jmp(0x100a_c77a, 0x16); goto l_0x100a_c77a; /* jmp 0x100ac77a */
        l_0x100a_c764:
            ii(0x100a_c764, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_c767, 3); add(edx, 0x28);                         /* add edx, 0x28 */
            ii(0x100a_c76a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c76d, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x100a_c770, 5); call(0x1008_8b44, -0x2_3c31);           /* call 0x10088b44 */
            ii(0x100a_c775, 5); jmp(0x100a_c895, 0x11b); goto l_0x100a_c895; /* jmp 0x100ac895 */
        l_0x100a_c77a:
            ii(0x100a_c77a, 7); mov(memd[ss, ebp - 0x14], 0x2);         /* mov dword [ebp-0x14], 0x2 */
            ii(0x100a_c781, 2); jmp(0x100a_c787, 0x4); goto l_0x100a_c787; /* jmp 0x100ac787 */
        l_0x100a_c783:
            ii(0x100a_c783, 4); add(memd[ss, ebp - 0x14], 0x2);         /* add dword [ebp-0x14], 0x2 */
        l_0x100a_c787:
            ii(0x100a_c787, 4); cmp(memb[ss, ebp - 0x8], 0);            /* cmp byte [ebp-0x8], 0x0 */
            ii(0x100a_c78b, 6); if(jz(0x100a_c895, 0x104)) goto l_0x100a_c895; /* jz 0x100ac895 */
            ii(0x100a_c791, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_c794, 4); dec(memw[ss, ebp - 0x1c]);              /* dec word [ebp-0x1c] */
            ii(0x100a_c798, 3); mov(eax, memd[ss, ebp - 0x1a]);         /* mov eax, [ebp-0x1a] */
            ii(0x100a_c79b, 4); inc(memw[ss, ebp - 0x1a]);              /* inc word [ebp-0x1a] */
            ii(0x100a_c79f, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x100a_c7a3, 7); mov(memd[ss, ebp - 0xc], 0);            /* mov dword [ebp-0xc], 0x0 */
            ii(0x100a_c7aa, 2); jmp(0x100a_c7b0, 0x4); goto l_0x100a_c7b0; /* jmp 0x100ac7b0 */
        l_0x100a_c7ac:
            ii(0x100a_c7ac, 4); add(memd[ss, ebp - 0xc], 0x2);          /* add dword [ebp-0xc], 0x2 */
        l_0x100a_c7b0:
            ii(0x100a_c7b0, 4); movsx(eax, memw[ss, ebp - 0xc]);        /* movsx eax, word [ebp-0xc] */
            ii(0x100a_c7b4, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x100a_c7b7, 6); if(jge(0x100a_c890, 0xd3)) goto l_0x100a_c890; /* jge 0x100ac890 */
            ii(0x100a_c7bd, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x100a_c7c4, 2); jmp(0x100a_c7cc, 0x6); goto l_0x100a_c7cc; /* jmp 0x100ac7cc */
        l_0x100a_c7c6:
            ii(0x100a_c7c6, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_c7c9, 3); inc(memd[ss, ebp - 0x10]);              /* inc dword [ebp-0x10] */
        l_0x100a_c7cc:
            ii(0x100a_c7cc, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_c7cf, 4); cmp(ax, memw[ss, ebp - 0x14]);          /* cmp ax, [ebp-0x14] */
            ii(0x100a_c7d3, 6); if(jge(0x100a_c88b, 0xb2)) goto l_0x100a_c88b; /* jge 0x100ac88b */
            ii(0x100a_c7d9, 4); movsx(edx, memw[ss, ebp - 0xc]);        /* movsx edx, word [ebp-0xc] */
            ii(0x100a_c7dd, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100a_c7e0, 5); mov(eax, 0x101c_5348);                  /* mov eax, 0x101c5348 */
            ii(0x100a_c7e5, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100a_c7e7, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100a_c7ea, 5); call(0x1008_b1a4, -0x2_164b);           /* call 0x1008b1a4 */
            ii(0x100a_c7ef, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100a_c7f2, 3); lea(eax, ebp - 0x2c);                   /* lea eax, [ebp-0x2c] */
            ii(0x100a_c7f5, 5); call(0x1010_82ce, 0x5_bad4);            /* call 0x101082ce */
            ii(0x100a_c7fa, 2); test(al, al);                           /* test al, al */
            ii(0x100a_c7fc, 6); if(jz(0x100a_c886, 0x84)) goto l_0x100a_c886; /* jz 0x100ac886 */
            ii(0x100a_c802, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x100a_c806, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100a_c80b, 1); push(eax);                              /* push eax */
            ii(0x100a_c80c, 4); movsx(ecx, memw[ss, ebp - 0x1a]);       /* movsx ecx, word [ebp-0x1a] */
            ii(0x100a_c810, 4); movsx(ebx, memw[ss, ebp - 0x1c]);       /* movsx ebx, word [ebp-0x1c] */
            ii(0x100a_c814, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c817, 3); mov(edx, memd[ds, eax + 0x7]);          /* mov edx, [eax+0x7] */
            ii(0x100a_c81a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100a_c81d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c820, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c823, 5); call(0x1007_6574, -0x3_62b4);           /* call 0x10076574 */
            ii(0x100a_c828, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x100a_c82b, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100a_c82e, 5); call(0x1007_02b9, -0x3_c57a);           /* call 0x100702b9 */
            ii(0x100a_c833, 3); test(ax, ax);                           /* test ax, ax */
            ii(0x100a_c836, 2); if(jz(0x100a_c863, 0x2b)) goto l_0x100a_c863; /* jz 0x100ac863 */
            ii(0x100a_c838, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x100a_c83d, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x100a_c842, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100a_c845, 3); lea(eax, ebp - 0x30);                   /* lea eax, [ebp-0x30] */
            ii(0x100a_c848, 5); call(0x1007_5e64, -0x3_69e9);           /* call 0x10075e64 */
            ii(0x100a_c84d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100a_c84f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c852, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100a_c855, 5); call(0x1008_abbc, -0x2_1c9e);           /* call 0x1008abbc */
            ii(0x100a_c85a, 5); call(0x100a_90f9, -0x3766);             /* call 0x100a90f9 */
            ii(0x100a_c85f, 2); test(al, al);                           /* test al, al */
            ii(0x100a_c861, 2); if(jz(0x100a_c865, 0x2)) goto l_0x100a_c865; /* jz 0x100ac865 */
        l_0x100a_c863:
            ii(0x100a_c863, 2); jmp(0x100a_c886, 0x21); goto l_0x100a_c886; /* jmp 0x100ac886 */
        l_0x100a_c865:
            ii(0x100a_c865, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100a_c868, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c86b, 3); add(eax, 0x28);                         /* add eax, 0x28 */
            ii(0x100a_c86e, 5); call(0x1008_8b44, -0x2_3d2f);           /* call 0x10088b44 */
            ii(0x100a_c873, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_c876, 3); add(edx, 0x28);                         /* add edx, 0x28 */
            ii(0x100a_c879, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_c87c, 3); add(eax, 0x22);                         /* add eax, 0x22 */
            ii(0x100a_c87f, 5); call(0x1008_8b44, -0x2_3d40);           /* call 0x10088b44 */
            ii(0x100a_c884, 2); jmp(0x100a_c895, 0xf); goto l_0x100a_c895; /* jmp 0x100ac895 */
        l_0x100a_c886:
            ii(0x100a_c886, 5); jmp(0x100a_c7c6, -0xc5); goto l_0x100a_c7c6; /* jmp 0x100ac7c6 */
        l_0x100a_c88b:
            ii(0x100a_c88b, 5); jmp(0x100a_c7ac, -0xe4); goto l_0x100a_c7ac; /* jmp 0x100ac7ac */
        l_0x100a_c890:
            ii(0x100a_c890, 5); jmp(0x100a_c783, -0x112); goto l_0x100a_c783; /* jmp 0x100ac783 */
        l_0x100a_c895:
            ii(0x100a_c895, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_c897, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_c898, 1); pop(edi);                               /* pop edi */
            ii(0x100a_c899, 1); pop(esi);                               /* pop esi */
            ii(0x100a_c89a, 1); pop(edx);                               /* pop edx */
            ii(0x100a_c89b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_c89c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_c89d, 1); ret();                                  /* ret */
        }
    }
}

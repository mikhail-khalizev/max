using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e446-f8445e6b")]
        public void Method_1007_e446()
        {
            ii(0x1007_e446, 5); push(0x44);                             /* push 0x44 */
            ii(0x1007_e44b, 5); call(Definitions.sys_check_available_stack_size, 0xe_7902); /* call 0x10165d52 */
            ii(0x1007_e450, 1); push(esi);                              /* push esi */
            ii(0x1007_e451, 1); push(edi);                              /* push edi */
            ii(0x1007_e452, 1); push(ebp);                              /* push ebp */
            ii(0x1007_e453, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e455, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1007_e45b, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1007_e45e, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1007_e461, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1007_e464, 3); mov(memd[ss, ebp - 8], ecx);            /* mov [ebp-0x8], ecx */
            ii(0x1007_e467, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x1007_e46c, 5); call(0x1007_6338, -0x8139);             /* call 0x10076338 */
            ii(0x1007_e471, 3); lea(ecx, memd[ss, ebp - 20]);           /* lea ecx, [ebp-0x14] */
            ii(0x1007_e474, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_e476, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1007_e478, 5); call(0x1007_64b8, -0x7fc5);             /* call 0x100764b8 */
            ii(0x1007_e47d, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1007_e480, 5); call(Definitions.my_ctor_0x101b_4184, -0x7995); /* call 0x10076af0 */
            ii(0x1007_e485, 5); mov(eax, memd[ds, 0x101c_8172]);        /* mov eax, [0x101c8172] */
            ii(0x1007_e48a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e48d, 1); push(eax);                              /* push eax */
            ii(0x1007_e48e, 6); mov(ecx, memd[ds, 0x101c_8170]);        /* mov ecx, [0x101c8170] */
            ii(0x1007_e494, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1007_e497, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_e499, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e49b, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_e49e, 5); call(0x1008_b148, 0xcca5);              /* call 0x1008b148 */
            ii(0x1007_e4a3, 2); jmp(0x1007_e4ad, 8); goto l_0x1007_e4ad; /* jmp 0x1007e4ad */
        l_0x1007_e4a5:
            ii(0x1007_e4a5, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e4a8, 5); call(0x1007_6bf8, -0x78b5);             /* call 0x10076bf8 */
        l_0x1007_e4ad:
            ii(0x1007_e4ad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e4af, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e4b2, 5); call(0x1013_ad71, 0xb_c8ba);            /* call 0x1013ad71 */
            ii(0x1007_e4b7, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e4b9, 6); if(jz(0x1007_e5bc, 0xfd)) goto l_0x1007_e5bc; /* jz 0x1007e5bc */
            ii(0x1007_e4bf, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e4c2, 5); call(0x1007_63a0, -0x8127);             /* call 0x100763a0 */
            ii(0x1007_e4c7, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e4c9, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1007_e4cc, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1007_e4cf, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1007_e4d2, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e4d5, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_e4d7, 2); if(jnz(0x1007_e4eb, 0x12)) goto l_0x1007_e4eb; /* jnz 0x1007e4eb */
            ii(0x1007_e4d9, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e4dc, 5); call(0x1007_63a0, -0x8141);             /* call 0x100763a0 */
            ii(0x1007_e4e1, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1007_e4e5, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1007_e4e9, 2); if(jz(0x1007_e4f0, 5)) goto l_0x1007_e4f0; /* jz 0x1007e4f0 */
        l_0x1007_e4eb:
            ii(0x1007_e4eb, 5); jmp(0x1007_e5b7, 0xc7); goto l_0x1007_e5b7; /* jmp 0x1007e5b7 */
        l_0x1007_e4f0:
            ii(0x1007_e4f0, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e4f3, 5); call(0x1007_63a0, -0x8158);             /* call 0x100763a0 */
            ii(0x1007_e4f8, 4); mov(ax, memw[ds, eax + 26]);            /* mov ax, [eax+0x1a] */
            ii(0x1007_e4fc, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1007_e4ff, 4); mov(memw[ss, ebp - 24], ax);            /* mov [ebp-0x18], ax */
            ii(0x1007_e503, 2); jmp(0x1007_e50c, 7); goto l_0x1007_e50c; /* jmp 0x1007e50c */
        l_0x1007_e505:
            ii(0x1007_e505, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1007_e508, 4); inc(memw[ss, ebp - 24]);                /* inc word [ebp-0x18] */
        l_0x1007_e50c:
            ii(0x1007_e50c, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e50f, 5); call(0x1007_63a0, -0x8174);             /* call 0x100763a0 */
            ii(0x1007_e514, 3); mov(eax, memd[ds, eax + 24]);           /* mov eax, [eax+0x18] */
            ii(0x1007_e517, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e51a, 4); movsx(edx, memw[ss, ebp - 24]);         /* movsx edx, word [ebp-0x18] */
            ii(0x1007_e51e, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1007_e521, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_e523, 6); if(jg(0x1007_e5b7, 0x8e)) goto l_0x1007_e5b7; /* jg 0x1007e5b7 */
            ii(0x1007_e529, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e52c, 5); call(0x1007_63a0, -0x8191);             /* call 0x100763a0 */
            ii(0x1007_e531, 4); mov(ax, memw[ds, eax + 28]);            /* mov ax, [eax+0x1c] */
            ii(0x1007_e535, 3); sub(eax, 2);                            /* sub eax, 0x2 */
            ii(0x1007_e538, 4); mov(memw[ss, ebp - 22], ax);            /* mov [ebp-0x16], ax */
            ii(0x1007_e53c, 2); jmp(0x1007_e545, 7); goto l_0x1007_e545; /* jmp 0x1007e545 */
        l_0x1007_e53e:
            ii(0x1007_e53e, 3); mov(eax, memd[ss, ebp - 22]);           /* mov eax, [ebp-0x16] */
            ii(0x1007_e541, 4); inc(memw[ss, ebp - 22]);                /* inc word [ebp-0x16] */
        l_0x1007_e545:
            ii(0x1007_e545, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e548, 5); call(0x1007_63a0, -0x81ad);             /* call 0x100763a0 */
            ii(0x1007_e54d, 3); mov(eax, memd[ds, eax + 26]);           /* mov eax, [eax+0x1a] */
            ii(0x1007_e550, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_e553, 4); movsx(edx, memw[ss, ebp - 22]);         /* movsx edx, word [ebp-0x16] */
            ii(0x1007_e557, 3); add(eax, 2);                            /* add eax, 0x2 */
            ii(0x1007_e55a, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_e55c, 2); if(jg(0x1007_e5b2, 0x54)) goto l_0x1007_e5b2; /* jg 0x1007e5b2 */
            ii(0x1007_e55e, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x1007_e561, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_e564, 5); call(0x1010_82ce, 0x8_9d65);            /* call 0x101082ce */
            ii(0x1007_e569, 2); test(al, al);                           /* test al, al */
            ii(0x1007_e56b, 2); if(jz(0x1007_e5b0, 0x43)) goto l_0x1007_e5b0; /* jz 0x1007e5b0 */
            ii(0x1007_e56d, 3); lea(edx, memd[ss, ebp - 24]);           /* lea edx, [ebp-0x18] */
            ii(0x1007_e570, 3); lea(eax, memd[ss, ebp - 44]);           /* lea eax, [ebp-0x2c] */
            ii(0x1007_e573, 5); call(0x1007_5e64, -0x8714);             /* call 0x10075e64 */
            ii(0x1007_e578, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_e57a, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_e57d, 3); lea(eax, memd[ss, ebp - 48]);           /* lea eax, [ebp-0x30] */
            ii(0x1007_e580, 5); call(0x1007_5e64, -0x8721);             /* call 0x10075e64 */
            ii(0x1007_e585, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1007_e587, 5); call(0x100a_5fca, 0x2_7a3e);            /* call 0x100a5fca */
            ii(0x1007_e58c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_e58f, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_e591, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_e594, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_e596, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_e598, 2); or(al, 0x80);                           /* or al, 0x80 */
            ii(0x1007_e59a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_e59c, 4); movsx(eax, memw[ss, ebp - 24]);         /* movsx eax, word [ebp-0x18] */
            ii(0x1007_e5a0, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_e5a3, 3); add(eax, memd[ss, ebp - 12]);           /* add eax, [ebp-0xc] */
            ii(0x1007_e5a6, 4); movsx(edx, memw[ss, ebp - 22]);         /* movsx edx, word [ebp-0x16] */
            ii(0x1007_e5aa, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_e5ac, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_e5ae, 2); mov(memb[ds, eax], bl);                 /* mov [eax], bl */
        l_0x1007_e5b0:
            ii(0x1007_e5b0, 2); jmp(0x1007_e53e, -0x74); goto l_0x1007_e53e; /* jmp 0x1007e53e */
        l_0x1007_e5b2:
            ii(0x1007_e5b2, 5); jmp(0x1007_e505, -0xb2); goto l_0x1007_e505; /* jmp 0x1007e505 */
        l_0x1007_e5b7:
            ii(0x1007_e5b7, 5); jmp(0x1007_e4a5, -0x117); goto l_0x1007_e4a5; /* jmp 0x1007e4a5 */
        l_0x1007_e5bc:
            ii(0x1007_e5bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_e5be, 3); lea(eax, memd[ss, ebp - 20]);           /* lea eax, [ebp-0x14] */
            ii(0x1007_e5c1, 5); call(0x1007_5f6c, -0x865a);             /* call 0x10075f6c */
            ii(0x1007_e5c6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e5c8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_e5c9, 1); pop(edi);                               /* pop edi */
            ii(0x1007_e5ca, 1); pop(esi);                               /* pop esi */
            ii(0x1007_e5cb, 1); ret();                                  /* ret */
        }
    }
}

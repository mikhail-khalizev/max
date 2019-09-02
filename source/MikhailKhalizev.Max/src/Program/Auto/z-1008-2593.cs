using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_2593-ad7ca58a")]
        public void Method_1008_2593()
        {
            ii(0x1008_2593, 5); push(0x3c);                             /* push 0x3c */
            ii(0x1008_2598, 5); call(Definitions.sys_check_available_stack_size, 0xe_37b5); /* call 0x10165d52 */
            ii(0x1008_259d, 1); push(ecx);                              /* push ecx */
            ii(0x1008_259e, 1); push(esi);                              /* push esi */
            ii(0x1008_259f, 1); push(edi);                              /* push edi */
            ii(0x1008_25a0, 1); push(ebp);                              /* push ebp */
            ii(0x1008_25a1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_25a3, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x1008_25a9, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_25ac, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1008_25af, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1008_25b2, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1008_25b6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_25b9, 3); mov(eax, memd[ds, eax + 7]);            /* mov eax, [eax+0x7] */
            ii(0x1008_25bc, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_25bf, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x1008_25c5, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1008_25ca, 2); add(eax, ebx);                          /* add eax, ebx */
            ii(0x1008_25cc, 5); call(0x100d_fd2c, 0x5_d75b);            /* call 0x100dfd2c */
            ii(0x1008_25d1, 4); mov(ax, memw[ds, eax + 23]);            /* mov ax, [eax+0x17] */
            ii(0x1008_25d5, 4); cmp(ax, memw[ss, ebp - 4]);             /* cmp ax, [ebp-0x4] */
            ii(0x1008_25d9, 2); if(jge(0x1008_25e4, 9)) goto l_0x1008_25e4; /* jge 0x100825e4 */
            ii(0x1008_25db, 4); mov(memb[ss, ebp - 16], 0);             /* mov byte [ebp-0x10], 0x0 */
            ii(0x1008_25df, 5); jmp(0x1008_26f6, 0x112); goto l_0x1008_26f6; /* jmp 0x100826f6 */
        l_0x1008_25e4:
            ii(0x1008_25e4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_25e6, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_25e9, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_25ec, 5); call(0x1013_ad71, 0xb_8780);            /* call 0x1013ad71 */
            ii(0x1008_25f1, 2); test(al, al);                           /* test al, al */
            ii(0x1008_25f3, 2); if(jz(0x1008_2640, 0x4b)) goto l_0x1008_2640; /* jz 0x10082640 */
            ii(0x1008_25f5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_25f8, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_25fb, 5); call(0x1007_6574, -0xc08c);             /* call 0x10076574 */
            ii(0x1008_2600, 4); mov(ax, memw[ds, eax + 8]);             /* mov ax, [eax+0x8] */
            ii(0x1008_2604, 4); cmp(ax, memw[ss, ebp - 8]);             /* cmp ax, [ebp-0x8] */
            ii(0x1008_2608, 2); if(jnz(0x1008_2613, 9)) goto l_0x1008_2613; /* jnz 0x10082613 */
            ii(0x1008_260a, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_260e, 5); jmp(0x1008_26f6, 0xe3); goto l_0x1008_26f6; /* jmp 0x100826f6 */
        l_0x1008_2613:
            ii(0x1008_2613, 5); call(0x1008_a79c, 0x8184);              /* call 0x1008a79c */
            ii(0x1008_2618, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1008_261a, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1008_261c, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_261f, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_2622, 5); call(0x1007_65d0, -0xc057);             /* call 0x100765d0 */
            ii(0x1008_2627, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_2629, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_262e, 5); call(0x100a_53ac, 0x2_2d79);            /* call 0x100a53ac */
            ii(0x1008_2633, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_2635, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_2638, 3); add(eax, 0x3e);                         /* add eax, 0x3e */
            ii(0x1008_263b, 5); call(0x1007_6630, -0xc010);             /* call 0x10076630 */
        l_0x1008_2640:
            ii(0x1008_2640, 3); lea(edx, memd[ss, ebp - 8]);            /* lea edx, [ebp-0x8] */
            ii(0x1008_2643, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_2646, 3); add(eax, 0x42);                         /* add eax, 0x42 */
            ii(0x1008_2649, 5); call(0x1008_b268, 0x8c1a);              /* call 0x1008b268 */
            ii(0x1008_264e, 1); cwde();                                 /* cwde */
            ii(0x1008_264f, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1008_2651, 2); if(jl(0x1008_265c, 9)) goto l_0x1008_265c; /* jl 0x1008265c */
            ii(0x1008_2653, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_2657, 5); jmp(0x1008_26f6, 0x9a); goto l_0x1008_26f6; /* jmp 0x100826f6 */
        l_0x1008_265c:
            ii(0x1008_265c, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1008_2661, 5); call(Definitions.sys_new, 0xe_379a);    /* call 0x10165e00 */
            ii(0x1008_2666, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1008_2669, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_266c, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x1008_266f, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1008_2673, 2); if(jz(0x1008_2698, 0x23)) goto l_0x1008_2698; /* jz 0x10082698 */
            ii(0x1008_2675, 3); lea(edx, memd[ss, ebp - 28]);           /* lea edx, [ebp-0x1c] */
            ii(0x1008_2678, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_267b, 5); call(0x100a_2d3d, 0x2_06bd);            /* call 0x100a2d3d */
            ii(0x1008_2680, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1008_2682, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x1008_2685, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1008_2688, 5); call(Definitions.my_ctor_c12, 0x2_39df); /* call 0x100a606c */
            ii(0x1008_268d, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1008_2690, 3); mov(eax, memd[ss, ebp - 32]);           /* mov eax, [ebp-0x20] */
            ii(0x1008_2693, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
            ii(0x1008_2696, 2); jmp(0x1008_269e, 6); goto l_0x1008_269e; /* jmp 0x1008269e */
        l_0x1008_2698:
            ii(0x1008_2698, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1008_269b, 3); mov(memd[ss, ebp - 36], eax);           /* mov [ebp-0x24], eax */
        l_0x1008_269e:
            ii(0x1008_269e, 3); mov(edx, memd[ss, ebp - 36]);           /* mov edx, [ebp-0x24] */
            ii(0x1008_26a1, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_26a4, 5); call(0x1008_a914, 0x826b);              /* call 0x1008a914 */
            ii(0x1008_26a9, 4); movsx(edx, memw[ss, ebp - 8]);          /* movsx edx, word [ebp-0x8] */
            ii(0x1008_26ad, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_26b0, 5); call(0x1008_a7dc, 0x8127);              /* call 0x1008a7dc */
            ii(0x1008_26b5, 5); call(0x100a_63bc, 0x2_3d02);            /* call 0x100a63bc */
            ii(0x1008_26ba, 3); lea(edx, memd[ss, ebp - 8]);            /* lea edx, [ebp-0x8] */
            ii(0x1008_26bd, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_26c0, 3); add(eax, 0x42);                         /* add eax, 0x42 */
            ii(0x1008_26c3, 5); call(0x1008_b2a8, 0x8be0);              /* call 0x1008b2a8 */
            ii(0x1008_26c8, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_26cb, 5); call(0x1008_a838, 0x8168);              /* call 0x1008a838 */
            ii(0x1008_26d0, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1008_26d2, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1008_26d7, 5); call(0x100a_4d50, 0x2_2674);            /* call 0x100a4d50 */
            ii(0x1008_26dc, 4); mov(memb[ss, ebp - 16], 1);             /* mov byte [ebp-0x10], 0x1 */
            ii(0x1008_26e0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_26e2, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1008_26e5, 5); call(0x1008_8cbc, 0x65d2);              /* call 0x10088cbc */
            ii(0x1008_26ea, 2); jmp(0x1008_26f6, 0xa); goto l_0x1008_26f6; /* jmp 0x100826f6 */
        //  ii(0x1008_26ec, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1008_26ee, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
        //  ii(0x1008_26f1, 5); call(0x1008_8cbc, 0x65c6);              /* call 0x10088cbc */
        l_0x1008_26f6:
            ii(0x1008_26f6, 3); mov(al, memb[ss, ebp - 16]);            /* mov al, [ebp-0x10] */
            ii(0x1008_26f9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_26fb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_26fc, 1); pop(edi);                               /* pop edi */
            ii(0x1008_26fd, 1); pop(esi);                               /* pop esi */
            ii(0x1008_26fe, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_26ff, 1); ret();                                  /* ret */
        }
    }
}

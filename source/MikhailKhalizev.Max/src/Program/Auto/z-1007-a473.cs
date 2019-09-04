using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_a473-a23de08c")]
        public void Method_1007_a473()
        {
            ii(0x1007_a473, 5); push(0xa8);                             /* push 0xa8 */
            ii(0x1007_a478, 5); call(Definitions.sys_check_available_stack_size, 0xe_b8d5); /* call 0x10165d52 */
            ii(0x1007_a47d, 1); push(ecx);                              /* push ecx */
            ii(0x1007_a47e, 1); push(esi);                              /* push esi */
            ii(0x1007_a47f, 1); push(edi);                              /* push edi */
            ii(0x1007_a480, 1); push(ebp);                              /* push ebp */
            ii(0x1007_a481, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_a483, 6); sub(esp, 0x88);                         /* sub esp, 0x88 */
            ii(0x1007_a489, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_a48c, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1007_a48f, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1007_a492, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x1007_a497, 5); call(0x1007_6338, -0x4164);             /* call 0x10076338 */
            ii(0x1007_a49c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a49e, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a4a1, 5); call(0x1007_64b8, -0x3fee);             /* call 0x100764b8 */
            ii(0x1007_a4a6, 4); or(memb[ss, ebp - 16], 1);              /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_a4aa, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a4ad, 5); call(Definitions.my_ctor_0x101b_38f8, -0x3dc2); /* call 0x100766f0 */
            ii(0x1007_a4b2, 3); mov(memd[ss, ebp - 44], eax);           /* mov [ebp-0x2c], eax */
            ii(0x1007_a4b5, 4); and(memb[ss, ebp - 16], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_a4b9, 4); mov(memb[ss, ebp - 24], 0);             /* mov byte [ebp-0x18], 0x0 */
            ii(0x1007_a4bd, 7); mov(memd[ss, ebp - 48], 0);             /* mov dword [ebp-0x30], 0x0 */
            ii(0x1007_a4c4, 2); jmp(0x1007_a4ce, 8); goto l_0x1007_a4ce; /* jmp 0x1007a4ce */
        l_0x1007_a4c6:
            ii(0x1007_a4c6, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a4c9, 5); call(0x1007_6bf8, -0x38d6);             /* call 0x10076bf8 */
        l_0x1007_a4ce:
            ii(0x1007_a4ce, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a4d0, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a4d3, 5); call(0x1013_ad71, 0xc_0899);            /* call 0x1013ad71 */
            ii(0x1007_a4d8, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a4da, 6); if(jz(0x1007_a5a0, 0xc0)) goto l_0x1007_a5a0; /* jz 0x1007a5a0 */
            ii(0x1007_a4e0, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a4e3, 5); call(0x1007_63a0, -0x4148);             /* call 0x100763a0 */
            ii(0x1007_a4e8, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1007_a4eb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a4ee, 3); cmp(dl, memb[ds, eax + 38]);            /* cmp dl, [eax+0x26] */
            ii(0x1007_a4f1, 2); if(jnz(0x1007_a509, 0x16)) goto l_0x1007_a509; /* jnz 0x1007a509 */
            ii(0x1007_a4f3, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a4f6, 5); call(0x1007_63d4, -0x4127);             /* call 0x100763d4 */
            ii(0x1007_a4fb, 5); call(0x1007_a3b3, -0x14d);              /* call 0x1007a3b3 */
            ii(0x1007_a500, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1007_a503, 4); cmp(memd[ss, ebp - 48], 0);             /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1007_a507, 2); if(jnz(0x1007_a50b, 2)) goto l_0x1007_a50b; /* jnz 0x1007a50b */
        l_0x1007_a509:
            ii(0x1007_a509, 2); jmp(0x1007_a51f, 0x14); goto l_0x1007_a51f; /* jmp 0x1007a51f */
        l_0x1007_a50b:
            ii(0x1007_a50b, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1007_a50f, 2); if(jz(0x1007_a51d, 0xc)) goto l_0x1007_a51d; /* jz 0x1007a51d */
            ii(0x1007_a511, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a514, 5); call(0x1008_9928, 0xf40f);              /* call 0x10089928 */
            ii(0x1007_a519, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a51b, 2); if(jz(0x1007_a51f, 2)) goto l_0x1007_a51f; /* jz 0x1007a51f */
        l_0x1007_a51d:
            ii(0x1007_a51d, 2); jmp(0x1007_a521, 2); goto l_0x1007_a521; /* jmp 0x1007a521 */
        l_0x1007_a51f:
            ii(0x1007_a51f, 2); jmp(0x1007_a532, 0x11); goto l_0x1007_a532; /* jmp 0x1007a532 */
        l_0x1007_a521:
            ii(0x1007_a521, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1007_a525, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a528, 5); call(0x100a_2bc4, 0x2_8697);            /* call 0x100a2bc4 */
            ii(0x1007_a52d, 1); cwde();                                 /* cwde */
            ii(0x1007_a52e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a530, 2); if(jle(0x1007_a534, 2)) goto l_0x1007_a534; /* jle 0x1007a534 */
        l_0x1007_a532:
            ii(0x1007_a532, 2); jmp(0x1007_a59b, 0x67); goto l_0x1007_a59b; /* jmp 0x1007a59b */
        l_0x1007_a534:
            ii(0x1007_a534, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a537, 5); call(0x1007_63d4, -0x4168);             /* call 0x100763d4 */
            ii(0x1007_a53c, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1007_a53f, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a541, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_a543, 5); call(0x1007_0d01, -0x9847);             /* call 0x10070d01 */
            ii(0x1007_a548, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_a54b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a54d, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a550, 5); call(0x1013_ad11, 0xc_07bc);            /* call 0x1013ad11 */
            ii(0x1007_a555, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a557, 2); if(jnz(0x1007_a562, 9)) goto l_0x1007_a562; /* jnz 0x1007a562 */
            ii(0x1007_a559, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_a55c, 4); cmp(ax, memw[ss, ebp - 32]);            /* cmp ax, [ebp-0x20] */
            ii(0x1007_a560, 2); if(jge(0x1007_a564, 2)) goto l_0x1007_a564; /* jge 0x1007a564 */
        l_0x1007_a562:
            ii(0x1007_a562, 2); jmp(0x1007_a578, 0x14); goto l_0x1007_a578; /* jmp 0x1007a578 */
        l_0x1007_a564:
            ii(0x1007_a564, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1007_a568, 2); if(jnz(0x1007_a576, 0xc)) goto l_0x1007_a576; /* jnz 0x1007a576 */
            ii(0x1007_a56a, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a56d, 5); call(0x1008_9928, 0xf3b6);              /* call 0x10089928 */
            ii(0x1007_a572, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a574, 2); if(jnz(0x1007_a578, 2)) goto l_0x1007_a578; /* jnz 0x1007a578 */
        l_0x1007_a576:
            ii(0x1007_a576, 2); jmp(0x1007_a59b, 0x23); goto l_0x1007_a59b; /* jmp 0x1007a59b */
        l_0x1007_a578:
            ii(0x1007_a578, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_a57b, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1007_a57e, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a581, 5); call(0x1007_63d4, -0x41b2);             /* call 0x100763d4 */
            ii(0x1007_a586, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a588, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a58b, 5); call(0x1007_6630, -0x3f60);             /* call 0x10076630 */
            ii(0x1007_a590, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a593, 5); call(0x1008_9928, 0xf390);              /* call 0x10089928 */
            ii(0x1007_a598, 3); mov(memb[ss, ebp - 24], al);            /* mov [ebp-0x18], al */
        l_0x1007_a59b:
            ii(0x1007_a59b, 5); jmp(0x1007_a4c6, -0xda); goto l_0x1007_a4c6; /* jmp 0x1007a4c6 */
        l_0x1007_a5a0:
            ii(0x1007_a5a0, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x1007_a5a5, 5); call(0x1007_6338, -0x4272);             /* call 0x10076338 */
            ii(0x1007_a5aa, 3); lea(ebx, memd[ss, ebp - 36]);           /* lea ebx, [ebp-0x24] */
            ii(0x1007_a5ad, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a5af, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_a5b1, 5); call(0x1007_643c, -0x417a);             /* call 0x1007643c */
            ii(0x1007_a5b6, 2); jmp(0x1007_a5c0, 8); goto l_0x1007_a5c0; /* jmp 0x1007a5c0 */
        l_0x1007_a5b8:
            ii(0x1007_a5b8, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a5bb, 5); call(0x1007_6bf8, -0x39c8);             /* call 0x10076bf8 */
        l_0x1007_a5c0:
            ii(0x1007_a5c0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a5c2, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a5c5, 5); call(0x1013_ad71, 0xc_07a7);            /* call 0x1013ad71 */
            ii(0x1007_a5ca, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a5cc, 6); if(jz(0x1007_a692, 0xc0)) goto l_0x1007_a692; /* jz 0x1007a692 */
            ii(0x1007_a5d2, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a5d5, 5); call(0x1007_63a0, -0x423a);             /* call 0x100763a0 */
            ii(0x1007_a5da, 3); mov(dl, memb[ds, eax + 38]);            /* mov dl, [eax+0x26] */
            ii(0x1007_a5dd, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a5e0, 3); cmp(dl, memb[ds, eax + 38]);            /* cmp dl, [eax+0x26] */
            ii(0x1007_a5e3, 2); if(jnz(0x1007_a5fb, 0x16)) goto l_0x1007_a5fb; /* jnz 0x1007a5fb */
            ii(0x1007_a5e5, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a5e8, 5); call(0x1007_63d4, -0x4219);             /* call 0x100763d4 */
            ii(0x1007_a5ed, 5); call(0x1007_a3b3, -0x23f);              /* call 0x1007a3b3 */
            ii(0x1007_a5f2, 3); mov(memd[ss, ebp - 48], eax);           /* mov [ebp-0x30], eax */
            ii(0x1007_a5f5, 4); cmp(memd[ss, ebp - 48], 0);             /* cmp dword [ebp-0x30], 0x0 */
            ii(0x1007_a5f9, 2); if(jnz(0x1007_a5fd, 2)) goto l_0x1007_a5fd; /* jnz 0x1007a5fd */
        l_0x1007_a5fb:
            ii(0x1007_a5fb, 2); jmp(0x1007_a611, 0x14); goto l_0x1007_a611; /* jmp 0x1007a611 */
        l_0x1007_a5fd:
            ii(0x1007_a5fd, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1007_a601, 2); if(jz(0x1007_a60f, 0xc)) goto l_0x1007_a60f; /* jz 0x1007a60f */
            ii(0x1007_a603, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a606, 5); call(0x1008_9928, 0xf31d);              /* call 0x10089928 */
            ii(0x1007_a60b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a60d, 2); if(jz(0x1007_a611, 2)) goto l_0x1007_a611; /* jz 0x1007a611 */
        l_0x1007_a60f:
            ii(0x1007_a60f, 2); jmp(0x1007_a613, 2); goto l_0x1007_a613; /* jmp 0x1007a613 */
        l_0x1007_a611:
            ii(0x1007_a611, 2); jmp(0x1007_a624, 0x11); goto l_0x1007_a624; /* jmp 0x1007a624 */
        l_0x1007_a613:
            ii(0x1007_a613, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1007_a617, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a61a, 5); call(0x100a_2bc4, 0x2_85a5);            /* call 0x100a2bc4 */
            ii(0x1007_a61f, 1); cwde();                                 /* cwde */
            ii(0x1007_a620, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a622, 2); if(jle(0x1007_a626, 2)) goto l_0x1007_a626; /* jle 0x1007a626 */
        l_0x1007_a624:
            ii(0x1007_a624, 2); jmp(0x1007_a68d, 0x67); goto l_0x1007_a68d; /* jmp 0x1007a68d */
        l_0x1007_a626:
            ii(0x1007_a626, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a629, 5); call(0x1007_63d4, -0x425a);             /* call 0x100763d4 */
            ii(0x1007_a62e, 3); mov(ebx, memd[ss, ebp - 8]);            /* mov ebx, [ebp-0x8] */
            ii(0x1007_a631, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a633, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_a635, 5); call(0x1007_0d01, -0x9939);             /* call 0x10070d01 */
            ii(0x1007_a63a, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x1007_a63d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a63f, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a642, 5); call(0x1013_ad11, 0xc_06ca);            /* call 0x1013ad11 */
            ii(0x1007_a647, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a649, 2); if(jnz(0x1007_a654, 9)) goto l_0x1007_a654; /* jnz 0x1007a654 */
            ii(0x1007_a64b, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_a64e, 4); cmp(ax, memw[ss, ebp - 32]);            /* cmp ax, [ebp-0x20] */
            ii(0x1007_a652, 2); if(jge(0x1007_a656, 2)) goto l_0x1007_a656; /* jge 0x1007a656 */
        l_0x1007_a654:
            ii(0x1007_a654, 2); jmp(0x1007_a66a, 0x14); goto l_0x1007_a66a; /* jmp 0x1007a66a */
        l_0x1007_a656:
            ii(0x1007_a656, 4); cmp(memb[ss, ebp - 24], 0);             /* cmp byte [ebp-0x18], 0x0 */
            ii(0x1007_a65a, 2); if(jnz(0x1007_a668, 0xc)) goto l_0x1007_a668; /* jnz 0x1007a668 */
            ii(0x1007_a65c, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a65f, 5); call(0x1008_9928, 0xf2c4);              /* call 0x10089928 */
            ii(0x1007_a664, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a666, 2); if(jnz(0x1007_a66a, 2)) goto l_0x1007_a66a; /* jnz 0x1007a66a */
        l_0x1007_a668:
            ii(0x1007_a668, 2); jmp(0x1007_a68d, 0x23); goto l_0x1007_a68d; /* jmp 0x1007a68d */
        l_0x1007_a66a:
            ii(0x1007_a66a, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1007_a66d, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x1007_a670, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_a673, 5); call(0x1007_63d4, -0x42a4);             /* call 0x100763d4 */
            ii(0x1007_a678, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a67a, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a67d, 5); call(0x1007_6630, -0x4052);             /* call 0x10076630 */
            ii(0x1007_a682, 3); mov(eax, memd[ss, ebp - 48]);           /* mov eax, [ebp-0x30] */
            ii(0x1007_a685, 5); call(0x1008_9928, 0xf29e);              /* call 0x10089928 */
            ii(0x1007_a68a, 3); mov(memb[ss, ebp - 24], al);            /* mov [ebp-0x18], al */
        l_0x1007_a68d:
            ii(0x1007_a68d, 5); jmp(0x1007_a5b8, -0xda); goto l_0x1007_a5b8; /* jmp 0x1007a5b8 */
        l_0x1007_a692:
            ii(0x1007_a692, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_a694, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a697, 5); call(0x1013_ad71, 0xc_06d5);            /* call 0x1013ad71 */
            ii(0x1007_a69c, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a69e, 6); if(jz(0x1007_aa38, 0x394)) goto l_0x1007_aa38; /* jz 0x1007aa38 */
            ii(0x1007_a6a4, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1007_a6a7, 5); call(Definitions.my_ctor_0x101b_4184, -0x3bbc); /* call 0x10076af0 */
            ii(0x1007_a6ac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a6af, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_a6b2, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a6b7, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1007_a6bd, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_a6c2, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_a6c4, 5); call(0x1008_a0c8, 0xf9ff);              /* call 0x1008a0c8 */
            ii(0x1007_a6c9, 3); mov(memd[ss, ebp - 56], eax);           /* mov [ebp-0x38], eax */
            ii(0x1007_a6cc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a6cf, 3); mov(ebx, memd[ds, eax + 26]);           /* mov ebx, [eax+0x1a] */
            ii(0x1007_a6d2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_a6d5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a6d8, 3); mov(edx, memd[ds, eax + 24]);           /* mov edx, [eax+0x18] */
            ii(0x1007_a6db, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_a6de, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1007_a6e1, 5); call(0x1007_6aac, -0x3c3a);             /* call 0x10076aac */
            ii(0x1007_a6e6, 7); mov(memd[ss, ebp - 64], 0xffff_ffff);   /* mov dword [ebp-0x40], 0xffffffff */
            ii(0x1007_a6ed, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a6f0, 4); test(memb[ds, eax + 19], 1);            /* test byte [eax+0x13], 0x1 */
            ii(0x1007_a6f4, 2); if(jz(0x1007_a736, 0x40)) goto l_0x1007_a736; /* jz 0x1007a736 */
            ii(0x1007_a6f6, 5); mov(edx, 0x4e);                         /* mov edx, 0x4e */
            ii(0x1007_a6fb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a6fe, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_a701, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_a703, 1); cwde();                                 /* cwde */
            ii(0x1007_a704, 5); call(0x100b_71dc, 0x3_cad3);            /* call 0x100b71dc */
            ii(0x1007_a709, 1); cwde();                                 /* cwde */
            ii(0x1007_a70a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a70c, 2); if(jle(0x1007_a717, 9)) goto l_0x1007_a717; /* jle 0x1007a717 */
            ii(0x1007_a70e, 7); mov(memd[ss, ebp - 64], 0x4e);          /* mov dword [ebp-0x40], 0x4e */
            ii(0x1007_a715, 2); jmp(0x1007_a736, 0x1f); goto l_0x1007_a736; /* jmp 0x1007a736 */
        l_0x1007_a717:
            ii(0x1007_a717, 5); mov(edx, 0x48);                         /* mov edx, 0x48 */
            ii(0x1007_a71c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a71f, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_a722, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_a724, 1); cwde();                                 /* cwde */
            ii(0x1007_a725, 5); call(0x100b_71dc, 0x3_cab2);            /* call 0x100b71dc */
            ii(0x1007_a72a, 1); cwde();                                 /* cwde */
            ii(0x1007_a72b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a72d, 2); if(jle(0x1007_a736, 7)) goto l_0x1007_a736; /* jle 0x1007a736 */
            ii(0x1007_a72f, 7); mov(memd[ss, ebp - 64], 0x48);          /* mov dword [ebp-0x40], 0x48 */
        l_0x1007_a736:
            ii(0x1007_a736, 4); or(memb[ss, ebp - 16], 1);              /* or byte [ebp-0x10], 0x1 */
            ii(0x1007_a73a, 4); movsx(eax, memw[ss, ebp - 64]);         /* movsx eax, word [ebp-0x40] */
            ii(0x1007_a73e, 1); push(eax);                              /* push eax */
            ii(0x1007_a73f, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_a741, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1007_a746, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_a749, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1007_a74c, 5); call(0x1011_fec1, 0xa_5770);            /* call 0x1011fec1 */
            ii(0x1007_a751, 3); mov(memd[ss, ebp - 84], eax);           /* mov [ebp-0x54], eax */
            ii(0x1007_a754, 4); and(memb[ss, ebp - 16], -2 /* 0xfe */); /* and byte [ebp-0x10], 0xfe */
            ii(0x1007_a758, 5); mov(ecx, 1);                            /* mov ecx, 0x1 */
            ii(0x1007_a75d, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x1007_a762, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_a765, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a768, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_a76b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a770, 6); imul(esi, eax, 0xc5);                   /* imul esi, eax, 0xc5 */
            ii(0x1007_a776, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1007_a77b, 2); add(eax, esi);                          /* add eax, esi */
            ii(0x1007_a77d, 5); call(0x100c_1fd4, 0x4_7852);            /* call 0x100c1fd4 */
            ii(0x1007_a782, 3); mov(memd[ss, ebp - 88], eax);           /* mov [ebp-0x58], eax */
            ii(0x1007_a785, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_a788, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a78b, 5); call(0x1008_abbc, 0x1_042c);            /* call 0x1008abbc */
            ii(0x1007_a790, 5); call(0x100a_601a, 0x2_b885);            /* call 0x100a601a */
            ii(0x1007_a795, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_a798, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_a79a, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_a79d, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_a79f, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_a7a1, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
            ii(0x1007_a7a4, 3); lea(edx, memd[ss, ebp - 60]);           /* lea edx, [ebp-0x3c] */
            ii(0x1007_a7a7, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1007_a7aa, 5); call(0x1008_8b44, 0xe395);              /* call 0x10088b44 */
            ii(0x1007_a7af, 7); mov(memd[ss, ebp - 96], 1);             /* mov dword [ebp-0x60], 0x1 */
            ii(0x1007_a7b6, 2); jmp(0x1007_a7be, 6); goto l_0x1007_a7be; /* jmp 0x1007a7be */
        l_0x1007_a7b8:
            ii(0x1007_a7b8, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x1007_a7bb, 3); inc(memd[ss, ebp - 96]);                /* inc dword [ebp-0x60] */
        l_0x1007_a7be:
            ii(0x1007_a7be, 3); mov(eax, memd[ss, ebp - 96]);           /* mov eax, [ebp-0x60] */
            ii(0x1007_a7c1, 4); cmp(ax, memw[ss, ebp - 92]);            /* cmp ax, [ebp-0x5c] */
            ii(0x1007_a7c5, 6); if(jge(0x1007_a956, 0x18b)) goto l_0x1007_a956; /* jge 0x1007a956 */
            ii(0x1007_a7cb, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1007_a7ce, 4); dec(memw[ss, ebp - 60]);                /* dec word [ebp-0x3c] */
            ii(0x1007_a7d2, 3); mov(eax, memd[ss, ebp - 58]);           /* mov eax, [ebp-0x3a] */
            ii(0x1007_a7d5, 4); inc(memw[ss, ebp - 58]);                /* inc word [ebp-0x3a] */
            ii(0x1007_a7d9, 7); mov(memd[ss, ebp - 100], 0);            /* mov dword [ebp-0x64], 0x0 */
            ii(0x1007_a7e0, 2); jmp(0x1007_a7e6, 4); goto l_0x1007_a7e6; /* jmp 0x1007a7e6 */
        l_0x1007_a7e2:
            ii(0x1007_a7e2, 4); add(memd[ss, ebp - 100], 2);            /* add dword [ebp-0x64], 0x2 */
        l_0x1007_a7e6:
            ii(0x1007_a7e6, 4); movsx(eax, memw[ss, ebp - 100]);        /* movsx eax, word [ebp-0x64] */
            ii(0x1007_a7ea, 3); cmp(eax, 8);                            /* cmp eax, 0x8 */
            ii(0x1007_a7ed, 6); if(jge(0x1007_a951, 0x15e)) goto l_0x1007_a951; /* jge 0x1007a951 */
            ii(0x1007_a7f3, 7); mov(memd[ss, ebp - 104], 0);            /* mov dword [ebp-0x68], 0x0 */
            ii(0x1007_a7fa, 2); jmp(0x1007_a802, 6); goto l_0x1007_a802; /* jmp 0x1007a802 */
        l_0x1007_a7fc:
            ii(0x1007_a7fc, 3); mov(eax, memd[ss, ebp - 104]);          /* mov eax, [ebp-0x68] */
            ii(0x1007_a7ff, 3); inc(memd[ss, ebp - 104]);               /* inc dword [ebp-0x68] */
        l_0x1007_a802:
            ii(0x1007_a802, 4); movsx(eax, memw[ss, ebp - 96]);         /* movsx eax, word [ebp-0x60] */
            ii(0x1007_a806, 2); add(eax, eax);                          /* add eax, eax */
            ii(0x1007_a808, 4); movsx(edx, memw[ss, ebp - 104]);        /* movsx edx, word [ebp-0x68] */
            ii(0x1007_a80c, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_a80e, 6); if(jge(0x1007_a94c, 0x138)) goto l_0x1007_a94c; /* jge 0x1007a94c */
            ii(0x1007_a814, 4); movsx(eax, memw[ss, ebp - 100]);        /* movsx eax, word [ebp-0x64] */
            ii(0x1007_a818, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_a81b, 5); mov(edx, 0x101c_5348);                  /* mov edx, 0x101c5348 */
            ii(0x1007_a820, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1007_a822, 3); lea(eax, memd[ss, ebp - 60]);           /* lea eax, [ebp-0x3c] */
            ii(0x1007_a825, 5); call(0x1008_b1a4, 0x1_097a);            /* call 0x1008b1a4 */
            ii(0x1007_a82a, 4); movsx(eax, memw[ss, ebp - 60]);         /* movsx eax, word [ebp-0x3c] */
            ii(0x1007_a82e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a830, 2); if(jl(0x1007_a83e, 0xc)) goto l_0x1007_a83e; /* jl 0x1007a83e */
            ii(0x1007_a832, 3); mov(eax, memd[ss, ebp - 60]);           /* mov eax, [ebp-0x3c] */
            ii(0x1007_a835, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x1007_a83c, 2); if(jl(0x1007_a840, 2)) goto l_0x1007_a840; /* jl 0x1007a840 */
        l_0x1007_a83e:
            ii(0x1007_a83e, 2); jmp(0x1007_a848, 8); goto l_0x1007_a848; /* jmp 0x1007a848 */
        l_0x1007_a840:
            ii(0x1007_a840, 4); movsx(eax, memw[ss, ebp - 58]);         /* movsx eax, word [ebp-0x3a] */
            ii(0x1007_a844, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a846, 2); if(jge(0x1007_a84a, 2)) goto l_0x1007_a84a; /* jge 0x1007a84a */
        l_0x1007_a848:
            ii(0x1007_a848, 2); jmp(0x1007_a856, 0xc); goto l_0x1007_a856; /* jmp 0x1007a856 */
        l_0x1007_a84a:
            ii(0x1007_a84a, 3); mov(eax, memd[ss, ebp - 58]);           /* mov eax, [ebp-0x3a] */
            ii(0x1007_a84d, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x1007_a854, 2); if(jl(0x1007_a858, 2)) goto l_0x1007_a858; /* jl 0x1007a858 */
        l_0x1007_a856:
            ii(0x1007_a856, 2); jmp(0x1007_a886, 0x2e); goto l_0x1007_a886; /* jmp 0x1007a886 */
        l_0x1007_a858:
            ii(0x1007_a858, 4); cmp(memd[ss, ebp - 88], 0);             /* cmp dword [ebp-0x58], 0x0 */
            ii(0x1007_a85c, 2); if(jz(0x1007_a884, 0x26)) goto l_0x1007_a884; /* jz 0x1007a884 */
            ii(0x1007_a85e, 4); movsx(eax, memw[ss, ebp - 60]);         /* movsx eax, word [ebp-0x3c] */
            ii(0x1007_a862, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_a865, 3); add(eax, memd[ss, ebp - 88]);           /* add eax, [ebp-0x58] */
            ii(0x1007_a868, 4); movsx(edx, memw[ss, ebp - 58]);         /* movsx edx, word [ebp-0x3a] */
            ii(0x1007_a86c, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1007_a86e, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_a870, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_a872, 3); movsx(edx, memw[ds, eax]);              /* movsx edx, word [eax] */
            ii(0x1007_a875, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a878, 3); mov(al, memb[ds, eax + 77]);            /* mov al, [eax+0x4d] */
            ii(0x1007_a87b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_a880, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1007_a882, 2); if(jge(0x1007_a886, 2)) goto l_0x1007_a886; /* jge 0x1007a886 */
        l_0x1007_a884:
            ii(0x1007_a884, 2); jmp(0x1007_a88b, 5); goto l_0x1007_a88b; /* jmp 0x1007a88b */
        l_0x1007_a886:
            ii(0x1007_a886, 5); jmp(0x1007_a947, 0xbc); goto l_0x1007_a947; /* jmp 0x1007a947 */
        l_0x1007_a88b:
            ii(0x1007_a88b, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a88e, 5); call(0x1007_6574, -0x431f);             /* call 0x10076574 */
            ii(0x1007_a893, 3); mov(edx, memd[ss, ebp - 58]);           /* mov edx, [ebp-0x3a] */
            ii(0x1007_a896, 4); sub(dx, memw[ds, eax + 28]);            /* sub dx, [eax+0x1c] */
            ii(0x1007_a89a, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_a89c, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_a89f, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_a8a2, 5); call(0x1007_6574, -0x4333);             /* call 0x10076574 */
            ii(0x1007_a8a7, 3); mov(ebx, memd[ss, ebp - 60]);           /* mov ebx, [ebp-0x3c] */
            ii(0x1007_a8aa, 4); sub(bx, memw[ds, eax + 26]);            /* sub bx, [eax+0x1a] */
            ii(0x1007_a8ae, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1007_a8b0, 1); cwde();                                 /* cwde */
            ii(0x1007_a8b1, 5); call(0x100a_5f65, 0x2_b6af);            /* call 0x100a5f65 */
            ii(0x1007_a8b6, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_a8b9, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_a8bb, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_a8be, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x1007_a8c0, 2); sar(eax, 1);                            /* sar eax, 1 */
            ii(0x1007_a8c2, 3); mov(memd[ss, ebp - 108], eax);          /* mov [ebp-0x6c], eax */
            ii(0x1007_a8c5, 3); mov(eax, memd[ss, ebp - 108]);          /* mov eax, [ebp-0x6c] */
            ii(0x1007_a8c8, 4); cmp(ax, memw[ss, ebp - 92]);            /* cmp ax, [ebp-0x5c] */
            ii(0x1007_a8cc, 6); if(jge(0x1007_a947, 0x75)) goto l_0x1007_a947; /* jge 0x1007a947 */
            ii(0x1007_a8d2, 4); cmp(memd[ss, ebp - 56], 0);             /* cmp dword [ebp-0x38], 0x0 */
            ii(0x1007_a8d6, 2); if(jz(0x1007_a8ef, 0x17)) goto l_0x1007_a8ef; /* jz 0x1007a8ef */
            ii(0x1007_a8d8, 4); movsx(eax, memw[ss, ebp - 60]);         /* movsx eax, word [ebp-0x3c] */
            ii(0x1007_a8dc, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1007_a8df, 3); add(eax, memd[ss, ebp - 56]);           /* add eax, [ebp-0x38] */
            ii(0x1007_a8e2, 4); movsx(edx, memw[ss, ebp - 58]);         /* movsx edx, word [ebp-0x3a] */
            ii(0x1007_a8e6, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1007_a8e8, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1007_a8ea, 3); test(memb[ds, eax], 8);                 /* test byte [eax], 0x8 */
            ii(0x1007_a8ed, 2); if(jnz(0x1007_a947, 0x58)) goto l_0x1007_a947; /* jnz 0x1007a947 */
        l_0x1007_a8ef:
            ii(0x1007_a8ef, 3); lea(edx, memd[ss, ebp - 60]);           /* lea edx, [ebp-0x3c] */
            ii(0x1007_a8f2, 3); lea(eax, memd[ss, ebp - 112]);          /* lea eax, [ebp-0x70] */
            ii(0x1007_a8f5, 5); call(0x1007_5e64, -0x4a96);             /* call 0x10075e64 */
            ii(0x1007_a8fa, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a8fc, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1007_a8ff, 5); call(0x1011_ff4c, 0xa_5648);            /* call 0x1011ff4c */
            ii(0x1007_a904, 2); test(al, al);                           /* test al, al */
            ii(0x1007_a906, 2); if(jz(0x1007_a934, 0x2c)) goto l_0x1007_a934; /* jz 0x1007a934 */
            ii(0x1007_a908, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1007_a90d, 1); push(eax);                              /* push eax */
            ii(0x1007_a90e, 4); movsx(ecx, memw[ss, ebp - 58]);         /* movsx ecx, word [ebp-0x3a] */
            ii(0x1007_a912, 4); movsx(ebx, memw[ss, ebp - 60]);         /* movsx ebx, word [ebp-0x3c] */
            ii(0x1007_a916, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a919, 3); mov(al, memb[ds, eax + 38]);            /* mov al, [eax+0x26] */
            ii(0x1007_a91c, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1007_a91e, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_a921, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_a924, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1007_a927, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_a92a, 5); call(0x1007_02b9, -0xa676);             /* call 0x100702b9 */
            ii(0x1007_a92f, 1); cwde();                                 /* cwde */
            ii(0x1007_a930, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_a932, 2); if(jnz(0x1007_a936, 2)) goto l_0x1007_a936; /* jnz 0x1007a936 */
        l_0x1007_a934:
            ii(0x1007_a934, 2); jmp(0x1007_a947, 0x11); goto l_0x1007_a947; /* jmp 0x1007a947 */
        l_0x1007_a936:
            ii(0x1007_a936, 3); lea(edx, memd[ss, ebp - 60]);           /* lea edx, [ebp-0x3c] */
            ii(0x1007_a939, 3); lea(eax, memd[ss, ebp - 52]);           /* lea eax, [ebp-0x34] */
            ii(0x1007_a93c, 5); call(0x1008_8b44, 0xe203);              /* call 0x10088b44 */
            ii(0x1007_a941, 3); mov(eax, memd[ss, ebp - 108]);          /* mov eax, [ebp-0x6c] */
            ii(0x1007_a944, 3); mov(memd[ss, ebp - 92], eax);           /* mov [ebp-0x5c], eax */
        l_0x1007_a947:
            ii(0x1007_a947, 5); jmp(0x1007_a7fc, -0x150); goto l_0x1007_a7fc; /* jmp 0x1007a7fc */
        l_0x1007_a94c:
            ii(0x1007_a94c, 5); jmp(0x1007_a7e2, -0x16f); goto l_0x1007_a7e2; /* jmp 0x1007a7e2 */
        l_0x1007_a951:
            ii(0x1007_a951, 5); jmp(0x1007_a7b8, -0x19e); goto l_0x1007_a7b8; /* jmp 0x1007a7b8 */
        l_0x1007_a956:
            ii(0x1007_a956, 3); mov(eax, memd[ss, ebp - 52]);           /* mov eax, [ebp-0x34] */
            ii(0x1007_a959, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_a95c, 4); cmp(ax, memw[ds, edx + 26]);            /* cmp ax, [edx+0x1a] */
            ii(0x1007_a960, 2); if(jnz(0x1007_a972, 0x10)) goto l_0x1007_a972; /* jnz 0x1007a972 */
            ii(0x1007_a962, 3); mov(eax, memd[ss, ebp - 50]);           /* mov eax, [ebp-0x32] */
            ii(0x1007_a965, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_a968, 4); cmp(ax, memw[ds, edx + 28]);            /* cmp ax, [edx+0x1c] */
            ii(0x1007_a96c, 6); if(jz(0x1007_aa14, 0xa2)) goto l_0x1007_aa14; /* jz 0x1007aa14 */
        l_0x1007_a972:
            ii(0x1007_a972, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1007_a977, 5); call(Definitions.sys_new, 0xe_b484);    /* call 0x10165e00 */
            ii(0x1007_a97c, 3); mov(memd[ss, ebp - 116], eax);          /* mov [ebp-0x74], eax */
            ii(0x1007_a97f, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x1007_a982, 3); mov(memd[ss, ebp - 120], eax);          /* mov [ebp-0x78], eax */
            ii(0x1007_a985, 4); cmp(memd[ss, ebp - 120], 0);            /* cmp dword [ebp-0x78], 0x0 */
            ii(0x1007_a989, 2); if(jz(0x1007_a9c1, 0x36)) goto l_0x1007_a9c1; /* jz 0x1007a9c1 */
            ii(0x1007_a98b, 5); mov(eax, 0x100b_0ebb);                  /* mov eax, 0x100b0ebb */
            ii(0x1007_a990, 1); push(eax);                              /* push eax */
            ii(0x1007_a991, 3); lea(edx, memd[ss, ebp - 52]);           /* lea edx, [ebp-0x34] */
            ii(0x1007_a994, 3); lea(eax, memd[ss, ebp - 124]);          /* lea eax, [ebp-0x7c] */
            ii(0x1007_a997, 5); call(0x1007_5e64, -0x4b38);             /* call 0x10075e64 */
            ii(0x1007_a99c, 1); push(eax);                              /* push eax */
            ii(0x1007_a99d, 5); mov(eax, 2);                            /* mov eax, 0x2 */
            ii(0x1007_a9a2, 1); push(eax);                              /* push eax */
            ii(0x1007_a9a3, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_a9a5, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x1007_a9a8, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1007_a9ab, 3); mov(eax, memd[ss, ebp - 116]);          /* mov eax, [ebp-0x74] */
            ii(0x1007_a9ae, 5); call(0x100a_c220, 0x3_186d);            /* call 0x100ac220 */
            ii(0x1007_a9b3, 3); mov(memd[ss, ebp - 128], eax);          /* mov [ebp-0x80], eax */
            ii(0x1007_a9b6, 3); mov(eax, memd[ss, ebp - 128]);          /* mov eax, [ebp-0x80] */
            ii(0x1007_a9b9, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
            ii(0x1007_a9bf, 2); jmp(0x1007_a9ca, 9); goto l_0x1007_a9ca; /* jmp 0x1007a9ca */
        l_0x1007_a9c1:
            ii(0x1007_a9c1, 3); mov(eax, memd[ss, ebp - 120]);          /* mov eax, [ebp-0x78] */
            ii(0x1007_a9c4, 6); mov(memd[ss, ebp - 132], eax);          /* mov [ebp-0x84], eax */
        l_0x1007_a9ca:
            ii(0x1007_a9ca, 6); mov(edx, memd[ss, ebp - 132]);          /* mov edx, [ebp-0x84] */
            ii(0x1007_a9d0, 6); lea(eax, memd[ss, ebp - 136]);          /* lea eax, [ebp-0x88] */
            ii(0x1007_a9d6, 5); call(0x1008_a5f0, 0xfc15);              /* call 0x1008a5f0 */
            ii(0x1007_a9db, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1007_a9e0, 6); lea(eax, memd[ss, ebp - 136]);          /* lea eax, [ebp-0x88] */
            ii(0x1007_a9e6, 5); call(0x1008_a520, 0xfb35);              /* call 0x1008a520 */
            ii(0x1007_a9eb, 5); call(0x1008_a6a4, 0xfcb4);              /* call 0x1008a6a4 */
            ii(0x1007_a9f0, 6); lea(eax, memd[ss, ebp - 136]);          /* lea eax, [ebp-0x88] */
            ii(0x1007_a9f6, 5); call(0x1008_a57c, 0xfb81);              /* call 0x1008a57c */
            ii(0x1007_a9fb, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1007_a9fd, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_aa02, 5); call(0x100a_4d50, 0x2_a349);            /* call 0x100a4d50 */
            ii(0x1007_aa07, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_aa09, 6); lea(eax, memd[ss, ebp - 136]);          /* lea eax, [ebp-0x88] */
            ii(0x1007_aa0f, 5); call(0x1008_8d4c, 0xe338);              /* call 0x10088d4c */
        l_0x1007_aa14:
            ii(0x1007_aa14, 4); mov(memb[ss, ebp - 20], 1);             /* mov byte [ebp-0x14], 0x1 */
            ii(0x1007_aa18, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_aa1a, 3); lea(eax, memd[ss, ebp - 80]);           /* lea eax, [ebp-0x50] */
            ii(0x1007_aa1d, 5); call(Definitions.my_dtor_d1, 0xe2da);   /* call 0x10088cfc */
            ii(0x1007_aa22, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_aa24, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_aa27, 5); call(0x1007_5f2c, -0x4b00);             /* call 0x10075f2c */
            ii(0x1007_aa2c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_aa2e, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_aa31, 5); call(0x1007_5f6c, -0x4aca);             /* call 0x10075f6c */
            ii(0x1007_aa36, 2); jmp(0x1007_aa66, 0x2e); goto l_0x1007_aa66; /* jmp 0x1007aa66 */
        l_0x1007_aa38:
            ii(0x1007_aa38, 4); mov(memb[ss, ebp - 20], 0);             /* mov byte [ebp-0x14], 0x0 */
            ii(0x1007_aa3c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_aa3e, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1007_aa41, 5); call(0x1007_5f2c, -0x4b1a);             /* call 0x10075f2c */
            ii(0x1007_aa46, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_aa48, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
            ii(0x1007_aa4b, 5); call(0x1007_5f6c, -0x4ae4);             /* call 0x10075f6c */
            ii(0x1007_aa50, 2); jmp(0x1007_aa66, 0x14); goto l_0x1007_aa66; /* jmp 0x1007aa66 */
        //  ii(0x1007_aa52, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_aa54, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
        //  ii(0x1007_aa57, 5); call(0x1007_5f2c, -0x4b30);             /* call 0x10075f2c */
        //  ii(0x1007_aa5c, 2); xor(edx, edx);                          /* xor edx, edx */
        //  ii(0x1007_aa5e, 3); lea(eax, memd[ss, ebp - 36]);           /* lea eax, [ebp-0x24] */
        //  ii(0x1007_aa61, 5); call(0x1007_5f6c, -0x4afa);             /* call 0x10075f6c */
        l_0x1007_aa66:
            ii(0x1007_aa66, 3); mov(al, memb[ss, ebp - 20]);            /* mov al, [ebp-0x14] */
            ii(0x1007_aa69, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_aa6b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_aa6c, 1); pop(edi);                               /* pop edi */
            ii(0x1007_aa6d, 1); pop(esi);                               /* pop esi */
            ii(0x1007_aa6e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_aa6f, 1); ret();                                  /* ret */
        }
    }
}

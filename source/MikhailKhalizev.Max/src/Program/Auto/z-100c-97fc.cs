using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_97fc-ae08a2b9")]
        public void Method_100c_97fc()
        {
            ii(0x100c_97fc, 5); push(0x3c);                             /* push 0x3c */
            ii(0x100c_9801, 5); call(Definitions.sys_check_available_stack_size, 0x9_c54c); /* call 0x10165d52 */
            ii(0x100c_9806, 1); push(ebx);                              /* push ebx */
            ii(0x100c_9807, 1); push(ecx);                              /* push ecx */
            ii(0x100c_9808, 1); push(edx);                              /* push edx */
            ii(0x100c_9809, 1); push(esi);                              /* push esi */
            ii(0x100c_980a, 1); push(edi);                              /* push edi */
            ii(0x100c_980b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_980c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_980e, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_9814, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
        l_0x100c_9817:
            ii(0x100c_9817, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_981a, 4); mov(ax, memw[ds, eax + 19]);            /* mov ax, [eax+0x13] */
            ii(0x100c_981e, 7); cmp(ax, memw[ds, 0x101c_8172]);         /* cmp ax, [0x101c8172] */
            ii(0x100c_9825, 6); if(jge(0x100c_9926, 0xfb)) goto l_0x100c_9926; /* jge 0x100c9926 */
            ii(0x100c_982b, 5); call(0x1014_82f4, 0x7_eac4);            /* call 0x101482f4 */
            ii(0x100c_9830, 6); sub(eax, memd[ds, 0x101c_3974]);        /* sub eax, [0x101c3974] */
            ii(0x100c_9836, 6); cmp(eax, memd[ds, 0x101b_dd84]);        /* cmp eax, [0x101bdd84] */
            ii(0x100c_983c, 6); if(jbe(0x100c_98ba, 0x78)) goto l_0x100c_98ba; /* jbe 0x100c98ba */
            ii(0x100c_9842, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100c_9844, 5); mov(al, memb[ds, 0x101c_37da]);         /* mov al, [0x101c37da] */
            ii(0x100c_9849, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100c_984f, 7); cmp(memb[ds, eax + 0x101c_a491], 0);    /* cmp byte [eax+0x101ca491], 0x0 */
            ii(0x100c_9856, 2); if(jnz(0x100c_9864, 0xc)) goto l_0x100c_9864; /* jnz 0x100c9864 */
            ii(0x100c_9858, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_985b, 5); call(0x1008_acf8, -0x3_eb68);           /* call 0x1008acf8 */
            ii(0x100c_9860, 2); test(al, al);                           /* test al, al */
            ii(0x100c_9862, 2); if(jz(0x100c_9866, 2)) goto l_0x100c_9866; /* jz 0x100c9866 */
        l_0x100c_9864:
            ii(0x100c_9864, 2); jmp(0x100c_98b8, 0x52); goto l_0x100c_98b8; /* jmp 0x100c98b8 */
        l_0x100c_9866:
            ii(0x100c_9866, 5); call(0x1008_a7bc, -0x3_f0af);           /* call 0x1008a7bc */
            ii(0x100c_986b, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100c_9870, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100c_9873, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100c_9878, 5); call(Definitions.sys_new, 0x9_c583);    /* call 0x10165e00 */
            ii(0x100c_987d, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100c_9880, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_9883, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100c_9886, 4); cmp(memd[ss, ebp - 24], 0);             /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_988a, 2); if(jz(0x100c_98a2, 0x16)) goto l_0x100c_98a2; /* jz 0x100c98a2 */
            ii(0x100c_988c, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_988f, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100c_9892, 5); call(0x100a_3711, -0x2_6186);           /* call 0x100a3711 */
            ii(0x100c_9897, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100c_989a, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x100c_989d, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
            ii(0x100c_98a0, 2); jmp(0x100c_98a8, 6); goto l_0x100c_98a8; /* jmp 0x100c98a8 */
        l_0x100c_98a2:
            ii(0x100c_98a2, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100c_98a5, 3); mov(memd[ss, ebp - 32], eax);           /* mov [ebp-0x20], eax */
        l_0x100c_98a8:
            ii(0x100c_98a8, 3); mov(edx, memd[ss, ebp - 32]);           /* mov edx, [ebp-0x20] */
            ii(0x100c_98ab, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_98b0, 3); mov(ebx, memd[ss, ebp - 16]);           /* mov ebx, [ebp-0x10] */
            ii(0x100c_98b3, 5); call(0x100a_4db6, -0x2_4b02);           /* call 0x100a4db6 */
        l_0x100c_98b8:
            ii(0x100c_98b8, 2); jmp(0x100c_9933, 0x79); goto l_0x100c_9933; /* jmp 0x100c9933 */
        l_0x100c_98ba:
            ii(0x100c_98ba, 5); mov(ebx, 1);                            /* mov ebx, 0x1 */
            ii(0x100c_98bf, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_98c2, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_98c5, 3); lea(eax, memd[ss, ebp - 12]);           /* lea eax, [ebp-0xc] */
            ii(0x100c_98c8, 5); call(0x1007_5e64, -0x5_3a69);           /* call 0x10075e64 */
            ii(0x100c_98cd, 5); mov(ecx, 0x101c_34d8);                  /* mov ecx, 0x101c34d8 */
            ii(0x100c_98d2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_98d4, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x100c_98d6, 5); call(0x100c_90d6, -0x805);              /* call 0x100c90d6 */
            ii(0x100c_98db, 5); mov(ebx, 2);                            /* mov ebx, 0x2 */
            ii(0x100c_98e0, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_98e3, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100c_98e6, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x100c_98e9, 5); call(0x1007_5e64, -0x5_3a8a);           /* call 0x10075e64 */
            ii(0x100c_98ee, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100c_98f0, 5); mov(eax, 0x101c_34d8);                  /* mov eax, 0x101c34d8 */
            ii(0x100c_98f5, 5); call(0x100c_90d6, -0x824);              /* call 0x100c90d6 */
            ii(0x100c_98fa, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_98fd, 4); inc(memw[ds, eax + 21]);                /* inc word [eax+0x15] */
            ii(0x100c_9901, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_9904, 4); mov(ax, memw[ds, eax + 21]);            /* mov ax, [eax+0x15] */
            ii(0x100c_9908, 7); cmp(ax, memw[ds, 0x101c_8174]);         /* cmp ax, [0x101c8174] */
            ii(0x100c_990f, 2); if(jl(0x100c_9921, 0x10)) goto l_0x100c_9921; /* jl 0x100c9921 */
            ii(0x100c_9911, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_9914, 6); mov(memw[ds, eax + 21], 0);             /* mov word [eax+0x15], 0x0 */
            ii(0x100c_991a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100c_991d, 4); inc(memw[ds, eax + 19]);                /* inc word [eax+0x13] */
        l_0x100c_9921:
            ii(0x100c_9921, 5); jmp(0x100c_9817, -0x10f); goto l_0x100c_9817; /* jmp 0x100c9817 */
        l_0x100c_9926:
            ii(0x100c_9926, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100c_9929, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100c_992e, 5); call(0x100a_5e27, -0x2_3b0c);           /* call 0x100a5e27 */
        l_0x100c_9933:
            ii(0x100c_9933, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_9935, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_9936, 1); pop(edi);                               /* pop edi */
            ii(0x100c_9937, 1); pop(esi);                               /* pop esi */
            ii(0x100c_9938, 1); pop(edx);                               /* pop edx */
            ii(0x100c_9939, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_993a, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_993b, 1); ret();                                  /* ret */
        }
    }
}

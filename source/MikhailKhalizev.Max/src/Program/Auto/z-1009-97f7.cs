using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_97f7-3e40528c")]
        public void Method_1009_97f7()
        {
            ii(0x1009_97f7, 5); push(0x44);                             /* push 0x44 */
            ii(0x1009_97fc, 5); call(Definitions.sys_check_available_stack_size, 0xc_c551); /* call 0x10165d52 */
            ii(0x1009_9801, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9802, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9803, 1); push(edx);                              /* push edx */
            ii(0x1009_9804, 1); push(esi);                              /* push esi */
            ii(0x1009_9805, 1); push(edi);                              /* push edi */
            ii(0x1009_9806, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9807, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9809, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_980f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_9812, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1009_9815, 5); call(Definitions.my_ctor_0x101b_4184, -0x2_2d2a); /* call 0x10076af0 */
            ii(0x1009_981a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_981d, 3); mov(eax, memd[ds, eax + 0x15]);         /* mov eax, [eax+0x15] */
            ii(0x1009_9820, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_9823, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_9826, 3); mov(edx, memd[ds, edx + 7]);            /* mov edx, [edx+0x7] */
            ii(0x1009_9829, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_982c, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x1009_9832, 5); mov(ebx, 0x101c_a468);                  /* mov ebx, 0x101ca468 */
            ii(0x1009_9837, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x1009_9839, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_983b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1009_983d, 5); call(0x100d_fd2c, 0x4_64ea);            /* call 0x100dfd2c */
            ii(0x1009_9842, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_9844, 5); call(0x100a_314c, 0x9903);              /* call 0x100a314c */
            ii(0x1009_9849, 4); cmp(ax, memw[ds, edx + 8]);             /* cmp ax, [edx+0x8] */
            ii(0x1009_984d, 6); if(jl(0x1009_990f, 0xbc)) goto l_0x1009_990f; /* jl 0x1009990f */
            ii(0x1009_9853, 5); mov(eax, 0x1200);                       /* mov eax, 0x1200 */
            ii(0x1009_9858, 1); push(eax);                              /* push eax */
            ii(0x1009_9859, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1009_985e, 1); push(eax);                              /* push eax */
            ii(0x1009_985f, 3); lea(ecx, memd[ss, ebp - 8]);            /* lea ecx, [ebp-0x8] */
            ii(0x1009_9862, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1009_9864, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9867, 3); mov(edx, memd[ds, eax + 0x15]);         /* mov edx, [eax+0x15] */
            ii(0x1009_986a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1009_986d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_9870, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_9873, 5); call(0x1009_c3c0, 0x2b48);              /* call 0x1009c3c0 */
            ii(0x1009_9878, 5); call(0x1009_5f0a, -0x3973);             /* call 0x10095f0a */
            ii(0x1009_987d, 2); test(al, al);                           /* test al, al */
            ii(0x1009_987f, 6); if(jz(0x1009_990f, 0x8a)) goto l_0x1009_990f; /* jz 0x1009990f */
            ii(0x1009_9885, 5); mov(eax, 0x35);                         /* mov eax, 0x35 */
            ii(0x1009_988a, 5); call(Definitions.sys_new, 0xc_c571);    /* call 0x10165e00 */
            ii(0x1009_988f, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_9892, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_9895, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1009_9898, 4); cmp(memd[ss, ebp - 0x10], 0);           /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_989c, 2); if(jz(0x1009_98da, 0x3c)) goto l_0x1009_98da; /* jz 0x100998da */
            ii(0x1009_989e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_98a1, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_98a4, 5); call(0x1009_c41c, 0x2b73);              /* call 0x1009c41c */
            ii(0x1009_98a9, 1); push(eax);                              /* push eax */
            ii(0x1009_98aa, 3); lea(edx, memd[ss, ebp - 8]);            /* lea edx, [ebp-0x8] */
            ii(0x1009_98ad, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x1009_98b0, 5); call(0x1007_5e64, -0x2_3a51);           /* call 0x10075e64 */
            ii(0x1009_98b5, 1); push(eax);                              /* push eax */
            ii(0x1009_98b6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_98b9, 3); mov(ecx, memd[ds, eax + 0x15]);         /* mov ecx, [eax+0x15] */
            ii(0x1009_98bc, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x1009_98bf, 5); mov(ebx, 0x1200);                       /* mov ebx, 0x1200 */
            ii(0x1009_98c4, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_98c7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_98ca, 5); call(0x1008_c999, -0xcf36);             /* call 0x1008c999 */
            ii(0x1009_98cf, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1009_98d2, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1009_98d5, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x1009_98d8, 2); jmp(0x1009_98e0, 6); goto l_0x1009_98e0; /* jmp 0x100998e0 */
        l_0x1009_98da:
            ii(0x1009_98da, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1009_98dd, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
        l_0x1009_98e0:
            ii(0x1009_98e0, 3); mov(edx, memd[ss, ebp - 0x1c]);         /* mov edx, [ebp-0x1c] */
            ii(0x1009_98e3, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_98e6, 5); call(0x1009_c7e0, 0x2ef5);              /* call 0x1009c7e0 */
            ii(0x1009_98eb, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_98ee, 5); call(0x1009_c73c, 0x2e49);              /* call 0x1009c73c */
            ii(0x1009_98f3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_98f5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_98f8, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_98fb, 5); call(0x1009_c3c0, 0x2ac0);              /* call 0x1009c3c0 */
            ii(0x1009_9900, 5); call(0x1009_350b, -0x63fa);             /* call 0x1009350b */
            ii(0x1009_9905, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_9907, 3); lea(eax, memd[ss, ebp - 0x20]);         /* lea eax, [ebp-0x20] */
            ii(0x1009_990a, 5); call(0x1009_b9ec, 0x20dd);              /* call 0x1009b9ec */
        l_0x1009_990f:
            ii(0x1009_990f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_9911, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_9912, 1); pop(edi);                               /* pop edi */
            ii(0x1009_9913, 1); pop(esi);                               /* pop esi */
            ii(0x1009_9914, 1); pop(edx);                               /* pop edx */
            ii(0x1009_9915, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_9916, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_9917, 1); ret();                                  /* ret */
        }
    }
}

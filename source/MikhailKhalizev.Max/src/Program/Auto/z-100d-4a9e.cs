using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_4a9e-124b4a0b")]
        public void Method_100d_4a9e()
        {
            ii(0x100d_4a9e, 5); push(0x168);                            /* push 0x168 */
            ii(0x100d_4aa3, 5); call(Definitions.sys_check_available_stack_size, 0x9_12aa); /* call 0x10165d52 */
            ii(0x100d_4aa8, 1); push(ebx);                              /* push ebx */
            ii(0x100d_4aa9, 1); push(ecx);                              /* push ecx */
            ii(0x100d_4aaa, 1); push(edx);                              /* push edx */
            ii(0x100d_4aab, 1); push(esi);                              /* push esi */
            ii(0x100d_4aac, 1); push(edi);                              /* push edi */
            ii(0x100d_4aad, 1); push(ebp);                              /* push ebp */
            ii(0x100d_4aae, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4ab0, 6); sub(esp, 0x14c);                        /* sub esp, 0x14c */
            ii(0x100d_4ab6, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_4ab9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_4abc, 4); test(memb[ds, eax + 0x13], 2);          /* test byte [eax+0x13], 0x2 */
            ii(0x100d_4ac0, 2); if(jz(0x100d_4b0b, 0x49)) goto l_0x100d_4b0b; /* jz 0x100d4b0b */
            ii(0x100d_4ac2, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_4ac6, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_4ac9, 6); lea(eax, memd[ss, ebp - 0xbc]);         /* lea eax, [ebp-0xbc] */
            ii(0x100d_4acf, 5); call(0x100d_3395, -0x173f);             /* call 0x100d3395 */
            ii(0x100d_4ad4, 6); mov(memd[ss, ebp - 0xc0], eax);         /* mov [ebp-0xc0], eax */
            ii(0x100d_4ada, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_4ade, 6); lea(eax, memd[ss, ebp - 0xbc]);         /* lea eax, [ebp-0xbc] */
            ii(0x100d_4ae4, 5); call(0x100d_42d8, -0x811);              /* call 0x100d42d8 */
            ii(0x100d_4ae9, 6); lea(eax, memd[ss, ebp - 0xbc]);         /* lea eax, [ebp-0xbc] */
            ii(0x100d_4aef, 5); call(0x100d_2504, -0x25f0);             /* call 0x100d2504 */
            ii(0x100d_4af4, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_4af9, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4afc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4afe, 6); lea(eax, memd[ss, ebp - 0xbc]);         /* lea eax, [ebp-0xbc] */
            ii(0x100d_4b04, 5); call(0x100d_4133, -0x9d6);              /* call 0x100d4133 */
            ii(0x100d_4b09, 2); jmp(0x100d_4b52, 0x47); goto l_0x100d_4b52; /* jmp 0x100d4b52 */
        l_0x100d_4b0b:
            ii(0x100d_4b0b, 4); or(memb[ss, ebp - 8], 1);               /* or byte [ebp-0x8], 0x1 */
            ii(0x100d_4b0f, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100d_4b12, 6); lea(eax, memd[ss, ebp - 0x148]);        /* lea eax, [ebp-0x148] */
            ii(0x100d_4b18, 5); call(0x100d_25d4, -0x2549);             /* call 0x100d25d4 */
            ii(0x100d_4b1d, 6); mov(memd[ss, ebp - 0x14c], eax);        /* mov [ebp-0x14c], eax */
            ii(0x100d_4b23, 4); and(memb[ss, ebp - 8], -2 /* 0xfe */);  /* and byte [ebp-0x8], 0xfe */
            ii(0x100d_4b27, 6); lea(eax, memd[ss, ebp - 0x148]);        /* lea eax, [ebp-0x148] */
            ii(0x100d_4b2d, 5); call(0x100d_1447, -0x36eb);             /* call 0x100d1447 */
            ii(0x100d_4b32, 6); lea(eax, memd[ss, ebp - 0x148]);        /* lea eax, [ebp-0x148] */
            ii(0x100d_4b38, 5); call(0x100d_2504, -0x2639);             /* call 0x100d2504 */
            ii(0x100d_4b3d, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100d_4b42, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_4b45, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_4b47, 6); lea(eax, memd[ss, ebp - 0x148]);        /* lea eax, [ebp-0x148] */
            ii(0x100d_4b4d, 5); call(0x100d_4e00, 0x2ae);               /* call 0x100d4e00 */
        l_0x100d_4b52:
            ii(0x100d_4b52, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_4b55, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_4b58, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_4b5b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4b5d, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_4b5e, 1); pop(edi);                               /* pop edi */
            ii(0x100d_4b5f, 1); pop(esi);                               /* pop esi */
            ii(0x100d_4b60, 1); pop(edx);                               /* pop edx */
            ii(0x100d_4b61, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_4b62, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_4b63, 1); ret();                                  /* ret */
        }
    }
}

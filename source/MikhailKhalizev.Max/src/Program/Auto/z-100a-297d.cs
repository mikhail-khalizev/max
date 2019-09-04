using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_297d-544c0249")]
        public void Method_100a_297d()
        {
            ii(0x100a_297d, 5); push(0x34);                             /* push 0x34 */
            ii(0x100a_2982, 5); call(Definitions.sys_check_available_stack_size, 0xc_33cb); /* call 0x10165d52 */
            ii(0x100a_2987, 1); push(ebx);                              /* push ebx */
            ii(0x100a_2988, 1); push(ecx);                              /* push ecx */
            ii(0x100a_2989, 1); push(esi);                              /* push esi */
            ii(0x100a_298a, 1); push(edi);                              /* push edi */
            ii(0x100a_298b, 1); push(ebp);                              /* push ebp */
            ii(0x100a_298c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_298e, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_2994, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_2997, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x100a_299a, 4); cmp(memd[ss, ebp - 8], 0);              /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100a_299e, 2); if(jz(0x100a_29ad, 0xd)) goto l_0x100a_29ad; /* jz 0x100a29ad */
            ii(0x100a_29a0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_29a3, 5); call(0x1008_aa80, -0x1_7f28);           /* call 0x1008aa80 */
            ii(0x100a_29a8, 3); test(ah, 1);                            /* test ah, 0x1 */
            ii(0x100a_29ab, 2); if(jz(0x100a_29af, 2)) goto l_0x100a_29af; /* jz 0x100a29af */
        l_0x100a_29ad:
            ii(0x100a_29ad, 2); jmp(0x100a_29fc, 0x4d); goto l_0x100a_29fc; /* jmp 0x100a29fc */
        l_0x100a_29af:
            ii(0x100a_29af, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100a_29b1, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100a_29b4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_29b7, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x100a_29bc, 5); call(Definitions.sys_new, 0xc_343f);    /* call 0x10165e00 */
            ii(0x100a_29c1, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x100a_29c4, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_29c7, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x100a_29ca, 4); cmp(memd[ss, ebp - 20], 0);             /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100a_29ce, 2); if(jz(0x100a_29e6, 0x16)) goto l_0x100a_29e6; /* jz 0x100a29e6 */
            ii(0x100a_29d0, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100a_29d3, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x100a_29d6, 5); call(0x100a_3b9c, 0x11c1);              /* call 0x100a3b9c */
            ii(0x100a_29db, 3); mov(memd[ss, ebp - 24], eax);           /* mov [ebp-0x18], eax */
            ii(0x100a_29de, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x100a_29e1, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
            ii(0x100a_29e4, 2); jmp(0x100a_29ec, 6); goto l_0x100a_29ec; /* jmp 0x100a29ec */
        l_0x100a_29e6:
            ii(0x100a_29e6, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x100a_29e9, 3); mov(memd[ss, ebp - 28], eax);           /* mov [ebp-0x1c], eax */
        l_0x100a_29ec:
            ii(0x100a_29ec, 3); mov(edx, memd[ss, ebp - 28]);           /* mov edx, [ebp-0x1c] */
            ii(0x100a_29ef, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_29f4, 3); mov(ebx, memd[ss, ebp - 12]);           /* mov ebx, [ebp-0xc] */
            ii(0x100a_29f7, 5); call(0x100a_4db6, 0x23ba);              /* call 0x100a4db6 */
        l_0x100a_29fc:
            ii(0x100a_29fc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_29fe, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_29ff, 1); pop(edi);                               /* pop edi */
            ii(0x100a_2a00, 1); pop(esi);                               /* pop esi */
            ii(0x100a_2a01, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_2a02, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_2a03, 1); ret();                                  /* ret */
        }
    }
}

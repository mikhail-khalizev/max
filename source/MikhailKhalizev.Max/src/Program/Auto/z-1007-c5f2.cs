using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c5f2-506d84e6")]
        public void Method_1007_c5f2()
        {
            ii(0x1007_c5f2, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_c5f7, 5); call(Definitions.sys_check_available_stack_size, 0xe_9756); /* call 0x10165d52 */
            ii(0x1007_c5fc, 1); push(ebx);                              /* push ebx */
            ii(0x1007_c5fd, 1); push(ecx);                              /* push ecx */
            ii(0x1007_c5fe, 1); push(esi);                              /* push esi */
            ii(0x1007_c5ff, 1); push(edi);                              /* push edi */
            ii(0x1007_c600, 1); push(ebp);                              /* push ebp */
            ii(0x1007_c601, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c603, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_c609, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_c60c, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_c60f, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_c612, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c615, 5); call(0x1015_2a52, 0xd_6438);            /* call 0x10152a52 */
            ii(0x1007_c61a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c61c, 2); if(jz(0x1007_c62f, 0x11)) goto l_0x1007_c62f; /* jz 0x1007c62f */
            ii(0x1007_c61e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c620, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c623, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_c626, 5); call(0x1013_ad11, 0xb_e6e6);            /* call 0x1013ad11 */
            ii(0x1007_c62b, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c62d, 2); if(jz(0x1007_c631, 0x2)) goto l_0x1007_c631; /* jz 0x1007c631 */
        l_0x1007_c62f:
            ii(0x1007_c62f, 2); jmp(0x1007_c640, 0xf); goto l_0x1007_c640; /* jmp 0x1007c640 */
        l_0x1007_c631:
            ii(0x1007_c631, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c634, 3); mov(al, memb[ds, eax + 0x4e]);          /* mov al, [eax+0x4e] */
            ii(0x1007_c637, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_c63c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1007_c63e, 2); if(jnz(0x1007_c649, 0x9)) goto l_0x1007_c649; /* jnz 0x1007c649 */
        l_0x1007_c640:
            ii(0x1007_c640, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_c644, 5); jmp(0x1007_c6c0, 0x77); goto l_0x1007_c6c0; /* jmp 0x1007c6c0 */
        l_0x1007_c649:
            ii(0x1007_c649, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_c64b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c64e, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1007_c651, 5); call(0x1013_ad11, 0xb_e6bb);            /* call 0x1013ad11 */
            ii(0x1007_c656, 2); test(al, al);                           /* test al, al */
            ii(0x1007_c658, 2); if(jnz(0x1007_c677, 0x1d)) goto l_0x1007_c677; /* jnz 0x1007c677 */
            ii(0x1007_c65a, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c65d, 5); call(0x1007_623c, -0x6426);             /* call 0x1007623c */
            ii(0x1007_c662, 3); mov(edx, memd[ds, eax + 0x12]);         /* mov edx, [eax+0x12] */
            ii(0x1007_c665, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_c668, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_c66b, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x1007_c66e, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_c673, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x1007_c675, 2); if(jge(0x1007_c6a1, 0x2a)) goto l_0x1007_c6a1; /* jge 0x1007c6a1 */
        l_0x1007_c677:
            ii(0x1007_c677, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c67a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c67d, 3); add(eax, 0x29);                         /* add eax, 0x29 */
            ii(0x1007_c680, 5); call(0x1007_6630, -0x6055);             /* call 0x10076630 */
            ii(0x1007_c685, 5); call(0x1008_a79c, 0xe112);              /* call 0x1008a79c */
            ii(0x1007_c68a, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_c68c, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1007_c68e, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_c691, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1007_c696, 5); call(0x100a_53ac, 0x2_8d11);            /* call 0x100a53ac */
            ii(0x1007_c69b, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x1007_c69f, 2); jmp(0x1007_c6c0, 0x1f); goto l_0x1007_c6c0; /* jmp 0x1007c6c0 */
        l_0x1007_c6a1:
            ii(0x1007_c6a1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_c6a4, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_c6a7, 5); call(0x1008_afb4, 0xe908);              /* call 0x1008afb4 */
            ii(0x1007_c6ac, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_c6af, 3); mov(ebx, memd[ss, ebp - 0x4]);          /* mov ebx, [ebp-0x4] */
            ii(0x1007_c6b2, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1007_c6b5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_c6b8, 5); call(0x1008_58d6, 0x9219);              /* call 0x100858d6 */
            ii(0x1007_c6bd, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x1007_c6c0:
            ii(0x1007_c6c0, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_c6c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c6c5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_c6c6, 1); pop(edi);                               /* pop edi */
            ii(0x1007_c6c7, 1); pop(esi);                               /* pop esi */
            ii(0x1007_c6c8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_c6c9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_c6ca, 1); ret();                                  /* ret */
        }
    }
}

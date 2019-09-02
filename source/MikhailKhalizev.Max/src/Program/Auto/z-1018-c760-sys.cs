using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_c760-2ddd91a8")]
        public void /* sys */ Method_1018_c760()
        {
            ii(0x1018_c760, 1); push(ebp);                              /* push ebp */
            ii(0x1018_c761, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_c763, 1); push(ebx);                              /* push ebx */
            ii(0x1018_c764, 1); push(ecx);                              /* push ecx */
            ii(0x1018_c765, 1); push(edx);                              /* push edx */
            ii(0x1018_c766, 3); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x1018_c769, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_c76b, 5); call(/* sys */ 0x1018_c450, -0x320);    /* call 0x1018c450 */
            ii(0x1018_c770, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c772, 2); if(jz(0x1018_c7c9, 0x55)) goto l_0x1018_c7c9; /* jz 0x1018c7c9 */
            ii(0x1018_c774, 3); lea(eax, memd[ss, ebp - 64]);           /* lea eax, [ebp-0x40] */
            ii(0x1018_c777, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1018_c77c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_c77e, 5); call(Definitions.sys_memset, -0x2_69a3); /* call 0x10165de0 */
            ii(0x1018_c783, 2); mov(ah, 0x4f);                          /* mov ah, 0x4f */
            ii(0x1018_c785, 2); mov(dl, 3);                             /* mov dl, 0x3 */
            ii(0x1018_c787, 3); mov(memb[ss, ebp - 35], ah);            /* mov [ebp-0x23], ah */
            ii(0x1018_c78a, 3); mov(memb[ss, ebp - 36], dl);            /* mov [ebp-0x24], dl */
            ii(0x1018_c78d, 6); mov(ax, memw[ds, 0x1020_b708]);         /* mov ax, [0x1020b708] */
            ii(0x1018_c793, 5); mov(edx, 0x800);                        /* mov edx, 0x800 */
            ii(0x1018_c798, 4); mov(memw[ss, ebp - 16], ax);            /* mov [ebp-0x10], ax */
            ii(0x1018_c79c, 4); mov(memw[ss, ebp - 18], dx);            /* mov [ebp-0x12], dx */
            ii(0x1018_c7a0, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1018_c7a5, 3); lea(edx, memd[ss, ebp - 64]);           /* lea edx, [ebp-0x40] */
            ii(0x1018_c7a8, 5); call(/* sys */ 0x1019_4540, 0x7d93);    /* call 0x10194540 */
            ii(0x1018_c7ad, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c7af, 2); if(jz(0x1018_c7b8, 7)) goto l_0x1018_c7b8; /* jz 0x1018c7b8 */
            ii(0x1018_c7b1, 5); cmp(memw[ss, ebp - 36], 0x4f);          /* cmp word [ebp-0x24], 0x4f */
            ii(0x1018_c7b6, 2); if(jz(0x1018_c7bc, 4)) goto l_0x1018_c7bc; /* jz 0x1018c7bc */
        l_0x1018_c7b8:
            ii(0x1018_c7b8, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c7ba, 2); jmp(0x1018_c7c9, 0xd); goto l_0x1018_c7c9; /* jmp 0x1018c7c9 */
        l_0x1018_c7bc:
            ii(0x1018_c7bc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c7be, 4); mov(ax, memw[ss, ebp - 48]);            /* mov ax, [ebp-0x30] */
            ii(0x1018_c7c2, 2); mov(memd[ds, ecx], eax);                /* mov [ecx], eax */
            ii(0x1018_c7c4, 5); mov(eax, 1);                            /* mov eax, 0x1 */
        l_0x1018_c7c9:
            ii(0x1018_c7c9, 3); lea(esp, memd[ss, ebp - 12]);           /* lea esp, [ebp-0xc] */
            ii(0x1018_c7cc, 1); pop(edx);                               /* pop edx */
            ii(0x1018_c7cd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_c7ce, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_c7cf, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_c7d0, 1); ret();                                  /* ret */
        }
    }
}

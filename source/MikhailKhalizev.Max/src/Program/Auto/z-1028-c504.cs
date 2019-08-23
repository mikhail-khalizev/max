using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_c504-692eac16")]
        public void Method_1028_c504()
        {
            ii(0x1028_c504, 1); push(ds);                               /* push ds */
            ii(0x1028_c505, 1); push(esi);                              /* push esi */
            ii(0x1028_c506, 6); mov(ecx, memd[ds, 0x1348]);             /* mov ecx, [0x1348] */
            ii(0x1028_c50c, 6); mov(memd[ds, 0x134c], ecx);             /* mov [0x134c], ecx */
            ii(0x1028_c512, 4); movzx(eax, memw[ds, esi + 0x56]);       /* movzx eax, word [esi+0x56] */
            ii(0x1028_c516, 4); add(memw[ds, esi + 0x54], ax);          /* add [esi+0x54], ax */
            ii(0x1028_c51a, 4); movzx(eax, memw[ds, esi + 0x54]);       /* movzx eax, word [esi+0x54] */
            ii(0x1028_c51e, 5); mov(ebx, 0x7fff);                       /* mov ebx, 0x7fff */
            ii(0x1028_c523, 5); mov(ecx, 0x7fff);                       /* mov ecx, 0x7fff */
            ii(0x1028_c528, 5); test(eax, 0x8000);                      /* test eax, 0x8000 */
            ii(0x1028_c52d, 2); if(jnz(0x1028_c533, 0x4)) goto l_0x1028_c533; /* jnz 0x1028c533 */
            ii(0x1028_c52f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1028_c531, 2); jmp(0x1028_c53a, 0x7); goto l_0x1028_c53a; /* jmp 0x1028c53a */
        l_0x1028_c533:
            ii(0x1028_c533, 5); mov(ebx, 0xffff);                       /* mov ebx, 0xffff */
            ii(0x1028_c538, 2); sub(ebx, eax);                          /* sub ebx, eax */
        l_0x1028_c53a:
            ii(0x1028_c53a, 4); movzx(eax, memw[ds, esi + 0x32]);       /* movzx eax, word [esi+0x32] */
            ii(0x1028_c53e, 7); imul(memw[ds, 0x1334]);                 /* imul word [0x1334] */
            ii(0x1028_c545, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c547, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c549, 3); imul(bx);                               /* imul bx */
            ii(0x1028_c54c, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c54e, 6); mov(memd[ds, 0x139a], edx);             /* mov [0x139a], edx */
            ii(0x1028_c554, 4); movzx(eax, memw[ds, esi + 0x32]);       /* movzx eax, word [esi+0x32] */
            ii(0x1028_c558, 7); imul(memw[ds, 0x1334]);                 /* imul word [0x1334] */
            ii(0x1028_c55f, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c561, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c563, 3); imul(cx);                               /* imul cx */
            ii(0x1028_c566, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c568, 6); mov(memd[ds, 0x1396], edx);             /* mov [0x1396], edx */
            ii(0x1028_c56e, 4); movzx(eax, memw[ds, esi + 0x32]);       /* movzx eax, word [esi+0x32] */
            ii(0x1028_c572, 7); imul(memw[ds, 0x1334]);                 /* imul word [0x1334] */
            ii(0x1028_c579, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c57b, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1028_c57d, 7); mov(es, memw[ds, 0x135c]);              /* mov es, [0x135c] */
            ii(0x1028_c584, 6); mov(ecx, memd[ds, 0x1340]);             /* mov ecx, [0x1340] */
            ii(0x1028_c58a, 3); shr(ecx, 0x2);                          /* shr ecx, 0x2 */
            ii(0x1028_c58d, 6); mov(memd[ds, 0x1344], ecx);             /* mov [0x1344], ecx */
            ii(0x1028_c593, 3); lds(esi, memd[ds, esi + 0x8]);          /* lds esi, [esi+0x8] */
            ii(0x1028_c596, 1); cld();                                  /* cld */
            ii(0x1028_c597, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_c599, 8); cmp(memd[fs, 0x1344], 0);               /* cmp dword [fs:0x1344], 0x0 */
            ii(0x1028_c5a1, 6); if(jz(0x1028_c614, 0x6d)) goto l_0x1028_c614; /* jz 0x1028c614 */
        l_0x1028_c5a7:
            ii(0x1028_c5a7, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c5aa, 8); imul(memw[fs, 0x139a]);                 /* imul word [fs:0x139a] */
            ii(0x1028_c5b2, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c5b4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c5b6, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c5ba, 2); if(jno(0x1028_c5ce, 0x12)) goto l_0x1028_c5ce; /* jno 0x1028c5ce */
            ii(0x1028_c5bc, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c5c0, 2); if(jl(0x1028_c5c9, 0x7)) goto l_0x1028_c5c9; /* jl 0x1028c5c9 */
            ii(0x1028_c5c2, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c5c7, 2); jmp(0x1028_c5ce, 0x5); goto l_0x1028_c5ce; /* jmp 0x1028c5ce */
        l_0x1028_c5c9:
            ii(0x1028_c5c9, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c5ce:
            ii(0x1028_c5ce, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c5d2, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c5d5, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c5d8, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c5db, 8); imul(memw[fs, 0x1396]);                 /* imul word [fs:0x1396] */
            ii(0x1028_c5e3, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c5e5, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c5e7, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c5eb, 2); if(jno(0x1028_c5ff, 0x12)) goto l_0x1028_c5ff; /* jno 0x1028c5ff */
            ii(0x1028_c5ed, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c5f1, 2); if(jl(0x1028_c5fa, 0x7)) goto l_0x1028_c5fa; /* jl 0x1028c5fa */
            ii(0x1028_c5f3, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c5f8, 2); jmp(0x1028_c5ff, 0x5); goto l_0x1028_c5ff; /* jmp 0x1028c5ff */
        l_0x1028_c5fa:
            ii(0x1028_c5fa, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c5ff:
            ii(0x1028_c5ff, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c603, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c606, 8); sub(memd[fs, 0x1344], 0x1);             /* sub dword [fs:0x1344], 0x1 */
            ii(0x1028_c60e, 6); if(jnz(0x1028_c5a7, -0x6d)) goto l_0x1028_c5a7; /* jnz 0x1028c5a7 */
        l_0x1028_c614:
            ii(0x1028_c614, 6); mov(eax, memd[fs, 0x134c]);             /* mov eax, [fs:0x134c] */
            ii(0x1028_c61a, 3); shr(eax, 0x2);                          /* shr eax, 0x2 */
            ii(0x1028_c61d, 3); adc(eax, 0);                            /* adc eax, 0x0 */
            ii(0x1028_c620, 6); mov(memd[fs, 0x134c], eax);             /* mov [fs:0x134c], eax */
            ii(0x1028_c626, 2); or(eax, eax);                           /* or eax, eax */
            ii(0x1028_c628, 6); if(jz(0x1028_c69d, 0x6f)) goto l_0x1028_c69d; /* jz 0x1028c69d */
            ii(0x1028_c62e, 2); xor(edi, edi);                          /* xor edi, edi */
        l_0x1028_c630:
            ii(0x1028_c630, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c633, 8); imul(memw[fs, 0x139a]);                 /* imul word [fs:0x139a] */
            ii(0x1028_c63b, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c63d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c63f, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c643, 2); if(jno(0x1028_c657, 0x12)) goto l_0x1028_c657; /* jno 0x1028c657 */
            ii(0x1028_c645, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c649, 2); if(jl(0x1028_c652, 0x7)) goto l_0x1028_c652; /* jl 0x1028c652 */
            ii(0x1028_c64b, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c650, 2); jmp(0x1028_c657, 0x5); goto l_0x1028_c657; /* jmp 0x1028c657 */
        l_0x1028_c652:
            ii(0x1028_c652, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c657:
            ii(0x1028_c657, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c65b, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c65e, 3); movzx(eax, memw[ds, esi]);              /* movzx eax, word [esi] */
            ii(0x1028_c661, 3); add(esi, 0x2);                          /* add esi, 0x2 */
            ii(0x1028_c664, 8); imul(memw[fs, 0x1396]);                 /* imul word [fs:0x1396] */
            ii(0x1028_c66c, 2); add(edx, edx);                          /* add edx, edx */
            ii(0x1028_c66e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1028_c670, 4); add(ax, memw[es, edi]);                 /* add ax, [es:edi] */
            ii(0x1028_c674, 2); if(jno(0x1028_c688, 0x12)) goto l_0x1028_c688; /* jno 0x1028c688 */
            ii(0x1028_c676, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_c67a, 2); if(jl(0x1028_c683, 0x7)) goto l_0x1028_c683; /* jl 0x1028c683 */
            ii(0x1028_c67c, 5); mov(eax, 0x8000);                       /* mov eax, 0x8000 */
            ii(0x1028_c681, 2); jmp(0x1028_c688, 0x5); goto l_0x1028_c688; /* jmp 0x1028c688 */
        l_0x1028_c683:
            ii(0x1028_c683, 5); mov(eax, 0x7fff);                       /* mov eax, 0x7fff */
        l_0x1028_c688:
            ii(0x1028_c688, 4); mov(memw[es, edi], ax);                 /* mov [es:edi], ax */
            ii(0x1028_c68c, 3); add(edi, 0x2);                          /* add edi, 0x2 */
            ii(0x1028_c68f, 8); sub(memd[fs, 0x134c], 0x1);             /* sub dword [fs:0x134c], 0x1 */
            ii(0x1028_c697, 6); if(jnz(0x1028_c630, -0x6d)) goto l_0x1028_c630; /* jnz 0x1028c630 */
        l_0x1028_c69d:
            ii(0x1028_c69d, 1); pop(esi);                               /* pop esi */
            ii(0x1028_c69e, 1); pop(ds);                                /* pop ds */
            ii(0x1028_c69f, 1); ret();                                  /* ret */
        }
    }
}

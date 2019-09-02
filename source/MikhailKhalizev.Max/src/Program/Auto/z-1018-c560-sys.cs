using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_c560-4a4cf600")]
        public void /* sys */ Method_1018_c560()
        {
            ii(0x1018_c560, 1); push(ebp);                              /* push ebp */
            ii(0x1018_c561, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1018_c563, 1); push(esi);                              /* push esi */
            ii(0x1018_c564, 1); push(edi);                              /* push edi */
            ii(0x1018_c565, 3); sub(esp, 0x40);                         /* sub esp, 0x40 */
            ii(0x1018_c568, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1018_c56a, 3); mov(memd[ss, ebp - 0x10], edx);         /* mov [ebp-0x10], edx */
            ii(0x1018_c56d, 3); mov(memd[ss, ebp - 0xc], ebx);          /* mov [ebp-0xc], ebx */
            ii(0x1018_c570, 3); mov(memd[ss, ebp - 0x14], ecx);         /* mov [ebp-0x14], ecx */
            ii(0x1018_c573, 5); call(/* sys */ 0x1018_c450, -0x128);    /* call 0x1018c450 */
            ii(0x1018_c578, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c57a, 6); if(jz(0x1018_c625, 0xa5)) goto l_0x1018_c625; /* jz 0x1018c625 */
            ii(0x1018_c580, 3); lea(eax, memd[ss, ebp - 0x48]);         /* lea eax, [ebp-0x48] */
            ii(0x1018_c583, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1018_c588, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_c58a, 5); call(Definitions.sys_memset, -0x2_67af); /* call 0x10165de0 */
            ii(0x1018_c58f, 2); mov(ah, 0x4f);                          /* mov ah, 0x4f */
            ii(0x1018_c591, 2); mov(dl, 1);                             /* mov dl, 0x1 */
            ii(0x1018_c593, 4); mov(memw[ss, ebp - 0x30], si);          /* mov [ebp-0x30], si */
            ii(0x1018_c597, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_c599, 3); mov(memb[ss, ebp - 0x2b], ah);          /* mov [ebp-0x2b], ah */
            ii(0x1018_c59c, 3); mov(memb[ss, ebp - 0x2c], dl);          /* mov [ebp-0x2c], dl */
            ii(0x1018_c59f, 6); mov(ax, memw[ds, 0x1020_b708]);         /* mov ax, [0x1020b708] */
            ii(0x1018_c5a5, 5); mov(edx, 0x800);                        /* mov edx, 0x800 */
            ii(0x1018_c5aa, 4); mov(memw[ss, ebp - 0x18], ax);          /* mov [ebp-0x18], ax */
            ii(0x1018_c5ae, 4); mov(memw[ss, ebp - 0x1a], dx);          /* mov [ebp-0x1a], dx */
            ii(0x1018_c5b2, 4); mov(memw[ss, ebp - 0x26], ax);          /* mov [ebp-0x26], ax */
            ii(0x1018_c5b6, 5); mov(eax, 0x10);                         /* mov eax, 0x10 */
            ii(0x1018_c5bb, 3); lea(edx, memd[ss, ebp - 0x48]);         /* lea edx, [ebp-0x48] */
            ii(0x1018_c5be, 4); mov(memw[ss, ebp - 0x48], bx);          /* mov [ebp-0x48], bx */
            ii(0x1018_c5c2, 5); call(/* sys */ 0x1019_4540, 0x7f79);    /* call 0x10194540 */
            ii(0x1018_c5c7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_c5c9, 2); if(jz(0x1018_c5d2, 7)) goto l_0x1018_c5d2; /* jz 0x1018c5d2 */
            ii(0x1018_c5cb, 5); cmp(memw[ss, ebp - 0x2c], 0x4f);        /* cmp word [ebp-0x2c], 0x4f */
            ii(0x1018_c5d0, 2); if(jz(0x1018_c5d6, 4)) goto l_0x1018_c5d6; /* jz 0x1018c5d6 */
        l_0x1018_c5d2:
            ii(0x1018_c5d2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c5d4, 2); jmp(0x1018_c625, 0x4f); goto l_0x1018_c625; /* jmp 0x1018c625 */
        l_0x1018_c5d6:
            ii(0x1018_c5d6, 5); mov(ecx, 0x40);                         /* mov ecx, 0x40 */
            ii(0x1018_c5db, 3); mov(edi, memd[ss, ebp - 0x10]);         /* mov edi, [ebp-0x10] */
            ii(0x1018_c5de, 6); mov(esi, memd[ds, 0x1020_b700]);        /* mov esi, [0x1020b700] */
            ii(0x1018_c5e4, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1018_c5e7, 2); rep(() => movsd());                     /* rep movsd */
            ii(0x1018_c5e9, 3); mov(eax, memd[ds, eax + 0xc]);          /* mov eax, [eax+0xc] */
            ii(0x1018_c5ec, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1018_c5ef, 5); call(/* sys */ 0x1019_43d0, 0x7ddc);    /* call 0x101943d0 */
            ii(0x1018_c5f4, 3); mov(memd[ds, edx + 0xc], eax);          /* mov [edx+0xc], eax */
            ii(0x1018_c5f7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c5f9, 4); mov(ax, memw[ds, edx + 8]);             /* mov ax, [edx+0x8] */
            ii(0x1018_c5fd, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_c600, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1018_c603, 5); call(/* sys */ 0x1019_43d0, 0x7dc8);    /* call 0x101943d0 */
            ii(0x1018_c608, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1018_c60a, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1018_c60d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_c60f, 4); mov(ax, memw[ds, edx + 0xa]);           /* mov ax, [edx+0xa] */
            ii(0x1018_c613, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x1018_c616, 3); mov(edx, memd[ss, ebp - 0x14]);         /* mov edx, [ebp-0x14] */
            ii(0x1018_c619, 5); call(/* sys */ 0x1019_43d0, 0x7db2);    /* call 0x101943d0 */
            ii(0x1018_c61e, 2); mov(memd[ds, edx], eax);                /* mov [edx], eax */
            ii(0x1018_c620, 5); mov(eax, 1);                            /* mov eax, 0x1 */
        l_0x1018_c625:
            ii(0x1018_c625, 3); lea(esp, memd[ss, ebp - 8]);            /* lea esp, [ebp-0x8] */
            ii(0x1018_c628, 1); pop(edi);                               /* pop edi */
            ii(0x1018_c629, 1); pop(esi);                               /* pop esi */
            ii(0x1018_c62a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1018_c62b, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_16c5-f3093c2")]
        public void /* sys */ Method_1018_16c5()
        {
            ii(0x1018_16c5, 1); push(ecx);                              /* push ecx */
            ii(0x1018_16c6, 1); push(esi);                              /* push esi */
            ii(0x1018_16c7, 1); push(edi);                              /* push edi */
            ii(0x1018_16c8, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1018_16cb, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_16cd, 2); mov(esi, ebx);                          /* mov esi, ebx */
            ii(0x1018_16cf, 3); mov(memd[ss, esp], edx);                /* mov [esp], edx */
            ii(0x1018_16d2, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_16d4, 2); if(jge(0x1018_16e1, 0xb)) goto l_0x1018_16e1; /* jge 0x101816e1 */
            ii(0x1018_16d6, 2); neg(edx);                               /* neg edx */
            ii(0x1018_16d8, 3); lea(ecx, memd[ds, eax + 0x1]);          /* lea ecx, [eax+0x1] */
            ii(0x1018_16db, 3); mov(memb[ds, eax], 0x2d);               /* mov byte [eax], 0x2d */
            ii(0x1018_16de, 3); mov(memd[ss, esp], edx);                /* mov [esp], edx */
        l_0x1018_16e1:
            ii(0x1018_16e1, 4); cmp(memd[ds, esi + 0x8], -0x1 /* 0xff */); /* cmp dword [esi+0x8], 0xffffffff */
            ii(0x1018_16e5, 2); if(jnz(0x1018_16ee, 0x7)) goto l_0x1018_16ee; /* jnz 0x101816ee */
            ii(0x1018_16e7, 7); mov(memd[ds, esi + 0x8], 0x4);          /* mov dword [esi+0x8], 0x4 */
        l_0x1018_16ee:
            ii(0x1018_16ee, 5); mov(ebx, 0xa);                          /* mov ebx, 0xa */
            ii(0x1018_16f3, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_16f5, 2); mov(edx, ecx);                          /* mov edx, ecx */
            ii(0x1018_16f7, 5); mov(ax, memw[ss, esp + 0x2]);           /* mov ax, [esp+0x2] */
            ii(0x1018_16fc, 5); call(/* sys */ 0x1017_93f8, -0x8309);   /* call 0x101793f8 */
            ii(0x1018_1701, 2); mov(ebx, ecx);                          /* mov ebx, ecx */
        l_0x1018_1703:
            ii(0x1018_1703, 2); mov(ah, memb[ds, ecx]);                 /* mov ah, [ecx] */
            ii(0x1018_1705, 3); lea(edx, memd[ds, ecx + 0x1]);          /* lea edx, [ecx+0x1] */
            ii(0x1018_1708, 2); test(ah, ah);                           /* test ah, ah */
            ii(0x1018_170a, 2); if(jz(0x1018_1710, 0x4)) goto l_0x1018_1710; /* jz 0x10181710 */
            ii(0x1018_170c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_170e, 2); jmp(0x1018_1703, -0xd); goto l_0x1018_1703; /* jmp 0x10181703 */
        l_0x1018_1710:
            ii(0x1018_1710, 4); cmp(memd[ds, esi + 0x8], 0);            /* cmp dword [esi+0x8], 0x0 */
            ii(0x1018_1714, 2); if(jz(0x1018_1742, 0x2c)) goto l_0x1018_1742; /* jz 0x10181742 */
            ii(0x1018_1716, 3); mov(memb[ds, ecx], 0x2e);               /* mov byte [ecx], 0x2e */
            ii(0x1018_1719, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_171b, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_171d, 2); jmp(0x1018_173a, 0x1b); goto l_0x1018_173a; /* jmp 0x1018173a */
        l_0x1018_171f:
            ii(0x1018_171f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1721, 5); mov(memw[ss, esp + 0x2], dx);           /* mov [esp+0x2], dx */
            ii(0x1018_1726, 3); mov(edi, memd[ss, esp]);                /* mov edi, [esp] */
            ii(0x1018_1729, 3); imul(edx, edi, 0xa);                    /* imul edx, edi, 0xa */
            ii(0x1018_172c, 3); mov(memd[ss, esp], edx);                /* mov [esp], edx */
            ii(0x1018_172f, 4); mov(dl, memb[ss, esp + 0x2]);           /* mov dl, [esp+0x2] */
            ii(0x1018_1733, 3); add(dl, 0x30);                          /* add dl, 0x30 */
            ii(0x1018_1736, 1); inc(eax);                               /* inc eax */
            ii(0x1018_1737, 2); mov(memb[ds, ecx], dl);                 /* mov [ecx], dl */
            ii(0x1018_1739, 1); inc(ecx);                               /* inc ecx */
        l_0x1018_173a:
            ii(0x1018_173a, 3); cmp(eax, memd[ds, esi + 0x8]);          /* cmp eax, [esi+0x8] */
            ii(0x1018_173d, 2); if(jl(0x1018_171f, -0x20)) goto l_0x1018_171f; /* jl 0x1018171f */
            ii(0x1018_173f, 3); mov(memb[ds, ecx], 0);                  /* mov byte [ecx], 0x0 */
        l_0x1018_1742:
            ii(0x1018_1742, 3); mov(eax, memd[ss, esp]);                /* mov eax, [esp] */
            ii(0x1018_1745, 2); xor(al, al);                            /* xor al, al */
            ii(0x1018_1747, 3); and(ah, 0x80);                          /* and ah, 0x80 */
            ii(0x1018_174a, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1018_174f, 6); if(jz(0x1018_17b3, 0x5e)) goto l_0x1018_17b3; /* jz 0x101817b3 */
        l_0x1018_1755:
            ii(0x1018_1755, 2); cmp(ecx, ebx);                          /* cmp ecx, ebx */
            ii(0x1018_1757, 2); if(jnz(0x1018_1792, 0x39)) goto l_0x1018_1792; /* jnz 0x10181792 */
            ii(0x1018_1759, 3); lea(ecx, memd[ds, ebx + 0x1]);          /* lea ecx, [ebx+0x1] */
            ii(0x1018_175c, 3); mov(memb[ds, ebx], 0x31);               /* mov byte [ebx], 0x31 */
        l_0x1018_175f:
            ii(0x1018_175f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1761, 2); mov(dl, memb[ds, ecx]);                 /* mov dl, [ecx] */
            ii(0x1018_1763, 3); lea(eax, memd[ds, ecx + 0x1]);          /* lea eax, [ecx+0x1] */
            ii(0x1018_1766, 3); cmp(edx, 0x30);                         /* cmp edx, 0x30 */
            ii(0x1018_1769, 2); if(jnz(0x1018_176f, 0x4)) goto l_0x1018_176f; /* jnz 0x1018176f */
            ii(0x1018_176b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_176d, 2); jmp(0x1018_175f, -0x10); goto l_0x1018_175f; /* jmp 0x1018175f */
        l_0x1018_176f:
            ii(0x1018_176f, 3); cmp(edx, 0x2e);                         /* cmp edx, 0x2e */
            ii(0x1018_1772, 2); if(jnz(0x1018_1789, 0x15)) goto l_0x1018_1789; /* jnz 0x10181789 */
            ii(0x1018_1774, 3); mov(memb[ds, ecx], 0x30);               /* mov byte [ecx], 0x30 */
            ii(0x1018_1777, 3); lea(ecx, memd[ds, eax + 0x1]);          /* lea ecx, [eax+0x1] */
            ii(0x1018_177a, 3); mov(memb[ds, eax], 0x2e);               /* mov byte [eax], 0x2e */
        l_0x1018_177d:
            ii(0x1018_177d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_177f, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1018_1781, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1018_1784, 2); if(jnz(0x1018_1789, 0x3)) goto l_0x1018_1789; /* jnz 0x10181789 */
            ii(0x1018_1786, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_1787, 2); jmp(0x1018_177d, -0xc); goto l_0x1018_177d; /* jmp 0x1018177d */
        l_0x1018_1789:
            ii(0x1018_1789, 3); mov(memb[ds, ecx], 0x30);               /* mov byte [ecx], 0x30 */
            ii(0x1018_178c, 1); inc(ecx);                               /* inc ecx */
            ii(0x1018_178d, 3); mov(memb[ds, ecx], 0);                  /* mov byte [ecx], 0x0 */
            ii(0x1018_1790, 2); jmp(0x1018_17b3, 0x21); goto l_0x1018_17b3; /* jmp 0x101817b3 */
        l_0x1018_1792:
            ii(0x1018_1792, 1); dec(ecx);                               /* dec ecx */
            ii(0x1018_1793, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_1795, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1018_1797, 3); cmp(eax, 0x2e);                         /* cmp eax, 0x2e */
            ii(0x1018_179a, 2); if(jnz(0x1018_179d, 0x1)) goto l_0x1018_179d; /* jnz 0x1018179d */
            ii(0x1018_179c, 1); dec(ecx);                               /* dec ecx */
        l_0x1018_179d:
            ii(0x1018_179d, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_179f, 2); mov(al, memb[ds, ecx]);                 /* mov al, [ecx] */
            ii(0x1018_17a1, 3); cmp(eax, 0x39);                         /* cmp eax, 0x39 */
            ii(0x1018_17a4, 2); if(jz(0x1018_17ae, 0x8)) goto l_0x1018_17ae; /* jz 0x101817ae */
            ii(0x1018_17a6, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1018_17a8, 2); inc(dl);                                /* inc dl */
            ii(0x1018_17aa, 2); mov(memb[ds, ecx], dl);                 /* mov [ecx], dl */
            ii(0x1018_17ac, 2); jmp(0x1018_17b3, 0x5); goto l_0x1018_17b3; /* jmp 0x101817b3 */
        l_0x1018_17ae:
            ii(0x1018_17ae, 3); mov(memb[ds, ecx], 0x30);               /* mov byte [ecx], 0x30 */
            ii(0x1018_17b1, 2); jmp(0x1018_1755, -0x5e); goto l_0x1018_1755; /* jmp 0x10181755 */
        l_0x1018_17b3:
            ii(0x1018_17b3, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1018_17b6, 1); pop(edi);                               /* pop edi */
            ii(0x1018_17b7, 1); pop(esi);                               /* pop esi */
            ii(0x1018_17b8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_17b9, 1); ret();                                  /* ret */
        }
    }
}

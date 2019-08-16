using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e5c065f-97db-49ec-839b-59ad971c8db9")]
        public void /* sys */ Method_1017_1680()
        {
            ii(0x1017_1680, 1); pushd(esi);                             /* push esi */
            ii(0x1017_1681, 1); pushd(edi);                             /* push edi */
            ii(0x1017_1682, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_1683, 6); sub(esp, 0x118);                        /* sub esp, 0x118 */
            ii(0x1017_1689, 2); mov(esi, eax);                          /* mov esi, eax */
            ii(0x1017_168b, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1017_168d, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1017_168f, 7); mov(memd_a32[ss, esp + 0x108], ecx);    /* mov [esp+0x108], ecx */
            ii(0x1017_1696, 5); calld(/* sys */ 0x1018_c6f0, 0x1_b055); /* call 0x1018c6f0 */
            ii(0x1017_169b, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_169d, 2); if(jzd(0x1017_16ba, 0x1b)) goto l_0x1017_16ba; /* jz 0x101716ba */
            ii(0x1017_169f, 7); lea(ecx, esp + 0x100);                  /* lea ecx, [esp+0x100] */
            ii(0x1017_16a6, 7); lea(ebx, esp + 0x104);                  /* lea ebx, [esp+0x104] */
            ii(0x1017_16ad, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1017_16af, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1017_16b1, 5); calld(/* sys */ 0x1018_c560, 0x1_aeaa); /* call 0x1018c560 */
            ii(0x1017_16b6, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_16b8, 2); if(jnzd(0x1017_16dc, 0x22)) goto l_0x1017_16dc; /* jnz 0x101716dc */
        l_0x1017_16ba:
            ii(0x1017_16ba, 5); calld(/* sys */ 0x1017_1834, 0x175);    /* call 0x10171834 */
            ii(0x1017_16bf, 6); mov(dl, memb_a32[ds, 0x1020_8930]);     /* mov dl, [0x10208930] */
            ii(0x1017_16c5, 2); cmp(al, dl);                            /* cmp al, dl */
            ii(0x1017_16c7, 2); if(jzd(0x1017_16d2, 0x9)) goto l_0x1017_16d2; /* jz 0x101716d2 */
            ii(0x1017_16c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_16cb, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1017_16cd, 5); calld(/* sys */ 0x1017_1810, 0x13e);    /* call 0x10171810 */
        l_0x1017_16d2:
            ii(0x1017_16d2, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_16d7, 5); jmpd(0x1017_1804, 0x128); goto l_0x1017_1804; /* jmp 0x10171804 */
        l_0x1017_16dc:
            ii(0x1017_16dc, 4); mov(al, memb_a32[ss, esp + 0x2]);       /* mov al, [esp+0x2] */
            ii(0x1017_16e0, 2); and(al, 0x3);                           /* and al, 0x3 */
            ii(0x1017_16e2, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x1017_16e4, 2); if(jnzd(0x1017_16f8, 0x12)) goto l_0x1017_16f8; /* jnz 0x101716f8 */
            ii(0x1017_16e6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_16e8, 7); mov(eax, memd_a32[ss, esp + 0x104]);    /* mov eax, [esp+0x104] */
            ii(0x1017_16ef, 7); mov(memd_a32[ss, esp + 0x10c], ebx);    /* mov [esp+0x10c], ebx */
            ii(0x1017_16f6, 2); jmpd(0x1017_1715, 0x1d); goto l_0x1017_1715; /* jmp 0x10171715 */
        l_0x1017_16f8:
            ii(0x1017_16f8, 4); mov(al, memb_a32[ss, esp + 0x3]);       /* mov al, [esp+0x3] */
            ii(0x1017_16fc, 2); and(al, 0x3);                           /* and al, 0x3 */
            ii(0x1017_16fe, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x1017_1700, 2); if(jnzd(0x1017_171c, 0x1a)) goto l_0x1017_171c; /* jnz 0x1017171c */
            ii(0x1017_1702, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1017_1707, 7); mov(eax, memd_a32[ss, esp + 0x100]);    /* mov eax, [esp+0x100] */
            ii(0x1017_170e, 7); mov(memd_a32[ss, esp + 0x10c], edx);    /* mov [esp+0x10c], edx */
        l_0x1017_1715:
            ii(0x1017_1715, 7); mov(memd_a32[ss, esp + 0x114], eax);    /* mov [esp+0x114], eax */
        l_0x1017_171c:
            ii(0x1017_171c, 4); mov(al, memb_a32[ss, esp + 0x2]);       /* mov al, [esp+0x2] */
            ii(0x1017_1720, 2); and(al, 0x5);                           /* and al, 0x5 */
            ii(0x1017_1722, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1017_1724, 2); if(jnzd(0x1017_172f, 0x9)) goto l_0x1017_172f; /* jnz 0x1017172f */
            ii(0x1017_1726, 7); mov(ebx, memd_a32[ss, esp + 0x104]);    /* mov ebx, [esp+0x104] */
            ii(0x1017_172d, 2); jmpd(0x1017_174c, 0x1d); goto l_0x1017_174c; /* jmp 0x1017174c */
        l_0x1017_172f:
            ii(0x1017_172f, 4); mov(al, memb_a32[ss, esp + 0x3]);       /* mov al, [esp+0x3] */
            ii(0x1017_1733, 2); and(al, 0x5);                           /* and al, 0x5 */
            ii(0x1017_1735, 2); cmp(al, 0x5);                           /* cmp al, 0x5 */
            ii(0x1017_1737, 2); if(jnzd(0x1017_1747, 0xe)) goto l_0x1017_1747; /* jnz 0x10171747 */
            ii(0x1017_1739, 5); mov(ecx, 0x1);                          /* mov ecx, 0x1 */
            ii(0x1017_173e, 7); mov(ebx, memd_a32[ss, esp + 0x100]);    /* mov ebx, [esp+0x100] */
            ii(0x1017_1745, 2); jmpd(0x1017_174e, 0x7); goto l_0x1017_174e; /* jmp 0x1017174e */
        l_0x1017_1747:
            ii(0x1017_1747, 5); mov(ebx, 0xa_0000);                     /* mov ebx, 0xa0000 */
        l_0x1017_174c:
            ii(0x1017_174c, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
        l_0x1017_174e:
            ii(0x1017_174e, 4); test(memb_a32[ss, esp], 0x2);           /* test byte [esp], 0x2 */
            ii(0x1017_1752, 2); if(jzd(0x1017_175b, 0x7)) goto l_0x1017_175b; /* jz 0x1017175b */
            ii(0x1017_1754, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1017_1756, 5); mov(di, memw_a32[ss, esp + 0x12]);      /* mov di, [esp+0x12] */
        l_0x1017_175b:
            ii(0x1017_175b, 7); mov(eax, memd_a32[ss, esp + 0x108]);    /* mov eax, [esp+0x108] */
            ii(0x1017_1762, 2); mov(esi, ebp);                          /* mov esi, ebp */
            ii(0x1017_1764, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_1766, 2); if(jzd(0x1017_179a, 0x32)) goto l_0x1017_179a; /* jz 0x1017179a */
            ii(0x1017_1768, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1017_176a, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1017_176f, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_1770, 5); mov(edx, 0x3d5);                        /* mov edx, 0x3d5 */
            ii(0x1017_1775, 2); sub(eax, eax);                          /* sub eax, eax */
            ii(0x1017_1777, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1017_1778, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1017_177d, 7); mov(memd_a32[ss, esp + 0x110], eax);    /* mov [esp+0x110], eax */
            ii(0x1017_1784, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1017_1786, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1017_1787, 7); mov(al, memb_a32[ss, esp + 0x110]);     /* mov al, [esp+0x110] */
            ii(0x1017_178e, 2); and(al, 0xe0);                          /* and al, 0xe0 */
            ii(0x1017_1790, 5); mov(edx, 0x3d5);                        /* mov edx, 0x3d5 */
            ii(0x1017_1795, 2); or(al, 0x80);                           /* or al, 0x80 */
            ii(0x1017_1797, 2); shr(esi, 0x1);                          /* shr esi, 1 */
            ii(0x1017_1799, 1); outb(dx, al);                           /* out dx, al */
        l_0x1017_179a:
            ii(0x1017_179a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_179c, 5); mov(edx, /* sys */ 0x1018_cda8);        /* mov edx, 0x1018cda8 */
            ii(0x1017_17a1, 5); mov(ax, memw_a32[ss, esp + 0x4]);       /* mov ax, [esp+0x4] */
            ii(0x1017_17a6, 1); pushd(edx);                             /* push edx */
            ii(0x1017_17a7, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x1017_17aa, 1); pushd(eax);                             /* push eax */
            ii(0x1017_17ab, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_17ad, 5); mov(ax, memw_a32[ss, esp + 0xe]);       /* mov ax, [esp+0xe] */
            ii(0x1017_17b2, 3); shl(eax, 0xa);                          /* shl eax, 0xa */
            ii(0x1017_17b5, 1); pushd(eax);                             /* push eax */
            ii(0x1017_17b6, 7); mov(ebp, memd_a32[ss, esp + 0x120]);    /* mov ebp, [esp+0x120] */
            ii(0x1017_17bd, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_17be, 7); mov(eax, memd_a32[ss, esp + 0x11c]);    /* mov eax, [esp+0x11c] */
            ii(0x1017_17c5, 4); mov(memd_a32[ss, esp + 0x1c], edx);     /* mov [esp+0x1c], edx */
            ii(0x1017_17c9, 1); pushd(eax);                             /* push eax */
            ii(0x1017_17ca, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1017_17cc, 1); dec(esi);                               /* dec esi */
            ii(0x1017_17cd, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_17ce, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_17d0, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1017_17d2, 5); mov(bx, memw_a32[ss, esp + 0x28]);      /* mov bx, [esp+0x28] */
            ii(0x1017_17d7, 1); dec(edi);                               /* dec edi */
            ii(0x1017_17d8, 5); calld(/* sys */ 0x1017_12d0, -0x50d);   /* call 0x101712d0 */
            ii(0x1017_17dd, 5); mov(edx, /* sys */ 0x1017_1c5c);        /* mov edx, 0x10171c5c */
            ii(0x1017_17e2, 6); mov(memd_a32[ds, 0x1020_88e8], edi);    /* mov [0x102088e8], edi */
            ii(0x1017_17e8, 6); mov(memd_a32[ds, 0x1020_88ec], esi);    /* mov [0x102088ec], esi */
            ii(0x1017_17ee, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1017_17f0, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_17f2, 6); mov(memd_a32[ds, 0x1020_892c], edx);    /* mov [0x1020892c], edx */
            ii(0x1017_17f8, 6); mov(memd_a32[ds, 0x1020_88e0], ebx);    /* mov [0x102088e0], ebx */
            ii(0x1017_17fe, 6); mov(memd_a32[ds, 0x1020_88e4], ebx);    /* mov [0x102088e4], ebx */
        l_0x1017_1804:
            ii(0x1017_1804, 6); add(esp, 0x118);                        /* add esp, 0x118 */
            ii(0x1017_180a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_180b, 1); popd(edi);                              /* pop edi */
            ii(0x1017_180c, 1); popd(esi);                              /* pop esi */
            ii(0x1017_180d, 1); retd(); return;                         /* ret */
        }
    }
}
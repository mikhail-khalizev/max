using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1483-eeab701e")]
        public void /* sys */ Method_1018_1483()
        {
            ii(0x1018_1483, 1); push(ecx);                              /* push ecx */
            ii(0x1018_1484, 1); push(esi);                              /* push esi */
            ii(0x1018_1485, 1); push(edi);                              /* push edi */
            ii(0x1018_1486, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1018_1488, 4); mov(memb[ds, ebx + 0x17], 0);           /* mov byte [ebx+0x17], 0x0 */
            ii(0x1018_148c, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1018_148e, 4); mov(memb[ds, ebx + 0x16], 0x20);        /* mov byte [ebx+0x16], 0x20 */
            ii(0x1018_1492, 5); call(/* sys */ 0x1018_15c1, 0x12a);     /* call 0x101815c1 */
            ii(0x1018_1497, 7); mov(memd[ds, ebx + 4], 0);              /* mov dword [ebx+0x4], 0x0 */
            ii(0x1018_149e, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_14a0, 6); and(edx, 0xff);                         /* and edx, 0xff */
            ii(0x1018_14a6, 3); cmp(edx, 0x30);                         /* cmp edx, 0x30 */
            ii(0x1018_14a9, 2); if(jl(0x1018_14d1, 0x26)) goto l_0x1018_14d1; /* jl 0x101814d1 */
            ii(0x1018_14ab, 3); cmp(edx, 0x39);                         /* cmp edx, 0x39 */
            ii(0x1018_14ae, 2); if(jg(0x1018_14d1, 0x21)) goto l_0x1018_14d1; /* jg 0x101814d1 */
        l_0x1018_14b0:
            ii(0x1018_14b0, 4); imul(ecx, memd[ds, ebx + 4], 0xa);      /* imul ecx, [ebx+0x4], 0xa */
            ii(0x1018_14b4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_14b6, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_14b8, 3); sub(edx, 0x30);                         /* sub edx, 0x30 */
            ii(0x1018_14bb, 1); inc(eax);                               /* inc eax */
            ii(0x1018_14bc, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1018_14be, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_14c0, 3); mov(memd[ds, ebx + 4], ecx);            /* mov [ebx+0x4], ecx */
            ii(0x1018_14c3, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_14c5, 3); cmp(edx, 0x30);                         /* cmp edx, 0x30 */
            ii(0x1018_14c8, 2); if(jl(0x1018_14fc, 0x32)) goto l_0x1018_14fc; /* jl 0x101814fc */
            ii(0x1018_14ca, 3); cmp(edx, 0x39);                         /* cmp edx, 0x39 */
            ii(0x1018_14cd, 2); if(jle(0x1018_14b0, -0x1f)) goto l_0x1018_14b0; /* jle 0x101814b0 */
            ii(0x1018_14cf, 2); jmp(0x1018_14fc, 0x2b); goto l_0x1018_14fc; /* jmp 0x101814fc */
        l_0x1018_14d1:
            ii(0x1018_14d1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_14d3, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_14d5, 3); cmp(edx, 0x2a);                         /* cmp edx, 0x2a */
            ii(0x1018_14d8, 2); if(jnz(0x1018_14fc, 0x22)) goto l_0x1018_14fc; /* jnz 0x101814fc */
            ii(0x1018_14da, 2); mov(edx, memd[ds, esi]);                /* mov edx, [esi] */
            ii(0x1018_14dc, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1018_14df, 2); mov(memd[ds, esi], edx);                /* mov [esi], edx */
            ii(0x1018_14e1, 3); mov(edx, memd[ds, edx - 4]);            /* mov edx, [edx-0x4] */
            ii(0x1018_14e4, 3); mov(memd[ds, ebx + 4], edx);            /* mov [ebx+0x4], edx */
            ii(0x1018_14e7, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_14e9, 2); if(jge(0x1018_14fb, 0x10)) goto l_0x1018_14fb; /* jge 0x101814fb */
            ii(0x1018_14eb, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1018_14ed, 3); mov(dl, memb[ds, ebx + 0x14]);          /* mov dl, [ebx+0x14] */
            ii(0x1018_14f0, 2); neg(edi);                               /* neg edi */
            ii(0x1018_14f2, 3); or(dl, 8);                              /* or dl, 0x8 */
            ii(0x1018_14f5, 3); mov(memd[ds, ebx + 4], edi);            /* mov [ebx+0x4], edi */
            ii(0x1018_14f8, 3); mov(memb[ds, ebx + 0x14], dl);          /* mov [ebx+0x14], dl */
        l_0x1018_14fb:
            ii(0x1018_14fb, 1); inc(eax);                               /* inc eax */
        l_0x1018_14fc:
            ii(0x1018_14fc, 7); mov(memd[ds, ebx + 8], 0xffff_ffff);    /* mov dword [ebx+0x8], 0xffffffff */
            ii(0x1018_1503, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1505, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_1507, 3); cmp(edx, 0x2e);                         /* cmp edx, 0x2e */
            ii(0x1018_150a, 2); if(jnz(0x1018_1555, 0x49)) goto l_0x1018_1555; /* jnz 0x10181555 */
            ii(0x1018_150c, 1); inc(eax);                               /* inc eax */
            ii(0x1018_150d, 7); mov(memd[ds, ebx + 8], 0);              /* mov dword [ebx+0x8], 0x0 */
            ii(0x1018_1514, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_1516, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_1518, 3); cmp(edx, 0x2a);                         /* cmp edx, 0x2a */
            ii(0x1018_151b, 2); if(jnz(0x1018_1538, 0x1b)) goto l_0x1018_1538; /* jnz 0x10181538 */
            ii(0x1018_151d, 2); mov(edx, memd[ds, esi]);                /* mov edx, [esi] */
            ii(0x1018_151f, 3); add(edx, 4);                            /* add edx, 0x4 */
            ii(0x1018_1522, 2); mov(memd[ds, esi], edx);                /* mov [esi], edx */
            ii(0x1018_1524, 3); mov(edx, memd[ds, edx - 4]);            /* mov edx, [edx-0x4] */
            ii(0x1018_1527, 3); mov(memd[ds, ebx + 8], edx);            /* mov [ebx+0x8], edx */
            ii(0x1018_152a, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1018_152c, 2); if(jge(0x1018_1535, 7)) goto l_0x1018_1535; /* jge 0x10181535 */
            ii(0x1018_152e, 7); mov(memd[ds, ebx + 8], 0xffff_ffff);    /* mov dword [ebx+0x8], 0xffffffff */
        l_0x1018_1535:
            ii(0x1018_1535, 1); inc(eax);                               /* inc eax */
            ii(0x1018_1536, 2); jmp(0x1018_1555, 0x1d); goto l_0x1018_1555; /* jmp 0x10181555 */
        l_0x1018_1538:
            ii(0x1018_1538, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_153a, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_153c, 3); cmp(edx, 0x30);                         /* cmp edx, 0x30 */
            ii(0x1018_153f, 2); if(jl(0x1018_1555, 0x14)) goto l_0x1018_1555; /* jl 0x10181555 */
            ii(0x1018_1541, 3); cmp(edx, 0x39);                         /* cmp edx, 0x39 */
            ii(0x1018_1544, 2); if(jg(0x1018_1555, 0xf)) goto l_0x1018_1555; /* jg 0x10181555 */
            ii(0x1018_1546, 4); imul(ecx, memd[ds, ebx + 8], 0xa);      /* imul ecx, [ebx+0x8], 0xa */
            ii(0x1018_154a, 3); sub(edx, 0x30);                         /* sub edx, 0x30 */
            ii(0x1018_154d, 2); add(ecx, edx);                          /* add ecx, edx */
            ii(0x1018_154f, 1); inc(eax);                               /* inc eax */
            ii(0x1018_1550, 3); mov(memd[ds, ebx + 8], ecx);            /* mov [ebx+0x8], ecx */
            ii(0x1018_1553, 2); jmp(0x1018_1538, -0x1d); goto l_0x1018_1538; /* jmp 0x10181538 */
        l_0x1018_1555:
            ii(0x1018_1555, 2); mov(dl, memb[ds, eax]);                 /* mov dl, [eax] */
            ii(0x1018_1557, 3); lea(ecx, memd[ds, eax + 1]);            /* lea ecx, [eax+0x1] */
            ii(0x1018_155a, 3); cmp(dl, 0x4e);                          /* cmp dl, 0x4e */
            ii(0x1018_155d, 2); if(jb(0x1018_157a, 0x1b)) goto l_0x1018_157a; /* jb 0x1018157a */
            ii(0x1018_155f, 2); if(jbe(0x1018_15b7, 0x56)) goto l_0x1018_15b7; /* jbe 0x101815b7 */
            ii(0x1018_1561, 3); cmp(dl, 0x6c);                          /* cmp dl, 0x6c */
            ii(0x1018_1564, 2); if(jb(0x1018_1571, 0xb)) goto l_0x1018_1571; /* jb 0x10181571 */
            ii(0x1018_1566, 2); if(jbe(0x1018_158a, 0x22)) goto l_0x1018_158a; /* jbe 0x1018158a */
            ii(0x1018_1568, 3); cmp(dl, 0x77);                          /* cmp dl, 0x77 */
            ii(0x1018_156b, 2); if(jz(0x1018_158a, 0x1d)) goto l_0x1018_158a; /* jz 0x1018158a */
            ii(0x1018_156d, 1); pop(edi);                               /* pop edi */
            ii(0x1018_156e, 1); pop(esi);                               /* pop esi */
            ii(0x1018_156f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_1570, 1); ret(); return;                          /* ret */
        l_0x1018_1571:
            ii(0x1018_1571, 3); cmp(dl, 0x68);                          /* cmp dl, 0x68 */
            ii(0x1018_1574, 2); if(jz(0x1018_1598, 0x22)) goto l_0x1018_1598; /* jz 0x10181598 */
            ii(0x1018_1576, 1); pop(edi);                               /* pop edi */
            ii(0x1018_1577, 1); pop(esi);                               /* pop esi */
            ii(0x1018_1578, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_1579, 1); ret(); return;                          /* ret */
        l_0x1018_157a:
            ii(0x1018_157a, 3); cmp(dl, 0x46);                          /* cmp dl, 0x46 */
            ii(0x1018_157d, 2); if(jb(0x1018_15bd, 0x3e)) goto l_0x1018_15bd; /* jb 0x101815bd */
            ii(0x1018_157f, 2); if(jbe(0x1018_15ad, 0x2c)) goto l_0x1018_15ad; /* jbe 0x101815ad */
            ii(0x1018_1581, 3); cmp(dl, 0x4c);                          /* cmp dl, 0x4c */
            ii(0x1018_1584, 2); if(jz(0x1018_159e, 0x18)) goto l_0x1018_159e; /* jz 0x1018159e */
            ii(0x1018_1586, 1); pop(edi);                               /* pop edi */
            ii(0x1018_1587, 1); pop(esi);                               /* pop esi */
            ii(0x1018_1588, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_1589, 1); ret(); return;                          /* ret */
        l_0x1018_158a:
            ii(0x1018_158a, 3); mov(dh, memb[ds, ebx + 0x14]);          /* mov dh, [ebx+0x14] */
            ii(0x1018_158d, 3); or(dh, 0x20);                           /* or dh, 0x20 */
            ii(0x1018_1590, 1); inc(eax);                               /* inc eax */
        l_0x1018_1591:
            ii(0x1018_1591, 3); mov(memb[ds, ebx + 0x14], dh);          /* mov [ebx+0x14], dh */
            ii(0x1018_1594, 1); pop(edi);                               /* pop edi */
            ii(0x1018_1595, 1); pop(esi);                               /* pop esi */
            ii(0x1018_1596, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_1597, 1); ret(); return;                          /* ret */
        l_0x1018_1598:
            ii(0x1018_1598, 4); or(memb[ds, ebx + 0x14], 0x10);         /* or byte [ebx+0x14], 0x10 */
            ii(0x1018_159c, 2); jmp(0x1018_15bb, 0x1d); goto l_0x1018_15bb; /* jmp 0x101815bb */
        l_0x1018_159e:
            ii(0x1018_159e, 3); mov(dl, memb[ds, ebx + 0x14]);          /* mov dl, [ebx+0x14] */
            ii(0x1018_15a1, 3); or(dl, 0x40);                           /* or dl, 0x40 */
            ii(0x1018_15a4, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_15a6, 3); mov(memb[ds, ebx + 0x14], dl);          /* mov [ebx+0x14], dl */
            ii(0x1018_15a9, 1); pop(edi);                               /* pop edi */
            ii(0x1018_15aa, 1); pop(esi);                               /* pop esi */
            ii(0x1018_15ab, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_15ac, 1); ret(); return;                          /* ret */
        l_0x1018_15ad:
            ii(0x1018_15ad, 3); mov(dh, memb[ds, ebx + 0x14]);          /* mov dh, [ebx+0x14] */
            ii(0x1018_15b0, 3); or(dh, 0x80);                           /* or dh, 0x80 */
            ii(0x1018_15b3, 2); mov(eax, ecx);                          /* mov eax, ecx */
            ii(0x1018_15b5, 2); jmp(0x1018_1591, -0x26); goto l_0x1018_1591; /* jmp 0x10181591 */
        l_0x1018_15b7:
            ii(0x1018_15b7, 4); or(memb[ds, ebx + 0x14], 0x40);         /* or byte [ebx+0x14], 0x40 */
        l_0x1018_15bb:
            ii(0x1018_15bb, 2); mov(eax, ecx);                          /* mov eax, ecx */
        l_0x1018_15bd:
            ii(0x1018_15bd, 1); pop(edi);                               /* pop edi */
            ii(0x1018_15be, 1); pop(esi);                               /* pop esi */
            ii(0x1018_15bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_15c0, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_15c1-78e11fed")]
        public void /* sys */ Method_1018_15c1()
        {
            ii(0x1018_15c1, 1); push(ebx);                              /* push ebx */
            ii(0x1018_15c2, 1); push(ecx);                              /* push ecx */
            ii(0x1018_15c3, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_15c5, 4); mov(memb[ds, edx + 0x14], 0);           /* mov byte [edx+0x14], 0x0 */
        l_0x1018_15c9:
            ii(0x1018_15c9, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_15cb, 2); mov(al, memb[ds, ebx]);                 /* mov al, [ebx] */
            ii(0x1018_15cd, 3); cmp(eax, 0x2d);                         /* cmp eax, 0x2d */
            ii(0x1018_15d0, 2); if(jnz(0x1018_15d8, 0x6)) goto l_0x1018_15d8; /* jnz 0x101815d8 */
            ii(0x1018_15d2, 4); or(memb[ds, edx + 0x14], 0x8);          /* or byte [edx+0x14], 0x8 */
            ii(0x1018_15d6, 2); jmp(0x1018_1618, 0x40); goto l_0x1018_1618; /* jmp 0x10181618 */
        l_0x1018_15d8:
            ii(0x1018_15d8, 3); cmp(eax, 0x23);                         /* cmp eax, 0x23 */
            ii(0x1018_15db, 2); if(jnz(0x1018_15e3, 0x6)) goto l_0x1018_15e3; /* jnz 0x101815e3 */
            ii(0x1018_15dd, 4); or(memb[ds, edx + 0x14], 0x1);          /* or byte [edx+0x14], 0x1 */
            ii(0x1018_15e1, 2); jmp(0x1018_1618, 0x35); goto l_0x1018_1618; /* jmp 0x10181618 */
        l_0x1018_15e3:
            ii(0x1018_15e3, 3); cmp(eax, 0x2b);                         /* cmp eax, 0x2b */
            ii(0x1018_15e6, 2); if(jnz(0x1018_15f8, 0x10)) goto l_0x1018_15f8; /* jnz 0x101815f8 */
            ii(0x1018_15e8, 3); mov(cl, memb[ds, edx + 0x14]);          /* mov cl, [edx+0x14] */
            ii(0x1018_15eb, 3); or(cl, 0x4);                            /* or cl, 0x4 */
            ii(0x1018_15ee, 2); mov(ch, cl);                            /* mov ch, cl */
            ii(0x1018_15f0, 3); and(ch, 0xfd);                          /* and ch, 0xfd */
            ii(0x1018_15f3, 3); mov(memb[ds, edx + 0x14], ch);          /* mov [edx+0x14], ch */
            ii(0x1018_15f6, 2); jmp(0x1018_1618, 0x20); goto l_0x1018_1618; /* jmp 0x10181618 */
        l_0x1018_15f8:
            ii(0x1018_15f8, 3); cmp(eax, 0x20);                         /* cmp eax, 0x20 */
            ii(0x1018_15fb, 2); if(jnz(0x1018_160f, 0x12)) goto l_0x1018_160f; /* jnz 0x1018160f */
            ii(0x1018_15fd, 3); mov(al, memb[ds, edx + 0x14]);          /* mov al, [edx+0x14] */
            ii(0x1018_1600, 2); and(al, 0x4);                           /* and al, 0x4 */
            ii(0x1018_1602, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_1607, 2); if(jnz(0x1018_1618, 0xf)) goto l_0x1018_1618; /* jnz 0x10181618 */
            ii(0x1018_1609, 4); or(memb[ds, edx + 0x14], 0x2);          /* or byte [edx+0x14], 0x2 */
            ii(0x1018_160d, 2); jmp(0x1018_1618, 0x9); goto l_0x1018_1618; /* jmp 0x10181618 */
        l_0x1018_160f:
            ii(0x1018_160f, 3); cmp(eax, 0x30);                         /* cmp eax, 0x30 */
            ii(0x1018_1612, 2); if(jnz(0x1018_161b, 0x7)) goto l_0x1018_161b; /* jnz 0x1018161b */
            ii(0x1018_1614, 4); mov(memb[ds, edx + 0x16], 0x30);        /* mov byte [edx+0x16], 0x30 */
        l_0x1018_1618:
            ii(0x1018_1618, 1); inc(ebx);                               /* inc ebx */
            ii(0x1018_1619, 2); jmp(0x1018_15c9, -0x52); goto l_0x1018_15c9; /* jmp 0x101815c9 */
        l_0x1018_161b:
            ii(0x1018_161b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_161d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_161e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_161f, 1); ret();                                  /* ret */
        }
    }
}

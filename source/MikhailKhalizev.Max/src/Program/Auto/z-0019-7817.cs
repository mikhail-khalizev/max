using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_7817-c76b3bb7")]
        public void Method_0019_7817()
        {
            ii(0x19_7817, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x19_781a, 3); or(ax, memw_a16[ss, bp - 0x16]);          /* or ax, [bp-0x16] */
            ii(0x19_781d, 2); if(jnzw(0x19_7822, 0x3)) goto l_0x19_7822; /* jnz 0x7822 */
            ii(0x19_781f, 3); jmpw(0x19_7839, 0x17); goto l_0x19_7839;  /* jmp 0x7839 */
        l_0x19_7822:
            ii(0x19_7822, 4); test(memb_a16[ss, bp - 0x22], 0x1);       /* test byte [bp-0x22], 0x1 */
            ii(0x19_7826, 2); if(jnzw(0x19_782b, 0x3)) goto l_0x19_782b; /* jnz 0x782b */
            ii(0x19_7828, 3); jmpw(0x19_7839, 0xe); goto l_0x19_7839;   /* jmp 0x7839 */
        l_0x19_782b:
            ii(0x19_782b, 3); mov(ax, memw_a16[ss, bp - 0x34]);         /* mov ax, [bp-0x34] */
            ii(0x19_782e, 3); mov(memw_a16[ss, bp - 0x34], ax);         /* mov [bp-0x34], ax */
            ii(0x19_7831, 5); mov(memw_a16[ss, bp - 0x32], 0);          /* mov word [bp-0x32], 0x0 */
            ii(0x19_7836, 3); jmpw(0x19_7880, 0x47); goto l_0x19_7880;  /* jmp 0x7880 */
        l_0x19_7839:
            ii(0x19_7839, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x19_783c, 3); or(ax, memw_a16[ss, bp - 0x16]);          /* or ax, [bp-0x16] */
            ii(0x19_783f, 2); if(jnzw(0x19_7844, 0x3)) goto l_0x19_7844; /* jnz 0x7844 */
            ii(0x19_7841, 3); jmpw(0x19_7880, 0x3c); goto l_0x19_7880;  /* jmp 0x7880 */
        l_0x19_7844:
            ii(0x19_7844, 3); lea(ax, bp - 0x34);                       /* lea ax, [bp-0x34] */
            ii(0x19_7847, 4); mov(memw_a16[ss, bp - 0xe2], ax);         /* mov [bp-0xe2], ax */
            ii(0x19_784b, 4); mov(memw_a16[ss, bp - 0xe0], ss);         /* mov [bp-0xe0], ss */
        l_0x19_784f:
            ii(0x19_784f, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x19_7853, 2); if(jnzw(0x19_7858, 0x3)) goto l_0x19_7858; /* jnz 0x7858 */
            ii(0x19_7855, 3); jmpw(0x19_7880, 0x28); goto l_0x19_7880;  /* jmp 0x7880 */
        l_0x19_7858:
            ii(0x19_7858, 4); test(memb_a16[ss, bp - 0x2], 0x1);        /* test byte [bp-0x2], 0x1 */
            ii(0x19_785c, 2); if(jnzw(0x19_7861, 0x3)) goto l_0x19_7861; /* jnz 0x7861 */
            ii(0x19_785e, 3); jmpw(0x19_7875, 0x14); goto l_0x19_7875;  /* jmp 0x7875 */
        l_0x19_7861:
            ii(0x19_7861, 4); les(bx, ss, bp - 0xe2);                   /* les bx, [bp-0xe2] */
            ii(0x19_7865, 3); mov(ax, memw_a16[es, bx]);                /* mov ax, [es:bx] */
            ii(0x19_7868, 4); les(bx, ss, bp - 0xe2);                   /* les bx, [bp-0xe2] */
            ii(0x19_786c, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_786f, 6); mov(memw_a16[es, bx + 0x2], 0);           /* mov word [es:bx+0x2], 0x0 */
        l_0x19_7875:
            ii(0x19_7875, 5); sub(memw_a16[ss, bp - 0xe2], 0x4);        /* sub word [bp-0xe2], 0x4 */
            ii(0x19_787a, 3); shr(memw_a16[ss, bp - 0x2], 0x1);         /* shr word [bp-0x2], 1 */
            ii(0x19_787d, 3); jmpw(0x19_784f, -0x31); goto l_0x19_784f; /* jmp 0x784f */
        l_0x19_7880:
            ii(0x19_7880, 1); pushw(ds);                                /* push ds */
            ii(0x19_7881, 3); lea(si, bp - 0x5c);                       /* lea si, [bp-0x5c] */
            ii(0x19_7884, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x19_7886, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_7888, 3); les(di, ss, bp + 0x8);                    /* les di, [bp+0x8] */
            ii(0x19_788b, 3); mov(cx, 0x1f);                            /* mov cx, 0x1f */
            ii(0x19_788e, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x19_7890, 1); popw(ds);                                 /* pop ds */
            ii(0x19_7891, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7894, 3); jmpw(0x19_7897, 0); goto l_0x19_7897;     /* jmp 0x7897 */
        l_0x19_7897:
            ii(0x19_7897, 1); popw(ds);                                 /* pop ds */
            ii(0x19_7898, 1); popw(si);                                 /* pop si */
            ii(0x19_7899, 1); popw(di);                                 /* pop di */
            ii(0x19_789a, 1); leavew();                                 /* leave */
            ii(0x19_789b, 1); retfw();                                  /* retf */
        }
    }
}

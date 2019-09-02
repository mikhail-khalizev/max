using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_7817-c76b3bb7")]
        public void Method_0019_7817()
        {
            ii(0x19_7817, 3); mov(ax, memw[ss, bp - 20]);               /* mov ax, [bp-0x14] */
            ii(0x19_781a, 3); or(ax, memw[ss, bp - 22]);                /* or ax, [bp-0x16] */
            ii(0x19_781d, 2); if(jnz(0x19_7822, 3)) goto l_0x19_7822;   /* jnz 0x7822 */
            ii(0x19_781f, 3); jmp(0x19_7839, 0x17); goto l_0x19_7839;   /* jmp 0x7839 */
        l_0x19_7822:
            ii(0x19_7822, 4); test(memb[ss, bp - 34], 1);               /* test byte [bp-0x22], 0x1 */
            ii(0x19_7826, 2); if(jnz(0x19_782b, 3)) goto l_0x19_782b;   /* jnz 0x782b */
            ii(0x19_7828, 3); jmp(0x19_7839, 0xe); goto l_0x19_7839;    /* jmp 0x7839 */
        l_0x19_782b:
            ii(0x19_782b, 3); mov(ax, memw[ss, bp - 52]);               /* mov ax, [bp-0x34] */
            ii(0x19_782e, 3); mov(memw[ss, bp - 52], ax);               /* mov [bp-0x34], ax */
            ii(0x19_7831, 5); mov(memw[ss, bp - 50], 0);                /* mov word [bp-0x32], 0x0 */
            ii(0x19_7836, 3); jmp(0x19_7880, 0x47); goto l_0x19_7880;   /* jmp 0x7880 */
        l_0x19_7839:
            ii(0x19_7839, 3); mov(ax, memw[ss, bp - 20]);               /* mov ax, [bp-0x14] */
            ii(0x19_783c, 3); or(ax, memw[ss, bp - 22]);                /* or ax, [bp-0x16] */
            ii(0x19_783f, 2); if(jnz(0x19_7844, 3)) goto l_0x19_7844;   /* jnz 0x7844 */
            ii(0x19_7841, 3); jmp(0x19_7880, 0x3c); goto l_0x19_7880;   /* jmp 0x7880 */
        l_0x19_7844:
            ii(0x19_7844, 3); lea(ax, memw[ss, bp - 52]);               /* lea ax, [bp-0x34] */
            ii(0x19_7847, 4); mov(memw[ss, bp - 226], ax);              /* mov [bp-0xe2], ax */
            ii(0x19_784b, 4); mov(memw[ss, bp - 224], ss);              /* mov [bp-0xe0], ss */
        l_0x19_784f:
            ii(0x19_784f, 4); cmp(memw[ss, bp - 2], 0);                 /* cmp word [bp-0x2], 0x0 */
            ii(0x19_7853, 2); if(jnz(0x19_7858, 3)) goto l_0x19_7858;   /* jnz 0x7858 */
            ii(0x19_7855, 3); jmp(0x19_7880, 0x28); goto l_0x19_7880;   /* jmp 0x7880 */
        l_0x19_7858:
            ii(0x19_7858, 4); test(memb[ss, bp - 2], 1);                /* test byte [bp-0x2], 0x1 */
            ii(0x19_785c, 2); if(jnz(0x19_7861, 3)) goto l_0x19_7861;   /* jnz 0x7861 */
            ii(0x19_785e, 3); jmp(0x19_7875, 0x14); goto l_0x19_7875;   /* jmp 0x7875 */
        l_0x19_7861:
            ii(0x19_7861, 4); les(bx, memw[ss, bp - 226]);              /* les bx, [bp-0xe2] */
            ii(0x19_7865, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_7868, 4); les(bx, memw[ss, bp - 226]);              /* les bx, [bp-0xe2] */
            ii(0x19_786c, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_786f, 6); mov(memw[es, bx + 2], 0);                 /* mov word [es:bx+0x2], 0x0 */
        l_0x19_7875:
            ii(0x19_7875, 5); sub(memw[ss, bp - 226], 4);               /* sub word [bp-0xe2], 0x4 */
            ii(0x19_787a, 3); shr(memw[ss, bp - 2], 1);                 /* shr word [bp-0x2], 1 */
            ii(0x19_787d, 3); jmp(0x19_784f, -0x31); goto l_0x19_784f;  /* jmp 0x784f */
        l_0x19_7880:
            ii(0x19_7880, 1); push(ds);                                 /* push ds */
            ii(0x19_7881, 3); lea(si, memw[ss, bp - 92]);               /* lea si, [bp-0x5c] */
            ii(0x19_7884, 2); mov(ax, ss);                              /* mov ax, ss */
            ii(0x19_7886, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_7888, 3); les(di, memw[ss, bp + 8]);                /* les di, [bp+0x8] */
            ii(0x19_788b, 3); mov(cx, 0x1f);                            /* mov cx, 0x1f */
            ii(0x19_788e, 2); rep(() => movsw());                       /* rep movsw */
            ii(0x19_7890, 1); pop(ds);                                  /* pop ds */
            ii(0x19_7891, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_7894, 3); jmp(0x19_7897, 0); goto l_0x19_7897;      /* jmp 0x7897 */
        l_0x19_7897:
            ii(0x19_7897, 1); pop(ds);                                  /* pop ds */
            ii(0x19_7898, 1); pop(si);                                  /* pop si */
            ii(0x19_7899, 1); pop(di);                                  /* pop di */
            ii(0x19_789a, 1); leave();                                  /* leave */
            ii(0x19_789b, 1); retf();                                   /* retf */
        }
    }
}

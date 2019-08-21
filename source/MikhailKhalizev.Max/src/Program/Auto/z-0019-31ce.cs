using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_31ce-ed1f3a3")]
        public void Method_0019_31ce()
        {
            ii(0x19_31ce, 1); pushw(ax);                                /* push ax */
            ii(0x19_31cf, 1); pushw(bx);                                /* push bx */
            ii(0x19_31d0, 1); pushw(cx);                                /* push cx */
            ii(0x19_31d1, 1); pushw(ds);                                /* push ds */
            ii(0x19_31d2, 1); pushw(es);                                /* push es */
            ii(0x19_31d3, 1); popw(ds);                                 /* pop ds */
            ii(0x19_31d4, 2); mov(cx, di);                              /* mov cx, di */
            ii(0x19_31d6, 2); sub(cx, dx);                              /* sub cx, dx */
            ii(0x19_31d8, 2); if(jcxzw(0x19_31ec, 0x12)) goto l_0x19_31ec; /* jcxz 0x31ec */
            ii(0x19_31da, 1); pushw(cx);                                /* push cx */
            ii(0x19_31db, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x19_31de, 2); mov(ah, 0x40);                            /* mov ah, 0x40 */
            ii(0x19_31e0, 2); @int(0x21);                               /* int 0x21 */
            ii(0x19_31e2, 1); popw(cx);                                 /* pop cx */
            ii(0x19_31e3, 2); if(jbw(0x19_31f3, 0xe)) goto l_0x19_31f3; /* jb 0x31f3 */
            ii(0x19_31e5, 3); add(memw_a16[ss, bp - 0x2], ax);          /* add [bp-0x2], ax */
            ii(0x19_31e8, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x19_31ea, 2); if(jaw(0x19_31f3, 0x7)) goto l_0x19_31f3; /* ja 0x31f3 */
        l_0x19_31ec:
            ii(0x19_31ec, 1); popw(ds);                                 /* pop ds */
            ii(0x19_31ed, 1); popw(cx);                                 /* pop cx */
            ii(0x19_31ee, 1); popw(bx);                                 /* pop bx */
            ii(0x19_31ef, 1); popw(ax);                                 /* pop ax */
            ii(0x19_31f0, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x19_31f2, 1); retw(); return;                           /* ret */
        l_0x19_31f3:
            ii(0x19_31f3, 1); lahf();                                   /* lahf */
            ii(0x19_31f4, 1); popw(ds);                                 /* pop ds */
            ii(0x19_31f5, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_31f8, 4); cmp(memw_a16[ss, bp - 0x2], 0);           /* cmp word [bp-0x2], 0x0 */
            ii(0x19_31fc, 2); if(jnzw_func(0x19_3223, 0x25)) return;    /* jnz 0x3223 */
            ii(0x19_31fe, 1); sahf();                                   /* sahf */
            ii(0x19_31ff, 2); if(jaew(0x19_3205, 0x4)) goto l_0x19_3205; /* jae 0x3205 */
            ii(0x19_3201, 2); mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0x19_3203, 2); if(jmpw_func(0x19_3229, 0x24)) return;    /* jmp 0x3229 */
        l_0x19_3205:
            ii(0x19_3205, 3); mov(ds, memw_a16[ss, bp - 0x6]);          /* mov ds, [bp-0x6] */
            ii(0x19_3208, 5); test(memb_a16[ds, bx + 0x3c21], 0x40);    /* test byte [bx+0x3c21], 0x40 */
            ii(0x19_320d, 2); if(jzw(0x19_321d, 0xe)) goto l_0x19_321d; /* jz 0x321d */
            ii(0x19_320f, 3); mov(ds, memw_a16[ss, bp + 0xa]);          /* mov ds, [bp+0xa] */
            ii(0x19_3212, 3); mov(bx, memw_a16[ss, bp + 0x8]);          /* mov bx, [bp+0x8] */
            ii(0x19_3215, 3); cmp(memb_a16[ds, bx], 0x1a);              /* cmp byte [bx], 0x1a */
            ii(0x19_3218, 2); if(jnzw(0x19_321d, 0x3)) goto l_0x19_321d; /* jnz 0x321d */
            ii(0x19_321a, 1); clc();                                    /* clc */
            ii(0x19_321b, 2); if(jmpw_func(0x19_3229, 0xc)) return;     /* jmp 0x3229 */
        l_0x19_321d:
            ii(0x19_321d, 1); stc();                                    /* stc */
            ii(0x19_321e, 3); mov(ax, 0x1c00);                          /* mov ax, 0x1c00 */
            ii(0x19_3221, 2); if(jmpw_func(0x19_3229, 0x6)) return;     /* jmp 0x3229 */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("51329e8e-7e62-4f32-9ef1-3ad12d491712")]
        public void Method_0019_8399()
        {
            ii(0x19_8399, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x19_839d, 1); pushw(di);                                /* push di */
            ii(0x19_839e, 1); pushw(si);                                /* push si */
            ii(0x19_839f, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x19_83a4, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_83a7, 2); if(jnzw(0x19_83ac, 0x3)) goto l_0x19_83ac; /* jnz 0x83ac */
            ii(0x19_83a9, 3); jmpw(0x19_83b9, 0xd); goto l_0x19_83b9;   /* jmp 0x83b9 */
        l_0x19_83ac:
            ii(0x19_83ac, 1); pushw(ds);                                /* push ds */
            ii(0x19_83ad, 3); pushw(0x16f4);                            /* push 0x16f4 */
            ii(0x19_83b0, 3); callw(0x19_105e, -0x7355);                /* call 0x105e */
            ii(0x19_83b3, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_83b6, 3); jmpw(0x19_8458, 0x9f); goto l_0x19_8458;  /* jmp 0x8458 */
        l_0x19_83b9:
            ii(0x19_83b9, 5); callw_far_abs(0x80, 0x1708);              /* call word 0x80:0x1708 */
            ii(0x19_83be, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_83c1, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_83c4, 1); pushw(ds);                                /* push ds */
            ii(0x19_83c5, 3); pushw(0x1706);                            /* push 0x1706 */
            ii(0x19_83c8, 3); callw(0x19_105e, -0x736d);                /* call 0x105e */
            ii(0x19_83cb, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_83ce, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_83d1, 3); and(ax, 0x8000);                          /* and ax, 0x8000 */
            ii(0x19_83d4, 1); pushw(ax);                                /* push ax */
            ii(0x19_83d5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_83d7, 1); pushw(ds);                                /* push ds */
            ii(0x19_83d8, 3); pushw(0x170c);                            /* push 0x170c */
            ii(0x19_83db, 3); callw(0x19_8367, -0x77);                  /* call 0x8367 */
            ii(0x19_83de, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_83e1, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x19_83e4, 3); and(ax, 0x10);                            /* and ax, 0x10 */
            ii(0x19_83e7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_83e9, 1); pushw(ax);                                /* push ax */
            ii(0x19_83ea, 1); pushw(ds);                                /* push ds */
            ii(0x19_83eb, 3); pushw(0x170f);                            /* push 0x170f */
            ii(0x19_83ee, 3); callw(0x19_8367, -0x8a);                  /* call 0x8367 */
            ii(0x19_83f1, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_83f4, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x19_83f7, 3); and(ax, 0x8);                             /* and ax, 0x8 */
            ii(0x19_83fa, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_83fc, 1); pushw(ax);                                /* push ax */
            ii(0x19_83fd, 1); pushw(ds);                                /* push ds */
            ii(0x19_83fe, 3); pushw(0x1712);                            /* push 0x1712 */
            ii(0x19_8401, 3); callw(0x19_8367, -0x9d);                  /* call 0x8367 */
            ii(0x19_8404, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_8407, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x19_840a, 3); and(ax, 0x4);                             /* and ax, 0x4 */
            ii(0x19_840d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_840f, 1); pushw(ax);                                /* push ax */
            ii(0x19_8410, 1); pushw(ds);                                /* push ds */
            ii(0x19_8411, 3); pushw(0x1715);                            /* push 0x1715 */
            ii(0x19_8414, 3); callw(0x19_8367, -0xb0);                  /* call 0x8367 */
            ii(0x19_8417, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_841a, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x19_841d, 3); and(ax, 0x2);                             /* and ax, 0x2 */
            ii(0x19_8420, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_8422, 1); pushw(ax);                                /* push ax */
            ii(0x19_8423, 1); pushw(ds);                                /* push ds */
            ii(0x19_8424, 3); pushw(0x1718);                            /* push 0x1718 */
            ii(0x19_8427, 3); callw(0x19_8367, -0xc3);                  /* call 0x8367 */
            ii(0x19_842a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_842d, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x19_8430, 3); and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x19_8433, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_8435, 1); pushw(ax);                                /* push ax */
            ii(0x19_8436, 1); pushw(ds);                                /* push ds */
            ii(0x19_8437, 3); pushw(0x171b);                            /* push 0x171b */
            ii(0x19_843a, 3); callw(0x19_8367, -0xd6);                  /* call 0x8367 */
            ii(0x19_843d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_8440, 5); callw_far_abs(0x80, 0x171e);              /* call word 0x80:0x171e */
            ii(0x19_8445, 1); pushw(dx);                                /* push dx */
            ii(0x19_8446, 1); pushw(ax);                                /* push ax */
            ii(0x19_8447, 5); callw_far_abs(0x80, 0x1713);              /* call word 0x80:0x1713 */
            ii(0x19_844c, 1); pushw(dx);                                /* push dx */
            ii(0x19_844d, 1); pushw(ax);                                /* push ax */
            ii(0x19_844e, 1); pushw(ds);                                /* push ds */
            ii(0x19_844f, 3); pushw(0x171e);                            /* push 0x171e */
            ii(0x19_8452, 3); callw(0x19_105e, -0x73f7);                /* call 0x105e */
            ii(0x19_8455, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_8458:
            ii(0x19_8458, 1); popw(si);                                 /* pop si */
            ii(0x19_8459, 1); popw(di);                                 /* pop di */
            ii(0x19_845a, 1); leavew();                                 /* leave */
            ii(0x19_845b, 1); retfw(); return;                          /* retf */
        }
    }
}

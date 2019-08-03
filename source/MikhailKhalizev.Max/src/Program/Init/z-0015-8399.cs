using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a5cc081a-33db-429d-a68f-7a741c58d716")]
        public void Method_0015_8399()
        {
            ii(0x15_8399, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_839d, 1); pushw(di);                                /* push di */
            ii(0x15_839e, 1); pushw(si);                                /* push si */
            ii(0x15_839f, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x15_83a4, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_83a7, 2); if(jnzw(0x15_83ac, 0x3)) goto l_0x15_83ac; /* jnz 0x83ac */
            ii(0x15_83a9, 3); jmpw(0x15_83b9, 0xd); goto l_0x15_83b9;   /* jmp 0x83b9 */
        l_0x15_83ac:
            ii(0x15_83ac, 1); pushw(ds);                                /* push ds */
            ii(0x15_83ad, 3); pushw(0x16f4);                            /* push 0x16f4 */
            ii(0x15_83b0, 3); callw(0x15_105e, -0x7355);                /* call 0x105e */
            ii(0x15_83b3, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_83b6, 3); jmpw(0x15_8458, 0x9f); goto l_0x15_8458;  /* jmp 0x8458 */
        l_0x15_83b9:
            ii(0x15_83b9, 5); callw_far_abs(0x80, 0x1708);              /* call word 0x80:0x1708 */
            ii(0x15_83be, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_83c1, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_83c4, 1); pushw(ds);                                /* push ds */
            ii(0x15_83c5, 3); pushw(0x1706);                            /* push 0x1706 */
            ii(0x15_83c8, 3); callw(0x15_105e, -0x736d);                /* call 0x105e */
            ii(0x15_83cb, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_83ce, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_83d1, 3); and(ax, 0x8000);                          /* and ax, 0x8000 */
            ii(0x15_83d4, 1); pushw(ax);                                /* push ax */
            ii(0x15_83d5, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_83d7, 1); pushw(ds);                                /* push ds */
            ii(0x15_83d8, 3); pushw(0x170c);                            /* push 0x170c */
            ii(0x15_83db, 3); callw(0x15_8367, -0x77);                  /* call 0x8367 */
            ii(0x15_83de, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_83e1, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x15_83e4, 3); and(ax, 0x10);                            /* and ax, 0x10 */
            ii(0x15_83e7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_83e9, 1); pushw(ax);                                /* push ax */
            ii(0x15_83ea, 1); pushw(ds);                                /* push ds */
            ii(0x15_83eb, 3); pushw(0x170f);                            /* push 0x170f */
            ii(0x15_83ee, 3); callw(0x15_8367, -0x8a);                  /* call 0x8367 */
            ii(0x15_83f1, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_83f4, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x15_83f7, 3); and(ax, 0x8);                             /* and ax, 0x8 */
            ii(0x15_83fa, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_83fc, 1); pushw(ax);                                /* push ax */
            ii(0x15_83fd, 1); pushw(ds);                                /* push ds */
            ii(0x15_83fe, 3); pushw(0x1712);                            /* push 0x1712 */
            ii(0x15_8401, 3); callw(0x15_8367, -0x9d);                  /* call 0x8367 */
            ii(0x15_8404, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_8407, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x15_840a, 3); and(ax, 0x4);                             /* and ax, 0x4 */
            ii(0x15_840d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_840f, 1); pushw(ax);                                /* push ax */
            ii(0x15_8410, 1); pushw(ds);                                /* push ds */
            ii(0x15_8411, 3); pushw(0x1715);                            /* push 0x1715 */
            ii(0x15_8414, 3); callw(0x15_8367, -0xb0);                  /* call 0x8367 */
            ii(0x15_8417, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_841a, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x15_841d, 3); and(ax, 0x2);                             /* and ax, 0x2 */
            ii(0x15_8420, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_8422, 1); pushw(ax);                                /* push ax */
            ii(0x15_8423, 1); pushw(ds);                                /* push ds */
            ii(0x15_8424, 3); pushw(0x1718);                            /* push 0x1718 */
            ii(0x15_8427, 3); callw(0x15_8367, -0xc3);                  /* call 0x8367 */
            ii(0x15_842a, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_842d, 3); mov(al, memb_a16[ss, bp - 0x4]);          /* mov al, [bp-0x4] */
            ii(0x15_8430, 3); and(ax, 0x1);                             /* and ax, 0x1 */
            ii(0x15_8433, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_8435, 1); pushw(ax);                                /* push ax */
            ii(0x15_8436, 1); pushw(ds);                                /* push ds */
            ii(0x15_8437, 3); pushw(0x171b);                            /* push 0x171b */
            ii(0x15_843a, 3); callw(0x15_8367, -0xd6);                  /* call 0x8367 */
            ii(0x15_843d, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_8440, 5); callw_far_abs(0x80, 0x171e);              /* call word 0x80:0x171e */
            ii(0x15_8445, 1); pushw(dx);                                /* push dx */
            ii(0x15_8446, 1); pushw(ax);                                /* push ax */
            ii(0x15_8447, 5); callw_far_abs(0x80, 0x1713);              /* call word 0x80:0x1713 */
            ii(0x15_844c, 1); pushw(dx);                                /* push dx */
            ii(0x15_844d, 1); pushw(ax);                                /* push ax */
            ii(0x15_844e, 1); pushw(ds);                                /* push ds */
            ii(0x15_844f, 3); pushw(0x171e);                            /* push 0x171e */
            ii(0x15_8452, 3); callw(0x15_105e, -0x73f7);                /* call 0x105e */
            ii(0x15_8455, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x15_8458:
            ii(0x15_8458, 1); popw(si);                                 /* pop si */
            ii(0x15_8459, 1); popw(di);                                 /* pop di */
            ii(0x15_845a, 1); leavew();                                 /* leave */
            ii(0x15_845b, 1); retfw(); return;                          /* retf */
        }
    }
}

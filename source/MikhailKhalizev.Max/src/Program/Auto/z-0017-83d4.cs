using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("671012f0-861e-4d36-bdaf-7411481e8e21")]
        public void Method_0017_83d4()
        {
            ii(0x17_83d4, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x17_83d8, 1); pushw(si);                                /* push si */
            ii(0x17_83d9, 1); pushw(ds);                                /* push ds */
            ii(0x17_83da, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_83dd, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_83df, 3); mov(ax, memw_a16[ds, 0xa2e]);             /* mov ax, [0xa2e] */
            ii(0x17_83e2, 4); or(ax, memw_a16[ds, 0xa2c]);              /* or ax, [0xa2c] */
            ii(0x17_83e6, 2); if(jnzw(0x17_83ec, 0x4)) goto l_0x17_83ec; /* jnz 0x83ec */
            ii(0x17_83e8, 1); popw(ds);                                 /* pop ds */
            ii(0x17_83e9, 1); popw(si);                                 /* pop si */
            ii(0x17_83ea, 1); leavew();                                 /* leave */
            ii(0x17_83eb, 1); retfw(); return;                          /* retf */
        l_0x17_83ec:
            ii(0x17_83ec, 1); pushw(cs);                                /* push cs */
            ii(0x17_83ed, 3); callw(0x17_8d64, 0x974);                  /* call 0x8d64 */
            ii(0x17_83f0, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x17_83f4, 4); mov(al, memb_a16[es, bx + 0x13]);         /* mov al, [es:bx+0x13] */
            ii(0x17_83f8, 3); mov(memb_a16[ss, bp - 0x2], al);          /* mov [bp-0x2], al */
            ii(0x17_83fb, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x17_8400, 2); jmpw(0x17_8405, 0x3); goto l_0x17_8405;   /* jmp 0x8405 */
        l_0x17_8402:
            ii(0x17_8402, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
        l_0x17_8405:
            ii(0x17_8405, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_8408, 4); cmp(memw_a16[ds, 0xa24], ax);             /* cmp [0xa24], ax */
            ii(0x17_840c, 2); if(jbew(0x17_8430, 0x22)) goto l_0x17_8430; /* jbe 0x8430 */
            ii(0x17_840e, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_8410, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x17_8412, 2); add(si, ax);                              /* add si, ax */
            ii(0x17_8414, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x17_8416, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x17_841a, 4); mov(al, memb_a16[es, bx + si + 0x4]);     /* mov al, [es:bx+si+0x4] */
            ii(0x17_841e, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x17_8422, 4); mov(memb_a16[es, bx + 0x13], al);         /* mov [es:bx+0x13], al */
            ii(0x17_8426, 2); pushw(0x13);                              /* push 0x13 */
            ii(0x17_8428, 1); nop();                                    /* nop */
            ii(0x17_8429, 1); pushw(cs);                                /* push cs */
            ii(0x17_842a, 3); callw(0x17_0791, -0x7c9c);                /* call 0x791 */
            ii(0x17_842d, 2); jmpw(0x17_8402, -0x2d); goto l_0x17_8402; /* jmp 0x8402 */
        //    ii(0x17_842f, 1); nop();                                    /* nop */
        l_0x17_8430:
            ii(0x17_8430, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x17_8433, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x17_8437, 4); mov(memb_a16[es, bx + 0x13], al);         /* mov [es:bx+0x13], al */
            ii(0x17_843b, 1); popw(ds);                                 /* pop ds */
            ii(0x17_843c, 1); popw(si);                                 /* pop si */
            ii(0x17_843d, 1); leavew();                                 /* leave */
            ii(0x17_843e, 1); retfw(); return;                          /* retf */
        }
    }
}

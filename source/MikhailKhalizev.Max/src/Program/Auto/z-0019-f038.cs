using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f038-548de469")]
        public void Method_0019_f038()
        {
            ii(0x19_f038, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x19_f03c, 1); pushw(di);                                /* push di */
            ii(0x19_f03d, 1); pushw(si);                                /* push si */
            ii(0x19_f03e, 3); mov(si, 0);                               /* mov si, 0x0 */
            ii(0x19_f041, 3); jmpw(0x19_f045, 0x1); goto l_0x19_f045;   /* jmp 0xf045 */
        l_0x19_f044:
            ii(0x19_f044, 1); inc(si);                                  /* inc si */
        l_0x19_f045:
            ii(0x19_f045, 3); cmp(si, 0x4);                             /* cmp si, 0x4 */
            ii(0x19_f048, 2); if(jlw(0x19_f04d, 0x3)) goto l_0x19_f04d; /* jl 0xf04d */
            ii(0x19_f04a, 3); jmpw(0x19_f0c4, 0x77); goto l_0x19_f0c4;  /* jmp 0xf0c4 */
        l_0x19_f04d:
            ii(0x19_f04d, 3); imul(bx, si, 0x1b);                       /* imul bx, si, 0x1b */
            ii(0x19_f050, 5); cmp(memb_a16[ds, bx + 0x2e53], 0);        /* cmp byte [bx+0x2e53], 0x0 */
            ii(0x19_f055, 2); if(jzw(0x19_f05a, 0x3)) goto l_0x19_f05a; /* jz 0xf05a */
            ii(0x19_f057, 3); jmpw(0x19_f0c1, 0x67); goto l_0x19_f0c1;  /* jmp 0xf0c1 */
        l_0x19_f05a:
            ii(0x19_f05a, 3); imul(ax, si, 0x1b);                       /* imul ax, si, 0x1b */
            ii(0x19_f05d, 3); add(ax, 0x2e3c);                          /* add ax, 0x2e3c */
            ii(0x19_f060, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_f063, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
            ii(0x19_f066, 3); mov(al, memb_a16[ss, bp + 0xa]);          /* mov al, [bp+0xa] */
            ii(0x19_f069, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f06c, 4); mov(memb_a16[es, bx + 0x17], al);         /* mov [es:bx+0x17], al */
            ii(0x19_f070, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_f073, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f076, 4); mov(memw_a16[es, bx + 0x14], ax);         /* mov [es:bx+0x14], ax */
            ii(0x19_f07a, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_f07d, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f080, 4); mov(memw_a16[es, bx + 0x10], ax);         /* mov [es:bx+0x10], ax */
            ii(0x19_f084, 6); mov(memw_a16[es, bx + 0x12], 0);          /* mov word [es:bx+0x12], 0x0 */
            ii(0x19_f08a, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f08d, 5); mov(memb_a16[es, bx + 0x16], 0x3);        /* mov byte [es:bx+0x16], 0x3 */
            ii(0x19_f092, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f095, 5); mov(memb_a16[es, bx + 0x19], 0);          /* mov byte [es:bx+0x19], 0x0 */
            ii(0x19_f09a, 2); mov(al, 0);                               /* mov al, 0x0 */
            ii(0x19_f09c, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f09f, 4); mov(memb_a16[es, bx + 0x18], al);         /* mov [es:bx+0x18], al */
            ii(0x19_f0a3, 1); cbw();                                    /* cbw */
            ii(0x19_f0a4, 1); cwd();                                    /* cwd */
            ii(0x19_f0a5, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f0a8, 4); mov(memw_a16[es, bx + 0xc], ax);          /* mov [es:bx+0xc], ax */
            ii(0x19_f0ac, 4); mov(memw_a16[es, bx + 0xe], dx);          /* mov [es:bx+0xe], dx */
            ii(0x19_f0b0, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x19_f0b3, 4); mov(memw_a16[es, bx + 0x8], ax);          /* mov [es:bx+0x8], ax */
            ii(0x19_f0b7, 4); mov(memw_a16[es, bx + 0xa], dx);          /* mov [es:bx+0xa], dx */
            ii(0x19_f0bb, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_f0be, 3); jmpw(0x19_f0ca, 0x9); goto l_0x19_f0ca;   /* jmp 0xf0ca */
        l_0x19_f0c1:
            ii(0x19_f0c1, 3); jmpw(0x19_f044, -0x80); goto l_0x19_f044; /* jmp 0xf044 */
        l_0x19_f0c4:
            ii(0x19_f0c4, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_f0c7, 3); jmpw(0x19_f0ca, 0); goto l_0x19_f0ca;     /* jmp 0xf0ca */
        l_0x19_f0ca:
            ii(0x19_f0ca, 1); popw(si);                                 /* pop si */
            ii(0x19_f0cb, 1); popw(di);                                 /* pop di */
            ii(0x19_f0cc, 1); leavew();                                 /* leave */
            ii(0x19_f0cd, 1); retfw(); return;                          /* retf */
        }
    }
}

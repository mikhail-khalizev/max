using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("db21b19e-aac9-4ca0-9fda-31b0e88b304c")]
        public void Method_0013_998a()
        {
            ii(0x13_998a, 4); enterw(0x12, 0);                          /* enter 0x12, 0x0 */
            ii(0x13_998e, 1); pushw(di);                                /* push di */
            ii(0x13_998f, 1); pushw(si);                                /* push si */
            ii(0x13_9990, 1); pushw(ds);                                /* push ds */
            ii(0x13_9991, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_9994, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_9996, 1); pushw(cs);                                /* push cs */
            ii(0x13_9997, 3); callw(0x13_bb08, 0x216e);                 /* call 0xbb08 */
            ii(0x13_999a, 3); mov(memw_a16[ds, 0x1fa8], ax);            /* mov [0x1fa8], ax */
            ii(0x13_999d, 4); mov(memw_a16[ds, 0x1faa], dx);            /* mov [0x1faa], dx */
            ii(0x13_99a1, 5); mov(memw_a16[ss, bp - 0x10], 0x24);       /* mov word [bp-0x10], 0x24 */
            ii(0x13_99a6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_99a9, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x13_99ad, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x13_99b1, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x13_99b3, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x13_99b5, 4); test(dx, 0xffff);                         /* test dx, 0xffff */
            ii(0x13_99b9, 2); if(jzw(0x13_99f0, 0x35)) goto l_0x13_99f0; /* jz 0x99f0 */
            ii(0x13_99bb, 2); pushw(0x24);                              /* push 0x24 */
            ii(0x13_99bd, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x13_99c1, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x13_99c3, 1); pushw(ax);                                /* push ax */
            ii(0x13_99c4, 1); pushw(dx);                                /* push dx */
            ii(0x13_99c5, 2); mov(di, cx);                              /* mov di, cx */
            ii(0x13_99c7, 1); nop();                                    /* nop */
            ii(0x13_99c8, 1); pushw(cs);                                /* push cs */
            ii(0x13_99c9, 3); callw(0x13_e91a, 0x4f4e);                 /* call 0xe91a */
            ii(0x13_99cc, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_99cf, 2); add(ax, di);                              /* add ax, di */
            ii(0x13_99d1, 2); adc(dx, si);                              /* adc dx, si */
            ii(0x13_99d3, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x13_99d6, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x13_99d9, 1); pushw(dx);                                /* push dx */
            ii(0x13_99da, 1); pushw(ax);                                /* push ax */
            ii(0x13_99db, 1); nop();                                    /* nop */
            ii(0x13_99dc, 1); pushw(cs);                                /* push cs */
            ii(0x13_99dd, 3); callw(0x13_e96a, 0x4f8a);                 /* call 0xe96a */
            ii(0x13_99e0, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_99e3, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x13_99e6, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x13_99e9, 4); mov(memb_a16[ss, bp - 0x6], 0x1);         /* mov byte [bp-0x6], 0x1 */
            ii(0x13_99ed, 2); jmpw(0x13_99fe, 0xf); goto l_0x13_99fe;   /* jmp 0x99fe */
        //    ii(0x13_99ef, 1); nop();                                    /* nop */
        l_0x13_99f0:
            ii(0x13_99f0, 4); mov(ax, memw_a16[es, bx + 0x2]);          /* mov ax, [es:bx+0x2] */
            ii(0x13_99f4, 3); mov(memw_a16[ss, bp - 0xa], cx);          /* mov [bp-0xa], cx */
            ii(0x13_99f7, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_99fa, 4); mov(memb_a16[ss, bp - 0x6], 0);           /* mov byte [bp-0x6], 0x0 */
        l_0x13_99fe:
            ii(0x13_99fe, 5); mov(memw_a16[ss, bp - 0x4], 0x1fa8);      /* mov word [bp-0x4], 0x1fa8 */
            ii(0x13_9a03, 3); mov(memw_a16[ss, bp - 0x2], ds);          /* mov [bp-0x2], ds */
        l_0x13_9a06:
            ii(0x13_9a06, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x13_9a09, 3); dec(memw_a16[ss, bp - 0x10]);             /* dec word [bp-0x10] */
            ii(0x13_9a0c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_9a0e, 2); if(jzw(0x13_9a24, 0x14)) goto l_0x13_9a24; /* jz 0x9a24 */
            ii(0x13_9a10, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x13_9a13, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x13_9a16, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x13_9a19, 3); les(bx, ss, bp - 0xa);                    /* les bx, [bp-0xa] */
            ii(0x13_9a1c, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
            ii(0x13_9a1f, 3); mov(memb_a16[es, bx], al);                /* mov [es:bx], al */
            ii(0x13_9a22, 2); jmpw(0x13_9a06, -0x1e); goto l_0x13_9a06; /* jmp 0x9a06 */
        l_0x13_9a24:
            ii(0x13_9a24, 4); cmp(memb_a16[ss, bp - 0x6], 0);           /* cmp byte [bp-0x6], 0x0 */
            ii(0x13_9a28, 2); if(jzw(0x13_9a38, 0xe)) goto l_0x13_9a38; /* jz 0x9a38 */
            ii(0x13_9a2a, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x13_9a2d, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x13_9a30, 1); nop();                                    /* nop */
            ii(0x13_9a31, 1); pushw(cs);                                /* push cs */
            ii(0x13_9a32, 3); callw(0x13_e758, 0x4d23);                 /* call 0xe758 */
            ii(0x13_9a35, 3); add(sp, 0x4);                             /* add sp, 0x4 */
        l_0x13_9a38:
            ii(0x13_9a38, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x13_9a3b, 5); and(memb_a16[es, bx + 0x2c], -0x2 /* 0xfe */); /* and byte [es:bx+0x2c], 0xfe */
            ii(0x13_9a40, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9a41, 1); popw(si);                                 /* pop si */
            ii(0x13_9a42, 1); popw(di);                                 /* pop di */
            ii(0x13_9a43, 1); leavew();                                 /* leave */
            ii(0x13_9a44, 1); retfw(); return;                          /* retf */
        }
    }
}

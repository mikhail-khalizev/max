using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fedf5f3a-2512-42f9-87bc-29d937b4bb00")]
        public void Method_0019_a06c()
        {
            ii(0x19_a06c, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_a070, 1); pushw(di);                                /* push di */
            ii(0x19_a071, 1); pushw(si);                                /* push si */
            ii(0x19_a072, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_a075, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a077, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_a07b, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_a07e, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_a082, 6); cmp(memw_a16[es, bx + 0x1362], 0x10);     /* cmp word [es:bx+0x1362], 0x10 */
            ii(0x19_a088, 2); if(jbw(0x19_a090, 0x6)) goto l_0x19_a090; /* jb 0xa090 */
        l_0x19_a08a:
            ii(0x19_a08a, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x19_a08d, 3); jmpw(0x19_a146, 0xb6); goto l_0x19_a146;  /* jmp 0xa146 */
        l_0x19_a090:
            ii(0x19_a090, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x19_a093, 2); jmpw(0x19_a098, 0x3); goto l_0x19_a098;   /* jmp 0xa098 */
        l_0x19_a095:
            ii(0x19_a095, 3); inc(memw_a16[ss, bp - 0x2]);              /* inc word [bp-0x2] */
        l_0x19_a098:
            ii(0x19_a098, 4); mov(bx, memw_a16[ds, 0x1f1a]);            /* mov bx, [0x1f1a] */
            ii(0x19_a09c, 4); add(bx, 0x1352);                          /* add bx, 0x1352 */
            ii(0x19_a0a0, 3); mov(si, memw_a16[ss, bp - 0x2]);          /* mov si, [bp-0x2] */
            ii(0x19_a0a3, 4); cmp(memb_a16[es, bx + si], 0);            /* cmp byte [es:bx+si], 0x0 */
            ii(0x19_a0a7, 2); if(jzw(0x19_a0b0, 0x7)) goto l_0x19_a0b0; /* jz 0xa0b0 */
            ii(0x19_a0a9, 3); cmp(si, 0x10);                            /* cmp si, 0x10 */
            ii(0x19_a0ac, 2); if(jbw(0x19_a095, -0x19)) goto l_0x19_a095; /* jb 0xa095 */
            ii(0x19_a0ae, 2); jmpw(0x19_a08a, -0x26); goto l_0x19_a08a; /* jmp 0xa08a */
        l_0x19_a0b0:
            ii(0x19_a0b0, 4); imul(ax, si, 0x134);                      /* imul ax, si, 0x134 */
            ii(0x19_a0b4, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_a0b6, 4); add(ax, memw_a16[ds, 0x1f1a]);            /* add ax, [0x1f1a] */
            ii(0x19_a0ba, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x19_a0bc, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_a0be, 2); mov(si, es);                              /* mov si, es */
            ii(0x19_a0c0, 3); add(ax, 0x12);                            /* add ax, 0x12 */
            ii(0x19_a0c3, 3); les(di, ss, bp + 0x4);                    /* les di, [bp+0x4] */
            ii(0x19_a0c6, 3); mov(memw_a16[es, di], ax);                /* mov [es:di], ax */
            ii(0x19_a0c9, 4); mov(memw_a16[es, di + 0x2], dx);          /* mov [es:di+0x2], dx */
            ii(0x19_a0cd, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_a0cf, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_a0d3, 3); mov(di, memw_a16[ss, bp - 0x2]);          /* mov di, [bp-0x2] */
            ii(0x19_a0d6, 6); mov(memb_a16[es, bx + di + 0x1352], 0x1); /* mov byte [es:bx+di+0x1352], 0x1 */
            ii(0x19_a0dc, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_a0df, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_a0e2, 3); add(ax, 0xfc);                            /* add ax, 0xfc */
            ii(0x19_a0e5, 1); pushw(si);                                /* push si */
            ii(0x19_a0e6, 1); pushw(ax);                                /* push ax */
            ii(0x19_a0e7, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x19_a0e9, 3); callw(0x19_d4c3, 0x33d7);                 /* call 0xd4c3 */
            ii(0x19_a0ec, 4); cmp(memw_a16[ss, bp + 0xa], 0);           /* cmp word [bp+0xa], 0x0 */
            ii(0x19_a0f0, 2); if(jzw(0x19_a124, 0x32)) goto l_0x19_a124; /* jz 0xa124 */
            ii(0x19_a0f2, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_a0f5, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_a0f8, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_a0fa, 4); add(si, memw_a16[ds, 0x1f1a]);            /* add si, [0x1f1a] */
            ii(0x19_a0fe, 4); mov(cx, memw_a16[ds, 0x1f1c]);            /* mov cx, [0x1f1c] */
            ii(0x19_a102, 4); add(si, 0x84);                            /* add si, 0x84 */
            ii(0x19_a106, 1); pushw(cx);                                /* push cx */
            ii(0x19_a107, 1); pushw(si);                                /* push si */
            ii(0x19_a108, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_a10a, 1); nop();                                    /* nop */
            ii(0x19_a10b, 1); pushw(cs);                                /* push cs */
            ii(0x19_a10c, 3); callw(0x1a_01ed, 0x60de);                 /* call 0x1ed */
            ii(0x19_a10f, 4); add(si, memw_a16[ds, 0x1f1a]);            /* add si, [0x1f1a] */
            ii(0x19_a113, 4); mov(cx, memw_a16[ds, 0x1f1c]);            /* mov cx, [0x1f1c] */
            ii(0x19_a117, 4); add(si, 0x84);                            /* add si, 0x84 */
            ii(0x19_a11b, 1); pushw(cx);                                /* push cx */
            ii(0x19_a11c, 1); pushw(si);                                /* push si */
            ii(0x19_a11d, 5); callw_far_abs(0x80, 0x4508);              /* call word 0x80:0x4508 */
            ii(0x19_a122, 1); popw(bx);                                 /* pop bx */
            ii(0x19_a123, 1); popw(bx);                                 /* pop bx */
        l_0x19_a124:
            ii(0x19_a124, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_a127, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x19_a12b, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x19_a12e, 3); callw(0x19_9e0e, -0x323);                 /* call 0x9e0e */
            ii(0x19_a131, 2); mov(bx, di);                              /* mov bx, di */
            ii(0x19_a133, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x19_a135, 6); mov(memw_a16[ds, bx + 0x1f24], 0x1);      /* mov word [bx+0x1f24], 0x1 */
            ii(0x19_a13b, 4); les(bx, ds, 0x1f1a);                      /* les bx, [0x1f1a] */
            ii(0x19_a13f, 5); inc(memw_a16[es, bx + 0x1362]);           /* inc word [es:bx+0x1362] */
            ii(0x19_a144, 2); mov(ax, di);                              /* mov ax, di */
        l_0x19_a146:
            ii(0x19_a146, 1); popw(si);                                 /* pop si */
            ii(0x19_a147, 1); popw(di);                                 /* pop di */
            ii(0x19_a148, 1); leavew();                                 /* leave */
            ii(0x19_a149, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}

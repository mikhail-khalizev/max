using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7cd33d36-0bcb-40e1-b342-d356ce5786c1")]
        public void Method_0015_e49a()
        {
            ii(0x15_e49a, 4); enterw(0x1a, 0);                          /* enter 0x1a, 0x0 */
            ii(0x15_e49e, 1); pushw(di);                                /* push di */
            ii(0x15_e49f, 1); pushw(si);                                /* push si */
            ii(0x15_e4a0, 4); mov(es, memw_a16[ds, 0x3fce]);            /* mov es, [0x3fce] */
            ii(0x15_e4a4, 4); mov(ax, memw_a16[es, 0x3b7a]);            /* mov ax, [es:0x3b7a] */
            ii(0x15_e4a8, 6); mov(memw_a16[ds, 0x2c22], 0);             /* mov word [0x2c22], 0x0 */
            ii(0x15_e4ae, 3); mov(memw_a16[ds, 0x2c24], ax);            /* mov [0x2c24], ax */
            ii(0x15_e4b1, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_e4b4, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x15_e4b8, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x15_e4bb, 1); nop();                                    /* nop */
            ii(0x15_e4bc, 1); pushw(cs);                                /* push cs */
            ii(0x15_e4bd, 3); callw(0x15_e596, 0xd6);                   /* call 0xe596 */
            ii(0x15_e4c0, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_e4c3, 1); nop();                                    /* nop */
            ii(0x15_e4c4, 1); pushw(cs);                                /* push cs */
            ii(0x15_e4c5, 3); callw(0x15_e402, -0xc6);                  /* call 0xe402 */
            ii(0x15_e4c8, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x15_e4cb, 2); if(jnzw(0x15_e4d0, 0x3)) goto l_0x15_e4d0; /* jnz 0xe4d0 */
            ii(0x15_e4cd, 3); jmpw(0x15_e559, 0x89); goto l_0x15_e559;  /* jmp 0xe559 */
        l_0x15_e4d0:
            ii(0x15_e4d0, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_e4d3, 4); pushw(memw_a16[es, bx + 0x6]);            /* push word [es:bx+0x6] */
            ii(0x15_e4d7, 4); pushw(memw_a16[es, bx + 0x4]);            /* push word [es:bx+0x4] */
            ii(0x15_e4db, 1); nop();                                    /* nop */
            ii(0x15_e4dc, 1); pushw(cs);                                /* push cs */
            ii(0x15_e4dd, 3); callw(0x15_e596, 0xb6);                   /* call 0xe596 */
            ii(0x15_e4e0, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_e4e3, 1); pushw(ds);                                /* push ds */
            ii(0x15_e4e4, 3); pushw(0x48b6);                            /* push 0x48b6 */
            ii(0x15_e4e7, 1); nop();                                    /* nop */
            ii(0x15_e4e8, 1); pushw(cs);                                /* push cs */
            ii(0x15_e4e9, 3); callw(0x15_e62f, 0x143);                  /* call 0xe62f */
            ii(0x15_e4ec, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_e4ef, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x15_e4f2, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_e4f4, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_e4f8, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_e4fb, 3); mov(ax, memw_a16[ds, 0x2c22]);            /* mov ax, [0x2c22] */
            ii(0x15_e4fe, 4); mov(dx, memw_a16[ds, 0x2c24]);            /* mov dx, [0x2c24] */
            ii(0x15_e502, 3); add(ax, 0x80);                            /* add ax, 0x80 */
            ii(0x15_e505, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_e508, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_e50b, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x15_e50e, 3); inc(memw_a16[ss, bp - 0x4]);              /* inc word [bp-0x4] */
            ii(0x15_e511, 3); mov(al, memb_a16[es, bx]);                /* mov al, [es:bx] */
            ii(0x15_e514, 1); cbw();                                    /* cbw */
            ii(0x15_e515, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_e518, 3); pushw(memw_a16[ss, bp - 0x1a]);           /* push word [bp-0x1a] */
            ii(0x15_e51b, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x15_e51e, 1); pushw(ss);                                /* push ss */
            ii(0x15_e51f, 1); pushw(ax);                                /* push ax */
            ii(0x15_e520, 1); nop();                                    /* nop */
            ii(0x15_e521, 1); pushw(cs);                                /* push cs */
            ii(0x15_e522, 3); callw(0x15_e39c, -0x189);                 /* call 0xe39c */
            ii(0x15_e525, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_e528, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x15_e52b, 3); mov(al, memb_a16[ss, bp - 0x1a]);         /* mov al, [bp-0x1a] */
            ii(0x15_e52e, 4); les(bx, ds, 0x2c22);                      /* les bx, [0x2c22] */
            ii(0x15_e532, 5); mov(memb_a16[es, bx + 0x80], al);         /* mov [es:bx+0x80], al */
            ii(0x15_e537, 3); mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x15_e53a, 1); inc(ax);                                  /* inc ax */
            ii(0x15_e53b, 1); pushw(ax);                                /* push ax */
            ii(0x15_e53c, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_e53f, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_e542, 3); mov(ax, memw_a16[ds, 0x2c22]);            /* mov ax, [0x2c22] */
            ii(0x15_e545, 4); mov(dx, memw_a16[ds, 0x2c24]);            /* mov dx, [0x2c24] */
            ii(0x15_e549, 3); add(ax, 0x81);                            /* add ax, 0x81 */
            ii(0x15_e54c, 1); pushw(dx);                                /* push dx */
            ii(0x15_e54d, 1); pushw(ax);                                /* push ax */
            ii(0x15_e54e, 1); nop();                                    /* nop */
            ii(0x15_e54f, 1); pushw(cs);                                /* push cs */
            ii(0x15_e550, 3); callw(0x16_0f5f, 0x2a0c);                 /* call 0xf5f */
            ii(0x15_e553, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_e556, 3); jmpw(0x15_e57e, 0x25); goto l_0x15_e57e;  /* jmp 0xe57e */
        l_0x15_e559:
            ii(0x15_e559, 5); mov(memw_a16[ss, bp - 0xa], 0xe00);       /* mov word [bp-0xa], 0xe00 */
            ii(0x15_e55e, 3); lea(ax, bp - 0x18);                       /* lea ax, [bp-0x18] */
            ii(0x15_e561, 1); pushw(ss);                                /* push ss */
            ii(0x15_e562, 1); pushw(ax);                                /* push ax */
            ii(0x15_e563, 3); pushw(0xff00);                            /* push 0xff00 */
            ii(0x15_e566, 5); callw_far_abs(0x80, 0x4c9f);              /* call word 0x80:0x4c9f */
            ii(0x15_e56b, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_e56e, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x15_e571, 3); mov(cx, memw_a16[ss, bp - 0xc]);          /* mov cx, [bp-0xc] */
            ii(0x15_e574, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x15_e577, 3); mov(memw_a16[es, bx], cx);                /* mov [es:bx], cx */
            ii(0x15_e57a, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
        l_0x15_e57e:
            ii(0x15_e57e, 1); pushw(ds);                                /* push ds */
            ii(0x15_e57f, 3); pushw(0x2cb8);                            /* push 0x2cb8 */
            ii(0x15_e582, 1); nop();                                    /* nop */
            ii(0x15_e583, 1); pushw(cs);                                /* push cs */
            ii(0x15_e584, 3); callw(0x15_e607, 0x80);                   /* call 0xe607 */
            ii(0x15_e587, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_e58a, 3); mov(ax, 0x48b6);                          /* mov ax, 0x48b6 */
            ii(0x15_e58d, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x15_e58f, 3); jmpw(0x15_e592, 0); goto l_0x15_e592;     /* jmp 0xe592 */
        l_0x15_e592:
            ii(0x15_e592, 1); popw(si);                                 /* pop si */
            ii(0x15_e593, 1); popw(di);                                 /* pop di */
            ii(0x15_e594, 1); leavew();                                 /* leave */
            ii(0x15_e595, 1); retfw(); return;                          /* retf */
        }
    }
}

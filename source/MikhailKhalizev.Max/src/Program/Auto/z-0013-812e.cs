using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f6792402-f851-4ac3-a1c4-59083110f75f")]
        public void Method_0013_812e()
        {
            ii(0x13_812e, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x13_8132, 1); pushw(si);                                /* push si */
            ii(0x13_8133, 1); pushw(ds);                                /* push ds */
            ii(0x13_8134, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_8137, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_8139, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_813c, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_813f, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_8142, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_8145, 1); pushw(ds);                                /* push ds */
            ii(0x13_8146, 3); pushw(0xa34);                             /* push 0xa34 */
            ii(0x13_8149, 1); nop();                                    /* nop */
            ii(0x13_814a, 1); pushw(cs);                                /* push cs */
            ii(0x13_814b, 3); callw(0x13_104f, -0x70ff);                /* call 0x104f */
            ii(0x13_814e, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_8151, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_8154, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x13_8156, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_8158, 1); nop();                                    /* nop */
            ii(0x13_8159, 1); pushw(cs);                                /* push cs */
            ii(0x13_815a, 3); callw(0x13_e96a, 0x680d);                 /* call 0xe96a */
            ii(0x13_815d, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_8160, 3); mov(memw_a16[ds, 0x4fb8], ax);            /* mov [0x4fb8], ax */
            ii(0x13_8163, 4); mov(memw_a16[ds, 0x4fba], dx);            /* mov [0x4fba], dx */
            ii(0x13_8167, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_816a, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x13_816c, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_816e, 1); nop();                                    /* nop */
            ii(0x13_816f, 1); pushw(cs);                                /* push cs */
            ii(0x13_8170, 3); callw(0x13_e96a, 0x67f7);                 /* call 0xe96a */
            ii(0x13_8173, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_8176, 3); mov(memw_a16[ds, 0xa30], ax);             /* mov [0xa30], ax */
            ii(0x13_8179, 4); mov(memw_a16[ds, 0xa32], dx);             /* mov [0xa32], dx */
            ii(0x13_817d, 1); pushw(cs);                                /* push cs */
            ii(0x13_817e, 3); callw(0x13_808e, -0xf3);                  /* call 0x808e */
            ii(0x13_8181, 1); pushw(cs);                                /* push cs */
            ii(0x13_8182, 3); callw(0x13_8d64, 0xbdf);                  /* call 0x8d64 */
            ii(0x13_8185, 3); mov(ax, memw_a16[ds, 0x1a]);              /* mov ax, [0x1a] */
            ii(0x13_8188, 4); or(ax, memw_a16[ds, 0x18]);               /* or ax, [0x18] */
            ii(0x13_818c, 2); if(jzw(0x13_81ab, 0x1d)) goto l_0x13_81ab; /* jz 0x81ab */
            ii(0x13_818e, 3); mov(ax, memw_a16[ds, 0x14]);              /* mov ax, [0x14] */
            ii(0x13_8191, 4); mov(dx, memw_a16[ds, 0x16]);              /* mov dx, [0x16] */
            ii(0x13_8195, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_8197, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_8199, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_819b, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_819d, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_819f, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_81a1, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_81a3, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_81a5, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x13_81a8, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x13_81ab:
            ii(0x13_81ab, 1); pushw(ds);                                /* push ds */
            ii(0x13_81ac, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_81af, 3); pushw(0x8002);                            /* push 0x8002 */
            ii(0x13_81b2, 1); nop();                                    /* nop */
            ii(0x13_81b3, 1); pushw(cs);                                /* push cs */
            ii(0x13_81b4, 3); callw(0x13_0708, -0x7aaf);                /* call 0x708 */
            ii(0x13_81b7, 3); mov(memw_a16[ds, 0x982], ax);             /* mov [0x982], ax */
            ii(0x13_81ba, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_81bc, 2); if(jgew(0x13_81cc, 0xe)) goto l_0x13_81cc; /* jge 0x81cc */
            ii(0x13_81be, 1); pushw(ds);                                /* push ds */
            ii(0x13_81bf, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_81c2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_81c4, 1); nop();                                    /* nop */
            ii(0x13_81c5, 1); pushw(cs);                                /* push cs */
            ii(0x13_81c6, 3); callw(0x13_074a, -0x7a7f);                /* call 0x74a */
            ii(0x13_81c9, 3); mov(memw_a16[ds, 0x982], ax);             /* mov [0x982], ax */
        l_0x13_81cc:
            ii(0x13_81cc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_81ce, 2); if(jgew(0x13_81e6, 0x16)) goto l_0x13_81e6; /* jge 0x81e6 */
            ii(0x13_81d0, 1); pushw(ds);                                /* push ds */
            ii(0x13_81d1, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_81d4, 3); pushw(0x906);                             /* push 0x906 */
            ii(0x13_81d7, 1); nop();                                    /* nop */
            ii(0x13_81d8, 1); pushw(cs);                                /* push cs */
            ii(0x13_81d9, 3); callw(0x13_75b4, -0xc28);                 /* call 0x75b4 */
            ii(0x13_81dc, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_81df, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_81e2, 1); popw(ds);                                 /* pop ds */
            ii(0x13_81e3, 1); popw(si);                                 /* pop si */
            ii(0x13_81e4, 1); leavew();                                 /* leave */
            ii(0x13_81e5, 1); retfw(); return;                          /* retf */
        l_0x13_81e6:
            ii(0x13_81e6, 2); pushw(0x2);                               /* push 0x2 */
            ii(0x13_81e8, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_81ea, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_81ec, 1); pushw(ax);                                /* push ax */
            ii(0x13_81ed, 1); nop();                                    /* nop */
            ii(0x13_81ee, 1); pushw(cs);                                /* push cs */
            ii(0x13_81ef, 3); callw(0x13_d91c, 0x572a);                 /* call 0xd91c */
            ii(0x13_81f2, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_81f5, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x13_81f8, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x13_81fb, 3); cmp(dx, memw_a16[ss, bp - 0x2]);          /* cmp dx, [bp-0x2] */
            ii(0x13_81fe, 2); if(jlw(0x13_8220, 0x20)) goto l_0x13_8220; /* jl 0x8220 */
            ii(0x13_8200, 2); if(jgw(0x13_8207, 0x5)) goto l_0x13_8207; /* jg 0x8207 */
            ii(0x13_8202, 3); cmp(ax, memw_a16[ss, bp - 0x4]);          /* cmp ax, [bp-0x4] */
            ii(0x13_8205, 2); if(jbew(0x13_8220, 0x19)) goto l_0x13_8220; /* jbe 0x8220 */
        l_0x13_8207:
            ii(0x13_8207, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_820b, 1); nop();                                    /* nop */
            ii(0x13_820c, 1); pushw(cs);                                /* push cs */
            ii(0x13_820d, 3); callw(0x13_d8fc, 0x56ec);                 /* call 0xd8fc */
            ii(0x13_8210, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_8213, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_8216, 1); nop();                                    /* nop */
            ii(0x13_8217, 1); pushw(cs);                                /* push cs */
            ii(0x13_8218, 3); callw(0x13_dd6c, 0x5b51);                 /* call 0xdd6c */
            ii(0x13_821b, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_821e, 2); jmpw(0x13_81ab, -0x75); goto l_0x13_81ab; /* jmp 0x81ab */
        l_0x13_8220:
            ii(0x13_8220, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x13_8223, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x13_8226, 3); cmp(memw_a16[ss, bp - 0x6], dx);          /* cmp [bp-0x6], dx */
            ii(0x13_8229, 2); if(jgw(0x13_829e, 0x73)) goto l_0x13_829e; /* jg 0x829e */
            ii(0x13_822b, 2); if(jlw(0x13_8232, 0x5)) goto l_0x13_8232; /* jl 0x8232 */
            ii(0x13_822d, 3); cmp(memw_a16[ss, bp - 0x8], ax);          /* cmp [bp-0x8], ax */
            ii(0x13_8230, 2); if(jaew(0x13_829e, 0x6c)) goto l_0x13_829e; /* jae 0x829e */
        l_0x13_8232:
            ii(0x13_8232, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_8234, 3); sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x13_8237, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x13_823a, 1); pushw(dx);                                /* push dx */
            ii(0x13_823b, 1); pushw(ax);                                /* push ax */
            ii(0x13_823c, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_8240, 1); nop();                                    /* nop */
            ii(0x13_8241, 1); pushw(cs);                                /* push cs */
            ii(0x13_8242, 3); callw(0x13_d91c, 0x56d7);                 /* call 0xd91c */
            ii(0x13_8245, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_8248, 2); or(dx, dx);                               /* or dx, dx */
            ii(0x13_824a, 2); if(jlw(0x13_8261, 0x15)) goto l_0x13_8261; /* jl 0x8261 */
            ii(0x13_824c, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x13_824e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_8250, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_8254, 1); nop();                                    /* nop */
            ii(0x13_8255, 1); pushw(cs);                                /* push cs */
            ii(0x13_8256, 3); callw(0x13_d996, 0x573d);                 /* call 0xd996 */
            ii(0x13_8259, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_825c, 3); cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0x13_825f, 2); if(jgew(0x13_828e, 0x2d)) goto l_0x13_828e; /* jge 0x828e */
        l_0x13_8261:
            ii(0x13_8261, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_8265, 1); nop();                                    /* nop */
            ii(0x13_8266, 1); pushw(cs);                                /* push cs */
            ii(0x13_8267, 3); callw(0x13_d8fc, 0x5692);                 /* call 0xd8fc */
            ii(0x13_826a, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_826d, 6); mov(memw_a16[ds, 0x982], 0);              /* mov word [0x982], 0x0 */
            ii(0x13_8273, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_8276, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_8279, 3); pushw(0x902);                             /* push 0x902 */
            ii(0x13_827c, 1); nop();                                    /* nop */
            ii(0x13_827d, 1); pushw(cs);                                /* push cs */
            ii(0x13_827e, 3); callw(0x13_75b4, -0xccd);                 /* call 0x75b4 */
            ii(0x13_8281, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_8284, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_8287, 1); popw(ds);                                 /* pop ds */
            ii(0x13_8288, 1); popw(si);                                 /* pop si */
            ii(0x13_8289, 1); leavew();                                 /* leave */
            ii(0x13_828a, 1); retfw(); return;                          /* retf */
        //    ii(0x13_828b, 2); jmpw(0x13_829e, 0x11); goto l_0x13_829e;  /* jmp 0x829e */
        //    ii(0x13_828d, 1); nop();                                    /* nop */
        l_0x13_828e:
            ii(0x13_828e, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_8292, 1); nop();                                    /* nop */
            ii(0x13_8293, 1); pushw(cs);                                /* push cs */
            ii(0x13_8294, 3); callw(0x13_d8fc, 0x5665);                 /* call 0xd8fc */
            ii(0x13_8297, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_829a, 3); jmpw(0x13_81ab, -0xf2); goto l_0x13_81ab; /* jmp 0x81ab */
        //    ii(0x13_829d, 1); nop();                                    /* nop */
        l_0x13_829e:
            ii(0x13_829e, 6); mov(memw_a16[ds, 0xa24], 0x1);            /* mov word [0xa24], 0x1 */
            ii(0x13_82a4, 2); pushw(0x6);                               /* push 0x6 */
            ii(0x13_82a6, 1); nop();                                    /* nop */
            ii(0x13_82a7, 1); pushw(cs);                                /* push cs */
            ii(0x13_82a8, 3); callw(0x13_e7a8, 0x64fd);                 /* call 0xe7a8 */
            ii(0x13_82ab, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_82ae, 3); mov(memw_a16[ds, 0x1f60], ax);            /* mov [0x1f60], ax */
            ii(0x13_82b1, 4); mov(memw_a16[ds, 0x1f62], dx);            /* mov [0x1f62], dx */
            ii(0x13_82b5, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_82b7, 4); or(ax, memw_a16[ds, 0x1f60]);             /* or ax, [0x1f60] */
            ii(0x13_82bb, 2); if(jnzw(0x13_82e6, 0x29)) goto l_0x13_82e6; /* jnz 0x82e6 */
            ii(0x13_82bd, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_82c1, 1); nop();                                    /* nop */
            ii(0x13_82c2, 1); pushw(cs);                                /* push cs */
            ii(0x13_82c3, 3); callw(0x13_d8fc, 0x5636);                 /* call 0xd8fc */
            ii(0x13_82c6, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_82c9, 6); mov(memw_a16[ds, 0x982], 0);              /* mov word [0x982], 0x0 */
            ii(0x13_82cf, 1); pushw(ds);                                /* push ds */
            ii(0x13_82d0, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_82d3, 3); pushw(0x906);                             /* push 0x906 */
            ii(0x13_82d6, 1); nop();                                    /* nop */
            ii(0x13_82d7, 1); pushw(cs);                                /* push cs */
            ii(0x13_82d8, 3); callw(0x13_75b4, -0xd27);                 /* call 0x75b4 */
            ii(0x13_82db, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x13_82de, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x13_82e1, 1); popw(ds);                                 /* pop ds */
            ii(0x13_82e2, 1); popw(si);                                 /* pop si */
            ii(0x13_82e3, 1); leavew();                                 /* leave */
            ii(0x13_82e4, 1); retfw(); return;                          /* retf */
        //    ii(0x13_82e5, 1); nop();                                    /* nop */
        l_0x13_82e6:
            ii(0x13_82e6, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_82e8, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_82ea, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_82ec, 4); pushw(memw_a16[ds, 0x982]);               /* push word [0x982] */
            ii(0x13_82f0, 1); nop();                                    /* nop */
            ii(0x13_82f1, 1); pushw(cs);                                /* push cs */
            ii(0x13_82f2, 3); callw(0x13_d91c, 0x5627);                 /* call 0xd91c */
            ii(0x13_82f5, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_82f8, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x13_82fc, 4); mov(si, memw_a16[ds, 0x982]);             /* mov si, [0x982] */
            ii(0x13_8300, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x13_8303, 1); cbw();                                    /* cbw */
            ii(0x13_8304, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x13_8308, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
            ii(0x13_830c, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x13_8310, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_8312, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x13_8316, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x13_8319, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x13_831d, 4); mov(si, memw_a16[ds, 0x982]);             /* mov si, [0x982] */
            ii(0x13_8321, 4); mov(memb_a16[es, bx + si], 0xff);         /* mov byte [es:bx+si], 0xff */
            ii(0x13_8325, 5); mov(memw_a16[ss, bp - 0xa], 0x1);         /* mov word [bp-0xa], 0x1 */
            ii(0x13_832a, 2); jmpw(0x13_832f, 0x3); goto l_0x13_832f;   /* jmp 0x832f */
        l_0x13_832c:
            ii(0x13_832c, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x13_832f:
            ii(0x13_832f, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x13_8332, 4); cmp(memw_a16[ds, 0xa24], ax);             /* cmp [0xa24], ax */
            ii(0x13_8336, 2); if(jbew(0x13_8390, 0x58)) goto l_0x13_8390; /* jbe 0x8390 */
            ii(0x13_8338, 1); pushw(ds);                                /* push ds */
            ii(0x13_8339, 3); pushw(0x3c);                              /* push 0x3c */
            ii(0x13_833c, 3); pushw(0x8002);                            /* push 0x8002 */
            ii(0x13_833f, 1); nop();                                    /* nop */
            ii(0x13_8340, 1); pushw(cs);                                /* push cs */
            ii(0x13_8341, 3); callw(0x13_0708, -0x7c3c);                /* call 0x708 */
            ii(0x13_8344, 3); mov(memw_a16[ds, 0x982], ax);             /* mov [0x982], ax */
            ii(0x13_8347, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_8349, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_834b, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_834d, 1); pushw(ax);                                /* push ax */
            ii(0x13_834e, 1); nop();                                    /* nop */
            ii(0x13_834f, 1); pushw(cs);                                /* push cs */
            ii(0x13_8350, 3); callw(0x13_d91c, 0x55c9);                 /* call 0xd91c */
            ii(0x13_8353, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x13_8356, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x13_835a, 4); mov(si, memw_a16[ds, 0x982]);             /* mov si, [0x982] */
            ii(0x13_835e, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x13_8361, 1); cbw();                                    /* cbw */
            ii(0x13_8362, 3); mov(si, memw_a16[ss, bp - 0xa]);          /* mov si, [bp-0xa] */
            ii(0x13_8365, 2); mov(cx, si);                              /* mov cx, si */
            ii(0x13_8367, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x13_8369, 2); add(si, cx);                              /* add si, cx */
            ii(0x13_836b, 2); shl(si, 0x1);                             /* shl si, 1 */
            ii(0x13_836d, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x13_8371, 4); mov(memw_a16[es, bx + si + 0x4], ax);     /* mov [es:bx+si+0x4], ax */
            ii(0x13_8375, 4); les(bx, ds, 0x1f60);                      /* les bx, [0x1f60] */
            ii(0x13_8379, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_837b, 4); mov(memw_a16[es, bx + si + 0x2], ax);     /* mov [es:bx+si+0x2], ax */
            ii(0x13_837f, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x13_8382, 4); les(bx, ds, 0xa30);                       /* les bx, [0xa30] */
            ii(0x13_8386, 4); mov(si, memw_a16[ds, 0x982]);             /* mov si, [0x982] */
            ii(0x13_838a, 4); mov(memb_a16[es, bx + si], 0xff);         /* mov byte [es:bx+si], 0xff */
            ii(0x13_838e, 2); jmpw(0x13_832c, -0x64); goto l_0x13_832c; /* jmp 0x832c */
        l_0x13_8390:
            ii(0x13_8390, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_8392, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_8395, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x13_8398, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x13_839b, 1); nop();                                    /* nop */
            ii(0x13_839c, 1); pushw(cs);                                /* push cs */
            ii(0x13_839d, 3); callw(0x13_dddc, 0x5a3c);                 /* call 0xdddc */
            ii(0x13_83a0, 3); mov(memw_a16[ds, 0x4fbc], ax);            /* mov [0x4fbc], ax */
            ii(0x13_83a3, 4); mov(memw_a16[ds, 0x4fbe], dx);            /* mov [0x4fbe], dx */
            ii(0x13_83a7, 2); pushw(0);                                 /* push 0x0 */
            ii(0x13_83a9, 3); pushw(0x1000);                            /* push 0x1000 */
            ii(0x13_83ac, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x13_83af, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x13_83b2, 1); nop();                                    /* nop */
            ii(0x13_83b3, 1); pushw(cs);                                /* push cs */
            ii(0x13_83b4, 3); callw(0x13_dddc, 0x5a25);                 /* call 0xdddc */
            ii(0x13_83b7, 3); mov(memw_a16[ds, 0x1f50], ax);            /* mov [0x1f50], ax */
            ii(0x13_83ba, 4); mov(memw_a16[ds, 0x1f52], dx);            /* mov [0x1f52], dx */
            ii(0x13_83be, 1); pushw(ds);                                /* push ds */
            ii(0x13_83bf, 3); pushw(0xa3f);                             /* push 0xa3f */
            ii(0x13_83c2, 1); nop();                                    /* nop */
            ii(0x13_83c3, 1); pushw(cs);                                /* push cs */
            ii(0x13_83c4, 3); callw(0x13_104f, -0x7378);                /* call 0x104f */
            ii(0x13_83c7, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_83ca, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_83cc, 1); popw(ds);                                 /* pop ds */
            ii(0x13_83cd, 1); popw(si);                                 /* pop si */
            ii(0x13_83ce, 1); leavew();                                 /* leave */
            ii(0x13_83cf, 1); retfw(); return;                          /* retf */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_812e-4c63776e")]
        public void Method_0017_812e()
        {
            ii(0x17_812e, 4);  enter(0xa, 0);                          /* enter 0xa, 0x0 */
            ii(0x17_8132, 1);  push(si);                               /* push si */
            ii(0x17_8133, 1);  push(ds);                               /* push ds */
            ii(0x17_8134, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_8137, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_8139, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_813c, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_813f, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_8142, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_8145, 1);  push(ds);                               /* push ds */
            ii(0x17_8146, 3);  push(0xa34);                            /* push 0xa34 */
            ii(0x17_8149, 1);  nop();                                  /* nop */
            ii(0x17_814a, 1);  push(cs);                               /* push cs */
            ii(0x17_814b, 3);  call(0x17_104f, -0x70ff);               /* call 0x104f */
            ii(0x17_814e, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_8151, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_8154, 2);  push(0x40);                             /* push 0x40 */
            ii(0x17_8156, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8158, 1);  nop();                                  /* nop */
            ii(0x17_8159, 1);  push(cs);                               /* push cs */
            ii(0x17_815a, 3);  call(0x17_e96a, 0x680d);                /* call 0xe96a */
            ii(0x17_815d, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_8160, 3);  mov(memw[ds, 0x4fb8], ax);              /* mov [0x4fb8], ax */
            ii(0x17_8163, 4);  mov(memw[ds, 0x4fba], dx);              /* mov [0x4fba], dx */
            ii(0x17_8167, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_816a, 2);  push(0x40);                             /* push 0x40 */
            ii(0x17_816c, 2);  push(0);                                /* push 0x0 */
            ii(0x17_816e, 1);  nop();                                  /* nop */
            ii(0x17_816f, 1);  push(cs);                               /* push cs */
            ii(0x17_8170, 3);  call(0x17_e96a, 0x67f7);                /* call 0xe96a */
            ii(0x17_8173, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_8176, 3);  mov(memw[ds, 0xa30], ax);               /* mov [0xa30], ax */
            ii(0x17_8179, 4);  mov(memw[ds, 0xa32], dx);               /* mov [0xa32], dx */
            ii(0x17_817d, 1);  push(cs);                               /* push cs */
            ii(0x17_817e, 3);  call(0x17_808e, -0xf3);                 /* call 0x808e */
            ii(0x17_8181, 1);  push(cs);                               /* push cs */
            ii(0x17_8182, 3);  call(0x17_8d64, 0xbdf);                 /* call 0x8d64 */
            ii(0x17_8185, 3);  mov(ax, memw[ds, 0x1a]);                /* mov ax, [0x1a] */
            ii(0x17_8188, 4);  or(ax, memw[ds, 0x18]);                 /* or ax, [0x18] */
            ii(0x17_818c, 2);  if(jz(0x17_81ab, 0x1d)) goto l_0x17_81ab;/* jz 0x81ab */
            ii(0x17_818e, 3);  mov(ax, memw[ds, 0x14]);                /* mov ax, [0x14] */
            ii(0x17_8191, 4);  mov(dx, memw[ds, 0x16]);                /* mov dx, [0x16] */
            ii(0x17_8195, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_8197, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_8199, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_819b, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_819d, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_819f, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_81a1, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_81a3, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_81a5, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_81a8, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
        l_0x17_81ab:
            ii(0x17_81ab, 1);  push(ds);                               /* push ds */
            ii(0x17_81ac, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_81af, 3);  push(0x8002);                           /* push 0x8002 */
            ii(0x17_81b2, 1);  nop();                                  /* nop */
            ii(0x17_81b3, 1);  push(cs);                               /* push cs */
            ii(0x17_81b4, 3);  call(0x17_0708, -0x7aaf);               /* call 0x708 */
            ii(0x17_81b7, 3);  mov(memw[ds, 0x982], ax);               /* mov [0x982], ax */
            ii(0x17_81ba, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_81bc, 2);  if(jge(0x17_81cc, 0xe)) goto l_0x17_81cc;/* jge 0x81cc */
            ii(0x17_81be, 1);  push(ds);                               /* push ds */
            ii(0x17_81bf, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_81c2, 2);  push(0);                                /* push 0x0 */
            ii(0x17_81c4, 1);  nop();                                  /* nop */
            ii(0x17_81c5, 1);  push(cs);                               /* push cs */
            ii(0x17_81c6, 3);  call(0x17_074a, -0x7a7f);               /* call 0x74a */
            ii(0x17_81c9, 3);  mov(memw[ds, 0x982], ax);               /* mov [0x982], ax */
        l_0x17_81cc:
            ii(0x17_81cc, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_81ce, 2);  if(jge(0x17_81e6, 0x16)) goto l_0x17_81e6;/* jge 0x81e6 */
            ii(0x17_81d0, 1);  push(ds);                               /* push ds */
            ii(0x17_81d1, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_81d4, 3);  push(0x906);                            /* push 0x906 */
            ii(0x17_81d7, 1);  nop();                                  /* nop */
            ii(0x17_81d8, 1);  push(cs);                               /* push cs */
            ii(0x17_81d9, 3);  call(0x17_75b4, -0xc28);                /* call 0x75b4 */
            ii(0x17_81dc, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_81df, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_81e2, 1);  pop(ds);                                /* pop ds */
            ii(0x17_81e3, 1);  pop(si);                                /* pop si */
            ii(0x17_81e4, 1);  leave();                                /* leave */
            ii(0x17_81e5, 1);  retf(); return;                         /* retf */
        l_0x17_81e6:
            ii(0x17_81e6, 2);  push(2);                                /* push 0x2 */
            ii(0x17_81e8, 2);  push(0);                                /* push 0x0 */
            ii(0x17_81ea, 2);  push(0);                                /* push 0x0 */
            ii(0x17_81ec, 1);  push(ax);                               /* push ax */
            ii(0x17_81ed, 1);  nop();                                  /* nop */
            ii(0x17_81ee, 1);  push(cs);                               /* push cs */
            ii(0x17_81ef, 3);  call(0x17_d91c, 0x572a);                /* call 0xd91c */
            ii(0x17_81f2, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_81f5, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_81f8, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_81fb, 3);  cmp(dx, memw[ss, bp - 2]);              /* cmp dx, [bp-0x2] */
            ii(0x17_81fe, 2);  if(jl(0x17_8220, 0x20)) goto l_0x17_8220;/* jl 0x8220 */
            ii(0x17_8200, 2);  if(jg(0x17_8207, 5)) goto l_0x17_8207;  /* jg 0x8207 */
            ii(0x17_8202, 3);  cmp(ax, memw[ss, bp - 4]);              /* cmp ax, [bp-0x4] */
            ii(0x17_8205, 2);  if(jbe(0x17_8220, 0x19)) goto l_0x17_8220;/* jbe 0x8220 */
        l_0x17_8207:
            ii(0x17_8207, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_820b, 1);  nop();                                  /* nop */
            ii(0x17_820c, 1);  push(cs);                               /* push cs */
            ii(0x17_820d, 3);  call(0x17_d8fc, 0x56ec);                /* call 0xd8fc */
            ii(0x17_8210, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_8213, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_8216, 1);  nop();                                  /* nop */
            ii(0x17_8217, 1);  push(cs);                               /* push cs */
            ii(0x17_8218, 3);  call(0x17_dd6c, 0x5b51);                /* call 0xdd6c */
            ii(0x17_821b, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_821e, 2);  jmp(0x17_81ab, -0x75); goto l_0x17_81ab;/* jmp 0x81ab */
        l_0x17_8220:
            ii(0x17_8220, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_8223, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_8226, 3);  cmp(memw[ss, bp - 6], dx);              /* cmp [bp-0x6], dx */
            ii(0x17_8229, 2);  if(jg(0x17_829e, 0x73)) goto l_0x17_829e;/* jg 0x829e */
            ii(0x17_822b, 2);  if(jl(0x17_8232, 5)) goto l_0x17_8232;  /* jl 0x8232 */
            ii(0x17_822d, 3);  cmp(memw[ss, bp - 8], ax);              /* cmp [bp-0x8], ax */
            ii(0x17_8230, 2);  if(jae(0x17_829e, 0x6c)) goto l_0x17_829e;/* jae 0x829e */
        l_0x17_8232:
            ii(0x17_8232, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8234, 3);  sub(ax, 1);                             /* sub ax, 0x1 */
            ii(0x17_8237, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
            ii(0x17_823a, 1);  push(dx);                               /* push dx */
            ii(0x17_823b, 1);  push(ax);                               /* push ax */
            ii(0x17_823c, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_8240, 1);  nop();                                  /* nop */
            ii(0x17_8241, 1);  push(cs);                               /* push cs */
            ii(0x17_8242, 3);  call(0x17_d91c, 0x56d7);                /* call 0xd91c */
            ii(0x17_8245, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_8248, 2);  or(dx, dx);                             /* or dx, dx */
            ii(0x17_824a, 2);  if(jl(0x17_8261, 0x15)) goto l_0x17_8261;/* jl 0x8261 */
            ii(0x17_824c, 2);  push(1);                                /* push 0x1 */
            ii(0x17_824e, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8250, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_8254, 1);  nop();                                  /* nop */
            ii(0x17_8255, 1);  push(cs);                               /* push cs */
            ii(0x17_8256, 3);  call(0x17_d996, 0x573d);                /* call 0xd996 */
            ii(0x17_8259, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_825c, 3);  cmp(ax, 1);                             /* cmp ax, 0x1 */
            ii(0x17_825f, 2);  if(jge(0x17_828e, 0x2d)) goto l_0x17_828e;/* jge 0x828e */
        l_0x17_8261:
            ii(0x17_8261, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_8265, 1);  nop();                                  /* nop */
            ii(0x17_8266, 1);  push(cs);                               /* push cs */
            ii(0x17_8267, 3);  call(0x17_d8fc, 0x5692);                /* call 0xd8fc */
            ii(0x17_826a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_826d, 6);  mov(memw[ds, 0x982], 0);                /* mov word [0x982], 0x0 */
            ii(0x17_8273, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_8276, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_8279, 3);  push(0x902);                            /* push 0x902 */
            ii(0x17_827c, 1);  nop();                                  /* nop */
            ii(0x17_827d, 1);  push(cs);                               /* push cs */
            ii(0x17_827e, 3);  call(0x17_75b4, -0xccd);                /* call 0x75b4 */
            ii(0x17_8281, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_8284, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_8287, 1);  pop(ds);                                /* pop ds */
            ii(0x17_8288, 1);  pop(si);                                /* pop si */
            ii(0x17_8289, 1);  leave();                                /* leave */
            ii(0x17_828a, 1);  retf(); return;                         /* retf */
        //  ii(0x17_828b, 3);  Недостижимый код.
        l_0x17_828e:
            ii(0x17_828e, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_8292, 1);  nop();                                  /* nop */
            ii(0x17_8293, 1);  push(cs);                               /* push cs */
            ii(0x17_8294, 3);  call(0x17_d8fc, 0x5665);                /* call 0xd8fc */
            ii(0x17_8297, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_829a, 3);  jmp(0x17_81ab, -0xf2); goto l_0x17_81ab;/* jmp 0x81ab */
        //  ii(0x17_829d, 1);  nop();                                  /* nop */
        l_0x17_829e:
            ii(0x17_829e, 6);  mov(memw[ds, 0xa24], 1);                /* mov word [0xa24], 0x1 */
            ii(0x17_82a4, 2);  push(6);                                /* push 0x6 */
            ii(0x17_82a6, 1);  nop();                                  /* nop */
            ii(0x17_82a7, 1);  push(cs);                               /* push cs */
            ii(0x17_82a8, 3);  call(0x17_e7a8, 0x64fd);                /* call 0xe7a8 */
            ii(0x17_82ab, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_82ae, 3);  mov(memw[ds, 0x1f60], ax);              /* mov [0x1f60], ax */
            ii(0x17_82b1, 4);  mov(memw[ds, 0x1f62], dx);              /* mov [0x1f62], dx */
            ii(0x17_82b5, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_82b7, 4);  or(ax, memw[ds, 0x1f60]);               /* or ax, [0x1f60] */
            ii(0x17_82bb, 2);  if(jnz(0x17_82e6, 0x29)) goto l_0x17_82e6;/* jnz 0x82e6 */
            ii(0x17_82bd, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_82c1, 1);  nop();                                  /* nop */
            ii(0x17_82c2, 1);  push(cs);                               /* push cs */
            ii(0x17_82c3, 3);  call(0x17_d8fc, 0x5636);                /* call 0xd8fc */
            ii(0x17_82c6, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_82c9, 6);  mov(memw[ds, 0x982], 0);                /* mov word [0x982], 0x0 */
            ii(0x17_82cf, 1);  push(ds);                               /* push ds */
            ii(0x17_82d0, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_82d3, 3);  push(0x906);                            /* push 0x906 */
            ii(0x17_82d6, 1);  nop();                                  /* nop */
            ii(0x17_82d7, 1);  push(cs);                               /* push cs */
            ii(0x17_82d8, 3);  call(0x17_75b4, -0xd27);                /* call 0x75b4 */
            ii(0x17_82db, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_82de, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_82e1, 1);  pop(ds);                                /* pop ds */
            ii(0x17_82e2, 1);  pop(si);                                /* pop si */
            ii(0x17_82e3, 1);  leave();                                /* leave */
            ii(0x17_82e4, 1);  retf(); return;                         /* retf */
        //  ii(0x17_82e5, 1);  Недостижимый код.
        l_0x17_82e6:
            ii(0x17_82e6, 2);  push(0);                                /* push 0x0 */
            ii(0x17_82e8, 2);  push(0);                                /* push 0x0 */
            ii(0x17_82ea, 2);  push(0);                                /* push 0x0 */
            ii(0x17_82ec, 4);  push(memw[ds, 0x982]);                  /* push word [0x982] */
            ii(0x17_82f0, 1);  nop();                                  /* nop */
            ii(0x17_82f1, 1);  push(cs);                               /* push cs */
            ii(0x17_82f2, 3);  call(0x17_d91c, 0x5627);                /* call 0xd91c */
            ii(0x17_82f5, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_82f8, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_82fc, 4);  mov(si, memw[ds, 0x982]);               /* mov si, [0x982] */
            ii(0x17_8300, 3);  mov(al, memb[es, bx + si]);             /* mov al, [es:bx+si] */
            ii(0x17_8303, 1);  cbw();                                  /* cbw */
            ii(0x17_8304, 4);  les(bx, memw[ds, 0x1f60]);              /* les bx, [0x1f60] */
            ii(0x17_8308, 4);  mov(memw[es, bx + 4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x17_830c, 4);  les(bx, memw[ds, 0x1f60]);              /* les bx, [0x1f60] */
            ii(0x17_8310, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_8312, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x17_8316, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x17_8319, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_831d, 4);  mov(si, memw[ds, 0x982]);               /* mov si, [0x982] */
            ii(0x17_8321, 4);  mov(memb[es, bx + si], 0xff);           /* mov byte [es:bx+si], 0xff */
            ii(0x17_8325, 5);  mov(memw[ss, bp - 10], 1);              /* mov word [bp-0xa], 0x1 */
            ii(0x17_832a, 2);  jmp(0x17_832f, 3); goto l_0x17_832f;    /* jmp 0x832f */
        l_0x17_832c:
            ii(0x17_832c, 3);  inc(memw[ss, bp - 10]);                 /* inc word [bp-0xa] */
        l_0x17_832f:
            ii(0x17_832f, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x17_8332, 4);  cmp(memw[ds, 0xa24], ax);               /* cmp [0xa24], ax */
            ii(0x17_8336, 2);  if(jbe(0x17_8390, 0x58)) goto l_0x17_8390;/* jbe 0x8390 */
            ii(0x17_8338, 1);  push(ds);                               /* push ds */
            ii(0x17_8339, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_833c, 3);  push(0x8002);                           /* push 0x8002 */
            ii(0x17_833f, 1);  nop();                                  /* nop */
            ii(0x17_8340, 1);  push(cs);                               /* push cs */
            ii(0x17_8341, 3);  call(0x17_0708, -0x7c3c);               /* call 0x708 */
            ii(0x17_8344, 3);  mov(memw[ds, 0x982], ax);               /* mov [0x982], ax */
            ii(0x17_8347, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8349, 2);  push(0);                                /* push 0x0 */
            ii(0x17_834b, 2);  push(0);                                /* push 0x0 */
            ii(0x17_834d, 1);  push(ax);                               /* push ax */
            ii(0x17_834e, 1);  nop();                                  /* nop */
            ii(0x17_834f, 1);  push(cs);                               /* push cs */
            ii(0x17_8350, 3);  call(0x17_d91c, 0x55c9);                /* call 0xd91c */
            ii(0x17_8353, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_8356, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_835a, 4);  mov(si, memw[ds, 0x982]);               /* mov si, [0x982] */
            ii(0x17_835e, 3);  mov(al, memb[es, bx + si]);             /* mov al, [es:bx+si] */
            ii(0x17_8361, 1);  cbw();                                  /* cbw */
            ii(0x17_8362, 3);  mov(si, memw[ss, bp - 10]);             /* mov si, [bp-0xa] */
            ii(0x17_8365, 2);  mov(cx, si);                            /* mov cx, si */
            ii(0x17_8367, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x17_8369, 2);  add(si, cx);                            /* add si, cx */
            ii(0x17_836b, 2);  shl(si, 1);                             /* shl si, 1 */
            ii(0x17_836d, 4);  les(bx, memw[ds, 0x1f60]);              /* les bx, [0x1f60] */
            ii(0x17_8371, 4);  mov(memw[es, bx + si + 4], ax);         /* mov [es:bx+si+0x4], ax */
            ii(0x17_8375, 4);  les(bx, memw[ds, 0x1f60]);              /* les bx, [0x1f60] */
            ii(0x17_8379, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_837b, 4);  mov(memw[es, bx + si + 2], ax);         /* mov [es:bx+si+0x2], ax */
            ii(0x17_837f, 3);  mov(memw[es, bx + si], ax);             /* mov [es:bx+si], ax */
            ii(0x17_8382, 4);  les(bx, memw[ds, 0xa30]);               /* les bx, [0xa30] */
            ii(0x17_8386, 4);  mov(si, memw[ds, 0x982]);               /* mov si, [0x982] */
            ii(0x17_838a, 4);  mov(memb[es, bx + si], 0xff);           /* mov byte [es:bx+si], 0xff */
            ii(0x17_838e, 2);  jmp(0x17_832c, -0x64); goto l_0x17_832c;/* jmp 0x832c */
        l_0x17_8390:
            ii(0x17_8390, 2);  push(0);                                /* push 0x0 */
            ii(0x17_8392, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_8395, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_8398, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_839b, 1);  nop();                                  /* nop */
            ii(0x17_839c, 1);  push(cs);                               /* push cs */
            ii(0x17_839d, 3);  call(0x17_dddc, 0x5a3c);                /* call 0xdddc */
            ii(0x17_83a0, 3);  mov(memw[ds, 0x4fbc], ax);              /* mov [0x4fbc], ax */
            ii(0x17_83a3, 4);  mov(memw[ds, 0x4fbe], dx);              /* mov [0x4fbe], dx */
            ii(0x17_83a7, 2);  push(0);                                /* push 0x0 */
            ii(0x17_83a9, 3);  push(0x1000);                           /* push 0x1000 */
            ii(0x17_83ac, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_83af, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_83b2, 1);  nop();                                  /* nop */
            ii(0x17_83b3, 1);  push(cs);                               /* push cs */
            ii(0x17_83b4, 3);  call(0x17_dddc, 0x5a25);                /* call 0xdddc */
            ii(0x17_83b7, 3);  mov(memw[ds, 0x1f50], ax);              /* mov [0x1f50], ax */
            ii(0x17_83ba, 4);  mov(memw[ds, 0x1f52], dx);              /* mov [0x1f52], dx */
            ii(0x17_83be, 1);  push(ds);                               /* push ds */
            ii(0x17_83bf, 3);  push(0xa3f);                            /* push 0xa3f */
            ii(0x17_83c2, 1);  nop();                                  /* nop */
            ii(0x17_83c3, 1);  push(cs);                               /* push cs */
            ii(0x17_83c4, 3);  call(0x17_104f, -0x7378);               /* call 0x104f */
            ii(0x17_83c7, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_83ca, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_83cc, 1);  pop(ds);                                /* pop ds */
            ii(0x17_83cd, 1);  pop(si);                                /* pop si */
            ii(0x17_83ce, 1);  leave();                                /* leave */
            ii(0x17_83cf, 1);  retf();                                 /* retf */
        }
    }
}

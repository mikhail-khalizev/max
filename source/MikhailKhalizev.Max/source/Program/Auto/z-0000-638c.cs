using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x638c-1635c2a7")]
        public void Method_0000_638c()
        {
            ii(0x638c, 1);  push(bp);                                  /* push bp */
            ii(0x638d, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x638f, 3);  sub(sp, 0xa);                              /* sub sp, 0xa */
            ii(0x6392, 3);  call(0x9bd1, 0x383c);                      /* call 0x9bd1 */
            ii(0x6395, 3);  mov(memb[ds, 0x2f], al);                   /* mov [0x2f], al */
            ii(0x6398, 3);  mov(ax, 2);                                /* mov ax, 0x2 */
            ii(0x639b, 1);  push(ax);                                  /* push ax */
            ii(0x639c, 3);  mov(ax, 0x9b8);                            /* mov ax, 0x9b8 */
            ii(0x639f, 1);  push(ax);                                  /* push ax */
            ii(0x63a0, 3);  mov(ax, 0x2c);                             /* mov ax, 0x2c */
            ii(0x63a3, 1);  push(ax);                                  /* push ax */
            ii(0x63a4, 4);  push(memw[ds, 0xcec]);                     /* push word [0xcec] */
            ii(0x63a8, 3);  call(0x9cd1, 0x3926);                      /* call 0x9cd1 */
            ii(0x63ab, 3);  add(sp, 8);                                /* add sp, 0x8 */
            ii(0x63ae, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x63b1, 2);  push(memw[ds, bx]);                        /* push word [bx] */
            ii(0x63b3, 3);  call(0x4f0d, -0x14a9);                     /* call 0x4f0d */
            ii(0x63b6, 1);  pop(bx);                                   /* pop bx */
            ii(0x63b7, 3);  mov(ax, 0xe4e);                            /* mov ax, 0xe4e */
            ii(0x63ba, 1);  push(ax);                                  /* push ax */
            ii(0x63bb, 3);  mov(ax, 0x1190);                           /* mov ax, 0x1190 */
            ii(0x63be, 1);  push(ax);                                  /* push ax */
            ii(0x63bf, 3);  call(0x973a, 0x3378);                      /* call 0x973a */
            ii(0x63c2, 1);  pop(bx);                                   /* pop bx */
            ii(0x63c3, 1);  pop(bx);                                   /* pop bx */
            ii(0x63c4, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x63c6, 2);  if(jnz(0x63dc, 0x14)) goto l_0x63dc;       /* jnz 0x63dc */
            ii(0x63c8, 3);  mov(ax, 0xe56);                            /* mov ax, 0xe56 */
            ii(0x63cb, 1);  push(ax);                                  /* push ax */
            ii(0x63cc, 3);  mov(ax, 0x1190);                           /* mov ax, 0x1190 */
            ii(0x63cf, 1);  push(ax);                                  /* push ax */
            ii(0x63d0, 3);  call(0x973a, 0x3367);                      /* call 0x973a */
            ii(0x63d3, 1);  pop(bx);                                   /* pop bx */
            ii(0x63d4, 1);  pop(bx);                                   /* pop bx */
            ii(0x63d5, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x63d7, 2);  if(jnz(0x63dc, 3)) goto l_0x63dc;          /* jnz 0x63dc */
            ii(0x63d9, 3);  jmp(0x6470, 0x94); goto l_0x6470;          /* jmp 0x6470 */
        l_0x63dc:
            ii(0x63dc, 4);  cmp(memw[ss, bp + 4], 1);                  /* cmp word [bp+0x4], 0x1 */
            ii(0x63e0, 2);  if(jg(0x63e5, 3)) goto l_0x63e5;           /* jg 0x63e5 */
            ii(0x63e2, 3);  jmp(0x6470, 0x8b); goto l_0x6470;          /* jmp 0x6470 */
        l_0x63e5:
            ii(0x63e5, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x63e8, 3);  push(memw[ds, bx + 2]);                    /* push word [bx+0x2] */
            ii(0x63eb, 3);  call(0x4f0d, -0x14e1);                     /* call 0x4f0d */
            ii(0x63ee, 1);  pop(bx);                                   /* pop bx */
            ii(0x63ef, 3);  mov(ax, 0xe62);                            /* mov ax, 0xe62 */
            ii(0x63f2, 1);  push(ax);                                  /* push ax */
            ii(0x63f3, 3);  call(0x4eaa, -0x154c);                     /* call 0x4eaa */
            ii(0x63f6, 1);  pop(bx);                                   /* pop bx */
            ii(0x63f7, 3);  mov(ax, 0x80);                             /* mov ax, 0x80 */
            ii(0x63fa, 4);  mov(dx, memw[ds, 0xcec]);                  /* mov dx, [0xcec] */
            ii(0x63fe, 3);  mov(memw[ss, bp - 8], ax);                 /* mov [bp-0x8], ax */
            ii(0x6401, 3);  mov(memw[ss, bp - 6], dx);                 /* mov [bp-0x6], dx */
            ii(0x6404, 2);  mov(es, dx);                               /* mov es, dx */
            ii(0x6406, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0x6408, 3);  mov(cl, memb[es, bx]);                     /* mov cl, [es:bx] */
            ii(0x640b, 2);  sub(ch, ch);                               /* sub ch, ch */
            ii(0x640d, 3);  mov(memw[ss, bp - 10], cx);                /* mov [bp-0xa], cx */
            ii(0x6410, 1);  inc(ax);                                   /* inc ax */
            ii(0x6411, 3);  mov(memw[ss, bp - 4], ax);                 /* mov [bp-0x4], ax */
            ii(0x6414, 3);  mov(memw[ss, bp - 2], dx);                 /* mov [bp-0x2], dx */
            ii(0x6417, 2);  jmp(0x6421, 8); goto l_0x6421;             /* jmp 0x6421 */
        l_0x6419:
            ii(0x6419, 3);  dec(memw[ss, bp - 10]);                    /* dec word [bp-0xa] */
            ii(0x641c, 2);  if(js(0x643c, 0x1e)) goto l_0x643c;        /* js 0x643c */
            ii(0x641e, 3);  inc(memw[ss, bp - 4]);                     /* inc word [bp-0x4] */
        l_0x6421:
            ii(0x6421, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x6424, 3);  mov(al, memb[es, bx]);                     /* mov al, [es:bx] */
            ii(0x6427, 2);  sub(ah, ah);                               /* sub ah, ah */
            ii(0x6429, 1);  push(ax);                                  /* push ax */
            ii(0x642a, 3);  call(0x656f, 0x142);                       /* call 0x656f */
            ii(0x642d, 1);  pop(bx);                                   /* pop bx */
            ii(0x642e, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x6430, 2);  if(jnz(0x6419, -0x19)) goto l_0x6419;      /* jnz 0x6419 */
            ii(0x6432, 2);  jmp(0x643c, 8); goto l_0x643c;             /* jmp 0x643c */
        l_0x6434:
            ii(0x6434, 3);  dec(memw[ss, bp - 10]);                    /* dec word [bp-0xa] */
            ii(0x6437, 2);  if(js(0x644d, 0x14)) goto l_0x644d;        /* js 0x644d */
            ii(0x6439, 3);  inc(memw[ss, bp - 4]);                     /* inc word [bp-0x4] */
        l_0x643c:
            ii(0x643c, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x643f, 3);  mov(al, memb[es, bx]);                     /* mov al, [es:bx] */
            ii(0x6442, 2);  sub(ah, ah);                               /* sub ah, ah */
            ii(0x6444, 1);  push(ax);                                  /* push ax */
            ii(0x6445, 3);  call(0x656f, 0x127);                       /* call 0x656f */
            ii(0x6448, 1);  pop(bx);                                   /* pop bx */
            ii(0x6449, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x644b, 2);  if(jz(0x6434, -0x19)) goto l_0x6434;       /* jz 0x6434 */
        l_0x644d:
            ii(0x644d, 3);  mov(al, memb[ss, bp - 10]);                /* mov al, [bp-0xa] */
            ii(0x6450, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x6453, 3);  mov(memb[es, bx], al);                     /* mov [es:bx], al */
        l_0x6456:
            ii(0x6456, 3);  les(bx, memw[ss, bp - 4]);                 /* les bx, [bp-0x4] */
            ii(0x6459, 3);  inc(memw[ss, bp - 4]);                     /* inc word [bp-0x4] */
            ii(0x645c, 3);  mov(al, memb[es, bx]);                     /* mov al, [es:bx] */
            ii(0x645f, 3);  inc(memw[ss, bp - 8]);                     /* inc word [bp-0x8] */
            ii(0x6462, 3);  les(bx, memw[ss, bp - 8]);                 /* les bx, [bp-0x8] */
            ii(0x6465, 3);  mov(memb[es, bx], al);                     /* mov [es:bx], al */
            ii(0x6468, 3);  dec(memw[ss, bp - 10]);                    /* dec word [bp-0xa] */
            ii(0x646b, 2);  if(jns(0x6456, -0x17)) goto l_0x6456;      /* jns 0x6456 */
            ii(0x646d, 3);  call(0x6595, 0x125);                       /* call 0x6595 */
        l_0x6470:
            ii(0x6470, 3);  call(0x8f82, 0x2b0f);                      /* call 0x8f82 */
            ii(0x6473, 3);  mov(ax, 0xe67);                            /* mov ax, 0xe67 */
            ii(0x6476, 1);  push(ax);                                  /* push ax */
            ii(0x6477, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x647a, 2);  push(memw[ds, bx]);                        /* push word [bx] */
            ii(0x647c, 3);  call(0x9618, 0x3199);                      /* call 0x9618 */
            ii(0x647f, 1);  pop(bx);                                   /* pop bx */
            ii(0x6480, 1);  pop(bx);                                   /* pop bx */
            ii(0x6481, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x6483, 2);  if(jnz(0x648b, 6)) goto l_0x648b;          /* jnz 0x648b */
            ii(0x6485, 3);  call(0x6333, -0x155);                      /* call 0x6333 */
            ii(0x6488, 3);  call(0x8f82, 0x2af7);                      /* call 0x8f82 */
        l_0x648b:
            ii(0x648b, 5);  cmp(memb[ds, 0x2f], 3);                    /* cmp byte [0x2f], 0x3 */
            ii(0x6490, 2);  if(jge(0x649a, 8)) goto l_0x649a;          /* jge 0x649a */
            ii(0x6492, 3);  mov(ax, 0xf);                              /* mov ax, 0xf */
            ii(0x6495, 1);  push(ax);                                  /* push ax */
            ii(0x6496, 3);  call(0x589d, -0xbfc);                      /* call 0x589d */
            ii(0x6499, 1);  pop(bx);                                   /* pop bx */
        l_0x649a:
            ii(0x649a, 3);  call(0x74c8, 0x102b);                      /* call 0x74c8 */
            ii(0x649d, 5);  cmp(memb[ds, 0x2f], 3);                    /* cmp byte [0x2f], 0x3 */
            ii(0x64a2, 2);  if(jl(0x64b2, 0xe)) goto l_0x64b2;         /* jl 0x64b2 */
            ii(0x64a4, 3);  call(0x6389, -0x11e);                      /* call 0x6389 */
            ii(0x64a7, 1);  push(ax);                                  /* push ax */
            ii(0x64a8, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x64ab, 2);  push(memw[ds, bx]);                        /* push word [bx] */
            ii(0x64ad, 3);  call(0xa01d, 0x3b6d);                      /* call 0xa01d */
            ii(0x64b0, 1);  pop(bx);                                   /* pop bx */
            ii(0x64b1, 1);  pop(bx);                                   /* pop bx */
        l_0x64b2:
            ii(0x64b2, 3);  call(0x986f, 0x33ba);                      /* call 0x986f */
            ii(0x64b5, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x64b7, 1);  pop(bp);                                   /* pop bp */
            ii(0x64b8, 1);  ret();                                     /* ret */
        }
    }
}

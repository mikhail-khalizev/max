using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8c69-39d5a414")]
        public void Method_0019_8c69()
        {
            ii(0x19_8c69, 4); enter(0x88, 0);                           /* enter 0x88, 0x0 */
            ii(0x19_8c6d, 1); push(si);                                 /* push si */
            ii(0x19_8c6e, 1); push(ds);                                 /* push ds */
            ii(0x19_8c6f, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_8c72, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_8c74, 4); mov(es, memw[ds, 0x3fbc]);                /* mov es, [0x3fbc] */
            ii(0x19_8c78, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_8c7c, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x19_8c7e, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_8c80, 3); mov(memw[ss, bp - 0x80], bx);             /* mov [bp-0x80], bx */
            ii(0x19_8c83, 3); mov(memw[ss, bp - 0x7e], es);             /* mov [bp-0x7e], es */
            ii(0x19_8c86, 5); test(memb[es, bx + 0x47], 0x80);          /* test byte [es:bx+0x47], 0x80 */
            ii(0x19_8c8b, 2); if(jnz(0x19_8cb8, 0x2b)) goto l_0x19_8cb8; /* jnz 0x8cb8 */
            ii(0x19_8c8d, 5); cmp(memb[ds, 0x1b20], 0);                 /* cmp byte [0x1b20], 0x0 */
            ii(0x19_8c92, 2); if(jnz(0x19_8cb8, 0x24)) goto l_0x19_8cb8; /* jnz 0x8cb8 */
            ii(0x19_8c94, 4); inc(memb[ds, 0x1b20]);                    /* inc byte [0x1b20] */
            ii(0x19_8c98, 3); push(0x88);                               /* push 0x88 */
            ii(0x19_8c9b, 3); push(0x4241);                             /* push 0x4241 */
            ii(0x19_8c9e, 3); call(0x19_fa6b, 0x6dca);                  /* call 0xfa6b */
            ii(0x19_8ca1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8ca3, 2); if(jz(0x19_8cb2, 0xd)) goto l_0x19_8cb2;  /* jz 0x8cb2 */
            ii(0x19_8ca5, 3); push(0x80);                               /* push 0x80 */
            ii(0x19_8ca8, 3); push(0x4252);                             /* push 0x4252 */
            ii(0x19_8cab, 3); call(0x19_fa6b, 0x6dbd);                  /* call 0xfa6b */
            ii(0x19_8cae, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8cb0, 2); if(jnz(0x19_8cb8, 0x6)) goto l_0x19_8cb8; /* jnz 0x8cb8 */
        l_0x19_8cb2:
            ii(0x19_8cb2, 3); mov(ax, 0x522);                           /* mov ax, 0x522 */
            ii(0x19_8cb5, 3); jmp(0x19_92a4, 0x5ec); goto l_0x19_92a4;  /* jmp 0x92a4 */
        l_0x19_8cb8:
            ii(0x19_8cb8, 3); call(0x19_8bd0, -0xeb);                   /* call 0x8bd0 */
            ii(0x19_8cbb, 3); les(bx, memw[ss, bp + 0xe]);              /* les bx, [bp+0xe] */
            ii(0x19_8cbe, 6); mov(memw[es, bx + 0x36], 0);              /* mov word [es:bx+0x36], 0x0 */
            ii(0x19_8cc4, 4); cmp(memw[ss, bp + 0x8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x19_8cc8, 2); if(jz(0x19_8ce3, 0x19)) goto l_0x19_8ce3; /* jz 0x8ce3 */
            ii(0x19_8cca, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_8ccd, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_8cd0, 3); call(0x19_c4ae, 0x37db);                  /* call 0xc4ae */
            ii(0x19_8cd3, 3); mov(memw[ss, bp - 0x78], ax);             /* mov [bp-0x78], ax */
            ii(0x19_8cd6, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8cd8, 2); if(jg(0x19_8d06, 0x2c)) goto l_0x19_8d06; /* jg 0x8d06 */
        l_0x19_8cda:
            ii(0x19_8cda, 3); call(0x19_8bea, -0xf3);                   /* call 0x8bea */
            ii(0x19_8cdd, 3); mov(ax, 0x514);                           /* mov ax, 0x514 */
            ii(0x19_8ce0, 3); jmp(0x19_92a4, 0x5c1); goto l_0x19_92a4;  /* jmp 0x92a4 */
        l_0x19_8ce3:
            ii(0x19_8ce3, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_8ce6, 3); mov(memw[ss, bp - 0x78], ax);             /* mov [bp-0x78], ax */
            ii(0x19_8ce9, 3); mov(ax, memw[ds, 0x32a6]);                /* mov ax, [0x32a6] */
            ii(0x19_8cec, 4); or(ax, memw[ds, 0x32a4]);                 /* or ax, [0x32a4] */
            ii(0x19_8cf0, 2); if(jz(0x19_8cfe, 0xc)) goto l_0x19_8cfe;  /* jz 0x8cfe */
            ii(0x19_8cf2, 4); call_far_ind(memw[ds, 0x32a4]);           /* call far word [0x32a4] */
            ii(0x19_8cf6, 3); mov(memw[ss, bp + 0x6], ax);              /* mov [bp+0x6], ax */
            ii(0x19_8cf9, 3); mov(memw[ss, bp + 0x8], dx);              /* mov [bp+0x8], dx */
            ii(0x19_8cfc, 2); jmp(0x19_8d06, 0x8); goto l_0x19_8d06;    /* jmp 0x8d06 */
        l_0x19_8cfe:
            ii(0x19_8cfe, 5); mov(memw[ss, bp + 0x6], 0x1ab1);          /* mov word [bp+0x6], 0x1ab1 */
            ii(0x19_8d03, 3); mov(memw[ss, bp + 0x8], ds);              /* mov [bp+0x8], ds */
        l_0x19_8d06:
            ii(0x19_8d06, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_8d09, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_8d0c, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x19_8d0f, 1); push(ss);                                 /* push ss */
            ii(0x19_8d10, 1); push(ax);                                 /* push ax */
            ii(0x19_8d11, 3); call(0x19_d4c3, 0x47af);                  /* call 0xd4c3 */
            ii(0x19_8d14, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x19_8d17, 1); push(ss);                                 /* push ss */
            ii(0x19_8d18, 1); push(ax);                                 /* push ax */
            ii(0x19_8d19, 3); call(0x19_a16e, 0x1452);                  /* call 0xa16e */
            ii(0x19_8d1c, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_8d1f, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_8d22, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x19_8d25, 2); if(jnz(0x19_8d2a, 0x3)) goto l_0x19_8d2a; /* jnz 0x8d2a */
            ii(0x19_8d27, 3); jmp(0x19_8edf, 0x1b5); goto l_0x19_8edf;  /* jmp 0x8edf */
        l_0x19_8d2a:
            ii(0x19_8d2a, 1); push(ax);                                 /* push ax */
            ii(0x19_8d2b, 3); push(memw[ss, bp - 0x78]);                /* push word [bp-0x78] */
            ii(0x19_8d2e, 3); call(0x19_9ed2, 0x11a1);                  /* call 0x9ed2 */
            ii(0x19_8d31, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8d33, 2); if(jz(0x19_8cda, -0x5b)) goto l_0x19_8cda; /* jz 0x8cda */
            ii(0x19_8d35, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_8d38, 3); push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x19_8d3b, 3); call(0x19_a14c, 0x140e);                  /* call 0xa14c */
            ii(0x19_8d3e, 3); mov(memw[ss, bp - 0x7c], ax);             /* mov [bp-0x7c], ax */
            ii(0x19_8d41, 3); mov(memw[ss, bp - 0x7a], dx);             /* mov [bp-0x7a], dx */
            ii(0x19_8d44, 1); nop();                                    /* nop */
            ii(0x19_8d45, 1); push(cs);                                 /* push cs */
            ii(0x19_8d46, 3); call(0x19_daf8, 0x4daf);                  /* call 0xdaf8 */
            ii(0x19_8d49, 3); push(memw[ss, bp - 0x7a]);                /* push word [bp-0x7a] */
            ii(0x19_8d4c, 3); push(memw[ss, bp - 0x7c]);                /* push word [bp-0x7c] */
            ii(0x19_8d4f, 3); call(0x19_b95c, 0x2c0a);                  /* call 0xb95c */
            ii(0x19_8d52, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8d55, 4); mov(ax, memw[es, bx + 0x3c]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_8d59, 4); mov(dx, memw[es, bx + 0x3e]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_8d5d, 3); mov(memw[ss, bp - 0x60], ax);             /* mov [bp-0x60], ax */
            ii(0x19_8d60, 3); mov(memw[ss, bp - 0x5e], dx);             /* mov [bp-0x5e], dx */
            ii(0x19_8d63, 4); les(si, memw[es, bx + 0x1c]);             /* les si, [es:bx+0x1c] */
            ii(0x19_8d67, 4); mov(ax, memw[es, si + 0x20]);             /* mov ax, [es:si+0x20] */
            ii(0x19_8d6b, 4); mov(memw[ss, bp - 0x86], ax);             /* mov [bp-0x86], ax */
            ii(0x19_8d6f, 3); mov(ax, memw[ds, 0x19e6]);                /* mov ax, [0x19e6] */
            ii(0x19_8d72, 3); mov(es, memw[ss, bp - 0x7a]);             /* mov es, [bp-0x7a] */
            ii(0x19_8d75, 4); mov(memw[es, bx + 0x68], ax);             /* mov [es:bx+0x68], ax */
            ii(0x19_8d79, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8d7c, 4); mov(ax, memw[es, bx + 0x68]);             /* mov ax, [es:bx+0x68] */
            ii(0x19_8d80, 4); mov(memw[ss, bp - 0x88], ax);             /* mov [bp-0x88], ax */
            ii(0x19_8d84, 3); mov(ax, memw[ds, 0x19e4]);                /* mov ax, [0x19e4] */
            ii(0x19_8d87, 4); mov(memw[es, bx + 0x6a], ax);             /* mov [es:bx+0x6a], ax */
            ii(0x19_8d8b, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8d8e, 4); mov(ax, memw[es, bx + 0x6a]);             /* mov ax, [es:bx+0x6a] */
            ii(0x19_8d92, 4); mov(memw[ss, bp - 0x84], ax);             /* mov [bp-0x84], ax */
            ii(0x19_8d96, 3); mov(ax, memw[ds, 0x19e8]);                /* mov ax, [0x19e8] */
            ii(0x19_8d99, 4); mov(memw[es, bx + 0x66], ax);             /* mov [es:bx+0x66], ax */
            ii(0x19_8d9d, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8da0, 4); mov(ax, memw[es, bx + 0x66]);             /* mov ax, [es:bx+0x66] */
            ii(0x19_8da4, 4); mov(memw[ss, bp - 0x82], ax);             /* mov [bp-0x82], ax */
        l_0x19_8da8:
            ii(0x19_8da8, 2); push(0);                                  /* push 0x0 */
            ii(0x19_8daa, 2); push(0x3e);                               /* push 0x3e */
            ii(0x19_8dac, 3); lea(ax, memw[ss, bp - 0x58]);             /* lea ax, [bp-0x58] */
            ii(0x19_8daf, 1); push(ss);                                 /* push ss */
            ii(0x19_8db0, 1); push(ax);                                 /* push ax */
            ii(0x19_8db1, 1); nop();                                    /* nop */
            ii(0x19_8db2, 1); push(cs);                                 /* push cs */
            ii(0x19_8db3, 3); call(0x19_0faf, -0x7e07);                 /* call 0xfaf */
            ii(0x19_8db6, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_8db9, 4); mov(es, memw[ds, 0x3fbc]);                /* mov es, [0x3fbc] */
            ii(0x19_8dbd, 4); mov(ax, memw[es, 0x3b7a]);                /* mov ax, [es:0x3b7a] */
            ii(0x19_8dc1, 3); mov(memw[ss, bp - 0x52], ax);             /* mov [bp-0x52], ax */
            ii(0x19_8dc4, 4); mov(ax, memw[ss, bp - 0x88]);             /* mov ax, [bp-0x88] */
            ii(0x19_8dc8, 3); mov(memw[ss, bp - 0x54], ax);             /* mov [bp-0x54], ax */
            ii(0x19_8dcb, 4); mov(ax, memw[ss, bp - 0x84]);             /* mov ax, [bp-0x84] */
            ii(0x19_8dcf, 3); mov(memw[ss, bp - 0x22], ax);             /* mov [bp-0x22], ax */
            ii(0x19_8dd2, 4); mov(ax, memw[ss, bp - 0x82]);             /* mov ax, [bp-0x82] */
            ii(0x19_8dd6, 3); mov(memw[ss, bp - 0x56], ax);             /* mov [bp-0x56], ax */
            ii(0x19_8dd9, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8ddc, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x19_8dde, 4); les(si, memw[es, bx + 0x1c]);             /* les si, [es:bx+0x1c] */
            ii(0x19_8de2, 4); mov(cx, memw[es, si + 0x1c]);             /* mov cx, [es:si+0x1c] */
            ii(0x19_8de6, 4); mov(dx, memw[es, si + 0x1e]);             /* mov dx, [es:si+0x1e] */
            ii(0x19_8dea, 3); mov(memw[ss, bp - 0x26], cx);             /* mov [bp-0x26], cx */
            ii(0x19_8ded, 3); mov(memw[ss, bp - 0x24], dx);             /* mov [bp-0x24], dx */
            ii(0x19_8df0, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_8df2, 4); les(bx, memw[es, bx + 0x1c]);             /* les bx, [es:bx+0x1c] */
            ii(0x19_8df6, 4); mov(ax, memw[es, bx + 0x24]);             /* mov ax, [es:bx+0x24] */
            ii(0x19_8dfa, 4); mov(dx, memw[es, bx + 0x26]);             /* mov dx, [es:bx+0x26] */
            ii(0x19_8dfe, 2); and(al, 0xfc);                            /* and al, 0xfc */
            ii(0x19_8e00, 3); mov(memw[ss, bp - 0x40], ax);             /* mov [bp-0x40], ax */
            ii(0x19_8e03, 3); mov(memw[ss, bp - 0x3e], dx);             /* mov [bp-0x3e], dx */
            ii(0x19_8e06, 5); mov(memw[ss, bp - 0x50], 0);              /* mov word [bp-0x50], 0x0 */
            ii(0x19_8e0b, 4); mov(es, memw[ds, 0x3fbc]);                /* mov es, [0x3fbc] */
            ii(0x19_8e0f, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_8e13, 3); mov(memw[ss, bp - 0x4e], ax);             /* mov [bp-0x4e], ax */
            ii(0x19_8e16, 5); mov(memw[ss, bp - 0x1e], 0x200);          /* mov word [bp-0x1e], 0x200 */
            ii(0x19_8e1b, 5); mov(memw[ss, bp - 0x1c], 0);              /* mov word [bp-0x1c], 0x0 */
            ii(0x19_8e20, 5); cmp(memw[ss, bp - 0x86], 0);              /* cmp word [bp-0x86], 0x0 */
            ii(0x19_8e25, 2); if(jz(0x19_8e58, 0x31)) goto l_0x19_8e58; /* jz 0x8e58 */
            ii(0x19_8e27, 5); imul(ax, memw[ss, bp - 0x86], 0x18);      /* imul ax, [bp-0x86], 0x18 */
            ii(0x19_8e2c, 3); add(ax, memw[ss, bp - 0x60]);             /* add ax, [bp-0x60] */
            ii(0x19_8e2f, 3); mov(dx, memw[ss, bp - 0x5e]);             /* mov dx, [bp-0x5e] */
            ii(0x19_8e32, 3); sub(ax, 0x18);                            /* sub ax, 0x18 */
            ii(0x19_8e35, 1); push(dx);                                 /* push dx */
            ii(0x19_8e36, 1); push(ax);                                 /* push ax */
            ii(0x19_8e37, 3); call(0x19_cd74, 0x3f3a);                  /* call 0xcd74 */
            ii(0x19_8e3a, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_8e3e, 4); mov(memw[es, bx + 0x4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x19_8e42, 4); mov(memw[es, bx + 0x6], dx);              /* mov [es:bx+0x6], dx */
            ii(0x19_8e46, 3); mov(ax, memw[ss, bp - 0x40]);             /* mov ax, [bp-0x40] */
            ii(0x19_8e49, 3); mov(dx, memw[ss, bp - 0x3e]);             /* mov dx, [bp-0x3e] */
            ii(0x19_8e4c, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_8e50, 4); mov(memw[es, bx + 0x8], ax);              /* mov [es:bx+0x8], ax */
            ii(0x19_8e54, 4); mov(memw[es, bx + 0xa], dx);              /* mov [es:bx+0xa], dx */
        l_0x19_8e58:
            ii(0x19_8e58, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_8e5b, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_8e5e, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_8e62, 4); mov(memw[es, bx + 0x30], ax);             /* mov [es:bx+0x30], ax */
            ii(0x19_8e66, 6); mov(memw[es, bx + 0x32], 0);              /* mov word [es:bx+0x32], 0x0 */
            ii(0x19_8e6c, 4); mov(ax, memw[ss, bp - 0x84]);             /* mov ax, [bp-0x84] */
            ii(0x19_8e70, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_8e72, 1); push(ax);                                 /* push ax */
            ii(0x19_8e73, 1); push(cx);                                 /* push cx */
            ii(0x19_8e74, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_8e79, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8e7a, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8e7b, 3); mov(memw[ss, bp - 0x6c], ax);             /* mov [bp-0x6c], ax */
            ii(0x19_8e7e, 3); mov(memw[ss, bp - 0x6a], dx);             /* mov [bp-0x6a], dx */
            ii(0x19_8e81, 3); add(ax, memw[ss, bp - 0x26]);             /* add ax, [bp-0x26] */
            ii(0x19_8e84, 3); adc(dx, memw[ss, bp - 0x24]);             /* adc dx, [bp-0x24] */
            ii(0x19_8e87, 1); push(dx);                                 /* push dx */
            ii(0x19_8e88, 1); push(ax);                                 /* push ax */
            ii(0x19_8e89, 3); call(0x19_8b7d, -0x30f);                  /* call 0x8b7d */
            ii(0x19_8e8c, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8e8e, 2); if(jz(0x19_8e99, 0x9)) goto l_0x19_8e99;  /* jz 0x8e99 */
            ii(0x19_8e90, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8e93, 6); or(memb[es, bx + 0x132], 0x2);            /* or byte [es:bx+0x132], 0x2 */
        l_0x19_8e99:
            ii(0x19_8e99, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8e9c, 6); test(memb[es, bx + 0x132], 0x2);          /* test byte [es:bx+0x132], 0x2 */
            ii(0x19_8ea2, 2); if(jnz(0x19_8eb9, 0x15)) goto l_0x19_8eb9; /* jnz 0x8eb9 */
            ii(0x19_8ea4, 2); push(0);                                  /* push 0x0 */
            ii(0x19_8ea6, 1); push(ds);                                 /* push ds */
            ii(0x19_8ea7, 3); push(0x1ab9);                             /* push 0x1ab9 */
            ii(0x19_8eaa, 1); nop();                                    /* nop */
            ii(0x19_8eab, 1); push(cs);                                 /* push cs */
            ii(0x19_8eac, 3); call(0x19_cd5c, 0x3ead);                  /* call 0xcd5c */
            ii(0x19_8eaf, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_8eb2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8eb4, 2); if(jnz(0x19_8eb9, 0x3)) goto l_0x19_8eb9; /* jnz 0x8eb9 */
            ii(0x19_8eb6, 3); jmp(0x19_90a3, 0x1ea); goto l_0x19_90a3;  /* jmp 0x90a3 */
        l_0x19_8eb9:
            ii(0x19_8eb9, 1); push(ds);                                 /* push ds */
            ii(0x19_8eba, 3); push(0x1ac0);                             /* push 0x1ac0 */
            ii(0x19_8ebd, 3); call(0x19_1066, -0x7e5a);                 /* call 0x1066 */
            ii(0x19_8ec0, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8ec1, 1); pop(bx);                                  /* pop bx */
            ii(0x19_8ec2, 3); mov(ax, memw[ss, bp - 0x54]);             /* mov ax, [bp-0x54] */
            ii(0x19_8ec5, 3); mov(memw[ss, bp - 0x52], ax);             /* mov [bp-0x52], ax */
            ii(0x19_8ec8, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_8ecc, 5); mov(ax, memw[es, bx + 0x244]);            /* mov ax, [es:bx+0x244] */
            ii(0x19_8ed1, 3); mov(memw[ss, bp - 0x50], ax);             /* mov [bp-0x50], ax */
            ii(0x19_8ed4, 5); mov(memw[ss, bp - 0x4e], 0);              /* mov word [bp-0x4e], 0x0 */
            ii(0x19_8ed9, 3); call(0x19_92a8, 0x3cc);                   /* call 0x92a8 */
            ii(0x19_8edc, 3); jmp(0x19_90ac, 0x1cd); goto l_0x19_90ac;  /* jmp 0x90ac */
        l_0x19_8edf:
            ii(0x19_8edf, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_8ee2, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_8ee5, 3); lea(ax, memw[ss, bp - 0x7c]);             /* lea ax, [bp-0x7c] */
            ii(0x19_8ee8, 1); push(ss);                                 /* push ss */
            ii(0x19_8ee9, 1); push(ax);                                 /* push ax */
            ii(0x19_8eea, 3); call(0x19_a06c, 0x117f);                  /* call 0xa06c */
            ii(0x19_8eed, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_8ef0, 3); mov(memw[es, bx], ax);                    /* mov [es:bx], ax */
            ii(0x19_8ef3, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x19_8ef6, 2); if(jnz(0x19_8efb, 0x3)) goto l_0x19_8efb; /* jnz 0x8efb */
            ii(0x19_8ef8, 3); jmp(0x19_8cda, -0x221); goto l_0x19_8cda; /* jmp 0x8cda */
        l_0x19_8efb:
            ii(0x19_8efb, 3); mov(ax, memw[ss, bp - 0x78]);             /* mov ax, [bp-0x78] */
            ii(0x19_8efe, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8f01, 5); mov(memw[es, bx + 0xb4], ax);             /* mov [es:bx+0xb4], ax */
            ii(0x19_8f06, 4); cmp(memw[ss, bp + 0xa], -0x1 /* 0xff */); /* cmp word [bp+0xa], 0xffff */
            ii(0x19_8f0a, 2); if(jnz(0x19_8f1e, 0x12)) goto l_0x19_8f1e; /* jnz 0x8f1e */
            ii(0x19_8f0c, 4); cmp(memw[ss, bp + 0xc], -0x1 /* 0xff */); /* cmp word [bp+0xc], 0xffff */
            ii(0x19_8f10, 2); if(jnz(0x19_8f1e, 0xc)) goto l_0x19_8f1e; /* jnz 0x8f1e */
            ii(0x19_8f12, 1); push(ax);                                 /* push ax */
            ii(0x19_8f13, 2); push(0);                                  /* push 0x0 */
            ii(0x19_8f15, 2); push(0);                                  /* push 0x0 */
            ii(0x19_8f17, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_8f19, 3); call(0x19_fed2, 0x6fb6);                  /* call 0xfed2 */
            ii(0x19_8f1c, 2); jmp(0x19_8f24, 0x6); goto l_0x19_8f24;    /* jmp 0x8f24 */
        l_0x19_8f1e:
            ii(0x19_8f1e, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_8f21, 3); mov(dx, memw[ss, bp + 0xc]);              /* mov dx, [bp+0xc] */
        l_0x19_8f24:
            ii(0x19_8f24, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8f27, 5); mov(memw[es, bx + 0xb6], ax);             /* mov [es:bx+0xb6], ax */
            ii(0x19_8f2c, 5); mov(memw[es, bx + 0xb8], dx);             /* mov [es:bx+0xb8], dx */
            ii(0x19_8f31, 3); mov(al, memb[ds, 0x19f3]);                /* mov al, [0x19f3] */
            ii(0x19_8f34, 1); cbw();                                    /* cbw */
            ii(0x19_8f35, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8f38, 4); mov(memw[es, bx + 0x5c], ax);             /* mov [es:bx+0x5c], ax */
            ii(0x19_8f3c, 5); cmp(memb[ds, 0x19f4], 0x1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_8f41, 2); if(jnz(0x19_8f57, 0x14)) goto l_0x19_8f57; /* jnz 0x8f57 */
            ii(0x19_8f43, 3); mov(ax, memw[ds, 0x19fe]);                /* mov ax, [0x19fe] */
            ii(0x19_8f46, 4); mov(dx, memw[ds, 0x1a00]);                /* mov dx, [0x1a00] */
            ii(0x19_8f4a, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8f4d, 5); mov(memw[es, bx + 0xc4], ax);             /* mov [es:bx+0xc4], ax */
            ii(0x19_8f52, 5); mov(memw[es, bx + 0xc6], dx);             /* mov [es:bx+0xc6], dx */
        l_0x19_8f57:
            ii(0x19_8f57, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_8f5a, 3); push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x19_8f5d, 2); push(0);                                  /* push 0x0 */
            ii(0x19_8f5f, 3); call(0x19_a6d4, 0x1772);                  /* call 0xa6d4 */
            ii(0x19_8f62, 3); mov(memw[ss, bp - 0x72], ax);             /* mov [bp-0x72], ax */
            ii(0x19_8f65, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8f67, 2); if(jz(0x19_8f88, 0x1f)) goto l_0x19_8f88; /* jz 0x8f88 */
            ii(0x19_8f69, 4); cmp(memw[ss, bp + 0x8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x19_8f6d, 2); if(jz(0x19_8f7f, 0x10)) goto l_0x19_8f7f; /* jz 0x8f7f */
            ii(0x19_8f6f, 3); push(memw[ss, bp - 0x78]);                /* push word [bp-0x78] */
            ii(0x19_8f72, 3); call(0x19_febc, 0x6f47);                  /* call 0xfebc */
            ii(0x19_8f75, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8f78, 7); mov(memw[es, bx + 0xb4], 0xffff);         /* mov word [es:bx+0xb4], 0xffff */
        l_0x19_8f7f:
            ii(0x19_8f7f, 3); call(0x19_8bea, -0x398);                  /* call 0x8bea */
            ii(0x19_8f82, 3); mov(ax, memw[ss, bp - 0x72]);             /* mov ax, [bp-0x72] */
            ii(0x19_8f85, 3); jmp(0x19_92a4, 0x31c); goto l_0x19_92a4;  /* jmp 0x92a4 */
        l_0x19_8f88:
            ii(0x19_8f88, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_8f8b, 4); mov(ax, memw[es, bx + 0x3c]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_8f8f, 4); mov(dx, memw[es, bx + 0x3e]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_8f93, 3); mov(memw[ss, bp - 0x60], ax);             /* mov [bp-0x60], ax */
            ii(0x19_8f96, 3); mov(memw[ss, bp - 0x5e], dx);             /* mov [bp-0x5e], dx */
            ii(0x19_8f99, 4); les(bx, memw[es, bx + 0x1c]);             /* les bx, [es:bx+0x1c] */
            ii(0x19_8f9d, 4); mov(cx, memw[es, bx + 0x20]);             /* mov cx, [es:bx+0x20] */
            ii(0x19_8fa1, 4); mov(memw[ss, bp - 0x86], cx);             /* mov [bp-0x86], cx */
            ii(0x19_8fa5, 4); mov(cx, memw[es, bx + 0x18]);             /* mov cx, [es:bx+0x18] */
            ii(0x19_8fa9, 1); dec(cx);                                  /* dec cx */
            ii(0x19_8faa, 3); mov(memw[ss, bp - 0x74], cx);             /* mov [bp-0x74], cx */
            ii(0x19_8fad, 3); imul(si, cx, 0x18);                       /* imul si, cx, 0x18 */
            ii(0x19_8fb0, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_8fb2, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_8fb4, 5); test(memb[es, bx + si + 0x9], 0x20);      /* test byte [es:bx+si+0x9], 0x20 */
            ii(0x19_8fb9, 2); if(jz(0x19_8fc0, 0x5)) goto l_0x19_8fc0;  /* jz 0x8fc0 */
            ii(0x19_8fbb, 3); mov(ax, memw[ds, 0x19e4]);                /* mov ax, [0x19e4] */
            ii(0x19_8fbe, 2); jmp(0x19_8fc7, 0x7); goto l_0x19_8fc7;    /* jmp 0x8fc7 */
        l_0x19_8fc0:
            ii(0x19_8fc0, 3); imul(si, cx, 0x18);                       /* imul si, cx, 0x18 */
            ii(0x19_8fc3, 4); mov(ax, memw[es, bx + si + 0x14]);        /* mov ax, [es:bx+si+0x14] */
        l_0x19_8fc7:
            ii(0x19_8fc7, 4); mov(memw[ss, bp - 0x84], ax);             /* mov [bp-0x84], ax */
            ii(0x19_8fcb, 5); cmp(memw[ss, bp - 0x86], 0);              /* cmp word [bp-0x86], 0x0 */
            ii(0x19_8fd0, 2); if(jz(0x19_9000, 0x2e)) goto l_0x19_9000; /* jz 0x9000 */
            ii(0x19_8fd2, 5); imul(si, memw[ss, bp - 0x86], 0x18);      /* imul si, [bp-0x86], 0x18 */
            ii(0x19_8fd7, 4); mov(ah, memb[es, bx + si - 0xf]);         /* mov ah, [es:bx+si-0xf] */
            ii(0x19_8fdb, 3); and(ax, 0x2000);                          /* and ax, 0x2000 */
            ii(0x19_8fde, 3); mov(memw[ss, bp - 0x66], ax);             /* mov [bp-0x66], ax */
            ii(0x19_8fe1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_8fe3, 2); if(jz(0x19_8ff5, 0x10)) goto l_0x19_8ff5; /* jz 0x8ff5 */
            ii(0x19_8fe5, 3); mov(ax, memw[ds, 0x19e6]);                /* mov ax, [0x19e6] */
            ii(0x19_8fe8, 4); mov(memw[ss, bp - 0x88], ax);             /* mov [bp-0x88], ax */
            ii(0x19_8fec, 3); mov(ax, memw[ds, 0x19e8]);                /* mov ax, [0x19e8] */
            ii(0x19_8fef, 4); mov(memw[ss, bp - 0x82], ax);             /* mov [bp-0x82], ax */
            ii(0x19_8ff3, 2); jmp(0x19_900a, 0x15); goto l_0x19_900a;   /* jmp 0x900a */
        l_0x19_8ff5:
            ii(0x19_8ff5, 5); imul(si, memw[ss, bp - 0x86], 0x18);      /* imul si, [bp-0x86], 0x18 */
            ii(0x19_8ffa, 4); mov(ax, memw[es, bx + si - 0x4]);         /* mov ax, [es:bx+si-0x4] */
            ii(0x19_8ffe, 2); jmp(0x19_9002, 0x2); goto l_0x19_9002;    /* jmp 0x9002 */
        l_0x19_9000:
            ii(0x19_9000, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_9002:
            ii(0x19_9002, 4); mov(memw[ss, bp - 0x82], ax);             /* mov [bp-0x82], ax */
            ii(0x19_9006, 4); mov(memw[ss, bp - 0x88], ax);             /* mov [bp-0x88], ax */
        l_0x19_900a:
            ii(0x19_900a, 4); mov(ax, memw[ss, bp - 0x84]);             /* mov ax, [bp-0x84] */
            ii(0x19_900e, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_9011, 4); mov(memw[es, bx + 0x6a], ax);             /* mov [es:bx+0x6a], ax */
            ii(0x19_9015, 4); mov(ax, memw[ss, bp - 0x88]);             /* mov ax, [bp-0x88] */
            ii(0x19_9019, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_901c, 4); mov(memw[es, bx + 0x68], ax);             /* mov [es:bx+0x68], ax */
            ii(0x19_9020, 4); mov(ax, memw[ss, bp - 0x82]);             /* mov ax, [bp-0x82] */
            ii(0x19_9024, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_9027, 4); mov(memw[es, bx + 0x66], ax);             /* mov [es:bx+0x66], ax */
            ii(0x19_902b, 3); mov(ax, memw[ss, bp - 0x66]);             /* mov ax, [bp-0x66] */
            ii(0x19_902e, 3); mov(memw[ss, bp - 0x70], ax);             /* mov [bp-0x70], ax */
            ii(0x19_9031, 5); mov(memw[ss, bp - 0x76], 0);              /* mov word [bp-0x76], 0x0 */
            ii(0x19_9036, 2); jmp(0x19_903b, 0x3); goto l_0x19_903b;    /* jmp 0x903b */
        l_0x19_9038:
            ii(0x19_9038, 3); inc(memw[ss, bp - 0x76]);                 /* inc word [bp-0x76] */
        l_0x19_903b:
            ii(0x19_903b, 3); mov(ax, memw[ss, bp - 0x76]);             /* mov ax, [bp-0x76] */
            ii(0x19_903e, 1); cwd();                                    /* cwd */
            ii(0x19_903f, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_9042, 4); les(bx, memw[es, bx + 0x1c]);             /* les bx, [es:bx+0x1c] */
            ii(0x19_9046, 4); cmp(memw[es, bx + 0x46], dx);             /* cmp [es:bx+0x46], dx */
            ii(0x19_904a, 2); if(jae(0x19_904f, 0x3)) goto l_0x19_904f; /* jae 0x904f */
            ii(0x19_904c, 3); jmp(0x19_8da8, -0x2a7); goto l_0x19_8da8; /* jmp 0x8da8 */
        l_0x19_904f:
            ii(0x19_904f, 2); if(ja(0x19_905a, 0x9)) goto l_0x19_905a;  /* ja 0x905a */
            ii(0x19_9051, 4); cmp(memw[es, bx + 0x44], ax);             /* cmp [es:bx+0x44], ax */
            ii(0x19_9055, 2); if(ja(0x19_905a, 0x3)) goto l_0x19_905a;  /* ja 0x905a */
            ii(0x19_9057, 3); jmp(0x19_8da8, -0x2b2); goto l_0x19_8da8; /* jmp 0x8da8 */
        l_0x19_905a:
            ii(0x19_905a, 3); imul(si, ax, 0x18);                       /* imul si, ax, 0x18 */
            ii(0x19_905d, 3); les(bx, memw[ss, bp - 0x60]);             /* les bx, [bp-0x60] */
            ii(0x19_9060, 5); test(memb[es, bx + si + 0x9], 0x10);      /* test byte [es:bx+si+0x9], 0x10 */
            ii(0x19_9065, 2); if(jnz(0x19_9038, -0x2f)) goto l_0x19_9038; /* jnz 0x9038 */
            ii(0x19_9067, 3); imul(bx, ax, 0x18);                       /* imul bx, ax, 0x18 */
            ii(0x19_906a, 3); add(bx, memw[ss, bp - 0x60]);             /* add bx, [bp-0x60] */
            ii(0x19_906d, 5); test(memb[es, bx + 0x8], 0x4);            /* test byte [es:bx+0x8], 0x4 */
            ii(0x19_9072, 2); if(jz(0x19_9082, 0xe)) goto l_0x19_9082;  /* jz 0x9082 */
            ii(0x19_9074, 4); mov(ax, memw[ss, bp - 0x84]);             /* mov ax, [bp-0x84] */
            ii(0x19_9078, 4); mov(memw[es, bx + 0x14], ax);             /* mov [es:bx+0x14], ax */
            ii(0x19_907c, 6); mov(memw[es, bx + 0x16], 0);              /* mov word [es:bx+0x16], 0x0 */
        l_0x19_9082:
            ii(0x19_9082, 4); imul(bx, memw[ss, bp - 0x76], 0x18);      /* imul bx, [bp-0x76], 0x18 */
            ii(0x19_9086, 3); add(bx, memw[ss, bp - 0x60]);             /* add bx, [bp-0x60] */
            ii(0x19_9089, 3); mov(es, memw[ss, bp - 0x5e]);             /* mov es, [bp-0x5e] */
            ii(0x19_908c, 5); test(memb[es, bx + 0x8], 0x2);            /* test byte [es:bx+0x8], 0x2 */
            ii(0x19_9091, 2); if(jz(0x19_9038, -0x5b)) goto l_0x19_9038; /* jz 0x9038 */
            ii(0x19_9093, 4); mov(ax, memw[ss, bp - 0x88]);             /* mov ax, [bp-0x88] */
            ii(0x19_9097, 4); mov(memw[es, bx + 0x14], ax);             /* mov [es:bx+0x14], ax */
            ii(0x19_909b, 6); mov(memw[es, bx + 0x16], 0);              /* mov word [es:bx+0x16], 0x0 */
            ii(0x19_90a1, 2); jmp(0x19_9038, -0x6b); goto l_0x19_9038;  /* jmp 0x9038 */
        l_0x19_90a3:
            ii(0x19_90a3, 1); push(ds);                                 /* push ds */
            ii(0x19_90a4, 3); push(0x1aee);                             /* push 0x1aee */
            ii(0x19_90a7, 3); call(0x1a_1066, 0x7fbc);                  /* call 0x1066 */
            ii(0x19_90aa, 1); pop(bx);                                  /* pop bx */
            ii(0x19_90ab, 1); pop(bx);                                  /* pop bx */
        l_0x19_90ac:
            ii(0x19_90ac, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_90af, 6); test(memb[es, bx + 0x132], 0x1);          /* test byte [es:bx+0x132], 0x1 */
            ii(0x19_90b5, 2); if(jz(0x19_90c3, 0xc)) goto l_0x19_90c3;  /* jz 0x90c3 */
            ii(0x19_90b7, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_90bb, 5); mov(ax, memw[es, bx + 0x246]);            /* mov ax, [es:bx+0x246] */
            ii(0x19_90c0, 3); mov(memw[ss, bp - 0x50], ax);             /* mov [bp-0x50], ax */
        l_0x19_90c3:
            ii(0x19_90c3, 4); mov(ax, memw[ss, bp - 0x82]);             /* mov ax, [bp-0x82] */
            ii(0x19_90c7, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_90c9, 1); push(ax);                                 /* push ax */
            ii(0x19_90ca, 1); push(cx);                                 /* push cx */
            ii(0x19_90cb, 5); call_far_abs(0x80, 0x55dc);               /* call word 0x80:0x55dc */
            ii(0x19_90d0, 1); pop(bx);                                  /* pop bx */
            ii(0x19_90d1, 1); pop(bx);                                  /* pop bx */
            ii(0x19_90d2, 3); mov(memw[ss, bp - 0x6c], ax);             /* mov [bp-0x6c], ax */
            ii(0x19_90d5, 3); mov(memw[ss, bp - 0x6a], dx);             /* mov [bp-0x6a], dx */
            ii(0x19_90d8, 5); cmp(memw[ss, bp - 0x86], 0);              /* cmp word [bp-0x86], 0x0 */
            ii(0x19_90dd, 2); if(jnz(0x19_90e2, 0x3)) goto l_0x19_90e2; /* jnz 0x90e2 */
            ii(0x19_90df, 3); jmp(0x19_91c5, 0xe3); goto l_0x19_91c5;   /* jmp 0x91c5 */
        l_0x19_90e2:
            ii(0x19_90e2, 4); sub(memw[ss, bp - 0x40], 0x20);           /* sub word [bp-0x40], 0x20 */
            ii(0x19_90e6, 4); sbb(memw[ss, bp - 0x3e], 0);              /* sbb word [bp-0x3e], 0x0 */
            ii(0x19_90ea, 3); mov(ax, memw[ss, bp - 0x40]);             /* mov ax, [bp-0x40] */
            ii(0x19_90ed, 3); add(ax, memw[ss, bp - 0x6c]);             /* add ax, [bp-0x6c] */
            ii(0x19_90f0, 3); and(ah, 0xf);                             /* and ah, 0xf */
            ii(0x19_90f3, 3); cmp(ax, 0x100);                           /* cmp ax, 0x100 */
            ii(0x19_90f6, 2); if(jae(0x19_90ff, 0x7)) goto l_0x19_90ff; /* jae 0x90ff */
            ii(0x19_90f8, 5); mov(memw[ss, bp - 0x6e], 0x200);          /* mov word [bp-0x6e], 0x200 */
            ii(0x19_90fd, 2); jmp(0x19_9104, 0x5); goto l_0x19_9104;    /* jmp 0x9104 */
        l_0x19_90ff:
            ii(0x19_90ff, 5); mov(memw[ss, bp - 0x6e], 0);              /* mov word [bp-0x6e], 0x0 */
        l_0x19_9104:
            ii(0x19_9104, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9106, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9108, 3); mov(ax, memw[ss, bp - 0x6c]);             /* mov ax, [bp-0x6c] */
            ii(0x19_910b, 3); sub(ax, memw[ss, bp - 0x6e]);             /* sub ax, [bp-0x6e] */
            ii(0x19_910e, 3); sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x19_9111, 3); add(ax, memw[ss, bp - 0x40]);             /* add ax, [bp-0x40] */
            ii(0x19_9114, 3); adc(dx, memw[ss, bp - 0x3e]);             /* adc dx, [bp-0x3e] */
            ii(0x19_9117, 1); push(dx);                                 /* push dx */
            ii(0x19_9118, 1); push(ax);                                 /* push ax */
            ii(0x19_9119, 3); mov(ax, memw[ss, bp - 0x6e]);             /* mov ax, [bp-0x6e] */
            ii(0x19_911c, 3); add(ax, 0x20);                            /* add ax, 0x20 */
            ii(0x19_911f, 2); push(0);                                  /* push 0x0 */
            ii(0x19_9121, 1); push(ax);                                 /* push ax */
            ii(0x19_9122, 3); call(0x19_de46, 0x4d21);                  /* call 0xde46 */
            ii(0x19_9125, 3); mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0x19_9128, 3); mov(memw[ss, bp - 0x16], dx);             /* mov [bp-0x16], dx */
            ii(0x19_912b, 3); les(bx, memw[ss, bp - 0x18]);             /* les bx, [bp-0x18] */
            ii(0x19_912e, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_9131, 3); mov(memw[ss, bp - 0x72], ax);             /* mov [bp-0x72], ax */
            ii(0x19_9134, 4); shr(memw[ss, bp - 0x6e], 0x2);            /* shr word [bp-0x6e], 0x2 */
            ii(0x19_9138, 3); mov(bx, memw[ss, bp - 0x6e]);             /* mov bx, [bp-0x6e] */
            ii(0x19_913b, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_913e, 3); mov(si, memw[ss, bp - 0x18]);             /* mov si, [bp-0x18] */
            ii(0x19_9141, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9143, 4); mov(memw[es, bx + si + 0x2], ax);         /* mov [es:bx+si+0x2], ax */
            ii(0x19_9147, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
            ii(0x19_914a, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_914d, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_9150, 3); mov(bx, memw[ss, bp - 0x6e]);             /* mov bx, [bp-0x6e] */
            ii(0x19_9153, 1); inc(bx);                                  /* inc bx */
            ii(0x19_9154, 3); mov(memw[ss, bp - 0x6e], bx);             /* mov [bp-0x6e], bx */
            ii(0x19_9157, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_915a, 3); les(si, memw[ss, bp - 0x18]);             /* les si, [bp-0x18] */
            ii(0x19_915d, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
            ii(0x19_9160, 6); mov(memw[es, bx + si + 0x2], 0);          /* mov word [es:bx+si+0x2], 0x0 */
            ii(0x19_9166, 3); mov(bx, memw[ss, bp - 0x6e]);             /* mov bx, [bp-0x6e] */
            ii(0x19_9169, 1); inc(bx);                                  /* inc bx */
            ii(0x19_916a, 3); mov(memw[ss, bp - 0x6e], bx);             /* mov [bp-0x6e], bx */
            ii(0x19_916d, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_9170, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9172, 4); mov(memw[es, bx + si + 0x2], ax);         /* mov [es:bx+si+0x2], ax */
            ii(0x19_9176, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
            ii(0x19_9179, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_917d, 4); mov(ax, memw[es, bx + 0x38]);             /* mov ax, [es:bx+0x38] */
            ii(0x19_9181, 4); mov(dx, memw[es, bx + 0x3a]);             /* mov dx, [es:bx+0x3a] */
            ii(0x19_9185, 3); mov(bx, memw[ss, bp - 0x6e]);             /* mov bx, [bp-0x6e] */
            ii(0x19_9188, 1); inc(bx);                                  /* inc bx */
            ii(0x19_9189, 3); mov(memw[ss, bp - 0x6e], bx);             /* mov [bp-0x6e], bx */
            ii(0x19_918c, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_918f, 3); les(si, memw[ss, bp - 0x18]);             /* les si, [bp-0x18] */
            ii(0x19_9192, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
            ii(0x19_9195, 4); mov(memw[es, bx + si + 0x2], dx);         /* mov [es:bx+si+0x2], dx */
            ii(0x19_9199, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_919d, 4); mov(ax, memw[es, bx + 0x34]);             /* mov ax, [es:bx+0x34] */
            ii(0x19_91a1, 4); mov(dx, memw[es, bx + 0x36]);             /* mov dx, [es:bx+0x36] */
            ii(0x19_91a5, 3); mov(bx, memw[ss, bp - 0x6e]);             /* mov bx, [bp-0x6e] */
            ii(0x19_91a8, 1); inc(bx);                                  /* inc bx */
            ii(0x19_91a9, 3); mov(memw[ss, bp - 0x6e], bx);             /* mov [bp-0x6e], bx */
            ii(0x19_91ac, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_91af, 3); les(si, memw[ss, bp - 0x18]);             /* les si, [bp-0x18] */
            ii(0x19_91b2, 3); mov(memw[es, bx + si], ax);               /* mov [es:bx+si], ax */
            ii(0x19_91b5, 4); mov(memw[es, bx + si + 0x2], dx);         /* mov [es:bx+si+0x2], dx */
            ii(0x19_91b9, 3); mov(ax, memw[ss, bp - 0x6e]);             /* mov ax, [bp-0x6e] */
            ii(0x19_91bc, 1); inc(ax);                                  /* inc ax */
            ii(0x19_91bd, 3); mov(memw[ss, bp - 0x6e], ax);             /* mov [bp-0x6e], ax */
            ii(0x19_91c0, 1); push(es);                                 /* push es */
            ii(0x19_91c1, 1); push(si);                                 /* push si */
            ii(0x19_91c2, 3); call(0x19_df78, 0x4db3);                  /* call 0xdf78 */
        l_0x19_91c5:
            ii(0x19_91c5, 3); mov(ax, memw[ss, bp + 0x18]);             /* mov ax, [bp+0x18] */
            ii(0x19_91c8, 3); or(ax, memw[ss, bp + 0x16]);              /* or ax, [bp+0x16] */
            ii(0x19_91cb, 2); if(jz(0x19_923f, 0x72)) goto l_0x19_923f; /* jz 0x923f */
            ii(0x19_91cd, 3); lea(ax, memw[ss, bp + 0x16]);             /* lea ax, [bp+0x16] */
            ii(0x19_91d0, 1); push(ss);                                 /* push ss */
            ii(0x19_91d1, 1); push(ax);                                 /* push ax */
            ii(0x19_91d2, 3); call(0x19_8c1c, -0x5b9);                  /* call 0x8c1c */
            ii(0x19_91d5, 3); push(memw[ss, bp + 0x18]);                /* push word [bp+0x18] */
            ii(0x19_91d8, 3); push(memw[ss, bp + 0x16]);                /* push word [bp+0x16] */
            ii(0x19_91db, 5); call_far_abs(0x80, 0x5066);               /* call word 0x80:0x5066 */
            ii(0x19_91e0, 1); pop(bx);                                  /* pop bx */
            ii(0x19_91e1, 1); pop(bx);                                  /* pop bx */
            ii(0x19_91e2, 3); sub(ax, memw[ss, bp + 0x16]);             /* sub ax, [bp+0x16] */
            ii(0x19_91e5, 1); inc(ax);                                  /* inc ax */
            ii(0x19_91e6, 3); mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x19_91e9, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_91eb, 2); if(jz(0x19_91f2, 0x5)) goto l_0x19_91f2;  /* jz 0x91f2 */
            ii(0x19_91ed, 3); cmp(ax, 0x200);                           /* cmp ax, 0x200 */
            ii(0x19_91f0, 2); if(jbe(0x19_91f7, 0x5)) goto l_0x19_91f7; /* jbe 0x91f7 */
        l_0x19_91f2:
            ii(0x19_91f2, 5); mov(memw[ss, bp - 0x1a], 0x200);          /* mov word [bp-0x1a], 0x200 */
        l_0x19_91f7:
            ii(0x19_91f7, 3); push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x19_91fa, 3); push(memw[ss, bp + 0x18]);                /* push word [bp+0x18] */
            ii(0x19_91fd, 3); push(memw[ss, bp + 0x16]);                /* push word [bp+0x16] */
            ii(0x19_9200, 3); mov(ax, memw[ds, 0x2b9a]);                /* mov ax, [0x2b9a] */
            ii(0x19_9203, 4); mov(dx, memw[ds, 0x2b9c]);                /* mov dx, [0x2b9c] */
            ii(0x19_9207, 3); add(ax, 0x44);                            /* add ax, 0x44 */
            ii(0x19_920a, 1); push(dx);                                 /* push dx */
            ii(0x19_920b, 1); push(ax);                                 /* push ax */
            ii(0x19_920c, 1); nop();                                    /* nop */
            ii(0x19_920d, 1); push(cs);                                 /* push cs */
            ii(0x19_920e, 3); call(0x1a_0f5f, 0x7d4e);                  /* call 0xf5f */
            ii(0x19_9211, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_9214, 4); les(bx, memw[ds, 0x2b9a]);                /* les bx, [0x2b9a] */
            ii(0x19_9218, 4); mov(ax, memw[es, bx + 0x34]);             /* mov ax, [es:bx+0x34] */
            ii(0x19_921c, 4); sub(ax, memw[es, bx + 0x38]);             /* sub ax, [es:bx+0x38] */
            ii(0x19_9220, 2); add(bx, ax);                              /* add bx, ax */
            ii(0x19_9222, 4); add(bx, 0x2a2);                           /* add bx, 0x2a2 */
            ii(0x19_9226, 3); mov(memw[ss, bp - 0x5c], bx);             /* mov [bp-0x5c], bx */
            ii(0x19_9229, 3); mov(memw[ss, bp - 0x5a], es);             /* mov [bp-0x5a], es */
            ii(0x19_922c, 3); push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x19_922f, 3); push(memw[ss, bp + 0x18]);                /* push word [bp+0x18] */
            ii(0x19_9232, 3); push(memw[ss, bp + 0x16]);                /* push word [bp+0x16] */
            ii(0x19_9235, 1); push(es);                                 /* push es */
            ii(0x19_9236, 1); push(bx);                                 /* push bx */
            ii(0x19_9237, 1); nop();                                    /* nop */
            ii(0x19_9238, 1); push(cs);                                 /* push cs */
            ii(0x19_9239, 3); call(0x1a_0f5f, 0x7d23);                  /* call 0xf5f */
            ii(0x19_923c, 3); add(sp, 0xa);                             /* add sp, 0xa */
        l_0x19_923f:
            ii(0x19_923f, 5); cmp(memb[ds, 0x19f4], 0x1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_9244, 2); if(jz(0x19_925c, 0x16)) goto l_0x19_925c; /* jz 0x925c */
            ii(0x19_9246, 4); cmp(memw[ss, bp + 0x8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x19_924a, 2); if(jz(0x19_925c, 0x10)) goto l_0x19_925c; /* jz 0x925c */
            ii(0x19_924c, 3); push(memw[ss, bp - 0x78]);                /* push word [bp-0x78] */
            ii(0x19_924f, 3); call(0x19_febc, 0x6c6a);                  /* call 0xfebc */
            ii(0x19_9252, 3); les(bx, memw[ss, bp - 0x7c]);             /* les bx, [bp-0x7c] */
            ii(0x19_9255, 7); mov(memw[es, bx + 0xb4], 0xffff);         /* mov word [es:bx+0xb4], 0xffff */
        l_0x19_925c:
            ii(0x19_925c, 3); mov(ax, memw[ss, bp - 0x64]);             /* mov ax, [bp-0x64] */
            ii(0x19_925f, 3); mov(dx, memw[ss, bp - 0x62]);             /* mov dx, [bp-0x62] */
            ii(0x19_9262, 3); mov(memw[ss, bp - 0x2a], ax);             /* mov [bp-0x2a], ax */
            ii(0x19_9265, 3); mov(memw[ss, bp - 0x28], dx);             /* mov [bp-0x28], dx */
            ii(0x19_9268, 3); call(0x19_8bea, -0x681);                  /* call 0x8bea */
            ii(0x19_926b, 2); push(0x3e);                               /* push 0x3e */
            ii(0x19_926d, 3); lea(ax, memw[ss, bp - 0x58]);             /* lea ax, [bp-0x58] */
            ii(0x19_9270, 1); push(ss);                                 /* push ss */
            ii(0x19_9271, 1); push(ax);                                 /* push ax */
            ii(0x19_9272, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_9275, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_9278, 1); nop();                                    /* nop */
            ii(0x19_9279, 1); push(cs);                                 /* push cs */
            ii(0x19_927a, 3); call(0x1a_0f5f, 0x7ce2);                  /* call 0xf5f */
            ii(0x19_927d, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_9280, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_9283, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_9286, 3); call(0x19_8c04, -0x685);                  /* call 0x8c04 */
            ii(0x19_9289, 3); push(memw[ss, bp - 0x7a]);                /* push word [bp-0x7a] */
            ii(0x19_928c, 3); push(memw[ss, bp - 0x7c]);                /* push word [bp-0x7c] */
            ii(0x19_928f, 3); call(0x19_d518, 0x4286);                  /* call 0xd518 */
            ii(0x19_9292, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9294, 2); if(jz(0x19_929a, 0x4)) goto l_0x19_929a;  /* jz 0x929a */
            ii(0x19_9296, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9298, 2); jmp(0x19_92a4, 0xa); goto l_0x19_92a4;    /* jmp 0x92a4 */
        l_0x19_929a:
            ii(0x19_929a, 5); cmp(memw[ss, bp - 0x86], 0x1);            /* cmp word [bp-0x86], 0x1 */
            ii(0x19_929f, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_92a1, 3); and(ax, 0x525);                           /* and ax, 0x525 */
        l_0x19_92a4:
            ii(0x19_92a4, 1); pop(ds);                                  /* pop ds */
            ii(0x19_92a5, 1); pop(si);                                  /* pop si */
            ii(0x19_92a6, 1); leave();                                  /* leave */
            ii(0x19_92a7, 1); retf();                                   /* retf */
        }
    }
}

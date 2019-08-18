using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0e81-cb6f9a8")]
        public void Method_001a_0e81()
        {
            ii(0x1a_0e81, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x1a_0e85, 1); pushw(ds);                                /* push ds */
            ii(0x1a_0e86, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0e89, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_0e8b, 2); jmpw(0x1a_0edc, 0x4f); goto l_0x1a_0edc;  /* jmp 0xedc */
        l_0x1a_0e8d:
            ii(0x1a_0e8d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_0e90, 3); lea(ax, bp - 0x4);                        /* lea ax, [bp-0x4] */
            ii(0x1a_0e93, 1); pushw(ss);                                /* push ss */
            ii(0x1a_0e94, 1); pushw(ax);                                /* push ax */
            ii(0x1a_0e95, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x1a_0e97, 3); callw(0x19_fef1, -0xfa9);                 /* call 0xfef1 */
            ii(0x1a_0e9a, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x1a_0e9d, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x1a_0ea0, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x1a_0ea4, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x1a_0ea7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0eaa, 3); callw(0x19_fef1, -0xfbc);                 /* call 0xfef1 */
            ii(0x1a_0ead, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x1a_0eb0, 3); add(ax, 0x4);                             /* add ax, 0x4 */
            ii(0x1a_0eb3, 3); sub(memw_a16[ss, bp + 0xa], ax);          /* sub [bp+0xa], ax */
            ii(0x1a_0eb6, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x1a_0eb9, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x1a_0ebc, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x1a_0ebf, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x1a_0ec2, 4); pushw(memw_a16[es, bx + 0x2]);            /* push word [es:bx+0x2] */
            ii(0x1a_0ec6, 3); pushw(memw_a16[es, bx]);                  /* push word [es:bx] */
            ii(0x1a_0ec9, 1); pushw(cs);                                /* push cs */
            ii(0x1a_0eca, 3); callw(0x1a_0e42, -0x8b);                  /* call 0xe42 */
            ii(0x1a_0ecd, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x1a_0ed0, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x1a_0ed3, 3); mul(memw_a16[ss, bp - 0x4]);              /* mul word [bp-0x4] */
            ii(0x1a_0ed6, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x1a_0ed9, 3); add(memw_a16[es, bx], ax);                /* add [es:bx], ax */
        l_0x1a_0edc:
            ii(0x1a_0edc, 4); cmp(memw_a16[ss, bp + 0xa], 0);           /* cmp word [bp+0xa], 0x0 */
            ii(0x1a_0ee0, 2); if(jnzw(0x1a_0e8d, -0x55)) goto l_0x1a_0e8d; /* jnz 0xe8d */
            ii(0x1a_0ee2, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_0ee3, 1); leavew();                                 /* leave */
            ii(0x1a_0ee4, 3); retfw(0x8); return;                       /* retf 0x8 */
        //  ii(0x1a_0ee7, 120); Недостижимый (и не декодированный) код.
        //    ii(0x1a_0f5f, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
        //    ii(0x1a_0f63, 1); pushw(es);                                /* push es */
        //    ii(0x1a_0f64, 1); pushw(ds);                                /* push ds */
        //    ii(0x1a_0f65, 1); pushw(si);                                /* push si */
        //    ii(0x1a_0f66, 1); pushw(di);                                /* push di */
        //    ii(0x1a_0f67, 1); pushw(cx);                                /* push cx */
        //    ii(0x1a_0f68, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
        //    ii(0x1a_0f6b, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
        //    ii(0x1a_0f6e, 2); mov(ax, di);                              /* mov ax, di */
        //    ii(0x1a_0f70, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
        //    ii(0x1a_0f73, 2); if(jcxzw(0x1a_0fa6, 0x31)) goto l_0x1a_0fa6; /* jcxz 0xfa6 */
        //    ii(0x1a_0f75, 2); mov(ax, es);                              /* mov ax, es */
        //    ii(0x1a_0f77, 3); cmp(ax, memw_a16[ss, bp + 0xc]);          /* cmp ax, [bp+0xc] */
        //    ii(0x1a_0f7a, 2); if(jnzw(0x1a_0f96, 0x1a)) goto l_0x1a_0f96; /* jnz 0xf96 */
        //    ii(0x1a_0f7c, 2); cmp(di, si);                              /* cmp di, si */
        //    ii(0x1a_0f7e, 2); if(jbew(0x1a_0f96, 0x16)) goto l_0x1a_0f96; /* jbe 0xf96 */
        //    ii(0x1a_0f80, 2); mov(ax, si);                              /* mov ax, si */
        //    ii(0x1a_0f82, 2); add(ax, cx);                              /* add ax, cx */
        //    ii(0x1a_0f84, 2); cmp(di, ax);                              /* cmp di, ax */
        //    ii(0x1a_0f86, 2); if(jaew(0x1a_0f96, 0xe)) goto l_0x1a_0f96; /* jae 0xf96 */
        //    ii(0x1a_0f88, 2); mov(ax, di);                              /* mov ax, di */
        //    ii(0x1a_0f8a, 2); add(si, cx);                              /* add si, cx */
        //    ii(0x1a_0f8c, 2); add(di, cx);                              /* add di, cx */
        //    ii(0x1a_0f8e, 1); dec(si);                                  /* dec si */
        //    ii(0x1a_0f8f, 1); dec(di);                                  /* dec di */
        //    ii(0x1a_0f90, 1); std();                                    /* std */
        //    ii(0x1a_0f91, 2); rep_a16(() => movsb_a16());               /* rep movsb */
        //    ii(0x1a_0f93, 1); cld();                                    /* cld */
        //    ii(0x1a_0f94, 2); jmpw(0x1a_0fa6, 0x10); goto l_0x1a_0fa6;  /* jmp 0xfa6 */
        l_0x1a_0f96:
            ii(0x1a_0f96, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x1a_0f98, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x1a_0f9a, 2); if(jzw(0x1a_0f9e, 0x2)) goto l_0x1a_0f9e; /* jz 0xf9e */
            ii(0x1a_0f9c, 1); movsb_a16();                              /* movsb */
            ii(0x1a_0f9d, 1); dec(cx);                                  /* dec cx */
        l_0x1a_0f9e:
            ii(0x1a_0f9e, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x1a_0fa0, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x1a_0fa2, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x1a_0fa4, 2); rep_a16(() => movsb_a16());               /* rep movsb */
        l_0x1a_0fa6:
            ii(0x1a_0fa6, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x1a_0fa8, 1); popw(cx);                                 /* pop cx */
            ii(0x1a_0fa9, 1); popw(di);                                 /* pop di */
            ii(0x1a_0faa, 1); popw(si);                                 /* pop si */
            ii(0x1a_0fab, 1); popw(ds);                                 /* pop ds */
            ii(0x1a_0fac, 1); popw(es);                                 /* pop es */
            ii(0x1a_0fad, 1); leavew();                                 /* leave */
            ii(0x1a_0fae, 1); retfw(); return;                          /* retf */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f76860a-b031-462f-b03e-7d895b9eb609")]
        public void Method_0016_0f5f()
        {
            ii(0x16_0f5f, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x16_0f63, 1); pushw(es);                                /* push es */
            ii(0x16_0f64, 1); pushw(ds);                                /* push ds */
            ii(0x16_0f65, 1); pushw(si);                                /* push si */
            ii(0x16_0f66, 1); pushw(di);                                /* push di */
            ii(0x16_0f67, 1); pushw(cx);                                /* push cx */
            ii(0x16_0f68, 3); lds(si, ss, bp + 0xa);                    /* lds si, [bp+0xa] */
            ii(0x16_0f6b, 3); les(di, ss, bp + 0x6);                    /* les di, [bp+0x6] */
            ii(0x16_0f6e, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x16_0f70, 3); mov(cx, memw_a16[ss, bp + 0xe]);          /* mov cx, [bp+0xe] */
            ii(0x16_0f73, 2); if(jcxzw(0x16_0fa6, 0x31)) goto l_0x16_0fa6; /* jcxz 0xfa6 */
            ii(0x16_0f75, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x16_0f77, 3); cmp(ax, memw_a16[ss, bp + 0xc]);          /* cmp ax, [bp+0xc] */
            ii(0x16_0f7a, 2); if(jnzw(0x16_0f96, 0x1a)) goto l_0x16_0f96; /* jnz 0xf96 */
            ii(0x16_0f7c, 2); cmp(di, si);                              /* cmp di, si */
            ii(0x16_0f7e, 2); if(jbew(0x16_0f96, 0x16)) goto l_0x16_0f96; /* jbe 0xf96 */
            ii(0x16_0f80, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x16_0f82, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x16_0f84, 2); cmp(di, ax);                              /* cmp di, ax */
            ii(0x16_0f86, 2); if(jaew(0x16_0f96, 0xe)) goto l_0x16_0f96; /* jae 0xf96 */
            ii(0x16_0f88, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x16_0f8a, 2); add(si, cx);                              /* add si, cx */
            ii(0x16_0f8c, 2); add(di, cx);                              /* add di, cx */
            ii(0x16_0f8e, 1); dec(si);                                  /* dec si */
            ii(0x16_0f8f, 1); dec(di);                                  /* dec di */
            ii(0x16_0f90, 1); std();                                    /* std */
            ii(0x16_0f91, 2); rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x16_0f93, 1); cld();                                    /* cld */
            ii(0x16_0f94, 2); jmpw(0x16_0fa6, 0x10); goto l_0x16_0fa6;  /* jmp 0xfa6 */
        l_0x16_0f96:
            ii(0x16_0f96, 2); mov(ax, di);                              /* mov ax, di */
            ii(0x16_0f98, 2); test(al, 0x1);                            /* test al, 0x1 */
            ii(0x16_0f9a, 2); if(jzw(0x16_0f9e, 0x2)) goto l_0x16_0f9e; /* jz 0xf9e */
            ii(0x16_0f9c, 1); movsb_a16();                              /* movsb */
            ii(0x16_0f9d, 1); dec(cx);                                  /* dec cx */
        l_0x16_0f9e:
            ii(0x16_0f9e, 2); shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x16_0fa0, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x16_0fa2, 2); adc(cx, cx);                              /* adc cx, cx */
            ii(0x16_0fa4, 2); rep_a16(() => movsb_a16());               /* rep movsb */
        l_0x16_0fa6:
            ii(0x16_0fa6, 2); mov(dx, es);                              /* mov dx, es */
            ii(0x16_0fa8, 1); popw(cx);                                 /* pop cx */
            ii(0x16_0fa9, 1); popw(di);                                 /* pop di */
            ii(0x16_0faa, 1); popw(si);                                 /* pop si */
            ii(0x16_0fab, 1); popw(ds);                                 /* pop ds */
            ii(0x16_0fac, 1); popw(es);                                 /* pop es */
            ii(0x16_0fad, 1); leavew();                                 /* leave */
            ii(0x16_0fae, 1); retfw(); return;                          /* retf */
        }
    }
}

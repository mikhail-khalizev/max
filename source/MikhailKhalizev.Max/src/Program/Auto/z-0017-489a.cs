using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_489a-eb98bc0f")]
        public void Method_0017_489a()
        {
            ii(0x17_489a, 4); enter(0x10, 0);                           /* enter 0x10, 0x0 */
            ii(0x17_489e, 1); push(di);                                 /* push di */
            ii(0x17_489f, 1); push(si);                                 /* push si */
            ii(0x17_48a0, 1); push(ds);                                 /* push ds */
            ii(0x17_48a1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_48a4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_48a6, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x17_48a9, 1); push(cs);                                 /* push cs */
            ii(0x17_48aa, 3); call(0x17_4984, 0xd7);                    /* call 0x4984 */
            ii(0x17_48ad, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x17_48b0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_48b2, 2); if(jnz(0x17_48b7, 3)) goto l_0x17_48b7;   /* jnz 0x48b7 */
            ii(0x17_48b4, 3); mov(memw[ss, bp + 8], ax);                /* mov [bp+0x8], ax */
        l_0x17_48b7:
            ii(0x17_48b7, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x17_48ba, 3); mov(dx, 8);                               /* mov dx, 0x8 */
            ii(0x17_48bd, 1); push(ds);                                 /* push ds */
            ii(0x17_48be, 3); lea(di, memw[ss, bp - 0x10]);             /* lea di, [bp-0x10] */
            ii(0x17_48c1, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x17_48c3, 1); push(ss);                                 /* push ss */
            ii(0x17_48c4, 1); pop(es);                                  /* pop es */
            ii(0x17_48c5, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x17_48c7, 1); movsw();                                  /* movsw */
            ii(0x17_48c8, 1); movsw();                                  /* movsw */
            ii(0x17_48c9, 1); movsw();                                  /* movsw */
            ii(0x17_48ca, 1); movsw();                                  /* movsw */
            ii(0x17_48cb, 1); pop(ds);                                  /* pop ds */
            ii(0x17_48cc, 3); mov(al, memb[ss, bp - 9]);                /* mov al, [bp-0x9] */
            ii(0x17_48cf, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_48d1, 3); shl(ax, 8);                               /* shl ax, 0x8 */
            ii(0x17_48d4, 3); mov(cl, memb[ss, bp - 0xc]);              /* mov cl, [bp-0xc] */
            ii(0x17_48d7, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x17_48d9, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x17_48db, 3); mov(cx, memw[ss, bp - 0xe]);              /* mov cx, [bp-0xe] */
            ii(0x17_48de, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x17_48e0, 3); add(cx, memw[ss, bp + 6]);                /* add cx, [bp+0x6] */
            ii(0x17_48e3, 3); adc(dx, memw[ss, bp + 8]);                /* adc dx, [bp+0x8] */
            ii(0x17_48e6, 3); mov(memw[ss, bp - 4], cx);                /* mov [bp-0x4], cx */
            ii(0x17_48e9, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x17_48ec, 3); mov(memw[ss, bp - 0xe], cx);              /* mov [bp-0xe], cx */
            ii(0x17_48ef, 3); mov(al, memb[ss, bp - 2]);                /* mov al, [bp-0x2] */
            ii(0x17_48f2, 3); mov(memb[ss, bp - 0xc], al);              /* mov [bp-0xc], al */
            ii(0x17_48f5, 3); mov(al, memb[ss, bp - 1]);                /* mov al, [bp-0x1] */
            ii(0x17_48f8, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x17_48fa, 3); mov(memb[ss, bp - 9], al);                /* mov [bp-0x9], al */
            ii(0x17_48fd, 3); mov(al, memb[ss, bp - 0xa]);              /* mov al, [bp-0xa] */
            ii(0x17_4900, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x17_4903, 3); mov(cx, memw[ss, bp - 0x10]);             /* mov cx, [bp-0x10] */
            ii(0x17_4906, 3); mov(memw[ss, bp - 8], cx);                /* mov [bp-0x8], cx */
            ii(0x17_4909, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x17_490c, 4); test(memb[ss, bp - 0xa], 0x80);           /* test byte [bp-0xa], 0x80 */
            ii(0x17_4910, 2); if(jz(0x17_494c, 0x3a)) goto l_0x17_494c; /* jz 0x494c */
            ii(0x17_4912, 4); and(memb[ss, bp - 0xa], 0x7f);            /* and byte [bp-0xa], 0x7f */
            ii(0x17_4916, 2); push(0xc);                                /* push 0xc */
            ii(0x17_4918, 3); lea(ax, memw[ss, bp - 8]);                /* lea ax, [bp-0x8] */
            ii(0x17_491b, 1); push(ss);                                 /* push ss */
            ii(0x17_491c, 1); push(ax);                                 /* push ax */
            ii(0x17_491d, 1); nop();                                    /* nop */
            ii(0x17_491e, 1); push(cs);                                 /* push cs */
            ii(0x17_491f, 3); call(0x16_dd9c, -0x6b86);                 /* call 0xdd9c */
            ii(0x17_4922, 5); or(memw[ss, bp - 8], 0xfff);              /* or word [bp-0x8], 0xfff */
            ii(0x17_4927, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_492a, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_492d, 3); sub(memw[ss, bp - 8], ax);                /* sub [bp-0x8], ax */
            ii(0x17_4930, 3); sbb(memw[ss, bp - 6], dx);                /* sbb [bp-0x6], dx */
            ii(0x17_4933, 4); cmp(memw[ss, bp - 6], 0);                 /* cmp word [bp-0x6], 0x0 */
            ii(0x17_4937, 2); if(jnz(0x17_493f, 6)) goto l_0x17_493f;   /* jnz 0x493f */
            ii(0x17_4939, 4); cmp(memw[ss, bp - 8], -1 /* 0xff */);     /* cmp word [bp-0x8], 0xffff */
            ii(0x17_493d, 2); if(jbe(0x17_4949, 0xa)) goto l_0x17_4949; /* jbe 0x4949 */
        l_0x17_493f:
            ii(0x17_493f, 5); mov(memw[ss, bp - 8], 0xffff);            /* mov word [bp-0x8], 0xffff */
            ii(0x17_4944, 5); mov(memw[ss, bp - 6], 0);                 /* mov word [bp-0x6], 0x0 */
        l_0x17_4949:
            ii(0x17_4949, 2); jmp(0x17_4958, 0xd); goto l_0x17_4958;    /* jmp 0x4958 */
        //  ii(0x17_494b, 1); nop();                                    /* nop */
        l_0x17_494c:
            ii(0x17_494c, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x17_494f, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x17_4952, 3); sub(memw[ss, bp - 8], ax);                /* sub [bp-0x8], ax */
            ii(0x17_4955, 3); sbb(memw[ss, bp - 6], dx);                /* sbb [bp-0x6], dx */
        l_0x17_4958:
            ii(0x17_4958, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x17_495b, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x17_495e, 4); mov(memb[ss, bp - 0xa], 0);               /* mov byte [bp-0xa], 0x0 */
            ii(0x17_4962, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x17_4965, 3); mov(dx, 8);                               /* mov dx, 0x8 */
            ii(0x17_4968, 1); push(ds);                                 /* push ds */
            ii(0x17_4969, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x17_496b, 3); lea(si, memw[ss, bp - 0x10]);             /* lea si, [bp-0x10] */
            ii(0x17_496e, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x17_4970, 1); push(ss);                                 /* push ss */
            ii(0x17_4971, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4972, 1); movsw();                                  /* movsw */
            ii(0x17_4973, 1); movsw();                                  /* movsw */
            ii(0x17_4974, 1); movsw();                                  /* movsw */
            ii(0x17_4975, 1); movsw();                                  /* movsw */
            ii(0x17_4976, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4977, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x17_497a, 1); pop(ds);                                  /* pop ds */
            ii(0x17_497b, 1); pop(si);                                  /* pop si */
            ii(0x17_497c, 1); pop(di);                                  /* pop di */
            ii(0x17_497d, 1); leave();                                  /* leave */
            ii(0x17_497e, 1); ret();                                    /* ret */
        }
    }
}

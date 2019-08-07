using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("88595301-bc13-4a4b-a87c-e831f887a64d")]
        public void Method_0013_489a()
        {
            ii(0x13_489a, 4); enterw(0x10, 0);                          /* enter 0x10, 0x0 */
            ii(0x13_489e, 1); pushw(di);                                /* push di */
            ii(0x13_489f, 1); pushw(si);                                /* push si */
            ii(0x13_48a0, 1); pushw(ds);                                /* push ds */
            ii(0x13_48a1, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_48a4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_48a6, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x13_48a9, 1); pushw(cs);                                /* push cs */
            ii(0x13_48aa, 3); callw(0x13_4984, 0xd7);                   /* call 0x4984 */
            ii(0x13_48ad, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_48b0, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_48b2, 2); if(jnzw(0x13_48b7, 0x3)) goto l_0x13_48b7; /* jnz 0x48b7 */
            ii(0x13_48b4, 3); mov(memw_a16[ss, bp + 0x8], ax);          /* mov [bp+0x8], ax */
        l_0x13_48b7:
            ii(0x13_48b7, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x13_48ba, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x13_48bd, 1); pushw(ds);                                /* push ds */
            ii(0x13_48be, 3); lea(di, bp - 0x10);                       /* lea di, [bp-0x10] */
            ii(0x13_48c1, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x13_48c3, 1); pushw(ss);                                /* push ss */
            ii(0x13_48c4, 1); popw(es);                                 /* pop es */
            ii(0x13_48c5, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x13_48c7, 1); movsw_a16();                              /* movsw */
            ii(0x13_48c8, 1); movsw_a16();                              /* movsw */
            ii(0x13_48c9, 1); movsw_a16();                              /* movsw */
            ii(0x13_48ca, 1); movsw_a16();                              /* movsw */
            ii(0x13_48cb, 1); popw(ds);                                 /* pop ds */
            ii(0x13_48cc, 3); mov(al, memb_a16[ss, bp - 0x9]);          /* mov al, [bp-0x9] */
            ii(0x13_48cf, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_48d1, 3); shl(ax, 0x8);                             /* shl ax, 0x8 */
            ii(0x13_48d4, 3); mov(cl, memb_a16[ss, bp - 0xc]);          /* mov cl, [bp-0xc] */
            ii(0x13_48d7, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x13_48d9, 2); add(ax, cx);                              /* add ax, cx */
            ii(0x13_48db, 3); mov(cx, memw_a16[ss, bp - 0xe]);          /* mov cx, [bp-0xe] */
            ii(0x13_48de, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_48e0, 3); add(cx, memw_a16[ss, bp + 0x6]);          /* add cx, [bp+0x6] */
            ii(0x13_48e3, 3); adc(dx, memw_a16[ss, bp + 0x8]);          /* adc dx, [bp+0x8] */
            ii(0x13_48e6, 3); mov(memw_a16[ss, bp - 0x4], cx);          /* mov [bp-0x4], cx */
            ii(0x13_48e9, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x13_48ec, 3); mov(memw_a16[ss, bp - 0xe], cx);          /* mov [bp-0xe], cx */
            ii(0x13_48ef, 3); mov(al, memb_a16[ss, bp - 0x2]);          /* mov al, [bp-0x2] */
            ii(0x13_48f2, 3); mov(memb_a16[ss, bp - 0xc], al);          /* mov [bp-0xc], al */
            ii(0x13_48f5, 3); mov(al, memb_a16[ss, bp - 0x1]);          /* mov al, [bp-0x1] */
            ii(0x13_48f8, 2); sub(ah, ah);                              /* sub ah, ah */
            ii(0x13_48fa, 3); mov(memb_a16[ss, bp - 0x9], al);          /* mov [bp-0x9], al */
            ii(0x13_48fd, 3); mov(al, memb_a16[ss, bp - 0xa]);          /* mov al, [bp-0xa] */
            ii(0x13_4900, 3); and(ax, 0xf);                             /* and ax, 0xf */
            ii(0x13_4903, 3); mov(cx, memw_a16[ss, bp - 0x10]);         /* mov cx, [bp-0x10] */
            ii(0x13_4906, 3); mov(memw_a16[ss, bp - 0x8], cx);          /* mov [bp-0x8], cx */
            ii(0x13_4909, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x13_490c, 4); test(memb_a16[ss, bp - 0xa], 0x80);       /* test byte [bp-0xa], 0x80 */
            ii(0x13_4910, 2); if(jzw(0x13_494c, 0x3a)) goto l_0x13_494c; /* jz 0x494c */
            ii(0x13_4912, 4); and(memb_a16[ss, bp - 0xa], 0x7f);        /* and byte [bp-0xa], 0x7f */
            ii(0x13_4916, 2); pushw(0xc);                               /* push 0xc */
            ii(0x13_4918, 3); lea(ax, bp - 0x8);                        /* lea ax, [bp-0x8] */
            ii(0x13_491b, 1); pushw(ss);                                /* push ss */
            ii(0x13_491c, 1); pushw(ax);                                /* push ax */
            ii(0x13_491d, 1); nop();                                    /* nop */
            ii(0x13_491e, 1); pushw(cs);                                /* push cs */
            ii(0x13_491f, 3); callw(0x12_dd9c, -0x6b86);                /* call 0xdd9c */
            ii(0x13_4922, 5); or(memw_a16[ss, bp - 0x8], 0xfff);        /* or word [bp-0x8], 0xfff */
            ii(0x13_4927, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_492a, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_492d, 3); sub(memw_a16[ss, bp - 0x8], ax);          /* sub [bp-0x8], ax */
            ii(0x13_4930, 3); sbb(memw_a16[ss, bp - 0x6], dx);          /* sbb [bp-0x6], dx */
            ii(0x13_4933, 4); cmp(memw_a16[ss, bp - 0x6], 0);           /* cmp word [bp-0x6], 0x0 */
            ii(0x13_4937, 2); if(jnzw(0x13_493f, 0x6)) goto l_0x13_493f; /* jnz 0x493f */
            ii(0x13_4939, 4); cmp(memw_a16[ss, bp - 0x8], -0x1 /* 0xff */); /* cmp word [bp-0x8], 0xffff */
            ii(0x13_493d, 2); if(jbew(0x13_4949, 0xa)) goto l_0x13_4949; /* jbe 0x4949 */
        l_0x13_493f:
            ii(0x13_493f, 5); mov(memw_a16[ss, bp - 0x8], 0xffff);      /* mov word [bp-0x8], 0xffff */
            ii(0x13_4944, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
        l_0x13_4949:
            ii(0x13_4949, 2); jmpw(0x13_4958, 0xd); goto l_0x13_4958;   /* jmp 0x4958 */
        //  ii(0x13_494b, 1); Недостижимый код.
l_0x13_494c:
            ii(0x13_494c, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x13_494f, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x13_4952, 3); sub(memw_a16[ss, bp - 0x8], ax);          /* sub [bp-0x8], ax */
            ii(0x13_4955, 3); sbb(memw_a16[ss, bp - 0x6], dx);          /* sbb [bp-0x6], dx */
        l_0x13_4958:
            ii(0x13_4958, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x13_495b, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x13_495e, 4); mov(memb_a16[ss, bp - 0xa], 0);           /* mov byte [bp-0xa], 0x0 */
            ii(0x13_4962, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_4965, 3); mov(dx, 0x8);                             /* mov dx, 0x8 */
            ii(0x13_4968, 1); pushw(ds);                                /* push ds */
            ii(0x13_4969, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x13_496b, 3); lea(si, bp - 0x10);                       /* lea si, [bp-0x10] */
            ii(0x13_496e, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x13_4970, 1); pushw(ss);                                /* push ss */
            ii(0x13_4971, 1); popw(ds);                                 /* pop ds */
            ii(0x13_4972, 1); movsw_a16();                              /* movsw */
            ii(0x13_4973, 1); movsw_a16();                              /* movsw */
            ii(0x13_4974, 1); movsw_a16();                              /* movsw */
            ii(0x13_4975, 1); movsw_a16();                              /* movsw */
            ii(0x13_4976, 1); popw(ds);                                 /* pop ds */
            ii(0x13_4977, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x13_497a, 1); popw(ds);                                 /* pop ds */
            ii(0x13_497b, 1); popw(si);                                 /* pop si */
            ii(0x13_497c, 1); popw(di);                                 /* pop di */
            ii(0x13_497d, 1); leavew();                                 /* leave */
            ii(0x13_497e, 1); retw(); return;                           /* ret */
        }
    }
}

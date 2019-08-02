using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b7ec9252-2e37-421e-a94f-5d3fc4d7fd76")]
        public void Method_0015_d0ec()
        {
            ii(0x15_d0ec, 4); enterw(0xe, 0);                           /* enter 0xe, 0x0 */
            ii(0x15_d0f0, 3); les(bx, ss, bp + 0x10);                   /* les bx, [bp+0x10] */
            ii(0x15_d0f3, 4); mov(ax, memw_a16[es, bx + 0x3c]);         /* mov ax, [es:bx+0x3c] */
            ii(0x15_d0f7, 4); mov(dx, memw_a16[es, bx + 0x3e]);         /* mov dx, [es:bx+0x3e] */
            ii(0x15_d0fb, 4); cmp(memw_a16[ss, bp + 0xe], 0);           /* cmp word [bp+0xe], 0x0 */
            ii(0x15_d0ff, 2); if(jnzw(0x15_d104, 0x3)) goto l_0x15_d104; /* jnz 0xd104 */
            ii(0x15_d101, 3); jmpw(0x15_d196, 0x92); goto l_0x15_d196;  /* jmp 0xd196 */
        l_0x15_d104:
            ii(0x15_d104, 4); imul(bx, memw_a16[ss, bp + 0xe], 0x18);   /* imul bx, [bp+0xe], 0x18 */
            ii(0x15_d108, 2); add(bx, ax);                              /* add bx, ax */
            ii(0x15_d10a, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_d10c, 3); sub(bx, 0x18);                            /* sub bx, 0x18 */
            ii(0x15_d10f, 3); mov(memw_a16[ss, bp - 0xa], bx);          /* mov [bp-0xa], bx */
            ii(0x15_d112, 3); mov(memw_a16[ss, bp - 0x8], es);          /* mov [bp-0x8], es */
            ii(0x15_d115, 4); mov(ax, memw_a16[es, bx + 0x8]);          /* mov ax, [es:bx+0x8] */
            ii(0x15_d119, 4); mov(dx, memw_a16[es, bx + 0xa]);          /* mov dx, [es:bx+0xa] */
            ii(0x15_d11d, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x15_d120, 4); mov(cx, memw_a16[es, bx + 0x14]);         /* mov cx, [es:bx+0x14] */
            ii(0x15_d124, 3); mov(memw_a16[ss, bp - 0x6], cx);          /* mov [bp-0x6], cx */
            ii(0x15_d127, 4); cmp(memb_a16[ss, bp + 0x4], 0);           /* cmp byte [bp+0x4], 0x0 */
            ii(0x15_d12b, 2); if(jzw(0x15_d154, 0x27)) goto l_0x15_d154; /* jz 0xd154 */
            ii(0x15_d12d, 3); test(ah, 0x10);                           /* test ah, 0x10 */
            ii(0x15_d130, 2); if(jzw(0x15_d140, 0xe)) goto l_0x15_d140; /* jz 0xd140 */
            ii(0x15_d132, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_d135, 3); mov(memw_a16[es, bx], cx);                /* mov [es:bx], cx */
            ii(0x15_d138, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_d13b, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
            ii(0x15_d13e, 2); jmpw(0x15_d19f, 0x5f); goto l_0x15_d19f;  /* jmp 0xd19f */
        l_0x15_d140:
            ii(0x15_d140, 1); pushw(ds);                                /* push ds */
            ii(0x15_d141, 3); pushw(0x293d);                            /* push 0x293d */
            ii(0x15_d144, 3); pushw(0xce6);                             /* push 0xce6 */
            ii(0x15_d147, 5); callw_far_abs(0x80, 0x220b);              /* call word 0x80:0x220b */
            ii(0x15_d14c, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_d14f, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_d152, 2); jmpw(0x15_d1a9, 0x55); goto l_0x15_d1a9;  /* jmp 0xd1a9 */
        l_0x15_d154:
            ii(0x15_d154, 4); test(memb_a16[ss, bp - 0xe], 0x4);        /* test byte [bp-0xe], 0x4 */
            ii(0x15_d158, 2); if(jzw(0x15_d15f, 0x5)) goto l_0x15_d15f; /* jz 0xd15f */
            ii(0x15_d15a, 3); mov(ax, memw_a16[ds, 0x19e4]);            /* mov ax, [0x19e4] */
            ii(0x15_d15d, 2); jmpw(0x15_d162, 0x3); goto l_0x15_d162;   /* jmp 0xd162 */
        l_0x15_d15f:
            ii(0x15_d15f, 3); mov(ax, memw_a16[ds, 0x19e6]);            /* mov ax, [0x19e6] */
        l_0x15_d162:
            ii(0x15_d162, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_d165, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x15_d168, 4); test(memb_a16[ss, bp - 0xd], 0x10);       /* test byte [bp-0xd], 0x10 */
            ii(0x15_d16c, 2); if(jnzw(0x15_d189, 0x1b)) goto l_0x15_d189; /* jnz 0xd189 */
            ii(0x15_d16e, 3); les(bx, ss, bp - 0xa);                    /* les bx, [bp-0xa] */
            ii(0x15_d171, 4); mov(ax, memw_a16[es, bx + 0x4]);          /* mov ax, [es:bx+0x4] */
            ii(0x15_d175, 4); mov(dx, memw_a16[es, bx + 0x6]);          /* mov dx, [es:bx+0x6] */
            ii(0x15_d179, 4); sub(ax, memw_a16[ds, 0x19ea]);            /* sub ax, [0x19ea] */
            ii(0x15_d17d, 4); sbb(dx, memw_a16[ds, 0x19ec]);            /* sbb dx, [0x19ec] */
            ii(0x15_d181, 3); add(ax, memw_a16[ss, bp + 0xa]);          /* add ax, [bp+0xa] */
            ii(0x15_d184, 3); adc(dx, memw_a16[ss, bp + 0xc]);          /* adc dx, [bp+0xc] */
            ii(0x15_d187, 2); jmpw(0x15_d19c, 0x13); goto l_0x15_d19c;  /* jmp 0xd19c */
        l_0x15_d189:
            ii(0x15_d189, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_d18c, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x15_d18f, 1); pushw(dx);                                /* push dx */
            ii(0x15_d190, 1); pushw(ax);                                /* push ax */
            ii(0x15_d191, 3); callw(0x15_d9f4, 0x860);                  /* call 0xd9f4 */
            ii(0x15_d194, 2); jmpw(0x15_d19c, 0x6); goto l_0x15_d19c;   /* jmp 0xd19c */
        l_0x15_d196:
            ii(0x15_d196, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_d199, 3); mov(dx, memw_a16[ss, bp + 0xc]);          /* mov dx, [bp+0xc] */
        l_0x15_d19c:
            ii(0x15_d19c, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
        l_0x15_d19f:
            ii(0x15_d19f, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_d1a3, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x15_d1a7, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_d1a9:
            ii(0x15_d1a9, 1); leavew();                                 /* leave */
            ii(0x15_d1aa, 3); retw(0x10); return;                       /* ret 0x10 */
        }
    }
}

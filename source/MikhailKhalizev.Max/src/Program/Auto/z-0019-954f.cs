using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_954f-5aa814a0")]
        public void Method_0019_954f()
        {
            ii(0x19_954f, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x19_9553, 1); pushw(si);                                /* push si */
            ii(0x19_9554, 1); pushw(ds);                                /* push ds */
            ii(0x19_9555, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_9558, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_955a, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_955d, 1); pushw(ss);                                /* push ss */
            ii(0x19_955e, 1); pushw(ax);                                /* push ax */
            ii(0x19_955f, 3); lea(cx, bp - 0x12);                       /* lea cx, [bp-0x12] */
            ii(0x19_9562, 1); pushw(ss);                                /* push ss */
            ii(0x19_9563, 1); pushw(cx);                                /* push cx */
            ii(0x19_9564, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_9567, 1); pushw(cs);                                /* push cs */
            ii(0x19_9568, 3); callw(0x19_9407, -0x164);                 /* call 0x9407 */
            ii(0x19_956b, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_956e, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x19_9571, 3); mov(memw_a16[ss, bp - 0xc], dx);          /* mov [bp-0xc], dx */
            ii(0x19_9574, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_9576, 2); if(jzw(0x19_9598, 0x20)) goto l_0x19_9598; /* jz 0x9598 */
            ii(0x19_9578, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x19_957b, 3); or(ax, memw_a16[ss, bp - 0x12]);          /* or ax, [bp-0x12] */
            ii(0x19_957e, 2); if(jzw(0x19_9598, 0x18)) goto l_0x19_9598; /* jz 0x9598 */
            ii(0x19_9580, 4); cmp(memw_a16[ss, bp - 0x14], 0);          /* cmp word [bp-0x14], 0x0 */
            ii(0x19_9584, 2); if(jzw(0x19_9598, 0x12)) goto l_0x19_9598; /* jz 0x9598 */
            ii(0x19_9586, 5); mov(memw_a16[ss, bp - 0xa], 0x1);         /* mov word [bp-0xa], 0x1 */
            ii(0x19_958b, 2); jmpw(0x19_9590, 0x3); goto l_0x19_9590;   /* jmp 0x9590 */
        l_0x19_958d:
            ii(0x19_958d, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x19_9590:
            ii(0x19_9590, 3); mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0x19_9593, 3); cmp(memw_a16[ss, bp - 0xa], ax);          /* cmp [bp-0xa], ax */
            ii(0x19_9596, 2); if(jbew(0x19_959a, 0x2)) goto l_0x19_959a; /* jbe 0x959a */
        l_0x19_9598:
            ii(0x19_9598, 2); jmpw(0x19_960d, 0x73); goto l_0x19_960d;  /* jmp 0x960d */
        l_0x19_959a:
            ii(0x19_959a, 4); imul(ax, memw_a16[ss, bp - 0xa], 0x18);   /* imul ax, [bp-0xa], 0x18 */
            ii(0x19_959e, 3); add(ax, memw_a16[ss, bp - 0x12]);         /* add ax, [bp-0x12] */
            ii(0x19_95a1, 3); mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0x19_95a4, 3); sub(ax, 0x18);                            /* sub ax, 0x18 */
            ii(0x19_95a7, 1); pushw(dx);                                /* push dx */
            ii(0x19_95a8, 1); pushw(ax);                                /* push ax */
            ii(0x19_95a9, 3); callw(0x19_cd74, 0x37c8);                 /* call 0xcd74 */
            ii(0x19_95ac, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_95af, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_95b2, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x19_95b5, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x19_95b8, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x19_95bb, 3); callw(0x19_a8a9, 0x12eb);                 /* call 0xa8a9 */
            ii(0x19_95be, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x19_95c1, 3); adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0x19_95c4, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x19_95c7, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x19_95ca, 3); cmp(dx, memw_a16[ss, bp - 0x6]);          /* cmp dx, [bp-0x6] */
            ii(0x19_95cd, 2); if(jbw(0x19_958d, -0x42)) goto l_0x19_958d; /* jb 0x958d */
            ii(0x19_95cf, 2); if(jaw(0x19_95d6, 0x5)) goto l_0x19_95d6; /* ja 0x95d6 */
            ii(0x19_95d1, 3); cmp(ax, memw_a16[ss, bp - 0x8]);          /* cmp ax, [bp-0x8] */
            ii(0x19_95d4, 2); if(jbew(0x19_958d, -0x49)) goto l_0x19_958d; /* jbe 0x958d */
        l_0x19_95d6:
            ii(0x19_95d6, 3); mov(cx, memw_a16[ss, bp - 0x8]);          /* mov cx, [bp-0x8] */
            ii(0x19_95d9, 3); mov(bx, memw_a16[ss, bp - 0x6]);          /* mov bx, [bp-0x6] */
            ii(0x19_95dc, 3); les(si, ss, bp + 0x6);                    /* les si, [bp+0x6] */
            ii(0x19_95df, 4); cmp(memw_a16[es, si + 0x2], bx);          /* cmp [es:si+0x2], bx */
            ii(0x19_95e3, 2); if(jbw(0x19_958d, -0x58)) goto l_0x19_958d; /* jb 0x958d */
            ii(0x19_95e5, 2); if(jaw(0x19_95ec, 0x5)) goto l_0x19_95ec; /* ja 0x95ec */
            ii(0x19_95e7, 3); cmp(memw_a16[es, si], cx);                /* cmp [es:si], cx */
            ii(0x19_95ea, 2); if(jbw(0x19_958d, -0x5f)) goto l_0x19_958d; /* jb 0x958d */
        l_0x19_95ec:
            ii(0x19_95ec, 4); cmp(dx, memw_a16[es, si + 0x2]);          /* cmp dx, [es:si+0x2] */
            ii(0x19_95f0, 2); if(jbw(0x19_958d, -0x65)) goto l_0x19_958d; /* jb 0x958d */
            ii(0x19_95f2, 2); if(jaw(0x19_95f9, 0x5)) goto l_0x19_95f9; /* ja 0x95f9 */
            ii(0x19_95f4, 3); cmp(ax, memw_a16[es, si]);                /* cmp ax, [es:si] */
            ii(0x19_95f7, 2); if(jbew(0x19_958d, -0x6c)) goto l_0x19_958d; /* jbe 0x958d */
        l_0x19_95f9:
            ii(0x19_95f9, 3); mov(ax, memw_a16[ss, bp - 0xa]);          /* mov ax, [bp-0xa] */
            ii(0x19_95fc, 4); mov(memw_a16[es, si + 0x4], ax);          /* mov [es:si+0x4], ax */
            ii(0x19_9600, 3); sub(memw_a16[es, si], cx);                /* sub [es:si], cx */
            ii(0x19_9603, 4); sbb(memw_a16[es, si + 0x2], bx);          /* sbb [es:si+0x2], bx */
            ii(0x19_9607, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_9609:
            ii(0x19_9609, 2); sub(dx, dx);                              /* sub dx, dx */
            ii(0x19_960b, 2); jmpw(0x19_9612, 0x5); goto l_0x19_9612;   /* jmp 0x9612 */
        l_0x19_960d:
            ii(0x19_960d, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_9610, 2); jmpw(0x19_9609, -0x9); goto l_0x19_9609;  /* jmp 0x9609 */
        l_0x19_9612:
            ii(0x19_9612, 1); popw(ds);                                 /* pop ds */
            ii(0x19_9613, 1); popw(si);                                 /* pop si */
            ii(0x19_9614, 1); leavew();                                 /* leave */
            ii(0x19_9615, 1); retfw(); return;                          /* retf */
        }
    }
}

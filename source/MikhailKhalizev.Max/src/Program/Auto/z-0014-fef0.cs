using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("30dc7600-9ff7-4b55-95d5-133c414859f7")]
        public void Method_0014_fef0()
        {
            ii(0x14_fef0, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x14_fef4, 1); pushw(di);                                /* push di */
            ii(0x14_fef5, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
            ii(0x14_fef8, 3); mov(ax, 0x202);                           /* mov ax, 0x202 */
            ii(0x14_fefb, 2); or(bh, bh);                               /* or bh, bh */
            ii(0x14_fefd, 4); if(jnzw(0x14_ff04, 0x3)) goto l_0x14_ff04; /* jnz 0xff04 */
            ii(0x14_ff01, 3); add(ax, 0x2);                             /* add ax, 0x2 */
        l_0x14_ff04:
            ii(0x14_ff04, 1); pushw(ax);                                /* push ax */
            ii(0x14_ff05, 2); @int(0x31);                               /* int 0x31 */
            ii(0x14_ff07, 4); if(jbw(0x14_ff7e, 0x73)) goto l_0x14_ff7e; /* jb 0xff7e */
            ii(0x14_ff0b, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x14_ff0d, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x14_ff10, 4); add(di, 0x142);                           /* add di, 0x142 */
            ii(0x14_ff14, 3); mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x14_ff17, 3); mov(memd_a16[ds, di], edx);               /* mov [di], edx */
            ii(0x14_ff1a, 4); mov(memb_a16[ds, di + 0x6], 0x8e);        /* mov byte [di+0x6], 0x8e */
            ii(0x14_ff1e, 4); cmp(memw_a16[ss, bp + 0x8], 0);           /* cmp word [bp+0x8], 0x0 */
            ii(0x14_ff22, 4); if(jnzw(0x14_ff37, 0x11)) goto l_0x14_ff37; /* jnz 0xff37 */
            ii(0x14_ff26, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x14_ff28, 3); mov(cx, 0xd);                             /* mov cx, 0xd */
            ii(0x14_ff2b, 1); pushw(ds);                                /* push ds */
            ii(0x14_ff2c, 1); popw(es);                                 /* pop es */
            ii(0x14_ff2d, 3); mov(di, 0x128);                           /* mov di, 0x128 */
            ii(0x14_ff30, 1); cld();                                    /* cld */
            ii(0x14_ff31, 2); repne_a16(() => scasw_a16());             /* repne scasw */
            ii(0x14_ff33, 4); if(jzw(0x14_ff7e, 0x47)) goto l_0x14_ff7e; /* jz 0xff7e */
        l_0x14_ff37:
            ii(0x14_ff37, 4); cmp(bx, 0xfd);                            /* cmp bx, 0xfd */
            ii(0x14_ff3b, 4); if(jzw(0x14_ff7e, 0x3f)) goto l_0x14_ff7e; /* jz 0xff7e */
            ii(0x14_ff3f, 4); cmp(bx, 0xfe);                            /* cmp bx, 0xfe */
            ii(0x14_ff43, 4); if(jzw(0x14_ff7e, 0x37)) goto l_0x14_ff7e; /* jz 0xff7e */
            ii(0x14_ff47, 2); or(bh, bh);                               /* or bh, bh */
            ii(0x14_ff49, 4); if(jnzw(0x14_ff63, 0x16)) goto l_0x14_ff63; /* jnz 0xff63 */
            ii(0x14_ff4d, 3); cmp(bl, 0x31);                            /* cmp bl, 0x31 */
            ii(0x14_ff50, 2); if(jnzw(0x14_ff59, 0x7)) goto l_0x14_ff59; /* jnz 0xff59 */
            ii(0x14_ff52, 5); cmp(memw_a16[ds, 0x3b72], 0);             /* cmp word [0x3b72], 0x0 */
            ii(0x14_ff57, 2); if(jnzw(0x14_ff7e, 0x25)) goto l_0x14_ff7e; /* jnz 0xff7e */
        l_0x14_ff59:
            ii(0x14_ff59, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x14_ff5c, 2); mul(bx);                                  /* mul bx */
            ii(0x14_ff5e, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x14_ff61, 2); jmpw(0x14_ff6d, 0xa); goto l_0x14_ff6d;   /* jmp 0xff6d */
        l_0x14_ff63:
            ii(0x14_ff63, 2); mov(bh, 0);                               /* mov bh, 0x0 */
            ii(0x14_ff65, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x14_ff68, 2); mul(bx);                                  /* mul bx */
            ii(0x14_ff6a, 3); add(ax, 0x400);                           /* add ax, 0x400 */
        l_0x14_ff6d:
            ii(0x14_ff6d, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x14_ff6f, 4); movzx(edx, ax);                           /* movzx edx, ax */
            ii(0x14_ff73, 1); popw(ax);                                 /* pop ax */
            ii(0x14_ff74, 1); inc(ax);                                  /* inc ax */
            ii(0x14_ff75, 2); @int(0x31);                               /* int 0x31 */
            ii(0x14_ff77, 4); if(jaew(0x14_ff7d, 0x2)) goto l_0x14_ff7d; /* jae 0xff7d */
            ii(0x14_ff7b, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x14_ff7d:
            ii(0x14_ff7d, 1); pushw(ax);                                /* push ax */
        l_0x14_ff7e:
            ii(0x14_ff7e, 1); popw(ax);                                 /* pop ax */
            ii(0x14_ff7f, 1); popw(di);                                 /* pop di */
            ii(0x14_ff80, 1); popw(bp);                                 /* pop bp */
            ii(0x14_ff81, 1); retfw(); return;                          /* retf */
        }
    }
}

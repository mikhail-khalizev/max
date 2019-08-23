using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_fef0-613491d9")]
        public void Method_0018_fef0()
        {
            ii(0x18_fef0, 4); enter(0, 0);                              /* enter 0x0, 0x0 */
            ii(0x18_fef4, 1); push(di);                                 /* push di */
            ii(0x18_fef5, 3); mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x18_fef8, 3); mov(ax, 0x202);                           /* mov ax, 0x202 */
            ii(0x18_fefb, 2); or(bh, bh);                               /* or bh, bh */
            ii(0x18_fefd, 4); if(jnz(0x18_ff04, 0x3)) goto l_0x18_ff04; /* jnz 0xff04 */
            ii(0x18_ff01, 3); add(ax, 0x2);                             /* add ax, 0x2 */
        l_0x18_ff04:
            ii(0x18_ff04, 1); push(ax);                                 /* push ax */
            ii(0x18_ff05, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_ff07, 4); if(jb(0x18_ff7e, 0x73)) goto l_0x18_ff7e; /* jb 0xff7e */
            ii(0x18_ff0b, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x18_ff0d, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x18_ff10, 4); add(di, 0x142);                           /* add di, 0x142 */
            ii(0x18_ff14, 3); mov(memw[ds, di + 0x4], cx);              /* mov [di+0x4], cx */
            ii(0x18_ff17, 3); mov(memd[ds, di], edx);                   /* mov [di], edx */
            ii(0x18_ff1a, 4); mov(memb[ds, di + 0x6], 0x8e);            /* mov byte [di+0x6], 0x8e */
            ii(0x18_ff1e, 4); cmp(memw[ss, bp + 0x8], 0);               /* cmp word [bp+0x8], 0x0 */
            ii(0x18_ff22, 4); if(jnz(0x18_ff37, 0x11)) goto l_0x18_ff37; /* jnz 0xff37 */
            ii(0x18_ff26, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x18_ff28, 3); mov(cx, 0xd);                             /* mov cx, 0xd */
            ii(0x18_ff2b, 1); push(ds);                                 /* push ds */
            ii(0x18_ff2c, 1); pop(es);                                  /* pop es */
            ii(0x18_ff2d, 3); mov(di, 0x128);                           /* mov di, 0x128 */
            ii(0x18_ff30, 1); cld();                                    /* cld */
            ii(0x18_ff31, 2); repne(() => scasw());                     /* repne scasw */
            ii(0x18_ff33, 4); if(jz(0x18_ff7e, 0x47)) goto l_0x18_ff7e; /* jz 0xff7e */
        l_0x18_ff37:
            ii(0x18_ff37, 4); cmp(bx, 0xfd);                            /* cmp bx, 0xfd */
            ii(0x18_ff3b, 4); if(jz(0x18_ff7e, 0x3f)) goto l_0x18_ff7e; /* jz 0xff7e */
            ii(0x18_ff3f, 4); cmp(bx, 0xfe);                            /* cmp bx, 0xfe */
            ii(0x18_ff43, 4); if(jz(0x18_ff7e, 0x37)) goto l_0x18_ff7e; /* jz 0xff7e */
            ii(0x18_ff47, 2); or(bh, bh);                               /* or bh, bh */
            ii(0x18_ff49, 4); if(jnz(0x18_ff63, 0x16)) goto l_0x18_ff63; /* jnz 0xff63 */
            ii(0x18_ff4d, 3); cmp(bl, 0x31);                            /* cmp bl, 0x31 */
            ii(0x18_ff50, 2); if(jnz(0x18_ff59, 0x7)) goto l_0x18_ff59; /* jnz 0xff59 */
            ii(0x18_ff52, 5); cmp(memw[ds, 0x3b72], 0);                 /* cmp word [0x3b72], 0x0 */
            ii(0x18_ff57, 2); if(jnz(0x18_ff7e, 0x25)) goto l_0x18_ff7e; /* jnz 0xff7e */
        l_0x18_ff59:
            ii(0x18_ff59, 3); mov(ax, 0x4);                             /* mov ax, 0x4 */
            ii(0x18_ff5c, 2); mul(bx);                                  /* mul bx */
            ii(0x18_ff5e, 3); add(ax, 0);                               /* add ax, 0x0 */
            ii(0x18_ff61, 2); jmp(0x18_ff6d, 0xa); goto l_0x18_ff6d;    /* jmp 0xff6d */
        l_0x18_ff63:
            ii(0x18_ff63, 2); mov(bh, 0);                               /* mov bh, 0x0 */
            ii(0x18_ff65, 3); mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x18_ff68, 2); mul(bx);                                  /* mul bx */
            ii(0x18_ff6a, 3); add(ax, 0x400);                           /* add ax, 0x400 */
        l_0x18_ff6d:
            ii(0x18_ff6d, 2); mov(cx, cs);                              /* mov cx, cs */
            ii(0x18_ff6f, 4); movzx(edx, ax);                           /* movzx edx, ax */
            ii(0x18_ff73, 1); pop(ax);                                  /* pop ax */
            ii(0x18_ff74, 1); inc(ax);                                  /* inc ax */
            ii(0x18_ff75, 2); @int(0x31);                               /* int 0x31 */
            ii(0x18_ff77, 4); if(jae(0x18_ff7d, 0x2)) goto l_0x18_ff7d; /* jae 0xff7d */
            ii(0x18_ff7b, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x18_ff7d:
            ii(0x18_ff7d, 1); push(ax);                                 /* push ax */
        l_0x18_ff7e:
            ii(0x18_ff7e, 1); pop(ax);                                  /* pop ax */
            ii(0x18_ff7f, 1); pop(di);                                  /* pop di */
            ii(0x18_ff80, 1); pop(bp);                                  /* pop bp */
            ii(0x18_ff81, 1); retf();                                   /* retf */
        }
    }
}

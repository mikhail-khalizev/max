using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8c0bf989-1749-4017-b4bd-0953fa3b89e0")]
        public void Method_0000_4218()
        {
            ii(0x4218, 1);    pushw(cx);                                /* push cx */
            ii(0x4219, 2);    xor(cx, cx);                              /* xor cx, cx */
        l_0x421b:
            ii(0x421b, 2);    inb(al, 0x64);                            /* in al, 0x64 */
            ii(0x421d, 2);    test(al, 0x2);                            /* test al, 0x2 */
            ii(0x421f, 2);    if(jnzw(0x4223, 0x2)) goto l_0x4223;      /* jnz 0x4223 */
        l_0x4221:
            ii(0x4221, 1);    popw(cx);                                 /* pop cx */
            ii(0x4222, 1);    retw(); return;                           /* ret */
        l_0x4223:
            ii(0x4223, 2);    if(loopnew_a16(0x421b, -0xa)) goto l_0x421b; /* loopne 0x421b */
            ii(0x4225, 2);    if(jzw(0x4221, -0x6)) goto l_0x4221;      /* jz 0x4221 */
            ii(0x4227, 2);    pushw(0x1a);                              /* push 0x1a */
            ii(0x4229, 3);    callw(0x589d, 0x1671);                    /* call 0x589d */
            ii(0x422c, 3);    callw(0x428b, 0x5c);                      /* call 0x428b */
            ii(0x422f, 2);    add(al, ch);                              /* add al, ch */
            ii(0x4231, 1);    popw(ax);                                 /* pop ax */
            ii(0x4232, 2);    add(memb_a16[ds, bx + di], al);           /* add [bx+di], al */
            ii(0x4234, 3);    callw(0x428b, 0x54);                      /* call 0x428b */
            ii(0x4237, 2);    add(ch, al);                              /* add ch, al */
            ii(0x4239, 1);    pushw(ax);                                /* push ax */
            ii(0x423a, 2);    add(memb_a16[ss, bp + di], al);           /* add [bp+di], al */
            ii(0x423c, 3);    callw(0x428b, 0x4c);                      /* call 0x428b */
            ii(0x423f, 2);    add(al, -0x18 /* 0xe8 */);                /* add al, 0xe8 */
            ii(0x4241, 1);    dec(ax);                                  /* dec ax */
            ii(0x4242, 2);    add(memb_a16[ds, di], al);                /* add [di], al */
            ii(0x4244, 3);    callw(0x428b, 0x44);                      /* call 0x428b */
            ii(0x4247, 1);    pushw(es);                                /* push es */
            ii(0x4248, 3);    callw(0x428b, 0x40);                      /* call 0x428b */
            ii(0x424b, 1);    popw(es);                                 /* pop es */
            ii(0x424c, 3);    callw(0x428f, 0x40);                      /* call 0x428f */
            ii(0x424f, 2);    or(al, ch);                               /* or al, ch */
            ii(0x4251, 2);    cmp(memb_a16[ds, bx + si], al);           /* cmp [bx+si], al */
            ii(0x4253, 2);    or(ax, bp);                               /* or ax, bp */
            ii(0x4255, 2);    cmp(memb_a16[ds, bx + si], al);           /* cmp [bx+si], al */
            ii(0x4257, 2);    or(ch, al);                               /* or ch, al */
            ii(0x4259, 2);    xor(al, 0);                               /* xor al, 0x0 */
            ii(0x425b, 2);    or(bp, ax);                               /* or bp, ax */
            ii(0x425d, 2);    xor(memb_a16[ds, bx + si], al);           /* xor [bx+si], al */
            ii(0x425f, 2);    or(al, 0xe8);                             /* or al, 0xe8 */
            ii(0x4261, 2);    sub(al, 0);                               /* sub al, 0x0 */
            ii(0x4263, 3);    or(ax, 0x28e8);                           /* or ax, 0x28e8 */
            ii(0x4266, 4);    add(memb_a16[ds, 0x20e8], cl);            /* add [0x20e8], cl */
            ii(0x426a, 2);    add(memb_a16[ds, bx], cl);                /* add [bx], cl */
            ii(0x426c, 3);    callw(0x428b, 0x1c);                      /* call 0x428b */
            ii(0x426f, 1);    pushw(ds);                                /* push ds */
            ii(0x4270, 3);    callw(0x428b, 0x18);                      /* call 0x428b */
            ii(0x4273, 2);    and(memb_a16[ds, bx], bl);                /* and [bx], bl */
            ii(0x4275, 1);    popw(ax);                                 /* pop ax */
            ii(0x4276, 1);    pusha();                                  /* pusha */
            ii(0x4277, 1);    pushw(es);                                /* push es */
            ii(0x4278, 1);    pushw(ds);                                /* push ds */
            ii(0x4279, 1);    pushw(ss);                                /* push ss */
            ii(0x427a, 3);    mov(ax, 0x20);                            /* mov ax, 0x20 */
            ii(0x427d, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x427f, 4);    pushw(memw_a16[ds, 0x996]);               /* push word [0x996] */
            ii(0x4283, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4285, 4);    add(memw_a16[ss, bp + 0xe], 0x6);         /* add word [bp+0xe], 0x6 */
            ii(0x4289, 2);    if(jmpw_func(0x42dc, 0x51)) return;       /* jmp 0x42dc */
        }
    }
}

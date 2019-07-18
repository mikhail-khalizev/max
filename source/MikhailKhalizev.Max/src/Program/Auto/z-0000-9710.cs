using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2a2f14a3-f9bc-44f9-9c4a-8b16ff6e940e")]
        public void Method_0000_9710()
        {
            ii(0x9710, 1);    pushw(bp);                                /* push bp */
            ii(0x9711, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9713, 1);    pushw(di);                                /* push di */
            ii(0x9714, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x9717, 1);    pushw(ds);                                /* push ds */
            ii(0x9718, 1);    popw(es);                                 /* pop es */
            ii(0x9719, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0x971b, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x971d, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0x9720, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x9722, 1);    inc(cx);                                  /* inc cx */
            ii(0x9723, 2);    neg(cx);                                  /* neg cx */
            ii(0x9725, 3);    mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x9728, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0x972a, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0x972c, 1);    dec(di);                                  /* dec di */
            ii(0x972d, 2);    cmp(memb_a16[ds, di], al);                /* cmp [di], al */
            ii(0x972f, 2);    if(jzw(0x9733, 0x2)) goto l_0x9733;       /* jz 0x9733 */
            ii(0x9731, 2);    xor(di, di);                              /* xor di, di */
        l_0x9733:
            ii(0x9733, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x9735, 1);    popw(di);                                 /* pop di */
            ii(0x9736, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x9738, 1);    popw(bp);                                 /* pop bp */
            ii(0x9739, 1);    retw(); return;                           /* ret */
        }
    }
}

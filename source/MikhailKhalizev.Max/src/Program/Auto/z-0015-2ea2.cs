using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6a150a6e-3ebd-4b7b-b179-bb11db111f8d")]
        public void Method_0015_2ea2()
        {
            ii(0x15_2ea2, 1); pushw(bp);                                /* push bp */
            ii(0x15_2ea3, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_2ea5, 3); sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0x15_2ea8, 1); pushw(di);                                /* push di */
            ii(0x15_2ea9, 1); pushw(si);                                /* push si */
            ii(0x15_2eaa, 2); sub(di, di);                              /* sub di, di */
            ii(0x15_2eac, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_2eaf, 3); or(ax, memw_a16[ss, bp + 0x6]);           /* or ax, [bp+0x6] */
            ii(0x15_2eb2, 2); if(jnzw(0x15_2ebc, 0x8)) goto l_0x15_2ebc; /* jnz 0x2ebc */
            ii(0x15_2eb4, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_2eb6, 1); pushw(ax);                                /* push ax */
            ii(0x15_2eb7, 3); callw(0x15_2f2a, 0x70);                   /* call 0x2f2a */
            ii(0x15_2eba, 2); jmpw(0x15_2f1b, 0x5f); goto l_0x15_2f1b;  /* jmp 0x2f1b */
        l_0x15_2ebc:
            ii(0x15_2ebc, 3); mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0x15_2ebf, 3); mov(al, memb_a16[ds, si + 0xa]);          /* mov al, [si+0xa] */
            ii(0x15_2ec2, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x15_2ec4, 2); and(al, 0x3);                             /* and al, 0x3 */
            ii(0x15_2ec6, 2); cmp(al, 0x2);                             /* cmp al, 0x2 */
            ii(0x15_2ec8, 2); if(jnzw(0x15_2f09, 0x3f)) goto l_0x15_2f09; /* jnz 0x2f09 */
            ii(0x15_2eca, 3); test(cl, 0x8);                            /* test cl, 0x8 */
            ii(0x15_2ecd, 2); if(jnzw(0x15_2edc, 0xd)) goto l_0x15_2edc; /* jnz 0x2edc */
            ii(0x15_2ecf, 2); mov(bx, si);                              /* mov bx, si */
            ii(0x15_2ed1, 4); sub(bx, 0x3c68);                          /* sub bx, 0x3c68 */
            ii(0x15_2ed5, 5); test(memb_a16[ds, bx + 0x3d58], 0x1);     /* test byte [bx+0x3d58], 0x1 */
            ii(0x15_2eda, 2); if(jzw(0x15_2f09, 0x2d)) goto l_0x15_2f09; /* jz 0x2f09 */
        l_0x15_2edc:
            ii(0x15_2edc, 2); mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x15_2ede, 3); sub(ax, memw_a16[ds, si + 0x6]);          /* sub ax, [si+0x6] */
            ii(0x15_2ee1, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_2ee4, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_2ee6, 2); if(jlew(0x15_2f09, 0x21)) goto l_0x15_2f09; /* jle 0x2f09 */
            ii(0x15_2ee8, 1); pushw(ax);                                /* push ax */
            ii(0x15_2ee9, 3); pushw(memw_a16[ds, si + 0x8]);            /* push word [si+0x8] */
            ii(0x15_2eec, 3); pushw(memw_a16[ds, si + 0x6]);            /* push word [si+0x6] */
            ii(0x15_2eef, 3); mov(cl, memb_a16[ds, si + 0xb]);          /* mov cl, [si+0xb] */
            ii(0x15_2ef2, 2); sub(ch, ch);                              /* sub ch, ch */
            ii(0x15_2ef4, 1); pushw(cx);                                /* push cx */
            ii(0x15_2ef5, 1); nop();                                    /* nop */
            ii(0x15_2ef6, 1); pushw(cs);                                /* push cs */
            ii(0x15_2ef7, 3); callw(0x15_310e, 0x214);                  /* call 0x310e */
            ii(0x15_2efa, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_2efd, 3); cmp(memw_a16[ss, bp - 0x2], ax);          /* cmp [bp-0x2], ax */
            ii(0x15_2f00, 2); if(jzw(0x15_2f09, 0x7)) goto l_0x15_2f09; /* jz 0x2f09 */
            ii(0x15_2f02, 4); or(memb_a16[ds, si + 0xa], 0x20);         /* or byte [si+0xa], 0x20 */
            ii(0x15_2f06, 3); mov(di, 0xffff);                          /* mov di, 0xffff */
        l_0x15_2f09:
            ii(0x15_2f09, 3); mov(ax, memw_a16[ds, si + 0x6]);          /* mov ax, [si+0x6] */
            ii(0x15_2f0c, 3); mov(dx, memw_a16[ds, si + 0x8]);          /* mov dx, [si+0x8] */
            ii(0x15_2f0f, 2); mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x15_2f11, 3); mov(memw_a16[ds, si + 0x2], dx);          /* mov [si+0x2], dx */
            ii(0x15_2f14, 5); mov(memw_a16[ds, si + 0x4], 0);           /* mov word [si+0x4], 0x0 */
            ii(0x15_2f19, 2); mov(ax, di);                              /* mov ax, di */
        l_0x15_2f1b:
            ii(0x15_2f1b, 1); popw(si);                                 /* pop si */
            ii(0x15_2f1c, 1); popw(di);                                 /* pop di */
            ii(0x15_2f1d, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x15_2f1f, 1); popw(bp);                                 /* pop bp */
            ii(0x15_2f20, 1); retfw(); return;                          /* retf */
        }
    }
}

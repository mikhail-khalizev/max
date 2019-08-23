using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4a08-8bdcab87")]
        public void Method_0017_4a08()
        {
            ii(0x17_4a08, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x17_4a0c, 1); pushw(ds);                                /* push ds */
            ii(0x17_4a0d, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4a10, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4a12, 3); mov(dl, memb_a16[ss, bp + 0x6]);          /* mov dl, [bp+0x6] */
            ii(0x17_4a15, 2); mov(ah, 0x36);                            /* mov ah, 0x36 */
            ii(0x17_4a17, 4); callw_a16_far_ind(ds, 0x1fe0);            /* call far word [0x1fe0] */
            ii(0x17_4a1b, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x17_4a1e, 2); if(jzw(0x17_4a26, 0x6)) goto l_0x17_4a26; /* jz 0x4a26 */
            ii(0x17_4a20, 2); mul(cx);                                  /* mul cx */
            ii(0x17_4a22, 2); mul(bx);                                  /* mul bx */
            ii(0x17_4a24, 2); jmpw(0x17_4a2b, 0x5); goto l_0x17_4a2b;   /* jmp 0x4a2b */
        l_0x17_4a26:
            ii(0x17_4a26, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x17_4a29, 2); mov(dx, ax);                              /* mov dx, ax */
        l_0x17_4a2b:
            ii(0x17_4a2b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_4a2e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x17_4a31, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x17_4a34, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x17_4a37, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_4a39, 2); mov(ah, dl);                              /* mov ah, dl */
            ii(0x17_4a3b, 2); mov(dl, dh);                              /* mov dl, dh */
            ii(0x17_4a3d, 2); sub(dh, dh);                              /* sub dh, dh */
            ii(0x17_4a3f, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_4a41, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_4a43, 2); shr(dx, 0x1);                             /* shr dx, 1 */
            ii(0x17_4a45, 2); rcr(ax, 0x1);                             /* rcr ax, 1 */
            ii(0x17_4a47, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4a48, 1); leavew();                                 /* leave */
            ii(0x17_4a49, 1); retfw();                                  /* retf */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3e58ab48-c44d-47fc-b77b-4cb892e21c28")]
        public void Method_0013_615a()
        {
            ii(0x13_615a, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x13_615e, 1); pushw(si);                                /* push si */
            ii(0x13_615f, 1); pushw(ds);                                /* push ds */
            ii(0x13_6160, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_6163, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_6165, 1); nop();                                    /* nop */
            ii(0x13_6166, 1); pushw(cs);                                /* push cs */
            ii(0x13_6167, 3); callw(0x13_790e, 0x17a4);                 /* call 0x790e */
            ii(0x13_616a, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x13_616d, 3); cmp(ax, 0xffff);                          /* cmp ax, 0xffff */
            ii(0x13_6170, 2); if(jnzw(0x13_617a, 0x8)) goto l_0x13_617a; /* jnz 0x617a */
            ii(0x13_6172, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x13_6174, 1); cwd();                                    /* cwd */
            ii(0x13_6175, 1); popw(ds);                                 /* pop ds */
            ii(0x13_6176, 1); popw(si);                                 /* pop si */
            ii(0x13_6177, 1); leavew();                                 /* leave */
            ii(0x13_6178, 1); retfw(); return;                          /* retf */
        //  ii(0x13_6179, 1); Недостижимый код.
l_0x13_617a:
            ii(0x13_617a, 1); pushw(ax);                                /* push ax */
            ii(0x13_617b, 1); nop();                                    /* nop */
            ii(0x13_617c, 1); pushw(cs);                                /* push cs */
            ii(0x13_617d, 3); callw(0x13_7e98, 0x1d18);                 /* call 0x7e98 */
            ii(0x13_6180, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x13_6183, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x13_6186, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x13_6189, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x13_618d, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_6190, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x13_6194, 4); les(si, ds, 0x4fa4);                      /* les si, [0x4fa4] */
            ii(0x13_6198, 3); mov(memw_a16[es, bx + si], ax);           /* mov [es:bx+si], ax */
            ii(0x13_619b, 4); mov(memw_a16[es, bx + si + 0x2], dx);     /* mov [es:bx+si+0x2], dx */
            ii(0x13_619f, 4); les(si, ds, 0x4fa0);                      /* les si, [0x4fa0] */
            ii(0x13_61a3, 3); mov(ax, memw_a16[es, bx + si]);           /* mov ax, [es:bx+si] */
            ii(0x13_61a6, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x13_61aa, 2); mov(dh, dl);                              /* mov dh, dl */
            ii(0x13_61ac, 2); mov(dl, ah);                              /* mov dl, ah */
            ii(0x13_61ae, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x13_61b0, 2); sub(al, al);                              /* sub al, al */
            ii(0x13_61b2, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_61b4, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_61b6, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_61b8, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_61ba, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_61bc, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_61be, 2); shl(ax, 0x1);                             /* shl ax, 1 */
            ii(0x13_61c0, 2); rcl(dx, 0x1);                             /* rcl dx, 1 */
            ii(0x13_61c2, 1); popw(ds);                                 /* pop ds */
            ii(0x13_61c3, 1); popw(si);                                 /* pop si */
            ii(0x13_61c4, 1); leavew();                                 /* leave */
            ii(0x13_61c5, 1); retfw(); return;                          /* retf */
        }
    }
}

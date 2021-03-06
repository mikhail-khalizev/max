using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_615a-6bcb8edc")]
        public void Method_0017_615a()
        {
            ii(0x17_615a, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_615e, 1);  push(si);                               /* push si */
            ii(0x17_615f, 1);  push(ds);                               /* push ds */
            ii(0x17_6160, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_6163, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_6165, 1);  nop();                                  /* nop */
            ii(0x17_6166, 1);  push(cs);                               /* push cs */
            ii(0x17_6167, 3);  call(0x17_790e, 0x17a4);                /* call 0x790e */
            ii(0x17_616a, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_616d, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x17_6170, 2);  if(jnz(0x17_617a, 8)) goto l_0x17_617a; /* jnz 0x617a */
            ii(0x17_6172, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_6174, 1);  cwd();                                  /* cwd */
            ii(0x17_6175, 1);  pop(ds);                                /* pop ds */
            ii(0x17_6176, 1);  pop(si);                                /* pop si */
            ii(0x17_6177, 1);  leave();                                /* leave */
            ii(0x17_6178, 1);  retf(); return;                         /* retf */
        //  ii(0x17_6179, 1);  Недостижимый код.
        l_0x17_617a:
            ii(0x17_617a, 1);  push(ax);                               /* push ax */
            ii(0x17_617b, 1);  nop();                                  /* nop */
            ii(0x17_617c, 1);  push(cs);                               /* push cs */
            ii(0x17_617d, 3);  call(0x17_7e98, 0x1d18);                /* call 0x7e98 */
            ii(0x17_6180, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_6183, 3);  mov(bx, memw[ss, bp - 2]);              /* mov bx, [bp-0x2] */
            ii(0x17_6186, 3);  shl(bx, 2);                             /* shl bx, 0x2 */
            ii(0x17_6189, 4);  les(si, memw[ds, 0x4fa0]);              /* les si, [0x4fa0] */
            ii(0x17_618d, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x17_6190, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_6194, 4);  les(si, memw[ds, 0x4fa4]);              /* les si, [0x4fa4] */
            ii(0x17_6198, 3);  mov(memw[es, bx + si], ax);             /* mov [es:bx+si], ax */
            ii(0x17_619b, 4);  mov(memw[es, bx + si + 2], dx);         /* mov [es:bx+si+0x2], dx */
            ii(0x17_619f, 4);  les(si, memw[ds, 0x4fa0]);              /* les si, [0x4fa0] */
            ii(0x17_61a3, 3);  mov(ax, memw[es, bx + si]);             /* mov ax, [es:bx+si] */
            ii(0x17_61a6, 4);  mov(dx, memw[es, bx + si + 2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x17_61aa, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_61ac, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_61ae, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_61b0, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_61b2, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_61b4, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_61b6, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_61b8, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_61ba, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_61bc, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_61be, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_61c0, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_61c2, 1);  pop(ds);                                /* pop ds */
            ii(0x17_61c3, 1);  pop(si);                                /* pop si */
            ii(0x17_61c4, 1);  leave();                                /* leave */
            ii(0x17_61c5, 1);  retf();                                 /* retf */
        }
    }
}

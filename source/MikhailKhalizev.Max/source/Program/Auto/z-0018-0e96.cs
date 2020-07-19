using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_0e96-7e601664")]
        public void Method_0018_0e96()
        {
            ii(0x18_0e96, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x18_0e9a, 1);  push(ds);                               /* push ds */
            ii(0x18_0e9b, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x18_0e9e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x18_0ea0, 1);  push(ds);                               /* push ds */
            ii(0x18_0ea1, 3);  push(0x1b6c);                           /* push 0x1b6c */
            ii(0x18_0ea4, 1);  nop();                                  /* nop */
            ii(0x18_0ea5, 1);  push(cs);                               /* push cs */
            ii(0x18_0ea6, 3);  call(0x17_edf0, -0x20b9);               /* call 0xedf0 */
            ii(0x18_0ea9, 1);  pop(bx);                                /* pop bx */
            ii(0x18_0eaa, 1);  pop(bx);                                /* pop bx */
            ii(0x18_0eab, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_0eae, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x18_0eb1, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x18_0eb3, 2);  if(jz(0x18_0ed4, 0x1f)) goto l_0x18_0ed4;/* jz 0xed4 */
            ii(0x18_0eb5, 1);  push(ds);                               /* push ds */
            ii(0x18_0eb6, 3);  push(0x1b73);                           /* push 0x1b73 */
            ii(0x18_0eb9, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x18_0ebc, 1);  push(ax);                               /* push ax */
            ii(0x18_0ebd, 1);  nop();                                  /* nop */
            ii(0x18_0ebe, 1);  push(cs);                               /* push cs */
            ii(0x18_0ebf, 3);  call(0x17_ec70, -0x2252);               /* call 0xec70 */
            ii(0x18_0ec2, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x18_0ec5, 3);  mov(memw[ds, 0x1b60], ax);              /* mov [0x1b60], ax */
            ii(0x18_0ec8, 4);  mov(memw[ds, 0x1b62], dx);              /* mov [0x1b62], dx */
            ii(0x18_0ecc, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x18_0ece, 4);  or(ax, memw[ds, 0x1b60]);               /* or ax, [0x1b60] */
            ii(0x18_0ed2, 2);  if(jnz(0x18_0edd, 9)) goto l_0x18_0edd; /* jnz 0xedd */
        l_0x18_0ed4:
            ii(0x18_0ed4, 3);  push(0xee);                             /* push 0xee */
            ii(0x18_0ed7, 1);  nop();                                  /* nop */
            ii(0x18_0ed8, 1);  push(cs);                               /* push cs */
            ii(0x18_0ed9, 3);  call(0x17_d54f, -0x398d);               /* call 0xd54f */
            ii(0x18_0edc, 1);  pop(bx);                                /* pop bx */
        l_0x18_0edd:
            ii(0x18_0edd, 1);  push(ds);                               /* push ds */
            ii(0x18_0ede, 3);  push(0x1b7c);                           /* push 0x1b7c */
            ii(0x18_0ee1, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x18_0ee4, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x18_0ee7, 1);  nop();                                  /* nop */
            ii(0x18_0ee8, 1);  push(cs);                               /* push cs */
            ii(0x18_0ee9, 3);  call(0x17_ec70, -0x227c);               /* call 0xec70 */
            ii(0x18_0eec, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x18_0eef, 3);  mov(memw[ds, 0x1b64], ax);              /* mov [0x1b64], ax */
            ii(0x18_0ef2, 4);  mov(memw[ds, 0x1b66], dx);              /* mov [0x1b66], dx */
            ii(0x18_0ef6, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x18_0ef9, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x18_0efc, 3);  mov(memw[ds, 0x1b68], ax);              /* mov [0x1b68], ax */
            ii(0x18_0eff, 4);  mov(memw[ds, 0x1b6a], dx);              /* mov [0x1b6a], dx */
            ii(0x18_0f03, 1);  push(cs);                               /* push cs */
            ii(0x18_0f04, 3);  call(0x18_0e76, -0x91);                 /* call 0xe76 */
            ii(0x18_0f07, 1);  pop(ds);                                /* pop ds */
            ii(0x18_0f08, 1);  leave();                                /* leave */
            ii(0x18_0f09, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}

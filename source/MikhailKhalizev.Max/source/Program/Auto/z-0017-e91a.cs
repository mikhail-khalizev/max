using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e91a-b5f262f6")]
        public void Method_0017_e91a()
        {
            ii(0x17_e91a, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x17_e91e, 1);  push(ds);                               /* push ds */
            ii(0x17_e91f, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_e922, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_e924, 5);  mov(memw[ss, bp - 4], 0xffff);          /* mov word [bp-0x4], 0xffff */
            ii(0x17_e929, 5);  mov(memw[ss, bp - 2], 0xffff);          /* mov word [bp-0x2], 0xffff */
            ii(0x17_e92e, 3);  lea(ax, memw[ss, bp - 12]);             /* lea ax, [bp-0xc] */
            ii(0x17_e931, 1);  push(ss);                               /* push ss */
            ii(0x17_e932, 1);  push(ax);                               /* push ax */
            ii(0x17_e933, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x17_e936, 1);  nop();                                  /* nop */
            ii(0x17_e937, 1);  push(cs);                               /* push cs */
            ii(0x17_e938, 3);  call(0x17_effa, 0x6bf);                 /* call 0xeffa */
            ii(0x17_e93b, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_e93e, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_e940, 2);  if(jz(0x17_e961, 0x1f)) goto l_0x17_e961;/* jz 0xe961 */
            ii(0x17_e942, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_e945, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_e947, 2);  mov(dx, ax);                            /* mov dx, ax */
            ii(0x17_e949, 3);  mov(cx, memw[ss, bp - 10]);             /* mov cx, [bp-0xa] */
            ii(0x17_e94c, 3);  mov(bx, memw[ss, bp - 8]);              /* mov bx, [bp-0x8] */
            ii(0x17_e94f, 2);  sub(bh, bh);                            /* sub bh, bh */
            ii(0x17_e951, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x17_e953, 2);  or(dx, bx);                             /* or dx, bx */
            ii(0x17_e955, 3);  add(ax, memw[ss, bp + 6]);              /* add ax, [bp+0x6] */
            ii(0x17_e958, 3);  adc(dx, 0);                             /* adc dx, 0x0 */
            ii(0x17_e95b, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_e95e, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
        l_0x17_e961:
            ii(0x17_e961, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_e964, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_e967, 1);  pop(ds);                                /* pop ds */
            ii(0x17_e968, 1);  leave();                                /* leave */
            ii(0x17_e969, 1);  retf();                                 /* retf */
        }
    }
}

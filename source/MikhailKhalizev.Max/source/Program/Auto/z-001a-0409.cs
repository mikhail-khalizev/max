using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0409-5ff50b5")]
        public void Method_001a_0409()
        {
            ii(0x1a_0409, 4);  enter(0x2a, 0);                         /* enter 0x2a, 0x0 */
            ii(0x1a_040d, 1);  push(ds);                               /* push ds */
            ii(0x1a_040e, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x1a_0411, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x1a_0413, 3);  mov(ax, memw[ds, 0x32a2]);              /* mov ax, [0x32a2] */
            ii(0x1a_0416, 4);  or(ax, memw[ds, 0x32a0]);               /* or ax, [0x32a0] */
            ii(0x1a_041a, 2);  if(jnz(0x1a_042e, 0x12)) goto l_0x1a_042e;/* jnz 0x42e */
            ii(0x1a_041c, 1);  push(ds);                               /* push ds */
            ii(0x1a_041d, 3);  push(0x3715);                           /* push 0x3715 */
            ii(0x1a_0420, 1);  push(ds);                               /* push ds */
            ii(0x1a_0421, 3);  push(0x3708);                           /* push 0x3708 */
            ii(0x1a_0424, 3);  call(0x19_fcad, -0x77a);                /* call 0xfcad */
            ii(0x1a_0427, 3);  mov(memw[ds, 0x32a0], ax);              /* mov [0x32a0], ax */
            ii(0x1a_042a, 4);  mov(memw[ds, 0x32a2], dx);              /* mov [0x32a2], dx */
        l_0x1a_042e:
            ii(0x1a_042e, 3);  lea(ax, memw[ss, bp - 38]);             /* lea ax, [bp-0x26] */
            ii(0x1a_0431, 1);  push(ss);                               /* push ss */
            ii(0x1a_0432, 1);  push(ax);                               /* push ax */
            ii(0x1a_0433, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x1a_0436, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x1a_0439, 3);  call(0x19_fff7, -0x445);                /* call 0xfff7 */
            ii(0x1a_043c, 3);  mov(ax, memw[ds, 0x32a2]);              /* mov ax, [0x32a2] */
            ii(0x1a_043f, 4);  or(ax, memw[ds, 0x32a0]);               /* or ax, [0x32a0] */
            ii(0x1a_0443, 2);  if(jz(0x1a_0452, 0xd)) goto l_0x1a_0452;/* jz 0x452 */
            ii(0x1a_0445, 3);  lea(ax, memw[ss, bp - 38]);             /* lea ax, [bp-0x26] */
            ii(0x1a_0448, 1);  push(ss);                               /* push ss */
            ii(0x1a_0449, 1);  push(ax);                               /* push ax */
            ii(0x1a_044a, 4);  call_far_ind(memw[ds, 0x32a0]);         /* call far word [0x32a0] */
            ii(0x1a_044e, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_044f, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_0450, 2);  jmp(0x1a_0470, 0x1e); goto l_0x1a_0470; /* jmp 0x470 */
        l_0x1a_0452:
            ii(0x1a_0452, 3);  lea(ax, memw[ss, bp - 38]);             /* lea ax, [bp-0x26] */
            ii(0x1a_0455, 1);  push(ss);                               /* push ss */
            ii(0x1a_0456, 1);  push(ax);                               /* push ax */
            ii(0x1a_0457, 5);  call_far_abs(0x80, 0x3e14);             /* call word 0x80:0x3e14 */
            ii(0x1a_045c, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_045d, 1);  pop(bx);                                /* pop bx */
            ii(0x1a_045e, 3);  mov(memw[ss, bp - 42], ax);             /* mov [bp-0x2a], ax */
            ii(0x1a_0461, 3);  mov(memw[ss, bp - 40], dx);             /* mov [bp-0x28], dx */
            ii(0x1a_0464, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x1a_0466, 2);  if(jz(0x1a_046d, 5)) goto l_0x1a_046d;  /* jz 0x46d */
            ii(0x1a_0468, 3);  mov(dx, memw[ss, bp - 40]);             /* mov dx, [bp-0x28] */
            ii(0x1a_046b, 2);  jmp(0x1a_0470, 3); goto l_0x1a_0470;    /* jmp 0x470 */
        l_0x1a_046d:
            ii(0x1a_046d, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x1a_046f, 1);  cwd();                                  /* cwd */
        l_0x1a_0470:
            ii(0x1a_0470, 1);  pop(ds);                                /* pop ds */
            ii(0x1a_0471, 1);  leave();                                /* leave */
            ii(0x1a_0472, 3);  retf(4);                                /* retf 0x4 */
        }
    }
}

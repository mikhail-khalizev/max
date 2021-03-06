using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0d08-9a9b6a32")]
        public void Method_0019_0d08()
        {
            ii(0x19_0d08, 4);  enter(8, 0);                            /* enter 0x8, 0x0 */
            ii(0x19_0d0c, 1);  push(di);                               /* push di */
            ii(0x19_0d0d, 1);  push(si);                               /* push si */
            ii(0x19_0d0e, 5);  mov(memw[ss, bp - 4], 0);               /* mov word [bp-0x4], 0x0 */
            ii(0x19_0d13, 2);  push(3);                                /* push 0x3 */
            ii(0x19_0d15, 1);  nop();                                  /* nop */
            ii(0x19_0d16, 1);  push(cs);                               /* push cs */
            ii(0x19_0d17, 3);  call(0x19_464a, 0x3930);                /* call 0x464a */
            ii(0x19_0d1a, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_0d1d, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_0d20, 4);  push(memw[ds, 0x308c]);                 /* push word [0x308c] */
            ii(0x19_0d24, 1);  nop();                                  /* nop */
            ii(0x19_0d25, 1);  push(cs);                               /* push cs */
            ii(0x19_0d26, 3);  call(0x19_4678, 0x394f);                /* call 0x4678 */
            ii(0x19_0d29, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_0d2c, 3);  mov(memw[ds, 0x308e], ax);              /* mov [0x308e], ax */
            ii(0x19_0d2f, 4);  mov(memw[ds, 0x3090], dx);              /* mov [0x3090], dx */
            ii(0x19_0d33, 3);  mov(ax, memw[ds, 0x3090]);              /* mov ax, [0x3090] */
            ii(0x19_0d36, 4);  or(ax, memw[ds, 0x308e]);               /* or ax, [0x308e] */
            ii(0x19_0d3a, 2);  if(jz(0x19_0d3f, 3)) goto l_0x19_0d3f;  /* jz 0xd3f */
            ii(0x19_0d3c, 3);  jmp(0x19_0d42, 3); goto l_0x19_0d42;    /* jmp 0xd42 */
        l_0x19_0d3f:
            ii(0x19_0d3f, 3);  jmp(0x19_0d6b, 0x29); goto l_0x19_0d6b; /* jmp 0xd6b */
        l_0x19_0d42:
            ii(0x19_0d42, 4);  push(memw[ds, 0x3090]);                 /* push word [0x3090] */
            ii(0x19_0d46, 4);  push(memw[ds, 0x308e]);                 /* push word [0x308e] */
            ii(0x19_0d4a, 1);  nop();                                  /* nop */
            ii(0x19_0d4b, 1);  push(cs);                               /* push cs */
            ii(0x19_0d4c, 3);  call(0x19_0c56, -0xf9);                 /* call 0xc56 */
            ii(0x19_0d4f, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x19_0d52, 3);  mov(memw[ds, 0x490a], ax);              /* mov [0x490a], ax */
            ii(0x19_0d55, 4);  mov(memw[ds, 0x490c], dx);              /* mov [0x490c], dx */
            ii(0x19_0d59, 3);  mov(ax, memw[ds, 0x490c]);              /* mov ax, [0x490c] */
            ii(0x19_0d5c, 4);  or(ax, memw[ds, 0x490a]);               /* or ax, [0x490a] */
            ii(0x19_0d60, 2);  if(jz(0x19_0d65, 3)) goto l_0x19_0d65;  /* jz 0xd65 */
            ii(0x19_0d62, 3);  jmp(0x19_0d68, 3); goto l_0x19_0d68;    /* jmp 0xd68 */
        l_0x19_0d65:
            ii(0x19_0d65, 3);  jmp(0x19_0d6b, 3); goto l_0x19_0d6b;    /* jmp 0xd6b */
        l_0x19_0d68:
            ii(0x19_0d68, 3);  inc(memw[ss, bp - 4]);                  /* inc word [bp-0x4] */
        l_0x19_0d6b:
            ii(0x19_0d6b, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_0d6e, 1);  nop();                                  /* nop */
            ii(0x19_0d6f, 1);  push(cs);                               /* push cs */
            ii(0x19_0d70, 3);  call(0x19_464a, 0x38d7);                /* call 0x464a */
            ii(0x19_0d73, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x19_0d76, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_0d79, 3);  jmp(0x19_0d7c, 0); goto l_0x19_0d7c;    /* jmp 0xd7c */
        l_0x19_0d7c:
            ii(0x19_0d7c, 1);  pop(si);                                /* pop si */
            ii(0x19_0d7d, 1);  pop(di);                                /* pop di */
            ii(0x19_0d7e, 1);  leave();                                /* leave */
            ii(0x19_0d7f, 1);  retf();                                 /* retf */
        }
    }
}

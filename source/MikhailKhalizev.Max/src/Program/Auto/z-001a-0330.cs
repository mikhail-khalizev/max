using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0330-535f941f")]
        public void Method_001a_0330()
        {
            ii(0x1a_0330, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x1a_0334, 1); push(ds);                                 /* push ds */
            ii(0x1a_0335, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x1a_0338, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x1a_033a, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x1a_033d, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x1a_0340, 3); call(0x19_ff2f, -0x414);                  /* call 0xff2f */
            ii(0x1a_0343, 3); add(ax, memw[ss, bp + 0x6]);              /* add ax, [bp+0x6] */
            ii(0x1a_0346, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
            ii(0x1a_0349, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x1a_034c, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x1a_034f, 2); jmp(0x1a_0370, 0x1f); goto l_0x1a_0370;   /* jmp 0x370 */
        l_0x1a_0351:
            ii(0x1a_0351, 3); dec(memw[ss, bp - 0x4]);                  /* dec word [bp-0x4] */
            ii(0x1a_0354, 3); les(bx, ss, bp - 0x4);                    /* les bx, [bp-0x4] */
            ii(0x1a_0357, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x1a_035a, 1); cbw();                                    /* cbw */
            ii(0x1a_035b, 2); jmp(0x1a_0366, 0x9); goto l_0x1a_0366;    /* jmp 0x366 */
        l_0x1a_035d:
            ii(0x1a_035d, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x1a_0360, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x1a_0363, 1); inc(ax);                                  /* inc ax */
            ii(0x1a_0364, 2); jmp(0x1a_037b, 0x15); goto l_0x1a_037b;   /* jmp 0x37b */
        l_0x1a_0366:
            ii(0x1a_0366, 3); sub(ax, 0x3a);                            /* sub ax, 0x3a */
            ii(0x1a_0369, 2); if(jz(0x1a_035d, -0xe)) goto l_0x1a_035d; /* jz 0x35d */
            ii(0x1a_036b, 3); sub(ax, 0x22);                            /* sub ax, 0x22 */
            ii(0x1a_036e, 2); if(jz(0x1a_035d, -0x13)) goto l_0x1a_035d; /* jz 0x35d */
        l_0x1a_0370:
            ii(0x1a_0370, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x1a_0373, 3); cmp(memw[ss, bp - 0x4], ax);              /* cmp [bp-0x4], ax */
            ii(0x1a_0376, 2); if(ja(0x1a_0351, -0x27)) goto l_0x1a_0351; /* ja 0x351 */
            ii(0x1a_0378, 3); mov(dx, memw[ss, bp + 0x8]);              /* mov dx, [bp+0x8] */
        l_0x1a_037b:
            ii(0x1a_037b, 1); pop(ds);                                  /* pop ds */
            ii(0x1a_037c, 1); leave();                                  /* leave */
            ii(0x1a_037d, 3); retf(0x4);                                /* retf 0x4 */
        }
    }
}

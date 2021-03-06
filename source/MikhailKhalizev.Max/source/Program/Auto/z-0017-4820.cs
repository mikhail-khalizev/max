using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4820-b56da3d1")]
        public void Method_0017_4820()
        {
            ii(0x17_4820, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_4824, 1);  push(si);                               /* push si */
            ii(0x17_4825, 1);  push(ds);                               /* push ds */
            ii(0x17_4826, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_4829, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_482b, 2);  sub(si, si);                            /* sub si, si */
            ii(0x17_482d, 2);  jmp(0x17_4831, 2); goto l_0x17_4831;    /* jmp 0x4831 */
        //  ii(0x17_482f, 1);  Недостижимый код.
        l_0x17_4830:
            ii(0x17_4830, 1);  inc(si);                                /* inc si */
        l_0x17_4831:
            ii(0x17_4831, 3);  cmp(si, 8);                             /* cmp si, 0x8 */
            ii(0x17_4834, 2);  if(jge(0x17_4856, 0x20)) goto l_0x17_4856;/* jge 0x4856 */
            ii(0x17_4836, 2);  push(0);                                /* push 0x0 */
            ii(0x17_4838, 2);  push(0xb);                              /* push 0xb */
            ii(0x17_483a, 2);  push(0);                                /* push 0x0 */
            ii(0x17_483c, 1);  nop();                                  /* nop */
            ii(0x17_483d, 1);  push(cs);                               /* push cs */
            ii(0x17_483e, 3);  call(0x16_e96a, -0x5ed7);               /* call 0xe96a */
            ii(0x17_4841, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_4844, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_4847, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_484a, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_484c, 2);  mov(bx, si);                            /* mov bx, si */
            ii(0x17_484e, 2);  shl(bx, 1);                             /* shl bx, 1 */
            ii(0x17_4850, 4);  mov(memw[ds, bx + 0x1e8e], ax);         /* mov [bx+0x1e8e], ax */
            ii(0x17_4854, 2);  jmp(0x17_4830, -0x26); goto l_0x17_4830;/* jmp 0x4830 */
        l_0x17_4856:
            ii(0x17_4856, 6);  mov(memw[ds, 0xd8], 0);                 /* mov word [0xd8], 0x0 */
            ii(0x17_485c, 1);  pop(ds);                                /* pop ds */
            ii(0x17_485d, 1);  pop(si);                                /* pop si */
            ii(0x17_485e, 1);  leave();                                /* leave */
            ii(0x17_485f, 1);  retf();                                 /* retf */
        }
    }
}

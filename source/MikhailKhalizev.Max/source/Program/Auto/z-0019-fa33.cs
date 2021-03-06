using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fa33-193eda21")]
        public void Method_0019_fa33()
        {
            ii(0x19_fa33, 1);  push(ds);                               /* push ds */
            ii(0x19_fa34, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_fa37, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_fa39, 5);  cmp(memw[ds, 0x3182], -1 /* 0xff */);   /* cmp word [0x3182], 0xffff */
            ii(0x19_fa3e, 2);  if(jnz(0x19_fa66, 0x26)) goto l_0x19_fa66;/* jnz 0xfa66 */
            ii(0x19_fa40, 1);  push(ds);                               /* push ds */
            ii(0x19_fa41, 3);  push(0x317c);                           /* push 0x317c */
            ii(0x19_fa44, 5);  call_far_abs(0x80, 0x5ba0);             /* call word 0x80:0x5ba0 */
            ii(0x19_fa49, 1);  pop(bx);                                /* pop bx */
            ii(0x19_fa4a, 1);  pop(bx);                                /* pop bx */
            ii(0x19_fa4b, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_fa4d, 2);  if(jnz(0x19_fa58, 9)) goto l_0x19_fa58; /* jnz 0xfa58 */
            ii(0x19_fa4f, 5);  call_far_abs(0x80, 0x51a8);             /* call word 0x80:0x51a8 */
            ii(0x19_fa54, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_fa56, 2);  if(jz(0x19_fa60, 8)) goto l_0x19_fa60;  /* jz 0xfa60 */
        l_0x19_fa58:
            ii(0x19_fa58, 6);  mov(memw[ds, 0x3182], 1);               /* mov word [0x3182], 0x1 */
            ii(0x19_fa5e, 2);  jmp(0x19_fa66, 6); goto l_0x19_fa66;    /* jmp 0xfa66 */
        l_0x19_fa60:
            ii(0x19_fa60, 6);  mov(memw[ds, 0x3182], 0);               /* mov word [0x3182], 0x0 */
        l_0x19_fa66:
            ii(0x19_fa66, 3);  mov(ax, memw[ds, 0x3182]);              /* mov ax, [0x3182] */
            ii(0x19_fa69, 1);  pop(ds);                                /* pop ds */
            ii(0x19_fa6a, 1);  ret();                                  /* ret */
        }
    }
}

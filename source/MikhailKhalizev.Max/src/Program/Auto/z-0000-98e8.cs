using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("814da561-c27f-4344-a6c2-6c8a8f42db27")]
        public void Method_0000_98e8()
        {
            ii(0x98e8, 1);    pusha();                                  /* pusha */
            ii(0x98e9, 1);    pushw(ds);                                /* push ds */
            ii(0x98ea, 3);    mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x98ed, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x98ef, 3);    mov(si, 0x2f6);                           /* mov si, 0x2f6 */
            ii(0x98f2, 1);    std();                                    /* std */
        l_0x98f3:
            ii(0x98f3, 2);    mov(bx, si);                              /* mov bx, si */
            ii(0x98f5, 1);    lodsw_a16();                              /* lodsw */
            ii(0x98f6, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x98f8, 1);    lodsw_a16();                              /* lodsw */
        l_0x98f9:
            ii(0x98f9, 4);    cmp(bx, 0x2fa);                           /* cmp bx, 0x2fa */
            ii(0x98fd, 2);    if(jaew(0x98f3, -0xc)) goto l_0x98f3;     /* jae 0x98f3 */
            ii(0x98ff, 1);    inc(bx);                                  /* inc bx */
            ii(0x9900, 1);    inc(bx);                                  /* inc bx */
            ii(0x9901, 2);    cmp(memw_a16[ds, bx], ax);                /* cmp [bx], ax */
            ii(0x9903, 1);    pushfw();                                 /* pushfw */
            ii(0x9904, 1);    inc(bx);                                  /* inc bx */
            ii(0x9905, 1);    inc(bx);                                  /* inc bx */
            ii(0x9906, 1);    popfw();                                  /* popfw */
            ii(0x9907, 2);    if(jnzw(0x98f9, -0x10)) goto l_0x98f9;    /* jnz 0x98f9 */
            ii(0x9909, 2);    cmp(memw_a16[ds, bx], dx);                /* cmp [bx], dx */
            ii(0x990b, 2);    if(jnzw(0x98f9, -0x14)) goto l_0x98f9;    /* jnz 0x98f9 */
            ii(0x990d, 1);    popw(ds);                                 /* pop ds */
            ii(0x990e, 3);    mov(memw_a16[ds, 0x56], ax);              /* mov [0x56], ax */
            ii(0x9911, 4);    mov(memw_a16[ds, 0x58], dx);              /* mov [0x58], dx */
            ii(0x9915, 1);    popa();                                   /* popa */
            ii(0x9916, 1);    cld();                                    /* cld */
            ii(0x9917, 1);    retw(); return;                           /* ret */
        }
    }
}

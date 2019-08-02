using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("58e7c811-dd06-443a-a7af-a53ad2ba5215")]
        public void Method_0014_0a56()
        {
            ii(0x14_0a56, 1); pushw(ds);                                /* push ds */
            ii(0x14_0a57, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x14_0a5a, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_0a5c, 5); cmp(memw_a16[ds, 0x1bb0], -0x1 /* 0xff */); /* cmp word [0x1bb0], 0xffff */
            ii(0x14_0a61, 2); if(jnzw(0x14_0a89, 0x26)) goto l_0x14_0a89; /* jnz 0xa89 */
            ii(0x14_0a63, 1); pushw(ds);                                /* push ds */
            ii(0x14_0a64, 3); pushw(0x1baa);                            /* push 0x1baa */
            ii(0x14_0a67, 1); nop();                                    /* nop */
            ii(0x14_0a68, 1); pushw(cs);                                /* push cs */
            ii(0x14_0a69, 3); callw(0x13_edf0, -0x1c7c);                /* call 0xedf0 */
            ii(0x14_0a6c, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0a6d, 1); popw(bx);                                 /* pop bx */
            ii(0x14_0a6e, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x14_0a70, 2); if(jnzw(0x14_0a7b, 0x9)) goto l_0x14_0a7b; /* jnz 0xa7b */
            ii(0x14_0a72, 1); nop();                                    /* nop */
            ii(0x14_0a73, 1); pushw(cs);                                /* push cs */
            ii(0x14_0a74, 3); callw(0x13_f134, -0x1943);                /* call 0xf134 */
            ii(0x14_0a77, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x14_0a79, 2); if(jzw(0x14_0a83, 0x8)) goto l_0x14_0a83; /* jz 0xa83 */
        l_0x14_0a7b:
            ii(0x14_0a7b, 6); mov(memw_a16[ds, 0x1bb0], 0x1);           /* mov word [0x1bb0], 0x1 */
            ii(0x14_0a81, 2); jmpw(0x14_0a89, 0x6); goto l_0x14_0a89;   /* jmp 0xa89 */
        l_0x14_0a83:
            ii(0x14_0a83, 6); mov(memw_a16[ds, 0x1bb0], 0);             /* mov word [0x1bb0], 0x0 */
        l_0x14_0a89:
            ii(0x14_0a89, 3); mov(ax, memw_a16[ds, 0x1bb0]);            /* mov ax, [0x1bb0] */
            ii(0x14_0a8c, 1); popw(ds);                                 /* pop ds */
            ii(0x14_0a8d, 1); retw(); return;                           /* ret */
        }
    }
}

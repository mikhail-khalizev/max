using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e671fa0f-5e85-43fa-9075-25ea430a8491")]
        public void Method_0015_fb20()
        {
            ii(0x15_fb20, 1); pushw(bp);                                /* push bp */
            ii(0x15_fb21, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x15_fb23, 1); pushw(ds);                                /* push ds */
            ii(0x15_fb24, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_fb27, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_fb29, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fb2c, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_fb2f, 3); callw(0x15_fae5, -0x4d);                  /* call 0xfae5 */
            ii(0x15_fb32, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_fb34, 2); if(jzw(0x15_fb3b, 0x5)) goto l_0x15_fb3b; /* jz 0xfb3b */
            ii(0x15_fb36, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_fb39, 2); jmpw(0x15_fb44, 0x9); goto l_0x15_fb44;   /* jmp 0xfb44 */
        l_0x15_fb3b:
            ii(0x15_fb3b, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_fb3e, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_fb41, 3); callw(0x15_fa6b, -0xd9);                  /* call 0xfa6b */
        l_0x15_fb44:
            ii(0x15_fb44, 1); popw(ds);                                 /* pop ds */
            ii(0x15_fb45, 1); leavew();                                 /* leave */
            ii(0x15_fb46, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}

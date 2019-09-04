using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fb20-159ba0bf")]
        public void Method_0019_fb20()
        {
            ii(0x19_fb20, 1); push(bp);                                 /* push bp */
            ii(0x19_fb21, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_fb23, 1); push(ds);                                 /* push ds */
            ii(0x19_fb24, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_fb27, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_fb29, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_fb2c, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_fb2f, 3); call(0x19_fae5, -0x4d);                   /* call 0xfae5 */
            ii(0x19_fb32, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_fb34, 2); if(jz(0x19_fb3b, 5)) goto l_0x19_fb3b;    /* jz 0xfb3b */
            ii(0x19_fb36, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_fb39, 2); jmp(0x19_fb44, 9); goto l_0x19_fb44;      /* jmp 0xfb44 */
        l_0x19_fb3b:
            ii(0x19_fb3b, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_fb3e, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_fb41, 3); call(0x19_fa6b, -0xd9);                   /* call 0xfa6b */
        l_0x19_fb44:
            ii(0x19_fb44, 1); pop(ds);                                  /* pop ds */
            ii(0x19_fb45, 1); leave();                                  /* leave */
            ii(0x19_fb46, 3); ret(4);                                   /* ret 0x4 */
        }
    }
}

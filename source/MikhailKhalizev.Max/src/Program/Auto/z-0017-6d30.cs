using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("89d2599f-a432-4b75-b790-0c037f0d5fde")]
        public void Method_0017_6d30()
        {
            ii(0x17_6d30, 1); pushw(ds);                                /* push ds */
            ii(0x17_6d31, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_6d34, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_6d36, 1); pushw(ds);                                /* push ds */
            ii(0x17_6d37, 3); pushw(0x3d7);                             /* push 0x3d7 */
            ii(0x17_6d3a, 3); pushw(0x8002);                            /* push 0x8002 */
            ii(0x17_6d3d, 1); nop();                                    /* nop */
            ii(0x17_6d3e, 1); pushw(cs);                                /* push cs */
            ii(0x17_6d3f, 3); callw(0x17_0708, -0x663a);                /* call 0x708 */
            ii(0x17_6d42, 3); mov(memw_a16[ds, 0x5167], ax);            /* mov [0x5167], ax */
            ii(0x17_6d45, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_6d47, 2); if(jgew(0x17_6d57, 0xe)) goto l_0x17_6d57; /* jge 0x6d57 */
            ii(0x17_6d49, 1); pushw(ds);                                /* push ds */
            ii(0x17_6d4a, 3); pushw(0x3e1);                             /* push 0x3e1 */
            ii(0x17_6d4d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_6d4f, 1); nop();                                    /* nop */
            ii(0x17_6d50, 1); pushw(cs);                                /* push cs */
            ii(0x17_6d51, 3); callw(0x17_074a, -0x660a);                /* call 0x74a */
            ii(0x17_6d54, 3); mov(memw_a16[ds, 0x5167], ax);            /* mov [0x5167], ax */
        l_0x17_6d57:
            ii(0x17_6d57, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_6d59, 2); if(jgew(0x17_6d65, 0xa)) goto l_0x17_6d65; /* jge 0x6d65 */
            ii(0x17_6d5b, 3); pushw(0x92e);                             /* push 0x92e */
            ii(0x17_6d5e, 1); pushw(cs);                                /* push cs */
            ii(0x17_6d5f, 3); callw(0x17_75b4, 0x852);                  /* call 0x75b4 */
            ii(0x17_6d62, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x17_6d65:
            ii(0x17_6d65, 1); popw(ds);                                 /* pop ds */
            ii(0x17_6d66, 1); retfw(); return;                          /* retf */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_1e1c-2aeeaad2")]
        public void Method_001a_1e1c()
        {
            ii(0x1a_1e1c, 1); pushd(ds);                                /* push ds */
            ii(0x1a_1e1d, 4); mov(ax, 0x303);                           /* mov ax, 0x303 */
            ii(0x1a_1e21, 4); mov(dx, 0x98);                            /* mov dx, 0x98 */
            ii(0x1a_1e25, 3); mov(ds, dx);                              /* mov ds, dx */
            ii(0x1a_1e28, 5); mov(esi, 0x53);                           /* mov esi, 0x53 */
            ii(0x1a_1e2d, 4); mov(dx, 0xa8);                            /* mov dx, 0xa8 */
            ii(0x1a_1e31, 3); mov(es, dx);                              /* mov es, dx */
            ii(0x1a_1e34, 5); mov(edi, 0x2e0a);                         /* mov edi, 0x2e0a */
            ii(0x1a_1e39, 2); @int(0x31);                               /* int 0x31 */
            ii(0x1a_1e3b, 2); if(jb(0x1a_1e44, 0x7)) goto l_0x1a_1e44;  /* jb 0x1a1e44 */
            ii(0x1a_1e3d, 2); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x1a_1e3f, 3); mov(dx, cx);                              /* mov dx, cx */
            ii(0x1a_1e42, 2); jmp(0x1a_1e4a, 0x6); goto l_0x1a_1e4a;    /* jmp 0x1a1e4a */
        l_0x1a_1e44:
            ii(0x1a_1e44, 3); xor(dx, dx);                              /* xor dx, dx */
            ii(0x1a_1e47, 3); xor(ax, ax);                              /* xor ax, ax */
        l_0x1a_1e4a:
            ii(0x1a_1e4a, 1); popd(ds);                                 /* pop ds */
            ii(0x1a_1e4b, 2); retfw();                                  /* o16 retf */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("81a29005-057a-4cfd-8049-684d8398d370")]
        public void Method_0019_8367()
        {
            ii(0x19_8367, 4); enterw(0, 0);                             /* enter 0x0, 0x0 */
            ii(0x19_836b, 1); pushw(di);                                /* push di */
            ii(0x19_836c, 1); pushw(si);                                /* push si */
            ii(0x19_836d, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_8370, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x19_8373, 3); callw(0x19_105e, -0x7318);                /* call 0x105e */
            ii(0x19_8376, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_8379, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x19_837c, 3); or(ax, memw_a16[ss, bp + 0x8]);           /* or ax, [bp+0x8] */
            ii(0x19_837f, 2); if(jnzw(0x19_8384, 0x3)) goto l_0x19_8384; /* jnz 0x8384 */
            ii(0x19_8381, 3); jmpw(0x19_838a, 0x6); goto l_0x19_838a;   /* jmp 0x838a */
        l_0x19_8384:
            ii(0x19_8384, 3); mov(ax, 0x16ec);                          /* mov ax, 0x16ec */
            ii(0x19_8387, 3); jmpw(0x19_838d, 0x3); goto l_0x19_838d;   /* jmp 0x838d */
        l_0x19_838a:
            ii(0x19_838a, 3); mov(ax, 0x16f0);                          /* mov ax, 0x16f0 */
        l_0x19_838d:
            ii(0x19_838d, 1); pushw(ds);                                /* push ds */
            ii(0x19_838e, 1); pushw(ax);                                /* push ax */
            ii(0x19_838f, 3); callw(0x19_105e, -0x7334);                /* call 0x105e */
            ii(0x19_8392, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x19_8395, 1); popw(si);                                 /* pop si */
            ii(0x19_8396, 1); popw(di);                                 /* pop di */
            ii(0x19_8397, 1); leavew();                                 /* leave */
            ii(0x19_8398, 1); retw(); return;                           /* ret */
        }
    }
}

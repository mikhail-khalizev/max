using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cc05f040-2bfb-49a7-9860-165fc7585acc")]
        public void Method_0014_e7aa()
        {
            ii(0x14_e7aa, 3); callw(0x14_e702, -0xab);                  /* call 0xe702 */
            ii(0x14_e7ad, 3); add(bx, 0xc);                             /* add bx, 0xc */
            ii(0x14_e7b0, 3); add(di, 0xc);                             /* add di, 0xc */
            ii(0x14_e7b3, 2); mov(cl, 0xcd);                            /* mov cl, 0xcd */
            ii(0x14_e7b5, 4); mov(ch, memb_a32[ss, ebp + 0x14]);        /* mov ch, [ebp+0x14] */
            ii(0x14_e7b9, 4); mov(ds, memw_a32[ss, ebp + 0x2]);         /* mov ds, [ebp+0x2] */
            ii(0x14_e7bd, 3); pushw(0x4ccf);                            /* push 0x4ccf */
            ii(0x14_e7c0, 2); if(jmpw_func(0x14_e798, -0x2a)) return;   /* jmp 0xe798 */
        }
    }
}

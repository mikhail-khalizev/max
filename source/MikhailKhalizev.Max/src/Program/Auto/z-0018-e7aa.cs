using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e7aa-b7e4641e")]
        public void Method_0018_e7aa()
        {
            ii(0x18_e7aa, 3); call(0x18_e702, -0xab);                   /* call 0xe702 */
            ii(0x18_e7ad, 3); add(bx, 0xc);                             /* add bx, 0xc */
            ii(0x18_e7b0, 3); add(di, 0xc);                             /* add di, 0xc */
            ii(0x18_e7b3, 2); mov(cl, 0xcd);                            /* mov cl, 0xcd */
            ii(0x18_e7b5, 4); mov(ch, memb_a32[ss, ebp + 20]);          /* mov ch, [ebp+0x14] */
            ii(0x18_e7b9, 4); mov(ds, memw_a32[ss, ebp + 2]);           /* mov ds, [ebp+0x2] */
            ii(0x18_e7bd, 3); push(0x4ccf);                             /* push 0x4ccf */
            ii(0x18_e7c0, 2); if(jmp_func(0x18_e798, -0x2a)) return;    /* jmp 0xe798 */
        }
    }
}

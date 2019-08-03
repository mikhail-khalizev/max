using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45d183a3-217e-4c0a-bee6-60a7879529ba")]
        public void Method_0014_e367()
        {
            ii(0x14_e367, 5); cmp(memb_a32[ss, ebp + 0x14], 0x10);      /* cmp byte [ebp+0x14], 0x10 */
            ii(0x14_e36c, 2); if(jaw(0x14_e392, 0x24)) goto l_0x14_e392; /* ja 0xe392 */
            ii(0x14_e36e, 3); callw(0x14_e868, 0x4f7);                  /* call 0xe868 */
            ii(0x14_e371, 3); callw(0x14_e958, 0x5e4);                  /* call 0xe958 */
            ii(0x14_e374, 4); mov(bl, memb_a32[ss, ebp + 0x14]);        /* mov bl, [ebp+0x14] */
            ii(0x14_e378, 2); xor(bh, bh);                              /* xor bh, bh */
            ii(0x14_e37a, 3); imul(bx, bx, 0x1c);                       /* imul bx, bx, 0x1c */
            ii(0x14_e37d, 5); mov(eax, memd_a16[ds, bx + 0x4229]);      /* mov eax, [bx+0x4229] */
            ii(0x14_e382, 5); mov(memd_a32[ss, ebp + 0x18], eax);       /* mov [ebp+0x18], eax */
            ii(0x14_e387, 4); mov(ax, memw_a16[ds, bx + 0x422d]);       /* mov ax, [bx+0x422d] */
            ii(0x14_e38b, 4); mov(memw_a32[ss, ebp + 0x1c], ax);        /* mov [ebp+0x1c], ax */
            ii(0x14_e38f, 3); jmpw_func(0x14_e067, -0x32b); return;     /* jmp 0xe067 */
        l_0x14_e392:
            ii(0x14_e392, 3); jmpw_func(0x14_e062, -0x333); return;     /* jmp 0xe062 */
        }
    }
}

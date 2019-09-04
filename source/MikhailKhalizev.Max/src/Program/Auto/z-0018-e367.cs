using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e367-962cc992")]
        public void Method_0018_e367()
        {
            ii(0x18_e367, 5);  cmp(memb_a32[ss, ebp + 20], 0x10);      /* cmp byte [ebp+0x14], 0x10 */
            ii(0x18_e36c, 2);  if(ja(0x18_e392, 0x24)) goto l_0x18_e392;/* ja 0xe392 */
            ii(0x18_e36e, 3);  call(0x18_e868, 0x4f7);                 /* call 0xe868 */
            ii(0x18_e371, 3);  call(0x18_e958, 0x5e4);                 /* call 0xe958 */
            ii(0x18_e374, 4);  mov(bl, memb_a32[ss, ebp + 20]);        /* mov bl, [ebp+0x14] */
            ii(0x18_e378, 2);  xor(bh, bh);                            /* xor bh, bh */
            ii(0x18_e37a, 3);  imul(bx, bx, 0x1c);                     /* imul bx, bx, 0x1c */
            ii(0x18_e37d, 5);  mov(eax, memd[ds, bx + 0x4229]);        /* mov eax, [bx+0x4229] */
            ii(0x18_e382, 5);  mov(memd_a32[ss, ebp + 24], eax);       /* mov [ebp+0x18], eax */
            ii(0x18_e387, 4);  mov(ax, memw[ds, bx + 0x422d]);         /* mov ax, [bx+0x422d] */
            ii(0x18_e38b, 4);  mov(memw_a32[ss, ebp + 28], ax);        /* mov [ebp+0x1c], ax */
            ii(0x18_e38f, 3);  if(jmp_func(0x18_e067, -0x32b)) return; /* jmp 0xe067 */
        l_0x18_e392:
            ii(0x18_e392, 3);  if(jmp_func(0x18_e062, -0x333)) return; /* jmp 0xe062 */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ddb2-b138400f")]
        public void Method_100c_ddb2()
        {
            ii(0x100c_ddb2, 7);  mov(bx, memw[ds, 0x101c_59b6]);       /* mov bx, [0x101c59b6] */
            ii(0x100c_ddb9, 5);  mov(ecx, 8);                          /* mov ecx, 0x8 */
            ii(0x100c_ddbe, 1);  clc();                                /* clc */
        l_0x100c_ddbf:
            ii(0x100c_ddbf, 2);  rcl(al, 1);                           /* rcl al, 1 */
            ii(0x100c_ddc1, 3);  rcl(bx, 1);                           /* rcl bx, 1 */
            ii(0x100c_ddc4, 2);  if(jae(0x100c_ddcb, 5)) goto l_0x100c_ddcb;/* jae 0x100cddcb */
            ii(0x100c_ddc6, 5);  xor(bx, 0x1021);                      /* xor bx, 0x1021 */
        l_0x100c_ddcb:
            ii(0x100c_ddcb, 2);  if(loop(0x100c_ddbf, -0xe)) goto l_0x100c_ddbf;/* loop 0x100cddbf */
            ii(0x100c_ddcd, 7);  mov(memw[ds, 0x101c_59b6], bx);       /* mov [0x101c59b6], bx */
            ii(0x100c_ddd4, 1);  ret();                                /* ret */
        }
    }
}

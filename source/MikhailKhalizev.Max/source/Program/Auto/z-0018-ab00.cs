using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_ab00-c495d461")]
        public void Method_0018_ab00()
        {
            ii(0x18_ab00, 3);  cmp(cx, 0x10);                          /* cmp cx, 0x10 */
            ii(0x18_ab03, 2);  if(jae(0x18_ab13, 0xe)) goto l_0x18_ab13;/* jae 0xab13 */
            ii(0x18_ab05, 2);  test(al, 0xf);                          /* test al, 0xf */
            ii(0x18_ab07, 2);  if(jnz(0x18_ab13, 0xa)) goto l_0x18_ab13;/* jnz 0xab13 */
            ii(0x18_ab09, 3);  shr(ax, 4);                             /* shr ax, 0x4 */
            ii(0x18_ab0c, 3);  shl(cl, 4);                             /* shl cl, 0x4 */
            ii(0x18_ab0f, 2);  or(ah, cl);                             /* or ah, cl */
            ii(0x18_ab11, 1);  stc();                                  /* stc */
            ii(0x18_ab12, 1);  ret(); return;                          /* ret */
        l_0x18_ab13:
            ii(0x18_ab13, 3);  mov(ax, memw[ds, 0x9b4]);               /* mov ax, [0x9b4] */
            ii(0x18_ab16, 1);  clc();                                  /* clc */
            ii(0x18_ab17, 1);  ret();                                  /* ret */
        }
    }
}

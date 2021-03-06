using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7ac0-4ace46e2")]
        public void /* sys */ Method_1016_7ac0()
        {
            ii(0x1016_7ac0, 1);  push(edx);                            /* push edx */
            ii(0x1016_7ac1, 7);  cmp(memd[ds, 0x101b_ddbc], 0);        /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7ac8, 2);  if(jz(0x1016_7ad1, 7)) goto l_0x1016_7ad1;/* jz 0x10167ad1 */
            ii(0x1016_7aca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1016_7acc, 5);  call(/* sys */ 0x1016_7d38, 0x267);   /* call 0x10167d38 */
        l_0x1016_7ad1:
            ii(0x1016_7ad1, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_7ad2, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9465-e257f255")]
        public void /* sys */ Method_1017_9465()
        {
            ii(0x1017_9465, 1);  xchg(edx, eax);                       /* xchg edx, eax */
            ii(0x1017_9466, 2);  mov(ah, 0x3d);                        /* mov ah, 0x3d */
            ii(0x1017_9468, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_946a, 2);  if(jb(0x1017_946e, 2)) goto l_0x1017_946e;/* jb 0x1017946e */
            ii(0x1017_946c, 2);  mov(memd[ds, ebx], eax);              /* mov [ebx], eax */
        l_0x1017_946e:
            ii(0x1017_946e, 5);  call(/* sys */ 0x1018_dc28, 0x1_47b5);/* call 0x1018dc28 */
            ii(0x1017_9473, 1);  ret();                                /* ret */
        }
    }
}

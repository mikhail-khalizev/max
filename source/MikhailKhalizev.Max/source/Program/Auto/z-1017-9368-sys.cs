using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9368-9bdc2c57")]
        public void /* sys */ Method_1017_9368()
        {
            ii(0x1017_9368, 1);  push(edx);                            /* push edx */
            ii(0x1017_9369, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_936b, 2);  mov(ah, 0x3b);                        /* mov ah, 0x3b */
            ii(0x1017_936d, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_936f, 2);  rcl(eax, 1);                          /* rcl eax, 1 */
            ii(0x1017_9371, 2);  ror(eax, 1);                          /* ror eax, 1 */
            ii(0x1017_9373, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_9375, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1017_9377, 2);  if(jge(0x1017_9385, 0xc)) goto l_0x1017_9385;/* jge 0x10179385 */
            ii(0x1017_9379, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_937b, 3);  mov(ax, dx);                          /* mov ax, dx */
            ii(0x1017_937e, 5);  call(/* sys */ 0x1018_dbb7, 0x1_4834);/* call 0x1018dbb7 */
            ii(0x1017_9383, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_9384, 1);  ret(); return;                        /* ret */
        l_0x1017_9385:
            ii(0x1017_9385, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1017_9387, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_9388, 1);  ret();                                /* ret */
        }
    }
}

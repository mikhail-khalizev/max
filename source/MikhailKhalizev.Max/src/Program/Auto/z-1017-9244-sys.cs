using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9244-920fc578")]
        public void /* sys */ Method_1017_9244()
        {
            ii(0x1017_9244, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_9245, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1017_9247, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1017_9249, 1);  dec(edx);                             /* dec edx */
            ii(0x1017_924a, 2);  sub(eax, eax);                        /* sub eax, eax */
            ii(0x1017_924c, 2);  mov(ah, 0xe);                         /* mov ah, 0xe */
            ii(0x1017_924e, 2);  @int(0x21);                           /* int 0x21 */
            ii(0x1017_9250, 2);  mov(ah, 0);                           /* mov ah, 0x0 */
            ii(0x1017_9252, 2);  mov(memd[ds, ebx], eax);              /* mov [ebx], eax */
            ii(0x1017_9254, 2);  sub(eax, eax);                        /* sub eax, eax */
            ii(0x1017_9256, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_9257, 1);  ret();                                /* ret */
        }
    }
}

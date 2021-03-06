using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4357-ca8dfb8f")]
        public void /* sys */ Method_1019_4357()
        {
            ii(0x1019_4357, 1);  push(ebp);                            /* push ebp */
            ii(0x1019_4358, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1019_435a, 5);  mov(edx, 0x3da);                      /* mov edx, 0x3da */
            ii(0x1019_435f, 3);  mov(eax, memd[ss, ebp + 8]);          /* mov eax, [ebp+0x8] */
            ii(0x1019_4362, 2);  or(eax, eax);                         /* or eax, eax */
            ii(0x1019_4364, 2);  if(jnz(0x1019_436d, 7)) goto l_0x1019_436d;/* jnz 0x1019436d */
        l_0x1019_4366:
            ii(0x1019_4366, 1);  inb(al, dx);                          /* in al, dx */
            ii(0x1019_4367, 2);  and(al, 8);                           /* and al, 0x8 */
            ii(0x1019_4369, 2);  if(jnz(0x1019_4366, -5)) goto l_0x1019_4366;/* jnz 0x10194366 */
            ii(0x1019_436b, 1);  leave();                              /* leave */
            ii(0x1019_436c, 1);  ret(); return;                        /* ret */
        l_0x1019_436d:
            ii(0x1019_436d, 1);  inb(al, dx);                          /* in al, dx */
            ii(0x1019_436e, 2);  and(al, 8);                           /* and al, 0x8 */
            ii(0x1019_4370, 2);  if(jz(0x1019_436d, -5)) goto l_0x1019_436d;/* jz 0x1019436d */
            ii(0x1019_4372, 1);  leave();                              /* leave */
            ii(0x1019_4373, 1);  ret();                                /* ret */
        }
    }
}

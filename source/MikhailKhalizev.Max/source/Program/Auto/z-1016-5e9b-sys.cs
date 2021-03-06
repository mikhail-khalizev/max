using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5e9b-f51a12ea")]
        public void /* sys */ Method_1016_5e9b()
        {
            ii(0x1016_5e9b, 1);  push(edx);                            /* push edx */
            ii(0x1016_5e9c, 5);  call(/* sys */ 0x1016_5e95, -0xc);    /* call 0x10165e95 */
            ii(0x1016_5ea1, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x1016_5ea3, 2);  if(jz(0x1016_5ebd, 0x18)) goto l_0x1016_5ebd;/* jz 0x10165ebd */
            ii(0x1016_5ea5, 6);  imul(edx, memd[ds, eax], 0x41c6_4e6d);/* imul edx, [eax], 0x41c64e6d */
            ii(0x1016_5eab, 6);  add(edx, 0x3039);                     /* add edx, 0x3039 */
            ii(0x1016_5eb1, 2);  mov(memd[ds, eax], edx);              /* mov [eax], edx */
            ii(0x1016_5eb3, 2);  mov(eax, edx);                        /* mov eax, edx */
            ii(0x1016_5eb5, 3);  shr(eax, 0x10);                       /* shr eax, 0x10 */
            ii(0x1016_5eb8, 5);  and(eax, 0x7fff);                     /* and eax, 0x7fff */
        l_0x1016_5ebd:
            ii(0x1016_5ebd, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_5ebe, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5ecf-72d0ed7")]
        public void /* sys */ sys_strcpy()
        {
            ii(0x1016_5ecf, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_5ed0, 1);  push(eax);                            /* push eax */
        l_0x1016_5ed1:
            ii(0x1016_5ed1, 2);  mov(cl, memb[ds, edx]);               /* mov cl, [edx] */
            ii(0x1016_5ed3, 2);  mov(memb[ds, eax], cl);               /* mov [eax], cl */
            ii(0x1016_5ed5, 3);  cmp(cl, 0);                           /* cmp cl, 0x0 */
            ii(0x1016_5ed8, 2);  if(jz(0x1016_5eeb, 0x11)) goto l_0x1016_5eeb;/* jz 0x10165eeb */
            ii(0x1016_5eda, 3);  mov(cl, memb[ds, edx + 1]);           /* mov cl, [edx+0x1] */
            ii(0x1016_5edd, 3);  add(edx, 2);                          /* add edx, 0x2 */
            ii(0x1016_5ee0, 3);  mov(memb[ds, eax + 1], cl);           /* mov [eax+0x1], cl */
            ii(0x1016_5ee3, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1016_5ee6, 3);  cmp(cl, 0);                           /* cmp cl, 0x0 */
            ii(0x1016_5ee9, 2);  if(jnz(0x1016_5ed1, -0x1a)) goto l_0x1016_5ed1;/* jnz 0x10165ed1 */
        l_0x1016_5eeb:
            ii(0x1016_5eeb, 1);  pop(eax);                             /* pop eax */
            ii(0x1016_5eec, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_5eed, 1);  ret();                                /* ret */
        }
    }
}

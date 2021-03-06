using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_5d50-c8fa56db")]
        public void /* sys */ Method_1018_5d50()
        {
            ii(0x1018_5d50, 1);  push(edx);                            /* push edx */
            ii(0x1018_5d51, 7);  cmp(memd[ds, 0x101b_e850], 0);        /* cmp dword [0x101be850], 0x0 */
            ii(0x1018_5d58, 2);  if(jz(0x1018_5d71, 0x17)) goto l_0x1018_5d71;/* jz 0x10185d71 */
        l_0x1018_5d5a:
            ii(0x1018_5d5a, 5);  mov(eax, memd[ds, 0x101b_e850]);      /* mov eax, [0x101be850] */
            ii(0x1018_5d5f, 3);  mov(edx, memd[ds, eax + 16]);         /* mov edx, [eax+0x10] */
            ii(0x1018_5d62, 5);  call(Definitions.sys_free_internal, -0x3913);/* call 0x10182454 */
            ii(0x1018_5d67, 6);  mov(memd[ds, 0x101b_e850], edx);      /* mov [0x101be850], edx */
            ii(0x1018_5d6d, 2);  test(edx, edx);                       /* test edx, edx */
            ii(0x1018_5d6f, 2);  if(jnz(0x1018_5d5a, -0x17)) goto l_0x1018_5d5a;/* jnz 0x10185d5a */
        l_0x1018_5d71:
            ii(0x1018_5d71, 1);  pop(edx);                             /* pop edx */
            ii(0x1018_5d72, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0f0b-7a08e40d")]
        public void /* sys */ Method_1018_0f0b()
        {
            ii(0x1018_0f0b, 1);  push(ecx);                            /* push ecx */
            ii(0x1018_0f0c, 1);  push(esi);                            /* push esi */
            ii(0x1018_0f0d, 2);  mov(esi, eax);                        /* mov esi, eax */
            ii(0x1018_0f0f, 5);  mov(ecx, /* sys */ 0x1018_0ef8);      /* mov ecx, 0x10180ef8 */
            ii(0x1018_0f14, 5);  call(/* sys */ 0x1018_10e4, 0x1cb);   /* call 0x101810e4 */
            ii(0x1018_0f19, 4);  mov(memb[ds, esi + eax], 0);          /* mov byte [esi+eax], 0x0 */
            ii(0x1018_0f1d, 1);  pop(esi);                             /* pop esi */
            ii(0x1018_0f1e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1018_0f1f, 1);  ret();                                /* ret */
        }
    }
}

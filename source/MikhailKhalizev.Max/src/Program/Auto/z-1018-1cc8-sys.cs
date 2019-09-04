using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1cc8-1b69041d")]
        public void /* sys */ Method_1018_1cc8()
        {
            ii(0x1018_1cc8, 1); push(ebx);                              /* push ebx */
            ii(0x1018_1cc9, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_1ccb, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1018_1cce, 3); mov(eax, memd[ds, eax + 4]);            /* mov eax, [eax+0x4] */
            ii(0x1018_1cd1, 1); dec(edx);                               /* dec edx */
            ii(0x1018_1cd2, 5); call(/* sys */ 0x1018_d304, 0xb62d);    /* call 0x1018d304 */
            ii(0x1018_1cd7, 3); imul(edx, eax);                         /* imul edx, eax */
            ii(0x1018_1cda, 3); mov(eax, memd[ds, ebx + 12]);           /* mov eax, [ebx+0xc] */
            ii(0x1018_1cdd, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1018_1cdf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_1ce0, 1); ret();                                  /* ret */
        }
    }
}

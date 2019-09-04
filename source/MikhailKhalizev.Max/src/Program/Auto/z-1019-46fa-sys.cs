using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_46fa-b942dc21")]
        public void /* sys */ Method_1019_46fa()
        {
            ii(0x1019_46fa, 1); push(ebx);                              /* push ebx */
            ii(0x1019_46fb, 3); or(dh, 0x40);                           /* or dh, 0x40 */
            ii(0x1019_46fe, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1019_4700, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1019_4702, 5); mov(eax, memd[ds, Definitions.ptr_of_fd_table_]); /* mov eax, [0x101c0a24] */
            ii(0x1019_4707, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1019_470a, 3); mov(memd[ds, edx + eax], ebx);          /* mov [edx+eax], ebx */
            ii(0x1019_470d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_470e, 1); ret();                                  /* ret */
        }
    }
}

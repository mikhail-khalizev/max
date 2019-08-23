using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_b4cc-e252076")]
        public void /* sys */ Method_1019_b4cc()
        {
            ii(0x1019_b4cc, 1); push(ebx);                              /* push ebx */
            ii(0x1019_b4cd, 1); push(ecx);                              /* push ecx */
            ii(0x1019_b4ce, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1019_b4d0, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1019_b4d2, 3); shr(eax, 0x3);                          /* shr eax, 0x3 */
            ii(0x1019_b4d5, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1019_b4d7, 3); shl(ecx, 0x3);                          /* shl ecx, 0x3 */
            ii(0x1019_b4da, 2); sub(edx, ecx);                          /* sub edx, ecx */
            ii(0x1019_b4dc, 6); mov(dl, memb[ds, edx + 0x101c_1d00]);   /* mov dl, [edx+0x101c1d00] */
            ii(0x1019_b4e2, 3); and(dl, memb[ds, ebx + eax]);           /* and dl, [ebx+eax] */
            ii(0x1019_b4e5, 2); mov(al, dl);                            /* mov al, dl */
            ii(0x1019_b4e7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_b4e8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1019_b4e9, 1); ret();                                  /* ret */
        }
    }
}

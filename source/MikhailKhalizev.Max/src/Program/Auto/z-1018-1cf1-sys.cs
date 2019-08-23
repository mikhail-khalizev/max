using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1cf1-81c2e1d6")]
        public void /* sys */ Method_1018_1cf1()
        {
            ii(0x1018_1cf1, 1); push(ecx);                              /* push ecx */
            ii(0x1018_1cf2, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1018_1cf4, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1018_1cf6, 7); mov(memd[ds, edx + 0x10], 0x2);         /* mov dword [edx+0x10], 0x2 */
            ii(0x1018_1cfd, 3); mov(memd[ds, edx + 0x14], ebx);         /* mov [edx+0x14], ebx */
            ii(0x1018_1d00, 3); mov(edx, memd[ds, ebx + 0x9]);          /* mov edx, [ebx+0x9] */
            ii(0x1018_1d03, 7); mov(memd[ds, eax + 0x1c], 0);           /* mov dword [eax+0x1c], 0x0 */
            ii(0x1018_1d0a, 3); mov(memd[ds, eax + 0x18], edx);         /* mov [eax+0x18], edx */
            ii(0x1018_1d0d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_1d0f, 3); mov(memd[ds, eax + 0xc], ecx);          /* mov [eax+0xc], ecx */
            ii(0x1018_1d12, 3); add(edx, 0x10);                         /* add edx, 0x10 */
            ii(0x1018_1d15, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1018_1d17, 3); mov(memd[ds, eax + 0x4], edx);          /* mov [eax+0x4], edx */
            ii(0x1018_1d1a, 5); call(/* sys */ 0x1018_d348, 0xb629);    /* call 0x1018d348 */
            ii(0x1018_1d1f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_1d20, 1); ret();                                  /* ret */
        }
    }
}

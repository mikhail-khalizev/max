using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b346a1c-1207-4571-a4bb-754f2c1d6071")]
        public void /* sys */ Method_1017_90c5()
        {
            ii(0x1017_90c5, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_90c8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_90c9, 1); popd(edi);                              /* pop edi */
            ii(0x1017_90ca, 1); popd(esi);                              /* pop esi */
            ii(0x1017_90cb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_90cc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_90cd, 1); retd(); return;                         /* ret */
        }
    }
}
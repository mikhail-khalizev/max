using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_0ef8-95556738")]
        public void /* sys */ Method_1018_0ef8()
        {
            ii(0x1018_0ef8, 1); push(ebx);                              /* push ebx */
            ii(0x1018_0ef9, 1); push(ecx);                              /* push ecx */
            ii(0x1018_0efa, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1018_0efc, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1018_0efe, 3); lea(ecx, memd[ds, edx + 1]);            /* lea ecx, [edx+0x1] */
            ii(0x1018_0f01, 2); mov(memd[ds, eax], ecx);                /* mov [eax], ecx */
            ii(0x1018_0f03, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1018_0f05, 3); inc(memd[ds, eax + 0x10]);              /* inc dword [eax+0x10] */
            ii(0x1018_0f08, 1); pop(ecx);                               /* pop ecx */
            ii(0x1018_0f09, 1); pop(ebx);                               /* pop ebx */
            ii(0x1018_0f0a, 1); ret();                                  /* ret */
        }
    }
}

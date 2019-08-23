using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5eee-95556738")]
        public void /* sys */ Method_1016_5eee()
        {
            ii(0x1016_5eee, 1); push(ebx);                              /* push ebx */
            ii(0x1016_5eef, 1); push(ecx);                              /* push ecx */
            ii(0x1016_5ef0, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1016_5ef2, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1016_5ef4, 3); lea(ecx, edx + 0x1);                    /* lea ecx, [edx+0x1] */
            ii(0x1016_5ef7, 2); mov(memd[ds, eax], ecx);                /* mov [eax], ecx */
            ii(0x1016_5ef9, 2); mov(memb[ds, edx], bl);                 /* mov [edx], bl */
            ii(0x1016_5efb, 3); inc(memd[ds, eax + 0x10]);              /* inc dword [eax+0x10] */
            ii(0x1016_5efe, 1); pop(ecx);                               /* pop ecx */
            ii(0x1016_5eff, 1); pop(ebx);                               /* pop ebx */
            ii(0x1016_5f00, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9690-aa3d237f")]
        public void /* sys */ Method_1017_9690()
        {
            ii(0x1017_9690, 1); inc(ebp);                               /* inc ebp */
            ii(0x1017_9691, 1); push(ebp);                              /* push ebp */
            ii(0x1017_9692, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9694, 1); push(ebx);                              /* push ebx */
            ii(0x1017_9695, 1); push(ecx);                              /* push ecx */
            ii(0x1017_9696, 1); push(edx);                              /* push edx */
            ii(0x1017_9697, 5); call(Definitions.sys_timer_1, 0x1_45a0); /* call 0x1018dc3c */
            ii(0x1017_969c, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1017_969f, 1); pop(edx);                               /* pop edx */
            ii(0x1017_96a0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_96a1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_96a2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_96a3, 1); dec(ebp);                               /* dec ebp */
            ii(0x1017_96a4, 1); retf();                                 /* retf */
        }
    }
}

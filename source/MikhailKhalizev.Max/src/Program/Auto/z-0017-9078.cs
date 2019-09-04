using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_9078-a3c6345b")]
        public void Method_0017_9078()
        {
            ii(0x17_9078, 1);  cli();                                  /* cli */
            ii(0x17_9079, 2);  push(eax);                              /* push eax */
            ii(0x17_907b, 3);  mov(eax, cr0);                          /* mov eax, cr0 */
            ii(0x17_907e, 6);  or(eax, 0x8000_0000);                   /* or eax, 0x80000000 */
            ii(0x17_9084, 3);  mov(cr0, eax);                          /* mov cr0, eax */
            ii(0x17_9087, 2);  pop(eax);                               /* pop eax */
            ii(0x17_9089, 1);  sti();                                  /* sti */
            ii(0x17_908a, 1);  retf();                                 /* retf */
        }
    }
}

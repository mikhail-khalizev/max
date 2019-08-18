using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("02d5a27d-1fb3-4aa0-ae75-0e3ef3a933b6")]
        public void /* sys */ Method_1018_dc98()
        {
            ii(0x1018_dc98, 1); cli();                                  /* cli */
            ii(0x1018_dc99, 2); inb(al, 0x61);                          /* in al, 0x61 */
            ii(0x1018_dc9b, 2); and(al, 0xfc);                          /* and al, 0xfc */
            ii(0x1018_dc9d, 2); outb(0x61, al);                         /* out 0x61, al */
            ii(0x1018_dc9f, 2); mov(al, 0xb4);                          /* mov al, 0xb4 */
            ii(0x1018_dca1, 2); outb(0x43, al);                         /* out 0x43, al */
            ii(0x1018_dca3, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1018_dca5, 2); outb(0x42, al);                         /* out 0x42, al */
            ii(0x1018_dca7, 2); outb(0x42, al);                         /* out 0x42, al */
            ii(0x1018_dca9, 2); inb(al, 0x61);                          /* in al, 0x61 */
            ii(0x1018_dcab, 2); or(al, 0x1);                            /* or al, 0x1 */
            ii(0x1018_dcad, 2); outb(0x61, al);                         /* out 0x61, al */
            ii(0x1018_dcaf, 9); mov(memw_a32[ds, 0x1020_9dd0], 0xffff); /* mov word [0x10209dd0], 0xffff */
            ii(0x1018_dcb8, 5); mov(eax, memd_a32[ds, 0x1020_9dc0]);    /* mov eax, [0x10209dc0] */
            ii(0x1018_dcbd, 5); mov(memd_a32[ds, 0x101b_e420], eax);    /* mov [0x101be420], eax */
            ii(0x1018_dcc2, 1); sti();                                  /* sti */
            ii(0x1018_dcc3, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_9425-550431af")]
        public void Method_1028_9425()
        {
            ii(0x1028_9425, 6); mov(memw_a32[ds, 0x151], ax);           /* mov [0x151], ax */
            ii(0x1028_942b, 7); mov(dx, memw_a32[ds, 0x135]);           /* mov dx, [0x135] */
            ii(0x1028_9432, 4); add(dx, 0xc);                           /* add dx, 0xc */
            ii(0x1028_9436, 5); calld(0x1028_95e8, 0x1ad);              /* call 0x102895e8 */
            ii(0x1028_943b, 2); mov(al, 0x41);                          /* mov al, 0x41 */
            ii(0x1028_943d, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_943e, 5); calld(0x1028_95e8, 0x1a5);              /* call 0x102895e8 */
            ii(0x1028_9443, 6); mov(ax, memw_a32[ds, 0x151]);           /* mov ax, [0x151] */
            ii(0x1028_9449, 2); xchg(al, ah);                           /* xchg al, ah */
            ii(0x1028_944b, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_944c, 5); calld(0x1028_95e8, 0x197);              /* call 0x102895e8 */
            ii(0x1028_9451, 2); xchg(al, ah);                           /* xchg al, ah */
            ii(0x1028_9453, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9454, 1); retd(); return;                         /* ret */
        }
    }
}

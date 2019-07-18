using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2d924b89-2412-4825-a580-058f8a7458cd")]
        public void Method_0000_a264()
        {
            ii(0xa264, 3);    mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0xa267, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xa269, 2);    cmp(al, -0x80 /* 0x80 */);                /* cmp al, 0x80 */
            ii(0xa26b, 2);    if(jzw(0xa26f, 0x2)) goto l_0xa26f;       /* jz 0xa26f */
            ii(0xa26d, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0xa26f:
            ii(0xa26f, 4);    or(memb_a16[ds, 0x36], al);               /* or [0x36], al */
            ii(0xa273, 1);    retw(); return;                           /* ret */
        }
    }
}

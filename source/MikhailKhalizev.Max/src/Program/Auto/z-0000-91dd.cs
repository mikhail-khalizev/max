using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8b6f2730-fb90-4be8-a69f-45348d0a0af0")]
        public void Method_0000_91dd()
        {
            ii(0x91dd, 1);    popw(bx);                                 /* pop bx */
            ii(0x91de, 1);    popw(bx);                                 /* pop bx */
            ii(0x91df, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x91e1, 2);    jzw_func(0x920f, 0x2c);                   /* jz 0x920f */
            ii(0x91e3, 3);    mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x91e6, 3);    mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x91e9, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x91ec, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x91ef, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x91f2, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x91f5, 2);    jmpw_func(0x91b8, -0x3f); return;         /* jmp 0x91b8 */
        }
    }
}

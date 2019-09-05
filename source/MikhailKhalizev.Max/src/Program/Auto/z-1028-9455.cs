using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_9455-75744c88")]
        public void Method_1028_9455()
        {
            ii(0x1028_9455, 6);  mov(memw[ds, 0x153], ax);             /* mov [0x153], ax */
            ii(0x1028_945b, 4);  cmp(ax, 4);                           /* cmp ax, 0x4 */
            ii(0x1028_945f, 6);  if(jnz(0x1028_947c, 0x17)) goto l_0x1028_947c;/* jnz 0x1028947c */
            ii(0x1028_9465, 9);  mov(memw[ds, 0x155], 1);              /* mov word [0x155], 0x1 */
            ii(0x1028_946e, 9);  mov(memw[ds, 0x161], 0x24);           /* mov word [0x161], 0x24 */
            ii(0x1028_9477, 2);  jmp(0x1028_948e, 0x15); goto l_0x1028_948e;/* jmp 0x1028948e */
        //  ii(0x1028_9479, 3);  Недостижимый код.
        l_0x1028_947c:
            ii(0x1028_947c, 9);  mov(memw[ds, 0x155], 1);              /* mov word [0x155], 0x1 */
            ii(0x1028_9485, 9);  mov(memw[ds, 0x161], 0x14);           /* mov word [0x161], 0x14 */
        l_0x1028_948e:
            ii(0x1028_948e, 1);  ret();                                /* ret */
        }
    }
}

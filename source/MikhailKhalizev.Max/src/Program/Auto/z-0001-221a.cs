using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_221a-d38c80cc")]
        public void Method_0001_221a()
        {
            ii(0x1_221a, 3);  callw(0x1_2040, -0x1dd);                  /* call 0x2040 */
            ii(0x1_221d, 2);  if(jbw_func(0x1_2283, 0x64)) return;      /* jb 0x2283 */
            ii(0x1_221f, 2);  if(jcxzw_func(0x1_2283, 0x62)) return;    /* jcxz 0x2283 */
            ii(0x1_2221, 4);  mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x1_2225, 3);  mov(memw_a16[ds, bx + 0x2], ax);          /* mov [bx+0x2], ax */
            ii(0x1_2228, 4);  mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x1_222c, 3);  mov(memb_a16[ds, bx + 0x4], al);          /* mov [bx+0x4], al */
            ii(0x1_222f, 3);  mov(memb_a16[ds, bx + 0x7], ah);          /* mov [bx+0x7], ah */
            ii(0x1_2232, 3);  if(jmpw_func(0x1_2037, -0x1fe)) return;   /* jmp 0x2037 */
        }
    }
}

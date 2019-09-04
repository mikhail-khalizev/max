using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1_020a-d38c80cc")]
        public void Method_0001_020a()
        {
            ii(0x1_020a, 3);  call(0x1_0030, -0x1dd);                  /* call 0x30 */
            ii(0x1_020d, 2);  if(jb_func(0x1_0273, 0x64)) return;      /* jb 0x273 */
            ii(0x1_020f, 2);  if(jcxz_func(0x1_0273, 0x62)) return;    /* jcxz 0x273 */
            ii(0x1_0211, 4);  mov(ax, memw_a32[ss, ebp + 24]);         /* mov ax, [ebp+0x18] */
            ii(0x1_0215, 3);  mov(memw[ds, bx + 2], ax);               /* mov [bx+0x2], ax */
            ii(0x1_0218, 4);  mov(ax, memw_a32[ss, ebp + 28]);         /* mov ax, [ebp+0x1c] */
            ii(0x1_021c, 3);  mov(memb[ds, bx + 4], al);               /* mov [bx+0x4], al */
            ii(0x1_021f, 3);  mov(memb[ds, bx + 7], ah);               /* mov [bx+0x7], ah */
            ii(0x1_0222, 3);  if(jmp_func(0x1_0027, -0x1fe)) return;   /* jmp 0x27 */
        }
    }
}

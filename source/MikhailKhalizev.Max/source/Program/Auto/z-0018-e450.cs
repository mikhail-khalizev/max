using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e450-3a563108")]
        public void Method_0018_e450()
        {
            ii(0x18_e450, 4);  inc(memb[ds, 0x1182]);                  /* inc byte [0x1182] */
            ii(0x18_e454, 2);  push(edi);                              /* push edi */
            ii(0x18_e456, 3);  call(0x18_dd10, -0x749);                /* call 0xdd10 */
            ii(0x18_e459, 2);  pushfd();                               /* pushfd */
            ii(0x18_e45b, 2);  pushd(cs);                              /* o32 push cs */
            ii(0x18_e45d, 2);  push(0);                                /* push 0x0 */
            ii(0x18_e45f, 3);  call(0x18_a7be, -0x3ca4);               /* call 0xa7be */
            ii(0x18_e462, 6);  lss(esp, memd[ds, 0xc18]);              /* lss esp, [0xc18] */
            ii(0x18_e468, 1);  pushfw();                               /* pushfw */
            ii(0x18_e469, 6);  add(memw[ds, 0x996], 0x180);            /* add word [0x996], 0x180 */
            ii(0x18_e46f, 1);  popfw();                                /* popfw */
            ii(0x18_e470, 4);  pop(memw[ds, 0xc1c]);                   /* pop word [0xc1c] */
            ii(0x18_e474, 5);  pop(memd[ds, 0xc18]);                   /* pop dword [0xc18] */
            ii(0x18_e479, 2);  pop(edi);                               /* pop edi */
            ii(0x18_e47b, 4);  dec(memb[ds, 0x1182]);                  /* dec byte [0x1182] */
            ii(0x18_e47f, 1);  ret();                                  /* ret */
        }
    }
}

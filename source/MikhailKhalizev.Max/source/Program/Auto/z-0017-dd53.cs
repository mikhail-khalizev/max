using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dd53-322211ee")]
        public void Method_0017_dd53()
        {
            ii(0x17_dd53, 2);  cmp(al, 0x61);                          /* cmp al, 0x61 */
            ii(0x17_dd55, 2);  if(jb(0x17_dd59, 2)) goto l_0x17_dd59;  /* jb 0xdd59 */
            ii(0x17_dd57, 2);  and(al, 0xdf);                          /* and al, 0xdf */
        l_0x17_dd59:
            ii(0x17_dd59, 2);  sub(al, 0x30);                          /* sub al, 0x30 */
            ii(0x17_dd5b, 2);  if(jb(0x17_dd6a, 0xd)) goto l_0x17_dd6a;/* jb 0xdd6a */
            ii(0x17_dd5d, 2);  cmp(al, 0xa);                           /* cmp al, 0xa */
            ii(0x17_dd5f, 2);  if(jb(0x17_dd69, 8)) goto l_0x17_dd69;  /* jb 0xdd69 */
            ii(0x17_dd61, 2);  cmp(al, 0x11);                          /* cmp al, 0x11 */
            ii(0x17_dd63, 2);  if(jb(0x17_dd6a, 5)) goto l_0x17_dd6a;  /* jb 0xdd6a */
            ii(0x17_dd65, 2);  sub(al, 7);                             /* sub al, 0x7 */
            ii(0x17_dd67, 2);  cmp(al, 0x24);                          /* cmp al, 0x24 */
        l_0x17_dd69:
            ii(0x17_dd69, 1);  cmc();                                  /* cmc */
        l_0x17_dd6a:
            ii(0x17_dd6a, 1);  cbw();                                  /* cbw */
            ii(0x17_dd6b, 1);  ret();                                  /* ret */
        }
    }
}

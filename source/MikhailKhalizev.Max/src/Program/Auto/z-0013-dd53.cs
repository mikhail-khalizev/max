using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2b6692ab-f6fd-4d44-bca9-d1c93e4b29a7")]
        public void Method_0013_dd53()
        {
            ii(0x13_dd53, 2); cmp(al, 0x61);                            /* cmp al, 0x61 */
            ii(0x13_dd55, 2); if(jbw(0x13_dd59, 0x2)) goto l_0x13_dd59; /* jb 0xdd59 */
            ii(0x13_dd57, 2); and(al, 0xdf);                            /* and al, 0xdf */
        l_0x13_dd59:
            ii(0x13_dd59, 2); sub(al, 0x30);                            /* sub al, 0x30 */
            ii(0x13_dd5b, 2); if(jbw(0x13_dd6a, 0xd)) goto l_0x13_dd6a; /* jb 0xdd6a */
            ii(0x13_dd5d, 2); cmp(al, 0xa);                             /* cmp al, 0xa */
            ii(0x13_dd5f, 2); if(jbw(0x13_dd69, 0x8)) goto l_0x13_dd69; /* jb 0xdd69 */
            ii(0x13_dd61, 2); cmp(al, 0x11);                            /* cmp al, 0x11 */
            ii(0x13_dd63, 2); if(jbw(0x13_dd6a, 0x5)) goto l_0x13_dd6a; /* jb 0xdd6a */
            ii(0x13_dd65, 2); sub(al, 0x7);                             /* sub al, 0x7 */
            ii(0x13_dd67, 2); cmp(al, 0x24);                            /* cmp al, 0x24 */
        l_0x13_dd69:
            ii(0x13_dd69, 1); cmc();                                    /* cmc */
        l_0x13_dd6a:
            ii(0x13_dd6a, 1); cbw();                                    /* cbw */
            ii(0x13_dd6b, 1); retw(); return;                           /* ret */
        }
    }
}

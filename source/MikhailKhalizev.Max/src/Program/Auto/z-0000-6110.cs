using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("339c4056-3355-4149-ac94-f1bed3cb365d")]
        public void Method_0000_6110()
        {
            ii(0x6110, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x6112, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x6114, 3);    mov(bx, 0x1a2);                           /* mov bx, 0x1a2 */
            ii(0x6117, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x6119, 3);    mov(si, 0xf56);                           /* mov si, 0xf56 */
            ii(0x611c, 3);    mov(di, 0x467);                           /* mov di, 0x467 */
            ii(0x611f, 1);    cld();                                    /* cld */
            ii(0x6120, 1);    movsw_a16();                              /* movsw */
            ii(0x6121, 1);    movsw_a16();                              /* movsw */
            ii(0x6122, 3);    mov(di, 0x3e0);                           /* mov di, 0x3e0 */
            ii(0x6125, 3);    mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x6128, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x612a, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x612c, 1);    retw(); return;                           /* ret */
        }
    }
}

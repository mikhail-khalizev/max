using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b9e1102-d5b0-49d0-9f0d-55bb23eba9f2")]
        public void Method_0018_e2df()
        {
            ii(0x18_e2df, 3); callw(0x18_e070, -0x272);                 /* call 0xe070 */
            ii(0x18_e2e2, 2); if(jcxzw_func(0x18_e2b3, -0x31)) return;  /* jcxz 0xe2b3 */
            ii(0x18_e2e4, 3); mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x18_e2e7, 1); pushw(bx);                                /* push bx */
            ii(0x18_e2e8, 3); callw(0x18_e0b4, -0x237);                 /* call 0xe0b4 */
            ii(0x18_e2eb, 1); popw(si);                                 /* pop si */
            ii(0x18_e2ec, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x18_e2ee, 1); pushw(ds);                                /* push ds */
            ii(0x18_e2ef, 1); popw(es);                                 /* pop es */
            ii(0x18_e2f0, 1); movsw_a16();                              /* movsw */
            ii(0x18_e2f1, 1); movsw_a16();                              /* movsw */
            ii(0x18_e2f2, 1); lodsw_a16();                              /* lodsw */
            ii(0x18_e2f3, 3); and(ah, 0xe0);                            /* and ah, 0xe0 */
            ii(0x18_e2f6, 3); or(ah, 0x12);                             /* or ah, 0x12 */
            ii(0x18_e2f9, 1); stosw_a16();                              /* stosw */
            ii(0x18_e2fa, 1); movsw_a16();                              /* movsw */
            ii(0x18_e2fb, 3); if(jmpw_func(0x18_e067, -0x297)) return;  /* jmp 0xe067 */
        }
    }
}

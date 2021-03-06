using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x49ad-606e9c47")]
        public void Method_0000_49ad()
        {
            ii(0x49ad, 1);  cli();                                     /* cli */
            ii(0x49ae, 2);  xor(cx, cx);                               /* xor cx, cx */
            ii(0x49b0, 1);  push(ds);                                  /* push ds */
            ii(0x49b1, 2);  mov(ds, cx);                               /* mov ds, cx */
            ii(0x49b3, 1);  push(si);                                  /* push si */
            ii(0x49b4, 3);  mov(si, 0x20);                             /* mov si, 0x20 */
            ii(0x49b7, 1);  dec(cx);                                   /* dec cx */
            ii(0x49b8, 2);  mov(es, cx);                               /* mov es, cx */
            ii(0x49ba, 1);  push(di);                                  /* push di */
            ii(0x49bb, 3);  mov(di, 0x30);                             /* mov di, 0x30 */
            ii(0x49be, 1);  cld();                                     /* cld */
            ii(0x49bf, 3);  mov(cx, 4);                                /* mov cx, 0x4 */
            ii(0x49c2, 2);  repe(() => cmpsw());                       /* repe cmpsw */
            ii(0x49c4, 1);  pop(di);                                   /* pop di */
            ii(0x49c5, 1);  pop(si);                                   /* pop si */
            ii(0x49c6, 1);  pop(ds);                                   /* pop ds */
            ii(0x49c7, 1);  ret();                                     /* ret */
        }
    }
}

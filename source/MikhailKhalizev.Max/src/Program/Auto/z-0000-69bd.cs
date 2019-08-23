using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x69bd-606e9c47")]
        public void Method_0000_69bd()
        {
            ii(0x69bd, 1);    cli();                                    /* cli */
            ii(0x69be, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x69c0, 1);    push(ds);                                 /* push ds */
            ii(0x69c1, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x69c3, 1);    push(si);                                 /* push si */
            ii(0x69c4, 3);    mov(si, 0x20);                            /* mov si, 0x20 */
            ii(0x69c7, 1);    dec(cx);                                  /* dec cx */
            ii(0x69c8, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x69ca, 1);    push(di);                                 /* push di */
            ii(0x69cb, 3);    mov(di, 0x30);                            /* mov di, 0x30 */
            ii(0x69ce, 1);    cld();                                    /* cld */
            ii(0x69cf, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
            ii(0x69d2, 2);    repe(() => cmpsw());                      /* repe cmpsw */
            ii(0x69d4, 1);    pop(di);                                  /* pop di */
            ii(0x69d5, 1);    pop(si);                                  /* pop si */
            ii(0x69d6, 1);    pop(ds);                                  /* pop ds */
            ii(0x69d7, 1);    ret();                                    /* ret */
        }
    }
}

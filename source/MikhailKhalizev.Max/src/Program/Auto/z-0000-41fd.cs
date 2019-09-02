using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x41fd-606e9c47")]
        public void Method_0000_41fd()
        {
            ii(0x41fd, 1);    cli();                                    /* cli */
            ii(0x41fe, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x4200, 1);    push(ds);                                 /* push ds */
            ii(0x4201, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x4203, 1);    push(si);                                 /* push si */
            ii(0x4204, 3);    mov(si, 0x20);                            /* mov si, 0x20 */
            ii(0x4207, 1);    dec(cx);                                  /* dec cx */
            ii(0x4208, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x420a, 1);    push(di);                                 /* push di */
            ii(0x420b, 3);    mov(di, 0x30);                            /* mov di, 0x30 */
            ii(0x420e, 1);    cld();                                    /* cld */
            ii(0x420f, 3);    mov(cx, 4);                               /* mov cx, 0x4 */
            ii(0x4212, 2);    repe(() => cmpsw());                      /* repe cmpsw */
            ii(0x4214, 1);    pop(di);                                  /* pop di */
            ii(0x4215, 1);    pop(si);                                  /* pop si */
            ii(0x4216, 1);    pop(ds);                                  /* pop ds */
            ii(0x4217, 1);    ret();                                    /* ret */
        }
    }
}

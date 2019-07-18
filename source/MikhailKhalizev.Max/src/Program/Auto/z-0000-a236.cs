using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7c6ec44f-2887-4ad5-a811-5585086751fa")]
        public void Method_0000_a236()
        {
            ii(0xa236, 3);    mov(es, memw_a16[ss, bp + 0x2]);          /* mov es, [bp+0x2] */
            ii(0xa239, 3);    mov(di, memw_a16[ss, bp + 0xe]);          /* mov di, [bp+0xe] */
            ii(0xa23c, 1);    dec(di);                                  /* dec di */
            ii(0xa23d, 1);    dec(di);                                  /* dec di */
            ii(0xa23e, 3);    lea(si, bp + 0x26);                       /* lea si, [bp+0x26] */
            ii(0xa241, 1);    pushw(ss);                                /* push ss */
            ii(0xa242, 1);    popw(ds);                                 /* pop ds */
            ii(0xa243, 1);    std();                                    /* std */
            ii(0xa244, 3);    mov(cx, 0x15);                            /* mov cx, 0x15 */
            ii(0xa247, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0xa249, 2);    mov(ax, es);                              /* mov ax, es */
            ii(0xa24b, 2);    mov(ss, ax);                              /* mov ss, ax */
            ii(0xa24d, 2);    mov(sp, di);                              /* mov sp, di */
            ii(0xa24f, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xa252, 1);    popw(ds);                                 /* pop ds */
            ii(0xa253, 1);    popw(es);                                 /* pop es */
            ii(0xa254, 1);    popa();                                   /* popa */
            ii(0xa255, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xa258, 2);    iretd(); return;                          /* iretd */
        }
    }
}

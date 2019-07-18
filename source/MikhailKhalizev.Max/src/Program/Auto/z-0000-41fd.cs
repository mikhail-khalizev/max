using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cd6fe36c-0032-4090-88fc-fc8631489342")]
        public void Method_0000_41fd()
        {
            ii(0x41fd, 1);    cli();                                    /* cli */
            ii(0x41fe, 2);    xor(cx, cx);                              /* xor cx, cx */
            ii(0x4200, 1);    pushw(ds);                                /* push ds */
            ii(0x4201, 2);    mov(ds, cx);                              /* mov ds, cx */
            ii(0x4203, 1);    pushw(si);                                /* push si */
            ii(0x4204, 3);    mov(si, 0x20);                            /* mov si, 0x20 */
            ii(0x4207, 1);    dec(cx);                                  /* dec cx */
            ii(0x4208, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0x420a, 1);    pushw(di);                                /* push di */
            ii(0x420b, 3);    mov(di, 0x30);                            /* mov di, 0x30 */
            ii(0x420e, 1);    cld();                                    /* cld */
            ii(0x420f, 3);    mov(cx, 0x4);                             /* mov cx, 0x4 */
            ii(0x4212, 2);    repe_a16(() => cmpsw_a16());              /* repe cmpsw */
            ii(0x4214, 1);    popw(di);                                 /* pop di */
            ii(0x4215, 1);    popw(si);                                 /* pop si */
            ii(0x4216, 1);    popw(ds);                                 /* pop ds */
            ii(0x4217, 1);    retw(); return;                           /* ret */
        }
    }
}

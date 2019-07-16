using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4fe82f83-e92c-44f5-8c71-ecd1bdfc08af")]
        public void Method_0000_4812()
        {
            ii(0x4812, 1);    pushw(bp);                                /* push bp */
            ii(0x4813, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x4815, 1);    pushw(si);                                /* push si */
            ii(0x4816, 1);    pushw(di);                                /* push di */
            ii(0x4817, 3);    callw(0x3880, -0xf9a);                    /* call 0x3880 */
            ii(0x481a, 2);    pushw(0x60);                              /* push 0x60 */
            ii(0x481c, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x481f, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x4821, 1);    popw(es);                                 /* pop es */
            ii(0x4822, 4);    mov(memw_a16[es, 0x62], ax);              /* mov [es:0x62], ax */
            ii(0x4826, 3);    mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x4829, 4);    mov(memb_a16[es, 0x64], al);              /* mov [es:0x64], al */
            ii(0x482d, 5);    mov(memb_a16[es, 0x67], ah);              /* mov [es:0x67], ah */
            ii(0x4832, 1);    popw(es);                                 /* pop es */
            ii(0x4833, 2);    xor(di, di);                              /* xor di, di */
            ii(0x4835, 3);    mov(si, memw_a16[ss, bp + 0x8]);          /* mov si, [bp+0x8] */
            ii(0x4838, 3);    mov(cx, memw_a16[ss, bp + 0xa]);          /* mov cx, [bp+0xa] */
            ii(0x483b, 1);    cld();                                    /* cld */
            ii(0x483c, 2);    shr(cx, 0x1);                             /* shr cx, 1 */
            ii(0x483e, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x4840, 2);    rcl(cx, 0x1);                             /* rcl cx, 1 */
            ii(0x4842, 2);    rep_a16(() => movsb_a16());               /* rep movsb */
            ii(0x4844, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x4846, 1);    popw(es);                                 /* pop es */
            ii(0x4847, 5);    mov(memw_a16[es, 0x66], cx);              /* mov [es:0x66], cx */
            ii(0x484c, 3);    callw(0x3f19, -0x936);                    /* call 0x3f19 */
            ii(0x484f, 1);    popw(di);                                 /* pop di */
            ii(0x4850, 1);    popw(si);                                 /* pop si */
            ii(0x4851, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x4853, 1);    popw(bp);                                 /* pop bp */
            ii(0x4854, 1);    sti();                                    /* sti */
            ii(0x4855, 1);    retw();                                   /* ret */
        }
    }
}

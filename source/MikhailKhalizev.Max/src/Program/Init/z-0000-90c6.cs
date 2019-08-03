using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("25939aea-cea4-4a17-b08a-855f9449c94f")]
        public void Method_0000_90c6()
        {
            ii(0x90c6, 1);    pushw(si);                                /* push si */
            ii(0x90c7, 4);    mov(si, memw_a16[ds, 0x1188]);            /* mov si, [0x1188] */
            ii(0x90cb, 2);    inc(memw_a16[ds, si]);                    /* inc word [si] */
            ii(0x90cd, 2);    mov(ax, memw_a16[ds, si]);                /* mov ax, [si] */
            ii(0x90cf, 3);    cmp(memw_a16[ds, si + 0x2], ax);          /* cmp [si+0x2], ax */
            ii(0x90d2, 2);    if(jaw(0x90f1, 0x1d)) goto l_0x90f1;      /* ja 0x90f1 */
            ii(0x90d4, 3);    mov(ax, 0x100);                           /* mov ax, 0x100 */
            ii(0x90d7, 1);    pushw(ax);                                /* push ax */
            ii(0x90d8, 3);    lea(ax, si + 0x4);                        /* lea ax, [si+0x4] */
            ii(0x90db, 1);    pushw(ax);                                /* push ax */
            ii(0x90dc, 3);    callw(0x95d2, 0x4f3);                     /* call 0x95d2 */
            ii(0x90df, 1);    popw(bx);                                 /* pop bx */
            ii(0x90e0, 1);    popw(bx);                                 /* pop bx */
            ii(0x90e1, 3);    mov(memw_a16[ds, si + 0x2], ax);          /* mov [si+0x2], ax */
            ii(0x90e4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x90e6, 2);    if(jgw(0x90ed, 0x5)) goto l_0x90ed;       /* jg 0x90ed */
            ii(0x90e8, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x90eb, 1);    popw(si);                                 /* pop si */
            ii(0x90ec, 1);    retw(); return;                           /* ret */
        l_0x90ed:
            ii(0x90ed, 4);    mov(memw_a16[ds, si], 0);                 /* mov word [si], 0x0 */
        l_0x90f1:
            ii(0x90f1, 2);    mov(bx, memw_a16[ds, si]);                /* mov bx, [si] */
            ii(0x90f3, 3);    mov(al, memb_a16[ds, bx + si + 0x4]);     /* mov al, [bx+si+0x4] */
            ii(0x90f6, 1);    cbw();                                    /* cbw */
            ii(0x90f7, 1);    popw(si);                                 /* pop si */
            ii(0x90f8, 1);    retw(); return;                           /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x90c6-6b4e6fec")]
        public void Method_0000_90c6()
        {
            ii(0x90c6, 1);    push(si);                                 /* push si */
            ii(0x90c7, 4);    mov(si, memw[ds, 0x1188]);                /* mov si, [0x1188] */
            ii(0x90cb, 2);    inc(memw[ds, si]);                        /* inc word [si] */
            ii(0x90cd, 2);    mov(ax, memw[ds, si]);                    /* mov ax, [si] */
            ii(0x90cf, 3);    cmp(memw[ds, si + 2], ax);                /* cmp [si+0x2], ax */
            ii(0x90d2, 2);    if(ja(0x90f1, 0x1d)) goto l_0x90f1;       /* ja 0x90f1 */
            ii(0x90d4, 3);    mov(ax, 0x100);                           /* mov ax, 0x100 */
            ii(0x90d7, 1);    push(ax);                                 /* push ax */
            ii(0x90d8, 3);    lea(ax, memw[ds, si + 4]);                /* lea ax, [si+0x4] */
            ii(0x90db, 1);    push(ax);                                 /* push ax */
            ii(0x90dc, 3);    call(0x95d2, 0x4f3);                      /* call 0x95d2 */
            ii(0x90df, 1);    pop(bx);                                  /* pop bx */
            ii(0x90e0, 1);    pop(bx);                                  /* pop bx */
            ii(0x90e1, 3);    mov(memw[ds, si + 2], ax);                /* mov [si+0x2], ax */
            ii(0x90e4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x90e6, 2);    if(jg(0x90ed, 5)) goto l_0x90ed;          /* jg 0x90ed */
            ii(0x90e8, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x90eb, 1);    pop(si);                                  /* pop si */
            ii(0x90ec, 1);    ret(); return;                            /* ret */
        l_0x90ed:
            ii(0x90ed, 4);    mov(memw[ds, si], 0);                     /* mov word [si], 0x0 */
        l_0x90f1:
            ii(0x90f1, 2);    mov(bx, memw[ds, si]);                    /* mov bx, [si] */
            ii(0x90f3, 3);    mov(al, memb[ds, bx + si + 4]);           /* mov al, [bx+si+0x4] */
            ii(0x90f6, 1);    cbw();                                    /* cbw */
            ii(0x90f7, 1);    pop(si);                                  /* pop si */
            ii(0x90f8, 1);    ret();                                    /* ret */
        }
    }
}

using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("82f02984-d276-42f7-aebf-de47389595f8")]
        public void Method_0000_a187()
        {
            ii(0xa187, 3);    mov(si, memw_a16[ss, bp + 0x1e]);         /* mov si, [bp+0x1e] */
            ii(0xa18a, 3);    mov(ds, memw_a16[ss, bp + 0x22]);         /* mov ds, [bp+0x22] */
            ii(0xa18d, 1);    lodsw_a16();                              /* lodsw */
            ii(0xa18e, 3);    cmp(ax, 0x5eff);                          /* cmp ax, 0x5eff */
            ii(0xa191, 2);    jnzw_func(0xa1b8, 0x25);                  /* jnz 0xa1b8 */
            ii(0xa193, 1);    lodsb_a16();                              /* lodsb */
            ii(0xa194, 1);    cbw();                                    /* cbw */
            ii(0xa195, 3);    add(ax, memw_a16[ss, bp + 0xc]);          /* add ax, [bp+0xc] */
            ii(0xa198, 1);    xchg(si, ax);                             /* xchg si, ax */
            ii(0xa199, 3);    mov(ds, memw_a16[ss, bp + 0x2]);          /* mov ds, [bp+0x2] */
            ii(0xa19c, 3);    mov(bx, memw_a16[ds, si + 0x2]);          /* mov bx, [si+0x2] */
            ii(0xa19f, 3);    mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0xa1a2, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa1a4, 2);    jbw_func(0xa1b8, 0x12);                   /* jb 0xa1b8 */
            ii(0xa1a6, 5);    mov(es, memw_a16[cs, 0x208e]);            /* mov es, [cs:0x208e] */
            ii(0xa1ab, 5);    mov(bx, memw_a16[es, 0xa9c]);             /* mov bx, [es:0xa9c] */
            ii(0xa1b0, 3);    mov(memw_a16[ds, si + 0x2], bx);          /* mov [si+0x2], bx */
            ii(0xa1b3, 1);    inc(ax);                                  /* inc ax */
            ii(0xa1b4, 2);    @int(0x31);                              /* int 0x31 */
            ii(0xa1b6, 2);    jaew_func(0xa236, 0x7e);                  /* jae 0xa236 */
            ii(0xa1b8, 0);    jmpd_func(0xa1b8, 0);                     /* Принудительное завершение функции. */
        }
    }
}

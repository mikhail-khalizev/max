using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b7f192fa-412c-4f9d-8ac5-7734ac2a6b49")]
        public void Method_0000_a274()
        {
            ii(0xa274, 3);    callw(0xa264, -0x13);                     /* call 0xa264 */
            ii(0xa277, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xa279, 2);    if(jnzw(0xa27c, 0x1)) goto l_0xa27c;      /* jnz 0xa27c */
            ii(0xa27b, 1);    retw();                                   /* ret */
        l_0xa27c:
            ii(0xa27c, 3);    mov(ax, 0x4310);                          /* mov ax, 0x4310 */
            ii(0xa27f, 2);    int_n(0x2f);                              /* int 0x2f */
            ii(0xa281, 4);    mov(memw_a16[ds, 0xaec], bx);             /* mov [0xaec], bx */
            ii(0xa285, 4);    mov(memw_a16[ds, 0xaee], es);             /* mov [0xaee], es */
            ii(0xa289, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0xa28b, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0xa28f, 2);    dec(ah);                                  /* dec ah */
            ii(0xa291, 2);    jlew_func(0xa25a, -0x39);                 /* jle 0xa25a */
            ii(0xa293, 4);    cmp(bx, 0x204);                           /* cmp bx, 0x204 */
            ii(0xa297, 2);    if(jaew(0xa2a0, 0x7)) goto l_0xa2a0;      /* jae 0xa2a0 */
            ii(0xa299, 7);    mov(memw_a16[cs, 0x1df5], 0x40);          /* mov word [cs:0x1df5], 0x40 */
        l_0xa2a0:
            ii(0xa2a0, 2);    mov(ah, 0x8);                             /* mov ah, 0x8 */
            ii(0xa2a2, 4);    callw_a16_far_ind(ds, 0xaec);             /* call far word [0xaec] */
            ii(0xa2a6, 5);    sub(ax, memw_a16[cs, 0x1df5]);            /* sub ax, [cs:0x1df5] */
            ii(0xa2ab, 2);    jaew_func(0xa2af, 0x2);                   /* jae 0xa2af */
            ii(0xa2ad, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xa2af, 0);    jmpd_func(0xa2af, 0);                     /* Принудительное завершение функции. */
        }
    }
}

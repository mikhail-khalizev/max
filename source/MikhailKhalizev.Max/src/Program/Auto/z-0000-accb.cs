using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a602d2f1-4420-4bc9-b411-26270e6fe89b")]
        public void Method_0000_accb()
        {
            ii(0xaccb, 1);    pushw(si);                                /* push si */
            ii(0xaccc, 1);    pushw(di);                                /* push di */
            ii(0xaccd, 3);    callw(0x9f7b, -0xd55);                    /* call 0x9f7b */
            ii(0xacd0, 3);    mov(ax, 0x3567);                          /* mov ax, 0x3567 */
            ii(0xacd3, 2);    @int(0x21);                               /* int 0x21 */
            ii(0xacd5, 2);    mov(cx, es);                              /* mov cx, es */
            ii(0xacd7, 4);    cmp(cx, memw_a16[ds, 0x58]);              /* cmp cx, [0x58] */
            ii(0xacdb, 2);    jzw_func(0xad46, 0x69);                   /* jz 0xad46 */
            ii(0xacdd, 7);    cmp(memw_a16[es, 0xb], 0x4d4d);           /* cmp word [es:0xb], 0x4d4d */
            ii(0xace4, 2);    jnzw_func(0xad46, 0x60);                  /* jnz 0xad46 */
            ii(0xace6, 7);    cmp(memw_a16[es, 0xe], 0x5858);           /* cmp word [es:0xe], 0x5858 */
            ii(0xaced, 2);    jnzw_func(0xad46, 0x57);                  /* jnz 0xad46 */
            ii(0xacef, 6);    cmp(memb_a16[es, 0xa], 0x45);             /* cmp byte [es:0xa], 0x45 */
            ii(0xacf5, 2);    jnzw_func(0xad46, 0x4f);                  /* jnz 0xad46 */
            ii(0xacf7, 6);    cmp(memb_a16[es, 0xd], 0x58);             /* cmp byte [es:0xd], 0x58 */
            ii(0xacfd, 2);    jnzw_func(0xad46, 0x47);                  /* jnz 0xad46 */
            ii(0xacff, 6);    cmp(memb_a16[es, 0x11], 0x30);            /* cmp byte [es:0x11], 0x30 */
            ii(0xad05, 2);    jnzw_func(0xad46, 0x3f);                  /* jnz 0xad46 */
            ii(0xad07, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0xad0c, 2);    jnzw_func(0xad41, 0x33);                  /* jnz 0xad41 */
            ii(0xad0e, 5);    test(memb_a16[ds, 0x14], 0x2);            /* test byte [0x14], 0x2 */
            ii(0xad13, 2);    jnzw_func(0xad41, 0x2c);                  /* jnz 0xad41 */
            ii(0xad15, 3);    mov(ax, 0xde00);                          /* mov ax, 0xde00 */
            ii(0xad18, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xad1a, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad1c, 2);    jzw_func(0xad41, 0x23);                   /* jz 0xad41 */
            ii(0xad1e, 2);    mov(ah, 0x43);                            /* mov ah, 0x43 */
            ii(0xad20, 3);    mov(bx, 0x1);                             /* mov bx, 0x1 */
            ii(0xad23, 2);    @int(0x67);                               /* int 0x67 */
            ii(0xad25, 2);    or(ah, ah);                               /* or ah, ah */
            ii(0xad27, 2);    jnzw_func(0xad46, 0x1d);                  /* jnz 0xad46 */
            ii(0xad29, 5);    mov(memw_a16[cs, 0x2ad9], dx);            /* mov [cs:0x2ad9], dx */
            ii(0xad2e, 2);    jmpw_func(0xad46, 0x16); return;          /* jmp 0xad46 */
        }
    }
}

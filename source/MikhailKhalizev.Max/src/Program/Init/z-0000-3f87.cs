using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6bbaebca-8a03-4112-8402-fdd39294fb29")]
        public void Method_0000_3f87()
        {
            ii(0x3f87, 5);    test(memb_a16[ds, 0x47], 0x1);            /* test byte [0x47], 0x1 */
            ii(0x3f8c, 2);    if(jzw(0x3fb6, 0x28)) goto l_0x3fb6;      /* jz 0x3fb6 */
            ii(0x3f8e, 6);    mov(memw_a16[ds, 0x170], 0x4fa);          /* mov word [0x170], 0x4fa */
            ii(0x3f94, 6);    mov(memw_a16[ds, 0x1b0], 0xc7c);          /* mov word [0x1b0], 0xc7c */
            ii(0x3f9a, 6);    mov(memw_a16[ds, 0x1b2], 0x18);           /* mov word [0x1b2], 0x18 */
            ii(0x3fa0, 4);    mov(bl, memb_a16[ds, 0x51]);              /* mov bl, [0x51] */
            ii(0x3fa4, 2);    or(bl, bl);                               /* or bl, bl */
            ii(0x3fa6, 2);    if(jzw(0x3fb6, 0xe)) goto l_0x3fb6;       /* jz 0x3fb6 */
            ii(0x3fa8, 3);    add(bl, 0x5);                             /* add bl, 0x5 */
            ii(0x3fab, 2);    xor(bh, bh);                              /* xor bh, bh */
            ii(0x3fad, 3);    shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x3fb0, 6);    mov(memw_a16[ds, bx + 0xc0], 0x556);      /* mov word [bx+0xc0], 0x556 */
        l_0x3fb6:
            ii(0x3fb6, 5);    cmp(memb_a16[ds, 0x3e], 0);               /* cmp byte [0x3e], 0x0 */
            ii(0x3fbb, 2);    if(jzw(0x3fe5, 0x28)) goto l_0x3fe5;      /* jz 0x3fe5 */
            ii(0x3fbd, 2);    fninit();                                 /* fninit */
            ii(0x3fbf, 4);    mov(bx, memw_a16[ds, 0xf82]);             /* mov bx, [0xf82] */
            ii(0x3fc3, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x3fc5, 2);    if(jzw(0x3fc9, 0x2)) goto l_0x3fc9;       /* jz 0x3fc9 */
            ii(0x3fc7, 2);    fnsavew_a16(ds, bx);                      /* fnsave [bx] */
        l_0x3fc9:
            ii(0x3fc9, 6);    mov(memb_a16[cs, 0x92c], 0x9b);           /* mov byte [cs:0x92c], 0x9b */
            ii(0x3fcf, 6);    mov(memb_a16[cs, 0x931], 0x9b);           /* mov byte [cs:0x931], 0x9b */
            ii(0x3fd5, 3);    mov(al, memb_a16[ds, 0x2e]);              /* mov al, [0x2e] */
            ii(0x3fd8, 2);    or(al, al);                               /* or al, al */
            ii(0x3fda, 2);    if(jzw(0x3fe2, 0x6)) goto l_0x3fe2;       /* jz 0x3fe2 */
            ii(0x3fdc, 2);    cmp(al, 0xb);                             /* cmp al, 0xb */
            ii(0x3fde, 2);    if(jzw(0x3fe2, 0x2)) goto l_0x3fe2;       /* jz 0x3fe2 */
            ii(0x3fe0, 2);    clts();                                   /* clts */
        l_0x3fe2:
            ii(0x3fe2, 1);    wait();                                   /* wait */
            ii(0x3fe3, 2);    // invalid();                                /* fnsetpm */
        l_0x3fe5:
            ii(0x3fe5, 1);    retw(); return;                           /* ret */
        }
    }
}

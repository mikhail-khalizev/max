using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("29ffd282-29f0-4432-a303-15a140c210d1")]
        public void Method_0000_4888()
        {
            ii(0x4888, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0x488a, 3);    mov(si, memw_a16[ds, bx + 0x2]);          /* mov si, [bx+0x2] */
            ii(0x488d, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0x488f, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x4891, 3);    mov(bx, 0x8);                             /* mov bx, 0x8 */
            ii(0x4894, 1);    cld();                                    /* cld */
            ii(0x4895, 1);    cli();                                    /* cli */
            ii(0x4896, 3);    mov(di, 0x20);                            /* mov di, 0x20 */
        l_0x4899:
            ii(0x4899, 5);    cmp(memb_a16[ds, bx + 0x10be], 0);        /* cmp byte [bx+0x10be], 0x0 */
            ii(0x489e, 2);    if(jnzw(0x48aa, 0xa)) goto l_0x48aa;      /* jnz 0x48aa */
        l_0x48a0:
            ii(0x48a0, 1);    cmpsw_a16();                              /* cmpsw */
            ii(0x48a1, 1);    cmpsw_a16();                              /* cmpsw */
        l_0x48a2:
            ii(0x48a2, 1);    inc(bx);                                  /* inc bx */
            ii(0x48a3, 3);    cmp(bl, 0x2e);                            /* cmp bl, 0x2e */
            ii(0x48a6, 2);    if(jbew(0x4899, -0xf)) goto l_0x4899;     /* jbe 0x4899 */
            ii(0x48a8, 2);    jmpw_func(0x4885, -0x25);                 /* jmp 0x4885 */
        l_0x48aa:
            ii(0x48aa, 4);    cmp(bl, memb_a16[ds, 0x34]);              /* cmp bl, [0x34] */
            ii(0x48ae, 2);    if(jzw(0x48a0, -0x10)) goto l_0x48a0;     /* jz 0x48a0 */
            ii(0x48b0, 1);    movsw_a16();                              /* movsw */
            ii(0x48b1, 1);    movsw_a16();                              /* movsw */
            ii(0x48b2, 2);    goto l_0x48a2;                            /* jmp 0x48a2 */
        }
    }
}
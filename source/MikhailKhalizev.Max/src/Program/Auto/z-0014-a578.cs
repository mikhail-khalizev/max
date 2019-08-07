using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e5364252-afaf-476d-b88d-fd25c676aa10")]
        public void Method_0014_a578()
        {
            ii(0x14_a578, 3); mov(bx, memw_a16[ss, bp + 0x10]);         /* mov bx, [bp+0x10] */
            ii(0x14_a57b, 3); mov(cx, memw_a16[ss, bp + 0x14]);         /* mov cx, [bp+0x14] */
            ii(0x14_a57e, 1); pushw(ss);                                /* push ss */
            ii(0x14_a57f, 1); popw(es);                                 /* pop es */
            ii(0x14_a580, 3); mov(si, memw_a16[ss, bp + 0x22]);         /* mov si, [bp+0x22] */
            ii(0x14_a583, 4); cmp(memb_a16[ss, bp + 0x16], 0);          /* cmp byte [bp+0x16], 0x0 */
            ii(0x14_a587, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x14_a58a, 3); mov(ss, memw_a16[ss, bp + 0xa]);          /* mov ss, [bp+0xa] */
            ii(0x14_a58d, 1); xchg(sp, ax);                             /* xchg sp, ax */
            ii(0x14_a58e, 1); pushw(bx);                                /* push bx */
            ii(0x14_a58f, 1); pushw(cx);                                /* push cx */
            ii(0x14_a590, 2); if(jnzw(0x14_a5a0, 0xe)) goto l_0x14_a5a0; /* jnz 0xa5a0 */
            ii(0x14_a592, 2); mov(ah, 0x49);                            /* mov ah, 0x49 */
            ii(0x14_a594, 1); pushw(cs);                                /* push cs */
            ii(0x14_a595, 3); callw(0x14_a366, -0x232);                 /* call 0xa366 */
            ii(0x14_a598, 2); mov(es, si);                              /* mov es, si */
            ii(0x14_a59a, 2); mov(ah, 0x49);                            /* mov ah, 0x49 */
            ii(0x14_a59c, 1); pushw(cs);                                /* push cs */
            ii(0x14_a59d, 3); callw(0x14_a366, -0x23a);                 /* call 0xa366 */
        l_0x14_a5a0:
            ii(0x14_a5a0, 1); sti();                                    /* sti */
            ii(0x14_a5a1, 3); mov(ax, memw_a16[ds, 0xc2a]);             /* mov ax, [0xc2a] */
            ii(0x14_a5a4, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x14_a5a6, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x14_a5a8, 1); retfw(); return;                          /* retf */
        }
    }
}

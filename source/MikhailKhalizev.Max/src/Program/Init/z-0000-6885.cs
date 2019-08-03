using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f2d7e75e-0176-4913-b471-676dca08c050")]
        public void Method_0000_6885()
        {
        l_0x6885:
            ii(0x6885, 6);    mov(memw_a16[ds, 0x8d0], 0);              /* mov word [0x8d0], 0x0 */
            ii(0x688b, 5);    lidtw_a16(ds, 0x8d0);                     /* lidt [0x8d0] */
            ii(0x6890, 2);    @int(0xff);                               /* int 0xff */
            ii(0x6892, 1);    pushw(ax);                                /* push ax */
            ii(0x6893, 1);    pushw(bx);                                /* push bx */
            ii(0x6894, 3);    mov(bx, 0x1a2);                           /* mov bx, 0x1a2 */
            ii(0x6897, 1);    cli();                                    /* cli */
            ii(0x6898, 2);    inb(al, 0x21);                            /* in al, 0x21 */
            ii(0x689a, 1);    pusha();                                  /* pusha */
            ii(0x689b, 4);    mov(memw_a16[ds, 0xf7c], bx);             /* mov [0xf7c], bx */
            ii(0x689f, 4);    mov(memw_a16[ds, 0xf7a], sp);             /* mov [0xf7a], sp */
            ii(0x68a3, 3);    mov(ax, 0x38);                            /* mov ax, 0x38 */
            ii(0x68a6, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x68a8, 3);    mov(ax, memw_a16[ds, 0x9b6]);             /* mov ax, [0x9b6] */
            ii(0x68ab, 4);    mov(memw_a16[es, 0x469], ax);             /* mov [es:0x469], ax */
            ii(0x68af, 7);    mov(memw_a16[es, 0x467], 0xb14);          /* mov word [es:0x467], 0xb14 */
            ii(0x68b6, 5);    cmp(memb_a16[ds, 0xed0], 0);              /* cmp byte [0xed0], 0x0 */
            ii(0x68bb, 2);    if(jnzw(0x6885, -0x38)) goto l_0x6885;    /* jnz 0x6885 */
            ii(0x68bd, 2);    mov(al, 0xfe);                            /* mov al, 0xfe */
            ii(0x68bf, 2);    outb(0x64, al);                           /* out 0x64, al */
        l_0x68c1:
            ii(0x68c1, 1);    hlt();                                    /* hlt */
            ii(0x68c2, 2);    jmpw(0x68c1, -0x3); goto l_0x68c1;        /* jmp 0x68c1 */
        }
    }
}

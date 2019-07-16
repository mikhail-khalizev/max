using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fd02a39e-16eb-4c8c-a390-9cc6822d74d2")]
        public void Method_0000_a74b()
        {
            ii(0xa74b, 2);    pushw(0x20);                              /* push 0x20 */
            ii(0xa74d, 3);    callw(0x589d, -0x4eb3);                   /* call 0x589d */
            ii(0xa750, 2);    mov(bx, sp);                              /* mov bx, sp */
            ii(0xa752, 3);    mov(ax, memw_a16[ds, bx + 0x2]);          /* mov ax, [bx+0x2] */
            ii(0xa755, 4);    mov(es, memw_a16[ds, 0xc34]);             /* mov es, [0xc34] */
            ii(0xa759, 2);    mov(bx, ax);                              /* mov bx, ax */
            ii(0xa75b, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0xa75e, 4);    or(memb_a16[es, bx], -0x80 /* 0x80 */);   /* or byte [es:bx], 0x80 */
            ii(0xa762, 1);    xchg(bx, ax);                             /* xchg bx, ax */
            ii(0xa763, 3);    mov(al, memb_a16[ds, 0x980]);             /* mov al, [0x980] */
            ii(0xa766, 2);    cmp(al, 0x3);                             /* cmp al, 0x3 */
            ii(0xa768, 2);    if(jaew(0xa77e, 0x14)) goto l_0xa77e;     /* jae 0xa77e */
            ii(0xa76a, 1);    pushw(ax);                                /* push ax */
            ii(0xa76b, 5);    mov(memb_a16[ds, 0x980], 0x2);            /* mov byte [0x980], 0x2 */
            ii(0xa770, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0xa772, 2);    mov(dh, 0x3);                             /* mov dh, 0x3 */
            ii(0xa774, 2);    mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0xa776, 1);    pushw(bx);                                /* push bx */
            ii(0xa777, 2);    int_n(0x21);                              /* int 0x21 */
            ii(0xa779, 1);    popw(bx);                                 /* pop bx */
            ii(0xa77a, 1);    popw(ax);                                 /* pop ax */
            ii(0xa77b, 3);    mov(memb_a16[ds, 0x980], al);             /* mov [0x980], al */
        l_0xa77e:
            ii(0xa77e, 4);    cmp(bx, memw_a16[ds, 0xc3c]);             /* cmp bx, [0xc3c] */
            ii(0xa782, 2);    if(jnzw(0xa78c, 0x8)) goto l_0xa78c;      /* jnz 0xa78c */
            ii(0xa784, 3);    mov(ax, 0xa);                             /* mov ax, 0xa */
            ii(0xa787, 2);    int_n(0x31);                              /* int 0x31 */
            ii(0xa789, 3);    mov(memw_a16[ds, 0xc24], ax);             /* mov [0xc24], ax */
        l_0xa78c:
            ii(0xa78c, 3);    mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0xa78f, 2);    int_n(0x31);                              /* int 0x31 */
            ii(0xa791, 1);    xchg(dx, ax);                             /* xchg dx, ax */
            ii(0xa792, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0xa794, 1);    retw();                                   /* ret */
        }
    }
}

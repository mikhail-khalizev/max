using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8614-531dcb8f")]
        public void Method_0000_8614()
        {
            ii(0x8614, 1);    push(ax);                                 /* push ax */
            ii(0x8615, 1);    push(bx);                                 /* push bx */
            ii(0x8616, 4);    mov(bx, memw[ds, 0x9b4]);                 /* mov bx, [0x9b4] */
            ii(0x861a, 1);    cli();                                    /* cli */
            ii(0x861b, 5);    cmp(memb[ds, 0x11f0], 0);                 /* cmp byte [0x11f0], 0x0 */
            ii(0x8620, 2);    if(jnz(0x862c, 0xa)) goto l_0x862c;       /* jnz 0x862c */
            ii(0x8622, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x8624, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x8626, 2);    jmp(0x8628, 0); goto l_0x8628;            /* jmp 0x8628 */
        l_0x8628:
            ii(0x8628, 2);    xor(al, al);                              /* xor al, al */
            ii(0x862a, 2);    outb(0x71, al);                           /* out 0x71, al */
        l_0x862c:
            ii(0x862c, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x862e, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x8630, 4);    mov(memw[ds, 0xd62], gs);                 /* mov [0xd62], gs */
            ii(0x8634, 4);    mov(memw[ds, 0xd60], fs);                 /* mov [0xd60], fs */
            ii(0x8638, 2);    mov(fs, ax);                              /* mov fs, ax */
            ii(0x863a, 2);    mov(gs, ax);                              /* mov gs, ax */
            ii(0x863c, 2);    push(eax);                                /* push eax */
            ii(0x863e, 1);    push(cx);                                 /* push cx */
            ii(0x863f, 3);    mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x8642, 5);    mov(memb[ds, 0xdfe], 0);                  /* mov byte [0xdfe], 0x0 */
            ii(0x8647, 5);    btr(eax, 0x1f);                           /* btr eax, 0x1f */
            ii(0x864c, 4);    if(jae(0x865a, 0xa)) goto l_0x865a;       /* jae 0x865a */
            ii(0x8650, 5);    mov(memb[ds, 0xdfe], 0x1);                /* mov byte [0xdfe], 0x1 */
            ii(0x8655, 5);    str(memw[ds, 0xdfc]);                     /* str word [0xdfc] */
        l_0x865a:
            ii(0x865a, 4);    mov(cx, memw[ds, 0x40]);                  /* mov cx, [0x40] */
            ii(0x865e, 2);    not(cx);                                  /* not cx */
            ii(0x8660, 2);    and(ax, cx);                              /* and ax, cx */
            ii(0x8662, 1);    pop(cx);                                  /* pop cx */
            ii(0x8663, 3);    mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x8666, 5);    jmp_far_abs(0x5db, 0x28bb);               /* jmp word 0x5db:0x28bb */
        }
    }
}

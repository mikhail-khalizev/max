using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a31fc1c9-41e2-420f-a1b3-5d0eb30b10dd")]
        public void Method_0000_85fc()
        {
            ii(0x85fc, 1);    pushw(bx);                                /* push bx */
            ii(0x85fd, 2);    mov(bx, ss);                              /* mov bx, ss */
            ii(0x85ff, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x8602, 2);    pushw(0x8);                               /* push 0x8 */
            ii(0x8604, 1);    popw(es);                                 /* pop es */
            ii(0x8605, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x8608, 1);    cli();                                    /* cli */
            ii(0x8609, 3);    xchg(memw_a16[es, bx], ax);               /* xchg [es:bx], ax */
            ii(0x860c, 2);    mov(ss, bx);                              /* mov ss, bx */
            ii(0x860e, 3);    xchg(memw_a16[es, bx], ax);               /* xchg [es:bx], ax */
            ii(0x8611, 1);    popw(bx);                                 /* pop bx */
            ii(0x8612, 2);    jmpw(0x861b, 0x7); goto l_0x861b;         /* jmp 0x861b */
        //  ii(0x8614, 7);    Недостижимый код.
        l_0x861b:
            ii(0x861b, 5);    cmp(memb_a16[ds, 0x11f0], 0);             /* cmp byte [0x11f0], 0x0 */
            ii(0x8620, 2);    if(jnzw(0x862c, 0xa)) goto l_0x862c;      /* jnz 0x862c */
            ii(0x8622, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x8624, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x8626, 2);    jmpw(0x8628, 0); goto l_0x8628;           /* jmp 0x8628 */
        l_0x8628:
            ii(0x8628, 2);    xor(al, al);                              /* xor al, al */
            ii(0x862a, 2);    outb(0x71, al);                           /* out 0x71, al */
        l_0x862c:
            ii(0x862c, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x862e, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x8630, 4);    mov(memw_a16[ds, 0xd62], gs);             /* mov [0xd62], gs */
            ii(0x8634, 4);    mov(memw_a16[ds, 0xd60], fs);             /* mov [0xd60], fs */
            ii(0x8638, 2);    mov(fs, ax);                              /* mov fs, ax */
            ii(0x863a, 2);    mov(gs, ax);                              /* mov gs, ax */
            ii(0x863c, 2);    pushd(eax);                               /* push eax */
            ii(0x863e, 1);    pushw(cx);                                /* push cx */
            ii(0x863f, 3);    mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x8642, 5);    mov(memb_a16[ds, 0xdfe], 0);              /* mov byte [0xdfe], 0x0 */
            ii(0x8647, 5);    btr(eax, 0x1f);                           /* btr eax, 0x1f */
            ii(0x864c, 4);    if(jaew(0x865a, 0xa)) goto l_0x865a;      /* jae 0x865a */
            ii(0x8650, 5);    mov(memb_a16[ds, 0xdfe], 0x1);            /* mov byte [0xdfe], 0x1 */
            ii(0x8655, 5);    str(memw_a16[ds, 0xdfc]);                 /* str word [0xdfc] */
        l_0x865a:
            ii(0x865a, 4);    mov(cx, memw_a16[ds, 0x40]);              /* mov cx, [0x40] */
            ii(0x865e, 2);    not(cx);                                  /* not cx */
            ii(0x8660, 2);    and(ax, cx);                              /* and ax, cx */
            ii(0x8662, 1);    popw(cx);                                 /* pop cx */
            ii(0x8663, 3);    mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x8666, 5);    if(jmpw_far_abs(0x5db, 0x28bb)) return;   /* jmp word 0x5db:0x28bb */
        }
    }
}

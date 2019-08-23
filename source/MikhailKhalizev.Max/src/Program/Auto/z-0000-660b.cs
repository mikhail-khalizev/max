using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x660b-daa43739")]
        public void Method_0000_660b()
        {
            ii(0x660b, 5);    cmp(memb[ds, 0x11f0], 0);                 /* cmp byte [0x11f0], 0x0 */
            ii(0x6610, 2);    if(jnz(0x661c, 0xa)) goto l_0x661c;       /* jnz 0x661c */
            ii(0x6612, 2);    mov(al, 0xf);                             /* mov al, 0xf */
            ii(0x6614, 2);    outb(0x70, al);                           /* out 0x70, al */
            ii(0x6616, 2);    jmp(0x6618, 0); goto l_0x6618;            /* jmp 0x6618 */
        l_0x6618:
            ii(0x6618, 2);    xor(al, al);                              /* xor al, al */
            ii(0x661a, 2);    outb(0x71, al);                           /* out 0x71, al */
        l_0x661c:
            ii(0x661c, 2);    mov(ax, ds);                              /* mov ax, ds */
            ii(0x661e, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x6620, 4);    mov(memw[ds, 0xd62], gs);                 /* mov [0xd62], gs */
            ii(0x6624, 4);    mov(memw[ds, 0xd60], fs);                 /* mov [0xd60], fs */
            ii(0x6628, 2);    mov(fs, ax);                              /* mov fs, ax */
            ii(0x662a, 2);    mov(gs, ax);                              /* mov gs, ax */
            ii(0x662c, 2);    pushd(eax);                               /* push eax */
            ii(0x662e, 1);    push(cx);                                 /* push cx */
            ii(0x662f, 3);    mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x6632, 5);    mov(memb[ds, 0xdfe], 0);                  /* mov byte [0xdfe], 0x0 */
            ii(0x6637, 5);    btr(eax, 0x1f);                           /* btr eax, 0x1f */
            ii(0x663c, 4);    if(jae(0x664a, 0xa)) goto l_0x664a;       /* jae 0x664a */
            ii(0x6640, 5);    mov(memb[ds, 0xdfe], 0x1);                /* mov byte [0xdfe], 0x1 */
            ii(0x6645, 5);    str(memw[ds, 0xdfc]);                     /* str word [0xdfc] */
        l_0x664a:
            ii(0x664a, 4);    mov(cx, memw[ds, 0x40]);                  /* mov cx, [0x40] */
            ii(0x664e, 2);    not(cx);                                  /* not cx */
            ii(0x6650, 2);    and(ax, cx);                              /* and ax, cx */
            ii(0x6652, 1);    pop(cx);                                  /* pop cx */
            ii(0x6653, 3);    mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x6656, 5);    jmp_far_abs(0x3da, 0x28bb);               /* jmp word 0x3da:0x28bb */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8728-97e07b18")]
        public void Method_0000_8728()
        {
            ii(0x8728, 5);    cmp(memb[ds, 0xdfe], 0x1);                /* cmp byte [0xdfe], 0x1 */
            ii(0x872d, 4);    if(jnz(0x8765, 0x34)) goto l_0x8765;      /* jnz 0x8765 */
            ii(0x8731, 2);    push(eax);                                /* push eax */
            ii(0x8733, 3);    mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x8736, 6);    or(eax, 0x8000_0000);                     /* or eax, 0x80000000 */
            ii(0x873c, 3);    mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x873f, 3);    mov(ax, memw[ds, 0xdfc]);                 /* mov ax, [0xdfc] */
            ii(0x8742, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8744, 4);    if(jz(0x8763, 0x1b)) goto l_0x8763;       /* jz 0x8763 */
            ii(0x8748, 1);    push(bx);                                 /* push bx */
            ii(0x8749, 4);    mov(bx, memw[ds, 0xdfc]);                 /* mov bx, [0xdfc] */
            ii(0x874d, 3);    mov(ax, 0x8);                             /* mov ax, 0x8 */
            ii(0x8750, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x8752, 4);    mov(memb[ds, bx + 0x5], 0x89);            /* mov byte [bx+0x5], 0x89 */
            ii(0x8756, 2);    mov(ax, bx);                              /* mov ax, bx */
            ii(0x8758, 3);    mov(bx, 0x20);                            /* mov bx, 0x20 */
            ii(0x875b, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x875d, 1);    pop(bx);                                  /* pop bx */
            ii(0x875e, 3);    ltr(ax);                                  /* ltr ax */
            ii(0x8761, 2);    clts();                                   /* clts */
        l_0x8763:
            ii(0x8763, 2);    pop(eax);                                 /* pop eax */
        l_0x8765:
            ii(0x8765, 3);    if(jmp_func(0x60e7, -0x2681)) return;     /* jmp 0x60e7 */
        }
    }
}

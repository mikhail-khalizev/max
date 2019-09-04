using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6718-97e07b18")]
        public void Method_0000_6718()
        {
            ii(0x6718, 5);    cmp(memb[ds, 0xdfe], 1);                  /* cmp byte [0xdfe], 0x1 */
            ii(0x671d, 4);    if(jnz(0x6755, 0x34)) goto l_0x6755;      /* jnz 0x6755 */
            ii(0x6721, 2);    push(eax);                                /* push eax */
            ii(0x6723, 3);    mov(eax, cr0);                            /* mov eax, cr0 */
            ii(0x6726, 6);    or(eax, 0x8000_0000);                     /* or eax, 0x80000000 */
            ii(0x672c, 3);    mov(cr0, eax);                            /* mov cr0, eax */
            ii(0x672f, 3);    mov(ax, memw[ds, 0xdfc]);                 /* mov ax, [0xdfc] */
            ii(0x6732, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x6734, 4);    if(jz(0x6753, 0x1b)) goto l_0x6753;       /* jz 0x6753 */
            ii(0x6738, 1);    push(bx);                                 /* push bx */
            ii(0x6739, 4);    mov(bx, memw[ds, 0xdfc]);                 /* mov bx, [0xdfc] */
            ii(0x673d, 3);    mov(ax, 8);                               /* mov ax, 0x8 */
            ii(0x6740, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x6742, 4);    mov(memb[ds, bx + 5], 0x89);              /* mov byte [bx+0x5], 0x89 */
            ii(0x6746, 2);    mov(ax, bx);                              /* mov ax, bx */
            ii(0x6748, 3);    mov(bx, 0x20);                            /* mov bx, 0x20 */
            ii(0x674b, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x674d, 1);    pop(bx);                                  /* pop bx */
            ii(0x674e, 3);    ltr(ax);                                  /* ltr ax */
            ii(0x6751, 2);    clts();                                   /* clts */
        l_0x6753:
            ii(0x6753, 2);    pop(eax);                                 /* pop eax */
        l_0x6755:
            ii(0x6755, 3);    if(jmp_func(0x40d7, -0x2681)) return;     /* jmp 0x40d7 */
        }
    }
}

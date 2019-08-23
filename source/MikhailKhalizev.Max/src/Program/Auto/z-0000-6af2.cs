using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6af2-6d0b905f")]
        public void Method_0000_6af2()
        {
            ii(0x6af2, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x6af5, 1);    push(ax);                                 /* push ax */
            ii(0x6af6, 3);    call(0xa3f5, 0x38fc);                     /* call 0xa3f5 */
            ii(0x6af9, 1);    pop(bx);                                  /* pop bx */
            ii(0x6afa, 3);    mov(memb[ds, 0x1186], al);                /* mov [0x1186], al */
            ii(0x6afd, 5);    cmp(memb[ds, 0x26], 0);                   /* cmp byte [0x26], 0x0 */
            ii(0x6b02, 2);    if(jz(0x6b22, 0x1e)) goto l_0x6b22;       /* jz 0x6b22 */
            ii(0x6b04, 3);    mov(ax, 0xe20);                           /* mov ax, 0xe20 */
            ii(0x6b07, 1);    push(ax);                                 /* push ax */
            ii(0x6b08, 3);    call(0x5237, -0x18d4);                    /* call 0x5237 */
            ii(0x6b0b, 1);    pop(bx);                                  /* pop bx */
            ii(0x6b0c, 3);    mov(ax, 0xad6);                           /* mov ax, 0xad6 */
            ii(0x6b0f, 1);    push(ax);                                 /* push ax */
            ii(0x6b10, 3);    call(0x5237, -0x18dc);                    /* call 0x5237 */
            ii(0x6b13, 1);    pop(bx);                                  /* pop bx */
            ii(0x6b14, 3);    call(0x5578, -0x159f);                    /* call 0x5578 */
            ii(0x6b17, 4);    push(memw[ds, 0x30]);                     /* push word [0x30] */
            ii(0x6b1b, 3);    call(0x5237, -0x18e7);                    /* call 0x5237 */
            ii(0x6b1e, 1);    pop(bx);                                  /* pop bx */
            ii(0x6b1f, 3);    call(0x5578, -0x15aa);                    /* call 0x5578 */
        l_0x6b22:
            ii(0x6b22, 6);    mov(memw[ds, 0xe], 0x2000);               /* mov word [0xe], 0x2000 */
            ii(0x6b28, 3);    if(jmp_func(0xa2e9, 0x37be)) return;      /* jmp 0xa2e9 */
        }
    }
}

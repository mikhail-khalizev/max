using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_9f20-ee0f1fc8")]
        public void Method_0018_9f20()
        {
            ii(0x18_9f20, 1);  cli();                                  /* cli */
            ii(0x18_9f21, 1);  push(bx);                               /* push bx */
            ii(0x18_9f22, 3);  mov(bx, 0x20);                          /* mov bx, 0x20 */
            ii(0x18_9f25, 1);  push(ds);                               /* push ds */
            ii(0x18_9f26, 2);  mov(ds, bx);                            /* mov ds, bx */
            ii(0x18_9f28, 6);  sub(memw[ds, 0x996], 0x180);            /* sub word [0x996], 0x180 */
            ii(0x18_9f2e, 4);  mov(bx, memw[ds, 0x996]);               /* mov bx, [0x996] */
            ii(0x18_9f32, 3);  mov(memw[ds, bx - 44], di);             /* mov [bx-0x2c], di */
            ii(0x18_9f35, 3);  mov(memw[ds, bx - 42], si);             /* mov [bx-0x2a], si */
            ii(0x18_9f38, 3);  mov(memw[ds, bx - 34], dx);             /* mov [bx-0x22], dx */
            ii(0x18_9f3b, 3);  mov(memw[ds, bx - 32], cx);             /* mov [bx-0x20], cx */
            ii(0x18_9f3e, 3);  mov(memw[ds, bx - 30], ax);             /* mov [bx-0x1e], ax */
            ii(0x18_9f41, 1);  pop(cx);                                /* pop cx */
            ii(0x18_9f42, 1);  pop(ax);                                /* pop ax */
            ii(0x18_9f43, 3);  mov(memw[ds, bx + 4], cx);              /* mov [bx+0x4], cx */
            ii(0x18_9f46, 3);  mov(memw[ds, bx - 48], cx);             /* mov [bx-0x30], cx */
            ii(0x18_9f49, 3);  mov(memw[ds, bx - 36], ax);             /* mov [bx-0x24], ax */
            ii(0x18_9f4c, 3);  mov(memw[ds, bx + 6], es);              /* mov [bx+0x6], es */
            ii(0x18_9f4f, 3);  mov(memw[ds, bx - 46], es);             /* mov [bx-0x2e], es */
            ii(0x18_9f52, 3);  mov(memw[ds, bx + 2], ss);              /* mov [bx+0x2], ss */
            ii(0x18_9f55, 3);  mov(memw[ds, bx - 40], bp);             /* mov [bx-0x28], bp */
            ii(0x18_9f58, 1);  pop(si);                                /* pop si */
            ii(0x18_9f59, 4);  mov(memd[ds, bx + 42], esp);            /* mov [bx+0x2a], esp */
            ii(0x18_9f5d, 4);  pop(memd[ds, bx + 30]);                 /* pop dword [bx+0x1e] */
            ii(0x18_9f61, 4);  pop(memd[ds, bx + 34]);                 /* pop dword [bx+0x22] */
            ii(0x18_9f65, 4);  pop(memd[ds, bx + 38]);                 /* pop dword [bx+0x26] */
            ii(0x18_9f69, 3);  mov(cx, memw[ds, bx + 38]);             /* mov cx, [bx+0x26] */
            ii(0x18_9f6c, 2);  xor(ah, ah);                            /* xor ah, ah */
            ii(0x18_9f6e, 4);  mov(memw[ds, 0x9ca], cx);               /* mov [0x9ca], cx */
            ii(0x18_9f72, 3);  and(ch, 0xfe);                          /* and ch, 0xfe */
            ii(0x18_9f75, 3);  mov(memw[ds, bx - 18], cx);             /* mov [bx-0x12], cx */
            ii(0x18_9f78, 3);  and(ch, 0xfd);                          /* and ch, 0xfd */
            ii(0x18_9f7b, 3);  mov(al, memb[cs, si]);                  /* mov al, [cs:si] */
            ii(0x18_9f7e, 3);  mov(memw[ds, bx - 24], cx);             /* mov [bx-0x18], cx */
            ii(0x18_9f81, 3);  lea(bx, memw[ds, bx - 50]);             /* lea bx, [bx-0x32] */
            ii(0x18_9f84, 3);  mov(dx, 0x20);                          /* mov dx, 0x20 */
            ii(0x18_9f87, 3);  mov(memb[ds, 0x9cc], al);               /* mov [0x9cc], al */
            ii(0x18_9f8a, 4);  mov(memw[ds, bx], 0xef8);               /* mov word [bx], 0xef8 */
            ii(0x18_9f8e, 2);  mov(ss, dx);                            /* mov ss, dx */
            ii(0x18_9f90, 2);  mov(sp, bx);                            /* mov sp, bx */
            ii(0x18_9f92, 5);  mov(memw[ds, bx + 28], 0xf34);          /* mov word [bx+0x1c], 0xf34 */
            ii(0x18_9f97, 5);  jmp_far_abs(0x18, 0x92c);               /* jmp word 0x18:0x92c */
        }
    }
}

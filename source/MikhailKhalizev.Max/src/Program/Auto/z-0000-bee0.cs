using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b02d61b7-9336-4e59-94a6-1436deeeb236")]
        public void Method_0000_bee0()
        {
            ii(0xbee0, 1);    cli();                                    /* cli */
            ii(0xbee1, 1);    pushw(bx);                                /* push bx */
            ii(0xbee2, 3);    mov(bx, 0x20);                            /* mov bx, 0x20 */
            ii(0xbee5, 1);    pushw(ds);                                /* push ds */
            ii(0xbee6, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0xbee8, 6);    sub(memw_a16[ds, 0x996], 0x180);          /* sub word [0x996], 0x180 */
            ii(0xbeee, 4);    mov(bx, memw_a16[ds, 0x996]);             /* mov bx, [0x996] */
            ii(0xbef2, 3);    mov(memw_a16[ds, bx - 0x2c], di);         /* mov [bx-0x2c], di */
            ii(0xbef5, 3);    mov(memw_a16[ds, bx - 0x2a], si);         /* mov [bx-0x2a], si */
            ii(0xbef8, 3);    mov(memw_a16[ds, bx - 0x22], dx);         /* mov [bx-0x22], dx */
            ii(0xbefb, 3);    mov(memw_a16[ds, bx - 0x20], cx);         /* mov [bx-0x20], cx */
            ii(0xbefe, 3);    mov(memw_a16[ds, bx - 0x1e], ax);         /* mov [bx-0x1e], ax */
            ii(0xbf01, 1);    popw(cx);                                 /* pop cx */
            ii(0xbf02, 1);    popw(ax);                                 /* pop ax */
            ii(0xbf03, 3);    mov(memw_a16[ds, bx + 0x4], cx);          /* mov [bx+0x4], cx */
            ii(0xbf06, 3);    mov(memw_a16[ds, bx - 0x30], cx);         /* mov [bx-0x30], cx */
            ii(0xbf09, 3);    mov(memw_a16[ds, bx - 0x24], ax);         /* mov [bx-0x24], ax */
            ii(0xbf0c, 3);    mov(memw_a16[ds, bx + 0x6], es);          /* mov [bx+0x6], es */
            ii(0xbf0f, 3);    mov(memw_a16[ds, bx - 0x2e], es);         /* mov [bx-0x2e], es */
            ii(0xbf12, 3);    mov(memw_a16[ds, bx + 0x2], ss);          /* mov [bx+0x2], ss */
            ii(0xbf15, 3);    mov(memw_a16[ds, bx - 0x28], bp);         /* mov [bx-0x28], bp */
            ii(0xbf18, 1);    popw(si);                                 /* pop si */
            ii(0xbf19, 4);    mov(memd_a16[ds, bx + 0x2a], esp);        /* mov [bx+0x2a], esp */
            ii(0xbf1d, 4);    popd(memd_a16[ds, bx + 0x1e]);            /* pop dword [bx+0x1e] */
            ii(0xbf21, 4);    popd(memd_a16[ds, bx + 0x22]);            /* pop dword [bx+0x22] */
            ii(0xbf25, 4);    popd(memd_a16[ds, bx + 0x26]);            /* pop dword [bx+0x26] */
            ii(0xbf29, 3);    mov(cx, memw_a16[ds, bx + 0x26]);         /* mov cx, [bx+0x26] */
            ii(0xbf2c, 2);    xor(ah, ah);                              /* xor ah, ah */
            ii(0xbf2e, 4);    mov(memw_a16[ds, 0x9ca], cx);             /* mov [0x9ca], cx */
            ii(0xbf32, 3);    and(ch, 0xfe);                            /* and ch, 0xfe */
            ii(0xbf35, 3);    mov(memw_a16[ds, bx - 0x12], cx);         /* mov [bx-0x12], cx */
            ii(0xbf38, 3);    and(ch, 0xfd);                            /* and ch, 0xfd */
            ii(0xbf3b, 3);    mov(al, memb_a16[cs, si]);                /* mov al, [cs:si] */
            ii(0xbf3e, 3);    mov(memw_a16[ds, bx - 0x18], cx);         /* mov [bx-0x18], cx */
            ii(0xbf41, 3);    lea(bx, bx - 0x32);                       /* lea bx, [bx-0x32] */
            ii(0xbf44, 3);    mov(dx, 0x20);                            /* mov dx, 0x20 */
            ii(0xbf47, 3);    mov(memb_a16[ds, 0x9cc], al);             /* mov [0x9cc], al */
            ii(0xbf4a, 4);    mov(memw_a16[ds, bx], 0xef8);             /* mov word [bx], 0xef8 */
            ii(0xbf4e, 2);    mov(ss, dx);                              /* mov ss, dx */
            ii(0xbf50, 2);    mov(sp, bx);                              /* mov sp, bx */
            ii(0xbf52, 5);    mov(memw_a16[ds, bx + 0x1c], 0xf34);      /* mov word [bx+0x1c], 0xf34 */
            ii(0xbf57, 5);    if(jmpw_far_abs(0x18, 0x92c)) return;     /* jmp word 0x18:0x92c */
        }
    }
}

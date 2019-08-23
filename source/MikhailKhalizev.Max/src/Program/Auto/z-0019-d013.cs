using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d013-a28d25a7")]
        public void Method_0019_d013()
        {
            ii(0x19_d013, 1); push(bp);                                 /* push bp */
            ii(0x19_d014, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x19_d016, 1); push(si);                                 /* push si */
            ii(0x19_d017, 3); les(bx, memw[ss, bp + 0x4]);              /* les bx, [bp+0x4] */
            ii(0x19_d01a, 5); mov(memw[es, bx], 0);                     /* mov word [es:bx], 0x0 */
            ii(0x19_d01f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_d021, 4); mov(memw[es, bx + 0x4], ax);              /* mov [es:bx+0x4], ax */
            ii(0x19_d025, 4); mov(memw[es, bx + 0x2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_d029, 3); mov(ax, memw[ss, bp + 0xa]);              /* mov ax, [bp+0xa] */
            ii(0x19_d02c, 3); or(ax, memw[ss, bp + 0x8]);               /* or ax, [bp+0x8] */
            ii(0x19_d02f, 2); if(jz(0x19_d092, 0x61)) goto l_0x19_d092; /* jz 0xd092 */
            ii(0x19_d031, 2); jmp(0x19_d089, 0x56); goto l_0x19_d089;   /* jmp 0xd089 */
        l_0x19_d033:
            ii(0x19_d033, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x19_d036, 1); cbw();                                    /* cbw */
            ii(0x19_d037, 1); push(ax);                                 /* push ax */
            ii(0x19_d038, 3); lea(ax, memw[ds, bx + 0x1]);              /* lea ax, [bx+0x1] */
            ii(0x19_d03b, 1); push(es);                                 /* push es */
            ii(0x19_d03c, 1); push(ax);                                 /* push ax */
            ii(0x19_d03d, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_d040, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_d043, 5); call_far_abs(0x80, 0x4384);               /* call word 0x80:0x4384 */
            ii(0x19_d048, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x19_d04b, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_d04d, 2); if(jnz(0x19_d07c, 0x2d)) goto l_0x19_d07c; /* jnz 0xd07c */
            ii(0x19_d04f, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_d052, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_d055, 3); call(0x19_ff2f, 0x2ed7);                  /* call 0xff2f */
            ii(0x19_d058, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
            ii(0x19_d05b, 2); mov(cx, ax);                              /* mov cx, ax */
            ii(0x19_d05d, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x19_d060, 1); cbw();                                    /* cbw */
            ii(0x19_d061, 2); cmp(cx, ax);                              /* cmp cx, ax */
            ii(0x19_d063, 2); if(jnz(0x19_d07c, 0x17)) goto l_0x19_d07c; /* jnz 0xd07c */
            ii(0x19_d065, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_d068, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_d06a, 4); push(memw[es, bx + si + 0x1]);            /* push word [es:bx+si+0x1] */
            ii(0x19_d06e, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_d071, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_d074, 3); call(0x19_cff8, -0x7f);                   /* call 0xcff8 */
            ii(0x19_d077, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_d07a, 2); jmp(0x19_d094, 0x18); goto l_0x19_d094;   /* jmp 0xd094 */
        l_0x19_d07c:
            ii(0x19_d07c, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
            ii(0x19_d07f, 3); mov(al, memb[es, bx]);                    /* mov al, [es:bx] */
            ii(0x19_d082, 1); cbw();                                    /* cbw */
            ii(0x19_d083, 3); add(ax, 0x3);                             /* add ax, 0x3 */
            ii(0x19_d086, 3); add(memw[ss, bp + 0x8], ax);              /* add [bp+0x8], ax */
        l_0x19_d089:
            ii(0x19_d089, 3); les(bx, memw[ss, bp + 0x8]);              /* les bx, [bp+0x8] */
            ii(0x19_d08c, 4); cmp(memb[es, bx], 0);                     /* cmp byte [es:bx], 0x0 */
            ii(0x19_d090, 2); if(jnz(0x19_d033, -0x5f)) goto l_0x19_d033; /* jnz 0xd033 */
        l_0x19_d092:
            ii(0x19_d092, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_d094:
            ii(0x19_d094, 1); pop(si);                                  /* pop si */
            ii(0x19_d095, 1); leave();                                  /* leave */
            ii(0x19_d096, 3); ret(0xe);                                 /* ret 0xe */
        }
    }
}

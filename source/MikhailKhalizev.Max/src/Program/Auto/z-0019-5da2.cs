using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5da2-d7d51f0d")]
        public void Method_0019_5da2()
        {
            ii(0x19_5da2, 4); enter(0x14, 0);                           /* enter 0x14, 0x0 */
            ii(0x19_5da6, 1); push(di);                                 /* push di */
            ii(0x19_5da7, 1); push(si);                                 /* push si */
            ii(0x19_5da8, 5); cmp(memb[ds, 0xd83], 0);                  /* cmp byte [0xd83], 0x0 */
            ii(0x19_5dad, 2); if(jnz(0x19_5db2, 0x3)) goto l_0x19_5db2; /* jnz 0x5db2 */
            ii(0x19_5daf, 3); jmp(0x19_5db8, 0x6); goto l_0x19_5db8;    /* jmp 0x5db8 */
        l_0x19_5db2:
            ii(0x19_5db2, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_5db5, 3); jmp(0x19_5e25, 0x6d); goto l_0x19_5e25;   /* jmp 0x5e25 */
        l_0x19_5db8:
            ii(0x19_5db8, 2); push(0x10);                               /* push 0x10 */
            ii(0x19_5dba, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x19_5dbd, 1); push(ss);                                 /* push ss */
            ii(0x19_5dbe, 1); push(ax);                                 /* push ax */
            ii(0x19_5dbf, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_5dc2, 3); mov(cx, memw[ss, bp + 0x8]);              /* mov cx, [bp+0x8] */
            ii(0x19_5dc5, 3); mov(dx, memw[ss, bp + 0xa]);              /* mov dx, [bp+0xa] */
            ii(0x19_5dc8, 3); add(cx, 0x2);                             /* add cx, 0x2 */
            ii(0x19_5dcb, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x19_5dce, 1); push(dx);                                 /* push dx */
            ii(0x19_5dcf, 1); push(cx);                                 /* push cx */
            ii(0x19_5dd0, 5); call_far_abs(0x80, 0x1534);               /* call word 0x80:0x1534 */
            ii(0x19_5dd5, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_5dd8, 4); mov(memb[ss, bp - 0x5], 0);               /* mov byte [bp-0x5], 0x0 */
            ii(0x19_5ddc, 3); lea(ax, memw[ss, bp - 0x14]);             /* lea ax, [bp-0x14] */
            ii(0x19_5ddf, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_5de2, 3); mov(memw[ss, bp - 0x2], ss);              /* mov [bp-0x2], ss */
            ii(0x19_5de5, 3); jmp(0x19_5deb, 0x3); goto l_0x19_5deb;    /* jmp 0x5deb */
        l_0x19_5de8:
            ii(0x19_5de8, 3); inc(memw[ss, bp - 0x4]);                  /* inc word [bp-0x4] */
        l_0x19_5deb:
            ii(0x19_5deb, 3); lea(ax, memw[ss, bp - 0x5]);              /* lea ax, [bp-0x5] */
            ii(0x19_5dee, 3); cmp(memw[ss, bp - 0x4], ax);              /* cmp [bp-0x4], ax */
            ii(0x19_5df1, 2); if(jb(0x19_5df6, 0x3)) goto l_0x19_5df6;  /* jb 0x5df6 */
            ii(0x19_5df3, 3); jmp(0x19_5e1f, 0x29); goto l_0x19_5e1f;   /* jmp 0x5e1f */
        l_0x19_5df6:
            ii(0x19_5df6, 3); les(bx, memw[ss, bp - 0x4]);              /* les bx, [bp-0x4] */
            ii(0x19_5df9, 4); cmp(memb[es, bx], 0x57);                  /* cmp byte [es:bx], 0x57 */
            ii(0x19_5dfd, 2); if(jz(0x19_5e02, 0x3)) goto l_0x19_5e02;  /* jz 0x5e02 */
            ii(0x19_5dff, 3); jmp(0x19_5e1c, 0x1a); goto l_0x19_5e1c;   /* jmp 0x5e1c */
        l_0x19_5e02:
            ii(0x19_5e02, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_5e05, 3); push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x19_5e08, 1); push(ds);                                 /* push ds */
            ii(0x19_5e09, 3); push(0x112e);                             /* push 0x112e */
            ii(0x19_5e0c, 3); call(0x18_ffd5, -0x5e3a);                 /* call 0xffd5 */
            ii(0x19_5e0f, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5e11, 2); if(jnz(0x19_5e16, 0x3)) goto l_0x19_5e16; /* jnz 0x5e16 */
            ii(0x19_5e13, 3); jmp(0x19_5e1c, 0x6); goto l_0x19_5e1c;    /* jmp 0x5e1c */
        l_0x19_5e16:
            ii(0x19_5e16, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x19_5e19, 3); jmp(0x19_5e25, 0x9); goto l_0x19_5e25;    /* jmp 0x5e25 */
        l_0x19_5e1c:
            ii(0x19_5e1c, 3); jmp(0x19_5de8, -0x37); goto l_0x19_5de8;  /* jmp 0x5de8 */
        l_0x19_5e1f:
            ii(0x19_5e1f, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_5e22, 3); jmp(0x19_5e25, 0); goto l_0x19_5e25;      /* jmp 0x5e25 */
        l_0x19_5e25:
            ii(0x19_5e25, 1); pop(si);                                  /* pop si */
            ii(0x19_5e26, 1); pop(di);                                  /* pop di */
            ii(0x19_5e27, 1); leave();                                  /* leave */
            ii(0x19_5e28, 1); retf();                                   /* retf */
        }
    }
}

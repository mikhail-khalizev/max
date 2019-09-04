using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_8a8a-7442f267")]
        public void Method_0019_8a8a()
        {
            ii(0x19_8a8a, 4); enter(0xe, 0);                            /* enter 0xe, 0x0 */
            ii(0x19_8a8e, 1); push(di);                                 /* push di */
            ii(0x19_8a8f, 1); push(si);                                 /* push si */
            ii(0x19_8a90, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_8a93, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_8a96, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_8a99, 1); nop();                                    /* nop */
            ii(0x19_8a9a, 1); push(cs);                                 /* push cs */
            ii(0x19_8a9b, 3); call(0x19_89cb, -0xd3);                   /* call 0x89cb */
            ii(0x19_8a9e, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_8aa1, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_8aa4, 2); if(jz(0x19_8aa9, 3)) goto l_0x19_8aa9;    /* jz 0x8aa9 */
            ii(0x19_8aa6, 3); jmp(0x19_8aaf, 6); goto l_0x19_8aaf;      /* jmp 0x8aaf */
        l_0x19_8aa9:
            ii(0x19_8aa9, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_8aac, 3); jmp(0x19_8b1c, 0x6d); goto l_0x19_8b1c;   /* jmp 0x8b1c */
        l_0x19_8aaf:
            ii(0x19_8aaf, 5); mov(memw[ss, bp - 4], 0x3512);            /* mov word [bp-0x4], 0x3512 */
            ii(0x19_8ab4, 5); mov(memw[ss, bp - 2], 0x88);              /* mov word [bp-0x2], 0x88 */
            ii(0x19_8ab9, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x19_8abc, 3); mov(memw[ss, bp - 14], ax);               /* mov [bp-0xe], ax */
            ii(0x19_8abf, 5); mov(memw[ss, bp - 12], 0);                /* mov word [bp-0xc], 0x0 */
            ii(0x19_8ac4, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_8ac7, 3); mov(memw[ss, bp - 10], ax);               /* mov [bp-0xa], ax */
            ii(0x19_8aca, 3); lea(ax, memw[ss, bp - 14]);               /* lea ax, [bp-0xe] */
            ii(0x19_8acd, 1); push(ss);                                 /* push ss */
            ii(0x19_8ace, 1); push(ax);                                 /* push ax */
            ii(0x19_8acf, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_8ad2, 5); call_far_abs(0x80, 0xb38);                /* call word 0x80:0xb38 */
            ii(0x19_8ad7, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_8ada, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_8add, 2); if(jz(0x19_8ae2, 3)) goto l_0x19_8ae2;    /* jz 0x8ae2 */
            ii(0x19_8adf, 3); jmp(0x19_8ae8, 6); goto l_0x19_8ae8;      /* jmp 0x8ae8 */
        l_0x19_8ae2:
            ii(0x19_8ae2, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_8ae5, 3); jmp(0x19_8b1c, 0x34); goto l_0x19_8b1c;   /* jmp 0x8b1c */
        l_0x19_8ae8:
            ii(0x19_8ae8, 3); les(bx, memw[ss, bp + 8]);                /* les bx, [bp+0x8] */
            ii(0x19_8aeb, 4); mov(ax, memw[es, bx + 4]);                /* mov ax, [es:bx+0x4] */
            ii(0x19_8aef, 3); les(bx, memw[ss, bp + 8]);                /* les bx, [bp+0x8] */
            ii(0x19_8af2, 4); mov(cx, memw[es, bx + 32]);               /* mov cx, [es:bx+0x20] */
            ii(0x19_8af6, 3); mov(memw[ss, bp - 8], cx);                /* mov [bp-0x8], cx */
            ii(0x19_8af9, 3); mov(memw[ss, bp - 6], ax);                /* mov [bp-0x6], ax */
            ii(0x19_8afc, 3); mov(ax, memw[ss, bp - 8]);                /* mov ax, [bp-0x8] */
            ii(0x19_8aff, 3); mov(dx, memw[ss, bp - 6]);                /* mov dx, [bp-0x6] */
            ii(0x19_8b02, 4); mov(es, memw[ds, 0x3fb6]);                /* mov es, [0x3fb6] */
            ii(0x19_8b06, 3); mov(bx, memw[ss, bp + 6]);                /* mov bx, [bp+0x6] */
            ii(0x19_8b09, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_8b0c, 5); mov(memw[es, bx - 208], ax);              /* mov [es:bx-0xd0], ax */
            ii(0x19_8b11, 5); mov(memw[es, bx - 206], dx);              /* mov [es:bx-0xce], dx */
            ii(0x19_8b16, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_8b19, 3); jmp(0x19_8b1c, 0); goto l_0x19_8b1c;      /* jmp 0x8b1c */
        l_0x19_8b1c:
            ii(0x19_8b1c, 1); pop(si);                                  /* pop si */
            ii(0x19_8b1d, 1); pop(di);                                  /* pop di */
            ii(0x19_8b1e, 1); leave();                                  /* leave */
            ii(0x19_8b1f, 1); retf();                                   /* retf */
        }
    }
}

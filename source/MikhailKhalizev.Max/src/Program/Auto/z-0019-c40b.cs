using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_c40b-7b40bb33")]
        public void Method_0019_c40b()
        {
            ii(0x19_c40b, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x19_c40f, 1); push(di);                                 /* push di */
            ii(0x19_c410, 1); push(si);                                 /* push si */
            ii(0x19_c411, 1); push(ds);                                 /* push ds */
            ii(0x19_c412, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_c415, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_c417, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x19_c41a, 4); les(si, es, bx + 0x1c);                   /* les si, [es:bx+0x1c] */
            ii(0x19_c41e, 3); mov(es, memw[ss, bp + 0x8]);              /* mov es, [bp+0x8] */
            ii(0x19_c421, 4); mov(ax, memw[es, bx + 0x54]);             /* mov ax, [es:bx+0x54] */
            ii(0x19_c425, 4); mov(dx, memw[es, bx + 0x56]);             /* mov dx, [es:bx+0x56] */
            ii(0x19_c429, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_c42c, 4); mov(cx, memw[es, bx + 0x50]);             /* mov cx, [es:bx+0x50] */
            ii(0x19_c430, 4); mov(si, memw[es, bx + 0x52]);             /* mov si, [es:bx+0x52] */
            ii(0x19_c434, 2); mov(di, cx);                              /* mov di, cx */
            ii(0x19_c436, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x19_c438, 3); shl(di, 0x2);                             /* shl di, 0x2 */
            ii(0x19_c43b, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_c43d, 3); mov(memw[ss, bp - 0x16], bx);             /* mov [bp-0x16], bx */
            ii(0x19_c440, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x19_c442, 4); mov(ax, memw[es, bx + di - 0x4]);         /* mov ax, [es:bx+di-0x4] */
            ii(0x19_c446, 4); mov(dx, memw[es, bx + di - 0x2]);         /* mov dx, [es:bx+di-0x2] */
            ii(0x19_c44a, 3); mov(di, memw[ss, bp - 0x16]);             /* mov di, [bp-0x16] */
            ii(0x19_c44d, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x19_c450, 4); mov(memw[es, bx + di - 0x4], ax);         /* mov [es:bx+di-0x4], ax */
            ii(0x19_c454, 4); mov(memw[es, bx + di - 0x2], dx);         /* mov [es:bx+di-0x2], dx */
            ii(0x19_c458, 3); sub(cx, 0x1);                             /* sub cx, 0x1 */
            ii(0x19_c45b, 3); sbb(si, 0);                               /* sbb si, 0x0 */
            ii(0x19_c45e, 3); mov(memw[ss, bp - 0x10], cx);             /* mov [bp-0x10], cx */
            ii(0x19_c461, 3); mov(memw[ss, bp - 0xe], si);              /* mov [bp-0xe], si */
            ii(0x19_c464, 2); jmp(0x19_c46e, 0x8); goto l_0x19_c46e;    /* jmp 0xc46e */
        l_0x19_c466:
            ii(0x19_c466, 4); sub(memw[ss, bp - 0x10], 0x1);            /* sub word [bp-0x10], 0x1 */
            ii(0x19_c46a, 4); sbb(memw[ss, bp - 0xe], 0);               /* sbb word [bp-0xe], 0x0 */
        l_0x19_c46e:
            ii(0x19_c46e, 4); cmp(memw[ss, bp - 0xe], 0);               /* cmp word [bp-0xe], 0x0 */
            ii(0x19_c472, 2); if(jnz(0x19_c47a, 0x6)) goto l_0x19_c47a; /* jnz 0xc47a */
            ii(0x19_c474, 4); cmp(memw[ss, bp - 0x10], 0);              /* cmp word [bp-0x10], 0x0 */
            ii(0x19_c478, 2); if(jz(0x19_c4a6, 0x2c)) goto l_0x19_c4a6; /* jz 0xc4a6 */
        l_0x19_c47a:
            ii(0x19_c47a, 3); mov(bx, memw[ss, bp - 0x10]);             /* mov bx, [bp-0x10] */
            ii(0x19_c47d, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x19_c47f, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x19_c482, 3); mov(si, memw[ss, bp - 0x4]);              /* mov si, [bp-0x4] */
            ii(0x19_c485, 3); mov(cx, memw[es, bx + si]);               /* mov cx, [es:bx+si] */
            ii(0x19_c488, 4); mov(dx, memw[es, bx + si + 0x2]);         /* mov dx, [es:bx+si+0x2] */
            ii(0x19_c48c, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x19_c48e, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x19_c491, 2); add(di, si);                              /* add di, si */
            ii(0x19_c493, 4); mov(memw[es, di - 0x4], cx);              /* mov [es:di-0x4], cx */
            ii(0x19_c497, 4); mov(memw[es, di - 0x2], dx);              /* mov [es:di-0x2], dx */
            ii(0x19_c49b, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x19_c49d, 3); mov(memw[es, di], ax);                    /* mov [es:di], ax */
            ii(0x19_c4a0, 4); mov(memw[es, di + 0x2], dx);              /* mov [es:di+0x2], dx */
            ii(0x19_c4a4, 2); jmp(0x19_c466, -0x40); goto l_0x19_c466;  /* jmp 0xc466 */
        l_0x19_c4a6:
            ii(0x19_c4a6, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_c4a8, 1); pop(ds);                                  /* pop ds */
            ii(0x19_c4a9, 1); pop(si);                                  /* pop si */
            ii(0x19_c4aa, 1); pop(di);                                  /* pop di */
            ii(0x19_c4ab, 1); leave();                                  /* leave */
            ii(0x19_c4ac, 1); retf();                                   /* retf */
        }
    }
}

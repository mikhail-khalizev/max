using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ac57826e-ac65-4edf-9920-3aa7d549b2a2")]
        public void Method_0015_c40b()
        {
            ii(0x15_c40b, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x15_c40f, 1); pushw(di);                                /* push di */
            ii(0x15_c410, 1); pushw(si);                                /* push si */
            ii(0x15_c411, 1); pushw(ds);                                /* push ds */
            ii(0x15_c412, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_c415, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_c417, 3); les(bx, ss, bp + 0x6);                    /* les bx, [bp+0x6] */
            ii(0x15_c41a, 4); les(si, es, bx + 0x1c);                   /* les si, [es:bx+0x1c] */
            ii(0x15_c41e, 3); mov(es, memw_a16[ss, bp + 0x8]);          /* mov es, [bp+0x8] */
            ii(0x15_c421, 4); mov(ax, memw_a16[es, bx + 0x54]);         /* mov ax, [es:bx+0x54] */
            ii(0x15_c425, 4); mov(dx, memw_a16[es, bx + 0x56]);         /* mov dx, [es:bx+0x56] */
            ii(0x15_c429, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_c42c, 4); mov(cx, memw_a16[es, bx + 0x50]);         /* mov cx, [es:bx+0x50] */
            ii(0x15_c430, 4); mov(si, memw_a16[es, bx + 0x52]);         /* mov si, [es:bx+0x52] */
            ii(0x15_c434, 2); mov(di, cx);                              /* mov di, cx */
            ii(0x15_c436, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x15_c438, 3); shl(di, 0x2);                             /* shl di, 0x2 */
            ii(0x15_c43b, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_c43d, 3); mov(memw_a16[ss, bp - 0x16], bx);         /* mov [bp-0x16], bx */
            ii(0x15_c440, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_c442, 4); mov(ax, memw_a16[es, bx + di - 0x4]);     /* mov ax, [es:bx+di-0x4] */
            ii(0x15_c446, 4); mov(dx, memw_a16[es, bx + di - 0x2]);     /* mov dx, [es:bx+di-0x2] */
            ii(0x15_c44a, 3); mov(di, memw_a16[ss, bp - 0x16]);         /* mov di, [bp-0x16] */
            ii(0x15_c44d, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x15_c450, 4); mov(memw_a16[es, bx + di - 0x4], ax);     /* mov [es:bx+di-0x4], ax */
            ii(0x15_c454, 4); mov(memw_a16[es, bx + di - 0x2], dx);     /* mov [es:bx+di-0x2], dx */
            ii(0x15_c458, 3); sub(cx, 0x1);                             /* sub cx, 0x1 */
            ii(0x15_c45b, 3); sbb(si, 0);                               /* sbb si, 0x0 */
            ii(0x15_c45e, 3); mov(memw_a16[ss, bp - 0x10], cx);         /* mov [bp-0x10], cx */
            ii(0x15_c461, 3); mov(memw_a16[ss, bp - 0xe], si);          /* mov [bp-0xe], si */
            ii(0x15_c464, 2); jmpw(0x15_c46e, 0x8); goto l_0x15_c46e;   /* jmp 0xc46e */
        l_0x15_c466:
            ii(0x15_c466, 4); sub(memw_a16[ss, bp - 0x10], 0x1);        /* sub word [bp-0x10], 0x1 */
            ii(0x15_c46a, 4); sbb(memw_a16[ss, bp - 0xe], 0);           /* sbb word [bp-0xe], 0x0 */
        l_0x15_c46e:
            ii(0x15_c46e, 4); cmp(memw_a16[ss, bp - 0xe], 0);           /* cmp word [bp-0xe], 0x0 */
            ii(0x15_c472, 2); if(jnzw(0x15_c47a, 0x6)) goto l_0x15_c47a; /* jnz 0xc47a */
            ii(0x15_c474, 4); cmp(memw_a16[ss, bp - 0x10], 0);          /* cmp word [bp-0x10], 0x0 */
            ii(0x15_c478, 2); if(jzw(0x15_c4a6, 0x2c)) goto l_0x15_c4a6; /* jz 0xc4a6 */
        l_0x15_c47a:
            ii(0x15_c47a, 3); mov(bx, memw_a16[ss, bp - 0x10]);         /* mov bx, [bp-0x10] */
            ii(0x15_c47d, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x15_c47f, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_c482, 3); mov(si, memw_a16[ss, bp - 0x4]);          /* mov si, [bp-0x4] */
            ii(0x15_c485, 3); mov(cx, memw_a16[es, bx + si]);           /* mov cx, [es:bx+si] */
            ii(0x15_c488, 4); mov(dx, memw_a16[es, bx + si + 0x2]);     /* mov dx, [es:bx+si+0x2] */
            ii(0x15_c48c, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x15_c48e, 3); shl(di, 0x3);                             /* shl di, 0x3 */
            ii(0x15_c491, 2); add(di, si);                              /* add di, si */
            ii(0x15_c493, 4); mov(memw_a16[es, di - 0x4], cx);          /* mov [es:di-0x4], cx */
            ii(0x15_c497, 4); mov(memw_a16[es, di - 0x2], dx);          /* mov [es:di-0x2], dx */
            ii(0x15_c49b, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x15_c49d, 3); mov(memw_a16[es, di], ax);                /* mov [es:di], ax */
            ii(0x15_c4a0, 4); mov(memw_a16[es, di + 0x2], dx);          /* mov [es:di+0x2], dx */
            ii(0x15_c4a4, 2); jmpw(0x15_c466, -0x40); goto l_0x15_c466; /* jmp 0xc466 */
        l_0x15_c4a6:
            ii(0x15_c4a6, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_c4a8, 1); popw(ds);                                 /* pop ds */
            ii(0x15_c4a9, 1); popw(si);                                 /* pop si */
            ii(0x15_c4aa, 1); popw(di);                                 /* pop di */
            ii(0x15_c4ab, 1); leavew();                                 /* leave */
            ii(0x15_c4ac, 1); retfw(); return;                          /* retf */
        }
    }
}
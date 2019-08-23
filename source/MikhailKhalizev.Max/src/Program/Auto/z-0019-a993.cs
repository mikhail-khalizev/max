using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_a993-8bb9961e")]
        public void Method_0019_a993()
        {
            ii(0x19_a993, 4); enter(0x2c, 0);                           /* enter 0x2c, 0x0 */
            ii(0x19_a997, 1); push(di);                                 /* push di */
            ii(0x19_a998, 1); push(si);                                 /* push si */
            ii(0x19_a999, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_a99c, 4); mov(ax, memw[es, bx + 0x3c]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_a9a0, 4); mov(dx, memw[es, bx + 0x3e]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_a9a4, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x19_a9a7, 3); mov(memw[ss, bp - 0xe], dx);              /* mov [bp-0xe], dx */
            ii(0x19_a9aa, 4); les(bx, es, bx + 0x1c);                   /* les bx, [es:bx+0x1c] */
            ii(0x19_a9ae, 3); mov(memw[ss, bp - 0x18], bx);             /* mov [bp-0x18], bx */
            ii(0x19_a9b1, 3); mov(memw[ss, bp - 0x16], es);             /* mov [bp-0x16], es */
            ii(0x19_a9b4, 4); mov(ax, memw[es, bx + 0x28]);             /* mov ax, [es:bx+0x28] */
            ii(0x19_a9b8, 4); mov(dx, memw[es, bx + 0x2a]);             /* mov dx, [es:bx+0x2a] */
            ii(0x19_a9bc, 3); mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0x19_a9bf, 3); mov(memw[ss, bp - 0x12], dx);             /* mov [bp-0x12], dx */
            ii(0x19_a9c2, 5); mov(memw[ss, bp - 0x1a], 0);              /* mov word [bp-0x1a], 0x0 */
            ii(0x19_a9c7, 3); jmp(0x19_aaa8, 0xde); goto l_0x19_aaa8;   /* jmp 0xaaa8 */
        l_0x19_a9ca:
            ii(0x19_a9ca, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_a9cc, 3); mov(memw[ss, bp - 0x1c], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_a9cf, 3); mov(memw[ss, bp - 0x1e], ax);             /* mov [bp-0x1e], ax */
            ii(0x19_a9d2, 2); jmp(0x19_aa07, 0x33); goto l_0x19_aa07;   /* jmp 0xaa07 */
        l_0x19_a9d4:
            ii(0x19_a9d4, 3); push(memw[ss, bp - 0x28]);                /* push word [bp-0x28] */
            ii(0x19_a9d7, 3); push(memw[ss, bp - 0x2a]);                /* push word [bp-0x2a] */
            ii(0x19_a9da, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_a9dd, 5); push(memw[es, bx + 0xb4]);                /* push word [es:bx+0xb4] */
            ii(0x19_a9e2, 3); push(memw[ss, bp - 0x20]);                /* push word [bp-0x20] */
            ii(0x19_a9e5, 3); push(memw[ss, bp - 0x22]);                /* push word [bp-0x22] */
            ii(0x19_a9e8, 1); push(dx);                                 /* push dx */
            ii(0x19_a9e9, 1); push(ax);                                 /* push ax */
            ii(0x19_a9ea, 3); call(0x19_cbcd, 0x21e0);                  /* call 0xcbcd */
        l_0x19_a9ed:
            ii(0x19_a9ed, 3); mov(ax, memw[ss, bp - 0x14]);             /* mov ax, [bp-0x14] */
            ii(0x19_a9f0, 3); mov(dx, memw[ss, bp - 0x12]);             /* mov dx, [bp-0x12] */
            ii(0x19_a9f3, 3); add(memw[ss, bp - 0x4], ax);              /* add [bp-0x4], ax */
            ii(0x19_a9f6, 3); adc(memw[ss, bp - 0x2], dx);              /* adc [bp-0x2], dx */
            ii(0x19_a9f9, 3); add(memw[ss, bp - 0x2a], ax);             /* add [bp-0x2a], ax */
            ii(0x19_a9fc, 3); adc(memw[ss, bp - 0x28], dx);             /* adc [bp-0x28], dx */
            ii(0x19_a9ff, 4); add(memw[ss, bp - 0x1e], 0x1);            /* add word [bp-0x1e], 0x1 */
            ii(0x19_aa03, 4); adc(memw[ss, bp - 0x1c], 0);              /* adc word [bp-0x1c], 0x0 */
        l_0x19_aa07:
            ii(0x19_aa07, 3); mov(ax, memw[ss, bp - 0x1e]);             /* mov ax, [bp-0x1e] */
            ii(0x19_aa0a, 3); mov(dx, memw[ss, bp - 0x1c]);             /* mov dx, [bp-0x1c] */
            ii(0x19_aa0d, 4); imul(bx, memw[ss, bp - 0x1a], 0x18);      /* imul bx, [bp-0x1a], 0x18 */
            ii(0x19_aa11, 3); add(bx, memw[ss, bp - 0x10]);             /* add bx, [bp-0x10] */
            ii(0x19_aa14, 3); mov(es, memw[ss, bp - 0xe]);              /* mov es, [bp-0xe] */
            ii(0x19_aa17, 4); cmp(memw[es, bx + 0x12], dx);             /* cmp [es:bx+0x12], dx */
            ii(0x19_aa1b, 2); if(jae(0x19_aa20, 0x3)) goto l_0x19_aa20; /* jae 0xaa20 */
            ii(0x19_aa1d, 3); jmp(0x19_aaa5, 0x85); goto l_0x19_aaa5;   /* jmp 0xaaa5 */
        l_0x19_aa20:
            ii(0x19_aa20, 2); if(ja(0x19_aa28, 0x6)) goto l_0x19_aa28;  /* ja 0xaa28 */
            ii(0x19_aa22, 4); cmp(memw[es, bx + 0x10], ax);             /* cmp [es:bx+0x10], ax */
            ii(0x19_aa26, 2); if(jbe(0x19_aaa5, 0x7d)) goto l_0x19_aaa5; /* jbe 0xaaa5 */
        l_0x19_aa28:
            ii(0x19_aa28, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_aa2b, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_aa2e, 3); push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x19_aa31, 1); push(ax);                                 /* push ax */
            ii(0x19_aa32, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x19_aa35, 1); push(ss);                                 /* push ss */
            ii(0x19_aa36, 1); push(ax);                                 /* push ax */
            ii(0x19_aa37, 3); lea(cx, bp - 0x22);                       /* lea cx, [bp-0x22] */
            ii(0x19_aa3a, 1); push(ss);                                 /* push ss */
            ii(0x19_aa3b, 1); push(cx);                                 /* push cx */
            ii(0x19_aa3c, 3); lea(cx, bp - 0x8);                        /* lea cx, [bp-0x8] */
            ii(0x19_aa3f, 1); push(ss);                                 /* push ss */
            ii(0x19_aa40, 1); push(cx);                                 /* push cx */
            ii(0x19_aa41, 2); mov(si, bx);                              /* mov si, bx */
            ii(0x19_aa43, 2); mov(di, es);                              /* mov di, es */
            ii(0x19_aa45, 3); call(0x19_dc78, 0x3230);                  /* call 0xdc78 */
            ii(0x19_aa48, 3); mov(memw[ss, bp - 0x2c], ax);             /* mov [bp-0x2c], ax */
            ii(0x19_aa4b, 2); mov(es, di);                              /* mov es, di */
            ii(0x19_aa4d, 3); mov(ax, memw[es, si]);                    /* mov ax, [es:si] */
            ii(0x19_aa50, 4); mov(dx, memw[es, si + 0x2]);              /* mov dx, [es:si+0x2] */
            ii(0x19_aa54, 3); sub(ax, memw[ss, bp - 0x4]);              /* sub ax, [bp-0x4] */
            ii(0x19_aa57, 3); sbb(dx, memw[ss, bp - 0x2]);              /* sbb dx, [bp-0x2] */
            ii(0x19_aa5a, 3); cmp(dx, memw[ss, bp - 0x24]);             /* cmp dx, [bp-0x24] */
            ii(0x19_aa5d, 2); if(jb(0x19_aa6c, 0xd)) goto l_0x19_aa6c;  /* jb 0xaa6c */
            ii(0x19_aa5f, 2); if(ja(0x19_aa66, 0x5)) goto l_0x19_aa66;  /* ja 0xaa66 */
            ii(0x19_aa61, 3); cmp(ax, memw[ss, bp - 0x26]);             /* cmp ax, [bp-0x26] */
            ii(0x19_aa64, 2); if(jbe(0x19_aa6c, 0x6)) goto l_0x19_aa6c; /* jbe 0xaa6c */
        l_0x19_aa66:
            ii(0x19_aa66, 3); mov(dx, memw[ss, bp - 0x24]);             /* mov dx, [bp-0x24] */
            ii(0x19_aa69, 3); mov(ax, memw[ss, bp - 0x26]);             /* mov ax, [bp-0x26] */
        l_0x19_aa6c:
            ii(0x19_aa6c, 3); mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
            ii(0x19_aa6f, 3); mov(memw[ss, bp - 0x24], dx);             /* mov [bp-0x24], dx */
            ii(0x19_aa72, 4); cmp(memw[ss, bp - 0x2c], 0);              /* cmp word [bp-0x2c], 0x0 */
            ii(0x19_aa76, 2); if(jz(0x19_aa7b, 0x3)) goto l_0x19_aa7b;  /* jz 0xaa7b */
            ii(0x19_aa78, 3); jmp(0x19_a9ed, -0x8e); goto l_0x19_a9ed;  /* jmp 0xa9ed */
        l_0x19_aa7b:
            ii(0x19_aa7b, 5); cmp(memb[ds, 0x19f4], 0x1);               /* cmp byte [0x19f4], 0x1 */
            ii(0x19_aa80, 2); if(jz(0x19_aa85, 0x3)) goto l_0x19_aa85;  /* jz 0xaa85 */
            ii(0x19_aa82, 3); jmp(0x19_a9d4, -0xb1); goto l_0x19_a9d4;  /* jmp 0xa9d4 */
        l_0x19_aa85:
            ii(0x19_aa85, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x19_aa88, 4); les(bx, es, bx + 0x38);                   /* les bx, [es:bx+0x38] */
            ii(0x19_aa8c, 4); push(memw[es, bx + 0x2]);                 /* push word [es:bx+0x2] */
            ii(0x19_aa90, 3); push(memw[es, bx]);                       /* push word [es:bx] */
            ii(0x19_aa93, 1); push(dx);                                 /* push dx */
            ii(0x19_aa94, 1); push(ax);                                 /* push ax */
            ii(0x19_aa95, 3); push(memw[ss, bp - 0x28]);                /* push word [bp-0x28] */
            ii(0x19_aa98, 3); push(memw[ss, bp - 0x2a]);                /* push word [bp-0x2a] */
            ii(0x19_aa9b, 4); call_far_ind(ds, 0x1a04);                 /* call far word [0x1a04] */
            ii(0x19_aa9f, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_aaa2, 3); jmp(0x19_a9ed, -0xb8); goto l_0x19_a9ed;  /* jmp 0xa9ed */
        l_0x19_aaa5:
            ii(0x19_aaa5, 3); inc(memw[ss, bp - 0x1a]);                 /* inc word [bp-0x1a] */
        l_0x19_aaa8:
            ii(0x19_aaa8, 3); mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0x19_aaab, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x19_aaae, 4); cmp(memw[es, bx + 0x44], ax);             /* cmp [es:bx+0x44], ax */
            ii(0x19_aab2, 2); if(jbe(0x19_aaed, 0x39)) goto l_0x19_aaed; /* jbe 0xaaed */
            ii(0x19_aab4, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_aab6, 3); mov(memw[ss, bp - 0x2], cx);              /* mov [bp-0x2], cx */
            ii(0x19_aab9, 3); mov(memw[ss, bp - 0x4], cx);              /* mov [bp-0x4], cx */
            ii(0x19_aabc, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_aabf, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_aac2, 1); push(ax);                                 /* push ax */
            ii(0x19_aac3, 2); push(0x1);                                /* push 0x1 */
            ii(0x19_aac5, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_aac8, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_aacb, 1); inc(ax);                                  /* inc ax */
            ii(0x19_aacc, 1); push(ax);                                 /* push ax */
            ii(0x19_aacd, 3); call(0x19_a8a9, -0x227);                  /* call 0xa8a9 */
            ii(0x19_aad0, 3); mov(memw[ss, bp - 0xc], ax);              /* mov [bp-0xc], ax */
            ii(0x19_aad3, 3); mov(memw[ss, bp - 0xa], dx);              /* mov [bp-0xa], dx */
            ii(0x19_aad6, 1); push(dx);                                 /* push dx */
            ii(0x19_aad7, 1); push(ax);                                 /* push ax */
            ii(0x19_aad8, 3); call(0x19_c975, 0x1e9a);                  /* call 0xc975 */
            ii(0x19_aadb, 3); mov(memw[ss, bp - 0x2a], ax);             /* mov [bp-0x2a], ax */
            ii(0x19_aade, 3); mov(memw[ss, bp - 0x28], dx);             /* mov [bp-0x28], dx */
            ii(0x19_aae1, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_aae3, 2); if(jz(0x19_aae8, 0x3)) goto l_0x19_aae8;  /* jz 0xaae8 */
            ii(0x19_aae5, 3); jmp(0x19_a9ca, -0x11e); goto l_0x19_a9ca; /* jmp 0xa9ca */
        l_0x19_aae8:
            ii(0x19_aae8, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x19_aaeb, 2); jmp(0x19_aaef, 0x2); goto l_0x19_aaef;    /* jmp 0xaaef */
        l_0x19_aaed:
            ii(0x19_aaed, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x19_aaef:
            ii(0x19_aaef, 1); pop(si);                                  /* pop si */
            ii(0x19_aaf0, 1); pop(di);                                  /* pop di */
            ii(0x19_aaf1, 1); leave();                                  /* leave */
            ii(0x19_aaf2, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}

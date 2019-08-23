using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_df78-6611adb6")]
        public void Method_0019_df78()
        {
            ii(0x19_df78, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x19_df7c, 1); push(si);                                 /* push si */
            ii(0x19_df7d, 4); mov(es, memw[ds, 0x3fc8]);                /* mov es, [0x3fc8] */
            ii(0x19_df81, 4); mov(ax, memw[es, 0x3b84]);                /* mov ax, [es:0x3b84] */
            ii(0x19_df85, 5); mov(memw[ss, bp - 0x6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x19_df8a, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_df8d, 4); mov(ax, memw[es, 0x3b72]);                /* mov ax, [es:0x3b72] */
            ii(0x19_df91, 5); mov(memw[ss, bp - 0xa], 0);               /* mov word [bp-0xa], 0x0 */
            ii(0x19_df96, 3); mov(memw[ss, bp - 0x8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_df99, 3); mov(ax, memw[ss, bp + 0x6]);              /* mov ax, [bp+0x6] */
            ii(0x19_df9c, 3); mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_df9f, 3); or(ax, memw[ss, bp + 0x4]);               /* or ax, [bp+0x4] */
            ii(0x19_dfa2, 2); if(jz(0x19_dffc, 0x58)) goto l_0x19_dffc; /* jz 0xdffc */
            ii(0x19_dfa4, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_dfa7, 3); push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x19_dfaa, 5); call_far_abs(0x80, 0x4f60);               /* call word 0x80:0x4f60 */
            ii(0x19_dfaf, 1); pop(bx);                                  /* pop bx */
            ii(0x19_dfb0, 1); pop(bx);                                  /* pop bx */
            ii(0x19_dfb1, 5); cmp(memw[ss, bp - 0x2], 0x1000);          /* cmp word [bp-0x2], 0x1000 */
            ii(0x19_dfb6, 2); if(jae(0x19_dffc, 0x44)) goto l_0x19_dffc; /* jae 0xdffc */
            ii(0x19_dfb8, 4); mov(es, memw[ds, 0x3fcc]);                /* mov es, [0x3fcc] */
            ii(0x19_dfbc, 4); mov(ax, memw[es, 0x32b2]);                /* mov ax, [es:0x32b2] */
            ii(0x19_dfc0, 5); or(ax, memw[es, 0x32b0]);                 /* or ax, [es:0x32b0] */
            ii(0x19_dfc5, 2); if(jz(0x19_dffc, 0x35)) goto l_0x19_dffc; /* jz 0xdffc */
            ii(0x19_dfc7, 3); mov(bx, memw[ss, bp - 0x2]);              /* mov bx, [bp-0x2] */
            ii(0x19_dfca, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x19_dfcd, 3); les(si, memw[ss, bp - 0x6]);              /* les si, [bp-0x6] */
            ii(0x19_dfd0, 3); mov(al, memb[es, bx + si]);               /* mov al, [es:bx+si] */
            ii(0x19_dfd3, 1); cbw();                                    /* cbw */
            ii(0x19_dfd4, 1); push(ax);                                 /* push ax */
            ii(0x19_dfd5, 3); mov(bx, memw[ss, bp - 0x2]);              /* mov bx, [bp-0x2] */
            ii(0x19_dfd8, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x19_dfdb, 3); les(si, memw[ss, bp - 0xa]);              /* les si, [bp-0xa] */
            ii(0x19_dfde, 4); push(memw[es, bx + si + 0x6]);            /* push word [es:bx+si+0x6] */
            ii(0x19_dfe2, 4); push(memw[es, bx + si + 0x4]);            /* push word [es:bx+si+0x4] */
            ii(0x19_dfe6, 4); push(memw[es, bx + si + 0x2]);            /* push word [es:bx+si+0x2] */
            ii(0x19_dfea, 3); push(memw[es, bx + si]);                  /* push word [es:bx+si] */
            ii(0x19_dfed, 3); push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x19_dff0, 4); mov(es, memw[ds, 0x3fcc]);                /* mov es, [0x3fcc] */
            ii(0x19_dff4, 5); call_far_ind(es, 0x32b0);                 /* call far word [es:0x32b0] */
            ii(0x19_dff9, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_dffc:
            ii(0x19_dffc, 1); pop(si);                                  /* pop si */
            ii(0x19_dffd, 1); leave();                                  /* leave */
            ii(0x19_dffe, 3); ret(0x4);                                 /* ret 0x4 */
        }
    }
}

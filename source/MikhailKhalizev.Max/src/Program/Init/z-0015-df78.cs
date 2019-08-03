using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("daf51eb8-a419-49f1-b8e0-def20af04049")]
        public void Method_0015_df78()
        {
            ii(0x15_df78, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x15_df7c, 1); pushw(si);                                /* push si */
            ii(0x15_df7d, 4); mov(es, memw_a16[ds, 0x3fc8]);            /* mov es, [0x3fc8] */
            ii(0x15_df81, 4); mov(ax, memw_a16[es, 0x3b84]);            /* mov ax, [es:0x3b84] */
            ii(0x15_df85, 5); mov(memw_a16[ss, bp - 0x6], 0);           /* mov word [bp-0x6], 0x0 */
            ii(0x15_df8a, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_df8d, 4); mov(ax, memw_a16[es, 0x3b72]);            /* mov ax, [es:0x3b72] */
            ii(0x15_df91, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x15_df96, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_df99, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_df9c, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_df9f, 3); or(ax, memw_a16[ss, bp + 0x4]);           /* or ax, [bp+0x4] */
            ii(0x15_dfa2, 2); if(jzw(0x15_dffc, 0x58)) goto l_0x15_dffc; /* jz 0xdffc */
            ii(0x15_dfa4, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_dfa7, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_dfaa, 5); callw_far_abs(0x80, 0x4f60);              /* call word 0x80:0x4f60 */
            ii(0x15_dfaf, 1); popw(bx);                                 /* pop bx */
            ii(0x15_dfb0, 1); popw(bx);                                 /* pop bx */
            ii(0x15_dfb1, 5); cmp(memw_a16[ss, bp - 0x2], 0x1000);      /* cmp word [bp-0x2], 0x1000 */
            ii(0x15_dfb6, 2); if(jaew(0x15_dffc, 0x44)) goto l_0x15_dffc; /* jae 0xdffc */
            ii(0x15_dfb8, 4); mov(es, memw_a16[ds, 0x3fcc]);            /* mov es, [0x3fcc] */
            ii(0x15_dfbc, 4); mov(ax, memw_a16[es, 0x32b2]);            /* mov ax, [es:0x32b2] */
            ii(0x15_dfc0, 5); or(ax, memw_a16[es, 0x32b0]);             /* or ax, [es:0x32b0] */
            ii(0x15_dfc5, 2); if(jzw(0x15_dffc, 0x35)) goto l_0x15_dffc; /* jz 0xdffc */
            ii(0x15_dfc7, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x15_dfca, 3); shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x15_dfcd, 3); les(si, ss, bp - 0x6);                    /* les si, [bp-0x6] */
            ii(0x15_dfd0, 3); mov(al, memb_a16[es, bx + si]);           /* mov al, [es:bx+si] */
            ii(0x15_dfd3, 1); cbw();                                    /* cbw */
            ii(0x15_dfd4, 1); pushw(ax);                                /* push ax */
            ii(0x15_dfd5, 3); mov(bx, memw_a16[ss, bp - 0x2]);          /* mov bx, [bp-0x2] */
            ii(0x15_dfd8, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x15_dfdb, 3); les(si, ss, bp - 0xa);                    /* les si, [bp-0xa] */
            ii(0x15_dfde, 4); pushw(memw_a16[es, bx + si + 0x6]);       /* push word [es:bx+si+0x6] */
            ii(0x15_dfe2, 4); pushw(memw_a16[es, bx + si + 0x4]);       /* push word [es:bx+si+0x4] */
            ii(0x15_dfe6, 4); pushw(memw_a16[es, bx + si + 0x2]);       /* push word [es:bx+si+0x2] */
            ii(0x15_dfea, 3); pushw(memw_a16[es, bx + si]);             /* push word [es:bx+si] */
            ii(0x15_dfed, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_dff0, 4); mov(es, memw_a16[ds, 0x3fcc]);            /* mov es, [0x3fcc] */
            ii(0x15_dff4, 5); callw_a16_far_ind(es, 0x32b0);            /* call far word [es:0x32b0] */
            ii(0x15_dff9, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x15_dffc:
            ii(0x15_dffc, 1); popw(si);                                 /* pop si */
            ii(0x15_dffd, 1); leavew();                                 /* leave */
            ii(0x15_dffe, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}

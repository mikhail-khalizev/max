using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6c86b072-6b4e-4ca0-b161-c1d3ab0c5f74")]
        public void Method_0015_60d4()
        {
            ii(0x15_60d4, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x15_60d8, 1); pushw(di);                                /* push di */
            ii(0x15_60d9, 1); pushw(si);                                /* push si */
            ii(0x15_60da, 4); cmp(memw_a16[ss, bp + 0x6], 0xd);         /* cmp word [bp+0x6], 0xd */
            ii(0x15_60de, 2); if(jnzw(0x15_60e3, 0x3)) goto l_0x15_60e3; /* jnz 0x60e3 */
            ii(0x15_60e0, 3); jmpw(0x15_60fe, 0x1b); goto l_0x15_60fe;  /* jmp 0x60fe */
        l_0x15_60e3:
            ii(0x15_60e3, 4); cmp(memw_a16[ss, bp + 0x6], 0x8);         /* cmp word [bp+0x6], 0x8 */
            ii(0x15_60e7, 2); if(jgew(0x15_60ec, 0x3)) goto l_0x15_60ec; /* jge 0x60ec */
            ii(0x15_60e9, 3); jmpw(0x15_60f5, 0x9); goto l_0x15_60f5;   /* jmp 0x60f5 */
        l_0x15_60ec:
            ii(0x15_60ec, 4); cmp(memw_a16[ss, bp + 0x6], 0x2f);        /* cmp word [bp+0x6], 0x2f */
            ii(0x15_60f0, 2); if(jgw(0x15_60f5, 0x3)) goto l_0x15_60f5; /* jg 0x60f5 */
            ii(0x15_60f2, 3); jmpw(0x15_60fe, 0x9); goto l_0x15_60fe;   /* jmp 0x60fe */
        l_0x15_60f5:
            ii(0x15_60f5, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_60f8, 3); mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x15_60fb, 3); jmpw(0x15_612d, 0x2f); goto l_0x15_612d;  /* jmp 0x612d */
        l_0x15_60fe:
            ii(0x15_60fe, 4); mov(memb_a16[ss, bp - 0xd], 0x35);        /* mov byte [bp-0xd], 0x35 */
            ii(0x15_6102, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x15_6105, 3); mov(memb_a16[ss, bp - 0xe], al);          /* mov [bp-0xe], al */
            ii(0x15_6108, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x15_610b, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_610e, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x15_6111, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x15_6114, 1); pushw(ss);                                /* push ss */
            ii(0x15_6115, 1); pushw(ax);                                /* push ax */
            ii(0x15_6116, 3); lea(cx, bp - 0xe);                        /* lea cx, [bp-0xe] */
            ii(0x15_6119, 1); pushw(ss);                                /* push ss */
            ii(0x15_611a, 1); pushw(cx);                                /* push cx */
            ii(0x15_611b, 1); pushw(ss);                                /* push ss */
            ii(0x15_611c, 1); pushw(cx);                                /* push cx */
            ii(0x15_611d, 4); callw_a16_far_ind(ds, 0x1286);            /* call far word [0x1286] */
            ii(0x15_6121, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x15_6124, 3); mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0x15_6127, 3); mov(dx, memw_a16[ss, bp - 0x16]);         /* mov dx, [bp-0x16] */
            ii(0x15_612a, 3); jmpw(0x15_612d, 0); goto l_0x15_612d;     /* jmp 0x612d */
        l_0x15_612d:
            ii(0x15_612d, 1); popw(si);                                 /* pop si */
            ii(0x15_612e, 1); popw(di);                                 /* pop di */
            ii(0x15_612f, 1); leavew();                                 /* leave */
            ii(0x15_6130, 1); retfw(); return;                          /* retf */
        }
    }
}

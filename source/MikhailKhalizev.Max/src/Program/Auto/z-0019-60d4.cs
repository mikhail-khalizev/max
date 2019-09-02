using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_60d4-14bbb1e2")]
        public void Method_0019_60d4()
        {
            ii(0x19_60d4, 4); enter(0x16, 0);                           /* enter 0x16, 0x0 */
            ii(0x19_60d8, 1); push(di);                                 /* push di */
            ii(0x19_60d9, 1); push(si);                                 /* push si */
            ii(0x19_60da, 4); cmp(memw[ss, bp + 6], 0xd);               /* cmp word [bp+0x6], 0xd */
            ii(0x19_60de, 2); if(jnz(0x19_60e3, 3)) goto l_0x19_60e3;   /* jnz 0x60e3 */
            ii(0x19_60e0, 3); jmp(0x19_60fe, 0x1b); goto l_0x19_60fe;   /* jmp 0x60fe */
        l_0x19_60e3:
            ii(0x19_60e3, 4); cmp(memw[ss, bp + 6], 8);                 /* cmp word [bp+0x6], 0x8 */
            ii(0x19_60e7, 2); if(jge(0x19_60ec, 3)) goto l_0x19_60ec;   /* jge 0x60ec */
            ii(0x19_60e9, 3); jmp(0x19_60f5, 9); goto l_0x19_60f5;      /* jmp 0x60f5 */
        l_0x19_60ec:
            ii(0x19_60ec, 4); cmp(memw[ss, bp + 6], 0x2f);              /* cmp word [bp+0x6], 0x2f */
            ii(0x19_60f0, 2); if(jg(0x19_60f5, 3)) goto l_0x19_60f5;    /* jg 0x60f5 */
            ii(0x19_60f2, 3); jmp(0x19_60fe, 9); goto l_0x19_60fe;      /* jmp 0x60fe */
        l_0x19_60f5:
            ii(0x19_60f5, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_60f8, 3); mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x19_60fb, 3); jmp(0x19_612d, 0x2f); goto l_0x19_612d;   /* jmp 0x612d */
        l_0x19_60fe:
            ii(0x19_60fe, 4); mov(memb[ss, bp - 0xd], 0x35);            /* mov byte [bp-0xd], 0x35 */
            ii(0x19_6102, 3); mov(al, memb[ss, bp + 6]);                /* mov al, [bp+0x6] */
            ii(0x19_6105, 3); mov(memb[ss, bp - 0xe], al);              /* mov [bp-0xe], al */
            ii(0x19_6108, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_610b, 3); mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x19_610e, 3); mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0x19_6111, 3); lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0x19_6114, 1); push(ss);                                 /* push ss */
            ii(0x19_6115, 1); push(ax);                                 /* push ax */
            ii(0x19_6116, 3); lea(cx, memw[ss, bp - 0xe]);              /* lea cx, [bp-0xe] */
            ii(0x19_6119, 1); push(ss);                                 /* push ss */
            ii(0x19_611a, 1); push(cx);                                 /* push cx */
            ii(0x19_611b, 1); push(ss);                                 /* push ss */
            ii(0x19_611c, 1); push(cx);                                 /* push cx */
            ii(0x19_611d, 4); call_far_ind(memw[ds, 0x1286]);           /* call far word [0x1286] */
            ii(0x19_6121, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_6124, 3); mov(ax, memw[ss, bp - 0xc]);              /* mov ax, [bp-0xc] */
            ii(0x19_6127, 3); mov(dx, memw[ss, bp - 0x16]);             /* mov dx, [bp-0x16] */
            ii(0x19_612a, 3); jmp(0x19_612d, 0); goto l_0x19_612d;      /* jmp 0x612d */
        l_0x19_612d:
            ii(0x19_612d, 1); pop(si);                                  /* pop si */
            ii(0x19_612e, 1); pop(di);                                  /* pop di */
            ii(0x19_612f, 1); leave();                                  /* leave */
            ii(0x19_6130, 1); retf();                                   /* retf */
        }
    }
}

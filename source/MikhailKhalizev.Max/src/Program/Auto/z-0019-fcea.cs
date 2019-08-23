using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_fcea-d194a360")]
        public void Method_0019_fcea()
        {
            ii(0x19_fcea, 4); mov(es, memw_a16[ds, 0x3fe2]);            /* mov es, [0x3fe2] */
            ii(0x19_fcee, 4); mov(ax, memw_a16[es, 0x3b78]);            /* mov ax, [es:0x3b78] */
            ii(0x19_fcf2, 2); sub(cx, cx);                              /* sub cx, cx */
            ii(0x19_fcf4, 5); cmp(memw_a16[ds, 0x31aa], -0x1 /* 0xff */); /* cmp word [0x31aa], 0xffff */
            ii(0x19_fcf9, 2); if(jnzw(0x19_fd0e, 0x13)) goto l_0x19_fd0e; /* jnz 0xfd0e */
            ii(0x19_fcfb, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_fcfd, 2); mov(bx, cx);                              /* mov bx, cx */
            ii(0x19_fcff, 4); mov(al, memb_a16[es, bx + 0x47]);         /* mov al, [es:bx+0x47] */
            ii(0x19_fd03, 2); and(al, 0x80);                            /* and al, 0x80 */
            ii(0x19_fd05, 2); cmp(al, 0x1);                             /* cmp al, 0x1 */
            ii(0x19_fd07, 2); sbb(ax, ax);                              /* sbb ax, ax */
            ii(0x19_fd09, 2); neg(ax);                                  /* neg ax */
            ii(0x19_fd0b, 3); mov(memw_a16[ds, 0x31aa], ax);            /* mov [0x31aa], ax */
        l_0x19_fd0e:
            ii(0x19_fd0e, 3); mov(ax, memw_a16[ds, 0x31aa]);            /* mov ax, [0x31aa] */
            ii(0x19_fd11, 1); retw();                                   /* ret */
        }
    }
}

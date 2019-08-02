using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("684ff586-1e1d-4fca-aa26-bd517dc3cde7")]
        public void Method_0013_8ff5()
        {
            ii(0x13_8ff5, 1); pushw(es);                                /* push es */
            ii(0x13_8ff6, 1); pushw(di);                                /* push di */
            ii(0x13_8ff7, 1); pushw(cx);                                /* push cx */
            ii(0x13_8ff8, 4); les(di, ds, 0x4fa4);                      /* les di, [0x4fa4] */
            ii(0x13_8ffc, 4); mov(cx, memw_a16[ds, 0x50bc]);            /* mov cx, [0x50bc] */
            ii(0x13_9000, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x13_9003, 3); repne_a16(() => scasd_a16());             /* repne scasd */
            ii(0x13_9006, 4); if(jnzw(0x13_9013, 0x9)) goto l_0x13_9013; /* jnz 0x9013 */
            ii(0x13_900a, 3); mov(ax, memw_a16[ds, 0x50bc]);            /* mov ax, [0x50bc] */
            ii(0x13_900d, 1); inc(cx);                                  /* inc cx */
            ii(0x13_900e, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x13_9010, 2); jmpw(0x13_9016, 0x4); goto l_0x13_9016;   /* jmp 0x9016 */
        //  ii(0x13_9012, 1); Недостижимый код.
l_0x13_9013:
            ii(0x13_9013, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x13_9016:
            ii(0x13_9016, 1); popw(cx);                                 /* pop cx */
            ii(0x13_9017, 1); popw(di);                                 /* pop di */
            ii(0x13_9018, 1); popw(es);                                 /* pop es */
            ii(0x13_9019, 1); retfw(); return;                          /* retf */
        }
    }
}

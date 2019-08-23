using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_8ff5-d11c182e")]
        public void Method_0017_8ff5()
        {
            ii(0x17_8ff5, 1); push(es);                                 /* push es */
            ii(0x17_8ff6, 1); push(di);                                 /* push di */
            ii(0x17_8ff7, 1); push(cx);                                 /* push cx */
            ii(0x17_8ff8, 4); les(di, ds, 0x4fa4);                      /* les di, [0x4fa4] */
            ii(0x17_8ffc, 4); mov(cx, memw[ds, 0x50bc]);                /* mov cx, [0x50bc] */
            ii(0x17_9000, 3); xor(eax, eax);                            /* xor eax, eax */
            ii(0x17_9003, 3); repne(() => scasd());                     /* repne scasd */
            ii(0x17_9006, 4); if(jnz(0x17_9013, 0x9)) goto l_0x17_9013; /* jnz 0x9013 */
            ii(0x17_900a, 3); mov(ax, memw[ds, 0x50bc]);                /* mov ax, [0x50bc] */
            ii(0x17_900d, 1); inc(cx);                                  /* inc cx */
            ii(0x17_900e, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_9010, 2); jmp(0x17_9016, 0x4); goto l_0x17_9016;    /* jmp 0x9016 */
        //  ii(0x17_9012, 1); nop();                                    /* nop */
        l_0x17_9013:
            ii(0x17_9013, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x17_9016:
            ii(0x17_9016, 1); pop(cx);                                  /* pop cx */
            ii(0x17_9017, 1); pop(di);                                  /* pop di */
            ii(0x17_9018, 1); pop(es);                                  /* pop es */
            ii(0x17_9019, 1); retf();                                   /* retf */
        }
    }
}

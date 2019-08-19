using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_901a-476d2579")]
        public void Method_0017_901a()
        {
            ii(0x17_901a, 1); pushw(bp);                                /* push bp */
            ii(0x17_901b, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_901d, 1); pushw(es);                                /* push es */
            ii(0x17_901e, 1); pushw(di);                                /* push di */
            ii(0x17_901f, 1); pushw(cx);                                /* push cx */
            ii(0x17_9020, 4); mov(cx, memw_a16[ds, 0x519e]);            /* mov cx, [0x519e] */
            ii(0x17_9024, 4); mov(eax, memd_a16[ss, bp + 0x6]);         /* mov eax, [bp+0x6] */
            ii(0x17_9028, 4); les(di, ds, 0x4fa4);                      /* les di, [0x4fa4] */
            ii(0x17_902c, 3); repne_a16(() => scasd_a16());             /* repne scasd */
            ii(0x17_902f, 4); if(jnzw(0x17_903c, 0x9)) goto l_0x17_903c; /* jnz 0x903c */
            ii(0x17_9033, 3); mov(ax, memw_a16[ds, 0x519e]);            /* mov ax, [0x519e] */
            ii(0x17_9036, 1); inc(cx);                                  /* inc cx */
            ii(0x17_9037, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x17_9039, 2); jmpw(0x17_903f, 0x4); goto l_0x17_903f;   /* jmp 0x903f */
        //  ii(0x17_903b, 1); nop();                                    /* nop */
        l_0x17_903c:
            ii(0x17_903c, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x17_903f:
            ii(0x17_903f, 1); popw(cx);                                 /* pop cx */
            ii(0x17_9040, 1); popw(di);                                 /* pop di */
            ii(0x17_9041, 1); popw(es);                                 /* pop es */
            ii(0x17_9042, 1); popw(bp);                                 /* pop bp */
            ii(0x17_9043, 1); retfw(); return;                          /* retf */
        }
    }
}

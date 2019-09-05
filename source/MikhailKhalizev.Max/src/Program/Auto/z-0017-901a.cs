using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_901a-476d2579")]
        public void Method_0017_901a()
        {
            ii(0x17_901a, 1);  push(bp);                               /* push bp */
            ii(0x17_901b, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_901d, 1);  push(es);                               /* push es */
            ii(0x17_901e, 1);  push(di);                               /* push di */
            ii(0x17_901f, 1);  push(cx);                               /* push cx */
            ii(0x17_9020, 4);  mov(cx, memw[ds, 0x519e]);              /* mov cx, [0x519e] */
            ii(0x17_9024, 4);  mov(eax, memd[ss, bp + 6]);             /* mov eax, [bp+0x6] */
            ii(0x17_9028, 4);  les(di, memw[ds, 0x4fa4]);              /* les di, [0x4fa4] */
            ii(0x17_902c, 3);  repne(() => scasd());                   /* repne scasd */
            ii(0x17_902f, 4);  if(jnz(0x17_903c, 9)) goto l_0x17_903c; /* jnz 0x903c */
            ii(0x17_9033, 3);  mov(ax, memw[ds, 0x519e]);              /* mov ax, [0x519e] */
            ii(0x17_9036, 1);  inc(cx);                                /* inc cx */
            ii(0x17_9037, 2);  sub(ax, cx);                            /* sub ax, cx */
            ii(0x17_9039, 2);  jmp(0x17_903f, 4); goto l_0x17_903f;    /* jmp 0x903f */
        //  ii(0x17_903b, 1);  Недостижимый код.
        l_0x17_903c:
            ii(0x17_903c, 3);  mov(ax, 0xffff);                        /* mov ax, 0xffff */
        l_0x17_903f:
            ii(0x17_903f, 1);  pop(cx);                                /* pop cx */
            ii(0x17_9040, 1);  pop(di);                                /* pop di */
            ii(0x17_9041, 1);  pop(es);                                /* pop es */
            ii(0x17_9042, 1);  pop(bp);                                /* pop bp */
            ii(0x17_9043, 1);  retf();                                 /* retf */
        }
    }
}

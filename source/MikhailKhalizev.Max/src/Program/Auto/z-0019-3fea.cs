using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3fea-969aec93")]
        public void Method_0019_3fea()
        {
            ii(0x19_3fea, 1); push(es);                                 /* push es */
            ii(0x19_3feb, 1); push(di);                                 /* push di */
            ii(0x19_3fec, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x19_3fee, 2); add(di, bx);                              /* add di, bx */
            ii(0x19_3ff0, 3); mov(memw[ds, bx + 0x4], di);              /* mov [bx+0x4], di */
            ii(0x19_3ff3, 1); dec(di);                                  /* dec di */
            ii(0x19_3ff4, 1); dec(di);                                  /* dec di */
            ii(0x19_3ff5, 3); sub(ax, 0x16);                            /* sub ax, 0x16 */
            ii(0x19_3ff8, 3); lea(si, memw[ds, bx + 0x14]);             /* lea si, [bx+0x14] */
            ii(0x19_3ffb, 4); mov(memw[ds, di], 0xfffe);                /* mov word [di], 0xfffe */
            ii(0x19_3fff, 3); mov(memw[ds, bx + 0xa], di);              /* mov [bx+0xa], di */
            ii(0x19_4002, 1); dec(ax);                                  /* dec ax */
            ii(0x19_4003, 2); mov(memw[ds, si], ax);                    /* mov [si], ax */
            ii(0x19_4005, 2); mov(memw[ds, bx], ds);                    /* mov [bx], ds */
            ii(0x19_4007, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x19_4009, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x19_400b, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x19_400d, 3); lea(di, memw[ds, bx + 0x6]);              /* lea di, [bx+0x6] */
            ii(0x19_4010, 1); cld();                                    /* cld */
            ii(0x19_4011, 1); stosw();                                  /* stosw */
            ii(0x19_4012, 1); stosw();                                  /* stosw */
            ii(0x19_4013, 1); inc(di);                                  /* inc di */
            ii(0x19_4014, 1); inc(di);                                  /* inc di */
            ii(0x19_4015, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x19_4017, 1); stosw();                                  /* stosw */
            ii(0x19_4018, 1); stosw();                                  /* stosw */
            ii(0x19_4019, 1); stosw();                                  /* stosw */
            ii(0x19_401a, 1); stosw();                                  /* stosw */
            ii(0x19_401b, 1); pop(di);                                  /* pop di */
            ii(0x19_401c, 1); pop(es);                                  /* pop es */
            ii(0x19_401d, 1); ret();                                    /* ret */
        }
    }
}

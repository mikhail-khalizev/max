using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4cd7ca6e-f247-48d0-a3cf-ae904c9db0c2")]
        public void Method_0015_3fea()
        {
            ii(0x15_3fea, 1); pushw(es);                                /* push es */
            ii(0x15_3feb, 1); pushw(di);                                /* push di */
            ii(0x15_3fec, 2); mov(di, ax);                              /* mov di, ax */
            ii(0x15_3fee, 2); add(di, bx);                              /* add di, bx */
            ii(0x15_3ff0, 3); mov(memw_a16[ds, bx + 0x4], di);          /* mov [bx+0x4], di */
            ii(0x15_3ff3, 1); dec(di);                                  /* dec di */
            ii(0x15_3ff4, 1); dec(di);                                  /* dec di */
            ii(0x15_3ff5, 3); sub(ax, 0x16);                            /* sub ax, 0x16 */
            ii(0x15_3ff8, 3); lea(si, bx + 0x14);                       /* lea si, [bx+0x14] */
            ii(0x15_3ffb, 4); mov(memw_a16[ds, di], 0xfffe);            /* mov word [di], 0xfffe */
            ii(0x15_3fff, 3); mov(memw_a16[ds, bx + 0xa], di);          /* mov [bx+0xa], di */
            ii(0x15_4002, 1); dec(ax);                                  /* dec ax */
            ii(0x15_4003, 2); mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x15_4005, 2); mov(memw_a16[ds, bx], ds);                /* mov [bx], ds */
            ii(0x15_4007, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x15_4009, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x15_400b, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_400d, 3); lea(di, bx + 0x6);                        /* lea di, [bx+0x6] */
            ii(0x15_4010, 1); cld();                                    /* cld */
            ii(0x15_4011, 1); stosw_a16();                              /* stosw */
            ii(0x15_4012, 1); stosw_a16();                              /* stosw */
            ii(0x15_4013, 1); inc(di);                                  /* inc di */
            ii(0x15_4014, 1); inc(di);                                  /* inc di */
            ii(0x15_4015, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_4017, 1); stosw_a16();                              /* stosw */
            ii(0x15_4018, 1); stosw_a16();                              /* stosw */
            ii(0x15_4019, 1); stosw_a16();                              /* stosw */
            ii(0x15_401a, 1); stosw_a16();                              /* stosw */
            ii(0x15_401b, 1); popw(di);                                 /* pop di */
            ii(0x15_401c, 1); popw(es);                                 /* pop es */
            ii(0x15_401d, 1); retw(); return;                           /* ret */
        }
    }
}

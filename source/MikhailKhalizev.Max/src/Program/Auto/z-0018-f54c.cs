using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f54c-c26802e9")]
        public void Method_0018_f54c()
        {
            ii(0x18_f54c, 3); if(callw_up(0x18_fa00, 0x4b1)) return;    /* call 0xfa00 */
            ii(0x18_f54f, 1); das();                                    /* das */
            ii(0x18_f550, 3); callw(0x18_fa00, 0x4ad);                  /* call 0xfa00 */
            ii(0x18_f553, 2); xor(al, ch);                              /* xor al, ch */
            ii(0x18_f555, 3); test(ax, 0x3104);                         /* test ax, 0x3104 */
            ii(0x18_f558, 3); callw(0x18_fa00, 0x4a5);                  /* call 0xfa00 */
            ii(0x18_f55b, 2); xor(ch, al);                              /* xor ch, al */
            ii(0x18_f55d, 3); mov(ax, memw_a16[ds, 0x3304]);            /* mov ax, [0x3304] */
            ii(0x18_f560, 3); callw(0x18_fa00, 0x49d);                  /* call 0xfa00 */
            ii(0x18_f563, 2); xor(al, 0xe8);                            /* xor al, 0xe8 */
            ii(0x18_f565, 1); cwd();                                    /* cwd */
            ii(0x18_f566, 2); add(al, 0x35);                            /* add al, 0x35 */
            ii(0x18_f568, 3); callw(0x18_fa00, 0x495);                  /* call 0xfa00 */
            ii(0x18_f56b, 4); callw(0x18_fa00, 0x491);                  /* call 0xfa00 */
            ii(0x18_f56f, 1); aaa();                                    /* aaa */
            ii(0x18_f570, 3); callw(0x18_fa00, 0x48d);                  /* call 0xfa00 */
            ii(0x18_f573, 2); cmp(al, ch);                              /* cmp al, ch */
            ii(0x18_f575, 2); mov(memw_a16[ds, si], ax);                /* mov [si], ax */
            ii(0x18_f577, 2); cmp(ax, bp);                              /* cmp ax, bp */
            ii(0x18_f579, 2); test(memw_a16[ds, si], ax);               /* test [si], ax */
            ii(0x18_f57b, 2); cmp(ch, al);                              /* cmp ch, al */
            ii(0x18_f57d, 4); add(memw_a16[ds, si], 0xe83b);            /* add word [si], 0xe83b */
            ii(0x18_f581, 2); if(jgew(0x18_f587, 0x4)) goto l_0x18_f587; /* jge 0xf587 */
            ii(0x18_f583, 2); cmp(al, -0x18 /* 0xe8 */);                /* cmp al, 0xe8 */
            ii(0x18_f585, 2); if(jnsw_func(0x18_f58b, 0x4)) return;     /* jns 0xf58b */ /* Адрес перехода делит инструкцию в этой функции пополам. */
        l_0x18_f587:
            ii(0x18_f587, 3); cmp(ax, 0x75e8);                          /* cmp ax, 0x75e8 */
            ii(0x18_f58a, 2); add(al, 0x3e);                            /* add al, 0x3e */
            ii(0x18_f58c, 3); callw(0x18_fa00, 0x471);                  /* call 0xfa00 */
            ii(0x18_f58f, 1); aas();                                    /* aas */
            ii(0x18_f590, 3); callw(0x18_fa00, 0x46d);                  /* call 0xfa00 */
            ii(0x18_f593, 1); inc(ax);                                  /* inc ax */
            ii(0x18_f594, 3); callw(0x18_fa00, 0x469);                  /* call 0xfa00 */
            ii(0x18_f597, 1); inc(cx);                                  /* inc cx */
            ii(0x18_f598, 3); callw(0x18_fa00, 0x465);                  /* call 0xfa00 */
            ii(0x18_f59b, 1); inc(dx);                                  /* inc dx */
            ii(0x18_f59c, 3); callw(0x18_fa00, 0x461);                  /* call 0xfa00 */
            ii(0x18_f59f, 1); inc(bx);                                  /* inc bx */
            ii(0x18_f5a0, 3); callw(0x18_fa00, 0x45d);                  /* call 0xfa00 */
            ii(0x18_f5a3, 1); inc(sp);                                  /* inc sp */
            ii(0x18_f5a4, 3); callw(0x18_fa00, 0x459);                  /* call 0xfa00 */
            ii(0x18_f5a7, 1); inc(bp);                                  /* inc bp */
            ii(0x18_f5a8, 3); callw(0x18_fa00, 0x455);                  /* call 0xfa00 */
            ii(0x18_f5ab, 1); inc(si);                                  /* inc si */
            ii(0x18_f5ac, 3); callw(0x18_fa00, 0x451);                  /* call 0xfa00 */
            ii(0x18_f5af, 1); inc(di);                                  /* inc di */
            ii(0x18_f5b0, 3); callw(0x18_fa00, 0x44d);                  /* call 0xfa00 */
            ii(0x18_f5b3, 1); dec(ax);                                  /* dec ax */
            ii(0x18_f5b4, 3); callw(0x18_fa00, 0x449);                  /* call 0xfa00 */
            ii(0x18_f5b7, 1); dec(cx);                                  /* dec cx */
            ii(0x18_f5b8, 3); callw(0x18_fa00, 0x445);                  /* call 0xfa00 */
            ii(0x18_f5bb, 1); dec(dx);                                  /* dec dx */
            ii(0x18_f5bc, 3); callw(0x18_fa00, 0x441);                  /* call 0xfa00 */
            ii(0x18_f5bf, 1); dec(bx);                                  /* dec bx */
            ii(0x18_f5c0, 3); callw(0x18_fa00, 0x43d);                  /* call 0xfa00 */
            ii(0x18_f5c3, 1); dec(sp);                                  /* dec sp */
            ii(0x18_f5c4, 3); callw(0x18_fa00, 0x439);                  /* call 0xfa00 */
            ii(0x18_f5c7, 1); dec(bp);                                  /* dec bp */
            ii(0x18_f5c8, 3); callw(0x18_fa00, 0x435);                  /* call 0xfa00 */
            ii(0x18_f5cb, 1); dec(si);                                  /* dec si */
            ii(0x18_f5cc, 3); callw(0x18_fa00, 0x431);                  /* call 0xfa00 */
            ii(0x18_f5cf, 1); dec(di);                                  /* dec di */
            ii(0x18_f5d0, 3); callw(0x18_fa00, 0x42d);                  /* call 0xfa00 */
            ii(0x18_f5d3, 1); pushw(ax);                                /* push ax */
            ii(0x18_f5d4, 3); callw(0x18_fa00, 0x429);                  /* call 0xfa00 */
            ii(0x18_f5d7, 1); pushw(cx);                                /* push cx */
            ii(0x18_f5d8, 3); callw(0x18_fa00, 0x425);                  /* call 0xfa00 */
            ii(0x18_f5db, 1); pushw(dx);                                /* push dx */
            ii(0x18_f5dc, 3); callw(0x18_fa00, 0x421);                  /* call 0xfa00 */
            ii(0x18_f5df, 1); pushw(bx);                                /* push bx */
            ii(0x18_f5e0, 3); callw(0x18_fa00, 0x41d);                  /* call 0xfa00 */
            ii(0x18_f5e3, 1); pushw(sp);                                /* push sp */
            ii(0x18_f5e4, 3); callw(0x18_fa00, 0x419);                  /* call 0xfa00 */
            ii(0x18_f5e7, 1); pushw(bp);                                /* push bp */
            ii(0x18_f5e8, 3); callw(0x18_fa00, 0x415);                  /* call 0xfa00 */
            ii(0x18_f5eb, 1); pushw(si);                                /* push si */
            ii(0x18_f5ec, 3); callw(0x18_fa00, 0x411);                  /* call 0xfa00 */
            ii(0x18_f5ef, 1); pushw(di);                                /* push di */
            ii(0x18_f5f0, 3); callw(0x18_fa00, 0x40d);                  /* call 0xfa00 */
            ii(0x18_f5f3, 1); popw(ax);                                 /* pop ax */
            ii(0x18_f5f4, 3); callw(0x18_fa00, 0x409);                  /* call 0xfa00 */
            ii(0x18_f5f7, 1); popw(cx);                                 /* pop cx */
            ii(0x18_f5f8, 3); callw(0x18_fa00, 0x405);                  /* call 0xfa00 */
            ii(0x18_f5fb, 1); popw(dx);                                 /* pop dx */
            ii(0x18_f5fc, 3); callw(0x18_fa00, 0x401);                  /* call 0xfa00 */
            ii(0x18_f5ff, 1); popw(bx);                                 /* pop bx */
            ii(0x18_f600, 3); callw(0x18_fa00, 0x3fd);                  /* call 0xfa00 */
            ii(0x18_f603, 1); popw(sp);                                 /* pop sp */
            ii(0x18_f604, 3); callw(0x18_fa00, 0x3f9);                  /* call 0xfa00 */
            ii(0x18_f607, 1); popw(bp);                                 /* pop bp */
            ii(0x18_f608, 3); callw(0x18_fa00, 0x3f5);                  /* call 0xfa00 */
            ii(0x18_f60b, 1); popw(si);                                 /* pop si */
            ii(0x18_f60c, 3); callw(0x18_fa00, 0x3f1);                  /* call 0xfa00 */
            ii(0x18_f60f, 1); popw(di);                                 /* pop di */
            ii(0x18_f610, 3); callw(0x18_fa00, 0x3ed);                  /* call 0xfa00 */
            ii(0x18_f613, 1); pusha();                                  /* pusha */
            ii(0x18_f614, 3); callw(0x18_fa00, 0x3e9);                  /* call 0xfa00 */
            ii(0x18_f617, 1); popa();                                   /* popa */
            ii(0x18_f618, 3); callw(0x18_fa00, 0x3e5);                  /* call 0xfa00 */
        }
    }
}

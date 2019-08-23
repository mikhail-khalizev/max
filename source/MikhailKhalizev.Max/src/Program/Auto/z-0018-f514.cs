using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_f514-6e5d469")]
        public void Method_0018_f514()
        {
            ii(0x18_f514, 3); if(call_up(0x18_fa00, 0x4e9)) return;     /* call 0xfa00 */
            ii(0x18_f517, 2); and(ax, bp);                              /* and ax, bp */
            ii(0x18_f519, 2); inw(ax, 0x4);                             /* in ax, 0x4 */
            ii(0x18_f51b, 2); and(ch, al);                              /* and ch, al */
            ii(0x18_f51d, 2); if(loope(0x18_f523, 0x4)) goto l_0x18_f523; /* loope 0xf523 */
            ii(0x18_f51f, 2); and(bp, ax);                              /* and bp, ax */
            ii(0x18_f521, 2); fld(memq[ds, si]);                        /* fld qword [si] */
        l_0x18_f523:
            ii(0x18_f523, 2); and(al, 0xe8);                            /* and al, 0xe8 */
            ii(0x18_f525, 2); fld(memd[ds, si]);                        /* fld dword [si] */
            ii(0x18_f527, 3); and(ax, 0xd5e8);                          /* and ax, 0xd5e8 */
            ii(0x18_f52a, 2); add(al, 0x26);                            /* add al, 0x26 */
            ii(0x18_f52c, 3); call(0x18_fa00, 0x4d1);                   /* call 0xfa00 */
            ii(0x18_f52f, 1); daa();                                    /* daa */
            ii(0x18_f530, 3); call(0x18_fa00, 0x4cd);                   /* call 0xfa00 */
            ii(0x18_f533, 2); sub(al, ch);                              /* sub al, ch */
            ii(0x18_f535, 1); leave();                                  /* leave */
            ii(0x18_f536, 2); add(al, 0x29);                            /* add al, 0x29 */
            ii(0x18_f538, 3); call(0x18_fa00, 0x4c5);                   /* call 0xfa00 */
            ii(0x18_f53b, 2); sub(ch, al);                              /* sub ch, al */
            ii(0x18_f53d, 3); rol(memw[ds, si], 0x2b);                  /* rol word [si], 0x2b */
            ii(0x18_f540, 3); call(0x18_fa00, 0x4bd);                   /* call 0xfa00 */
            ii(0x18_f543, 2); sub(al, -0x18 /* 0xe8 */);                /* sub al, 0xe8 */
            ii(0x18_f545, 3); mov(cx, 0x2d04);                          /* mov cx, 0x2d04 */
            ii(0x18_f548, 3); call(0x18_fa00, 0x4b5);                   /* call 0xfa00 */
            ii(0x18_f54b, 4); call(0x18_fa00, 0x4b1);                   /* call 0xfa00 */
            ii(0x18_f54f, 1); das();                                    /* das */
            ii(0x18_f550, 3); call(0x18_fa00, 0x4ad);                   /* call 0xfa00 */
            ii(0x18_f553, 2); xor(al, ch);                              /* xor al, ch */
            ii(0x18_f555, 3); test(ax, 0x3104);                         /* test ax, 0x3104 */
            ii(0x18_f558, 3); call(0x18_fa00, 0x4a5);                   /* call 0xfa00 */
            ii(0x18_f55b, 2); xor(ch, al);                              /* xor ch, al */
            ii(0x18_f55d, 3); mov(ax, memw[ds, 0x3304]);                /* mov ax, [0x3304] */
            ii(0x18_f560, 3); call(0x18_fa00, 0x49d);                   /* call 0xfa00 */
            ii(0x18_f563, 2); xor(al, 0xe8);                            /* xor al, 0xe8 */
            ii(0x18_f565, 1); cwd();                                    /* cwd */
            ii(0x18_f566, 2); add(al, 0x35);                            /* add al, 0x35 */
            ii(0x18_f568, 3); call(0x18_fa00, 0x495);                   /* call 0xfa00 */
            ii(0x18_f56b, 4); call(0x18_fa00, 0x491);                   /* call 0xfa00 */
            ii(0x18_f56f, 1); aaa();                                    /* aaa */
            ii(0x18_f570, 3); call(0x18_fa00, 0x48d);                   /* call 0xfa00 */
            ii(0x18_f573, 2); cmp(al, ch);                              /* cmp al, ch */
            ii(0x18_f575, 2); mov(memw[ds, si], ax);                    /* mov [si], ax */
            ii(0x18_f577, 2); cmp(ax, bp);                              /* cmp ax, bp */
            ii(0x18_f579, 2); test(memw[ds, si], ax);                   /* test [si], ax */
            ii(0x18_f57b, 2); cmp(ch, al);                              /* cmp ch, al */
            ii(0x18_f57d, 4); add(memw[ds, si], 0xe83b);                /* add word [si], 0xe83b */
            ii(0x18_f581, 2); if(jge(0x18_f587, 0x4)) goto l_0x18_f587; /* jge 0xf587 */
            ii(0x18_f583, 2); cmp(al, -0x18 /* 0xe8 */);                /* cmp al, 0xe8 */
            ii(0x18_f585, 2); if(jns_func(0x18_f58b, 0x4)) return;      /* jns 0xf58b */
        l_0x18_f587:
            ii(0x18_f587, 3); cmp(ax, 0x75e8);                          /* cmp ax, 0x75e8 */
        }
    }
}

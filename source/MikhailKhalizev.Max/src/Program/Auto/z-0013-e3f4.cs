using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0eba35b7-6230-424f-b6d1-c5ccd56bd9e2")]
        public void Method_0013_e3f4()
        {
            ii(0x13_e3f4, 2); mov(dx, ax);                              /* mov dx, ax */
            ii(0x13_e3f6, 4); test(memb_a16[ds, bx + 0x2], 0x4);        /* test byte [bx+0x2], 0x4 */
            ii(0x13_e3fa, 2); if(jzw(0x13_e40b, 0xf)) goto l_0x13_e40b; /* jz 0xe40b */
            ii(0x13_e3fc, 1); dec(dx);                                  /* dec dx */
            ii(0x13_e3fd, 3); mov(si, memw_a16[ds, bx + 0x4]);          /* mov si, [bx+0x4] */
            ii(0x13_e400, 1); dec(si);                                  /* dec si */
            ii(0x13_e401, 2); cmp(dx, si);                              /* cmp dx, si */
            ii(0x13_e403, 2); if(jbw(0x13_e40a, 0x5)) goto l_0x13_e40a; /* jb 0xe40a */
            ii(0x13_e405, 3); cmp(memw_a16[ds, bx - 0x2], dx);          /* cmp [bx-0x2], dx */
            ii(0x13_e408, 2); if(jaew(0x13_e440, 0x36)) goto l_0x13_e440; /* jae 0xe440 */
        l_0x13_e40a:
            ii(0x13_e40a, 1); inc(dx);                                  /* inc dx */
        l_0x13_e40b:
            ii(0x13_e40b, 1); pushw(bx);                                /* push bx */
            ii(0x13_e40c, 1); pushw(cx);                                /* push cx */
            ii(0x13_e40d, 2); mov(si, ds);                              /* mov si, ds */
            ii(0x13_e40f, 2); mov(es, si);                              /* mov es, si */
            ii(0x13_e411, 2); mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x13_e413, 2); shr(ax, cl);                              /* shr ax, cl */
            ii(0x13_e415, 2); if(jnzw(0x13_e41a, 0x3)) goto l_0x13_e41a; /* jnz 0xe41a */
            ii(0x13_e417, 3); mov(ax, 0x1000);                          /* mov ax, 0x1000 */
        l_0x13_e41a:
            ii(0x13_e41a, 4); test(memb_a16[ds, bx + 0x2], 0x4);        /* test byte [bx+0x2], 0x4 */
            ii(0x13_e41e, 2); if(jzw(0x13_e42a, 0xa)) goto l_0x13_e42a; /* jz 0xe42a */
            ii(0x13_e420, 2); add(ax, si);                              /* add ax, si */
            ii(0x13_e422, 4); mov(bx, memw_a16[ds, 0x1c54]);            /* mov bx, [0x1c54] */
            ii(0x13_e426, 2); sub(ax, bx);                              /* sub ax, bx */
            ii(0x13_e428, 2); mov(es, bx);                              /* mov es, bx */
        l_0x13_e42a:
            ii(0x13_e42a, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x13_e42c, 2); mov(ah, 0x4a);                            /* mov ah, 0x4a */
            ii(0x13_e42e, 2); @int(0x21);                               /* int 0x21 */
            ii(0x13_e430, 1); popw(cx);                                 /* pop cx */
            ii(0x13_e431, 1); popw(bx);                                 /* pop bx */
            ii(0x13_e432, 2); if(jbw(0x13_e444, 0x10)) goto l_0x13_e444; /* jb 0xe444 */
            ii(0x13_e434, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x13_e436, 4); test(memb_a16[ds, bx + 0x2], 0x4);        /* test byte [bx+0x2], 0x4 */
            ii(0x13_e43a, 2); if(jzw(0x13_e440, 0x4)) goto l_0x13_e440; /* jz 0xe440 */
            ii(0x13_e43c, 1); dec(dx);                                  /* dec dx */
            ii(0x13_e43d, 3); mov(memw_a16[ds, bx - 0x2], dx);          /* mov [bx-0x2], dx */
        l_0x13_e440:
            ii(0x13_e440, 1); clc();                                    /* clc */
            ii(0x13_e441, 2); jmpw(0x13_e444, 0x1); goto l_0x13_e444;   /* jmp 0xe444 */
        //    ii(0x13_e443, 1); stc();                                    /* stc */
        l_0x13_e444:
            ii(0x13_e444, 1); retw(); return;                           /* ret */
        }
    }
}

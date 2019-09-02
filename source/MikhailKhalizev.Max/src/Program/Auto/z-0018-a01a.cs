using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a01a-c96550b3")]
        public void Method_0018_a01a()
        {
            ii(0x18_a01a, 1); sti();                                    /* sti */
            ii(0x18_a01b, 3); cmp(ah, 0);                               /* cmp ah, 0x0 */
            ii(0x18_a01e, 2); if(jz(0x18_a06b, 0x4b)) goto l_0x18_a06b; /* jz 0xa06b */
            ii(0x18_a020, 3); cmp(ah, 0x10);                            /* cmp ah, 0x10 */
            ii(0x18_a023, 2); if(jz(0x18_a06b, 0x46)) goto l_0x18_a06b; /* jz 0xa06b */
            ii(0x18_a025, 3); cmp(ah, 1);                               /* cmp ah, 0x1 */
            ii(0x18_a028, 2); if(jz(0x18_a02f, 5)) goto l_0x18_a02f;    /* jz 0xa02f */
            ii(0x18_a02a, 3); cmp(ah, 0x11);                            /* cmp ah, 0x11 */
            ii(0x18_a02d, 2); if(jnz(0x18_a05c, 0x2d)) goto l_0x18_a05c; /* jnz 0xa05c */
        l_0x18_a02f:
            ii(0x18_a02f, 1); push(ds);                                 /* push ds */
            ii(0x18_a030, 1); push(ax);                                 /* push ax */
            ii(0x18_a031, 2); push(0x38);                               /* push 0x38 */
            ii(0x18_a033, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a034, 3); mov(al, memb[ds, 0x46c]);                 /* mov al, [0x46c] */
            ii(0x18_a037, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_a039, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a03a, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_a03c, 4); xchg(memb[ds, 0x10ed], al);               /* xchg [0x10ed], al */
            ii(0x18_a040, 5); test(memb[ds, 0x14], 4);                  /* test byte [0x14], 0x4 */
            ii(0x18_a045, 2); if(jnz(0x18_a052, 0xb)) goto l_0x18_a052; /* jnz 0xa052 */
            ii(0x18_a047, 2); cmp(ah, al);                              /* cmp ah, al */
            ii(0x18_a049, 2); if(jnz(0x18_a052, 7)) goto l_0x18_a052;   /* jnz 0xa052 */
            ii(0x18_a04b, 1); pop(ax);                                  /* pop ax */
        l_0x18_a04c:
            ii(0x18_a04c, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a04d, 1); sti();                                    /* sti */
            ii(0x18_a04e, 4); retfd(4); return;                         /* o32 retf 0x4 */
        l_0x18_a052:
            ii(0x18_a052, 1); pop(ax);                                  /* pop ax */
            ii(0x18_a053, 2); pushfd();                                 /* pushfd */
            ii(0x18_a055, 2); pushd(cs);                                /* o32 push cs */
            ii(0x18_a057, 2); push(0);                                  /* push 0x0 */
            ii(0x18_a059, 3); push(0x541);                              /* push 0x541 */
        l_0x18_a05c:
            ii(0x18_a05c, 1); cli();                                    /* cli */
            ii(0x18_a05d, 3); if(call_up(0x18_9f20, -0x140)) return;    /* call 0x9f20 */
            ii(0x18_a060, 1); push(ss);                                 /* push ss */
            ii(0x18_a061, 2); if(jz(0x18_a04c, -0x17)) goto l_0x18_a04c; /* jz 0xa04c */
            ii(0x18_a063, 4); dec(memb[ds, 0x10ed]);                    /* dec byte [0x10ed] */
            ii(0x18_a067, 2); or(sp, sp);                               /* or sp, sp */
            ii(0x18_a069, 2); jmp(0x18_a04c, -0x1f); goto l_0x18_a04c;  /* jmp 0xa04c */
        l_0x18_a06b:
            ii(0x18_a06b, 1); push(ds);                                 /* push ds */
            ii(0x18_a06c, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_a06e, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a06f, 4); dec(memb[ds, 0x10ed]);                    /* dec byte [0x10ed] */
            ii(0x18_a073, 1); pop(ds);                                  /* pop ds */
            ii(0x18_a074, 2); jmp(0x18_a05c, -0x1a); goto l_0x18_a05c;  /* jmp 0xa05c */
        }
    }
}

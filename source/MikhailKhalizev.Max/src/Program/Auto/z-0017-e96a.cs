using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e96a-d57a0c53")]
        public void Method_0017_e96a()
        {
            ii(0x17_e96a, 4); enterw(0x22, 0);                          /* enter 0x22, 0x0 */
            ii(0x17_e96e, 1); pushw(ds);                                /* push ds */
            ii(0x17_e96f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_e972, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_e974, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_e976, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_e979, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x17_e97c, 1); nop();                                    /* nop */
            ii(0x17_e97d, 1); pushw(cs);                                /* push cs */
            ii(0x17_e97e, 3); callw(0x17_f134, 0x7b3);                  /* call 0xf134 */
            ii(0x17_e981, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e983, 2); if(jnzw(0x17_e9ba, 0x35)) goto l_0x17_e9ba; /* jnz 0xe9ba */
            ii(0x17_e985, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x17_e988, 2); mov(ah, 0xff);                            /* mov ah, 0xff */
            ii(0x17_e98a, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_e98d, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_e990, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_e993, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x17_e996, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x17_e999, 5); mov(memw_a16[ss, bp - 0x6], 0xa00);       /* mov word [bp-0x6], 0xa00 */
            ii(0x17_e99e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e9a0, 2); pushw(0);                                 /* push 0x0 */
            ii(0x17_e9a2, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x17_e9a5, 1); pushw(ss);                                /* push ss */
            ii(0x17_e9a6, 1); pushw(ax);                                /* push ax */
            ii(0x17_e9a7, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_e9aa, 1); nop();                                    /* nop */
            ii(0x17_e9ab, 1); pushw(cs);                                /* push cs */
            ii(0x17_e9ac, 3); callw(0x17_eb40, 0x191);                  /* call 0xeb40 */
            ii(0x17_e9af, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_e9b2, 3); mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
        l_0x17_e9b5:
            ii(0x17_e9b5, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x17_e9b8, 2); jmpw(0x17_ea15, 0x5b); goto l_0x17_ea15;  /* jmp 0xea15 */
        l_0x17_e9ba:
            ii(0x17_e9ba, 1); nop();                                    /* nop */
            ii(0x17_e9bb, 1); pushw(cs);                                /* push cs */
            ii(0x17_e9bc, 3); callw(0x17_f146, 0x787);                  /* call 0xf146 */
            ii(0x17_e9bf, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x17_e9c2, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_e9c4, 2); if(jzw(0x17_ea15, 0x4f)) goto l_0x17_ea15; /* jz 0xea15 */
            ii(0x17_e9c6, 3); lea(ax, bp - 0x22);                       /* lea ax, [bp-0x22] */
            ii(0x17_e9c9, 1); pushw(ss);                                /* push ss */
            ii(0x17_e9ca, 1); pushw(ax);                                /* push ax */
            ii(0x17_e9cb, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x17_e9ce, 1); nop();                                    /* nop */
            ii(0x17_e9cf, 1); pushw(cs);                                /* push cs */
            ii(0x17_e9d0, 3); callw(0x17_effa, 0x627);                  /* call 0xeffa */
            ii(0x17_e9d3, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_e9d6, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x17_e9d9, 3); mov(memb_a16[ss, bp - 0x1e], al);         /* mov [bp-0x1e], al */
            ii(0x17_e9dc, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x17_e9df, 3); mov(memw_a16[ss, bp - 0x20], ax);         /* mov [bp-0x20], ax */
            ii(0x17_e9e2, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x17_e9e5, 1); dec(ax);                                  /* dec ax */
            ii(0x17_e9e6, 3); mov(memw_a16[ss, bp - 0x22], ax);         /* mov [bp-0x22], ax */
            ii(0x17_e9e9, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x17_e9ec, 2); sub(al, al);                              /* sub al, al */
            ii(0x17_e9ee, 3); or(memw_a16[ss, bp - 0x1c], ax);          /* or [bp-0x1c], ax */
            ii(0x17_e9f1, 3); lea(ax, bp - 0x22);                       /* lea ax, [bp-0x22] */
            ii(0x17_e9f4, 1); pushw(ss);                                /* push ss */
            ii(0x17_e9f5, 1); pushw(ax);                                /* push ax */
            ii(0x17_e9f6, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x17_e9f9, 1); nop();                                    /* nop */
            ii(0x17_e9fa, 1); pushw(cs);                                /* push cs */
            ii(0x17_e9fb, 3); callw(0x17_f06c, 0x66e);                  /* call 0xf06c */
            ii(0x17_e9fe, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x17_ea01, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_ea03, 2); if(jzw(0x17_ea0a, 0x5)) goto l_0x17_ea0a; /* jz 0xea0a */
            ii(0x17_ea05, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x17_ea08, 2); jmpw(0x17_e9b5, -0x55); goto l_0x17_e9b5; /* jmp 0xe9b5 */
        l_0x17_ea0a:
            ii(0x17_ea0a, 3); pushw(memw_a16[ss, bp - 0x16]);           /* push word [bp-0x16] */
            ii(0x17_ea0d, 1); nop();                                    /* nop */
            ii(0x17_ea0e, 1); pushw(cs);                                /* push cs */
            ii(0x17_ea0f, 3); callw(0x17_f1aa, 0x798);                  /* call 0xf1aa */
            ii(0x17_ea12, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x17_ea15:
            ii(0x17_ea15, 3); mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x17_ea18, 3); mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x17_ea1b, 1); popw(ds);                                 /* pop ds */
            ii(0x17_ea1c, 1); leavew();                                 /* leave */
            ii(0x17_ea1d, 1); retfw(); return;                          /* retf */
        }
    }
}
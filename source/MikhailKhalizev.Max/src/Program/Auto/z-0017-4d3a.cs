using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4d3a-b8392585")]
        public void Method_0017_4d3a()
        {
            ii(0x17_4d3a, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x17_4d3e, 1); pushw(ds);                                /* push ds */
            ii(0x17_4d3f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4d42, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4d44, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x17_4d47, 3); pushw(0x867c);                            /* push 0x867c */
            ii(0x17_4d4a, 1); nop();                                    /* nop */
            ii(0x17_4d4b, 1); pushw(cs);                                /* push cs */
            ii(0x17_4d4c, 3); callw(0x16_e630, -0x671f);                /* call 0xe630 */
            ii(0x17_4d4f, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_4d52, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x17_4d55, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x17_4d58, 5); mov(memw_a16[ss, bp - 0xc], 0x8680);      /* mov word [bp-0xc], 0x8680 */
            ii(0x17_4d5d, 5); mov(memw_a16[ss, bp - 0xa], 0x3e58);      /* mov word [bp-0xa], 0x3e58 */
            ii(0x17_4d62, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x17_4d64, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x17_4d67, 5); mov(memw_a16[ss, bp - 0x14], 0x8688);     /* mov word [bp-0x14], 0x8688 */
            ii(0x17_4d6c, 5); mov(memw_a16[ss, bp - 0x12], 0x3e58);     /* mov word [bp-0x12], 0x3e58 */
            ii(0x17_4d71, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x17_4d74, 5); mov(memw_a16[ss, bp - 0x4], 0x8678);      /* mov word [bp-0x4], 0x8678 */
            ii(0x17_4d79, 5); mov(memw_a16[ss, bp - 0x2], 0x3e58);      /* mov word [bp-0x2], 0x3e58 */
            ii(0x17_4d7e, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x17_4d81, 5); mov(memw_a16[ss, bp - 0x10], 0x8684);     /* mov word [bp-0x10], 0x8684 */
            ii(0x17_4d86, 5); mov(memw_a16[ss, bp - 0xe], 0x3e58);      /* mov word [bp-0xe], 0x3e58 */
            ii(0x17_4d8b, 3); mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x17_4d8e, 1); pushw(ax);                                /* push ax */
            ii(0x17_4d8f, 3); pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0x17_4d92, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x17_4d95, 3); pushw(0x87ab);                            /* push 0x87ab */
            ii(0x17_4d98, 2); pushw(0x5);                               /* push 0x5 */
            ii(0x17_4d9a, 1); pushw(cs);                                /* push cs */
            ii(0x17_4d9b, 3); callw(0x17_4ee2, 0x144);                  /* call 0x4ee2 */
            ii(0x17_4d9e, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_4da1, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4da3, 2); if(jnzw(0x17_4e09, 0x64)) goto l_0x17_4e09; /* jnz 0x4e09 */
            ii(0x17_4da5, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x17_4da8, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x17_4dab, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x17_4dae, 3); pushw(0x877b);                            /* push 0x877b */
            ii(0x17_4db1, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x17_4db3, 1); pushw(cs);                                /* push cs */
            ii(0x17_4db4, 3); callw(0x17_4ee2, 0x12b);                  /* call 0x4ee2 */
            ii(0x17_4db7, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_4dba, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4dbc, 2); if(jnzw(0x17_4e09, 0x4b)) goto l_0x17_4e09; /* jnz 0x4e09 */
            ii(0x17_4dbe, 3); pushw(memw_a16[ss, bp - 0xa]);            /* push word [bp-0xa] */
            ii(0x17_4dc1, 3); pushw(memw_a16[ss, bp - 0xc]);            /* push word [bp-0xc] */
            ii(0x17_4dc4, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x17_4dc7, 3); pushw(0x87ec);                            /* push 0x87ec */
            ii(0x17_4dca, 2); pushw(0x6);                               /* push 0x6 */
            ii(0x17_4dcc, 1); pushw(cs);                                /* push cs */
            ii(0x17_4dcd, 3); callw(0x17_4ee2, 0x112);                  /* call 0x4ee2 */
            ii(0x17_4dd0, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_4dd3, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4dd5, 2); if(jnzw(0x17_4e09, 0x32)) goto l_0x17_4e09; /* jnz 0x4e09 */
            ii(0x17_4dd7, 3); pushw(memw_a16[ss, bp - 0xe]);            /* push word [bp-0xe] */
            ii(0x17_4dda, 3); pushw(memw_a16[ss, bp - 0x10]);           /* push word [bp-0x10] */
            ii(0x17_4ddd, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x17_4de0, 3); pushw(0x8821);                            /* push 0x8821 */
            ii(0x17_4de3, 2); pushw(0x7);                               /* push 0x7 */
            ii(0x17_4de5, 1); pushw(cs);                                /* push cs */
            ii(0x17_4de6, 3); callw(0x17_4ee2, 0xf9);                   /* call 0x4ee2 */
            ii(0x17_4de9, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_4dec, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4dee, 2); if(jnzw(0x17_4e09, 0x19)) goto l_0x17_4e09; /* jnz 0x4e09 */
            ii(0x17_4df0, 3); pushw(memw_a16[ss, bp - 0x12]);           /* push word [bp-0x12] */
            ii(0x17_4df3, 3); pushw(memw_a16[ss, bp - 0x14]);           /* push word [bp-0x14] */
            ii(0x17_4df6, 3); pushw(0x3e58);                            /* push 0x3e58 */
            ii(0x17_4df9, 3); pushw(0x8856);                            /* push 0x8856 */
            ii(0x17_4dfc, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x17_4dfe, 1); pushw(cs);                                /* push cs */
            ii(0x17_4dff, 3); callw(0x17_4ee2, 0xe0);                   /* call 0x4ee2 */
            ii(0x17_4e02, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x17_4e05, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_4e07, 2); if(jzw(0x17_4e10, 0x7)) goto l_0x17_4e10; /* jz 0x4e10 */
        l_0x17_4e09:
            ii(0x17_4e09, 5); mov(memw_a16[ss, bp - 0x16], 0x1);        /* mov word [bp-0x16], 0x1 */
            ii(0x17_4e0e, 2); jmpw(0x17_4e15, 0x5); goto l_0x17_4e15;   /* jmp 0x4e15 */
        l_0x17_4e10:
            ii(0x17_4e10, 5); mov(memw_a16[ss, bp - 0x16], 0);          /* mov word [bp-0x16], 0x0 */
        l_0x17_4e15:
            ii(0x17_4e15, 3); mov(ax, memw_a16[ss, bp - 0x16]);         /* mov ax, [bp-0x16] */
            ii(0x17_4e18, 1); popw(ds);                                 /* pop ds */
            ii(0x17_4e19, 1); leavew();                                 /* leave */
            ii(0x17_4e1a, 1); retw(); return;                           /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("04f930d8-f459-4480-8dac-03896ae5d45c")]
        public void Method_0015_da10()
        {
            ii(0x15_da10, 4); enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x15_da14, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_da16, 3); mov(memw_a16[ss, bp - 0x2], ax);          /* mov [bp-0x2], ax */
            ii(0x15_da19, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_da1c, 1); pushw(ds);                                /* push ds */
            ii(0x15_da1d, 3); pushw(0x2b9f);                            /* push 0x2b9f */
            ii(0x15_da20, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_da23, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_da26, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x15_da2b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_da2e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_da30, 2); if(jzw(0x15_da35, 0x3)) goto l_0x15_da35; /* jz 0xda35 */
            ii(0x15_da32, 3); jmpw(0x15_dada, 0xa5); goto l_0x15_dada;  /* jmp 0xdada */
        l_0x15_da35:
            ii(0x15_da35, 1); pushw(ds);                                /* push ds */
            ii(0x15_da36, 3); pushw(0x2ba8);                            /* push 0x2ba8 */
            ii(0x15_da39, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_da3c, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_da3f, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x15_da44, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_da47, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_da49, 2); if(jnzw(0x15_da55, 0xa)) goto l_0x15_da55; /* jnz 0xda55 */
            ii(0x15_da4b, 4); pushw(memw_a16[ds, 0x2b9c]);              /* push word [0x2b9c] */
            ii(0x15_da4f, 4); pushw(memw_a16[ds, 0x2b9a]);              /* push word [0x2b9a] */
            ii(0x15_da53, 2); jmpw(0x15_dad1, 0x7c); goto l_0x15_dad1;  /* jmp 0xdad1 */
        l_0x15_da55:
            ii(0x15_da55, 1); pushw(ds);                                /* push ds */
            ii(0x15_da56, 3); pushw(0x2bb5);                            /* push 0x2bb5 */
            ii(0x15_da59, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_da5c, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_da5f, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x15_da64, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_da67, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_da69, 2); if(jnzw(0x15_da77, 0xc)) goto l_0x15_da77; /* jnz 0xda77 */
            ii(0x15_da6b, 3); mov(ax, memw_a16[ds, 0x2b9a]);            /* mov ax, [0x2b9a] */
            ii(0x15_da6e, 4); mov(dx, memw_a16[ds, 0x2b9c]);            /* mov dx, [0x2b9c] */
            ii(0x15_da72, 3); add(ax, 0x28);                            /* add ax, 0x28 */
            ii(0x15_da75, 2); jmpw(0x15_dab5, 0x3e); goto l_0x15_dab5;  /* jmp 0xdab5 */
        l_0x15_da77:
            ii(0x15_da77, 1); pushw(ds);                                /* push ds */
            ii(0x15_da78, 3); pushw(0x2bc2);                            /* push 0x2bc2 */
            ii(0x15_da7b, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_da7e, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_da81, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x15_da86, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_da89, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_da8b, 2); if(jnzw(0x15_da95, 0x8)) goto l_0x15_da95; /* jnz 0xda95 */
            ii(0x15_da8d, 3); pushw(0xa8);                              /* push 0xa8 */
            ii(0x15_da90, 3); pushw(0x3b70);                            /* push 0x3b70 */
            ii(0x15_da93, 2); jmpw(0x15_dad1, 0x3c); goto l_0x15_dad1;  /* jmp 0xdad1 */
        l_0x15_da95:
            ii(0x15_da95, 1); pushw(ds);                                /* push ds */
            ii(0x15_da96, 3); pushw(0x2bca);                            /* push 0x2bca */
            ii(0x15_da99, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_da9c, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_da9f, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x15_daa4, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_daa7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_daa9, 2); if(jnzw(0x15_dab8, 0xd)) goto l_0x15_dab8; /* jnz 0xdab8 */
            ii(0x15_daab, 3); mov(ax, memw_a16[ds, 0x2b9a]);            /* mov ax, [0x2b9a] */
            ii(0x15_daae, 4); mov(dx, memw_a16[ds, 0x2b9c]);            /* mov dx, [0x2b9c] */
            ii(0x15_dab2, 3); add(ax, 0x248);                           /* add ax, 0x248 */
        l_0x15_dab5:
            ii(0x15_dab5, 1); pushw(dx);                                /* push dx */
            ii(0x15_dab6, 2); jmpw(0x15_dad0, 0x18); goto l_0x15_dad0;  /* jmp 0xdad0 */
        l_0x15_dab8:
            ii(0x15_dab8, 1); pushw(ds);                                /* push ds */
            ii(0x15_dab9, 3); pushw(0x2bd2);                            /* push 0x2bd2 */
            ii(0x15_dabc, 3); pushw(memw_a16[ss, bp + 0x10]);           /* push word [bp+0x10] */
            ii(0x15_dabf, 3); pushw(memw_a16[ss, bp + 0xe]);            /* push word [bp+0xe] */
            ii(0x15_dac2, 5); callw_far_abs(0x80, 0x3f26);              /* call word 0x80:0x3f26 */
            ii(0x15_dac7, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_daca, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_dacc, 2); if(jnzw(0x15_dada, 0xc)) goto l_0x15_dada; /* jnz 0xdada */
            ii(0x15_dace, 2); pushw(0x28);                              /* push 0x28 */
        l_0x15_dad0:
            ii(0x15_dad0, 1); pushw(ax);                                /* push ax */
        l_0x15_dad1:
            ii(0x15_dad1, 3); callw(0x15_d9f4, -0xe0);                  /* call 0xd9f4 */
            ii(0x15_dad4, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_dad7, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0x15_dada:
            ii(0x15_dada, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_dadd, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_dae0, 3); les(bx, ss, bp + 0x12);                   /* les bx, [bp+0x12] */
            ii(0x15_dae3, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x15_dae7, 4); mov(memw_a16[es, bx + 0x4], dx);          /* mov [es:bx+0x4], dx */
            ii(0x15_daeb, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_daed, 2); if(jzw(0x15_daf4, 0x5)) goto l_0x15_daf4; /* jz 0xdaf4 */
            ii(0x15_daef, 3); mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x15_daf2, 1); leavew();                                 /* leave */
            ii(0x15_daf3, 1); retfw(); return;                          /* retf */
        l_0x15_daf4:
            ii(0x15_daf4, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_daf6, 1); leavew();                                 /* leave */
            ii(0x15_daf7, 1); retfw(); return;                          /* retf */
        }
    }
}

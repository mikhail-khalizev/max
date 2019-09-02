using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_da10-e4d6e9e4")]
        public void Method_0019_da10()
        {
            ii(0x19_da10, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_da14, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_da16, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_da19, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_da1c, 1); push(ds);                                 /* push ds */
            ii(0x19_da1d, 3); push(0x2b9f);                             /* push 0x2b9f */
            ii(0x19_da20, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_da23, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_da26, 5); call_far_abs(0x80, 0x3f26);               /* call word 0x80:0x3f26 */
            ii(0x19_da2b, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_da2e, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_da30, 2); if(jz(0x19_da35, 3)) goto l_0x19_da35;    /* jz 0xda35 */
            ii(0x19_da32, 3); jmp(0x19_dada, 0xa5); goto l_0x19_dada;   /* jmp 0xdada */
        l_0x19_da35:
            ii(0x19_da35, 1); push(ds);                                 /* push ds */
            ii(0x19_da36, 3); push(0x2ba8);                             /* push 0x2ba8 */
            ii(0x19_da39, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_da3c, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_da3f, 5); call_far_abs(0x80, 0x3f26);               /* call word 0x80:0x3f26 */
            ii(0x19_da44, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_da47, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_da49, 2); if(jnz(0x19_da55, 0xa)) goto l_0x19_da55; /* jnz 0xda55 */
            ii(0x19_da4b, 4); push(memw[ds, 0x2b9c]);                   /* push word [0x2b9c] */
            ii(0x19_da4f, 4); push(memw[ds, 0x2b9a]);                   /* push word [0x2b9a] */
            ii(0x19_da53, 2); jmp(0x19_dad1, 0x7c); goto l_0x19_dad1;   /* jmp 0xdad1 */
        l_0x19_da55:
            ii(0x19_da55, 1); push(ds);                                 /* push ds */
            ii(0x19_da56, 3); push(0x2bb5);                             /* push 0x2bb5 */
            ii(0x19_da59, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_da5c, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_da5f, 5); call_far_abs(0x80, 0x3f26);               /* call word 0x80:0x3f26 */
            ii(0x19_da64, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_da67, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_da69, 2); if(jnz(0x19_da77, 0xc)) goto l_0x19_da77; /* jnz 0xda77 */
            ii(0x19_da6b, 3); mov(ax, memw[ds, 0x2b9a]);                /* mov ax, [0x2b9a] */
            ii(0x19_da6e, 4); mov(dx, memw[ds, 0x2b9c]);                /* mov dx, [0x2b9c] */
            ii(0x19_da72, 3); add(ax, 0x28);                            /* add ax, 0x28 */
            ii(0x19_da75, 2); jmp(0x19_dab5, 0x3e); goto l_0x19_dab5;   /* jmp 0xdab5 */
        l_0x19_da77:
            ii(0x19_da77, 1); push(ds);                                 /* push ds */
            ii(0x19_da78, 3); push(0x2bc2);                             /* push 0x2bc2 */
            ii(0x19_da7b, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_da7e, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_da81, 5); call_far_abs(0x80, 0x3f26);               /* call word 0x80:0x3f26 */
            ii(0x19_da86, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_da89, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_da8b, 2); if(jnz(0x19_da95, 8)) goto l_0x19_da95;   /* jnz 0xda95 */
            ii(0x19_da8d, 3); push(0xa8);                               /* push 0xa8 */
            ii(0x19_da90, 3); push(0x3b70);                             /* push 0x3b70 */
            ii(0x19_da93, 2); jmp(0x19_dad1, 0x3c); goto l_0x19_dad1;   /* jmp 0xdad1 */
        l_0x19_da95:
            ii(0x19_da95, 1); push(ds);                                 /* push ds */
            ii(0x19_da96, 3); push(0x2bca);                             /* push 0x2bca */
            ii(0x19_da99, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_da9c, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_da9f, 5); call_far_abs(0x80, 0x3f26);               /* call word 0x80:0x3f26 */
            ii(0x19_daa4, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_daa7, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_daa9, 2); if(jnz(0x19_dab8, 0xd)) goto l_0x19_dab8; /* jnz 0xdab8 */
            ii(0x19_daab, 3); mov(ax, memw[ds, 0x2b9a]);                /* mov ax, [0x2b9a] */
            ii(0x19_daae, 4); mov(dx, memw[ds, 0x2b9c]);                /* mov dx, [0x2b9c] */
            ii(0x19_dab2, 3); add(ax, 0x248);                           /* add ax, 0x248 */
        l_0x19_dab5:
            ii(0x19_dab5, 1); push(dx);                                 /* push dx */
            ii(0x19_dab6, 2); jmp(0x19_dad0, 0x18); goto l_0x19_dad0;   /* jmp 0xdad0 */
        l_0x19_dab8:
            ii(0x19_dab8, 1); push(ds);                                 /* push ds */
            ii(0x19_dab9, 3); push(0x2bd2);                             /* push 0x2bd2 */
            ii(0x19_dabc, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_dabf, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_dac2, 5); call_far_abs(0x80, 0x3f26);               /* call word 0x80:0x3f26 */
            ii(0x19_dac7, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_daca, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_dacc, 2); if(jnz(0x19_dada, 0xc)) goto l_0x19_dada; /* jnz 0xdada */
            ii(0x19_dace, 2); push(0x28);                               /* push 0x28 */
        l_0x19_dad0:
            ii(0x19_dad0, 1); push(ax);                                 /* push ax */
        l_0x19_dad1:
            ii(0x19_dad1, 3); call(0x19_d9f4, -0xe0);                   /* call 0xd9f4 */
            ii(0x19_dad4, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_dad7, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
        l_0x19_dada:
            ii(0x19_dada, 3); mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0x19_dadd, 3); mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0x19_dae0, 3); les(bx, memw[ss, bp + 0x12]);             /* les bx, [bp+0x12] */
            ii(0x19_dae3, 4); mov(memw[es, bx + 2], ax);                /* mov [es:bx+0x2], ax */
            ii(0x19_dae7, 4); mov(memw[es, bx + 4], dx);                /* mov [es:bx+0x4], dx */
            ii(0x19_daeb, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_daed, 2); if(jz(0x19_daf4, 5)) goto l_0x19_daf4;    /* jz 0xdaf4 */
            ii(0x19_daef, 3); mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x19_daf2, 1); leave();                                  /* leave */
            ii(0x19_daf3, 1); retf(); return;                           /* retf */
        l_0x19_daf4:
            ii(0x19_daf4, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_daf6, 1); leave();                                  /* leave */
            ii(0x19_daf7, 1); retf();                                   /* retf */
        }
    }
}

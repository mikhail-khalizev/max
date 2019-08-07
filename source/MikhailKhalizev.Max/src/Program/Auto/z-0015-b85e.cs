using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eeb60e3b-dc73-47f4-b0fe-3366dbcfe714")]
        public void Method_0015_b85e()
        {
            ii(0x15_b85e, 4); enterw(0x4c, 0);                          /* enter 0x4c, 0x0 */
            ii(0x15_b862, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_b865, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_b867, 4); mov(memw_a16[es, bx + 0x70], ax);         /* mov [es:bx+0x70], ax */
            ii(0x15_b86b, 4); mov(memw_a16[es, bx + 0x6e], ax);         /* mov [es:bx+0x6e], ax */
            ii(0x15_b86f, 2); sub(al, al);                              /* sub al, al */
            ii(0x15_b871, 5); mov(memb_a16[es, bx + 0xb3], al);         /* mov [es:bx+0xb3], al */
            ii(0x15_b876, 5); mov(memb_a16[es, bx + 0xb2], al);         /* mov [es:bx+0xb2], al */
            ii(0x15_b87b, 5); mov(ax, memw_a16[es, bx + 0xb4]);         /* mov ax, [es:bx+0xb4] */
            ii(0x15_b880, 3); mov(memw_a16[ss, bp - 0x4c], ax);         /* mov [bp-0x4c], ax */
            ii(0x15_b883, 5); mov(cx, memw_a16[es, bx + 0xb6]);         /* mov cx, [es:bx+0xb6] */
            ii(0x15_b888, 5); mov(dx, memw_a16[es, bx + 0xb8]);         /* mov dx, [es:bx+0xb8] */
            ii(0x15_b88d, 3); mov(memw_a16[ss, bp - 0x48], cx);         /* mov [bp-0x48], cx */
            ii(0x15_b890, 3); mov(memw_a16[ss, bp - 0x46], dx);         /* mov [bp-0x46], dx */
            ii(0x15_b893, 1); pushw(ax);                                /* push ax */
            ii(0x15_b894, 1); pushw(dx);                                /* push dx */
            ii(0x15_b895, 1); pushw(cx);                                /* push cx */
            ii(0x15_b896, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b898, 3); callw(0x15_fed2, 0x4637);                 /* call 0xfed2 */
            ii(0x15_b89b, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_b89e, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_b8a1, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x15_b8a4, 3); lea(ax, bp - 0x44);                       /* lea ax, [bp-0x44] */
            ii(0x15_b8a7, 1); pushw(ss);                                /* push ss */
            ii(0x15_b8a8, 1); pushw(ax);                                /* push ax */
            ii(0x15_b8a9, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x15_b8ab, 3); callw(0x15_fef1, 0x4643);                 /* call 0xfef1 */
            ii(0x15_b8ae, 3); cmp(ax, 0x40);                            /* cmp ax, 0x40 */
            ii(0x15_b8b1, 2); if(jnzw(0x15_b927, 0x74)) goto l_0x15_b927; /* jnz 0xb927 */
            ii(0x15_b8b3, 5); cmp(memw_a16[ss, bp - 0x44], 0x5a4d);     /* cmp word [bp-0x44], 0x5a4d */
            ii(0x15_b8b8, 2); if(jnzw(0x15_b8ed, 0x33)) goto l_0x15_b8ed; /* jnz 0xb8ed */
            ii(0x15_b8ba, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x15_b8bd, 3); mov(ax, memw_a16[ss, bp - 0x48]);         /* mov ax, [bp-0x48] */
            ii(0x15_b8c0, 3); mov(dx, memw_a16[ss, bp - 0x46]);         /* mov dx, [bp-0x46] */
            ii(0x15_b8c3, 3); add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0x15_b8c6, 3); adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0x15_b8c9, 1); pushw(dx);                                /* push dx */
            ii(0x15_b8ca, 1); pushw(ax);                                /* push ax */
            ii(0x15_b8cb, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b8cd, 3); callw(0x15_fed2, 0x4602);                 /* call 0xfed2 */
            ii(0x15_b8d0, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_b8d3, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_b8d6, 3); pushw(memw_a16[ss, bp - 0x4c]);           /* push word [bp-0x4c] */
            ii(0x15_b8d9, 3); lea(ax, bp - 0x44);                       /* lea ax, [bp-0x44] */
            ii(0x15_b8dc, 1); pushw(ss);                                /* push ss */
            ii(0x15_b8dd, 1); pushw(ax);                                /* push ax */
            ii(0x15_b8de, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x15_b8e0, 3); callw(0x15_fef1, 0x460e);                 /* call 0xfef1 */
            ii(0x15_b8e3, 3); cmp(ax, 0x40);                            /* cmp ax, 0x40 */
            ii(0x15_b8e6, 2); if(jzw(0x15_b8ed, 0x5)) goto l_0x15_b8ed; /* jz 0xb8ed */
            ii(0x15_b8e8, 3); mov(ax, 0x515);                           /* mov ax, 0x515 */
            ii(0x15_b8eb, 2); jmpw(0x15_b92a, 0x3d); goto l_0x15_b92a;  /* jmp 0xb92a */
        l_0x15_b8ed:
            ii(0x15_b8ed, 5); cmp(memw_a16[ss, bp - 0x44], 0x454e);     /* cmp word [bp-0x44], 0x454e */
            ii(0x15_b8f2, 2); if(jzw(0x15_b902, 0xe)) goto l_0x15_b902; /* jz 0xb902 */
            ii(0x15_b8f4, 5); cmp(memw_a16[ss, bp - 0x44], 0x454c);     /* cmp word [bp-0x44], 0x454c */
            ii(0x15_b8f9, 2); if(jzw(0x15_b902, 0x7)) goto l_0x15_b902; /* jz 0xb902 */
            ii(0x15_b8fb, 5); cmp(memw_a16[ss, bp - 0x44], 0x584c);     /* cmp word [bp-0x44], 0x584c */
            ii(0x15_b900, 2); if(jnzw(0x15_b927, 0x25)) goto l_0x15_b927; /* jnz 0xb927 */
        l_0x15_b902:
            ii(0x15_b902, 3); mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x15_b905, 3); mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x15_b908, 3); les(bx, ss, bp + 0x4);                    /* les bx, [bp+0x4] */
            ii(0x15_b90b, 4); mov(memw_a16[es, bx + 0x6e], ax);         /* mov [es:bx+0x6e], ax */
            ii(0x15_b90f, 4); mov(memw_a16[es, bx + 0x70], dx);         /* mov [es:bx+0x70], dx */
            ii(0x15_b913, 3); mov(al, memb_a16[ss, bp - 0x44]);         /* mov al, [bp-0x44] */
            ii(0x15_b916, 5); mov(memb_a16[es, bx + 0xb2], al);         /* mov [es:bx+0xb2], al */
            ii(0x15_b91b, 3); mov(al, memb_a16[ss, bp - 0x43]);         /* mov al, [bp-0x43] */
            ii(0x15_b91e, 5); mov(memb_a16[es, bx + 0xb3], al);         /* mov [es:bx+0xb3], al */
            ii(0x15_b923, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x15_b925, 2); jmpw(0x15_b92a, 0x3); goto l_0x15_b92a;   /* jmp 0xb92a */
        l_0x15_b927:
            ii(0x15_b927, 3); mov(ax, 0x514);                           /* mov ax, 0x514 */
        l_0x15_b92a:
            ii(0x15_b92a, 1); leavew();                                 /* leave */
            ii(0x15_b92b, 3); retw(0x4); return;                        /* ret 0x4 */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_606f-6ef8762e")]
        public void Method_0019_606f()
        {
            ii(0x19_606f, 4); enterw(0x16, 0);                          /* enter 0x16, 0x0 */
            ii(0x19_6073, 1); pushw(di);                                /* push di */
            ii(0x19_6074, 1); pushw(si);                                /* push si */
            ii(0x19_6075, 5); callw_far_abs(0x80, 0x51a8);              /* call word 0x80:0x51a8 */
            ii(0x19_607a, 3); cmp(ax, 0);                               /* cmp ax, 0x0 */
            ii(0x19_607d, 2); if(jnzw(0x19_6082, 0x3)) goto l_0x19_6082; /* jnz 0x6082 */
            ii(0x19_607f, 3); jmpw(0x19_60a0, 0x1e); goto l_0x19_60a0;  /* jmp 0x60a0 */
        l_0x19_6082:
            ii(0x19_6082, 4); cmp(memw_a16[ss, bp + 0x6], 0x8);         /* cmp word [bp+0x6], 0x8 */
            ii(0x19_6086, 2); if(jnzw(0x19_608b, 0x3)) goto l_0x19_608b; /* jnz 0x608b */
            ii(0x19_6088, 3); jmpw(0x19_609d, 0x12); goto l_0x19_609d;  /* jmp 0x609d */
        l_0x19_608b:
            ii(0x19_608b, 4); cmp(memw_a16[ss, bp + 0x6], 0x9);         /* cmp word [bp+0x6], 0x9 */
            ii(0x19_608f, 2); if(jnzw(0x19_6094, 0x3)) goto l_0x19_6094; /* jnz 0x6094 */
            ii(0x19_6091, 3); jmpw(0x19_609d, 0x9); goto l_0x19_609d;   /* jmp 0x609d */
        l_0x19_6094:
            ii(0x19_6094, 4); cmp(memw_a16[ss, bp + 0x6], 0x1c);        /* cmp word [bp+0x6], 0x1c */
            ii(0x19_6098, 2); if(jzw(0x19_609d, 0x3)) goto l_0x19_609d; /* jz 0x609d */
            ii(0x19_609a, 3); jmpw(0x19_60a0, 0x3); goto l_0x19_60a0;   /* jmp 0x60a0 */
        l_0x19_609d:
            ii(0x19_609d, 3); jmpw(0x19_60d0, 0x30); goto l_0x19_60d0;  /* jmp 0x60d0 */
        l_0x19_60a0:
            ii(0x19_60a0, 4); mov(memb_a16[ss, bp - 0x7], 0x17);        /* mov byte [bp-0x7], 0x17 */
            ii(0x19_60a4, 3); mov(al, memb_a16[ss, bp + 0x8]);          /* mov al, [bp+0x8] */
            ii(0x19_60a7, 3); mov(memb_a16[ss, bp - 0x8], al);          /* mov [bp-0x8], al */
            ii(0x19_60aa, 4); mov(memb_a16[ss, bp - 0xd], 0xff);        /* mov byte [bp-0xd], 0xff */
            ii(0x19_60ae, 3); mov(al, memb_a16[ss, bp + 0x6]);          /* mov al, [bp+0x6] */
            ii(0x19_60b1, 3); mov(memb_a16[ss, bp - 0xe], al);          /* mov [bp-0xe], al */
            ii(0x19_60b4, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_60b7, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_60ba, 3); mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x19_60bd, 3); lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x19_60c0, 1); pushw(ss);                                /* push ss */
            ii(0x19_60c1, 1); pushw(ax);                                /* push ax */
            ii(0x19_60c2, 3); lea(ax, bp - 0xe);                        /* lea ax, [bp-0xe] */
            ii(0x19_60c5, 1); pushw(ss);                                /* push ss */
            ii(0x19_60c6, 1); pushw(ax);                                /* push ax */
            ii(0x19_60c7, 1); pushw(ss);                                /* push ss */
            ii(0x19_60c8, 1); pushw(ax);                                /* push ax */
            ii(0x19_60c9, 4); callw_a16_far_ind(ds, 0x1286);            /* call far word [0x1286] */
            ii(0x19_60cd, 3); add(sp, 0xc);                             /* add sp, 0xc */
        l_0x19_60d0:
            ii(0x19_60d0, 1); popw(si);                                 /* pop si */
            ii(0x19_60d1, 1); popw(di);                                 /* pop di */
            ii(0x19_60d2, 1); leavew();                                 /* leave */
            ii(0x19_60d3, 1); retfw();                                  /* retf */
        }
    }
}

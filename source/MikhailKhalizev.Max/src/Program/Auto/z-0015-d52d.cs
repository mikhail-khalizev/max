using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("eac0e02b-cbf4-487a-beb0-63ac4a1c3b02")]
        public void Method_0015_d52d()
        {
            ii(0x15_d52d, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
        l_0x15_d531:
            ii(0x15_d531, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x15_d534, 3); mov(dx, memw_a16[ss, bp + 0x8]);          /* mov dx, [bp+0x8] */
            ii(0x15_d537, 3); mov(memw_a16[ss, bp - 0x1c], ax);         /* mov [bp-0x1c], ax */
            ii(0x15_d53a, 3); mov(memw_a16[ss, bp - 0x1a], dx);         /* mov [bp-0x1a], dx */
            ii(0x15_d53d, 3); mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0x15_d540, 3); mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0x15_d543, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x15_d548, 3); mov(ax, memw_a16[ss, bp + 0xc]);          /* mov ax, [bp+0xc] */
            ii(0x15_d54b, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_d54e, 3); mov(ax, memw_a16[ds, 0x3296]);            /* mov ax, [0x3296] */
            ii(0x15_d551, 4); or(ax, memw_a16[ds, 0x3294]);             /* or ax, [0x3294] */
            ii(0x15_d555, 2); if(jzw(0x15_d560, 0x9)) goto l_0x15_d560; /* jz 0xd560 */
            ii(0x15_d557, 3); mov(ax, memw_a16[ds, 0x19ec]);            /* mov ax, [0x19ec] */
            ii(0x15_d55a, 4); or(ax, memw_a16[ds, 0x19ea]);             /* or ax, [0x19ea] */
            ii(0x15_d55e, 2); if(jnzw(0x15_d57c, 0x1c)) goto l_0x15_d57c; /* jnz 0xd57c */
        l_0x15_d560:
            ii(0x15_d560, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x15_d562, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_d565, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_d568, 1); pushw(dx);                                /* push dx */
            ii(0x15_d569, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_d56c, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x15_d56f, 1); pushw(ss);                                /* push ss */
            ii(0x15_d570, 1); pushw(ax);                                /* push ax */
            ii(0x15_d571, 3); callw(0x15_c684, -0xef0);                 /* call 0xc684 */
            ii(0x15_d574, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x15_d577, 3); mov(memw_a16[ss, bp - 0xe], dx);          /* mov [bp-0xe], dx */
            ii(0x15_d57a, 2); jmpw(0x15_d587, 0xb); goto l_0x15_d587;   /* jmp 0xd587 */
        l_0x15_d57c:
            ii(0x15_d57c, 3); lea(ax, bp - 0x1c);                       /* lea ax, [bp-0x1c] */
            ii(0x15_d57f, 1); pushw(ss);                                /* push ss */
            ii(0x15_d580, 1); pushw(ax);                                /* push ax */
            ii(0x15_d581, 4); callw_a16_far_ind(ds, 0x3294);            /* call far word [0x3294] */
            ii(0x15_d585, 1); popw(bx);                                 /* pop bx */
            ii(0x15_d586, 1); popw(bx);                                 /* pop bx */
        l_0x15_d587:
            ii(0x15_d587, 3); mov(ax, memw_a16[ss, bp - 0x10]);         /* mov ax, [bp-0x10] */
            ii(0x15_d58a, 3); mov(dx, memw_a16[ss, bp - 0xe]);          /* mov dx, [bp-0xe] */
            ii(0x15_d58d, 4); cmp(memw_a16[ds, 0x19ec], dx);            /* cmp [0x19ec], dx */
            ii(0x15_d591, 2); if(jbw(0x15_d5b3, 0x20)) goto l_0x15_d5b3; /* jb 0xd5b3 */
            ii(0x15_d593, 2); if(jaw(0x15_d59b, 0x6)) goto l_0x15_d59b; /* ja 0xd59b */
            ii(0x15_d595, 4); cmp(memw_a16[ds, 0x19ea], ax);            /* cmp [0x19ea], ax */
            ii(0x15_d599, 2); if(jbew(0x15_d5b3, 0x18)) goto l_0x15_d5b3; /* jbe 0xd5b3 */
        l_0x15_d59b:
            ii(0x15_d59b, 3); mov(ax, memw_a16[ds, 0x2a84]);            /* mov ax, [0x2a84] */
            ii(0x15_d59e, 4); mov(dx, memw_a16[ds, 0x2a86]);            /* mov dx, [0x2a86] */
            ii(0x15_d5a2, 3); mov(memw_a16[ss, bp + 0xa], ax);          /* mov [bp+0xa], ax */
            ii(0x15_d5a5, 3); mov(memw_a16[ss, bp + 0xc], dx);          /* mov [bp+0xc], dx */
            ii(0x15_d5a8, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_d5aa, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_d5ac, 4); inc(memb_a16[es, bx + 0x7]);              /* inc byte [es:bx+0x7] */
            ii(0x15_d5b0, 3); jmpw(0x15_d531, -0x82); goto l_0x15_d531; /* jmp 0xd531 */
        l_0x15_d5b3:
            ii(0x15_d5b3, 1); leavew();                                 /* leave */
            ii(0x15_d5b4, 1); retfw(); return;                          /* retf */
        }
    }
}

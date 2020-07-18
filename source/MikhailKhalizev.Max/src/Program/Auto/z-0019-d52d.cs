using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d52d-44641728")]
        public void Method_0019_d52d()
        {
            ii(0x19_d52d, 4);  enter(0x1c, 0);                         /* enter 0x1c, 0x0 */
        l_0x19_d531:
            ii(0x19_d531, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x19_d534, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x19_d537, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x19_d53a, 3);  mov(memw[ss, bp - 26], dx);             /* mov [bp-0x1a], dx */
            ii(0x19_d53d, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_d540, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x19_d543, 5);  mov(memw[ss, bp - 10], 0);              /* mov word [bp-0xa], 0x0 */
            ii(0x19_d548, 3);  mov(ax, memw[ss, bp + 12]);             /* mov ax, [bp+0xc] */
            ii(0x19_d54b, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_d54e, 3);  mov(ax, memw[ds, 0x3296]);              /* mov ax, [0x3296] */
            ii(0x19_d551, 4);  or(ax, memw[ds, 0x3294]);               /* or ax, [0x3294] */
            ii(0x19_d555, 2);  if(jz(0x19_d560, 9)) goto l_0x19_d560;  /* jz 0xd560 */
            ii(0x19_d557, 3);  mov(ax, memw[ds, 0x19ec]);              /* mov ax, [0x19ec] */
            ii(0x19_d55a, 4);  or(ax, memw[ds, 0x19ea]);               /* or ax, [0x19ea] */
            ii(0x19_d55e, 2);  if(jnz(0x19_d57c, 0x1c)) goto l_0x19_d57c;/* jnz 0xd57c */
        l_0x19_d560:
            ii(0x19_d560, 2);  push(4);                                /* push 0x4 */
            ii(0x19_d562, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_d565, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_d568, 1);  push(dx);                               /* push dx */
            ii(0x19_d569, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_d56c, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x19_d56f, 1);  push(ss);                               /* push ss */
            ii(0x19_d570, 1);  push(ax);                               /* push ax */
            ii(0x19_d571, 3);  call(0x19_c684, -0xef0);                /* call 0xc684 */
            ii(0x19_d574, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x19_d577, 3);  mov(memw[ss, bp - 14], dx);             /* mov [bp-0xe], dx */
            ii(0x19_d57a, 2);  jmp(0x19_d587, 0xb); goto l_0x19_d587;  /* jmp 0xd587 */
        l_0x19_d57c:
            ii(0x19_d57c, 3);  lea(ax, memw[ss, bp - 28]);             /* lea ax, [bp-0x1c] */
            ii(0x19_d57f, 1);  push(ss);                               /* push ss */
            ii(0x19_d580, 1);  push(ax);                               /* push ax */
            ii(0x19_d581, 4);  call_far_ind(memw[ds, 0x3294]);         /* call far word [0x3294] */
            ii(0x19_d585, 1);  pop(bx);                                /* pop bx */
            ii(0x19_d586, 1);  pop(bx);                                /* pop bx */
        l_0x19_d587:
            ii(0x19_d587, 3);  mov(ax, memw[ss, bp - 16]);             /* mov ax, [bp-0x10] */
            ii(0x19_d58a, 3);  mov(dx, memw[ss, bp - 14]);             /* mov dx, [bp-0xe] */
            ii(0x19_d58d, 4);  cmp(memw[ds, 0x19ec], dx);              /* cmp [0x19ec], dx */
            ii(0x19_d591, 2);  if(jb(0x19_d5b3, 0x20)) goto l_0x19_d5b3;/* jb 0xd5b3 */
            ii(0x19_d593, 2);  if(ja(0x19_d59b, 6)) goto l_0x19_d59b;  /* ja 0xd59b */
            ii(0x19_d595, 4);  cmp(memw[ds, 0x19ea], ax);              /* cmp [0x19ea], ax */
            ii(0x19_d599, 2);  if(jbe(0x19_d5b3, 0x18)) goto l_0x19_d5b3;/* jbe 0xd5b3 */
        l_0x19_d59b:
            ii(0x19_d59b, 3);  mov(ax, memw[ds, 0x2a84]);              /* mov ax, [0x2a84] */
            ii(0x19_d59e, 4);  mov(dx, memw[ds, 0x2a86]);              /* mov dx, [0x2a86] */
            ii(0x19_d5a2, 3);  mov(memw[ss, bp + 10], ax);             /* mov [bp+0xa], ax */
            ii(0x19_d5a5, 3);  mov(memw[ss, bp + 12], dx);             /* mov [bp+0xc], dx */
            ii(0x19_d5a8, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x19_d5aa, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x19_d5ac, 4);  inc(memb[es, bx + 7]);                  /* inc byte [es:bx+0x7] */
            ii(0x19_d5b0, 3);  jmp(0x19_d531, -0x82); goto l_0x19_d531;/* jmp 0xd531 */
        l_0x19_d5b3:
            ii(0x19_d5b3, 1);  leave();                                /* leave */
            ii(0x19_d5b4, 1);  retf();                                 /* retf */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_dddc-2644f500")]
        public void Method_0017_dddc()
        {
            ii(0x17_dddc, 1);  push(bp);                               /* push bp */
            ii(0x17_dddd, 2);  mov(bp, sp);                            /* mov bp, sp */
            ii(0x17_dddf, 1);  push(di);                               /* push di */
            ii(0x17_dde0, 1);  push(si);                               /* push si */
            ii(0x17_dde1, 1);  push(bx);                               /* push bx */
            ii(0x17_dde2, 2);  xor(di, di);                            /* xor di, di */
            ii(0x17_dde4, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x17_dde7, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_dde9, 2);  if(jge(0x17_ddfc, 0x11)) goto l_0x17_ddfc;/* jge 0xddfc */
            ii(0x17_ddeb, 1);  inc(di);                                /* inc di */
            ii(0x17_ddec, 3);  mov(dx, memw[ss, bp + 6]);              /* mov dx, [bp+0x6] */
            ii(0x17_ddef, 2);  neg(ax);                                /* neg ax */
            ii(0x17_ddf1, 2);  neg(dx);                                /* neg dx */
            ii(0x17_ddf3, 3);  sbb(ax, 0);                             /* sbb ax, 0x0 */
            ii(0x17_ddf6, 3);  mov(memw[ss, bp + 8], ax);              /* mov [bp+0x8], ax */
            ii(0x17_ddf9, 3);  mov(memw[ss, bp + 6], dx);              /* mov [bp+0x6], dx */
        l_0x17_ddfc:
            ii(0x17_ddfc, 3);  mov(ax, memw[ss, bp + 12]);             /* mov ax, [bp+0xc] */
            ii(0x17_ddff, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_de01, 2);  if(jge(0x17_de14, 0x11)) goto l_0x17_de14;/* jge 0xde14 */
            ii(0x17_de03, 1);  inc(di);                                /* inc di */
            ii(0x17_de04, 3);  mov(dx, memw[ss, bp + 10]);             /* mov dx, [bp+0xa] */
            ii(0x17_de07, 2);  neg(ax);                                /* neg ax */
            ii(0x17_de09, 2);  neg(dx);                                /* neg dx */
            ii(0x17_de0b, 3);  sbb(ax, 0);                             /* sbb ax, 0x0 */
            ii(0x17_de0e, 3);  mov(memw[ss, bp + 12], ax);             /* mov [bp+0xc], ax */
            ii(0x17_de11, 3);  mov(memw[ss, bp + 10], dx);             /* mov [bp+0xa], dx */
        l_0x17_de14:
            ii(0x17_de14, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_de16, 2);  if(jnz(0x17_de2d, 0x15)) goto l_0x17_de2d;/* jnz 0xde2d */
            ii(0x17_de18, 3);  mov(cx, memw[ss, bp + 10]);             /* mov cx, [bp+0xa] */
            ii(0x17_de1b, 3);  mov(ax, memw[ss, bp + 8]);              /* mov ax, [bp+0x8] */
            ii(0x17_de1e, 2);  xor(dx, dx);                            /* xor dx, dx */
            ii(0x17_de20, 2);  div(cx);                                /* div cx */
            ii(0x17_de22, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x17_de24, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x17_de27, 2);  div(cx);                                /* div cx */
            ii(0x17_de29, 2);  mov(dx, bx);                            /* mov dx, bx */
            ii(0x17_de2b, 2);  jmp(0x17_de65, 0x38); goto l_0x17_de65; /* jmp 0xde65 */
        l_0x17_de2d:
            ii(0x17_de2d, 2);  mov(bx, ax);                            /* mov bx, ax */
            ii(0x17_de2f, 3);  mov(cx, memw[ss, bp + 10]);             /* mov cx, [bp+0xa] */
            ii(0x17_de32, 3);  mov(dx, memw[ss, bp + 8]);              /* mov dx, [bp+0x8] */
            ii(0x17_de35, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
        l_0x17_de38:
            ii(0x17_de38, 2);  shr(bx, 1);                             /* shr bx, 1 */
            ii(0x17_de3a, 2);  rcr(cx, 1);                             /* rcr cx, 1 */
            ii(0x17_de3c, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x17_de3e, 2);  rcr(ax, 1);                             /* rcr ax, 1 */
            ii(0x17_de40, 2);  or(bx, bx);                             /* or bx, bx */
            ii(0x17_de42, 2);  if(jnz(0x17_de38, -0xc)) goto l_0x17_de38;/* jnz 0xde38 */
            ii(0x17_de44, 2);  div(cx);                                /* div cx */
            ii(0x17_de46, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x17_de48, 3);  mul(memw[ss, bp + 12]);                 /* mul word [bp+0xc] */
            ii(0x17_de4b, 1);  xchg(cx, ax);                           /* xchg cx, ax */
            ii(0x17_de4c, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x17_de4f, 2);  mul(si);                                /* mul si */
            ii(0x17_de51, 2);  add(dx, cx);                            /* add dx, cx */
            ii(0x17_de53, 2);  if(jb(0x17_de61, 0xc)) goto l_0x17_de61;/* jb 0xde61 */
            ii(0x17_de55, 3);  cmp(dx, memw[ss, bp + 8]);              /* cmp dx, [bp+0x8] */
            ii(0x17_de58, 2);  if(ja(0x17_de61, 7)) goto l_0x17_de61;  /* ja 0xde61 */
            ii(0x17_de5a, 2);  if(jb(0x17_de62, 6)) goto l_0x17_de62;  /* jb 0xde62 */
            ii(0x17_de5c, 3);  cmp(ax, memw[ss, bp + 6]);              /* cmp ax, [bp+0x6] */
            ii(0x17_de5f, 2);  if(jbe(0x17_de62, 1)) goto l_0x17_de62; /* jbe 0xde62 */
        l_0x17_de61:
            ii(0x17_de61, 1);  dec(si);                                /* dec si */
        l_0x17_de62:
            ii(0x17_de62, 2);  xor(dx, dx);                            /* xor dx, dx */
            ii(0x17_de64, 1);  xchg(si, ax);                           /* xchg si, ax */
        l_0x17_de65:
            ii(0x17_de65, 1);  dec(di);                                /* dec di */
            ii(0x17_de66, 2);  if(jnz(0x17_de6f, 7)) goto l_0x17_de6f; /* jnz 0xde6f */
            ii(0x17_de68, 2);  neg(dx);                                /* neg dx */
            ii(0x17_de6a, 2);  neg(ax);                                /* neg ax */
            ii(0x17_de6c, 3);  sbb(dx, 0);                             /* sbb dx, 0x0 */
        l_0x17_de6f:
            ii(0x17_de6f, 1);  pop(bx);                                /* pop bx */
            ii(0x17_de70, 1);  pop(si);                                /* pop si */
            ii(0x17_de71, 1);  pop(di);                                /* pop di */
            ii(0x17_de72, 1);  pop(bp);                                /* pop bp */
            ii(0x17_de73, 3);  retf(8);                                /* retf 0x8 */
        }
    }
}

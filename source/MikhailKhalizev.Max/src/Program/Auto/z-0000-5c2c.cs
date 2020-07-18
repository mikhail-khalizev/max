using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c2c-815c226a")]
        public void Method_0000_5c2c()
        {
            ii(0x5c2c, 1);  push(bp);                                  /* push bp */
            ii(0x5c2d, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x5c2f, 1);  push(si);                                  /* push si */
            ii(0x5c30, 1);  push(di);                                  /* push di */
            ii(0x5c31, 1);  push(ds);                                  /* push ds */
            ii(0x5c32, 3);  sub(sp, 0xa);                              /* sub sp, 0xa */
            ii(0x5c35, 4);  mov(memb[ss, bp - 12], 0xcd);              /* mov byte [bp-0xc], 0xcd */
            ii(0x5c39, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x5c3c, 3);  mov(memb[ss, bp - 11], al);                /* mov [bp-0xb], al */
            ii(0x5c3f, 2);  cmp(al, 0x25);                             /* cmp al, 0x25 */
            ii(0x5c41, 2);  if(jz(0x5c4d, 0xa)) goto l_0x5c4d;         /* jz 0x5c4d */
            ii(0x5c43, 2);  cmp(al, 0x26);                             /* cmp al, 0x26 */
            ii(0x5c45, 2);  if(jz(0x5c4d, 6)) goto l_0x5c4d;           /* jz 0x5c4d */
            ii(0x5c47, 4);  mov(memb[ss, bp - 10], 0xcb);              /* mov byte [bp-0xa], 0xcb */
            ii(0x5c4b, 2);  jmp(0x5c59, 0xc); goto l_0x5c59;           /* jmp 0x5c59 */
        l_0x5c4d:
            ii(0x5c4d, 4);  mov(memb[ss, bp - 8], 0xcb);               /* mov byte [bp-0x8], 0xcb */
            ii(0x5c51, 4);  mov(memb[ss, bp - 9], 0x44);               /* mov byte [bp-0x9], 0x44 */
            ii(0x5c55, 4);  mov(memb[ss, bp - 10], 0x44);              /* mov byte [bp-0xa], 0x44 */
        l_0x5c59:
            ii(0x5c59, 3);  mov(memw[ss, bp - 14], ss);                /* mov [bp-0xe], ss */
            ii(0x5c5c, 3);  lea(ax, memw[ss, bp - 12]);                /* lea ax, [bp-0xc] */
            ii(0x5c5f, 3);  mov(memw[ss, bp - 16], ax);                /* mov [bp-0x10], ax */
            ii(0x5c62, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0x5c65, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
            ii(0x5c67, 3);  mov(bx, memw[ds, di + 2]);                 /* mov bx, [di+0x2] */
            ii(0x5c6a, 3);  mov(cx, memw[ds, di + 4]);                 /* mov cx, [di+0x4] */
            ii(0x5c6d, 3);  mov(dx, memw[ds, di + 6]);                 /* mov dx, [di+0x6] */
            ii(0x5c70, 3);  mov(si, memw[ds, di + 8]);                 /* mov si, [di+0x8] */
            ii(0x5c73, 3);  push(memw[ds, di + 10]);                   /* push word [di+0xa] */
            ii(0x5c76, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0x5c79, 2);  mov(es, memw[ds, di]);                     /* mov es, [di] */
            ii(0x5c7b, 3);  mov(ds, memw[ds, di + 6]);                 /* mov ds, [di+0x6] */
            ii(0x5c7e, 1);  pop(di);                                   /* pop di */
            ii(0x5c7f, 1);  push(bp);                                  /* push bp */
            ii(0x5c80, 3);  call_far_ind(memw[ss, bp - 16]);           /* call far word [bp-0x10] */
            ii(0x5c83, 1);  pop(bp);                                   /* pop bp */
            ii(0x5c84, 1);  cld();                                     /* cld */
            ii(0x5c85, 1);  push(di);                                  /* push di */
            ii(0x5c86, 1);  push(ds);                                  /* push ds */
            ii(0x5c87, 1);  push(ss);                                  /* push ss */
            ii(0x5c88, 1);  pop(ds);                                   /* pop ds */
            ii(0x5c89, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0x5c8c, 2);  mov(memw[ds, di], es);                     /* mov [di], es */
            ii(0x5c8e, 3);  pop(memw[ds, di + 6]);                     /* pop word [di+0x6] */
            ii(0x5c91, 3);  mov(di, memw[ss, bp + 8]);                 /* mov di, [bp+0x8] */
            ii(0x5c94, 2);  mov(memw[ds, di], ax);                     /* mov [di], ax */
            ii(0x5c96, 3);  mov(memw[ds, di + 2], bx);                 /* mov [di+0x2], bx */
            ii(0x5c99, 3);  mov(memw[ds, di + 4], cx);                 /* mov [di+0x4], cx */
            ii(0x5c9c, 3);  mov(memw[ds, di + 6], dx);                 /* mov [di+0x6], dx */
            ii(0x5c9f, 3);  mov(memw[ds, di + 8], si);                 /* mov [di+0x8], si */
            ii(0x5ca2, 3);  pop(memw[ds, di + 10]);                    /* pop word [di+0xa] */
            ii(0x5ca5, 2);  if(jb(0x5cab, 4)) goto l_0x5cab;           /* jb 0x5cab */
            ii(0x5ca7, 2);  xor(si, si);                               /* xor si, si */
            ii(0x5ca9, 2);  jmp(0x5cb3, 8); goto l_0x5cb3;             /* jmp 0x5cb3 */
        l_0x5cab:
            ii(0x5cab, 3);  call(0x5dce, 0x120);                       /* call 0x5dce */
            ii(0x5cae, 3);  mov(si, 1);                                /* mov si, 0x1 */
            ii(0x5cb1, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
        l_0x5cb3:
            ii(0x5cb3, 3);  mov(memw[ds, di + 12], si);                /* mov [di+0xc], si */
            ii(0x5cb6, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0x5cb9, 1);  pop(ds);                                   /* pop ds */
            ii(0x5cba, 1);  pop(di);                                   /* pop di */
            ii(0x5cbb, 1);  pop(si);                                   /* pop si */
            ii(0x5cbc, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x5cbe, 1);  pop(bp);                                   /* pop bp */
            ii(0x5cbf, 1);  ret();                                     /* ret */
        }
    }
}

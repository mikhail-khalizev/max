using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9e24-7c9191a6")]
        public void Method_0000_9e24()
        {
            ii(0x9e24, 1);  push(bp);                                  /* push bp */
            ii(0x9e25, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x9e27, 1);  push(si);                                  /* push si */
            ii(0x9e28, 1);  push(di);                                  /* push di */
            ii(0x9e29, 3);  sub(sp, 0xa);                              /* sub sp, 0xa */
            ii(0x9e2c, 4);  mov(memb[ss, bp - 10], 0xcd);              /* mov byte [bp-0xa], 0xcd */
            ii(0x9e30, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x9e33, 3);  mov(memb[ss, bp - 9], al);                 /* mov [bp-0x9], al */
            ii(0x9e36, 2);  cmp(al, 0x25);                             /* cmp al, 0x25 */
            ii(0x9e38, 2);  if(jz(0x9e44, 0xa)) goto l_0x9e44;         /* jz 0x9e44 */
            ii(0x9e3a, 2);  cmp(al, 0x26);                             /* cmp al, 0x26 */
            ii(0x9e3c, 2);  if(jz(0x9e44, 6)) goto l_0x9e44;           /* jz 0x9e44 */
            ii(0x9e3e, 4);  mov(memb[ss, bp - 8], 0xcb);               /* mov byte [bp-0x8], 0xcb */
            ii(0x9e42, 2);  jmp(0x9e50, 0xc); goto l_0x9e50;           /* jmp 0x9e50 */
        l_0x9e44:
            ii(0x9e44, 4);  mov(memb[ss, bp - 6], 0xcb);               /* mov byte [bp-0x6], 0xcb */
            ii(0x9e48, 4);  mov(memb[ss, bp - 7], 0x44);               /* mov byte [bp-0x7], 0x44 */
            ii(0x9e4c, 4);  mov(memb[ss, bp - 8], 0x44);               /* mov byte [bp-0x8], 0x44 */
        l_0x9e50:
            ii(0x9e50, 3);  mov(memw[ss, bp - 12], ss);                /* mov [bp-0xc], ss */
            ii(0x9e53, 3);  lea(ax, memw[ss, bp - 10]);                /* lea ax, [bp-0xa] */
            ii(0x9e56, 3);  mov(memw[ss, bp - 14], ax);                /* mov [bp-0xe], ax */
            ii(0x9e59, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0x9e5c, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
            ii(0x9e5e, 3);  mov(bx, memw[ds, di + 2]);                 /* mov bx, [di+0x2] */
            ii(0x9e61, 3);  mov(cx, memw[ds, di + 4]);                 /* mov cx, [di+0x4] */
            ii(0x9e64, 3);  mov(dx, memw[ds, di + 6]);                 /* mov dx, [di+0x6] */
            ii(0x9e67, 3);  mov(si, memw[ds, di + 8]);                 /* mov si, [di+0x8] */
            ii(0x9e6a, 3);  mov(di, memw[ds, di + 10]);                /* mov di, [di+0xa] */
            ii(0x9e6d, 1);  push(bp);                                  /* push bp */
            ii(0x9e6e, 3);  call_far_ind(memw[ss, bp - 14]);           /* call far word [bp-0xe] */
            ii(0x9e71, 1);  pop(bp);                                   /* pop bp */
            ii(0x9e72, 1);  cld();                                     /* cld */
            ii(0x9e73, 1);  push(di);                                  /* push di */
            ii(0x9e74, 3);  mov(di, memw[ss, bp + 8]);                 /* mov di, [bp+0x8] */
            ii(0x9e77, 2);  mov(memw[ds, di], ax);                     /* mov [di], ax */
            ii(0x9e79, 3);  mov(memw[ds, di + 2], bx);                 /* mov [di+0x2], bx */
            ii(0x9e7c, 3);  mov(memw[ds, di + 4], cx);                 /* mov [di+0x4], cx */
            ii(0x9e7f, 3);  mov(memw[ds, di + 6], dx);                 /* mov [di+0x6], dx */
            ii(0x9e82, 3);  mov(memw[ds, di + 8], si);                 /* mov [di+0x8], si */
            ii(0x9e85, 3);  pop(memw[ds, di + 10]);                    /* pop word [di+0xa] */
            ii(0x9e88, 2);  if(jb(0x9e8e, 4)) goto l_0x9e8e;           /* jb 0x9e8e */
            ii(0x9e8a, 2);  xor(si, si);                               /* xor si, si */
            ii(0x9e8c, 2);  jmp(0x9e96, 8); goto l_0x9e96;             /* jmp 0x9e96 */
        l_0x9e8e:
            ii(0x9e8e, 3);  call(0x657e, -0x3913);                     /* call 0x657e */
            ii(0x9e91, 3);  mov(si, 1);                                /* mov si, 0x1 */
            ii(0x9e94, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
        l_0x9e96:
            ii(0x9e96, 3);  mov(memw[ds, di + 12], si);                /* mov [di+0xc], si */
            ii(0x9e99, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0x9e9c, 1);  pop(di);                                   /* pop di */
            ii(0x9e9d, 1);  pop(si);                                   /* pop si */
            ii(0x9e9e, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x9ea0, 1);  pop(bp);                                   /* pop bp */
            ii(0x9ea1, 1);  ret();                                     /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x83ec-815c226a")]
        public void Method_0000_83ec()
        {
            ii(0x83ec, 1);  push(bp);                                  /* push bp */
            ii(0x83ed, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x83ef, 1);  push(si);                                  /* push si */
            ii(0x83f0, 1);  push(di);                                  /* push di */
            ii(0x83f1, 1);  push(ds);                                  /* push ds */
            ii(0x83f2, 3);  sub(sp, 0xa);                              /* sub sp, 0xa */
            ii(0x83f5, 4);  mov(memb[ss, bp - 12], 0xcd);              /* mov byte [bp-0xc], 0xcd */
            ii(0x83f9, 3);  mov(ax, memw[ss, bp + 4]);                 /* mov ax, [bp+0x4] */
            ii(0x83fc, 3);  mov(memb[ss, bp - 11], al);                /* mov [bp-0xb], al */
            ii(0x83ff, 2);  cmp(al, 0x25);                             /* cmp al, 0x25 */
            ii(0x8401, 2);  if(jz(0x840d, 0xa)) goto l_0x840d;         /* jz 0x840d */
            ii(0x8403, 2);  cmp(al, 0x26);                             /* cmp al, 0x26 */
            ii(0x8405, 2);  if(jz(0x840d, 6)) goto l_0x840d;           /* jz 0x840d */
            ii(0x8407, 4);  mov(memb[ss, bp - 10], 0xcb);              /* mov byte [bp-0xa], 0xcb */
            ii(0x840b, 2);  jmp(0x8419, 0xc); goto l_0x8419;           /* jmp 0x8419 */
        l_0x840d:
            ii(0x840d, 4);  mov(memb[ss, bp - 8], 0xcb);               /* mov byte [bp-0x8], 0xcb */
            ii(0x8411, 4);  mov(memb[ss, bp - 9], 0x44);               /* mov byte [bp-0x9], 0x44 */
            ii(0x8415, 4);  mov(memb[ss, bp - 10], 0x44);              /* mov byte [bp-0xa], 0x44 */
        l_0x8419:
            ii(0x8419, 3);  mov(memw[ss, bp - 14], ss);                /* mov [bp-0xe], ss */
            ii(0x841c, 3);  lea(ax, memw[ss, bp - 12]);                /* lea ax, [bp-0xc] */
            ii(0x841f, 3);  mov(memw[ss, bp - 16], ax);                /* mov [bp-0x10], ax */
            ii(0x8422, 3);  mov(di, memw[ss, bp + 6]);                 /* mov di, [bp+0x6] */
            ii(0x8425, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
            ii(0x8427, 3);  mov(bx, memw[ds, di + 2]);                 /* mov bx, [di+0x2] */
            ii(0x842a, 3);  mov(cx, memw[ds, di + 4]);                 /* mov cx, [di+0x4] */
            ii(0x842d, 3);  mov(dx, memw[ds, di + 6]);                 /* mov dx, [di+0x6] */
            ii(0x8430, 3);  mov(si, memw[ds, di + 8]);                 /* mov si, [di+0x8] */
            ii(0x8433, 3);  push(memw[ds, di + 10]);                   /* push word [di+0xa] */
            ii(0x8436, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0x8439, 2);  mov(es, memw[ds, di]);                     /* mov es, [di] */
            ii(0x843b, 3);  mov(ds, memw[ds, di + 6]);                 /* mov ds, [di+0x6] */
            ii(0x843e, 1);  pop(di);                                   /* pop di */
            ii(0x843f, 1);  push(bp);                                  /* push bp */
            ii(0x8440, 3);  call_far_ind(memw[ss, bp - 16]);           /* call far word [bp-0x10] */
            ii(0x8443, 1);  pop(bp);                                   /* pop bp */
            ii(0x8444, 1);  cld();                                     /* cld */
            ii(0x8445, 1);  push(di);                                  /* push di */
            ii(0x8446, 1);  push(ds);                                  /* push ds */
            ii(0x8447, 1);  push(ss);                                  /* push ss */
            ii(0x8448, 1);  pop(ds);                                   /* pop ds */
            ii(0x8449, 3);  mov(di, memw[ss, bp + 10]);                /* mov di, [bp+0xa] */
            ii(0x844c, 2);  mov(memw[ds, di], es);                     /* mov [di], es */
            ii(0x844e, 3);  pop(memw[ds, di + 6]);                     /* pop word [di+0x6] */
            ii(0x8451, 3);  mov(di, memw[ss, bp + 8]);                 /* mov di, [bp+0x8] */
            ii(0x8454, 2);  mov(memw[ds, di], ax);                     /* mov [di], ax */
            ii(0x8456, 3);  mov(memw[ds, di + 2], bx);                 /* mov [di+0x2], bx */
            ii(0x8459, 3);  mov(memw[ds, di + 4], cx);                 /* mov [di+0x4], cx */
            ii(0x845c, 3);  mov(memw[ds, di + 6], dx);                 /* mov [di+0x6], dx */
            ii(0x845f, 3);  mov(memw[ds, di + 8], si);                 /* mov [di+0x8], si */
            ii(0x8462, 3);  pop(memw[ds, di + 10]);                    /* pop word [di+0xa] */
            ii(0x8465, 2);  if(jb(0x846b, 4)) goto l_0x846b;           /* jb 0x846b */
            ii(0x8467, 2);  xor(si, si);                               /* xor si, si */
            ii(0x8469, 2);  jmp(0x8473, 8); goto l_0x8473;             /* jmp 0x8473 */
        l_0x846b:
            ii(0x846b, 3);  call(0x858e, 0x120);                       /* call 0x858e */
            ii(0x846e, 3);  mov(si, 1);                                /* mov si, 0x1 */
            ii(0x8471, 2);  mov(ax, memw[ds, di]);                     /* mov ax, [di] */
        l_0x8473:
            ii(0x8473, 3);  mov(memw[ds, di + 12], si);                /* mov [di+0xc], si */
            ii(0x8476, 3);  add(sp, 0xa);                              /* add sp, 0xa */
            ii(0x8479, 1);  pop(ds);                                   /* pop ds */
            ii(0x847a, 1);  pop(di);                                   /* pop di */
            ii(0x847b, 1);  pop(si);                                   /* pop si */
            ii(0x847c, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x847e, 1);  pop(bp);                                   /* pop bp */
            ii(0x847f, 1);  ret();                                     /* ret */
        }
    }
}

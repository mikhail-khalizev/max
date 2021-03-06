using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d4de-4a94744f")]
        public void Method_0018_d4de()
        {
            ii(0x18_d4de, 4);  enter(0x14, 0);                         /* enter 0x14, 0x0 */
            ii(0x18_d4e2, 1);  push(di);                               /* push di */
            ii(0x18_d4e3, 1);  push(si);                               /* push si */
            ii(0x18_d4e4, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x18_d4e7, 3);  dec(memw[ss, bp + 6]);                  /* dec word [bp+0x6] */
            ii(0x18_d4ea, 3);  cmp(ax, memw[ss, bp + 4]);              /* cmp ax, [bp+0x4] */
            ii(0x18_d4ed, 2);  if(jnz(0x18_d4f2, 3)) goto l_0x18_d4f2; /* jnz 0xd4f2 */
            ii(0x18_d4ef, 3);  jmp(0x18_d581, 0x8f); goto l_0x18_d581; /* jmp 0xd581 */
        l_0x18_d4f2:
            ii(0x18_d4f2, 3);  lea(ax, memw[ss, bp - 18]);             /* lea ax, [bp-0x12] */
            ii(0x18_d4f5, 1);  push(ax);                               /* push ax */
            ii(0x18_d4f6, 4);  mov(cx, memw[ds, 0xc38]);               /* mov cx, [0xc38] */
            ii(0x18_d4fa, 3);  mov(memw[ss, bp - 2], cx);              /* mov [bp-0x2], cx */
            ii(0x18_d4fd, 1);  push(cx);                               /* push cx */
            ii(0x18_d4fe, 3);  call(0x18_dc8e, 0x78d);                 /* call 0xdc8e */
            ii(0x18_d501, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d502, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d503, 3);  mov(ax, memw[ss, bp + 6]);              /* mov ax, [bp+0x6] */
            ii(0x18_d506, 3);  shr(ax, 0xc);                           /* shr ax, 0xc */
            ii(0x18_d509, 3);  mov(cx, memw[ss, bp + 6]);              /* mov cx, [bp+0x6] */
            ii(0x18_d50c, 3);  shl(cx, 4);                             /* shl cx, 0x4 */
            ii(0x18_d50f, 3);  mov(memw[ss, bp - 18], cx);             /* mov [bp-0x12], cx */
            ii(0x18_d512, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x18_d515, 3);  lea(ax, memw[ss, bp - 18]);             /* lea ax, [bp-0x12] */
            ii(0x18_d518, 1);  push(ax);                               /* push ax */
            ii(0x18_d519, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x18_d51c, 3);  call(0x18_dc28, 0x709);                 /* call 0xdc28 */
            ii(0x18_d51f, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d520, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d521, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x18_d524, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x18_d526, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x18_d528, 3);  mov(memw[ss, bp - 8], bx);              /* mov [bp-0x8], bx */
            ii(0x18_d52b, 3);  mov(memw[ss, bp - 6], es);              /* mov [bp-0x6], es */
            ii(0x18_d52e, 4);  cmp(memb[es, bx], 0x4d);                /* cmp byte [es:bx], 0x4d */
            ii(0x18_d532, 2);  if(jz(0x18_d53a, 6)) goto l_0x18_d53a;  /* jz 0xd53a */
            ii(0x18_d534, 4);  cmp(memb[es, bx], 0x5a);                /* cmp byte [es:bx], 0x5a */
            ii(0x18_d538, 2);  if(jnz(0x18_d581, 0x47)) goto l_0x18_d581;/* jnz 0xd581 */
        l_0x18_d53a:
            ii(0x18_d53a, 3);  mov(ax, memw[ss, bp + 4]);              /* mov ax, [bp+0x4] */
            ii(0x18_d53d, 3);  sub(ax, memw[ss, bp + 6]);              /* sub ax, [bp+0x6] */
            ii(0x18_d540, 1);  dec(ax);                                /* dec ax */
            ii(0x18_d541, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x18_d544, 3);  shl(ax, 4);                             /* shl ax, 0x4 */
            ii(0x18_d547, 3);  add(ax, memw[ss, bp - 8]);              /* add ax, [bp-0x8] */
            ii(0x18_d54a, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x18_d54c, 3);  mov(cx, memw[ss, bp - 8]);              /* mov cx, [bp-0x8] */
            ii(0x18_d54f, 2);  mov(bx, es);                            /* mov bx, es */
            ii(0x18_d551, 1);  push(cx);                               /* push cx */
            ii(0x18_d552, 1);  push(ds);                               /* push ds */
            ii(0x18_d553, 2);  mov(di, ax);                            /* mov di, ax */
            ii(0x18_d555, 2);  mov(si, cx);                            /* mov si, cx */
            ii(0x18_d557, 2);  mov(ds, dx);                            /* mov ds, dx */
            ii(0x18_d559, 3);  mov(cx, 8);                             /* mov cx, 0x8 */
            ii(0x18_d55c, 2);  rep(() => movsw());                     /* rep movsw */
            ii(0x18_d55e, 1);  pop(ds);                                /* pop ds */
            ii(0x18_d55f, 1);  pop(cx);                                /* pop cx */
            ii(0x18_d560, 2);  mov(es, bx);                            /* mov es, bx */
            ii(0x18_d562, 2);  mov(si, cx);                            /* mov si, cx */
            ii(0x18_d564, 4);  mov(memb[es, si], 0x4d);                /* mov byte [es:si], 0x4d */
            ii(0x18_d568, 3);  mov(di, memw[ss, bp - 4]);              /* mov di, [bp-0x4] */
            ii(0x18_d56b, 1);  dec(di);                                /* dec di */
            ii(0x18_d56c, 4);  mov(memw[es, si + 3], di);              /* mov [es:si+0x3], di */
            ii(0x18_d570, 6);  mov(memw[es, si + 1], 0);               /* mov word [es:si+0x1], 0x0 */
            ii(0x18_d576, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x18_d578, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x18_d57a, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x18_d57d, 4);  sub(memw[es, si + 3], ax);              /* sub [es:si+0x3], ax */
        l_0x18_d581:
            ii(0x18_d581, 1);  pop(si);                                /* pop si */
            ii(0x18_d582, 1);  pop(di);                                /* pop di */
            ii(0x18_d583, 1);  leave();                                /* leave */
            ii(0x18_d584, 1);  ret();                                  /* ret */
        }
    }
}

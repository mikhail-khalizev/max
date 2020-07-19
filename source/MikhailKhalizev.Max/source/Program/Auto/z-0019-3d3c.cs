using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_3d3c-368abb31")]
        public void Method_0019_3d3c()
        {
            ii(0x19_3d3c, 1);  push(cx);                               /* push cx */
            ii(0x19_3d3d, 1);  push(di);                               /* push di */
            ii(0x19_3d3e, 4);  test(memb[ds, bx + 2], 1);              /* test byte [bx+0x2], 0x1 */
            ii(0x19_3d42, 2);  if(jz(0x19_3daa, 0x66)) goto l_0x19_3daa;/* jz 0x3daa */
            ii(0x19_3d44, 3);  call(0x19_3e1c, 0xd5);                  /* call 0x3e1c */
            ii(0x19_3d47, 2);  mov(di, si);                            /* mov di, si */
            ii(0x19_3d49, 2);  mov(ax, memw[ds, si]);                  /* mov ax, [si] */
            ii(0x19_3d4b, 2);  test(al, 1);                            /* test al, 0x1 */
            ii(0x19_3d4d, 2);  if(jz(0x19_3d52, 3)) goto l_0x19_3d52;  /* jz 0x3d52 */
            ii(0x19_3d4f, 2);  sub(cx, ax);                            /* sub cx, ax */
            ii(0x19_3d51, 1);  dec(cx);                                /* dec cx */
        l_0x19_3d52:
            ii(0x19_3d52, 1);  inc(cx);                                /* inc cx */
            ii(0x19_3d53, 1);  inc(cx);                                /* inc cx */
            ii(0x19_3d54, 3);  mov(si, memw[ds, bx + 4]);              /* mov si, [bx+0x4] */
            ii(0x19_3d57, 2);  or(si, si);                             /* or si, si */
            ii(0x19_3d59, 2);  if(jz(0x19_3daa, 0x4f)) goto l_0x19_3daa;/* jz 0x3daa */
            ii(0x19_3d5b, 2);  add(cx, si);                            /* add cx, si */
            ii(0x19_3d5d, 2);  if(jae(0x19_3d68, 9)) goto l_0x19_3d68; /* jae 0x3d68 */
            ii(0x19_3d5f, 2);  xor(ax, ax);                            /* xor ax, ax */
            ii(0x19_3d61, 3);  mov(dx, 0xfff0);                        /* mov dx, 0xfff0 */
            ii(0x19_3d64, 2);  if(jcxz(0x19_3d99, 0x33)) goto l_0x19_3d99;/* jcxz 0x3d99 */
            ii(0x19_3d66, 2);  jmp(0x19_3daa, 0x42); goto l_0x19_3daa; /* jmp 0x3daa */
        l_0x19_3d68:
            ii(0x19_3d68, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_3d6b, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_3d6d, 4);  mov(ax, memw[es, 0x3f64]);              /* mov ax, [es:0x3f64] */
            ii(0x19_3d71, 3);  cmp(ax, 0x2000);                        /* cmp ax, 0x2000 */
            ii(0x19_3d74, 2);  if(jz(0x19_3d8c, 0x16)) goto l_0x19_3d8c;/* jz 0x3d8c */
            ii(0x19_3d76, 3);  mov(dx, 0x8000);                        /* mov dx, 0x8000 */
        l_0x19_3d79:
            ii(0x19_3d79, 2);  cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x19_3d7b, 2);  if(jb(0x19_3d83, 6)) goto l_0x19_3d83;  /* jb 0x3d83 */
            ii(0x19_3d7d, 2);  shr(dx, 1);                             /* shr dx, 1 */
            ii(0x19_3d7f, 2);  if(jnz(0x19_3d79, -8)) goto l_0x19_3d79;/* jnz 0x3d79 */
            ii(0x19_3d81, 2);  jmp(0x19_3da5, 0x22); goto l_0x19_3da5; /* jmp 0x3da5 */
        l_0x19_3d83:
            ii(0x19_3d83, 3);  cmp(dx, 8);                             /* cmp dx, 0x8 */
            ii(0x19_3d86, 2);  if(jb(0x19_3da5, 0x1d)) goto l_0x19_3da5;/* jb 0x3da5 */
            ii(0x19_3d88, 2);  shl(dx, 1);                             /* shl dx, 1 */
            ii(0x19_3d8a, 2);  mov(ax, dx);                            /* mov ax, dx */
        l_0x19_3d8c:
            ii(0x19_3d8c, 1);  dec(ax);                                /* dec ax */
            ii(0x19_3d8d, 2);  mov(dx, ax);                            /* mov dx, ax */
            ii(0x19_3d8f, 2);  add(ax, cx);                            /* add ax, cx */
            ii(0x19_3d91, 2);  if(jae(0x19_3d95, 2)) goto l_0x19_3d95; /* jae 0x3d95 */
            ii(0x19_3d93, 2);  xor(ax, ax);                            /* xor ax, ax */
        l_0x19_3d95:
            ii(0x19_3d95, 2);  not(dx);                                /* not dx */
            ii(0x19_3d97, 2);  and(ax, dx);                            /* and ax, dx */
        l_0x19_3d99:
            ii(0x19_3d99, 1);  push(dx);                               /* push dx */
            ii(0x19_3d9a, 3);  call(0x19_3dcb, 0x2e);                  /* call 0x3dcb */
            ii(0x19_3d9d, 1);  pop(dx);                                /* pop dx */
            ii(0x19_3d9e, 2);  if(jae(0x19_3dad, 0xd)) goto l_0x19_3dad;/* jae 0x3dad */
            ii(0x19_3da0, 3);  cmp(dx, -0x10 /* 0xf0 */);              /* cmp dx, 0xfff0 */
            ii(0x19_3da3, 2);  if(jz(0x19_3daa, 5)) goto l_0x19_3daa;  /* jz 0x3daa */
        l_0x19_3da5:
            ii(0x19_3da5, 3);  mov(ax, 0x10);                          /* mov ax, 0x10 */
            ii(0x19_3da8, 2);  jmp(0x19_3d8c, -0x1e); goto l_0x19_3d8c;/* jmp 0x3d8c */
        l_0x19_3daa:
            ii(0x19_3daa, 1);  stc();                                  /* stc */
            ii(0x19_3dab, 2);  jmp(0x19_3dc8, 0x1b); goto l_0x19_3dc8; /* jmp 0x3dc8 */
        l_0x19_3dad:
            ii(0x19_3dad, 2);  mov(dx, ax);                            /* mov dx, ax */
            ii(0x19_3daf, 3);  sub(dx, memw[ds, bx + 4]);              /* sub dx, [bx+0x4] */
            ii(0x19_3db2, 3);  mov(memw[ds, bx + 4], ax);              /* mov [bx+0x4], ax */
            ii(0x19_3db5, 3);  mov(memw[ds, bx + 8], di);              /* mov [bx+0x8], di */
            ii(0x19_3db8, 3);  mov(si, memw[ds, bx + 10]);             /* mov si, [bx+0xa] */
            ii(0x19_3dbb, 1);  dec(dx);                                /* dec dx */
            ii(0x19_3dbc, 2);  mov(memw[ds, si], dx);                  /* mov [si], dx */
            ii(0x19_3dbe, 1);  inc(dx);                                /* inc dx */
            ii(0x19_3dbf, 2);  add(si, dx);                            /* add si, dx */
            ii(0x19_3dc1, 4);  mov(memw[ds, si], 0xfffe);              /* mov word [si], 0xfffe */
            ii(0x19_3dc5, 3);  mov(memw[ds, bx + 10], si);             /* mov [bx+0xa], si */
        l_0x19_3dc8:
            ii(0x19_3dc8, 1);  pop(di);                                /* pop di */
            ii(0x19_3dc9, 1);  pop(cx);                                /* pop cx */
            ii(0x19_3dca, 1);  ret();                                  /* ret */
        }
    }
}

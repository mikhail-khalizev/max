using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1b15-f36addb")]
        public void Method_0019_1b15()
        {
            ii(0x19_1b15, 4);  enter(0xa, 0);                          /* enter 0xa, 0x0 */
            ii(0x19_1b19, 1);  push(ds);                               /* push ds */
            ii(0x19_1b1a, 3);  mov(ax, 0xa8);                          /* mov ax, 0xa8 */
            ii(0x19_1b1d, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x19_1b1f, 5);  mov(memw[ss, bp - 6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x19_1b24, 5);  mov(memw[ss, bp - 4], 0x392c);          /* mov word [bp-0x4], 0x392c */
            ii(0x19_1b29, 3);  mov(memw[ss, bp - 2], ds);              /* mov [bp-0x2], ds */
            ii(0x19_1b2c, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_1b2f, 1);  inc(ax);                                /* inc ax */
            ii(0x19_1b30, 2);  if(jz(0x19_1b6f, 0x3d)) goto l_0x19_1b6f;/* jz 0x1b6f */
            ii(0x19_1b32, 1);  dec(ax);                                /* dec ax */
            ii(0x19_1b33, 2);  if(jz(0x19_1b6f, 0x3a)) goto l_0x19_1b6f;/* jz 0x1b6f */
            ii(0x19_1b35, 1);  dec(ax);                                /* dec ax */
            ii(0x19_1b36, 2);  if(jz(0x19_1b4b, 0x13)) goto l_0x19_1b4b;/* jz 0x1b4b */
            ii(0x19_1b38, 1);  dec(ax);                                /* dec ax */
            ii(0x19_1b39, 2);  if(jnz(0x19_1b3e, 3)) goto l_0x19_1b3e; /* jnz 0x1b3e */
            ii(0x19_1b3b, 3);  jmp(0x19_1bd6, 0x98); goto l_0x19_1bd6; /* jmp 0x1bd6 */
        l_0x19_1b3e:
            ii(0x19_1b3e, 1);  dec(ax);                                /* dec ax */
            ii(0x19_1b3f, 2);  if(jnz(0x19_1b44, 3)) goto l_0x19_1b44; /* jnz 0x1b44 */
            ii(0x19_1b41, 3);  jmp(0x19_1bee, 0xaa); goto l_0x19_1bee; /* jmp 0x1bee */
        l_0x19_1b44:
            ii(0x19_1b44, 5);  mov(memw[ss, bp + 10], 0);              /* mov word [bp+0xa], 0x0 */
            ii(0x19_1b49, 2);  jmp(0x19_1b6f, 0x24); goto l_0x19_1b6f; /* jmp 0x1b6f */
        l_0x19_1b4b:
            ii(0x19_1b4b, 4);  cmp(memw[ss, bp + 12], 0);              /* cmp word [bp+0xc], 0x0 */
            ii(0x19_1b4f, 2);  if(jz(0x19_1b6f, 0x1e)) goto l_0x19_1b6f;/* jz 0x1b6f */
            ii(0x19_1b51, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_1b54, 4);  push(memw[ds, 0x3a72]);                 /* push word [0x3a72] */
            ii(0x19_1b58, 4);  push(memw[ds, 0x3a70]);                 /* push word [0x3a70] */
            ii(0x19_1b5c, 1);  push(ds);                               /* push ds */
            ii(0x19_1b5d, 3);  push(0x3a90);                           /* push 0x3a90 */
        l_0x19_1b60:
            ii(0x19_1b60, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_1b63, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_1b66, 3);  call(0x19_1e1c, 0x2b3);                 /* call 0x1e1c */
            ii(0x19_1b69, 3);  add(sp, 0xe);                           /* add sp, 0xe */
            ii(0x19_1b6c, 3);  add(memw[ss, bp - 4], ax);              /* add [bp-0x4], ax */
        l_0x19_1b6f:
            ii(0x19_1b6f, 3);  les(bx, memw[ss, bp + 18]);             /* les bx, [bp+0x12] */
            ii(0x19_1b72, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_1b76, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_1b79, 3);  push(memw[ss, bp + 16]);                /* push word [bp+0x10] */
            ii(0x19_1b7c, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_1b7f, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_1b82, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_1b85, 1);  push(cs);                               /* push cs */
            ii(0x19_1b86, 3);  call(0x19_1e37, 0x2ae);                 /* call 0x1e37 */
            ii(0x19_1b89, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x19_1b8c, 3);  mov(ax, memw[ds, 0x3a76]);              /* mov ax, [0x3a76] */
            ii(0x19_1b8f, 4);  or(ax, memw[ds, 0x3a74]);               /* or ax, [0x3a74] */
            ii(0x19_1b93, 2);  if(jz(0x19_1bca, 0x35)) goto l_0x19_1bca;/* jz 0x1bca */
            ii(0x19_1b95, 3);  les(bx, memw[ss, bp + 18]);             /* les bx, [bp+0x12] */
            ii(0x19_1b98, 4);  push(memw[es, bx + 2]);                 /* push word [es:bx+0x2] */
            ii(0x19_1b9c, 3);  push(memw[es, bx]);                     /* push word [es:bx] */
            ii(0x19_1b9f, 3);  push(memw[ss, bp + 16]);                /* push word [bp+0x10] */
            ii(0x19_1ba2, 3);  push(memw[ss, bp + 14]);                /* push word [bp+0xe] */
            ii(0x19_1ba5, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_1ba8, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_1bab, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_1bae, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_1bb1, 4);  push(memw[ds, 0x3a72]);                 /* push word [0x3a72] */
            ii(0x19_1bb5, 4);  push(memw[ds, 0x3a70]);                 /* push word [0x3a70] */
            ii(0x19_1bb9, 3);  push(0x100);                            /* push 0x100 */
            ii(0x19_1bbc, 1);  push(ds);                               /* push ds */
            ii(0x19_1bbd, 3);  push(0x392c);                           /* push 0x392c */
            ii(0x19_1bc0, 4);  call_far_ind(memw[ds, 0x3a74]);         /* call far word [0x3a74] */
            ii(0x19_1bc4, 3);  add(sp, 0x1a);                          /* add sp, 0x1a */
            ii(0x19_1bc7, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
        l_0x19_1bca:
            ii(0x19_1bca, 4);  cmp(memw[ss, bp - 6], 0);               /* cmp word [bp-0x6], 0x0 */
            ii(0x19_1bce, 2);  if(jz(0x19_1c09, 0x39)) goto l_0x19_1c09;/* jz 0x1c09 */
            ii(0x19_1bd0, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x19_1bd3, 1);  pop(ds);                                /* pop ds */
            ii(0x19_1bd4, 1);  leave();                                /* leave */
            ii(0x19_1bd5, 1);  retf(); return;                         /* retf */
        l_0x19_1bd6:
            ii(0x19_1bd6, 4);  cmp(memw[ss, bp + 12], 0);              /* cmp word [bp+0xc], 0x0 */
            ii(0x19_1bda, 2);  if(jz(0x19_1b6f, -0x6d)) goto l_0x19_1b6f;/* jz 0x1b6f */
            ii(0x19_1bdc, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_1bdf, 4);  push(memw[ds, 0x3a72]);                 /* push word [0x3a72] */
            ii(0x19_1be3, 4);  push(memw[ds, 0x3a70]);                 /* push word [0x3a70] */
            ii(0x19_1be7, 1);  push(ds);                               /* push ds */
            ii(0x19_1be8, 3);  push(0x3aa2);                           /* push 0x3aa2 */
            ii(0x19_1beb, 3);  jmp(0x19_1b60, -0x8e); goto l_0x19_1b60;/* jmp 0x1b60 */
        l_0x19_1bee:
            ii(0x19_1bee, 4);  cmp(memw[ss, bp + 12], 0);              /* cmp word [bp+0xc], 0x0 */
            ii(0x19_1bf2, 2);  if(jnz(0x19_1bf7, 3)) goto l_0x19_1bf7; /* jnz 0x1bf7 */
            ii(0x19_1bf4, 3);  jmp(0x19_1b6f, -0x88); goto l_0x19_1b6f;/* jmp 0x1b6f */
        l_0x19_1bf7:
            ii(0x19_1bf7, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_1bfa, 4);  push(memw[ds, 0x3a72]);                 /* push word [0x3a72] */
            ii(0x19_1bfe, 4);  push(memw[ds, 0x3a70]);                 /* push word [0x3a70] */
            ii(0x19_1c02, 1);  push(ds);                               /* push ds */
            ii(0x19_1c03, 3);  push(0x3ab2);                           /* push 0x3ab2 */
            ii(0x19_1c06, 3);  jmp(0x19_1b60, -0xa9); goto l_0x19_1b60;/* jmp 0x1b60 */
        l_0x19_1c09:
            ii(0x19_1c09, 3);  mov(bx, memw[ss, bp + 10]);             /* mov bx, [bp+0xa] */
            ii(0x19_1c0c, 2);  shl(bx, 1);                             /* shl bx, 1 */
            ii(0x19_1c0e, 4);  mov(bx, memw[ds, bx + 0x3a3a]);         /* mov bx, [bx+0x3a3a] */
            ii(0x19_1c12, 2);  shl(bx, 1);                             /* shl bx, 1 */
            ii(0x19_1c14, 4);  mov(ax, memw[ds, bx + 0x3a2c]);         /* mov ax, [bx+0x3a2c] */
            ii(0x19_1c18, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_1c1b, 5);  mov(memw[ss, bp - 10], 0x392c);         /* mov word [bp-0xa], 0x392c */
            ii(0x19_1c20, 2);  jmp(0x19_1c2c, 0xa); goto l_0x19_1c2c;  /* jmp 0x1c2c */
        l_0x19_1c22:
            ii(0x19_1c22, 2);  mov(al, memb[ds, bx]);                  /* mov al, [bx] */
            ii(0x19_1c24, 1);  push(ax);                               /* push ax */
            ii(0x19_1c25, 3);  call_abs(memw[ss, bp - 8]);             /* call word [bp-0x8] */
            ii(0x19_1c28, 1);  pop(bx);                                /* pop bx */
            ii(0x19_1c29, 3);  inc(memw[ss, bp - 10]);                 /* inc word [bp-0xa] */
        l_0x19_1c2c:
            ii(0x19_1c2c, 3);  mov(bx, memw[ss, bp - 10]);             /* mov bx, [bp-0xa] */
            ii(0x19_1c2f, 3);  cmp(memb[ds, bx], 0);                   /* cmp byte [bx], 0x0 */
            ii(0x19_1c32, 2);  if(jnz(0x19_1c22, -0x12)) goto l_0x19_1c22;/* jnz 0x1c22 */
            ii(0x19_1c34, 2);  mov(ax, bx);                            /* mov ax, bx */
            ii(0x19_1c36, 3);  sub(ax, 0x392c);                        /* sub ax, 0x392c */
            ii(0x19_1c39, 1);  pop(ds);                                /* pop ds */
            ii(0x19_1c3a, 1);  leave();                                /* leave */
            ii(0x19_1c3b, 1);  retf();                                 /* retf */
        }
    }
}

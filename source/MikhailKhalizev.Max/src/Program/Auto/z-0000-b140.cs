using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb140-96287ba9")]
        public void Method_0000_b140()
        {
            ii(0xb140, 1);  push(dx);                                  /* push dx */
            ii(0xb141, 4);  push(memw[ds, 0xecc]);                     /* push word [0xecc] */
            ii(0xb145, 3);  call(0xb124, -0x24);                       /* call 0xb124 */
            ii(0xb148, 2);  mov(si, bx);                               /* mov si, bx */
            ii(0xb14a, 2);  mov(di, dx);                               /* mov di, dx */
            ii(0xb14c, 3);  call(0xa274, -0xedb);                      /* call 0xa274 */
            ii(0xb14f, 1);  pop(cx);                                   /* pop cx */
            ii(0xb150, 1);  pop(dx);                                   /* pop dx */
            ii(0xb151, 4);  xchg(memw[ds, 0xecc], cx);                 /* xchg [0xecc], cx */
            ii(0xb155, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0xb157, 2);  if(jz_func(0xb19b, 0x42)) return;          /* jz 0xb19b */
            ii(0xb159, 1);  push(dx);                                  /* push dx */
            ii(0xb15a, 1);  push(cx);                                  /* push cx */
            ii(0xb15b, 3);  call(0xb124, -0x3a);                       /* call 0xb124 */
            ii(0xb15e, 1);  pop(cx);                                   /* pop cx */
            ii(0xb15f, 1);  pop(ax);                                   /* pop ax */
            ii(0xb160, 2);  cmp(di, dx);                               /* cmp di, dx */
            ii(0xb162, 1);  xchg(dx, ax);                              /* xchg dx, ax */
            ii(0xb163, 2);  if(jnz_func(0xb19c, 0x37)) return;         /* jnz 0xb19c */
            ii(0xb165, 2);  cmp(si, bx);                               /* cmp si, bx */
            ii(0xb167, 2);  if(jnz_func(0xb19c, 0x33)) return;         /* jnz 0xb19c */
            ii(0xb169, 4);  add(dx, memw[ds, 0xece]);                  /* add dx, [0xece] */
            ii(0xb16d, 5);  cmp(memb[ds, 0xdff], 0);                   /* cmp byte [0xdff], 0x0 */
            ii(0xb172, 4);  if(jnz(0xb181, 0xb)) goto l_0xb181;        /* jnz 0xb181 */
            ii(0xb176, 4);  cmp(dx, 0x3000);                           /* cmp dx, 0x3000 */
            ii(0xb17a, 4);  if(jbe(0xb181, 3)) goto l_0xb181;          /* jbe 0xb181 */
            ii(0xb17e, 3);  mov(dx, 0x3000);                           /* mov dx, 0x3000 */
        l_0xb181:
            ii(0xb181, 3);  mov(ax, memw[ds, 0xeca]);                  /* mov ax, [0xeca] */
            ii(0xb184, 2);  mov(bx, ax);                               /* mov bx, ax */
            ii(0xb186, 2);  add(ax, cx);                               /* add ax, cx */
            ii(0xb188, 2);  and(al, 0xfc);                             /* and al, 0xfc */
            ii(0xb18a, 3);  add(bx, 3);                                /* add bx, 0x3 */
            ii(0xb18d, 3);  and(bl, 0xfc);                             /* and bl, 0xfc */
            ii(0xb190, 2);  sub(ax, bx);                               /* sub ax, bx */
            ii(0xb192, 4);  mov(memw[ds, 0xeca], bx);                  /* mov [0xeca], bx */
            ii(0xb196, 3);  mov(memw[ds, 0xdfa], ax);                  /* mov [0xdfa], ax */
            ii(0xb199, 2);  or(ax, ax);                                /* or ax, ax */
        }
    }
}

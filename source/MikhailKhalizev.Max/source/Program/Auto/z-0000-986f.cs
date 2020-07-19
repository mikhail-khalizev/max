using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x986f-5825030e")]
        public void Method_0000_986f()
        {
            ii(0x986f, 4);  mov(sp, memw[ds, 0xcdc]);                  /* mov sp, [0xcdc] */
            ii(0x9873, 5);  smsw(memw[ds, 0xf88]);                     /* smsw word [0xf88] */
            ii(0x9878, 3);  call(0x6e34, -0x2a47);                     /* call 0x6e34 */
            ii(0x987b, 3);  call(0x41fd, -0x5681);                     /* call 0x41fd */
            ii(0x987e, 4);  mov(memb[ds, 0x35], cl);                   /* mov [0x35], cl */
            ii(0x9882, 4);  mov(memb[ds, 0x37], cl);                   /* mov [0x37], cl */
            ii(0x9886, 3);  call(0x6593, -0x32f6);                     /* call 0x6593 */
            ii(0x9889, 5);  cmp(memb[ds, 0x2e], 0);                    /* cmp byte [0x2e], 0x0 */
            ii(0x988e, 2);  if(jz(0x98b3, 0x23)) goto l_0x98b3;        /* jz 0x98b3 */
            ii(0x9890, 3);  call(0x4f8a, -0x4909);                     /* call 0x4f8a */
            ii(0x9893, 5);  cmp(memb[ds, 0x2e], 0xa);                  /* cmp byte [0x2e], 0xa */
            ii(0x9898, 2);  if(jnz(0x989d, 3)) goto l_0x989d;          /* jnz 0x989d */
            ii(0x989a, 3);  call(0x9aa7, 0x20a);                       /* call 0x9aa7 */
        l_0x989d:
            ii(0x989d, 5);  cmp(memb[ds, 0x2e], 9);                    /* cmp byte [0x2e], 0x9 */
            ii(0x98a2, 2);  if(jnz(0x98a7, 3)) goto l_0x98a7;          /* jnz 0x98a7 */
            ii(0x98a4, 3);  call(0x9a0d, 0x166);                       /* call 0x9a0d */
        l_0x98a7:
            ii(0x98a7, 3);  call(0x375c, -0x614e);                     /* call 0x375c */
            ii(0x98aa, 3);  call(0x9b96, 0x2e9);                       /* call 0x9b96 */
            ii(0x98ad, 6);  mov(memw[ds, 0xac2], 0x32);                /* mov word [0xac2], 0x32 */
        l_0x98b3:
            ii(0x98b3, 3);  push(0xf8a);                               /* push 0xf8a */
            ii(0x98b6, 3);  call(0x4870, -0x5049);                     /* call 0x4870 */
            ii(0x98b9, 1);  pop(cx);                                   /* pop cx */
            ii(0x98ba, 4);  mov(es, memw[ds, 0xcec]);                  /* mov es, [0xcec] */
            ii(0x98be, 3);  mov(bx, 0xa);                              /* mov bx, 0xa */
            ii(0x98c1, 3);  mov(ax, memw[es, bx]);                     /* mov ax, [es:bx] */
            ii(0x98c4, 3);  mov(memw[ds, 0x10c2], ax);                 /* mov [0x10c2], ax */
            ii(0x98c7, 4);  mov(ax, memw[es, bx + 2]);                 /* mov ax, [es:bx+0x2] */
            ii(0x98cb, 3);  mov(memw[ds, 0x10c4], ax);                 /* mov [0x10c4], ax */
            ii(0x98ce, 4);  mov(memw[ds, 0xf50], sp);                  /* mov [0xf50], sp */
            ii(0x98d2, 5);  cmp(memb[ds, 0x2e], 0);                    /* cmp byte [0x2e], 0x0 */
            ii(0x98d7, 2);  if(jz(0x98e5, 0xc)) goto l_0x98e5;         /* jz 0x98e5 */
            ii(0x98d9, 5);  mov(memw[es, bx], 0x10);                   /* mov word [es:bx], 0x10 */
            ii(0x98de, 4);  mov(memw[es, bx + 2], cs);                 /* mov [es:bx+0x2], cs */
            ii(0x98e2, 3);  if(jmp_func(0x3841, -0x60a4)) return;      /* jmp 0x3841 */
        l_0x98e5:
            ii(0x98e5, 3);  call(0xa880, 0xf98);                       /* call 0xa880 */
        }
    }
}

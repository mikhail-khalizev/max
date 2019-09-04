using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e958-4b85e50e")]
        public void Method_0018_e958()
        {
            ii(0x18_e958, 5);  cmp(memw[ds, 0x4d76], 0);               /* cmp word [0x4d76], 0x0 */
            ii(0x18_e95d, 2);  if(jnz(0x18_e9ac, 0x4d)) goto l_0x18_e9ac;/* jnz 0xe9ac */
            ii(0x18_e95f, 1);  push(ds);                               /* push ds */
            ii(0x18_e960, 2);  push(0x20);                             /* push 0x20 */
            ii(0x18_e962, 1);  pop(ds);                                /* pop ds */
            ii(0x18_e963, 2);  mov(cl, 0);                             /* mov cl, 0x0 */
            ii(0x18_e965, 4);  xchg(memb[ds, 0x980], cl);              /* xchg [0x980], cl */
            ii(0x18_e969, 2);  mov(ah, 0x48);                          /* mov ah, 0x48 */
            ii(0x18_e96b, 3);  mov(bx, 0x400);                         /* mov bx, 0x400 */
            ii(0x18_e96e, 3);  call(0x18_e450, -0x521);                /* call 0xe450 */
            ii(0x18_e971, 4);  mov(memb[ds, 0x980], cl);               /* mov [0x980], cl */
            ii(0x18_e975, 1);  push(ds);                               /* push ds */
            ii(0x18_e976, 1);  pop(es);                                /* pop es */
            ii(0x18_e977, 1);  pop(ds);                                /* pop ds */
            ii(0x18_e978, 2);  if(jb(0x18_e9ad, 0x33)) goto l_0x18_e9ad;/* jb 0xe9ad */
            ii(0x18_e97a, 2);  mov(si, ax);                            /* mov si, ax */
            ii(0x18_e97c, 5);  mov(di, memw[es, 0xc14]);               /* mov di, [es:0xc14] */
            ii(0x18_e981, 3);  add(di, 0x10);                          /* add di, 0x10 */
            ii(0x18_e984, 4);  mov(memw[ds, 0x4d76], di);              /* mov [0x4d76], di */
            ii(0x18_e988, 2);  push(8);                                /* push 0x8 */
            ii(0x18_e98a, 1);  pop(es);                                /* pop es */
            ii(0x18_e98b, 3);  mov(cx, 4);                             /* mov cx, 0x4 */
            ii(0x18_e98e, 3);  rep(() => movsw(es));                   /* es rep movsw */
            ii(0x18_e991, 5);  or(memb[es, di - 2], 0x40);             /* or byte [es:di-0x2], 0x40 */
            ii(0x18_e996, 2);  mov(cl, 8);                             /* mov cl, 0x8 */
            ii(0x18_e998, 2);  sub(si, cx);                            /* sub si, cx */
            ii(0x18_e99a, 3);  rep(() => movsb(es));                   /* es rep movsb */
            ii(0x18_e99d, 4);  mov(memb[es, si - 3], cl);              /* mov [es:si-0x3], cl */
            ii(0x18_e9a1, 2);  push(0x50);                             /* push 0x50 */
            ii(0x18_e9a3, 1);  pop(es);                                /* pop es */
            ii(0x18_e9a4, 3);  shr(di, 3);                             /* shr di, 0x3 */
            ii(0x18_e9a7, 5);  mov(memb[es, di - 1], 0xe1);            /* mov byte [es:di-0x1], 0xe1 */
        l_0x18_e9ac:
            ii(0x18_e9ac, 1);  ret(); return;                          /* ret */
        l_0x18_e9ad:
            ii(0x18_e9ad, 3);  if(jmp_func(0x18_e062, -0x94e)) return; /* jmp 0xe062 */
        }
    }
}

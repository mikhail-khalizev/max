using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0125-963bf1fe")]
        public void Method_0019_0125()
        {
            ii(0x19_0125, 4);  les(di, memw[ds, 0x122]);               /* les di, [0x122] */
            ii(0x19_0129, 4);  mov(cx, memw[ds, 0x126]);               /* mov cx, [0x126] */
            ii(0x19_012d, 2);  if(jcxz(0x19_016e, 0x3f)) goto l_0x19_016e;/* jcxz 0x16e */
        l_0x19_012f:
            ii(0x19_012f, 4);  cmp(memb[es, di], 0);                   /* cmp byte [es:di], 0x0 */
            ii(0x19_0133, 4);  if(jnz(0x19_013d, 6)) goto l_0x19_013d; /* jnz 0x13d */
            ii(0x19_0137, 4);  mov(memb[es, di], 1);                   /* mov byte [es:di], 0x1 */
            ii(0x19_013b, 1);  clc();                                  /* clc */
            ii(0x19_013c, 1);  ret(); return;                          /* ret */
        l_0x19_013d:
            ii(0x19_013d, 3);  add(di, 8);                             /* add di, 0x8 */
            ii(0x19_0140, 2);  if(loop(0x19_012f, -0x13)) goto l_0x19_012f;/* loop 0x12f */
            ii(0x19_0142, 4);  mov(bx, memw[ds, 0x126]);               /* mov bx, [0x126] */
            ii(0x19_0146, 2);  or(bh, bh);                             /* or bh, bh */
            ii(0x19_0148, 4);  if(jnz(0x19_016e, 0x22)) goto l_0x19_016e;/* jnz 0x16e */
            ii(0x19_014c, 3);  add(bx, 0x20);                          /* add bx, 0x20 */
            ii(0x19_014f, 1);  push(es);                               /* push es */
            ii(0x19_0150, 1);  push(bx);                               /* push bx */
            ii(0x19_0151, 5);  call_far_abs(0x88, 0x293f);             /* call word 0x88:0x293f */
            ii(0x19_0156, 1);  pop(bx);                                /* pop bx */
            ii(0x19_0157, 1);  pop(es);                                /* pop es */
            ii(0x19_0158, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x19_015a, 4);  if(jnz(0x19_016e, 0x10)) goto l_0x19_016e;/* jnz 0x16e */
            ii(0x19_015e, 5);  add(memw[ds, 0x126], 0x20);             /* add word [0x126], 0x20 */
            ii(0x19_0163, 1);  push(di);                               /* push di */
            ii(0x19_0164, 2);  sub(al, al);                            /* sub al, al */
            ii(0x19_0166, 3);  mov(cx, 0x100);                         /* mov cx, 0x100 */
            ii(0x19_0169, 2);  rep(() => stosb());                     /* rep stosb */
            ii(0x19_016b, 1);  pop(di);                                /* pop di */
            ii(0x19_016c, 2);  jmp(0x19_012f, -0x3f); goto l_0x19_012f;/* jmp 0x12f */
        l_0x19_016e:
            ii(0x19_016e, 1);  stc();                                  /* stc */
            ii(0x19_016f, 1);  ret();                                  /* ret */
        }
    }
}

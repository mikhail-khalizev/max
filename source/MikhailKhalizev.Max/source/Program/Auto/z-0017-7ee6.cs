using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_7ee6-11ebb056")]
        public void Method_0017_7ee6()
        {
            ii(0x17_7ee6, 4);  enter(2, 0);                            /* enter 0x2, 0x0 */
            ii(0x17_7eea, 1);  push(si);                               /* push si */
            ii(0x17_7eeb, 1);  push(ds);                               /* push ds */
            ii(0x17_7eec, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_7eef, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_7ef1, 4);  les(bx, memw[ds, 0x4f9c]);              /* les bx, [0x4f9c] */
            ii(0x17_7ef5, 3);  mov(si, memw[ss, bp + 6]);              /* mov si, [bp+0x6] */
            ii(0x17_7ef8, 4);  test(memb[es, bx + si], 0x80);          /* test byte [es:bx+si], 0x80 */
            ii(0x17_7efc, 2);  if(jz(0x17_7f35, 0x37)) goto l_0x17_7f35;/* jz 0x7f35 */
            ii(0x17_7efe, 3);  mov(al, memb[es, bx + si]);             /* mov al, [es:bx+si] */
            ii(0x17_7f01, 2);  mov(cx, ax);                            /* mov cx, ax */
            ii(0x17_7f03, 2);  and(al, 0x7f);                          /* and al, 0x7f */
            ii(0x17_7f05, 3);  mov(memb[ss, bp - 2], al);              /* mov [bp-0x2], al */
            ii(0x17_7f08, 2);  mov(ax, cx);                            /* mov ax, cx */
            ii(0x17_7f0a, 2);  dec(cl);                                /* dec cl */
            ii(0x17_7f0c, 2);  xor(al, cl);                            /* xor al, cl */
            ii(0x17_7f0e, 2);  and(al, 0x7f);                          /* and al, 0x7f */
            ii(0x17_7f10, 3);  xor(memb[es, bx + si], al);             /* xor [es:bx+si], al */
            ii(0x17_7f13, 4);  cmp(memb[ss, bp - 2], 0);               /* cmp byte [bp-0x2], 0x0 */
            ii(0x17_7f17, 2);  if(jnz(0x17_7f35, 0x1c)) goto l_0x17_7f35;/* jnz 0x7f35 */
            ii(0x17_7f19, 4);  les(bx, memw[ds, 0x4f9c]);              /* les bx, [0x4f9c] */
            ii(0x17_7f1d, 4);  and(memb[es, bx + si], 0x7f);           /* and byte [es:bx+si], 0x7f */
            ii(0x17_7f21, 5);  add(memw[ds, 0x1fb8], 1);               /* add word [0x1fb8], 0x1 */
            ii(0x17_7f26, 5);  adc(memw[ds, 0x1fba], 0);               /* adc word [0x1fba], 0x0 */
            ii(0x17_7f2b, 5);  add(memw[ds, 0x1fb0], 1);               /* add word [0x1fb0], 0x1 */
            ii(0x17_7f30, 5);  adc(memw[ds, 0x1fb2], 0);               /* adc word [0x1fb2], 0x0 */
        l_0x17_7f35:
            ii(0x17_7f35, 1);  pop(ds);                                /* pop ds */
            ii(0x17_7f36, 1);  pop(si);                                /* pop si */
            ii(0x17_7f37, 1);  leave();                                /* leave */
            ii(0x17_7f38, 1);  retf();                                 /* retf */
        }
    }
}

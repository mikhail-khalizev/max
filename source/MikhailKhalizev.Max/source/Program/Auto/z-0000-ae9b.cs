using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xae9b-66644528")]
        public void Method_0000_ae9b()
        {
            ii(0xae9b, 1);  pop(cx);                                   /* pop cx */
            ii(0xae9c, 2);  add(ax, cx);                               /* add ax, cx */
            ii(0xae9e, 3);  shr(ax, 4);                                /* shr ax, 0x4 */
            ii(0xaea1, 2);  mov(dx, es);                               /* mov dx, es */
            ii(0xaea3, 2);  add(ax, dx);                               /* add ax, dx */
            ii(0xaea5, 2);  or(al, al);                                /* or al, al */
            ii(0xaea7, 4);  if(jz(0xaeb0, 5)) goto l_0xaeb0;           /* jz 0xaeb0 */
            ii(0xaeab, 2);  push(0x18);                                /* push 0x18 */
            ii(0xaead, 3);  call(0x589d, -0x5613);                     /* call 0x589d */
        l_0xaeb0:
            ii(0xaeb0, 3);  mov(memw[ds, 0xaa], ax);                   /* mov [0xaa], ax */
            ii(0xaeb3, 3);  mov(memw[ds, 0xdf4], ax);                  /* mov [0xdf4], ax */
            ii(0xaeb6, 2);  mov(es, ax);                               /* mov es, ax */
            ii(0xaeb8, 2);  xor(di, di);                               /* xor di, di */
            ii(0xaeba, 1);  pop(cx);                                   /* pop cx */
            ii(0xaebb, 2);  shr(cx, 1);                                /* shr cx, 1 */
            ii(0xaebd, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0xaebf, 2);  rep(() => stosw());                        /* rep stosw */
        }
    }
}

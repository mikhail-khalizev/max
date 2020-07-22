using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3622-5d15e739")]
        public void Method_0000_3622()
        {
            ii(0x3622, 1);  pop(cx);                                   /* pop cx */
            ii(0x3623, 1);  push(ss);                                  /* push ss */
            ii(0x3624, 1);  pop(ds);                                   /* pop ds */
            ii(0x3625, 5);  cmp(memb[ds, 0x2e], 0);                    /* cmp byte [0x2e], 0x0 */
            ii(0x362a, 2);  if(jz(0x3650, 0x24)) goto l_0x3650;        /* jz 0x3650 */
            ii(0x362c, 3);  call(0x3658, 0x29);                        /* call 0x3658 */
            ii(0x362f, 5);  cmp(memb[ds, 0x10ef], 0);                  /* cmp byte [0x10ef], 0x0 */
            ii(0x3634, 2);  if(jz(0x3650, 0x1a)) goto l_0x3650;        /* jz 0x3650 */
            ii(0x3636, 2);  xor(ax, ax);                               /* xor ax, ax */
            ii(0x3638, 4);  sub(al, memb[ds, 0x37]);                   /* sub al, [0x37] */
            ii(0x363c, 2);  sbb(ah, ah);                               /* sbb ah, ah */
            ii(0x363e, 3);  and(ah, 2);                                /* and ah, 0x2 */
            ii(0x3641, 5);  cmp(memb[ds, 0x2e], 2);                    /* cmp byte [0x2e], 0x2 */
            ii(0x3646, 2);  if(jz(0x3653, 0xb)) goto l_0x3653;         /* jz 0x3653 */
            ii(0x3648, 3);  or(ah, 0xdd);                              /* or ah, 0xdd */
            ii(0x364b, 1);  cli();                                     /* cli */
            ii(0x364c, 3);  call(0x41c1, 0xb72);                       /* call 0x41c1 */
            ii(0x364f, 1);  sti();                                     /* sti */
        l_0x3650:
            ii(0x3650, 3);  call(0x5a20, 0x23cd);                      /* call 0x5a20 */
        l_0x3653:
            ii(0x3653, 3);  call(0x41b3, 0xb5d);                       /* call 0x41b3 */
            ii(0x3656, 2);  jmp(0x3650, -8); goto l_0x3650;            /* jmp 0x3650 */
        }
    }
}

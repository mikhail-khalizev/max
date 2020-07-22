using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_29b2-55e7f0ee")]
        public void Method_0019_29b2()
        {
            ii(0x19_29b2, 4);  mov(cx, memw[ds, 0x3f7a]);              /* mov cx, [0x3f7a] */
            ii(0x19_29b6, 2);  if(jcxz(0x19_29bf, 7)) goto l_0x19_29bf;/* jcxz 0x29bf */
            ii(0x19_29b8, 3);  mov(bx, 2);                             /* mov bx, 0x2 */
            ii(0x19_29bb, 4);  call_far_ind(memw[ds, 0x3f78]);         /* call far word [0x3f78] */
        l_0x19_29bf:
            ii(0x19_29bf, 1);  push(ds);                               /* push ds */
            ii(0x19_29c0, 4);  lds(dx, memw[ds, 0x3c04]);              /* lds dx, [0x3c04] */
            ii(0x19_29c4, 3);  mov(ax, 0x2500);                        /* mov ax, 0x2500 */
            ii(0x19_29c7, 2);  @int(0x21);                             /* int 0x21 */
            ii(0x19_29c9, 1);  pop(ds);                                /* pop ds */
            ii(0x19_29ca, 5);  cmp(memb[ds, 0x3c46], 0);               /* cmp byte [0x3c46], 0x0 */
            ii(0x19_29cf, 2);  if(jz(0x19_29de, 0xd)) goto l_0x19_29de;/* jz 0x29de */
            ii(0x19_29d1, 1);  push(ds);                               /* push ds */
            ii(0x19_29d2, 3);  mov(al, memb[ds, 0x3c47]);              /* mov al, [0x3c47] */
            ii(0x19_29d5, 4);  lds(dx, memw[ds, 0x3c48]);              /* lds dx, [0x3c48] */
            ii(0x19_29d9, 2);  mov(ah, 0x25);                          /* mov ah, 0x25 */
            ii(0x19_29db, 2);  @int(0x21);                             /* int 0x21 */
            ii(0x19_29dd, 1);  pop(ds);                                /* pop ds */
        l_0x19_29de:
            ii(0x19_29de, 1);  ret();                                  /* ret */
        }
    }
}

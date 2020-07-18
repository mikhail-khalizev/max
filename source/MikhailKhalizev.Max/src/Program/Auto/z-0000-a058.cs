using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xa058-9020cdc9")]
        public void Method_0000_a058()
        {
            ii(0xa058, 4);  mov(memw[ds, 0x1586], ds);                 /* mov [0x1586], ds */
            ii(0xa05c, 3);  mov(ax, 0x98);                             /* mov ax, 0x98 */
            ii(0xa05f, 3);  mov(memw[ds, 0x1584], ax);                 /* mov [0x1584], ax */
            ii(0xa062, 6);  mov(memw[ds, 0x158e], 0x20);               /* mov word [0x158e], 0x20 */
            ii(0xa068, 6);  mov(memw[ds, 0x158c], 0x70);               /* mov word [0x158c], 0x70 */
            ii(0xa06e, 6);  mov(memw[ds, 0x158a], 0x1bc7);             /* mov word [0x158a], 0x1bc7 */
            ii(0xa074, 3);  mov(ax, 0x1d50);                           /* mov ax, 0x1d50 */
            ii(0xa077, 3);  sub(ax, 0x1d47);                           /* sub ax, 0x1d47 */
            ii(0xa07a, 3);  mov(memw[ds, 0x1590], ax);                 /* mov [0x1590], ax */
            ii(0xa07d, 2);  mov(ax, ds);                               /* mov ax, ds */
            ii(0xa07f, 4);  movzx(eax, ax);                            /* movzx eax, ax */
            ii(0xa083, 4);  shl(eax, 4);                               /* shl eax, 0x4 */
            ii(0xa087, 3);  mov(bx, 0x98e);                            /* mov bx, 0x98e */
            ii(0xa08a, 4);  movzx(ebx, bx);                            /* movzx ebx, bx */
            ii(0xa08e, 3);  add(eax, ebx);                             /* add eax, ebx */
            ii(0xa091, 4);  mov(memd[ds, 0x1598], eax);                /* mov [0x1598], eax */
            ii(0xa095, 6);  mov(memw[ds, 0x1596], 1);                  /* mov word [0x1596], 0x1 */
            ii(0xa09b, 1);  ret();                                     /* ret */
        }
    }
}

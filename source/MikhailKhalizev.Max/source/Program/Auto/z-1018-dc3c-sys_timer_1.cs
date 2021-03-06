using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_dc3c-30e8d79c")]
        public void /* sys */ sys_timer_1()
        {
            ii(0x1018_dc3c, 1);  push(eax);                            /* push eax */
            ii(0x1018_dc3d, 1);  push(ebx);                            /* push ebx */
            ii(0x1018_dc3e, 2);  mov(al, 0x80);                        /* mov al, 0x80 */
            ii(0x1018_dc40, 2);  outb(0x43, al);                       /* out 0x43, al */
            ii(0x1018_dc42, 2);  inb(al, 0x42);                        /* in al, 0x42 */
            ii(0x1018_dc44, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1018_dc46, 2);  inb(al, 0x42);                        /* in al, 0x42 */
            ii(0x1018_dc48, 2);  mov(ah, al);                          /* mov ah, al */
            ii(0x1018_dc4a, 2);  mov(al, bl);                          /* mov al, bl */
            ii(0x1018_dc4c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1018_dc4e, 7);  mov(bx, memw[ds, 0x1020_9dd0]);       /* mov bx, [0x10209dd0] */
            ii(0x1018_dc55, 6);  mov(memw[ds, 0x1020_9dd0], ax);       /* mov [0x10209dd0], ax */
            ii(0x1018_dc5b, 3);  sub(bx, ax);                          /* sub bx, ax */
            ii(0x1018_dc5e, 6);  add(memd[ds, 0x101b_e420], ebx);      /* add [0x101be420], ebx */
            ii(0x1018_dc64, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1018_dc65, 1);  pop(eax);                             /* pop eax */
            ii(0x1018_dc66, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x85fc-aa51daca")]
        public void Method_0000_85fc()
        {
            ii(0x85fc, 1);  push(bx);                                  /* push bx */
            ii(0x85fd, 2);  mov(bx, ss);                               /* mov bx, ss */
            ii(0x85ff, 3);  and(bl, 0xf8);                             /* and bl, 0xf8 */
            ii(0x8602, 2);  push(8);                                   /* push 0x8 */
            ii(0x8604, 1);  pop(es);                                   /* pop es */
            ii(0x8605, 3);  mov(ax, 0xffff);                           /* mov ax, 0xffff */
            ii(0x8608, 1);  cli();                                     /* cli */
            ii(0x8609, 3);  xchg(memw[es, bx], ax);                    /* xchg [es:bx], ax */
            ii(0x860c, 2);  mov(ss, bx);                               /* mov ss, bx */
            ii(0x860e, 3);  xchg(memw[es, bx], ax);                    /* xchg [es:bx], ax */
            ii(0x8611, 1);  pop(bx);                                   /* pop bx */
            ii(0x8612, 2);  if(jmp_func(0x861b, 7)) return;            /* jmp 0x861b */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("21246edf-eec1-4c24-8552-e857752ce5ad")]
        public void Method_1028_9171()
        {
            ii(0x1028_9171, 5); calld(0x1028_92c9, 0x153);              /* call 0x102892c9 */
            ii(0x1028_9176, 4); cmp(ax, 0);                             /* cmp ax, 0x0 */
            ii(0x1028_917a, 6); if(jnzd(0x1028_9185, 0x5)) goto l_0x1028_9185; /* jnz 0x10289185 */
            ii(0x1028_9180, 2); jmpd(0x1028_91bc, 0x3a); goto l_0x1028_91bc; /* jmp 0x102891bc */
        //    ii(0x1028_9182, 1); nop();                                  /* nop */
        //    ii(0x1028_9183, 1); nop();                                  /* nop */
        //    ii(0x1028_9184, 1); nop();                                  /* nop */
        l_0x1028_9185:
            ii(0x1028_9185, 6); mov(memw_a32[ds, 0x12d], ax);           /* mov [0x12d], ax */
            ii(0x1028_918b, 7); mov(dx, memw_a32[ds, 0x12d]);           /* mov dx, [0x12d] */
            ii(0x1028_9192, 4); add(dx, 0x4);                           /* add dx, 0x4 */
            ii(0x1028_9196, 2); mov(al, 0x3f);                          /* mov al, 0x3f */
            ii(0x1028_9198, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9199, 2); inc(dx);                                /* inc dx */
            ii(0x1028_919b, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_919c, 2); pushw(ax);                              /* push ax */
            ii(0x1028_919e, 2); mov(al, 0xc0);                          /* mov al, 0xc0 */
            ii(0x1028_91a0, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_91a1, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_91a2, 2); cmp(al, -0x40 /* 0xc0 */);              /* cmp al, 0xc0 */
            ii(0x1028_91a4, 2); popw(ax);                               /* pop ax */
            ii(0x1028_91a6, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_91a7, 6); if(jzd(0x1028_91b6, 0x9)) goto l_0x1028_91b6; /* jz 0x102891b6 */
            ii(0x1028_91ad, 4); mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1028_91b1, 2); jmpd(0x1028_91bc, 0x9); goto l_0x1028_91bc; /* jmp 0x102891bc */
        //    ii(0x1028_91b3, 1); nop();                                  /* nop */
        //    ii(0x1028_91b4, 1); nop();                                  /* nop */
        //    ii(0x1028_91b5, 1); nop();                                  /* nop */
        l_0x1028_91b6:
            ii(0x1028_91b6, 6); mov(ax, memw_a32[ds, 0x12d]);           /* mov ax, [0x12d] */
        l_0x1028_91bc:
            ii(0x1028_91bc, 1); retd(); return;                         /* ret */
        }
    }
}

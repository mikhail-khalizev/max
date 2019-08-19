using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_92c9-534f141b")]
        public void Method_1028_92c9()
        {
            ii(0x1028_92c9, 5); mov(ebx, 0x125);                        /* mov ebx, 0x125 */
            ii(0x1028_92ce, 5); mov(ecx, 0x4);                          /* mov ecx, 0x4 */
        l_0x1028_92d3:
            ii(0x1028_92d3, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1028_92d6, 4); add(dx, 0x4);                           /* add dx, 0x4 */
            ii(0x1028_92da, 2); mov(al, 0x22);                          /* mov al, 0x22 */
            ii(0x1028_92dc, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_92dd, 2); inc(dx);                                /* inc dx */
            ii(0x1028_92df, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_92e0, 5); mov(memb_a32[ds, 0x131], al);           /* mov [0x131], al */
            ii(0x1028_92e5, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1028_92e7, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_92e8, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1028_92eb, 4); add(dx, 0x4);                           /* add dx, 0x4 */
            ii(0x1028_92ef, 2); mov(al, 0x3f);                          /* mov al, 0x3f */
            ii(0x1028_92f1, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_92f2, 2); inc(dx);                                /* inc dx */
            ii(0x1028_92f4, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_92f5, 2); pushw(ax);                              /* push ax */
            ii(0x1028_92f7, 2); mov(al, 0xc0);                          /* mov al, 0xc0 */
            ii(0x1028_92f9, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_92fa, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_92fb, 2); cmp(al, -0x40 /* 0xc0 */);              /* cmp al, 0xc0 */
            ii(0x1028_92fd, 2); popw(ax);                               /* pop ax */
            ii(0x1028_92ff, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9300, 6); if(jzd(0x1028_9327, 0x21)) goto l_0x1028_9327; /* jz 0x10289327 */
            ii(0x1028_9306, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1028_9309, 4); add(dx, 0x4);                           /* add dx, 0x4 */
            ii(0x1028_930d, 2); mov(al, 0x22);                          /* mov al, 0x22 */
            ii(0x1028_930f, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9310, 2); inc(dx);                                /* inc dx */
            ii(0x1028_9312, 5); mov(al, memb_a32[ds, 0x131]);           /* mov al, [0x131] */
            ii(0x1028_9317, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9318, 3); add(ebx, 0x2);                          /* add ebx, 0x2 */
            ii(0x1028_931b, 1); dec(ecx);                               /* dec ecx */
            ii(0x1028_931c, 2); if(jnzd(0x1028_92d3, -0x4b)) goto l_0x1028_92d3; /* jnz 0x102892d3 */
            ii(0x1028_931e, 4); mov(ax, 0);                             /* mov ax, 0x0 */
            ii(0x1028_9322, 2); jmpd(0x1028_9396, 0x72); goto l_0x1028_9396; /* jmp 0x10289396 */
        //  ii(0x1028_9324, 1); nop();                                  /* nop */
        //  ii(0x1028_9325, 1); nop();                                  /* nop */
        //  ii(0x1028_9326, 1); nop();                                  /* nop */
        l_0x1028_9327:
            ii(0x1028_9327, 3); mov(dx, memw_a32[ds, ebx]);             /* mov dx, [ebx] */
            ii(0x1028_932a, 4); add(dx, 0x4);                           /* add dx, 0x4 */
            ii(0x1028_932e, 2); mov(al, 0x22);                          /* mov al, 0x22 */
            ii(0x1028_9330, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9331, 2); inc(dx);                                /* inc dx */
            ii(0x1028_9333, 5); mov(al, memb_a32[ds, 0x131]);           /* mov al, [0x131] */
            ii(0x1028_9338, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9339, 3); mov(ax, memw_a32[ds, ebx]);             /* mov ax, [ebx] */
            ii(0x1028_933c, 5); calld(0x1028_929d, -0xa4);              /* call 0x1028929d */
            ii(0x1028_9341, 5); calld(0x1028_929d, -0xa9);              /* call 0x1028929d */
            ii(0x1028_9346, 5); calld(0x1028_929d, -0xae);              /* call 0x1028929d */
            ii(0x1028_934b, 5); calld(0x1028_929d, -0xb3);              /* call 0x1028929d */
            ii(0x1028_9350, 5); calld(0x1028_929d, -0xb8);              /* call 0x1028929d */
            ii(0x1028_9355, 5); calld(0x1028_929d, -0xbd);              /* call 0x1028929d */
            ii(0x1028_935a, 5); calld(0x1028_929d, -0xc2);              /* call 0x1028929d */
            ii(0x1028_935f, 5); calld(0x1028_929d, -0xc7);              /* call 0x1028929d */
            ii(0x1028_9364, 5); calld(0x1028_929d, -0xcc);              /* call 0x1028929d */
            ii(0x1028_9369, 5); calld(0x1028_929d, -0xd1);              /* call 0x1028929d */
            ii(0x1028_936e, 5); calld(0x1028_929d, -0xd6);              /* call 0x1028929d */
            ii(0x1028_9373, 5); calld(0x1028_929d, -0xdb);              /* call 0x1028929d */
            ii(0x1028_9378, 5); calld(0x1028_929d, -0xe0);              /* call 0x1028929d */
            ii(0x1028_937d, 5); calld(0x1028_929d, -0xe5);              /* call 0x1028929d */
            ii(0x1028_9382, 5); calld(0x1028_929d, -0xea);              /* call 0x1028929d */
            ii(0x1028_9387, 5); calld(0x1028_929d, -0xef);              /* call 0x1028929d */
            ii(0x1028_938c, 5); calld(0x1028_929d, -0xf4);              /* call 0x1028929d */
            ii(0x1028_9391, 5); calld(0x1028_929d, -0xf9);              /* call 0x1028929d */
        l_0x1028_9396:
            ii(0x1028_9396, 1); retd(); return;                         /* ret */
        }
    }
}

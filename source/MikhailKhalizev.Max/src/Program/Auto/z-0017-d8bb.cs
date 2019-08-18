using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b0206bff-9bd6-42b2-ab5b-e4d985c3de7d")]
        public void Method_0017_d8bb()
        {
            ii(0x17_d8bb, 2); if(jaew(0x17_d8c4, 0x7)) goto l_0x17_d8c4; /* jae 0xd8c4 */
            ii(0x17_d8bd, 3); callw(0x17_d8ce, 0xe);                    /* call 0xd8ce */
            ii(0x17_d8c0, 3); mov(ax, 0xffff);                          /* mov ax, 0xffff */
            ii(0x17_d8c3, 1); cwd();                                    /* cwd */
        l_0x17_d8c4:
            ii(0x17_d8c4, 2); mov(sp, bp);                              /* mov sp, bp */
            ii(0x17_d8c6, 1); popw(bp);                                 /* pop bp */
            ii(0x17_d8c7, 1); retfw(); return;                          /* retf */
        //  ii(0x17_d8c8, 6); Недостижимый (и не декодированный) код.
        //    ii(0x17_d8ce, 3); mov(memb_a16[ds, 0x1c59], al);            /* mov [0x1c59], al */
        //    ii(0x17_d8d1, 2); or(ah, ah);                               /* or ah, ah */
        //    ii(0x17_d8d3, 2); if(jnzw(0x17_d8f7, 0x22)) goto l_0x17_d8f7; /* jnz 0xd8f7 */
        //    ii(0x17_d8d5, 5); cmp(memb_a16[ds, 0x1c56], 0x3);           /* cmp byte [0x1c56], 0x3 */
        //    ii(0x17_d8da, 2); if(jbw(0x17_d8e8, 0xc)) goto l_0x17_d8e8; /* jb 0xd8e8 */
        //    ii(0x17_d8dc, 2); cmp(al, 0x22);                            /* cmp al, 0x22 */
        //    ii(0x17_d8de, 2); if(jaew(0x17_d8ec, 0xc)) goto l_0x17_d8ec; /* jae 0xd8ec */
        //    ii(0x17_d8e0, 2); cmp(al, 0x20);                            /* cmp al, 0x20 */
        //    ii(0x17_d8e2, 2); if(jbw(0x17_d8e8, 0x4)) goto l_0x17_d8e8; /* jb 0xd8e8 */
        //    ii(0x17_d8e4, 2); mov(al, 0x5);                             /* mov al, 0x5 */
        //    ii(0x17_d8e6, 2); jmpw(0x17_d8ee, 0x6); goto l_0x17_d8ee;   /* jmp 0xd8ee */
        l_0x17_d8e8:
            ii(0x17_d8e8, 2); cmp(al, 0x13);                            /* cmp al, 0x13 */
            ii(0x17_d8ea, 2); if(jbew(0x17_d8ee, 0x2)) goto l_0x17_d8ee; /* jbe 0xd8ee */
        l_0x17_d8ec:
            ii(0x17_d8ec, 2); mov(al, 0x13);                            /* mov al, 0x13 */
        l_0x17_d8ee:
            ii(0x17_d8ee, 3); mov(bx, 0x1c8c);                          /* mov bx, 0x1c8c */
            ii(0x17_d8f1, 1); xlatb_a16();                              /* xlatb */
        l_0x17_d8f2:
            ii(0x17_d8f2, 1); cbw();                                    /* cbw */
            ii(0x17_d8f3, 3); mov(memw_a16[ds, 0x1c4e], ax);            /* mov [0x1c4e], ax */
            ii(0x17_d8f6, 1); retw(); return;                           /* ret */
        l_0x17_d8f7:
            ii(0x17_d8f7, 2); mov(al, ah);                              /* mov al, ah */
            ii(0x17_d8f9, 2); jmpw(0x17_d8f2, -0x9); goto l_0x17_d8f2;  /* jmp 0xd8f2 */
        //    ii(0x17_d8fb, 3); add(memb_a16[ds, di - 0x75], dl);         /* add [di-0x75], dl */
        //    ii(0x17_d8fe, 1); inb(al, dx);                              /* in al, dx */
        //    ii(0x17_d8ff, 3); mov(bx, memw_a16[ss, bp + 0x6]);          /* mov bx, [bp+0x6] */
        //    ii(0x17_d902, 4); cmp(bx, memw_a16[ds, 0x1c5b]);            /* cmp bx, [0x1c5b] */
        //    ii(0x17_d906, 2); if(jbw(0x17_d90e, 0x6)) goto l_0x17_d90e; /* jb 0xd90e */
        //    ii(0x17_d908, 3); mov(ax, 0x900);                           /* mov ax, 0x900 */
        //    ii(0x17_d90b, 1); stc();                                    /* stc */
        //    ii(0x17_d90c, 2); jmpw(0x17_d919, 0xb); goto l_0x17_d919;   /* jmp 0xd919 */
        l_0x17_d90e:
            ii(0x17_d90e, 2); mov(ah, 0x3e);                            /* mov ah, 0x3e */
            ii(0x17_d910, 2); @int(0x21);                               /* int 0x21 */
            ii(0x17_d912, 2); if(jbw(0x17_d919, 0x5)) goto l_0x17_d919; /* jb 0xd919 */
            ii(0x17_d914, 5); mov(memb_a16[ds, bx + 0x1c5d], 0);        /* mov byte [bx+0x1c5d], 0x0 */
        l_0x17_d919:
            ii(0x17_d919, 3); if(jmpw_func(0x17_d8a6, -0x76)) return;   /* jmp 0xd8a6 */
        }
    }
}

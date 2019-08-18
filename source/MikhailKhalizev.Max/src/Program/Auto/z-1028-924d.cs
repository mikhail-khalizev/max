using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_924d-8b89e2a5")]
        public void Method_1028_924d()
        {
            ii(0x1028_924d, 6); mov(memw_a32[ds, 0x135], ax);           /* mov [0x135], ax */
            ii(0x1028_9253, 6); mov(memw_a32[ds, 0x793], ax);           /* mov [0x793], ax */
            ii(0x1028_9259, 6); mov(memb_a32[ds, 0x137], ch);           /* mov [0x137], ch */
            ii(0x1028_925f, 6); mov(memb_a32[ds, 0x170], cl);           /* mov [0x170], cl */
            ii(0x1028_9265, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1028_9267, 2); mov(bl, ch);                            /* mov bl, ch */
            ii(0x1028_9269, 2); shl(bl, 0x1);                           /* shl bl, 1 */
            ii(0x1028_926b, 7); cmp(memb_a32[ds, 0x137], 0x3);          /* cmp byte [0x137], 0x3 */
            ii(0x1028_9272, 6); if(jled(0x1028_92a4, 0x2c)) goto l_0x1028_92a4; /* jle 0x102892a4 */
            ii(0x1028_9278, 9); mov(memw_a32[ds, 0x173], 0xd8);         /* mov word [0x173], 0xd8 */
            ii(0x1028_9281, 9); mov(memw_a32[ds, 0x175], 0xd6);         /* mov word [0x175], 0xd6 */
            ii(0x1028_928a, 9); mov(memw_a32[ds, 0x177], 0xd4);         /* mov word [0x177], 0xd4 */
            ii(0x1028_9293, 5); mov(al, memb_a32[ds, 0x137]);           /* mov al, [0x137] */
            ii(0x1028_9298, 2); sub(al, 0x4);                           /* sub al, 0x4 */
            ii(0x1028_929a, 5); mov(memb_a32[ds, 0x179], al);           /* mov [0x179], al */
            ii(0x1028_929f, 2); jmpd(0x1028_92c9, 0x28); goto l_0x1028_92c9; /* jmp 0x102892c9 */
        //    ii(0x1028_92a1, 1); nop();                                  /* nop */
        //    ii(0x1028_92a2, 1); nop();                                  /* nop */
        //    ii(0x1028_92a3, 1); nop();                                  /* nop */
        l_0x1028_92a4:
            ii(0x1028_92a4, 9); mov(memw_a32[ds, 0x173], 0xc);          /* mov word [0x173], 0xc */
            ii(0x1028_92ad, 9); mov(memw_a32[ds, 0x175], 0xb);          /* mov word [0x175], 0xb */
            ii(0x1028_92b6, 9); mov(memw_a32[ds, 0x177], 0xa);          /* mov word [0x177], 0xa */
            ii(0x1028_92bf, 5); mov(al, memb_a32[ds, 0x137]);           /* mov al, [0x137] */
            ii(0x1028_92c4, 5); mov(memb_a32[ds, 0x179], al);           /* mov [0x179], al */
        l_0x1028_92c9:
            ii(0x1028_92c9, 7); mov(ax, memw_a32[ds, ebx + 0x17b]);     /* mov ax, [ebx+0x17b] */
            ii(0x1028_92d0, 6); mov(memw_a32[ds, 0x139], ax);           /* mov [0x139], ax */
            ii(0x1028_92d6, 7); mov(ax, memw_a32[ds, ebx + 0x19b]);     /* mov ax, [ebx+0x19b] */
            ii(0x1028_92dd, 6); mov(memw_a32[ds, 0x13b], ax);           /* mov [0x13b], ax */
            ii(0x1028_92e3, 7); mov(ax, memw_a32[ds, ebx + 0x18b]);     /* mov ax, [ebx+0x18b] */
            ii(0x1028_92ea, 6); mov(memw_a32[ds, 0x15f], ax);           /* mov [0x15f], ax */
            ii(0x1028_92f0, 2); mov(bl, cl);                            /* mov bl, cl */
            ii(0x1028_92f2, 2); shl(bl, 0x1);                           /* shl bl, 1 */
            ii(0x1028_92f4, 7); mov(ax, memw_a32[ds, ebx + 0x1ab]);     /* mov ax, [ebx+0x1ab] */
            ii(0x1028_92fb, 6); mov(memw_a32[ds, 0x13d], ax);           /* mov [0x13d], ax */
            ii(0x1028_9301, 7); mov(ax, memw_a32[ds, ebx + 0x1cd]);     /* mov ax, [ebx+0x1cd] */
            ii(0x1028_9308, 6); mov(memw_a32[ds, 0x13f], ax);           /* mov [0x13f], ax */
            ii(0x1028_930e, 7); mov(ax, memw_a32[ds, ebx + 0x1ed]);     /* mov ax, [ebx+0x1ed] */
            ii(0x1028_9315, 6); mov(memw_a32[ds, 0x141], ax);           /* mov [0x141], ax */
            ii(0x1028_931b, 7); cmp(memb_a32[ds, 0x170], 0x7);          /* cmp byte [0x170], 0x7 */
            ii(0x1028_9322, 6); if(jgd(0x1028_9339, 0x11)) goto l_0x1028_9339; /* jg 0x10289339 */
            ii(0x1028_9328, 5); mov(al, memb_a32[ds, 0x170]);           /* mov al, [0x170] */
            ii(0x1028_932d, 2); or(al, 0x60);                           /* or al, 0x60 */
            ii(0x1028_932f, 5); mov(memb_a32[ds, 0x171], al);           /* mov [0x171], al */
            ii(0x1028_9334, 2); jmpd(0x1028_934e, 0x18); goto l_0x1028_934e; /* jmp 0x1028934e */
        //    ii(0x1028_9336, 1); nop();                                  /* nop */
        //    ii(0x1028_9337, 1); nop();                                  /* nop */
        //    ii(0x1028_9338, 1); nop();                                  /* nop */
        l_0x1028_9339:
            ii(0x1028_9339, 5); mov(al, memb_a32[ds, 0x170]);           /* mov al, [0x170] */
            ii(0x1028_933e, 2); sub(al, 0x8);                           /* sub al, 0x8 */
            ii(0x1028_9340, 2); or(al, 0x60);                           /* or al, 0x60 */
            ii(0x1028_9342, 5); mov(memb_a32[ds, 0x172], al);           /* mov [0x172], al */
            ii(0x1028_9347, 7); mov(memb_a32[ds, 0x171], 0x62);         /* mov byte [0x171], 0x62 */
        l_0x1028_934e:
            ii(0x1028_934e, 5); mov(al, memb_a32[ds, 0x172]);           /* mov al, [0x172] */
            ii(0x1028_9353, 5); mov(memb_a32[ds, 0x7ab], al);           /* mov [0x7ab], al */
            ii(0x1028_9358, 5); mov(al, memb_a32[ds, 0x171]);           /* mov al, [0x171] */
            ii(0x1028_935d, 5); mov(memb_a32[ds, 0x79d], al);           /* mov [0x79d], al */
            ii(0x1028_9362, 5); mov(al, memb_a32[ds, 0x170]);           /* mov al, [0x170] */
            ii(0x1028_9367, 5); mov(memb_a32[ds, 0x7a0], al);           /* mov [0x7a0], al */
            ii(0x1028_936c, 7); mov(dx, memw_a32[ds, 0x135]);           /* mov dx, [0x135] */
            ii(0x1028_9373, 4); add(dx, 0x6);                           /* add dx, 0x6 */
            ii(0x1028_9377, 2); mov(al, 0x1);                           /* mov al, 0x1 */
            ii(0x1028_9379, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_937a, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
        l_0x1028_937f:
            ii(0x1028_937f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1028_9380, 5); mov(ecx, 0x10);                         /* mov ecx, 0x10 */
        l_0x1028_9385:
            ii(0x1028_9385, 1); nop();                                  /* nop */
            ii(0x1028_9386, 2); if(loopd_a32(0x1028_9385, -0x3)) goto l_0x1028_9385; /* loop 0x10289385 */
            ii(0x1028_9388, 1); popd(ecx);                              /* pop ecx */
            ii(0x1028_9389, 2); if(loopd_a32(0x1028_937f, -0xc)) goto l_0x1028_937f; /* loop 0x1028937f */
            ii(0x1028_938b, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1028_938d, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_938e, 4); add(dx, 0x8);                           /* add dx, 0x8 */
            ii(0x1028_9392, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
        l_0x1028_9397:
            ii(0x1028_9397, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_9398, 2); and(al, 0x80);                          /* and al, 0x80 */
            ii(0x1028_939a, 6); if(jnzd(0x1028_93a2, 0x2)) goto l_0x1028_93a2; /* jnz 0x102893a2 */
            ii(0x1028_93a0, 2); if(loopd_a32(0x1028_9397, -0xb)) goto l_0x1028_9397; /* loop 0x10289397 */
        l_0x1028_93a2:
            ii(0x1028_93a2, 4); sub(dx, 0x4);                           /* sub dx, 0x4 */
            ii(0x1028_93a6, 5); mov(ecx, 0xffff);                       /* mov ecx, 0xffff */
        l_0x1028_93ab:
            ii(0x1028_93ab, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_93ac, 2); cmp(al, -0x56 /* 0xaa */);              /* cmp al, 0xaa */
            ii(0x1028_93ae, 6); if(jzd(0x1028_93b6, 0x2)) goto l_0x1028_93b6; /* jz 0x102893b6 */
            ii(0x1028_93b4, 2); if(loopd_a32(0x1028_93ab, -0xb)) goto l_0x1028_93ab; /* loop 0x102893ab */
        l_0x1028_93b6:
            ii(0x1028_93b6, 6); mov(ax, memw_a32[ds, 0x13d]);           /* mov ax, [0x13d] */
            ii(0x1028_93bc, 5); calld(0x1028_9604, 0x243);              /* call 0x10289604 */
            ii(0x1028_93c1, 7); mov(dx, memw_a32[ds, 0x135]);           /* mov dx, [0x135] */
            ii(0x1028_93c8, 4); add(dx, 0x4);                           /* add dx, 0x4 */
            ii(0x1028_93cc, 2); mov(al, 0x83);                          /* mov al, 0x83 */
            ii(0x1028_93ce, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_93cf, 2); inc(dx);                                /* inc dx */
            ii(0x1028_93d1, 2); mov(al, 0xb);                           /* mov al, 0xb */
            ii(0x1028_93d3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_93d4, 4); mov(ax, 0x1);                           /* mov ax, 0x1 */
            ii(0x1028_93d8, 1); retd(); return;                         /* ret */
        }
    }
}

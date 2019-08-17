using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7ce0e50f-eaee-44d6-81b3-c0314a1dcb33")]
        public void Method_1028_948f()
        {
            ii(0x1028_948f, 7); mov(memb_a32[ds, 0x163], 0x1);          /* mov byte [0x163], 0x1 */
            ii(0x1028_9496, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1028_9498, 3); shr(eax, 0x10);                         /* shr eax, 0x10 */
            ii(0x1028_949b, 6); mov(memw_a32[ds, 0x157], ax);           /* mov [0x157], ax */
            ii(0x1028_94a1, 7); mov(memw_a32[ds, 0x159], di);           /* mov [0x159], di */
            ii(0x1028_94a8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1028_94a9, 2); mov(cl, 0xc);                           /* mov cl, 0xc */
            ii(0x1028_94ab, 3); shl(ax, cl);                            /* shl ax, cl */
            ii(0x1028_94ae, 2); pushw(ax);                              /* push ax */
            ii(0x1028_94b0, 3); mov(ax, di);                            /* mov ax, di */
            ii(0x1028_94b3, 2); mov(cl, 0x4);                           /* mov cl, 0x4 */
            ii(0x1028_94b5, 3); shr(ax, cl);                            /* shr ax, cl */
            ii(0x1028_94b8, 3); mov(cx, ax);                            /* mov cx, ax */
            ii(0x1028_94bb, 2); popw(ax);                               /* pop ax */
            ii(0x1028_94bd, 3); add(ax, cx);                            /* add ax, cx */
            ii(0x1028_94c0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1028_94c1, 7); mov(memw_a32[ds, 0x165], cx);           /* mov [0x165], cx */
            ii(0x1028_94c8, 7); sub(cx, memw_a32[ds, 0x155]);           /* sub cx, [0x155] */
            ii(0x1028_94cf, 7); mov(memw_a32[ds, 0x15d], cx);           /* mov [0x15d], cx */
            ii(0x1028_94d6, 2); mov(al, 0x50);                          /* mov al, 0x50 */
            ii(0x1028_94d8, 6); mov(bl, memb_a32[ds, 0x179]);           /* mov bl, [0x179] */
            ii(0x1028_94de, 2); or(al, bl);                             /* or al, bl */
            ii(0x1028_94e0, 6); mov(bl, memb_a32[ds, 0x153]);           /* mov bl, [0x153] */
            ii(0x1028_94e6, 2); or(al, bl);                             /* or al, bl */
            ii(0x1028_94e8, 7); mov(dx, memw_a32[ds, 0x175]);           /* mov dx, [0x175] */
            ii(0x1028_94ef, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_94f0, 7); mov(dx, memw_a32[ds, 0x139]);           /* mov dx, [0x139] */
            ii(0x1028_94f7, 5); mov(al, memb_a32[ds, 0x157]);           /* mov al, [0x157] */
            ii(0x1028_94fc, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_94fd, 4); mov(dx, 0xc);                           /* mov dx, 0xc */
            ii(0x1028_9501, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1028_9503, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9504, 7); mov(dx, memw_a32[ds, 0x13b]);           /* mov dx, [0x13b] */
            ii(0x1028_950b, 6); mov(ax, memw_a32[ds, 0x159]);           /* mov ax, [0x159] */
            ii(0x1028_9511, 8); cmp(memw_a32[ds, 0x137], 0x3);          /* cmp word [0x137], 0x3 */
            ii(0x1028_9519, 6); if(jled(0x1028_9536, 0x17)) goto l_0x1028_9536; /* jle 0x10289536 */
            ii(0x1028_951f, 3); shr(ax, 0x1);                           /* shr ax, 1 */
            ii(0x1028_9522, 7); mov(bx, memw_a32[ds, 0x157]);           /* mov bx, [0x157] */
            ii(0x1028_9529, 3); shr(bx, 0x1);                           /* shr bx, 1 */
            ii(0x1028_952c, 6); if(jaed(0x1028_9536, 0x4)) goto l_0x1028_9536; /* jae 0x10289536 */
            ii(0x1028_9532, 4); add(ax, 0x8000);                        /* add ax, 0x8000 */
        l_0x1028_9536:
            ii(0x1028_9536, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9537, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1028_9539, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_953a, 7); mov(dx, memw_a32[ds, 0x173]);           /* mov dx, [0x173] */
            ii(0x1028_9541, 2); mov(al, 0);                             /* mov al, 0x0 */
            ii(0x1028_9543, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9544, 7); mov(dx, memw_a32[ds, 0x15f]);           /* mov dx, [0x15f] */
            ii(0x1028_954b, 5); mov(al, memb_a32[ds, 0x137]);           /* mov al, [0x137] */
            ii(0x1028_9550, 2); cmp(al, 0x3);                           /* cmp al, 0x3 */
            ii(0x1028_9552, 6); if(jled(0x1028_9567, 0xf)) goto l_0x1028_9567; /* jle 0x10289567 */
            ii(0x1028_9558, 6); mov(ax, memw_a32[ds, 0x15d]);           /* mov ax, [0x15d] */
            ii(0x1028_955e, 3); shr(ax, 0x1);                           /* shr ax, 1 */
            ii(0x1028_9561, 6); mov(memw_a32[ds, 0x15d], ax);           /* mov [0x15d], ax */
        l_0x1028_9567:
            ii(0x1028_9567, 6); mov(ax, memw_a32[ds, 0x15d]);           /* mov ax, [0x15d] */
            ii(0x1028_956d, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_956e, 2); mov(al, ah);                            /* mov al, ah */
            ii(0x1028_9570, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9571, 5); calld(0x1028_9702, 0x18c);              /* call 0x10289702 */
            ii(0x1028_9576, 7); mov(dx, memw_a32[ds, 0x177]);           /* mov dx, [0x177] */
            ii(0x1028_957d, 5); mov(al, memb_a32[ds, 0x179]);           /* mov al, [0x179] */
            ii(0x1028_9582, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9583, 7); mov(dx, memw_a32[ds, 0x135]);           /* mov dx, [0x135] */
            ii(0x1028_958a, 4); add(dx, 0xe);                           /* add dx, 0xe */
            ii(0x1028_958e, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1028_958f, 5); calld(0x1028_95e8, 0x54);               /* call 0x102895e8 */
            ii(0x1028_9594, 7); mov(dx, memw_a32[ds, 0x135]);           /* mov dx, [0x135] */
            ii(0x1028_959b, 4); add(dx, 0xc);                           /* add dx, 0xc */
            ii(0x1028_959f, 4); mov(ax, 0xb4);                          /* mov ax, 0xb4 */
            ii(0x1028_95a3, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_95a4, 5); calld(0x1028_95e8, 0x3f);               /* call 0x102895e8 */
            ii(0x1028_95a9, 2); mov(al, 0x30);                          /* mov al, 0x30 */
            ii(0x1028_95ab, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_95ac, 5); calld(0x1028_95e8, 0x37);               /* call 0x102895e8 */
            ii(0x1028_95b1, 6); mov(ax, memw_a32[ds, 0x15d]);           /* mov ax, [0x15d] */
            ii(0x1028_95b7, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_95b8, 5); calld(0x1028_95e8, 0x2b);               /* call 0x102895e8 */
            ii(0x1028_95bd, 2); xchg(al, ah);                           /* xchg al, ah */
            ii(0x1028_95bf, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_95c0, 1); retd(); return;                         /* ret */
        }
    }
}

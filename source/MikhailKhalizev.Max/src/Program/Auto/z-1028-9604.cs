using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1028_9604-e70a3557")]
        public void Method_1028_9604()
        {
            ii(0x1028_9604, 1); pushd(eax);                             /* push eax */
            ii(0x1028_9605, 5); calld(0x1028_9724, 0x11a);              /* call 0x10289724 */
            ii(0x1028_960a, 1); popd(eax);                              /* pop eax */
            ii(0x1028_960b, 1); pushd(eax);                             /* push eax */
            ii(0x1028_960c, 1); pushd(es);                              /* push es */
            ii(0x1028_960d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1028_960e, 2); mov(ah, 0x35);                          /* mov ah, 0x35 */
            ii(0x1028_9610, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1028_9612, 6); mov(memd_a32[ds, 0x143], ebx);          /* mov [0x143], ebx */
            ii(0x1028_9618, 7); mov(memw_a32[ds, 0x147], es);           /* mov [0x147], es */
            ii(0x1028_961f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1028_9620, 1); popd(es);                               /* pop es */
            ii(0x1028_9621, 1); popd(eax);                              /* pop eax */
            ii(0x1028_9622, 1); pushd(eax);                             /* push eax */
            ii(0x1028_9623, 1); pushd(ds);                              /* push ds */
            ii(0x1028_9624, 1); pushd(es);                              /* push es */
            ii(0x1028_9625, 1); pushd(eax);                             /* push eax */
            ii(0x1028_9626, 5); mov(edx, 0x748);                        /* mov edx, 0x748 */
            ii(0x1028_962b, 3); mov(ax, cs);                            /* mov ax, cs */
            ii(0x1028_962e, 3); mov(ds, ax);                            /* mov ds, ax */
            ii(0x1028_9631, 3); xor(ax, ax);                            /* xor ax, ax */
            ii(0x1028_9634, 3); mov(es, ax);                            /* mov es, ax */
            ii(0x1028_9637, 1); popd(eax);                              /* pop eax */
            ii(0x1028_9638, 2); mov(ah, 0x25);                          /* mov ah, 0x25 */
            ii(0x1028_963a, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1028_963c, 1); popd(es);                               /* pop es */
            ii(0x1028_963d, 1); popd(ds);                               /* pop ds */
            ii(0x1028_963e, 4); mov(dx, 0x20);                          /* mov dx, 0x20 */
            ii(0x1028_9642, 2); mov(al, 0x20);                          /* mov al, 0x20 */
            ii(0x1028_9644, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1028_9645, 1); popd(eax);                              /* pop eax */
            ii(0x1028_9646, 1); pushd(eax);                             /* push eax */
            ii(0x1028_9647, 1); pushd(ebx);                             /* push ebx */
            ii(0x1028_9648, 1); pushd(edx);                             /* push edx */
            ii(0x1028_9649, 4); mov(ax, 0x100);                         /* mov ax, 0x100 */
            ii(0x1028_964d, 4); mov(bx, 0x100);                         /* mov bx, 0x100 */
            ii(0x1028_9651, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1028_9653, 6); mov(memw_a32[ds, 0x16a], ax);           /* mov [0x16a], ax */
            ii(0x1028_9659, 7); mov(memw_a32[ds, 0x168], dx);           /* mov [0x168], dx */
            ii(0x1028_9660, 1); pushd(ds);                              /* push ds */
            ii(0x1028_9661, 3); mov(es, dx);                            /* mov es, dx */
            ii(0x1028_9664, 2); xor(edi, edi);                          /* xor edi, edi */
            ii(0x1028_9666, 5); mov(esi, 0x790);                        /* mov esi, 0x790 */
            ii(0x1028_966b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1028_966d, 7); mov(cx, memw_a32[ds, 0x7b0]);           /* mov cx, [0x7b0] */
            ii(0x1028_9674, 1); pushd(cs);                              /* push cs */
            ii(0x1028_9675, 1); popd(ds);                               /* pop ds */
            ii(0x1028_9676, 2); repne_a32(() => movsb_a32());           /* repne movsb */
            ii(0x1028_9678, 1); popd(ds);                               /* pop ds */
            ii(0x1028_9679, 1); popd(edx);                              /* pop edx */
            ii(0x1028_967a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1028_967b, 1); popd(eax);                              /* pop eax */
            ii(0x1028_967c, 1); pushd(eax);                             /* push eax */
            ii(0x1028_967d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1028_967e, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1028_9680, 4); mov(ax, 0x200);                         /* mov ax, 0x200 */
            ii(0x1028_9684, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1028_9686, 7); mov(memw_a32[ds, 0x16c], dx);           /* mov [0x16c], dx */
            ii(0x1028_968d, 7); mov(memw_a32[ds, 0x16e], cx);           /* mov [0x16e], cx */
            ii(0x1028_9694, 1); popd(ebx);                              /* pop ebx */
            ii(0x1028_9695, 1); popd(eax);                              /* pop eax */
            ii(0x1028_9696, 1); pushd(ebx);                             /* push ebx */
            ii(0x1028_9697, 1); pushd(edx);                             /* push edx */
            ii(0x1028_9698, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1028_969a, 7); mov(cx, memw_a32[ds, 0x16a]);           /* mov cx, [0x16a] */
            ii(0x1028_96a1, 3); xor(dx, dx);                            /* xor dx, dx */
            ii(0x1028_96a4, 4); mov(ax, 0x201);                         /* mov ax, 0x201 */
            ii(0x1028_96a8, 2); @int(0x31);                             /* int 0x31 */
            ii(0x1028_96aa, 1); popd(edx);                              /* pop edx */
            ii(0x1028_96ab, 1); popd(ebx);                              /* pop ebx */
            ii(0x1028_96ac, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_4286-c15d2e8b")]
        public void /* sys */ Method_1019_4286()
        {
            ii(0x1019_4286, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_4287, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_4289, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_428a, 5); mov(edx, 0x3da);                        /* mov edx, 0x3da */
        l_0x1019_428f:
            ii(0x1019_428f, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4290, 2); test(al, 0x8);                          /* test al, 0x8 */
            ii(0x1019_4292, 2); if(jnzd(0x1019_428f, -0x5)) goto l_0x1019_428f; /* jnz 0x1019428f */
        l_0x1019_4294:
            ii(0x1019_4294, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4295, 2); test(al, 0x8);                          /* test al, 0x8 */
            ii(0x1019_4297, 2); if(jzd(0x1019_4294, -0x5)) goto l_0x1019_4294; /* jz 0x10194294 */
            ii(0x1019_4299, 1); cli();                                  /* cli */
            ii(0x1019_429a, 5); mov(edx, 0x3c4);                        /* mov edx, 0x3c4 */
            ii(0x1019_429f, 5); mov(eax, 0x100);                        /* mov eax, 0x100 */
            ii(0x1019_42a4, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_42a6, 5); mov(edx, 0x3cc);                        /* mov edx, 0x3cc */
            ii(0x1019_42ab, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_42ac, 2); and(al, 0x3f);                          /* and al, 0x3f */
            ii(0x1019_42ae, 5); mov(edx, 0x3c2);                        /* mov edx, 0x3c2 */
            ii(0x1019_42b3, 4); and(memb_a32[ss, ebp + 0x8], -0x40 /* 0xc0 */); /* and byte [ebp+0x8], 0xc0 */
            ii(0x1019_42b7, 3); or(al, memb_a32[ss, ebp + 0x8]);        /* or al, [ebp+0x8] */
            ii(0x1019_42ba, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_42bb, 5); mov(edx, 0x3c4);                        /* mov edx, 0x3c4 */
            ii(0x1019_42c0, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x1019_42c5, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_42c7, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1019_42cc, 3); mov(ebx, memd_a32[ss, ebp + 0xc]);      /* mov ebx, [ebp+0xc] */
            ii(0x1019_42cf, 2); mov(al, 0x11);                          /* mov al, 0x11 */
            ii(0x1019_42d1, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_42d2, 2); inc(dx);                                /* inc dx */
            ii(0x1019_42d4, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_42d5, 2); dec(dx);                                /* dec dx */
            ii(0x1019_42d7, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1019_42d9, 2); mov(al, 0x11);                          /* mov al, 0x11 */
            ii(0x1019_42db, 3); and(ah, 0x7f);                          /* and ah, 0x7f */
            ii(0x1019_42de, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_42e0, 2); mov(al, 0x3);                           /* mov al, 0x3 */
            ii(0x1019_42e2, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_42e3, 2); inc(dx);                                /* inc dx */
            ii(0x1019_42e5, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_42e6, 2); dec(dx);                                /* dec dx */
            ii(0x1019_42e8, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1019_42ea, 2); mov(al, 0x3);                           /* mov al, 0x3 */
            ii(0x1019_42ec, 3); or(ah, 0x80);                           /* or ah, 0x80 */
            ii(0x1019_42ef, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_42f1, 2); mov(al, 0x6);                           /* mov al, 0x6 */
            ii(0x1019_42f3, 3); mov(ah, memb_a32[ds, ebx + 0x6]);       /* mov ah, [ebx+0x6] */
            ii(0x1019_42f6, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_42f8, 2); mov(al, 0x7);                           /* mov al, 0x7 */
            ii(0x1019_42fa, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_42fb, 2); inc(dx);                                /* inc dx */
            ii(0x1019_42fd, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_42fe, 2); dec(dx);                                /* dec dx */
            ii(0x1019_4300, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1019_4302, 2); mov(al, 0x7);                           /* mov al, 0x7 */
            ii(0x1019_4304, 3); and(ah, 0x10);                          /* and ah, 0x10 */
            ii(0x1019_4307, 3); or(ah, memb_a32[ds, ebx + 0x7]);        /* or ah, [ebx+0x7] */
            ii(0x1019_430a, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_430c, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1019_430e, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_430f, 2); inc(dx);                                /* inc dx */
            ii(0x1019_4311, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4312, 2); dec(dx);                                /* dec dx */
            ii(0x1019_4314, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1019_4316, 2); mov(al, 0x9);                           /* mov al, 0x9 */
            ii(0x1019_4318, 3); and(ah, 0x40);                          /* and ah, 0x40 */
            ii(0x1019_431b, 3); or(ah, memb_a32[ds, ebx + 0x9]);        /* or ah, [ebx+0x9] */
            ii(0x1019_431e, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_4320, 2); mov(al, 0x10);                          /* mov al, 0x10 */
            ii(0x1019_4322, 3); mov(ah, memb_a32[ds, ebx + 0x10]);      /* mov ah, [ebx+0x10] */
            ii(0x1019_4325, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_4327, 2); mov(al, 0x11);                          /* mov al, 0x11 */
            ii(0x1019_4329, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_432a, 2); inc(dx);                                /* inc dx */
            ii(0x1019_432c, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_432d, 2); dec(dx);                                /* dec dx */
            ii(0x1019_432f, 2); mov(ah, al);                            /* mov ah, al */
            ii(0x1019_4331, 2); mov(al, 0x11);                          /* mov al, 0x11 */
            ii(0x1019_4333, 3); and(ah, 0x70);                          /* and ah, 0x70 */
            ii(0x1019_4336, 3); or(ah, memb_a32[ds, ebx + 0x11]);       /* or ah, [ebx+0x11] */
            ii(0x1019_4339, 3); or(ah, 0x80);                           /* or ah, 0x80 */
            ii(0x1019_433c, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_433e, 2); mov(al, 0x12);                          /* mov al, 0x12 */
            ii(0x1019_4340, 3); mov(ah, memb_a32[ds, ebx + 0x12]);      /* mov ah, [ebx+0x12] */
            ii(0x1019_4343, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_4345, 2); mov(al, 0x15);                          /* mov al, 0x15 */
            ii(0x1019_4347, 3); mov(ah, memb_a32[ds, ebx + 0x15]);      /* mov ah, [ebx+0x15] */
            ii(0x1019_434a, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_434c, 2); mov(al, 0x16);                          /* mov al, 0x16 */
            ii(0x1019_434e, 3); mov(ah, memb_a32[ds, ebx + 0x16]);      /* mov ah, [ebx+0x16] */
            ii(0x1019_4351, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_4353, 1); sti();                                  /* sti */
            ii(0x1019_4354, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4355, 1); leaved();                               /* leave */
            ii(0x1019_4356, 1); retd(); return;                         /* ret */
        }
    }
}

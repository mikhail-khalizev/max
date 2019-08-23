using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_41ed-f3550a06")]
        public void /* sys */ Method_1019_41ed()
        {
            ii(0x1019_41ed, 1); pushd(ebp);                             /* push ebp */
            ii(0x1019_41ee, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1019_41f0, 1); pushd(esi);                             /* push esi */
            ii(0x1019_41f1, 1); pushd(edi);                             /* push edi */
            ii(0x1019_41f2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_41f3, 5); mov(edx, 0x3c4);                        /* mov edx, 0x3c4 */
            ii(0x1019_41f8, 2); mov(al, 0x4);                           /* mov al, 0x4 */
            ii(0x1019_41fa, 3); mov(ah, memb_a32[ss, ebp + 0xc]);       /* mov ah, [ebp+0xc] */
            ii(0x1019_41fd, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_41ff, 4); mov(dx, 0x3da);                         /* mov dx, 0x3da */
        l_0x1019_4203:
            ii(0x1019_4203, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4204, 2); test(al, 0x8);                          /* test al, 0x8 */
            ii(0x1019_4206, 2); if(jnzd(0x1019_4203, -0x5)) goto l_0x1019_4203; /* jnz 0x10194203 */
        l_0x1019_4208:
            ii(0x1019_4208, 1); inb(al, dx);                            /* in al, dx */
            ii(0x1019_4209, 2); test(al, 0x8);                          /* test al, 0x8 */
            ii(0x1019_420b, 2); if(jzd(0x1019_4208, -0x5)) goto l_0x1019_4208; /* jz 0x10194208 */
            ii(0x1019_420d, 1); cli();                                  /* cli */
            ii(0x1019_420e, 5); mov(edx, 0x3c4);                        /* mov edx, 0x3c4 */
            ii(0x1019_4213, 5); mov(eax, 0x100);                        /* mov eax, 0x100 */
            ii(0x1019_4218, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_421a, 5); mov(edx, 0x3c2);                        /* mov edx, 0x3c2 */
            ii(0x1019_421f, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x1019_4222, 1); outb(dx, al);                           /* out dx, al */
            ii(0x1019_4223, 5); mov(edx, 0x3c4);                        /* mov edx, 0x3c4 */
            ii(0x1019_4228, 5); mov(eax, 0x300);                        /* mov eax, 0x300 */
            ii(0x1019_422d, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_422f, 5); mov(edx, 0x3d4);                        /* mov edx, 0x3d4 */
            ii(0x1019_4234, 3); mov(esi, memd_a32[ss, ebp + 0x8]);      /* mov esi, [ebp+0x8] */
            ii(0x1019_4237, 2); mov(al, 0x11);                          /* mov al, 0x11 */
            ii(0x1019_4239, 3); mov(ah, memb_a32[ds, esi + 0x11]);      /* mov ah, [esi+0x11] */
            ii(0x1019_423c, 3); and(ah, 0x7f);                          /* and ah, 0x7f */
            ii(0x1019_423f, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_4241, 5); mov(ecx, 0x18);                         /* mov ecx, 0x18 */
            ii(0x1019_4246, 5); mov(ebx, 0);                            /* mov ebx, 0x0 */
        l_0x1019_424b:
            ii(0x1019_424b, 2); mov(al, bl);                            /* mov al, bl */
            ii(0x1019_424d, 3); mov(ah, memb_a32[ds, ebx + esi]);       /* mov ah, [ebx+esi] */
            ii(0x1019_4250, 2); outw(dx, ax);                           /* out dx, ax */
            ii(0x1019_4252, 2); inc(bl);                                /* inc bl */
            ii(0x1019_4254, 2); if(loopd_a32(0x1019_424b, -0xb)) goto l_0x1019_424b; /* loop 0x1019424b */
            ii(0x1019_4256, 1); sti();                                  /* sti */
            ii(0x1019_4257, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_4258, 1); popd(edi);                              /* pop edi */
            ii(0x1019_4259, 1); popd(esi);                              /* pop esi */
            ii(0x1019_425a, 1); leaved();                               /* leave */
            ii(0x1019_425b, 1); retd();                                 /* ret */
        }
    }
}

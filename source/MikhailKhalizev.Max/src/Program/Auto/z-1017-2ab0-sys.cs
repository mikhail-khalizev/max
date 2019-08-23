using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_2ab0-ccde18d")]
        public void /* sys */ Method_1017_2ab0()
        {
            ii(0x1017_2ab0, 1); push(ebx);                              /* push ebx */
            ii(0x1017_2ab1, 1); push(ecx);                              /* push ecx */
            ii(0x1017_2ab2, 1); push(edx);                              /* push edx */
            ii(0x1017_2ab3, 7); cmp(memb[ds, 0x101b_e1e0], 0);          /* cmp byte [0x101be1e0], 0x0 */
            ii(0x1017_2aba, 6); if(jnz(0x1017_2b91, 0xd1)) goto l_0x1017_2b91; /* jnz 0x10172b91 */
            ii(0x1017_2ac0, 5); mov(ebx, 0x100);                        /* mov ebx, 0x100 */
            ii(0x1017_2ac5, 5); mov(eax, 0x1020_9440);                  /* mov eax, 0x10209440 */
            ii(0x1017_2aca, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2acc, 5); call(/* sys */ 0x1018_24f4, 0xfa23);    /* call 0x101824f4 */
            ii(0x1017_2ad1, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1017_2ad6, 5); mov(eax, 0x1020_954c);                  /* mov eax, 0x1020954c */
            ii(0x1017_2adb, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2add, 5); call(/* sys */ 0x1018_24f4, 0xfa12);    /* call 0x101824f4 */
            ii(0x1017_2ae2, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1017_2ae7, 5); mov(eax, 0x101b_e1e0);                  /* mov eax, 0x101be1e0 */
            ii(0x1017_2aec, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2aee, 5); call(/* sys */ 0x1018_24f4, 0xfa01);    /* call 0x101824f4 */
            ii(0x1017_2af3, 5); mov(ebx, 0x100);                        /* mov ebx, 0x100 */
            ii(0x1017_2af8, 5); mov(eax, 0x1020_8940);                  /* mov eax, 0x10208940 */
            ii(0x1017_2afd, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2aff, 5); call(/* sys */ 0x1018_24f4, 0xf9f0);    /* call 0x101824f4 */
            ii(0x1017_2b04, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1017_2b09, 5); mov(eax, 0x101b_e1e8);                  /* mov eax, 0x101be1e8 */
            ii(0x1017_2b0e, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2b10, 5); call(/* sys */ 0x1018_24f4, 0xf9df);    /* call 0x101824f4 */
            ii(0x1017_2b15, 5); mov(ebx, 0x4);                          /* mov ebx, 0x4 */
            ii(0x1017_2b1a, 5); mov(eax, 0x101b_e1ec);                  /* mov eax, 0x101be1ec */
            ii(0x1017_2b1f, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2b21, 5); call(/* sys */ 0x1018_24f4, 0xf9ce);    /* call 0x101824f4 */
            ii(0x1017_2b26, 5); mov(ebx, 0x2);                          /* mov ebx, 0x2 */
            ii(0x1017_2b2b, 5); mov(eax, 0x101b_e1f0);                  /* mov eax, 0x101be1f0 */
            ii(0x1017_2b30, 2); mov(edx, ds);                           /* mov edx, ds */
            ii(0x1017_2b32, 5); call(/* sys */ 0x1018_24f4, 0xf9bd);    /* call 0x101824f4 */
            ii(0x1017_2b37, 5); mov(ebx, /* sys */ 0x1017_2e04);        /* mov ebx, 0x10172e04 */
            ii(0x1017_2b3c, 5); mov(eax, /* sys */ 0x1017_2d9c);        /* mov eax, 0x10172d9c */
            ii(0x1017_2b41, 2); mov(edx, cs);                           /* mov edx, cs */
            ii(0x1017_2b43, 6); sub(ebx, /* sys */ 0x1017_2d38);        /* sub ebx, 0x10172d38 */
            ii(0x1017_2b49, 2); mov(ecx, cs);                           /* mov ecx, cs */
            ii(0x1017_2b4b, 5); call(/* sys */ 0x1018_24f4, 0xf9a4);    /* call 0x101824f4 */
            ii(0x1017_2b50, 1); cli();                                  /* cli */
            ii(0x1017_2b51, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_2b56, 5); mov(ebx, /* sys */ 0x1017_2d9c);        /* mov ebx, 0x10172d9c */
            ii(0x1017_2b5b, 5); call(/* sys */ 0x1017_92be, 0x675e);    /* call 0x101792be */
            ii(0x1017_2b60, 7); mov(memw[ds, 0x1020_954a], dx);         /* mov [0x1020954a], dx */
            ii(0x1017_2b67, 5); mov(memd[ds, 0x1020_9546], eax);        /* mov [0x10209546], eax */
            ii(0x1017_2b6c, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_2b71, 2); mov(dl, 0x1);                           /* mov dl, 0x1 */
            ii(0x1017_2b73, 5); call(/* sys */ 0x1017_92f0, 0x6778);    /* call 0x101792f0 */
            ii(0x1017_2b78, 6); mov(memb[ds, 0x101b_e1e0], dl);         /* mov [0x101be1e0], dl */
            ii(0x1017_2b7e, 5); call(/* sys */ 0x1017_2bf0, 0x6d);      /* call 0x10172bf0 */
            ii(0x1017_2b83, 1); sti();                                  /* sti */
            ii(0x1017_2b84, 1); cld();                                  /* cld */
            ii(0x1017_2b85, 5); call(/* sys */ 0x1017_8d8c, 0x6202);    /* call 0x10178d8c */
            ii(0x1017_2b8a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_2b8c, 5); call(/* sys */ 0x1017_2cb8, 0x127);     /* call 0x10172cb8 */
        l_0x1017_2b91:
            ii(0x1017_2b91, 1); pop(edx);                               /* pop edx */
            ii(0x1017_2b92, 1); pop(ecx);                               /* pop ecx */
            ii(0x1017_2b93, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_2b94, 1); ret();                                  /* ret */
        }
    }
}

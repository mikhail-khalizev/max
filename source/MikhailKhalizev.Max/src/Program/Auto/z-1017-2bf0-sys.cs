using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5a39d3ea-de75-4c6d-ab5d-918448aa89fa")]
        public void /* sys */ Method_1017_2bf0()
        {
            ii(0x1017_2bf0, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_2bf1, 1); pushd(edx);                             /* push edx */
            ii(0x1017_2bf2, 7); cmp(memb_a32[ds, 0x101b_e1e0], 0);      /* cmp byte [0x101be1e0], 0x0 */
            ii(0x1017_2bf9, 2); if(jzd(0x1017_2c28, 0x2d)) goto l_0x1017_2c28; /* jz 0x10172c28 */
            ii(0x1017_2bfb, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1017_2bfd, 1); cli();                                  /* cli */
            ii(0x1017_2bfe, 6); mov(memb_a32[ds, 0x1020_954c], dl);     /* mov [0x1020954c], dl */
            ii(0x1017_2c04, 5); mov(ecx, 0x100);                        /* mov ecx, 0x100 */
            ii(0x1017_2c09, 5); mov(eax, 0x1020_9440);                  /* mov eax, 0x10209440 */
            ii(0x1017_2c0e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_2c10, 5); calld(/* sys */ 0x1018_1040, 0xe42b);   /* call 0x10181040 */
            ii(0x1017_2c15, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_2c17, 6); mov(memd_a32[ds, 0x101b_e1e8], edx);    /* mov [0x101be1e8], edx */
            ii(0x1017_2c1d, 6); mov(memd_a32[ds, 0x101b_e1ec], edx);    /* mov [0x101be1ec], edx */
            ii(0x1017_2c23, 1); sti();                                  /* sti */
            ii(0x1017_2c24, 1); cld();                                  /* cld */
            ii(0x1017_2c25, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2c26, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2c27, 1); retd(); return;                         /* ret */
        l_0x1017_2c28:
            ii(0x1017_2c28, 5); calld(/* sys */ 0x1018_d7ae, 0x1ab81);  /* call 0x1018d7ae */
            ii(0x1017_2c2d, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_2c2f, 2); if(jzd(0x1017_2c38, 0x7)) goto l_0x1017_2c38; /* jz 0x10172c38 */
            ii(0x1017_2c31, 5); calld(/* sys */ 0x1017_9285, 0x664f);   /* call 0x10179285 */
            ii(0x1017_2c36, 2); jmpd(0x1017_2c28, -0x10); goto l_0x1017_2c28; /* jmp 0x10172c28 */
        l_0x1017_2c38:
            ii(0x1017_2c38, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2c39, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2c3a, 1); retd(); return;                         /* ret */
        }
    }
}

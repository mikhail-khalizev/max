using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6e531cf5-3a69-4aa6-855a-06bbec98f66a")]
        public void /* sys */ Method_1017_2b98()
        {
            ii(0x1017_2b98, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_2b99, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_2b9a, 1); pushd(edx);                             /* push edx */
            ii(0x1017_2b9b, 7); cmp(memb_a32[ds, 0x101b_e1e0], 0);      /* cmp byte [0x101be1e0], 0x0 */
            ii(0x1017_2ba2, 2); if(jzd(0x1017_2bc6, 0x22)) goto l_0x1017_2bc6; /* jz 0x10172bc6 */
            ii(0x1017_2ba4, 1); cli();                                  /* cli */
            ii(0x1017_2ba5, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1017_2baa, 7); mov(cx, memw_a32[ds, 0x1020_954a]);     /* mov cx, [0x1020954a] */
            ii(0x1017_2bb1, 6); mov(ebx, memd_a32[ds, 0x1020_9546]);    /* mov ebx, [0x10209546] */
            ii(0x1017_2bb7, 5); calld(/* sys */ 0x1017_92f0, 0x6734);   /* call 0x101792f0 */
            ii(0x1017_2bbc, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1017_2bbe, 1); sti();                                  /* sti */
            ii(0x1017_2bbf, 1); cld();                                  /* cld */
            ii(0x1017_2bc0, 6); mov(memb_a32[ds, 0x101b_e1e0], dl);     /* mov [0x101be1e0], dl */
        l_0x1017_2bc6:
            ii(0x1017_2bc6, 1); popd(edx);                              /* pop edx */
            ii(0x1017_2bc7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_2bc8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_2bc9, 1); retd(); return;                         /* ret */
        }
    }
}
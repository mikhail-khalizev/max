using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_97f0-5dd8d295")]
        public void /* sys */ Method_1017_97f0()
        {
            ii(0x1017_97f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_97f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_97f3, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_97f4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_97f5, 1); pushd(edx);                             /* push edx */
            ii(0x1017_97f6, 6); mov(edx, memd_a32[ds, 0x101b_e41c]);    /* mov edx, [0x101be41c] */
            ii(0x1017_97fc, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_97fe, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1017_9801, 2); if(jzd(0x1017_9814, 0x11)) goto l_0x1017_9814; /* jz 0x10179814 */
            ii(0x1017_9803, 5); calld(Definitions.sys_timer_3, 0x1_44bc); /* call 0x1018dcc4 */
            ii(0x1017_9808, 6); mov(edx, memd_a32[ds, 0x1020_9dc0]);    /* mov edx, [0x10209dc0] */
            ii(0x1017_980e, 6); add(memd_a32[ds, 0x101b_e420], edx);    /* add [0x101be420], edx */
        l_0x1017_9814:
            ii(0x1017_9814, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1017_9817, 1); popd(edx);                              /* pop edx */
            ii(0x1017_9818, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_9819, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_981a, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_981b, 1); retd(); return;                         /* ret */
        }
    }
}

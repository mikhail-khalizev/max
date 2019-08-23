using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_9650-a24eb459")]
        public void /* sys */ Method_1017_9650()
        {
            ii(0x1017_9650, 1); pushd(ebp);                             /* push ebp */
            ii(0x1017_9651, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_9653, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_9654, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_9655, 1); pushd(edx);                             /* push edx */
            ii(0x1017_9656, 6); mov(edx, memd_a32[ds, 0x101b_e41c]);    /* mov edx, [0x101be41c] */
            ii(0x1017_965c, 3); cmp(edx, -0x1 /* 0xff */);              /* cmp edx, 0xffffffff */
            ii(0x1017_965f, 2); if(jzd(0x1017_967b, 0x1a)) goto l_0x1017_967b; /* jz 0x1017967b */
            ii(0x1017_9661, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1017_9663, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x1017_9668, 5); calld(/* sys */ 0x1017_dc61, 0x45f4);   /* call 0x1017dc61 */
            ii(0x1017_966d, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1017_966f, 6); mov(memd_a32[ds, 0x101b_e41c], ebx);    /* mov [0x101be41c], ebx */
            ii(0x1017_9675, 6); mov(memd_a32[ds, 0x101b_e420], ecx);    /* mov [0x101be420], ecx */
        l_0x1017_967b:
            ii(0x1017_967b, 3); lea(esp, ebp - 0xc);                    /* lea esp, [ebp-0xc] */
            ii(0x1017_967e, 1); popd(edx);                              /* pop edx */
            ii(0x1017_967f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_9680, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_9681, 1); popd(ebp);                              /* pop ebp */
            ii(0x1017_9682, 1); retd();                                 /* ret */
        }
    }
}

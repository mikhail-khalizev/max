using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_ba98-a9da67e3")]
        public void /* sys */ Method_1018_ba98()
        {
            ii(0x1018_ba98, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_ba99, 1); pushd(ecx);                             /* push ecx */
            ii(0x1018_ba9a, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_ba9c, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1018_ba9e, 5); calld(/* sys */ 0x1017_1f05, -0x1_9b9e); /* call 0x10171f05 */
            ii(0x1018_baa3, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1018_baa5, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_baa8, 2); if(jzd(0x1018_baf3, 0x49)) goto l_0x1018_baf3; /* jz 0x1018baf3 */
            ii(0x1018_baaa, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_baac, 5); calld(/* sys */ 0x1017_1f05, -0x1_9bac); /* call 0x10171f05 */
            ii(0x1018_bab1, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_bab4, 2); if(jzd(0x1018_baf3, 0x3d)) goto l_0x1018_baf3; /* jz 0x1018baf3 */
            ii(0x1018_bab6, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1018_bab9, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_babe, 2); or(edx, eax);                           /* or edx, eax */
            ii(0x1018_bac0, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_bac2, 5); calld(/* sys */ 0x1017_1f05, -0x1_9bc2); /* call 0x10171f05 */
            ii(0x1018_bac7, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_baca, 2); if(jzd(0x1018_baf3, 0x27)) goto l_0x1018_baf3; /* jz 0x1018baf3 */
            ii(0x1018_bacc, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1018_bacf, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_bad4, 2); or(edx, eax);                           /* or edx, eax */
            ii(0x1018_bad6, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1018_bad8, 5); calld(/* sys */ 0x1017_1f05, -0x1_9bd8); /* call 0x10171f05 */
            ii(0x1018_badd, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_bae0, 2); if(jzd(0x1018_baf3, 0x11)) goto l_0x1018_baf3; /* jz 0x1018baf3 */
            ii(0x1018_bae2, 3); shl(edx, 0x8);                          /* shl edx, 0x8 */
            ii(0x1018_bae5, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1018_baea, 2); or(edx, eax);                           /* or edx, eax */
            ii(0x1018_baec, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1018_baee, 2); mov(memd_a32[ds, ecx], edx);            /* mov [ecx], edx */
            ii(0x1018_baf0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_baf1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_baf2, 1); retd(); return;                         /* ret */
        l_0x1018_baf3:
            ii(0x1018_baf3, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_baf8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1018_baf9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_bafa, 1); retd(); return;                         /* ret */
        }
    }
}

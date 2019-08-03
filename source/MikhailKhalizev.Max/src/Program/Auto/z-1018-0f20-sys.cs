using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c6208909-e960-4961-9c21-91ae6c9b6965")]
        public void /* sys */ Method_1018_0f20()
        {
            ii(0x1018_0f20, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_0f21, 1); pushd(edx);                             /* push edx */
            ii(0x1018_0f22, 5); mov(edx, 0x101b_e5ba);                  /* mov edx, 0x101be5ba */
            ii(0x1018_0f27, 5); calld(/* sys */ 0x1018_0f4d, 0x21);     /* call 0x10180f4d */
            ii(0x1018_0f2c, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1018_0f2e, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1018_0f31, 2); if(jzd(0x1018_0f4a, 0x17)) goto l_0x1018_0f4a; /* jz 0x10180f4a */
            ii(0x1018_0f33, 5); mov(edx, 0x101b_e5ba);                  /* mov edx, 0x101be5ba */
            ii(0x1018_0f38, 5); mov(eax, 0xa);                          /* mov eax, 0xa */
            ii(0x1018_0f3d, 5); calld(/* sys */ 0x1017_29f1, -0xe551);  /* call 0x101729f1 */
            ii(0x1018_0f42, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1018_0f45, 2); if(jnzd(0x1018_0f4a, 0x3)) goto l_0x1018_0f4a; /* jnz 0x10180f4a */
            ii(0x1018_0f47, 3); lea(eax, ebx + 0x1);                    /* lea eax, [ebx+0x1] */
        l_0x1018_0f4a:
            ii(0x1018_0f4a, 1); popd(edx);                              /* pop edx */
            ii(0x1018_0f4b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_0f4c, 1); retd(); return;                         /* ret */
        }
    }
}

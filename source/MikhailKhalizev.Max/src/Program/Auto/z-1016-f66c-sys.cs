using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f157eb0e-2dee-4da6-a3c8-e2a8239020b6")]
        public void /* sys */ Method_1016_f66c()
        {
            ii(0x1016_f66c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_f66d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_f66e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_f670, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1016_f672, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f674, 3); mov(ax, dx);                            /* mov ax, dx */
            ii(0x1016_f677, 3); sar(eax, 0x8);                          /* sar eax, 0x8 */
            ii(0x1016_f67a, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f67f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f684, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_f686, 5); calld(/* sys */ 0x1016_f518, -0x173);   /* call 0x1016f518 */
            ii(0x1016_f68b, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f68e, 3); setnz(al);                              /* setnz al */
            ii(0x1016_f691, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f696, 1); dec(eax);                               /* dec eax */
            ii(0x1016_f697, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f69a, 2); if(jzd(0x1016_f6b3, 0x17)) goto l_0x1016_f6b3; /* jz 0x1016f6b3 */
            ii(0x1016_f69c, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_f69e, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_f6a0, 2); mov(al, cl);                            /* mov al, cl */
            ii(0x1016_f6a2, 5); calld(/* sys */ 0x1016_f518, -0x18f);   /* call 0x1016f518 */
            ii(0x1016_f6a7, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1016_f6aa, 3); setnz(al);                              /* setnz al */
            ii(0x1016_f6ad, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1016_f6b2, 1); dec(eax);                               /* dec eax */
        l_0x1016_f6b3:
            ii(0x1016_f6b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_f6b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_f6b5, 1); retd(); return;                         /* ret */
        }
    }
}

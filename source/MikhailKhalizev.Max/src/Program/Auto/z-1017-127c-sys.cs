using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bd3e8396-ce45-4dd1-98f5-bed306250c9e")]
        public void /* sys */ Method_1017_127c()
        {
            ii(0x1017_127c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_127d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1017_127e, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1017_1280, 2); mov(ecx, edx);                          /* mov ecx, edx */
            ii(0x1017_1282, 5); calld(/* sys */ 0x1017_1f05, 0xc7e);    /* call 0x10171f05 */
            ii(0x1017_1287, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1017_1289, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_128c, 2); if(jzd(0x1017_12ae, 0x20)) goto l_0x1017_12ae; /* jz 0x101712ae */
            ii(0x1017_128e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1017_1290, 5); calld(/* sys */ 0x1017_1f05, 0xc70);    /* call 0x10171f05 */
            ii(0x1017_1295, 3); cmp(eax, -0x1 /* 0xff */);              /* cmp eax, 0xffffffff */
            ii(0x1017_1298, 2); if(jzd(0x1017_12ae, 0x14)) goto l_0x1017_12ae; /* jz 0x101712ae */
            ii(0x1017_129a, 2); mov(ebx, edx);                          /* mov ebx, edx */
            ii(0x1017_129c, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1017_12a1, 3); shl(ebx, 0x8);                          /* shl ebx, 0x8 */
            ii(0x1017_12a4, 2); or(ebx, eax);                           /* or ebx, eax */
            ii(0x1017_12a6, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_12a8, 3); mov(memw_a32[ds, ecx], bx);             /* mov [ecx], bx */
            ii(0x1017_12ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_12ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_12ad, 1); retd(); return;                         /* ret */
        l_0x1017_12ae:
            ii(0x1017_12ae, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1017_12b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1017_12b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_12b5, 1); retd(); return;                         /* ret */
        }
    }
}

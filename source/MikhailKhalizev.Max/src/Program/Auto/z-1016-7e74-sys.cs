using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9becab58-aea6-4f1f-bb17-10d8c785bdd6")]
        public void /* sys */ Method_1016_7e74()
        {
            ii(0x1016_7e74, 1); pushd(esi);                             /* push esi */
            ii(0x1016_7e75, 1); pushd(edi);                             /* push edi */
            ii(0x1016_7e76, 5); calld(/* sys */ 0x1016_7dac, -0xcf);    /* call 0x10167dac */
            ii(0x1016_7e7b, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_7e82, 2); if(jzd(0x1016_7e88, 0x4)) goto l_0x1016_7e88; /* jz 0x10167e88 */
            ii(0x1016_7e84, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7e86, 2); if(jnzd(0x1016_7e90, 0x8)) goto l_0x1016_7e90; /* jnz 0x10167e90 */
        l_0x1016_7e88:
            ii(0x1016_7e88, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_7e8d, 1); popd(edi);                              /* pop edi */
            ii(0x1016_7e8e, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7e8f, 1); retd(); return;                         /* ret */
        l_0x1016_7e90:
            ii(0x1016_7e90, 2); mov(edi, edx);                          /* mov edi, edx */
            ii(0x1016_7e92, 3); lea(esi, eax + 0x8);                    /* lea esi, [eax+0x8] */
            ii(0x1016_7e95, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_7e97, 1); movsd_a32();                            /* movsd */
            ii(0x1016_7e98, 1); movsd_a32();                            /* movsd */
            ii(0x1016_7e99, 1); movsd_a32();                            /* movsd */
            ii(0x1016_7e9a, 1); movsd_a32();                            /* movsd */
            ii(0x1016_7e9b, 1); popd(edi);                              /* pop edi */
            ii(0x1016_7e9c, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7e9d, 1); retd(); return;                         /* ret */
        }
    }
}

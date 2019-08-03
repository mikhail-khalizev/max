using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("47fecc1b-21b2-4f1c-b807-06394a08ee6a")]
        public void /* sys */ Method_1018_b764()
        {
            ii(0x1018_b764, 1); pushd(ebx);                             /* push ebx */
            ii(0x1018_b765, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1018_b768, 6); cmp(memd_a32[ds, eax], 0xfeba_feba);    /* cmp dword [eax], 0xfebafeba */
            ii(0x1018_b76e, 2); if(jnzd(0x1018_b783, 0x13)) goto l_0x1018_b783; /* jnz 0x1018b783 */
            ii(0x1018_b770, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1018_b772, 5); calld(/* sys */ 0x1018_b6e0, -0x97);    /* call 0x1018b6e0 */
            ii(0x1018_b777, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_b779, 2); if(jnzd(0x1018_b783, 0x8)) goto l_0x1018_b783; /* jnz 0x1018b783 */
            ii(0x1018_b77b, 3); mov(eax, memd_a32[ss, esp]);            /* mov eax, [esp] */
            ii(0x1018_b77e, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1018_b781, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_b782, 1); retd(); return;                         /* ret */
        l_0x1018_b783:
            ii(0x1018_b783, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_b788, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1018_b78b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1018_b78c, 1); retd(); return;                         /* ret */
        }
    }
}

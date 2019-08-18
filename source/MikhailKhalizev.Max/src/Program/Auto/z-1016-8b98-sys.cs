using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a600259b-8533-4709-b7e0-ff2a02a24261")]
        public void /* sys */ Method_1016_8b98()
        {
            ii(0x1016_8b98, 1); pushd(esi);                             /* push esi */
            ii(0x1016_8b99, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_8b9b, 7); cmp(memd_a32[ds, 0x101b_ddbc], 0);      /* cmp dword [0x101bddbc], 0x0 */
            ii(0x1016_8ba2, 2); if(jnzd(0x1016_8bad, 0x9)) goto l_0x1016_8bad; /* jnz 0x10168bad */
            ii(0x1016_8ba4, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_8ba9, 1); popd(esi);                              /* pop esi */
            ii(0x1016_8baa, 3); retd(0x4); return;                      /* ret 0x4 */
        l_0x1016_8bad:
            ii(0x1016_8bad, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1016_8baf, 5); calld(/* sys */ 0x1016_7f00, -0xcb4);   /* call 0x10167f00 */
            ii(0x1016_8bb4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_8bb6, 2); if(jnzd(0x1016_8bc1, 0x9)) goto l_0x1016_8bc1; /* jnz 0x10168bc1 */
            ii(0x1016_8bb8, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_8bbd, 1); popd(esi);                              /* pop esi */
            ii(0x1016_8bbe, 3); retd(0x4); return;                      /* ret 0x4 */
        l_0x1016_8bc1:
            ii(0x1016_8bc1, 3); mov(memd_a32[ds, eax + 0x50], esi);     /* mov [eax+0x50], esi */
            ii(0x1016_8bc4, 3); mov(memd_a32[ds, eax + 0x54], ebx);     /* mov [eax+0x54], ebx */
            ii(0x1016_8bc7, 3); mov(memd_a32[ds, eax + 0x58], ecx);     /* mov [eax+0x58], ecx */
            ii(0x1016_8bca, 4); mov(ebx, memd_a32[ss, esp + 0x8]);      /* mov ebx, [esp+0x8] */
            ii(0x1016_8bce, 3); mov(memd_a32[ds, eax + 0x5c], ebx);     /* mov [eax+0x5c], ebx */
            ii(0x1016_8bd1, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1016_8bd3, 1); popd(esi);                              /* pop esi */
            ii(0x1016_8bd4, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}

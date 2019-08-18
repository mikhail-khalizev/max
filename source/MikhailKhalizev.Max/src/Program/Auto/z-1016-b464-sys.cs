using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("329b2f83-dac3-46f8-af48-5fbbce5d8744")]
        public void /* sys */ Method_1016_b464()
        {
            ii(0x1016_b464, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b465, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b466, 7); cmp(memd_a32[ds, 0x101c_fb58], 0);      /* cmp dword [0x101cfb58], 0x0 */
            ii(0x1016_b46d, 2); if(jnzd(0x1016_b49a, 0x2b)) goto l_0x1016_b49a; /* jnz 0x1016b49a */
            ii(0x1016_b46f, 10); mov(memd_a32[ds, 0x101c_fb58], 0x1);   /* mov dword [0x101cfb58], 0x1 */
            ii(0x1016_b479, 6); calld_abs(memd_a32[ds, 0x101c_fb74]);   /* call dword [0x101cfb74] */
            ii(0x1016_b47f, 2); mov(edx, eax);                          /* mov edx, eax */
        l_0x1016_b481:
            ii(0x1016_b481, 5); calld(/* sys */ 0x1016_b208, -0x27e);   /* call 0x1016b208 */
            ii(0x1016_b486, 3); cmp(eax, 0x1b);                         /* cmp eax, 0x1b */
            ii(0x1016_b489, 2); if(jnzd(0x1016_b481, -0xa)) goto l_0x1016_b481; /* jnz 0x1016b481 */
            ii(0x1016_b48b, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1016_b48d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b48f, 6); mov(memd_a32[ds, 0x101c_fb58], ecx);    /* mov [0x101cfb58], ecx */
            ii(0x1016_b495, 5); calld(/* sys */ 0x1016_6990, -0x4b0a);  /* call 0x10166990 */
        l_0x1016_b49a:
            ii(0x1016_b49a, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b49b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b49c, 1); retd(); return;                         /* ret */
        }
    }
}

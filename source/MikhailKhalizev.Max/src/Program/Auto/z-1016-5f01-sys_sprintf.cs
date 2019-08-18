using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5f01-2247a737")]
        public void /* sys */ sys_sprintf()
        {
            ii(0x1016_5f01, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_5f02, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_5f03, 1); pushd(edx);                             /* push edx */
            ii(0x1016_5f04, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_5f07, 4); lea(eax, esp + 0x1c);                   /* lea eax, [esp+0x1c] */
            ii(0x1016_5f0b, 5); mov(ecx, /* sys */ 0x1016_5eee);        /* mov ecx, 0x10165eee */
            ii(0x1016_5f10, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1016_5f12, 4); mov(edx, memd_a32[ss, esp + 0x18]);     /* mov edx, [esp+0x18] */
            ii(0x1016_5f16, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_5f19, 4); mov(eax, memd_a32[ss, esp + 0x14]);     /* mov eax, [esp+0x14] */
            ii(0x1016_5f1d, 5); calld(/* sys */ 0x1018_10e4, 0x1_b1c2); /* call 0x101810e4 */
            ii(0x1016_5f22, 4); mov(edx, memd_a32[ss, esp + 0x14]);     /* mov edx, [esp+0x14] */
            ii(0x1016_5f26, 4); mov(memb_a32[ds, edx + eax], 0);        /* mov byte [edx+eax], 0x0 */
            ii(0x1016_5f2a, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_5f2d, 1); popd(edx);                              /* pop edx */
            ii(0x1016_5f2e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_5f2f, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_5f30, 1); retd(); return;                         /* ret */
        }
    }
}

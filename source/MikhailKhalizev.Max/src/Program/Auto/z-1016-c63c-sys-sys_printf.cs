using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7b1218ba-3108-4081-8313-092a61c8b5c8")]
        public void /* sys */ sys_printf()
        {
            ii(0x1016_c63c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_c63d, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c63e, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_c641, 4); lea(eax, esp + 0x14);                   /* lea eax, [esp+0x14] */
            ii(0x1016_c645, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1016_c647, 4); mov(edx, memd_a32[ss, esp + 0x10]);     /* mov edx, [esp+0x10] */
            ii(0x1016_c64b, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1016_c64e, 5); mov(eax, 0x101b_e5ba);                  /* mov eax, 0x101be5ba */
            ii(0x1016_c653, 5); calld(/* sys */ 0x1018_7da3, 0x1b74b);  /* call 0x10187da3 */
            ii(0x1016_c658, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_c65b, 1); popd(edx);                              /* pop edx */
            ii(0x1016_c65c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_c65d, 1); retd(); return;                         /* ret */
        }
    }
}

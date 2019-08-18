using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d471e636-bc28-4314-bd48-3210af5bef71")]
        public void /* sys */ Method_1017_913b()
        {
            ii(0x1017_913b, 1); pushd(ebx);                             /* push ebx */
            ii(0x1017_913c, 1); pushd(edx);                             /* push edx */
            ii(0x1017_913d, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_9140, 4); lea(eax, esp + 0x18);                   /* lea eax, [esp+0x18] */
            ii(0x1017_9144, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_9146, 4); mov(edx, memd_a32[ss, esp + 0x14]);     /* mov edx, [esp+0x14] */
            ii(0x1017_914a, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1017_914d, 4); mov(eax, memd_a32[ss, esp + 0x10]);     /* mov eax, [esp+0x10] */
            ii(0x1017_9151, 5); calld(/* sys */ 0x1018_7da3, 0xec4d);   /* call 0x10187da3 */
            ii(0x1017_9156, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_9159, 1); popd(edx);                              /* pop edx */
            ii(0x1017_915a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1017_915b, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_913b-cf611540")]
        public void /* sys */ Method_1017_913b()
        {
            ii(0x1017_913b, 1); push(ebx);                              /* push ebx */
            ii(0x1017_913c, 1); push(edx);                              /* push edx */
            ii(0x1017_913d, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1017_9140, 4); lea(eax, esp + 0x18);                   /* lea eax, [esp+0x18] */
            ii(0x1017_9144, 2); mov(ebx, esp);                          /* mov ebx, esp */
            ii(0x1017_9146, 4); mov(edx, memd[ss, esp + 0x14]);         /* mov edx, [esp+0x14] */
            ii(0x1017_914a, 3); mov(memd[ss, esp], eax);                /* mov [esp], eax */
            ii(0x1017_914d, 4); mov(eax, memd[ss, esp + 0x10]);         /* mov eax, [esp+0x10] */
            ii(0x1017_9151, 5); call(/* sys */ 0x1018_7da3, 0xec4d);    /* call 0x10187da3 */
            ii(0x1017_9156, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1017_9159, 1); pop(edx);                               /* pop edx */
            ii(0x1017_915a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1017_915b, 1); ret();                                  /* ret */
        }
    }
}

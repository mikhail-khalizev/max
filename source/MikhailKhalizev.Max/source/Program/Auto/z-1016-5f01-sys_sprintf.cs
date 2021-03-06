using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_5f01-2247a737")]
        public void /* sys */ sys_sprintf()
        {
            ii(0x1016_5f01, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_5f02, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_5f03, 1);  push(edx);                            /* push edx */
            ii(0x1016_5f04, 3);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1016_5f07, 4);  lea(eax, memd[ss, esp + 28]);         /* lea eax, [esp+0x1c] */
            ii(0x1016_5f0b, 5);  mov(ecx, /* sys */ 0x1016_5eee);      /* mov ecx, 0x10165eee */
            ii(0x1016_5f10, 2);  mov(ebx, esp);                        /* mov ebx, esp */
            ii(0x1016_5f12, 4);  mov(edx, memd[ss, esp + 24]);         /* mov edx, [esp+0x18] */
            ii(0x1016_5f16, 3);  mov(memd[ss, esp], eax);              /* mov [esp], eax */
            ii(0x1016_5f19, 4);  mov(eax, memd[ss, esp + 20]);         /* mov eax, [esp+0x14] */
            ii(0x1016_5f1d, 5);  call(/* sys */ 0x1018_10e4, 0x1_b1c2);/* call 0x101810e4 */
            ii(0x1016_5f22, 4);  mov(edx, memd[ss, esp + 20]);         /* mov edx, [esp+0x14] */
            ii(0x1016_5f26, 4);  mov(memb[ds, edx + eax], 0);          /* mov byte [edx+eax], 0x0 */
            ii(0x1016_5f2a, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1016_5f2d, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_5f2e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_5f2f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_5f30, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_de3a-e98ff83d")]
        public void /* sys */ Method_1017_de3a()
        {
            ii(0x1017_de3a, 1);  push(ebx);                            /* push ebx */
            ii(0x1017_de3b, 1);  push(ecx);                            /* push ecx */
            ii(0x1017_de3c, 1);  push(edx);                            /* push edx */
            ii(0x1017_de3d, 1);  push(esi);                            /* push esi */
            ii(0x1017_de3e, 1);  push(edi);                            /* push edi */
            ii(0x1017_de3f, 1);  push(ebp);                            /* push ebp */
            ii(0x1017_de40, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1017_de42, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1017_de48, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1017_de4b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1017_de4e, 5);  mov(memd[ds, 0x101c_0695], eax);      /* mov [0x101c0695], eax */
            ii(0x1017_de53, 3);  push(memd[ss, ebp - 8]);              /* push dword [ebp-0x8] */
            ii(0x1017_de56, 5);  call(/* sys */ 0x1019_4a3d, 0x1_6be2);/* call 0x10194a3d */
            ii(0x1017_de5b, 3);  add(esp, 4);                          /* add esp, 0x4 */
            ii(0x1017_de5e, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1017_de65, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1017_de68, 1);  leave();                              /* leave */
            ii(0x1017_de69, 1);  pop(edi);                             /* pop edi */
            ii(0x1017_de6a, 1);  pop(esi);                             /* pop esi */
            ii(0x1017_de6b, 1);  pop(edx);                             /* pop edx */
            ii(0x1017_de6c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1017_de6d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1017_de6e, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_531c-44b9eb0e")]
        public void Method_100d_531c()
        {
            ii(0x100d_531c, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_531d, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_531e, 1);  push(edx);                            /* push edx */
            ii(0x100d_531f, 1);  push(esi);                            /* push esi */
            ii(0x100d_5320, 1);  push(edi);                            /* push edi */
            ii(0x100d_5321, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_5322, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_5324, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_532a, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_532e, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_5331, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_5333, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_5334, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_5335, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_5336, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_5337, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5338, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5339, 1);  ret();                                /* ret */
        }
    }
}

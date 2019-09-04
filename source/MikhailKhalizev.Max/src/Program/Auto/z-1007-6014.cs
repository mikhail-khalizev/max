using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6014-b70b8a0f")]
        public void Method_1007_6014()
        {
            ii(0x1007_6014, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6015, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6016, 1);  push(edx);                            /* push edx */
            ii(0x1007_6017, 1);  push(esi);                            /* push esi */
            ii(0x1007_6018, 1);  push(edi);                            /* push edi */
            ii(0x1007_6019, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_601a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_601c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1007_6022, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1007_6026, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1007_6029, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_602b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_602c, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_602d, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_602e, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_602f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6030, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6031, 1);  ret();                                /* ret */
        }
    }
}

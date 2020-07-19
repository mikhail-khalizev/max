using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6034-b70b8a0f")]
        public void Method_1007_6034()
        {
            ii(0x1007_6034, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6035, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6036, 1);  push(edx);                            /* push edx */
            ii(0x1007_6037, 1);  push(esi);                            /* push esi */
            ii(0x1007_6038, 1);  push(edi);                            /* push edi */
            ii(0x1007_6039, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_603a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_603c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1007_6042, 4);  mov(memb[ss, ebp - 4], 0);            /* mov byte [ebp-0x4], 0x0 */
            ii(0x1007_6046, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1007_6049, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_604b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_604c, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_604d, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_604e, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_604f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6050, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6051, 1);  ret();                                /* ret */
        }
    }
}

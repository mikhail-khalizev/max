using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_19d0-c502b1ca")]
        public void Method_1013_19d0()
        {
            ii(0x1013_19d0, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_19d1, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_19d2, 1);  push(edx);                            /* push edx */
            ii(0x1013_19d3, 1);  push(esi);                            /* push esi */
            ii(0x1013_19d4, 1);  push(edi);                            /* push edi */
            ii(0x1013_19d5, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_19d6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_19d8, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_19de, 7);  mov(memd[ss, ebp - 4], 5);            /* mov dword [ebp-0x4], 0x5 */
            ii(0x1013_19e5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_19e8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_19ea, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_19eb, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_19ec, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_19ed, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_19ee, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_19ef, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_19f0, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a4fc-c502b1ca")]
        public void Method_1008_a4fc()
        {
            ii(0x1008_a4fc, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a4fd, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a4fe, 1);  push(edx);                            /* push edx */
            ii(0x1008_a4ff, 1);  push(esi);                            /* push esi */
            ii(0x1008_a500, 1);  push(edi);                            /* push edi */
            ii(0x1008_a501, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a502, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a504, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1008_a50a, 7);  mov(memd[ss, ebp - 4], 5);            /* mov dword [ebp-0x4], 0x5 */
            ii(0x1008_a511, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a514, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a516, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a517, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a518, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a519, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a51a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a51b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a51c, 1);  ret();                                /* ret */
        }
    }
}

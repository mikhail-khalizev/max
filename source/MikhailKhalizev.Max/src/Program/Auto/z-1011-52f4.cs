using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_52f4-7e93caef")]
        public void Method_1011_52f4()
        {
            ii(0x1011_52f4, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_52f5, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_52f6, 1);  push(edx);                            /* push edx */
            ii(0x1011_52f7, 1);  push(esi);                            /* push esi */
            ii(0x1011_52f8, 1);  push(edi);                            /* push edi */
            ii(0x1011_52f9, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_52fa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_52fc, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_5302, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1011_5309, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_530c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_530e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_530f, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_5310, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_5311, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_5312, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_5313, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_5314, 1);  ret();                                /* ret */
        }
    }
}

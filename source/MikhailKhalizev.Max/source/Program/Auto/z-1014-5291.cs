using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5291-2f95669a")]
        public void Method_1014_5291()
        {
            ii(0x1014_5291, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1014_5296, 5);  call(Definitions.sys_check_available_stack_size, 0x2_0ab7);/* call 0x10165d52 */
            ii(0x1014_529b, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_529c, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_529d, 1);  push(esi);                            /* push esi */
            ii(0x1014_529e, 1);  push(edi);                            /* push edi */
            ii(0x1014_529f, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_52a0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_52a2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_52a8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_52ab, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_52ae, 5);  mov(edx, StringDefinitions.ExpectingAString);/* mov edx, 0x101acfba */
            ii(0x1014_52b3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_52b6, 5);  call(0x1014_5151, -0x16a);            /* call 0x10145151 */
            ii(0x1014_52bb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_52be, 5);  call(Definitions.my_string_ctor, -0x37db);/* call 0x10141ae8 */
            ii(0x1014_52c3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_52c6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_52c8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_52c9, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_52ca, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_52cb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_52cc, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_52cd, 1);  ret();                                /* ret */
        }
    }
}

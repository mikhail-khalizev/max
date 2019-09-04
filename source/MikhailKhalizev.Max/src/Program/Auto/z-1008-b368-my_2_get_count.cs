using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b368-46c56022")]
        public void my_2_get_count()
        {
            ii(0x1008_b368, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_b36d, 5);  call(Definitions.sys_check_available_stack_size, 0xd_a9e0);/* call 0x10165d52 */
            ii(0x1008_b372, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b373, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b374, 1);  push(edx);                            /* push edx */
            ii(0x1008_b375, 1);  push(esi);                            /* push esi */
            ii(0x1008_b376, 1);  push(edi);                            /* push edi */
            ii(0x1008_b377, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b378, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b37a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_b380, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_b383, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b386, 5);  call(0x1008_b410, 0x85);              /* call 0x1008b410 */
            ii(0x1008_b38b, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1008_b38e, 5);  call(Definitions.my_3_get_count, 0xed);/* call 0x1008b480 */
            ii(0x1008_b393, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_b396, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_b399, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b39b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b39c, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b39d, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b39e, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_b39f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b3a0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b3a1, 1);  ret();                                /* ret */
        }
    }
}

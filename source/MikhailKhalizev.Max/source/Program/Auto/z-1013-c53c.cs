using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c53c-9fda567a")]
        public void Method_1013_c53c()
        {
            ii(0x1013_c53c, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_c541, 5);  call(Definitions.sys_check_available_stack_size, 0x2_980c);/* call 0x10165d52 */
            ii(0x1013_c546, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c547, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c548, 1);  push(esi);                            /* push esi */
            ii(0x1013_c549, 1);  push(edi);                            /* push edi */
            ii(0x1013_c54a, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c54b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c54d, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_c553, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c556, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c559, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_c55c, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c55f, 5);  call(0x1007_6d14, -0xc_5850);         /* call 0x10076d14 */
            ii(0x1013_c564, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c567, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1013_c56a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_c56d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c570, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_c573, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_c576, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c578, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c579, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c57a, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c57b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c57c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c57d, 1);  ret();                                /* ret */
        }
    }
}

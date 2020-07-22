using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7f44-2481b157")]
        public void Method_1014_7f44()
        {
            ii(0x1014_7f44, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1014_7f49, 5);  call(Definitions.sys_check_available_stack_size, 0x1_de04);/* call 0x10165d52 */
            ii(0x1014_7f4e, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_7f4f, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_7f50, 1);  push(esi);                            /* push esi */
            ii(0x1014_7f51, 1);  push(edi);                            /* push edi */
            ii(0x1014_7f52, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_7f53, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_7f55, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1014_7f5b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7f5e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_7f61, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_7f64, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7f67, 5);  call(0x1013_abc3, -0xd3a9);           /* call 0x1013abc3 */
            ii(0x1014_7f6c, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_7f6f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1014_7f72, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_7f75, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_7f78, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_7f7b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_7f7e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_7f80, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_7f81, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_7f82, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_7f83, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_7f84, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_7f85, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_bf1c-64b485fa")]
        public void Method_1013_bf1c()
        {
            ii(0x1013_bf1c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_bf21, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9e2c);/* call 0x10165d52 */
            ii(0x1013_bf26, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_bf27, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_bf28, 1);  push(esi);                            /* push esi */
            ii(0x1013_bf29, 1);  push(edi);                            /* push edi */
            ii(0x1013_bf2a, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_bf2b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_bf2d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_bf33, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_bf36, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_bf39, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bf3c, 5);  call(0x1013_bfc1, 0x80);              /* call 0x1013bfc1 */
            ii(0x1013_bf41, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_bf43, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bf46, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1013_bf49, 5);  call(0x1013_c404, 0x4b6);             /* call 0x1013c404 */
            ii(0x1013_bf4e, 3);  sub(eax, 4);                          /* sub eax, 0x4 */
            ii(0x1013_bf51, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_bf54, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_bf57, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_bf5a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_bf5d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_bf5f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_bf60, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_bf61, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_bf62, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_bf63, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_bf64, 1);  ret();                                /* ret */
        }
    }
}

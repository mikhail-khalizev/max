using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6564-60ccc84c")]
        public void Method_1013_6564()
        {
            ii(0x1013_6564, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_6569, 5);  call(Definitions.sys_check_available_stack_size, 0x2_f7e4);/* call 0x10165d52 */
            ii(0x1013_656e, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_656f, 1);  push(esi);                            /* push esi */
            ii(0x1013_6570, 1);  push(edi);                            /* push edi */
            ii(0x1013_6571, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_6572, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_6574, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_657a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_657d, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_6580, 3);  mov(memd[ss, ebp - 8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1013_6583, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_6586, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1013_658a, 3);  shl(eax, 2);                          /* shl eax, 0x2 */
            ii(0x1013_658d, 3);  mov(ebx, memd[ss, ebp - 12]);         /* mov ebx, [ebp-0xc] */
            ii(0x1013_6590, 3);  add(ebx, 8);                          /* add ebx, 0x8 */
            ii(0x1013_6593, 2);  add(eax, ebx);                        /* add eax, ebx */
            ii(0x1013_6595, 5);  call(0x100c_b77c, -0x6_ae1e);         /* call 0x100cb77c */
            ii(0x1013_659a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_659c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_659d, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_659e, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_659f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_65a0, 1);  ret();                                /* ret */
        }
    }
}

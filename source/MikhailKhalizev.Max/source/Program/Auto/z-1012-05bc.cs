using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_05bc-e4cf7b95")]
        public void Method_1012_05bc()
        {
            ii(0x1012_05bc, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1012_05c1, 5);  call(Definitions.sys_check_available_stack_size, 0x4_578c);/* call 0x10165d52 */
            ii(0x1012_05c6, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_05c7, 1);  push(esi);                            /* push esi */
            ii(0x1012_05c8, 1);  push(edi);                            /* push edi */
            ii(0x1012_05c9, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_05ca, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_05cc, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_05d2, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_05d5, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1012_05d8, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1012_05db, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x1012_05df, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1012_05e2, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_05e5, 5);  call(0x100c_d990, -0x5_2c5a);         /* call 0x100cd990 */
            ii(0x1012_05ea, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_05ec, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_05ed, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_05ee, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_05ef, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_05f0, 1);  ret();                                /* ret */
        }
    }
}

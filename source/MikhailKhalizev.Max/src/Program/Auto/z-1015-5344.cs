using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_5344-f39e3c43")]
        public void Method_1015_5344()
        {
            ii(0x1015_5344, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_5349, 5);  call(Definitions.sys_check_available_stack_size, 0x1_0a04);/* call 0x10165d52 */
            ii(0x1015_534e, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_534f, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_5350, 1);  push(esi);                            /* push esi */
            ii(0x1015_5351, 1);  push(edi);                            /* push edi */
            ii(0x1015_5352, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_5353, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_5355, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1015_535b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_535e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_5361, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_5364, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_5367, 5);  call(0x1013_acc5, -0x1_a6a7);         /* call 0x1013acc5 */
            ii(0x1015_536c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1015_536f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1015_5372, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_5374, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_5375, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_5376, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_5377, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_5378, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_5379, 1);  ret();                                /* ret */
        }
    }
}

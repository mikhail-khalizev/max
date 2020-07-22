using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_5346-acf24d4")]
        public void Method_1014_5346()
        {
            ii(0x1014_5346, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_534b, 5);  call(Definitions.sys_check_available_stack_size, 0x2_0a02);/* call 0x10165d52 */
            ii(0x1014_5350, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_5351, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_5352, 1);  push(edx);                            /* push edx */
            ii(0x1014_5353, 1);  push(esi);                            /* push esi */
            ii(0x1014_5354, 1);  push(edi);                            /* push edi */
            ii(0x1014_5355, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_5356, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_5358, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_535e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_5361, 5);  mov(edx, StringDefinitions.ExpectingA);/* mov edx, 0x101acff2 */
            ii(0x1014_5366, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_5369, 5);  call(0x1014_5151, -0x21d);            /* call 0x10145151 */
            ii(0x1014_536e, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_5375, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5378, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_537a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_537b, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_537c, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_537d, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_537e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_537f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_5380, 1);  ret();                                /* ret */
        }
    }
}

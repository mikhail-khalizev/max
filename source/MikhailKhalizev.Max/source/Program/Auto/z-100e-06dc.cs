using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_06dc-6c57397b")]
        public void Method_100e_06dc()
        {
            ii(0x100e_06dc, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_06e1, 5);  call(Definitions.sys_check_available_stack_size, 0x8_566c);/* call 0x10165d52 */
            ii(0x100e_06e6, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_06e7, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_06e8, 1);  push(esi);                            /* push esi */
            ii(0x100e_06e9, 1);  push(edi);                            /* push edi */
            ii(0x100e_06ea, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_06eb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_06ed, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100e_06f3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_06f6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_06f9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_06fc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_06ff, 5);  call(0x1013_ac03, 0x5_a4ff);          /* call 0x1013ac03 */
            ii(0x100e_0704, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0707, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_070a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_070d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0710, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_0713, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_0716, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0718, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0719, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_071a, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_071b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_071c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_071d, 1);  ret();                                /* ret */
        }
    }
}

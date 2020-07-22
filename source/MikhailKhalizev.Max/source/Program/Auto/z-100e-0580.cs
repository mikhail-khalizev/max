using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0580-ea0adc69")]
        public void Method_100e_0580()
        {
            ii(0x100e_0580, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_0585, 5);  call(Definitions.sys_check_available_stack_size, 0x8_57c8);/* call 0x10165d52 */
            ii(0x100e_058a, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_058b, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_058c, 1);  push(esi);                            /* push esi */
            ii(0x100e_058d, 1);  push(edi);                            /* push edi */
            ii(0x100e_058e, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_058f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0591, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100e_0597, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_059a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_059d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_05a0, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_05a3, 5);  call(0x1007_6cd0, -0x6_98d8);         /* call 0x10076cd0 */
            ii(0x100e_05a8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_05ab, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100e_05ae, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_05b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_05b4, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100e_05b7, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100e_05ba, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_05bc, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_05bd, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_05be, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_05bf, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_05c0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_05c1, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e30e-12c1c271")]
        public void Method_1012_e30e()
        {
            ii(0x1012_e30e, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_e313, 5);  call(Definitions.sys_check_available_stack_size, 0x3_7a3a);/* call 0x10165d52 */
            ii(0x1012_e318, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_e319, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_e31a, 1);  push(esi);                            /* push esi */
            ii(0x1012_e31b, 1);  push(edi);                            /* push edi */
            ii(0x1012_e31c, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_e31d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_e31f, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1012_e325, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_e328, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_e32b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_e32e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e331, 5);  call(0x1012_e2a7, -0x8f);             /* call 0x1012e2a7 */
            ii(0x1012_e336, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1012_e339:
            ii(0x1012_e339, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e33c, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e33f, 5);  call(Definitions.my_1_get_count, -0x8_2e6c);/* call 0x100ab4d8 */
            ii(0x1012_e344, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1012_e348, 2);  if(jle(0x1012_e36b, 0x21)) goto l_0x1012_e36b;/* jle 0x1012e36b */
            ii(0x1012_e34a, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e34e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e351, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e354, 5);  call(0x1013_18f8, 0x359f);            /* call 0x101318f8 */
            ii(0x1012_e359, 5);  call(0x1013_19f4, 0x3696);            /* call 0x101319f4 */
            ii(0x1012_e35e, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1012_e361, 2);  if(jnz(0x1012_e36b, 8)) goto l_0x1012_e36b;/* jnz 0x1012e36b */
            ii(0x1012_e363, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_e366, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
            ii(0x1012_e369, 2);  jmp(0x1012_e339, -0x32); goto l_0x1012_e339;/* jmp 0x1012e339 */
        l_0x1012_e36b:
            ii(0x1012_e36b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_e36e, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_e371, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_e374, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_e376, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_e377, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_e378, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_e379, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_e37a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_e37b, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_32a2-47bc01b")]
        public void Method_100f_32a2()
        {
            ii(0x100f_32a2, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100f_32a7, 5);  call(Definitions.sys_check_available_stack_size, 0x7_2aa6);/* call 0x10165d52 */
            ii(0x100f_32ac, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_32ad, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_32ae, 1);  push(esi);                            /* push esi */
            ii(0x100f_32af, 1);  push(edi);                            /* push edi */
            ii(0x100f_32b0, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_32b1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_32b3, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100f_32b9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100f_32bc, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100f_32bf, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100f_32c3, 1);  push(eax);                            /* push eax */
            ii(0x100f_32c4, 4);  movsx(eax, memw[ss, ebp - 8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100f_32c8, 1);  push(eax);                            /* push eax */
            ii(0x100f_32c9, 5);  mov(eax, StringDefinitions._33i33i);  /* mov eax, 0x101a2469 */
            ii(0x100f_32ce, 1);  push(eax);                            /* push eax */
            ii(0x100f_32cf, 3);  lea(eax, memd[ss, ebp - 20]);         /* lea eax, [ebp-0x14] */
            ii(0x100f_32d2, 1);  push(eax);                            /* push eax */
            ii(0x100f_32d3, 5);  call(Definitions.sys_sprintf, 0x7_2c29);/* call 0x10165f01 */
            ii(0x100f_32d8, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x100f_32db, 5);  mov(ecx, 0x15);                       /* mov ecx, 0x15 */
            ii(0x100f_32e0, 5);  mov(ebx, 0xa2);                       /* mov ebx, 0xa2 */
            ii(0x100f_32e5, 3);  lea(edx, memd[ss, ebp - 20]);         /* lea edx, [ebp-0x14] */
            ii(0x100f_32e8, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100f_32ea, 5);  call(0x100f_3176, -0x179);            /* call 0x100f3176 */
            ii(0x100f_32ef, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100f_32f1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_32f2, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_32f3, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_32f4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_32f5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_32f6, 1);  ret();                                /* ret */
        }
    }
}

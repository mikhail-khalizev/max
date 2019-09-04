using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_e2a7-ca4782c3")]
        public void Method_1012_e2a7()
        {
            ii(0x1012_e2a7, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1012_e2ac, 5);  call(Definitions.sys_check_available_stack_size, 0x3_7aa1);/* call 0x10165d52 */
            ii(0x1012_e2b1, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_e2b2, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_e2b3, 1);  push(esi);                            /* push esi */
            ii(0x1012_e2b4, 1);  push(edi);                            /* push edi */
            ii(0x1012_e2b5, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_e2b6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_e2b8, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1012_e2be, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_e2c1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_e2c4, 7);  mov(memd[ss, ebp - 12], 0);           /* mov dword [ebp-0xc], 0x0 */
            ii(0x1012_e2cb, 2);  jmp(0x1012_e2d3, 6); goto l_0x1012_e2d3;/* jmp 0x1012e2d3 */
        l_0x1012_e2cd:
            ii(0x1012_e2cd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_e2d0, 3);  inc(memd[ss, ebp - 12]);              /* inc dword [ebp-0xc] */
        l_0x1012_e2d3:
            ii(0x1012_e2d3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e2d6, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e2d9, 5);  call(Definitions.my_1_get_count, -0x8_2e06);/* call 0x100ab4d8 */
            ii(0x1012_e2de, 4);  cmp(ax, memw[ss, ebp - 12]);          /* cmp ax, [ebp-0xc] */
            ii(0x1012_e2e2, 2);  if(jle(0x1012_e2fd, 0x19)) goto l_0x1012_e2fd;/* jle 0x1012e2fd */
            ii(0x1012_e2e4, 4);  movsx(edx, memw[ss, ebp - 12]);       /* movsx edx, word [ebp-0xc] */
            ii(0x1012_e2e8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_e2eb, 3);  add(eax, 0x26);                       /* add eax, 0x26 */
            ii(0x1012_e2ee, 5);  call(0x1013_18f8, 0x3605);            /* call 0x101318f8 */
            ii(0x1012_e2f3, 5);  call(0x1013_19f4, 0x36fc);            /* call 0x101319f4 */
            ii(0x1012_e2f8, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1012_e2fb, 2);  if(jnz(0x1012_e2cd, -0x30)) goto l_0x1012_e2cd;/* jnz 0x1012e2cd */
        l_0x1012_e2fd:
            ii(0x1012_e2fd, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_e300, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_e303, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_e306, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_e308, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_e309, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_e30a, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_e30b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_e30c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_e30d, 1);  ret();                                /* ret */
        }
    }
}

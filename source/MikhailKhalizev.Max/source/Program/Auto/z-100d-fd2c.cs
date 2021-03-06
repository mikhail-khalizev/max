using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fd2c-b79926cc")]
        public void Method_100d_fd2c()
        {
            ii(0x100d_fd2c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100d_fd31, 5);  call(Definitions.sys_check_available_stack_size, 0x8_601c);/* call 0x10165d52 */
            ii(0x100d_fd36, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_fd37, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_fd38, 1);  push(esi);                            /* push esi */
            ii(0x100d_fd39, 1);  push(edi);                            /* push edi */
            ii(0x100d_fd3a, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_fd3b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_fd3d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100d_fd43, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_fd46, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_fd49, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_fd4d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_fd50, 6);  mov(eax, memd[ds, eax + 250]);        /* mov eax, [eax+0xfa] */
            ii(0x100d_fd56, 5);  call(0x1008_b104, -0x5_4c57);         /* call 0x1008b104 */
            ii(0x100d_fd5b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100d_fd5e, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100d_fd61, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_fd63, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_fd64, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_fd65, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_fd66, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_fd67, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_fd68, 1);  ret();                                /* ret */
        }
    }
}

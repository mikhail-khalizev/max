using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_fdbc-64f7baa8")]
        public void Method_1009_fdbc()
        {
            ii(0x1009_fdbc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_fdc1, 5);  call(Definitions.sys_check_available_stack_size, 0xc_5f8c);/* call 0x10165d52 */
            ii(0x1009_fdc6, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_fdc7, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_fdc8, 1);  push(esi);                            /* push esi */
            ii(0x1009_fdc9, 1);  push(edi);                            /* push edi */
            ii(0x1009_fdca, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_fdcb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_fdcd, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_fdd3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_fdd6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_fdd9, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_fddb, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_fdde, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_fde1, 5);  call(Definitions.my_dtor_0x101b_56fc, -0x1_71aa);/* call 0x10088c3c */
            ii(0x1009_fde6, 3);  sub(eax, 0x17);                       /* sub eax, 0x17 */
            ii(0x1009_fde9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_fdec, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_fdf1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_fdf4, 5);  call(0x100a_284c, 0x2a53);            /* call 0x100a284c */
            ii(0x1009_fdf9, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_fdfc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_fdff, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_fe02, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_fe05, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_fe07, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_fe08, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_fe09, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_fe0a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_fe0b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_fe0c, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9b82-1b9bac09")]
        public void Method_1015_9b82()
        {
            ii(0x1015_9b82, 5);  push(0x98);                           /* push 0x98 */
            ii(0x1015_9b87, 5);  call(Definitions.sys_check_available_stack_size, 0xc1c6);/* call 0x10165d52 */
            ii(0x1015_9b8c, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_9b8d, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_9b8e, 1);  push(esi);                            /* push esi */
            ii(0x1015_9b8f, 1);  push(edi);                            /* push edi */
            ii(0x1015_9b90, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_9b91, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_9b93, 6);  sub(esp, 0x80);                       /* sub esp, 0x80 */
            ii(0x1015_9b99, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9b9c, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9b9f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9ba2, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x1015_9ba5, 5);  mov(eax, 1);                          /* mov eax, 0x1 */
            ii(0x1015_9baa, 5);  call(0x100f_448c, -0x6_5723);         /* call 0x100f448c */
            ii(0x1015_9baf, 5);  call(0x100f_fc13, -0x5_9fa1);         /* call 0x100ffc13 */
            ii(0x1015_9bb4, 4);  or(memb[ss, ebp - 12], 1);            /* or byte [ebp-0xc], 0x1 */
            ii(0x1015_9bb8, 3);  mov(edx, memd[ss, ebp - 20]);         /* mov edx, [ebp-0x14] */
            ii(0x1015_9bbb, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x1015_9bbe, 5);  call(0x100e_1f02, -0x7_7cc1);         /* call 0x100e1f02 */
            ii(0x1015_9bc3, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1015_9bc6, 4);  and(memb[ss, ebp - 12], -2 /* 0xfe */);/* and byte [ebp-0xc], 0xfe */
            ii(0x1015_9bca, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x1015_9bcd, 5);  call(0x100e_2dc1, -0x7_6e11);         /* call 0x100e2dc1 */
            ii(0x1015_9bd2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1015_9bd4, 3);  lea(eax, memd[ss, ebp - 128]);        /* lea eax, [ebp-0x80] */
            ii(0x1015_9bd7, 5);  call(0x100e_2d1d, -0x7_6ebf);         /* call 0x100e2d1d */
            ii(0x1015_9bdc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_9bde, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_9bdf, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_9be0, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_9be1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_9be2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_9be3, 1);  ret();                                /* ret */
        }
    }
}

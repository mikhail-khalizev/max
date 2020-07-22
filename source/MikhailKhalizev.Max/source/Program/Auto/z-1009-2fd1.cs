using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_2fd1-a8972dc9")]
        public void Method_1009_2fd1()
        {
            ii(0x1009_2fd1, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_2fd6, 5);  call(Definitions.sys_check_available_stack_size, 0xd_2d77);/* call 0x10165d52 */
            ii(0x1009_2fdb, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_2fdc, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_2fdd, 1);  push(edx);                            /* push edx */
            ii(0x1009_2fde, 1);  push(esi);                            /* push esi */
            ii(0x1009_2fdf, 1);  push(edi);                            /* push edi */
            ii(0x1009_2fe0, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_2fe1, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_2fe3, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_2fe9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_2fec, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_2fef, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_2ff2, 5);  call(0x1013_a6f4, 0xa_76fd);          /* call 0x1013a6f4 */
            ii(0x1009_2ff7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_2ffa, 3);  add(eax, 0x21);                       /* add eax, 0x21 */
            ii(0x1009_2ffd, 5);  call(0x1013_a6f4, 0xa_76f2);          /* call 0x1013a6f4 */
            ii(0x1009_3002, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_3004, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_3007, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1009_300a, 5);  call(0x1008_afe4, -0x802b);           /* call 0x1008afe4 */
            ii(0x1009_300f, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_3012, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_3017, 5);  call(0x100a_5e27, 0x1_2e0b);          /* call 0x100a5e27 */
            ii(0x1009_301c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_301e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_301f, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_3020, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_3021, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_3022, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_3023, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_3024, 1);  ret();                                /* ret */
        }
    }
}

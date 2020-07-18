using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_718a-27e2579e")]
        public void Method_100e_718a()
        {
            ii(0x100e_718a, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_718f, 5);  call(Definitions.sys_check_available_stack_size, 0x7_ebbe);/* call 0x10165d52 */
            ii(0x100e_7194, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_7195, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_7196, 1);  push(esi);                            /* push esi */
            ii(0x100e_7197, 1);  push(edi);                            /* push edi */
            ii(0x100e_7198, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_7199, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_719b, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_71a1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_71a4, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_71a7, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_71aa, 3);  add(edx, 0x10);                       /* add edx, 0x10 */
            ii(0x100e_71ad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_71b0, 5);  call(0x1015_301f, 0x6_be6a);          /* call 0x1015301f */
            ii(0x100e_71b5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_71b7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_71b8, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_71b9, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_71ba, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_71bb, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_71bc, 1);  ret();                                /* ret */
        }
    }
}

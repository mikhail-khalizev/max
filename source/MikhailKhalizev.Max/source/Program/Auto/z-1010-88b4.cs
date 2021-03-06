using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_88b4-de819985")]
        public void Method_1010_88b4()
        {
            ii(0x1010_88b4, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x1010_88b9, 5);  call(Definitions.sys_check_available_stack_size, 0x5_d494);/* call 0x10165d52 */
            ii(0x1010_88be, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_88bf, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_88c0, 1);  push(edx);                            /* push edx */
            ii(0x1010_88c1, 1);  push(esi);                            /* push esi */
            ii(0x1010_88c2, 1);  push(edi);                            /* push edi */
            ii(0x1010_88c3, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_88c4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_88c6, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x1010_88cc, 5);  mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
            ii(0x1010_88d1, 5);  mov(ebx, 0xad);                       /* mov ebx, 0xad */
            ii(0x1010_88d6, 5);  mov(edx, 0xa4);                       /* mov edx, 0xa4 */
            ii(0x1010_88db, 5);  mov(eax, 0x101c_4e50);                /* mov eax, 0x101c4e50 */
            ii(0x1010_88e0, 5);  call(0x100d_53a4, -0x3_3541);         /* call 0x100d53a4 */
            ii(0x1010_88e5, 5);  mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
            ii(0x1010_88ea, 5);  mov(ebx, 8);                          /* mov ebx, 0x8 */
            ii(0x1010_88ef, 5);  mov(edx, 0xa2);                       /* mov edx, 0xa2 */
            ii(0x1010_88f4, 5);  mov(eax, 0x101c_4e54);                /* mov eax, 0x101c4e54 */
            ii(0x1010_88f9, 5);  call(0x100d_53a4, -0x3_355a);         /* call 0x100d53a4 */
            ii(0x1010_88fe, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_88ff, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_8900, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_8901, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_8902, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_8903, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_8904, 1);  ret();                                /* ret */
        }
    }
}

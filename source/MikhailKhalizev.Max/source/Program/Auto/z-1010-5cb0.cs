using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_5cb0-c7f52349")]
        public void Method_1010_5cb0()
        {
            ii(0x1010_5cb0, 5);  push(0x2c);                           /* push 0x2c */
            ii(0x1010_5cb5, 5);  call(Definitions.sys_check_available_stack_size, 0x6_0098);/* call 0x10165d52 */
            ii(0x1010_5cba, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_5cbb, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_5cbc, 1);  push(edx);                            /* push edx */
            ii(0x1010_5cbd, 1);  push(esi);                            /* push esi */
            ii(0x1010_5cbe, 1);  push(edi);                            /* push edi */
            ii(0x1010_5cbf, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_5cc0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_5cc2, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1010_5cc8, 5);  mov(eax, 0x101b_8b74);                /* mov eax, 0x101b8b74 */
            ii(0x1010_5ccd, 5);  call(/* sys */ 0x1016_611f, 0x6_044d);/* call 0x1016611f */
            ii(0x1010_5cd2, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x1010_5cd7, 5);  call(0x1010_5d15, 0x39);              /* call 0x10105d15 */
            ii(0x1010_5cdc, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_5cdf, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1010_5ce2, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_5ce5, 10);  mov(memd[ds, 0x101b_8b7c], 1);       /* mov dword [0x101b8b7c], 0x1 */
            ii(0x1010_5cef, 5);  mov(eax, 0x101c_3c4c);                /* mov eax, 0x101c3c4c */
            ii(0x1010_5cf4, 5);  call(0x1010_64f8, 0x7ff);             /* call 0x101064f8 */
            ii(0x1010_5cf9, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_5cfc, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_5cff, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_5d02, 10);  mov(memd[ds, 0x101b_8b7c], 2);       /* mov dword [0x101b8b7c], 0x2 */
            ii(0x1010_5d0c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_5d0e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_5d0f, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_5d10, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_5d11, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_5d12, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_5d13, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_5d14, 1);  ret();                                /* ret */
        }
    }
}

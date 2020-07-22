using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3a0b-d445bb78")]
        public void Method_100b_3a0b()
        {
            ii(0x100b_3a0b, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100b_3a10, 5);  call(Definitions.sys_check_available_stack_size, 0xb_233d);/* call 0x10165d52 */
            ii(0x100b_3a15, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_3a16, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_3a17, 1);  push(esi);                            /* push esi */
            ii(0x100b_3a18, 1);  push(edi);                            /* push edi */
            ii(0x100b_3a19, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_3a1a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_3a1c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100b_3a22, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_3a25, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100b_3a28, 5);  mov(edx, StringDefinitions.ActivateUnit);/* mov edx, 0x101a10e1 */
            ii(0x100b_3a2d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3a30, 5);  call(Definitions.sys_strcpy, 0xb_249a);/* call 0x10165ecf */
            ii(0x100b_3a35, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_3a38, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100b_3a3b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100b_3a3e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_3a40, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_3a41, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_3a42, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_3a43, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_3a44, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_3a45, 1);  ret();                                /* ret */
        }
    }
}

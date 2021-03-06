using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6a34-d7e99d6b")]
        public void Method_1007_6a34()
        {
            ii(0x1007_6a34, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6a39, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f314);/* call 0x10165d52 */
            ii(0x1007_6a3e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6a3f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6a40, 1);  push(esi);                            /* push esi */
            ii(0x1007_6a41, 1);  push(edi);                            /* push edi */
            ii(0x1007_6a42, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6a43, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6a45, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_6a4b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6a4e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_6a51, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_6a54, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6a57, 5);  call(0x1013_ac7d, 0xc_4221);          /* call 0x1013ac7d */
            ii(0x1007_6a5c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_6a5f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_6a62, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6a64, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6a65, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6a66, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6a67, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6a68, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6a69, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_1b38-14c2d45c")]
        public void Method_1013_1b38()
        {
            ii(0x1013_1b38, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_1b3d, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4210);/* call 0x10165d52 */
            ii(0x1013_1b42, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1b43, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1b44, 1);  push(edx);                            /* push edx */
            ii(0x1013_1b45, 1);  push(esi);                            /* push esi */
            ii(0x1013_1b46, 1);  push(edi);                            /* push edi */
            ii(0x1013_1b47, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1b48, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1b4a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_1b50, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_1b53, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_1b56, 5);  call(0x1007_6c30, -0xb_af2b);         /* call 0x10076c30 */
            ii(0x1013_1b5b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1b5e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_1b61, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1b63, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_1b64, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_1b65, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_1b66, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_1b67, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_1b68, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_1b69, 1);  ret();                                /* ret */
        }
    }
}

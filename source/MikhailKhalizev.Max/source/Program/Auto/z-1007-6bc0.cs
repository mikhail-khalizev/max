using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6bc0-b0b4ca89")]
        public void Method_1007_6bc0()
        {
            ii(0x1007_6bc0, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1007_6bc5, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f188);/* call 0x10165d52 */
            ii(0x1007_6bca, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6bcb, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6bcc, 1);  push(edx);                            /* push edx */
            ii(0x1007_6bcd, 1);  push(esi);                            /* push esi */
            ii(0x1007_6bce, 1);  push(edi);                            /* push edi */
            ii(0x1007_6bcf, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6bd0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6bd2, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1007_6bd8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6bdb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6bde, 5);  call(0x1007_6c68, 0x85);              /* call 0x10076c68 */
            ii(0x1007_6be3, 3);  lea(edx, memd[ds, eax + 14]);         /* lea edx, [eax+0xe] */
            ii(0x1007_6be6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6be9, 5);  call(0x1013_acc5, 0xc_40d7);          /* call 0x1013acc5 */
            ii(0x1007_6bee, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6bf0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6bf1, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6bf2, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6bf3, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6bf4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6bf5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6bf6, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c1ce-bec03a41")]
        public void Method_1013_c1ce()
        {
            ii(0x1013_c1ce, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_c1d3, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9b7a);/* call 0x10165d52 */
            ii(0x1013_c1d8, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c1d9, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c1da, 1);  push(esi);                            /* push esi */
            ii(0x1013_c1db, 1);  push(edi);                            /* push edi */
            ii(0x1013_c1dc, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c1dd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c1df, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_c1e5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c1e8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c1eb, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_c1ee, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c1f1, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1013_c1f4, 5);  call(0x1013_c6f4, 0x4fb);             /* call 0x1013c6f4 */
            ii(0x1013_c1f9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c1fc, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x1013_c1ff, 5);  call(0x1007_6b90, -0xc_5674);         /* call 0x10076b90 */
            ii(0x1013_c204, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1013_c207, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_c20a, 5);  call(0x1013_c868, 0x659);             /* call 0x1013c868 */
            ii(0x1013_c20f, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c211, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c212, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c213, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c214, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c215, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c216, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6af0-1592b52f")]
        public void my_ctor_0x101b_4184()
        {
            ii(0x1007_6af0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6af5, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f258);/* call 0x10165d52 */
            ii(0x1007_6afa, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6afb, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6afc, 1);  push(edx);                            /* push edx */
            ii(0x1007_6afd, 1);  push(esi);                            /* push esi */
            ii(0x1007_6afe, 1);  push(edi);                            /* push edi */
            ii(0x1007_6aff, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6b00, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6b02, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6b08, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6b0b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6b0e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6b11, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6b14, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6b16, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6b17, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6b18, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6b19, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6b1a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6b1b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6b1c, 1);  ret();                                /* ret */
        }
    }
}

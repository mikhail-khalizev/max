using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6e44-10c64fb")]
        public void my_ctor_0x101b_6edc()
        {
            ii(0x1007_6e44, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6e49, 5);  call(Definitions.sys_check_available_stack_size, 0xe_ef04);/* call 0x10165d52 */
            ii(0x1007_6e4e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6e4f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6e50, 1);  push(edx);                            /* push edx */
            ii(0x1007_6e51, 1);  push(esi);                            /* push esi */
            ii(0x1007_6e52, 1);  push(edi);                            /* push edi */
            ii(0x1007_6e53, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6e54, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6e56, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6e5c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6e5f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6e62, 6);  mov(memd[ds, eax], 0);                /* mov dword [eax], 0x0 */
            ii(0x1007_6e68, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6e6b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6e6e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6e71, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_6e73, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6e74, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6e75, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6e76, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6e77, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6e78, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6e79, 1);  ret();                                /* ret */
        }
    }
}

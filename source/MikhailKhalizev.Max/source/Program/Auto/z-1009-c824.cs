using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c824-57cf42ee")]
        public void Method_1009_c824()
        {
            ii(0x1009_c824, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1009_c829, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9524);/* call 0x10165d52 */
            ii(0x1009_c82e, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c82f, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c830, 1);  push(edx);                            /* push edx */
            ii(0x1009_c831, 1);  push(esi);                            /* push esi */
            ii(0x1009_c832, 1);  push(edi);                            /* push edi */
            ii(0x1009_c833, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c834, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c836, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_c83c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c83f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c842, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x2_5a03);/* call 0x10076e44 */
            ii(0x1009_c847, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c84a, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1009_c84d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c850, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c853, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_c856, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_c859, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c85b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c85c, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c85d, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c85e, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_c85f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c860, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c861, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_b3f4-1f8a25eb")]
        public void Method_100a_b3f4()
        {
            ii(0x100a_b3f4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_b3f9, 5);  call(Definitions.sys_check_available_stack_size, 0xb_a954);/* call 0x10165d52 */
            ii(0x100a_b3fe, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_b3ff, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_b400, 1);  push(edx);                            /* push edx */
            ii(0x100a_b401, 1);  push(esi);                            /* push esi */
            ii(0x100a_b402, 1);  push(edi);                            /* push edi */
            ii(0x100a_b403, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_b404, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_b406, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_b40c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b40f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b412, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x3_45d3);/* call 0x10076e44 */
            ii(0x100a_b417, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_b41a, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100a_b41d, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_b420, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_b423, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_b426, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_b429, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_b42b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_b42c, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_b42d, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_b42e, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_b42f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_b430, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_b431, 1);  ret();                                /* ret */
        }
    }
}

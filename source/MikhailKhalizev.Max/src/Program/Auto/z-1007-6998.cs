using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6998-b706bb49")]
        public void Method_1007_6998()
        {
            ii(0x1007_6998, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1007_699d, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f3b0);/* call 0x10165d52 */
            ii(0x1007_69a2, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_69a3, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_69a4, 1);  push(edx);                            /* push edx */
            ii(0x1007_69a5, 1);  push(esi);                            /* push esi */
            ii(0x1007_69a6, 1);  push(edi);                            /* push edi */
            ii(0x1007_69a7, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_69a8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_69aa, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1007_69b0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_69b3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_69b6, 5);  call(Definitions.my_ctor_0x101b_6edc, 0x489);/* call 0x10076e44 */
            ii(0x1007_69bb, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_69be, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1007_69c1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_69c4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_69c7, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1007_69ca, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1007_69cd, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_69cf, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_69d0, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_69d1, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_69d2, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_69d3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_69d4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_69d5, 1);  ret();                                /* ret */
        }
    }
}

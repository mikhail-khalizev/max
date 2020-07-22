using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b0a4-bb8d4e2d")]
        public void my_ctor_0x101b_3b58()
        {
            ii(0x1008_b0a4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_b0a9, 5);  call(Definitions.sys_check_available_stack_size, 0xd_aca4);/* call 0x10165d52 */
            ii(0x1008_b0ae, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b0af, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b0b0, 1);  push(edx);                            /* push edx */
            ii(0x1008_b0b1, 1);  push(esi);                            /* push esi */
            ii(0x1008_b0b2, 1);  push(edi);                            /* push edi */
            ii(0x1008_b0b3, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b0b4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b0b6, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_b0bc, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_b0bf, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b0c2, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x1_4283);/* call 0x10076e44 */
            ii(0x1008_b0c7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_b0ca, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1008_b0cd, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_b0d0, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b0d3, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_b0d6, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_b0d9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b0db, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b0dc, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b0dd, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b0de, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_b0df, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b0e0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b0e1, 1);  ret();                                /* ret */
        }
    }
}

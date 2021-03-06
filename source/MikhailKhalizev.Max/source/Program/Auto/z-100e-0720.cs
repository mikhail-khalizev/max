using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0720-e394271f")]
        public void Method_100e_0720()
        {
            ii(0x100e_0720, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100e_0725, 5);  call(Definitions.sys_check_available_stack_size, 0x8_5628);/* call 0x10165d52 */
            ii(0x100e_072a, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_072b, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_072c, 1);  push(edx);                            /* push edx */
            ii(0x100e_072d, 1);  push(esi);                            /* push esi */
            ii(0x100e_072e, 1);  push(edi);                            /* push edi */
            ii(0x100e_072f, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0730, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0732, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_0738, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_073b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_073e, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x6_98ff);/* call 0x10076e44 */
            ii(0x100e_0743, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0746, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x100e_0749, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_074c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_074f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_0752, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_0755, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0757, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0758, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_0759, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_075a, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_075b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_075c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_075d, 1);  ret();                                /* ret */
        }
    }
}

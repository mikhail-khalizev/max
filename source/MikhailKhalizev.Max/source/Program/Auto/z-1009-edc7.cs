using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_edc7-62a4c7c6")]
        public void Method_1009_edc7()
        {
            ii(0x1009_edc7, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_edcc, 5);  call(Definitions.sys_check_available_stack_size, 0xc_6f81);/* call 0x10165d52 */
            ii(0x1009_edd1, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_edd2, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_edd3, 1);  push(esi);                            /* push esi */
            ii(0x1009_edd4, 1);  push(edi);                            /* push edi */
            ii(0x1009_edd5, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_edd6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_edd8, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_edde, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ede1, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_ede4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_ede7, 3);  mov(eax, memd[ds, eax + 6]);          /* mov eax, [eax+0x6] */
            ii(0x1009_edea, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x1009_eded, 3);  add(eax, memd[ss, ebp - 8]);          /* add eax, [ebp-0x8] */
            ii(0x1009_edf0, 4);  mov(memb[ds, eax + 35], 0);           /* mov byte [eax+0x23], 0x0 */
            ii(0x1009_edf4, 5);  call(0x1008_a79c, -0x1_465d);         /* call 0x1008a79c */
            ii(0x1009_edf9, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_edfb, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1009_edfd, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_ee00, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_ee05, 5);  call(0x100a_53ac, 0x65a2);            /* call 0x100a53ac */
            ii(0x1009_ee0a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_ee0c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_ee0d, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_ee0e, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_ee0f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_ee10, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_ee11, 1);  ret();                                /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_aad4-829ee9c7")]
        public void Method_100a_aad4()
        {
            ii(0x100a_aad4, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100a_aad9, 5);  call(Definitions.sys_check_available_stack_size, 0xb_b274);/* call 0x10165d52 */
            ii(0x100a_aade, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_aadf, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_aae0, 1);  push(esi);                            /* push esi */
            ii(0x100a_aae1, 1);  push(edi);                            /* push edi */
            ii(0x100a_aae2, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_aae3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_aae5, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100a_aaeb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_aaee, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_aaf1, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x100a_aaf6, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100a_aafa, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_aafd, 5);  call(0x100c_d7e8, 0x2_2ce6);          /* call 0x100cd7e8 */
            ii(0x100a_ab02, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_ab05, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100a_ab08, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_ab0b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ab0e, 7);  mov(memd[ds, eax + 12], 0x101b_4fc8); /* mov dword [eax+0xc], 0x101b4fc8 */
            ii(0x100a_ab15, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_ab18, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_ab1b, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_ab1e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_ab20, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_ab21, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_ab22, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_ab23, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_ab24, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_ab25, 1);  ret();                                /* ret */
        }
    }
}

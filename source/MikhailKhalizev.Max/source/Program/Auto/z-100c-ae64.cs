using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ae64-30390bdb")]
        public void Method_100c_ae64()
        {
            ii(0x100c_ae64, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_ae69, 5);  call(Definitions.sys_check_available_stack_size, 0x9_aee4);/* call 0x10165d52 */
            ii(0x100c_ae6e, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_ae6f, 1);  push(esi);                            /* push esi */
            ii(0x100c_ae70, 1);  push(edi);                            /* push edi */
            ii(0x100c_ae71, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ae72, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ae74, 6);  sub(esp, 0x14);                       /* sub esp, 0x14 */
            ii(0x100c_ae7a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_ae7d, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_ae80, 3);  mov(memb[ss, ebp - 4], bl);           /* mov [ebp-0x4], bl */
            ii(0x100c_ae83, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x100c_ae85, 3);  mov(bl, memb[ss, ebp - 4]);           /* mov bl, [ebp-0x4] */
            ii(0x100c_ae88, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_ae8b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_ae8e, 5);  call(0x1013_afb8, 0x7_0125);          /* call 0x1013afb8 */
            ii(0x100c_ae93, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_ae96, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x100c_ae99, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_ae9c, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_ae9f, 3);  mov(memd[ss, ebp - 20], eax);         /* mov [ebp-0x14], eax */
            ii(0x100c_aea2, 3);  mov(eax, memd[ss, ebp - 20]);         /* mov eax, [ebp-0x14] */
            ii(0x100c_aea5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_aea7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_aea8, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_aea9, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_aeaa, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_aeab, 1);  ret();                                /* ret */
        }
    }
}

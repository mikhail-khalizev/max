using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_afc0-309a978b")]
        public void Method_100a_afc0()
        {
            ii(0x100a_afc0, 5); push(0x28);                             /* push 0x28 */
            ii(0x100a_afc5, 5); call(Definitions.sys_check_available_stack_size, 0xb_ad88); /* call 0x10165d52 */
            ii(0x100a_afca, 1); push(ebx);                              /* push ebx */
            ii(0x100a_afcb, 1); push(ecx);                              /* push ecx */
            ii(0x100a_afcc, 1); push(esi);                              /* push esi */
            ii(0x100a_afcd, 1); push(edi);                              /* push edi */
            ii(0x100a_afce, 1); push(ebp);                              /* push ebp */
            ii(0x100a_afcf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_afd1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_afd7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_afda, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_afdd, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_afe0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_afe3, 5); call(0x1007_6d14, -0x3_42d4);           /* call 0x10076d14 */
            ii(0x100a_afe8, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_afeb, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_afee, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100a_aff1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_aff4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_aff7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_affa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_affc, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_affd, 1); pop(edi);                               /* pop edi */
            ii(0x100a_affe, 1); pop(esi);                               /* pop esi */
            ii(0x100a_afff, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_b000, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_b001, 1); ret();                                  /* ret */
        }
    }
}

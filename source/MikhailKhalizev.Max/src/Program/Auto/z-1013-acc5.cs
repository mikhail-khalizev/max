using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_acc5-2b7ef5d7")]
        public void Method_1013_acc5()
        {
            ii(0x1013_acc5, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_acca, 5); call(Definitions.sys_check_available_stack_size, 0x2_b083); /* call 0x10165d52 */
            ii(0x1013_accf, 1); push(ebx);                              /* push ebx */
            ii(0x1013_acd0, 1); push(ecx);                              /* push ecx */
            ii(0x1013_acd1, 1); push(esi);                              /* push esi */
            ii(0x1013_acd2, 1); push(edi);                              /* push edi */
            ii(0x1013_acd3, 1); push(ebp);                              /* push ebp */
            ii(0x1013_acd4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_acd6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_acdc, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_acdf, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_ace2, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_ace5, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_ace7, 5); call(0x1013_ae28, 0x13c);               /* call 0x1013ae28 */
            ii(0x1013_acec, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_acef, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1013_acf1, 5); call(0x1013_add4, 0xde);                /* call 0x1013add4 */
            ii(0x1013_acf6, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_acf9, 2); mov(edx, memd[ds, eax]);                /* mov edx, [eax] */
            ii(0x1013_acfb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_acfe, 2); mov(memd[ds, eax], edx);                /* mov [eax], edx */
            ii(0x1013_ad00, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_ad03, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_ad06, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_ad09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ad0b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_ad0c, 1); pop(edi);                               /* pop edi */
            ii(0x1013_ad0d, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ad0e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ad0f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ad10, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_adcc-68603bd1")]
        public void Method_100e_adcc()
        {
            ii(0x100e_adcc, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_add1, 5); call(Definitions.sys_check_available_stack_size, 0x7_af7c); /* call 0x10165d52 */
            ii(0x100e_add6, 1); push(ebx);                              /* push ebx */
            ii(0x100e_add7, 1); push(ecx);                              /* push ecx */
            ii(0x100e_add8, 1); push(esi);                              /* push esi */
            ii(0x100e_add9, 1); push(edi);                              /* push edi */
            ii(0x100e_adda, 1); push(ebp);                              /* push ebp */
            ii(0x100e_addb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_addd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_ade3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_ade6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_ade9, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_aded, 3); lea(edx, eax + eax * 4);                /* lea edx, [eax+eax*4] */
            ii(0x100e_adf0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_adf3, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x100e_adf6, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x100e_adf8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100e_adfb, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_adfe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_ae00, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_ae01, 1); pop(edi);                               /* pop edi */
            ii(0x100e_ae02, 1); pop(esi);                               /* pop esi */
            ii(0x100e_ae03, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_ae04, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_ae05, 1); ret();                                  /* ret */
        }
    }
}

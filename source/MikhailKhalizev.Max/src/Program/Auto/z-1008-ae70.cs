using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ae70-2ddefa8f")]
        public void Method_1008_ae70()
        {
            ii(0x1008_ae70, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_ae75, 5); call(Definitions.sys_check_available_stack_size, 0xd_aed8); /* call 0x10165d52 */
            ii(0x1008_ae7a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ae7b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ae7c, 1); push(esi);                              /* push esi */
            ii(0x1008_ae7d, 1); push(edi);                              /* push edi */
            ii(0x1008_ae7e, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ae7f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ae81, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_ae87, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_ae8a, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_ae8d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_ae90, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ae93, 5); call(0x1007_6d14, -0x1_4184);           /* call 0x10076d14 */
            ii(0x1008_ae98, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_ae9b, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_ae9e, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_aea1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_aea4, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_aea7, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_aeaa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_aeac, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_aead, 1); pop(edi);                               /* pop edi */
            ii(0x1008_aeae, 1); pop(esi);                               /* pop esi */
            ii(0x1008_aeaf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_aeb0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_aeb1, 1); ret();                                  /* ret */
        }
    }
}

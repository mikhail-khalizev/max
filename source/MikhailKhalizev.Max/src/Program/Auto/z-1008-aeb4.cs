using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aeb4-3a21ee40")]
        public void Method_1008_aeb4()
        {
            ii(0x1008_aeb4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_aeb9, 5); call(Definitions.sys_check_available_stack_size, 0xd_ae94); /* call 0x10165d52 */
            ii(0x1008_aebe, 1); push(ebx);                              /* push ebx */
            ii(0x1008_aebf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_aec0, 1); push(edx);                              /* push edx */
            ii(0x1008_aec1, 1); push(esi);                              /* push esi */
            ii(0x1008_aec2, 1); push(edi);                              /* push edi */
            ii(0x1008_aec3, 1); push(ebp);                              /* push ebp */
            ii(0x1008_aec4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_aec6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_aecc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_aecf, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_aed2, 5); call(0x1007_6d58, -0x1_417f);           /* call 0x10076d58 */
            ii(0x1008_aed7, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_aeda, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1008_aedd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_aee0, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_aee3, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_aee6, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_aee9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_aeeb, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_aeec, 1); pop(edi);                               /* pop edi */
            ii(0x1008_aeed, 1); pop(esi);                               /* pop esi */
            ii(0x1008_aeee, 1); pop(edx);                               /* pop edx */
            ii(0x1008_aeef, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_aef0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_aef1, 1); ret();                                  /* ret */
        }
    }
}

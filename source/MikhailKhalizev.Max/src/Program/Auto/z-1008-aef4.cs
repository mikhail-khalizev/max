using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_aef4-1dfcd848")]
        public void Method_1008_aef4()
        {
            ii(0x1008_aef4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_aef9, 5); call(Definitions.sys_check_available_stack_size, 0xd_ae54); /* call 0x10165d52 */
            ii(0x1008_aefe, 1); push(ebx);                              /* push ebx */
            ii(0x1008_aeff, 1); push(ecx);                              /* push ecx */
            ii(0x1008_af00, 1); push(edx);                              /* push edx */
            ii(0x1008_af01, 1); push(esi);                              /* push esi */
            ii(0x1008_af02, 1); push(edi);                              /* push edi */
            ii(0x1008_af03, 1); push(ebp);                              /* push ebp */
            ii(0x1008_af04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_af06, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_af0c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_af0f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_af12, 5); call(0x1007_6b58, -0x1_43bf);           /* call 0x10076b58 */
            ii(0x1008_af17, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_af1a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_af1d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_af1f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_af20, 1); pop(edi);                               /* pop edi */
            ii(0x1008_af21, 1); pop(esi);                               /* pop esi */
            ii(0x1008_af22, 1); pop(edx);                               /* pop edx */
            ii(0x1008_af23, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_af24, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_af25, 1); ret();                                  /* ret */
        }
    }
}

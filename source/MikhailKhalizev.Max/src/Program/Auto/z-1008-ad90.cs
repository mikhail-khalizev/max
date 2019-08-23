using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ad90-e8efd595")]
        public void Method_1008_ad90()
        {
            ii(0x1008_ad90, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_ad95, 5); call(Definitions.sys_check_available_stack_size, 0xd_afb8); /* call 0x10165d52 */
            ii(0x1008_ad9a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ad9b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ad9c, 1); push(edx);                              /* push edx */
            ii(0x1008_ad9d, 1); push(esi);                              /* push esi */
            ii(0x1008_ad9e, 1); push(edi);                              /* push edi */
            ii(0x1008_ad9f, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ada0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ada2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_ada8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_adab, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_adae, 4); mov(ax, memw[ds, eax + 0x9]);           /* mov ax, [eax+0x9] */
            ii(0x1008_adb2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_adb5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_adb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_adba, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_adbb, 1); pop(edi);                               /* pop edi */
            ii(0x1008_adbc, 1); pop(esi);                               /* pop esi */
            ii(0x1008_adbd, 1); pop(edx);                               /* pop edx */
            ii(0x1008_adbe, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_adbf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_adc0, 1); ret();                                  /* ret */
        }
    }
}

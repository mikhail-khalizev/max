using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_820d-ffa95b50")]
        public void Method_100d_820d()
        {
            ii(0x100d_820d, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_8212, 5); call(Definitions.sys_check_available_stack_size, 0x8_db3b); /* call 0x10165d52 */
            ii(0x100d_8217, 1); push(ebx);                              /* push ebx */
            ii(0x100d_8218, 1); push(ecx);                              /* push ecx */
            ii(0x100d_8219, 1); push(esi);                              /* push esi */
            ii(0x100d_821a, 1); push(edi);                              /* push edi */
            ii(0x100d_821b, 1); push(ebp);                              /* push ebp */
            ii(0x100d_821c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_821e, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_8224, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_8227, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_822a, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x100d_822d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_8230, 5); call(0x100d_8197, -0x9e);               /* call 0x100d8197 */
            ii(0x100d_8235, 3); lea(edx, memd[ss, ebp - 0x18]);         /* lea edx, [ebp-0x18] */
            ii(0x100d_8238, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_823b, 5); call(Definitions.sys_display_draw_1, 0x8_f268); /* call 0x101674a8 */
            ii(0x100d_8240, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8242, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_8243, 1); pop(edi);                               /* pop edi */
            ii(0x100d_8244, 1); pop(esi);                               /* pop esi */
            ii(0x100d_8245, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_8246, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_8247, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b603-e458aa64")]
        public void Method_1010_b603()
        {
            ii(0x1010_b603, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_b608, 5); call(Definitions.sys_check_available_stack_size, 0x5_a745); /* call 0x10165d52 */
            ii(0x1010_b60d, 1); push(ebx);                              /* push ebx */
            ii(0x1010_b60e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_b60f, 1); push(edx);                              /* push edx */
            ii(0x1010_b610, 1); push(esi);                              /* push esi */
            ii(0x1010_b611, 1); push(edi);                              /* push edi */
            ii(0x1010_b612, 1); push(ebp);                              /* push ebp */
            ii(0x1010_b613, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b615, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1010_b61b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_b61e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b621, 3); mov(edx, memd[ds, eax + 0xd]);          /* mov edx, [eax+0xd] */
            ii(0x1010_b624, 3); sub(edx, 0x14);                         /* sub edx, 0x14 */
            ii(0x1010_b627, 5); mov(eax, 0x49);                         /* mov eax, 0x49 */
            ii(0x1010_b62c, 5); call(0x100c_aafc, -0x4_0b35);           /* call 0x100caafc */
            ii(0x1010_b631, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b634, 5); call(0x1010_a8a7, -0xd92);              /* call 0x1010a8a7 */
            ii(0x1010_b639, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_b63c, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_b63e, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b641, 5); call(Definitions.sys_display_draw_0, 0x5_be3e); /* call 0x10167484 */
            ii(0x1010_b646, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b648, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_b649, 1); pop(edi);                               /* pop edi */
            ii(0x1010_b64a, 1); pop(esi);                               /* pop esi */
            ii(0x1010_b64b, 1); pop(edx);                               /* pop edx */
            ii(0x1010_b64c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_b64d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_b64e, 1); ret();                                  /* ret */
        }
    }
}

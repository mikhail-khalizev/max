using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b000-39c69644")]
        public void Method_100c_b000()
        {
            ii(0x100c_b000, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_b005, 5); call(Definitions.sys_check_available_stack_size, 0x9_ad48); /* call 0x10165d52 */
            ii(0x100c_b00a, 1); push(ebx);                              /* push ebx */
            ii(0x100c_b00b, 1); push(ecx);                              /* push ecx */
            ii(0x100c_b00c, 1); push(edx);                              /* push edx */
            ii(0x100c_b00d, 1); push(esi);                              /* push esi */
            ii(0x100c_b00e, 1); push(edi);                              /* push edi */
            ii(0x100c_b00f, 1); push(ebp);                              /* push ebp */
            ii(0x100c_b010, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b012, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100c_b018, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_b01b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_b01e, 5); call(0x1007_6b58, -0x5_44cb);           /* call 0x10076b58 */
            ii(0x100c_b023, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b026, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b029, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b02b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_b02c, 1); pop(edi);                               /* pop edi */
            ii(0x100c_b02d, 1); pop(esi);                               /* pop esi */
            ii(0x100c_b02e, 1); pop(edx);                               /* pop edx */
            ii(0x100c_b02f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_b030, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_b031, 1); ret();                                  /* ret */
        }
    }
}

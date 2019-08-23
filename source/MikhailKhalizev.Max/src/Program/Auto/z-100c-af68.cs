using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_af68-e266f219")]
        public void Method_100c_af68()
        {
            ii(0x100c_af68, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_af6d, 5); call(Definitions.sys_check_available_stack_size, 0x9_ade0); /* call 0x10165d52 */
            ii(0x100c_af72, 1); push(ebx);                              /* push ebx */
            ii(0x100c_af73, 1); push(ecx);                              /* push ecx */
            ii(0x100c_af74, 1); push(esi);                              /* push esi */
            ii(0x100c_af75, 1); push(edi);                              /* push edi */
            ii(0x100c_af76, 1); push(ebp);                              /* push ebp */
            ii(0x100c_af77, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_af79, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_af7f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_af82, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_af85, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_af88, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_af8b, 5); call(0x1007_6c98, -0x5_42f8);           /* call 0x10076c98 */
            ii(0x100c_af90, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_af93, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_af96, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_af98, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_af99, 1); pop(edi);                               /* pop edi */
            ii(0x100c_af9a, 1); pop(esi);                               /* pop esi */
            ii(0x100c_af9b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_af9c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_af9d, 1); ret();                                  /* ret */
        }
    }
}

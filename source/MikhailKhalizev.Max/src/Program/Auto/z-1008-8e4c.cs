using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8e4c-4eeebae9")]
        public void Method_1008_8e4c()
        {
            ii(0x1008_8e4c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8e51, 5); call(Definitions.sys_check_available_stack_size, 0xd_cefc); /* call 0x10165d52 */
            ii(0x1008_8e56, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8e57, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8e58, 1); push(esi);                              /* push esi */
            ii(0x1008_8e59, 1); push(edi);                              /* push edi */
            ii(0x1008_8e5a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8e5b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8e5d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8e63, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8e66, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_8e69, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8e6e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8e71, 5); call(0x1007_5e24, -0x1_3052);           /* call 0x10075e24 */
            ii(0x1008_8e76, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8e79, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8e7c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_8e7f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_8e82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8e84, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8e85, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8e86, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8e87, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_8e88, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_8e89, 1); ret();                                  /* ret */
        }
    }
}

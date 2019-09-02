using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_736d-4688407d")]
        public void Method_1008_736d()
        {
            ii(0x1008_736d, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_7372, 5); call(Definitions.sys_check_available_stack_size, 0xd_e9db); /* call 0x10165d52 */
            ii(0x1008_7377, 1); push(ebx);                              /* push ebx */
            ii(0x1008_7378, 1); push(ecx);                              /* push ecx */
            ii(0x1008_7379, 1); push(esi);                              /* push esi */
            ii(0x1008_737a, 1); push(edi);                              /* push edi */
            ii(0x1008_737b, 1); push(ebp);                              /* push ebp */
            ii(0x1008_737c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_737e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_7384, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_7387, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_738a, 5); mov(edx, StringDefinitions.SupportAttack); /* mov edx, 0x101a02d7 */
            ii(0x1008_738f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_7392, 5); call(Definitions.sys_strcpy, 0xd_eb38); /* call 0x10165ecf */
            ii(0x1008_7397, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1008_739a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_739d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1008_73a0, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_73a2, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_73a3, 1); pop(edi);                               /* pop edi */
            ii(0x1008_73a4, 1); pop(esi);                               /* pop esi */
            ii(0x1008_73a5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_73a6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_73a7, 1); ret();                                  /* ret */
        }
    }
}

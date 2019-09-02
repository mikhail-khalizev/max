using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a454-d069fb34")]
        public void Method_100c_a454()
        {
            ii(0x100c_a454, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a459, 5); call(Definitions.sys_check_available_stack_size, 0x9_b8f4); /* call 0x10165d52 */
            ii(0x100c_a45e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a45f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a460, 1); push(esi);                              /* push esi */
            ii(0x100c_a461, 1); push(edi);                              /* push edi */
            ii(0x100c_a462, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a463, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a465, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a46b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a46e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a471, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100c_a476, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a479, 5); call(Definitions.my_dtor_0x101b_6edc, 0x7_07c7); /* call 0x1013ac45 */
            ii(0x100c_a47e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a481, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a484, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100c_a487, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100c_a48a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a48c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a48d, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a48e, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a48f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a490, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a491, 1); ret();                                  /* ret */
        }
    }
}

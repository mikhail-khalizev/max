using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7428-251434f9")]
        public void Method_100b_7428()
        {
            ii(0x100b_7428, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_742d, 5); call(Definitions.sys_check_available_stack_size, 0xa_e920); /* call 0x10165d52 */
            ii(0x100b_7432, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7433, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7434, 1); push(esi);                              /* push esi */
            ii(0x100b_7435, 1); push(edi);                              /* push edi */
            ii(0x100b_7436, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7437, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7439, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_743f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_7442, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_7445, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_744a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_744d, 5); call(Definitions.my_dtor_0x101b_6edc, 0x8_37f3); /* call 0x1013ac45 */
            ii(0x100b_7452, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_7455, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_7458, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_745b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_745e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7460, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7461, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7462, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7463, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7464, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7465, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_76d8-61160c91")]
        public void Method_100d_76d8()
        {
            ii(0x100d_76d8, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_76dd, 5); call(Definitions.sys_check_available_stack_size, 0x8_e670); /* call 0x10165d52 */
            ii(0x100d_76e2, 1); push(ebx);                              /* push ebx */
            ii(0x100d_76e3, 1); push(ecx);                              /* push ecx */
            ii(0x100d_76e4, 1); push(edx);                              /* push edx */
            ii(0x100d_76e5, 1); push(esi);                              /* push esi */
            ii(0x100d_76e6, 1); push(edi);                              /* push edi */
            ii(0x100d_76e7, 1); push(ebp);                              /* push ebp */
            ii(0x100d_76e8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_76ea, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100d_76f0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100d_76f3, 7); mov(memd[ss, ebp - 8], 0x101c_3602);    /* mov dword [ebp-0x8], 0x101c3602 */
            ii(0x100d_76fa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100d_76fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_76ff, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_7700, 1); pop(edi);                               /* pop edi */
            ii(0x100d_7701, 1); pop(esi);                               /* pop esi */
            ii(0x100d_7702, 1); pop(edx);                               /* pop edx */
            ii(0x100d_7703, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_7704, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_7705, 1); ret();                                  /* ret */
        }
    }
}

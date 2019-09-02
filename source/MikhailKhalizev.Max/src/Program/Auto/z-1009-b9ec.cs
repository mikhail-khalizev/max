using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b9ec-839dfcf1")]
        public void Method_1009_b9ec()
        {
            ii(0x1009_b9ec, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_b9f1, 5); call(Definitions.sys_check_available_stack_size, 0xc_a35c); /* call 0x10165d52 */
            ii(0x1009_b9f6, 1); push(ebx);                              /* push ebx */
            ii(0x1009_b9f7, 1); push(ecx);                              /* push ecx */
            ii(0x1009_b9f8, 1); push(esi);                              /* push esi */
            ii(0x1009_b9f9, 1); push(edi);                              /* push edi */
            ii(0x1009_b9fa, 1); push(ebp);                              /* push ebp */
            ii(0x1009_b9fb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b9fd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_ba03, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_ba06, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1009_ba09, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1009_ba0e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ba11, 5); call(Definitions.my_dtor_0x101b_6edc, 0x9_f22f); /* call 0x1013ac45 */
            ii(0x1009_ba16, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_ba19, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_ba1c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_ba1f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_ba22, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ba24, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_ba25, 1); pop(edi);                               /* pop edi */
            ii(0x1009_ba26, 1); pop(esi);                               /* pop esi */
            ii(0x1009_ba27, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_ba28, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_ba29, 1); ret();                                  /* ret */
        }
    }
}

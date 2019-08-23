using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_8fc4-7a7fb8f2")]
        public void Method_1008_8fc4()
        {
            ii(0x1008_8fc4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_8fc9, 5); call(Definitions.sys_check_available_stack_size, 0xd_cd84); /* call 0x10165d52 */
            ii(0x1008_8fce, 1); push(ebx);                              /* push ebx */
            ii(0x1008_8fcf, 1); push(ecx);                              /* push ecx */
            ii(0x1008_8fd0, 1); push(esi);                              /* push esi */
            ii(0x1008_8fd1, 1); push(edi);                              /* push edi */
            ii(0x1008_8fd2, 1); push(ebp);                              /* push ebp */
            ii(0x1008_8fd3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_8fd5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_8fdb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8fde, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_8fe1, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1008_8fe6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8fe9, 5); call(Definitions.my_dtor_0x101b_6edc, 0xb_1c57); /* call 0x1013ac45 */
            ii(0x1008_8fee, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_8ff1, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_8ff4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_8ff7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_8ffa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_8ffc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_8ffd, 1); pop(edi);                               /* pop edi */
            ii(0x1008_8ffe, 1); pop(esi);                               /* pop esi */
            ii(0x1008_8fff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9000, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9001, 1); ret();                                  /* ret */
        }
    }
}

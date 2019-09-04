using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c484-eb2d374b")]
        public void Method_1013_c484()
        {
            ii(0x1013_c484, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c489, 5); call(Definitions.sys_check_available_stack_size, 0x2_98c4); /* call 0x10165d52 */
            ii(0x1013_c48e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c48f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c490, 1); push(esi);                              /* push esi */
            ii(0x1013_c491, 1); push(edi);                              /* push edi */
            ii(0x1013_c492, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c493, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c495, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c49b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c49e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c4a1, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_c4a6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c4a9, 5); call(0x1007_5e24, -0xc_668a);           /* call 0x10075e24 */
            ii(0x1013_c4ae, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c4b1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c4b4, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_c4b7, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_c4ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c4bc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c4bd, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c4be, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c4bf, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c4c0, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c4c1, 1); ret();                                  /* ret */
        }
    }
}

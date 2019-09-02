using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_bc59-d41af248")]
        public void Method_1011_bc59()
        {
            ii(0x1011_bc59, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_bc5e, 5); call(Definitions.sys_check_available_stack_size, 0x4_a0ef); /* call 0x10165d52 */
            ii(0x1011_bc63, 1); push(ebx);                              /* push ebx */
            ii(0x1011_bc64, 1); push(ecx);                              /* push ecx */
            ii(0x1011_bc65, 1); push(esi);                              /* push esi */
            ii(0x1011_bc66, 1); push(edi);                              /* push edi */
            ii(0x1011_bc67, 1); push(ebp);                              /* push ebp */
            ii(0x1011_bc68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_bc6a, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1011_bc70, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1011_bc73, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1011_bc76, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_bc79, 3); add(edx, 0x16);                         /* add edx, 0x16 */
            ii(0x1011_bc7c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_bc7f, 5); call(0x1013_bb7b, 0x1_fef7);            /* call 0x1013bb7b */
            ii(0x1011_bc84, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1011_bc87, 3); add(edx, 0x18);                         /* add edx, 0x18 */
            ii(0x1011_bc8a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1011_bc8d, 5); call(0x1013_bb7b, 0x1_fee9);            /* call 0x1013bb7b */
            ii(0x1011_bc92, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_bc94, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_bc95, 1); pop(edi);                               /* pop edi */
            ii(0x1011_bc96, 1); pop(esi);                               /* pop esi */
            ii(0x1011_bc97, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_bc98, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_bc99, 1); ret();                                  /* ret */
        }
    }
}

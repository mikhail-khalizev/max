using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_bdf5-a16113e4")]
        public void Method_1008_bdf5()
        {
            ii(0x1008_bdf5, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_bdfa, 5); call(Definitions.sys_check_available_stack_size, 0xd_9f53); /* call 0x10165d52 */
            ii(0x1008_bdff, 1); push(ebx);                              /* push ebx */
            ii(0x1008_be00, 1); push(ecx);                              /* push ecx */
            ii(0x1008_be01, 1); push(edx);                              /* push edx */
            ii(0x1008_be02, 1); push(esi);                              /* push esi */
            ii(0x1008_be03, 1); push(edi);                              /* push edi */
            ii(0x1008_be04, 1); push(ebp);                              /* push ebp */
            ii(0x1008_be05, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_be07, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1008_be0d, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1008_be10, 4); mov(memb[ss, ebp - 8], 0x12);           /* mov byte [ebp-0x8], 0x12 */
            ii(0x1008_be14, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1008_be17, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_be19, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_be1a, 1); pop(edi);                               /* pop edi */
            ii(0x1008_be1b, 1); pop(esi);                               /* pop esi */
            ii(0x1008_be1c, 1); pop(edx);                               /* pop edx */
            ii(0x1008_be1d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_be1e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_be1f, 1); ret();                                  /* ret */
        }
    }
}

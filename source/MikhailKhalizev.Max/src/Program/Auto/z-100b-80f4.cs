using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_80f4-f7fe4242")]
        public void Method_100b_80f4()
        {
            ii(0x100b_80f4, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_80f9, 5); call(Definitions.sys_check_available_stack_size, 0xa_dc54); /* call 0x10165d52 */
            ii(0x100b_80fe, 1); push(ebx);                              /* push ebx */
            ii(0x100b_80ff, 1); push(ecx);                              /* push ecx */
            ii(0x100b_8100, 1); push(edx);                              /* push edx */
            ii(0x100b_8101, 1); push(esi);                              /* push esi */
            ii(0x100b_8102, 1); push(edi);                              /* push edi */
            ii(0x100b_8103, 1); push(ebp);                              /* push ebp */
            ii(0x100b_8104, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_8106, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_810c, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x100b_810f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_8112, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100b_8114, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_8117, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_811a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_811c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_811d, 1); pop(edi);                               /* pop edi */
            ii(0x100b_811e, 1); pop(esi);                               /* pop esi */
            ii(0x100b_811f, 1); pop(edx);                               /* pop edx */
            ii(0x100b_8120, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_8121, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_8122, 1); ret();                                  /* ret */
        }
    }
}

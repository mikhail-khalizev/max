using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_255c-3e479f7b")]
        public void my_strobj_get_size()
        {
            ii(0x1014_255c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_2561, 5); call(Definitions.sys_check_available_stack_size, 0x2_37ec); /* call 0x10165d52 */
            ii(0x1014_2566, 1); push(ebx);                              /* push ebx */
            ii(0x1014_2567, 1); push(ecx);                              /* push ecx */
            ii(0x1014_2568, 1); push(edx);                              /* push edx */
            ii(0x1014_2569, 1); push(esi);                              /* push esi */
            ii(0x1014_256a, 1); push(edi);                              /* push edi */
            ii(0x1014_256b, 1); push(ebp);                              /* push ebp */
            ii(0x1014_256c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_256e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_2574, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_2577, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_257a, 4); mov(ax, memw[ds, eax + 0x4]);           /* mov ax, [eax+0x4] */
            ii(0x1014_257e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_2581, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_2584, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2586, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_2587, 1); pop(edi);                               /* pop edi */
            ii(0x1014_2588, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2589, 1); pop(edx);                               /* pop edx */
            ii(0x1014_258a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_258b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_258c, 1); ret();                                  /* ret */
        }
    }
}

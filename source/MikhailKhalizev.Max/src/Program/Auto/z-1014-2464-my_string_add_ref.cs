using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2464-758e4ef8")]
        public void my_string_add_ref()
        {
            ii(0x1014_2464, 5); push(0x20);                             /* push 0x20 */
            ii(0x1014_2469, 5); call(Definitions.sys_check_available_stack_size, 0x2_38e4); /* call 0x10165d52 */
            ii(0x1014_246e, 1); push(ebx);                              /* push ebx */
            ii(0x1014_246f, 1); push(ecx);                              /* push ecx */
            ii(0x1014_2470, 1); push(edx);                              /* push edx */
            ii(0x1014_2471, 1); push(esi);                              /* push esi */
            ii(0x1014_2472, 1); push(edi);                              /* push edi */
            ii(0x1014_2473, 1); push(ebp);                              /* push ebp */
            ii(0x1014_2474, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2476, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_247c, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_247f, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1014_2483, 2); if(jz(0x1014_248b, 0x6)) goto l_0x1014_248b; /* jz 0x1014248b */
            ii(0x1014_2485, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_2488, 3); inc(memd[ds, eax + 0x8]);               /* inc dword [eax+0x8] */
        l_0x1014_248b:
            ii(0x1014_248b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_248d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_248e, 1); pop(edi);                               /* pop edi */
            ii(0x1014_248f, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2490, 1); pop(edx);                               /* pop edx */
            ii(0x1014_2491, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_2492, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_2493, 1); ret();                                  /* ret */
        }
    }
}

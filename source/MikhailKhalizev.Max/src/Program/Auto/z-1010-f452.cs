using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_f452-62ec910a")]
        public void Method_1010_f452()
        {
            ii(0x1010_f452, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_f457, 5); call(Definitions.sys_check_available_stack_size, 0x5_68f6); /* call 0x10165d52 */
            ii(0x1010_f45c, 1); push(ebx);                              /* push ebx */
            ii(0x1010_f45d, 1); push(ecx);                              /* push ecx */
            ii(0x1010_f45e, 1); push(edx);                              /* push edx */
            ii(0x1010_f45f, 1); push(esi);                              /* push esi */
            ii(0x1010_f460, 1); push(edi);                              /* push edi */
            ii(0x1010_f461, 1); push(ebp);                              /* push ebp */
            ii(0x1010_f462, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_f464, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_f46a, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1010_f46d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_f470, 5); call(0x1010_f2cf, -0x1a6);              /* call 0x1010f2cf */
            ii(0x1010_f475, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_f478, 7); mov(memd[ds, eax + 8], 1);              /* mov dword [eax+0x8], 0x1 */
            ii(0x1010_f47f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_f481, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_f482, 1); pop(edi);                               /* pop edi */
            ii(0x1010_f483, 1); pop(esi);                               /* pop esi */
            ii(0x1010_f484, 1); pop(edx);                               /* pop edx */
            ii(0x1010_f485, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_f486, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_f487, 1); ret();                                  /* ret */
        }
    }
}

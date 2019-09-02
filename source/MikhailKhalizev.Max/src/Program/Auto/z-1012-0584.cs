using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0584-eaa5fbf")]
        public void Method_1012_0584()
        {
            ii(0x1012_0584, 5); push(0x20);                             /* push 0x20 */
            ii(0x1012_0589, 5); call(Definitions.sys_check_available_stack_size, 0x4_57c4); /* call 0x10165d52 */
            ii(0x1012_058e, 1); push(ebx);                              /* push ebx */
            ii(0x1012_058f, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0590, 1); push(esi);                              /* push esi */
            ii(0x1012_0591, 1); push(edi);                              /* push edi */
            ii(0x1012_0592, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0593, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0595, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1012_059b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_059e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_05a1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_05a4, 2); mov(ebx, memd[ds, eax]);                /* mov ebx, [eax] */
            ii(0x1012_05a6, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1012_05a9, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_05ac, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_05af, 5); call(0x1012_05bc, 8);                   /* call 0x101205bc */
            ii(0x1012_05b4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_05b6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_05b7, 1); pop(edi);                               /* pop edi */
            ii(0x1012_05b8, 1); pop(esi);                               /* pop esi */
            ii(0x1012_05b9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_05ba, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_05bb, 1); ret();                                  /* ret */
        }
    }
}

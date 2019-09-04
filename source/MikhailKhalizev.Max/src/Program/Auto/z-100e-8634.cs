using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_8634-602a263d")]
        public void Method_100e_8634()
        {
            ii(0x100e_8634, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_8639, 5); call(Definitions.sys_check_available_stack_size, 0x7_d714); /* call 0x10165d52 */
            ii(0x100e_863e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_863f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_8640, 1); push(esi);                              /* push esi */
            ii(0x100e_8641, 1); push(edi);                              /* push edi */
            ii(0x100e_8642, 1); push(ebp);                              /* push ebp */
            ii(0x100e_8643, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_8645, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_864b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100e_864e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100e_8651, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100e_8655, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100e_8658, 5); call(0x100e_866c, 0xf);                 /* call 0x100e866c */
            ii(0x100e_865d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100e_8660, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100e_8663, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_8665, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_8666, 1); pop(edi);                               /* pop edi */
            ii(0x100e_8667, 1); pop(esi);                               /* pop esi */
            ii(0x100e_8668, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_8669, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_866a, 1); ret();                                  /* ret */
        }
    }
}

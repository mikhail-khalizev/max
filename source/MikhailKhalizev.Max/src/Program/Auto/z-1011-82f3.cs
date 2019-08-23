using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_82f3-635e3e71")]
        public void Method_1011_82f3()
        {
            ii(0x1011_82f3, 5); push(0x28);                             /* push 0x28 */
            ii(0x1011_82f8, 5); call(Definitions.sys_check_available_stack_size, 0x4_da55); /* call 0x10165d52 */
            ii(0x1011_82fd, 1); push(ebx);                              /* push ebx */
            ii(0x1011_82fe, 1); push(ecx);                              /* push ecx */
            ii(0x1011_82ff, 1); push(edx);                              /* push edx */
            ii(0x1011_8300, 1); push(esi);                              /* push esi */
            ii(0x1011_8301, 1); push(edi);                              /* push edi */
            ii(0x1011_8302, 1); push(ebp);                              /* push ebp */
            ii(0x1011_8303, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8305, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_830b, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_830e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8311, 5); call(0x1011_806d, -0x2a9);              /* call 0x1011806d */
            ii(0x1011_8316, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_8319, 3); lea(eax, memd[ss, ebp - 0x4]);          /* lea eax, [ebp-0x4] */
            ii(0x1011_831c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_831f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_8322, 7); mov(memd[ds, eax + 0x2], 0x101b_696c);  /* mov dword [eax+0x2], 0x101b696c */
            ii(0x1011_8329, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_832c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1011_832f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_8332, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_8334, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_8335, 1); pop(edi);                               /* pop edi */
            ii(0x1011_8336, 1); pop(esi);                               /* pop esi */
            ii(0x1011_8337, 1); pop(edx);                               /* pop edx */
            ii(0x1011_8338, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_8339, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_833a, 1); ret();                                  /* ret */
        }
    }
}

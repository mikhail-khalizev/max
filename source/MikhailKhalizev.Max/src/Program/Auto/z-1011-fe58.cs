using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fe58-101ec120")]
        public void Method_1011_fe58()
        {
            ii(0x1011_fe58, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_fe5d, 5); call(Definitions.sys_check_available_stack_size, 0x4_5ef0); /* call 0x10165d52 */
            ii(0x1011_fe62, 1); push(ebx);                              /* push ebx */
            ii(0x1011_fe63, 1); push(ecx);                              /* push ecx */
            ii(0x1011_fe64, 1); push(edx);                              /* push edx */
            ii(0x1011_fe65, 1); push(esi);                              /* push esi */
            ii(0x1011_fe66, 1); push(edi);                              /* push edi */
            ii(0x1011_fe67, 1); push(ebp);                              /* push ebp */
            ii(0x1011_fe68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fe6a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_fe70, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_fe73, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_fe76, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fe7b, 5); call(0x1011_e5df, -0x18a1);             /* call 0x1011e5df */
            ii(0x1011_fe80, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fe82, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_fe83, 1); pop(edi);                               /* pop edi */
            ii(0x1011_fe84, 1); pop(esi);                               /* pop esi */
            ii(0x1011_fe85, 1); pop(edx);                               /* pop edx */
            ii(0x1011_fe86, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_fe87, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_fe88, 1); ret();                                  /* ret */
        }
    }
}

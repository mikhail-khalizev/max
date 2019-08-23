using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_7603-787314d5")]
        public void Method_100e_7603()
        {
            ii(0x100e_7603, 5); push(0x1c);                             /* push 0x1c */
            ii(0x100e_7608, 5); call(Definitions.sys_check_available_stack_size, 0x7_e745); /* call 0x10165d52 */
            ii(0x100e_760d, 1); push(ebx);                              /* push ebx */
            ii(0x100e_760e, 1); push(ecx);                              /* push ecx */
            ii(0x100e_760f, 1); push(edx);                              /* push edx */
            ii(0x100e_7610, 1); push(esi);                              /* push esi */
            ii(0x100e_7611, 1); push(edi);                              /* push edi */
            ii(0x100e_7612, 1); push(ebp);                              /* push ebp */
            ii(0x100e_7613, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_7615, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x100e_761b, 5); mov(eax, 0x101c_819c);                  /* mov eax, 0x101c819c */
            ii(0x100e_7620, 5); call(0x100e_73f9, -0x22c);              /* call 0x100e73f9 */
            ii(0x100e_7625, 5); mov(eax, 0x101c_8184);                  /* mov eax, 0x101c8184 */
            ii(0x100e_762a, 5); call(0x100e_73f9, -0x236);              /* call 0x100e73f9 */
            ii(0x100e_762f, 5); mov(eax, 0x101c_81a8);                  /* mov eax, 0x101c81a8 */
            ii(0x100e_7634, 5); call(0x100e_73f9, -0x240);              /* call 0x100e73f9 */
            ii(0x100e_7639, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_763a, 1); pop(edi);                               /* pop edi */
            ii(0x100e_763b, 1); pop(esi);                               /* pop esi */
            ii(0x100e_763c, 1); pop(edx);                               /* pop edx */
            ii(0x100e_763d, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_763e, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_763f, 1); ret();                                  /* ret */
        }
    }
}

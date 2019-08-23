using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_57d4-5913dc22")]
        public void Method_1011_57d4()
        {
            ii(0x1011_57d4, 5); push(0x1c);                             /* push 0x1c */
            ii(0x1011_57d9, 5); call(Definitions.sys_check_available_stack_size, 0x5_0574); /* call 0x10165d52 */
            ii(0x1011_57de, 1); push(ebx);                              /* push ebx */
            ii(0x1011_57df, 1); push(ecx);                              /* push ecx */
            ii(0x1011_57e0, 1); push(edx);                              /* push edx */
            ii(0x1011_57e1, 1); push(esi);                              /* push esi */
            ii(0x1011_57e2, 1); push(edi);                              /* push edi */
            ii(0x1011_57e3, 1); push(ebp);                              /* push ebp */
            ii(0x1011_57e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_57e6, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1011_57ec, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_57ee, 5); mov(eax, 0x6b3);                        /* mov eax, 0x6b3 */
            ii(0x1011_57f3, 5); call(0x1011_556b, -0x28d);              /* call 0x1011556b */
            ii(0x1011_57f8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_57f9, 1); pop(edi);                               /* pop edi */
            ii(0x1011_57fa, 1); pop(esi);                               /* pop esi */
            ii(0x1011_57fb, 1); pop(edx);                               /* pop edx */
            ii(0x1011_57fc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_57fd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_57fe, 1); ret();                                  /* ret */
        }
    }
}

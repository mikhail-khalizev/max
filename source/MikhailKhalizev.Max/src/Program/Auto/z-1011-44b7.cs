using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_44b7-e8b5b8b6")]
        public void Method_1011_44b7()
        {
            ii(0x1011_44b7, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_44bc, 5); call(Definitions.sys_check_available_stack_size, 0x5_1891); /* call 0x10165d52 */
            ii(0x1011_44c1, 1); push(ebx);                              /* push ebx */
            ii(0x1011_44c2, 1); push(ecx);                              /* push ecx */
            ii(0x1011_44c3, 1); push(edx);                              /* push edx */
            ii(0x1011_44c4, 1); push(esi);                              /* push esi */
            ii(0x1011_44c5, 1); push(edi);                              /* push edi */
            ii(0x1011_44c6, 1); push(ebp);                              /* push ebp */
            ii(0x1011_44c7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_44c9, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_44cf, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_44d2, 5); call(0x100d_4e6c, -0x3_f66b);           /* call 0x100d4e6c */
            ii(0x1011_44d7, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1011_44d9, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x1011_44db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_44dd, 5); mov(eax, 0x3);                          /* mov eax, 0x3 */
            ii(0x1011_44e2, 5); call(0x1010_5b00, -0xe9e7);             /* call 0x10105b00 */
            ii(0x1011_44e7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_44e9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_44ea, 1); pop(edi);                               /* pop edi */
            ii(0x1011_44eb, 1); pop(esi);                               /* pop esi */
            ii(0x1011_44ec, 1); pop(edx);                               /* pop edx */
            ii(0x1011_44ed, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_44ee, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_44ef, 1); ret();                                  /* ret */
        }
    }
}

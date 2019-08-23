using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_b997-411295f9")]
        public void Method_1013_b997()
        {
            ii(0x1013_b997, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_b99c, 5); call(Definitions.sys_check_available_stack_size, 0x2_a3b1); /* call 0x10165d52 */
            ii(0x1013_b9a1, 1); push(ebx);                              /* push ebx */
            ii(0x1013_b9a2, 1); push(ecx);                              /* push ecx */
            ii(0x1013_b9a3, 1); push(esi);                              /* push esi */
            ii(0x1013_b9a4, 1); push(edi);                              /* push edi */
            ii(0x1013_b9a5, 1); push(ebp);                              /* push ebp */
            ii(0x1013_b9a6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_b9a8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_b9ae, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b9b1, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_b9b4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b9b7, 5); call(0x1013_ba3c, 0x80);                /* call 0x1013ba3c */
            ii(0x1013_b9bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_b9be, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b9c1, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1013_b9c4, 5); call(0x1013_c444, 0xa7b);               /* call 0x1013c444 */
            ii(0x1013_b9c9, 3); sub(eax, 0x4);                          /* sub eax, 0x4 */
            ii(0x1013_b9cc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_b9cf, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_b9d2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_b9d5, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1013_b9d8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_b9da, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_b9db, 1); pop(edi);                               /* pop edi */
            ii(0x1013_b9dc, 1); pop(esi);                               /* pop esi */
            ii(0x1013_b9dd, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_b9de, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_b9df, 1); ret();                                  /* ret */
        }
    }
}

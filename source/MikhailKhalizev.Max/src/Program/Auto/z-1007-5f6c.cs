using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5f6c-ea22ef29")]
        public void Method_1007_5f6c()
        {
            ii(0x1007_5f6c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_5f71, 5); call(Definitions.sys_check_available_stack_size, 0xe_fddc); /* call 0x10165d52 */
            ii(0x1007_5f76, 1); push(ebx);                              /* push ebx */
            ii(0x1007_5f77, 1); push(ecx);                              /* push ecx */
            ii(0x1007_5f78, 1); push(esi);                              /* push esi */
            ii(0x1007_5f79, 1); push(edi);                              /* push edi */
            ii(0x1007_5f7a, 1); push(ebp);                              /* push ebp */
            ii(0x1007_5f7b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5f7d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5f83, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5f86, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_5f89, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_5f8e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5f91, 5); call(0x1007_5e24, -0x172);              /* call 0x10075e24 */
            ii(0x1007_5f96, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5f99, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5f9c, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_5f9f, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_5fa2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5fa4, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_5fa5, 1); pop(edi);                               /* pop edi */
            ii(0x1007_5fa6, 1); pop(esi);                               /* pop esi */
            ii(0x1007_5fa7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_5fa8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_5fa9, 1); ret();                                  /* ret */
        }
    }
}

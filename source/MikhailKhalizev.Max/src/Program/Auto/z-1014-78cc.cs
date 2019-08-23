using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_78cc-a3cd8469")]
        public void Method_1014_78cc()
        {
            ii(0x1014_78cc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_78d1, 5); call(Definitions.sys_check_available_stack_size, 0x1_e47c); /* call 0x10165d52 */
            ii(0x1014_78d6, 1); push(ebx);                              /* push ebx */
            ii(0x1014_78d7, 1); push(ecx);                              /* push ecx */
            ii(0x1014_78d8, 1); push(esi);                              /* push esi */
            ii(0x1014_78d9, 1); push(edi);                              /* push edi */
            ii(0x1014_78da, 1); push(ebp);                              /* push ebp */
            ii(0x1014_78db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_78dd, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_78e3, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_78e6, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_78e9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1014_78ee, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_78f1, 5); call(0x1007_5e24, -0xd_1ad2);           /* call 0x10075e24 */
            ii(0x1014_78f6, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_78f9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_78fc, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_78ff, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_7902, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7904, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7905, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7906, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7907, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7908, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_7909, 1); ret();                                  /* ret */
        }
    }
}

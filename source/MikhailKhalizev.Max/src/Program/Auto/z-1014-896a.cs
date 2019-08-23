using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_896a-a4cbf910")]
        public void Method_1014_896a()
        {
            ii(0x1014_896a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_896f, 5); call(Definitions.sys_check_available_stack_size, 0x1_d3de); /* call 0x10165d52 */
            ii(0x1014_8974, 1); push(ebx);                              /* push ebx */
            ii(0x1014_8975, 1); push(ecx);                              /* push ecx */
            ii(0x1014_8976, 1); push(edx);                              /* push edx */
            ii(0x1014_8977, 1); push(esi);                              /* push esi */
            ii(0x1014_8978, 1); push(edi);                              /* push edi */
            ii(0x1014_8979, 1); push(ebp);                              /* push ebp */
            ii(0x1014_897a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_897c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_8982, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_8985, 5); mov(eax, 0x101c_814c);                  /* mov eax, 0x101c814c */
            ii(0x1014_898a, 5); call(0x1012_0d64, -0x2_7c2b);           /* call 0x10120d64 */
            ii(0x1014_898f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_8992, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_8995, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8997, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_8998, 1); pop(edi);                               /* pop edi */
            ii(0x1014_8999, 1); pop(esi);                               /* pop esi */
            ii(0x1014_899a, 1); pop(edx);                               /* pop edx */
            ii(0x1014_899b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_899c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_899d, 1); ret();                                  /* ret */
        }
    }
}

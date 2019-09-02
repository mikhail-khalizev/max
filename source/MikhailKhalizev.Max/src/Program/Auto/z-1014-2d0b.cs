using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2d0b-b2e4dd05")]
        public void Method_1014_2d0b()
        {
            ii(0x1014_2d0b, 5); push(0x34);                             /* push 0x34 */
            ii(0x1014_2d10, 5); call(Definitions.sys_check_available_stack_size, 0x2_303d); /* call 0x10165d52 */
            ii(0x1014_2d15, 1); push(esi);                              /* push esi */
            ii(0x1014_2d16, 1); push(edi);                              /* push edi */
            ii(0x1014_2d17, 1); push(ebp);                              /* push ebp */
            ii(0x1014_2d18, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2d1a, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_2d20, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_2d23, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_2d26, 3); mov(memd[ss, ebp - 12], ebx);           /* mov [ebp-0xc], ebx */
            ii(0x1014_2d29, 3); mov(memd[ss, ebp - 16], ecx);           /* mov [ebp-0x10], ecx */
            ii(0x1014_2d2c, 4); movsx(eax, memw[ss, ebp + 28]);         /* movsx eax, word [ebp+0x1c] */
            ii(0x1014_2d30, 1); push(eax);                              /* push eax */
            ii(0x1014_2d31, 4); movsx(eax, memw[ss, ebp + 24]);         /* movsx eax, word [ebp+0x18] */
            ii(0x1014_2d35, 1); push(eax);                              /* push eax */
            ii(0x1014_2d36, 3); mov(eax, memd[ss, ebp + 20]);           /* mov eax, [ebp+0x14] */
            ii(0x1014_2d39, 1); push(eax);                              /* push eax */
            ii(0x1014_2d3a, 3); mov(eax, memd[ss, ebp + 16]);           /* mov eax, [ebp+0x10] */
            ii(0x1014_2d3d, 1); push(eax);                              /* push eax */
            ii(0x1014_2d3e, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1014_2d41, 1); push(eax);                              /* push eax */
            ii(0x1014_2d42, 5); mov(ecx, 0xff);                         /* mov ecx, 0xff */
            ii(0x1014_2d47, 4); movsx(ebx, memw[ss, ebp - 12]);         /* movsx ebx, word [ebp-0xc] */
            ii(0x1014_2d4b, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x1014_2d4f, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1014_2d53, 5); call(0x1014_2b18, -0x240);              /* call 0x10142b18 */
            ii(0x1014_2d58, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_2d5a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_2d5b, 1); pop(edi);                               /* pop edi */
            ii(0x1014_2d5c, 1); pop(esi);                               /* pop esi */
            ii(0x1014_2d5d, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}

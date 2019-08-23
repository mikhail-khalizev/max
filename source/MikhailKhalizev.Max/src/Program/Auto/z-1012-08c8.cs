using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_08c8-5e315fab")]
        public void Method_1012_08c8()
        {
            ii(0x1012_08c8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_08cd, 5); call(Definitions.sys_check_available_stack_size, 0x4_5480); /* call 0x10165d52 */
            ii(0x1012_08d2, 1); push(ebx);                              /* push ebx */
            ii(0x1012_08d3, 1); push(ecx);                              /* push ecx */
            ii(0x1012_08d4, 1); push(edx);                              /* push edx */
            ii(0x1012_08d5, 1); push(esi);                              /* push esi */
            ii(0x1012_08d6, 1); push(edi);                              /* push edi */
            ii(0x1012_08d7, 1); push(ebp);                              /* push ebp */
            ii(0x1012_08d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_08da, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_08e0, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_08e3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_08e6, 5); call(0x1013_a0af, 0x1_97c4);            /* call 0x1013a0af */
            ii(0x1012_08eb, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_08ee, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1012_08f1, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_08f4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_08f7, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_08fa, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_08fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_08ff, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0900, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0901, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0902, 1); pop(edx);                               /* pop edx */
            ii(0x1012_0903, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0904, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0905, 1); ret();                                  /* ret */
        }
    }
}

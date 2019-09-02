using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_0872-da8eca9c")]
        public void Method_1009_0872()
        {
            ii(0x1009_0872, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_0877, 5); call(Definitions.sys_check_available_stack_size, 0xd_54d6); /* call 0x10165d52 */
            ii(0x1009_087c, 1); push(ecx);                              /* push ecx */
            ii(0x1009_087d, 1); push(esi);                              /* push esi */
            ii(0x1009_087e, 1); push(edi);                              /* push edi */
            ii(0x1009_087f, 1); push(ebp);                              /* push ebp */
            ii(0x1009_0880, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_0882, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1009_0888, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_088b, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x1009_088e, 3); mov(memd[ss, ebp - 4], ebx);            /* mov [ebp-0x4], ebx */
            ii(0x1009_0891, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_0894, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1009_0897, 4); mov(memw[ds, edx + 0x2b], ax);          /* mov [edx+0x2b], ax */
            ii(0x1009_089b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_089e, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1009_08a1, 5); call(0x1007_5e64, -0x1_aa42);           /* call 0x10075e64 */
            ii(0x1009_08a6, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_08a8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_08ab, 5); call(0x1009_034f, -0x561);              /* call 0x1009034f */
            ii(0x1009_08b0, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1009_08b3, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1009_08b6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_08b8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_08b9, 1); pop(edi);                               /* pop edi */
            ii(0x1009_08ba, 1); pop(esi);                               /* pop esi */
            ii(0x1009_08bb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_08bc, 1); ret();                                  /* ret */
        }
    }
}

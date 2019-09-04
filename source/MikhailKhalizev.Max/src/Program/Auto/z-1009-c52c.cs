using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c52c-94ba53ae")]
        public void Method_1009_c52c()
        {
            ii(0x1009_c52c, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_c531, 5); call(Definitions.sys_check_available_stack_size, 0xc_981c); /* call 0x10165d52 */
            ii(0x1009_c536, 1); push(ebx);                              /* push ebx */
            ii(0x1009_c537, 1); push(ecx);                              /* push ecx */
            ii(0x1009_c538, 1); push(edx);                              /* push edx */
            ii(0x1009_c539, 1); push(esi);                              /* push esi */
            ii(0x1009_c53a, 1); push(edi);                              /* push edi */
            ii(0x1009_c53b, 1); push(ebp);                              /* push ebp */
            ii(0x1009_c53c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c53e, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1009_c544, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_c547, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_c54a, 5); call(0x1007_6c30, -0x2_591f);           /* call 0x10076c30 */
            ii(0x1009_c54f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_c552, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1009_c555, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c557, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_c558, 1); pop(edi);                               /* pop edi */
            ii(0x1009_c559, 1); pop(esi);                               /* pop esi */
            ii(0x1009_c55a, 1); pop(edx);                               /* pop edx */
            ii(0x1009_c55b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_c55c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_c55d, 1); ret();                                  /* ret */
        }
    }
}

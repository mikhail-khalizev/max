using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_80e4-97061845")]
        public void Method_1014_80e4()
        {
            ii(0x1014_80e4, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_80e9, 5); call(Definitions.sys_check_available_stack_size, 0x1_dc64); /* call 0x10165d52 */
            ii(0x1014_80ee, 1); push(ebx);                              /* push ebx */
            ii(0x1014_80ef, 1); push(ecx);                              /* push ecx */
            ii(0x1014_80f0, 1); push(edx);                              /* push edx */
            ii(0x1014_80f1, 1); push(esi);                              /* push esi */
            ii(0x1014_80f2, 1); push(edi);                              /* push edi */
            ii(0x1014_80f3, 1); push(ebp);                              /* push ebp */
            ii(0x1014_80f4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_80f6, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1014_80fc, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_80ff, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_8102, 3); add(eax, 6);                            /* add eax, 0x6 */
            ii(0x1014_8105, 5); call(0x1014_81a4, 0x9a);                /* call 0x101481a4 */
            ii(0x1014_810a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_810d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_8110, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8112, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_8113, 1); pop(edi);                               /* pop edi */
            ii(0x1014_8114, 1); pop(esi);                               /* pop esi */
            ii(0x1014_8115, 1); pop(edx);                               /* pop edx */
            ii(0x1014_8116, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_8117, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_8118, 1); ret();                                  /* ret */
        }
    }
}

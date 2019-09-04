using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_cab7-4e90d75e")]
        public void Method_1007_cab7()
        {
            ii(0x1007_cab7, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_cabc, 5); call(Definitions.sys_check_available_stack_size, 0xe_9291); /* call 0x10165d52 */
            ii(0x1007_cac1, 1); push(ebx);                              /* push ebx */
            ii(0x1007_cac2, 1); push(ecx);                              /* push ecx */
            ii(0x1007_cac3, 1); push(edx);                              /* push edx */
            ii(0x1007_cac4, 1); push(esi);                              /* push esi */
            ii(0x1007_cac5, 1); push(edi);                              /* push edi */
            ii(0x1007_cac6, 1); push(ebp);                              /* push ebp */
            ii(0x1007_cac7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_cac9, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_cacf, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_cad2, 7); mov(memd[ss, ebp - 8], 4);              /* mov dword [ebp-0x8], 0x4 */
            ii(0x1007_cad9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_cadc, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_cade, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_cadf, 1); pop(edi);                               /* pop edi */
            ii(0x1007_cae0, 1); pop(esi);                               /* pop esi */
            ii(0x1007_cae1, 1); pop(edx);                               /* pop edx */
            ii(0x1007_cae2, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_cae3, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_cae4, 1); ret();                                  /* ret */
        }
    }
}

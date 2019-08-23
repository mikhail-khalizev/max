using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c8fc-f1291ba9")]
        public void Method_1013_c8fc()
        {
            ii(0x1013_c8fc, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c901, 5); call(Definitions.sys_check_available_stack_size, 0x2_944c); /* call 0x10165d52 */
            ii(0x1013_c906, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c907, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c908, 1); push(edx);                              /* push edx */
            ii(0x1013_c909, 1); push(esi);                              /* push esi */
            ii(0x1013_c90a, 1); push(edi);                              /* push edi */
            ii(0x1013_c90b, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c90c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c90e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1013_c914, 5); mov(eax, 0x101b_d4e0);                  /* mov eax, 0x101bd4e0 */
            ii(0x1013_c919, 5); call(/* sys */ 0x1016_611f, 0x2_9801);  /* call 0x1016611f */
            ii(0x1013_c91e, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1013_c923, 5); call(0x1013_c944, 0x1c);                /* call 0x1013c944 */
            ii(0x1013_c928, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c92b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c92e, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_c931, 10); mov(memd[ds, 0x101b_d4e8], 0x1);       /* mov dword [0x101bd4e8], 0x1 */
            ii(0x1013_c93b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c93d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c93e, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c93f, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c940, 1); pop(edx);                               /* pop edx */
            ii(0x1013_c941, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c942, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c943, 1); ret();                                  /* ret */
        }
    }
}

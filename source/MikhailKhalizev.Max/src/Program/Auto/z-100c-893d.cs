using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_893d-676ee81")]
        public void Method_100c_893d()
        {
            ii(0x100c_893d, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_8942, 5); call(Definitions.sys_check_available_stack_size, 0x9_d40b); /* call 0x10165d52 */
            ii(0x100c_8947, 1); push(ebx);                              /* push ebx */
            ii(0x100c_8948, 1); push(ecx);                              /* push ecx */
            ii(0x100c_8949, 1); push(esi);                              /* push esi */
            ii(0x100c_894a, 1); push(edi);                              /* push edi */
            ii(0x100c_894b, 1); push(ebp);                              /* push ebp */
            ii(0x100c_894c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_894e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_8954, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_8957, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_895a, 5); mov(edx, StringDefinitions.FrontierDeterminingAssistant); /* mov edx, 0x101a1339 */
            ii(0x100c_895f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_8962, 5); call(Definitions.sys_strcpy, 0x9_d568); /* call 0x10165ecf */
            ii(0x100c_8967, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_896a, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_896d, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_8970, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8972, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_8973, 1); pop(edi);                               /* pop edi */
            ii(0x100c_8974, 1); pop(esi);                               /* pop esi */
            ii(0x100c_8975, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_8976, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_8977, 1); ret();                                  /* ret */
        }
    }
}

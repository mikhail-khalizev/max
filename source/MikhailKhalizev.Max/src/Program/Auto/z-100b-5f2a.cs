using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5f2a-c018628b")]
        public void Method_100b_5f2a()
        {
            ii(0x100b_5f2a, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_5f2f, 5); call(Definitions.sys_check_available_stack_size, 0xa_fe1e); /* call 0x10165d52 */
            ii(0x100b_5f34, 1); push(ebx);                              /* push ebx */
            ii(0x100b_5f35, 1); push(ecx);                              /* push ecx */
            ii(0x100b_5f36, 1); push(esi);                              /* push esi */
            ii(0x100b_5f37, 1); push(edi);                              /* push edi */
            ii(0x100b_5f38, 1); push(ebp);                              /* push ebp */
            ii(0x100b_5f39, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_5f3b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_5f41, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_5f44, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_5f47, 5); mov(edx, StringDefinitions.UseTransportsToSpeedMovement); /* mov edx, 0x101a1137 */
            ii(0x100b_5f4c, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_5f4f, 5); call(Definitions.sys_strcpy, 0xa_ff7b); /* call 0x10165ecf */
            ii(0x100b_5f54, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_5f57, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100b_5f5a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_5f5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_5f5f, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_5f60, 1); pop(edi);                               /* pop edi */
            ii(0x100b_5f61, 1); pop(esi);                               /* pop esi */
            ii(0x100b_5f62, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_5f63, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_5f64, 1); ret();                                  /* ret */
        }
    }
}

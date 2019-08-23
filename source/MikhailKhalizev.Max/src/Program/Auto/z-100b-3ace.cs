using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3ace-647dd500")]
        public void Method_100b_3ace()
        {
            ii(0x100b_3ace, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_3ad3, 5); call(Definitions.sys_check_available_stack_size, 0xb_227a); /* call 0x10165d52 */
            ii(0x100b_3ad8, 1); push(ebx);                              /* push ebx */
            ii(0x100b_3ad9, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3ada, 1); push(edx);                              /* push edx */
            ii(0x100b_3adb, 1); push(esi);                              /* push esi */
            ii(0x100b_3adc, 1); push(edi);                              /* push edi */
            ii(0x100b_3add, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3ade, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3ae0, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_3ae6, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_3ae9, 7); mov(memd[ss, ebp - 0x8], 0x4);          /* mov dword [ebp-0x8], 0x4 */
            ii(0x100b_3af0, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_3af3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_3af5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_3af6, 1); pop(edi);                               /* pop edi */
            ii(0x100b_3af7, 1); pop(esi);                               /* pop esi */
            ii(0x100b_3af8, 1); pop(edx);                               /* pop edx */
            ii(0x100b_3af9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3afa, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3afb, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_e1fb-4a279bc0")]
        public void Method_1007_e1fb()
        {
            ii(0x1007_e1fb, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_e200, 5); call(Definitions.sys_check_available_stack_size, 0xe_7b4d); /* call 0x10165d52 */
            ii(0x1007_e205, 1); push(ebx);                              /* push ebx */
            ii(0x1007_e206, 1); push(ecx);                              /* push ecx */
            ii(0x1007_e207, 1); push(esi);                              /* push esi */
            ii(0x1007_e208, 1); push(edi);                              /* push edi */
            ii(0x1007_e209, 1); push(ebp);                              /* push ebp */
            ii(0x1007_e20a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_e20c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_e212, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_e215, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_e218, 5); mov(edx, StringDefinitions.DefenseReserve); /* mov edx, 0x101a01a8 */
            ii(0x1007_e21d, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_e220, 5); call(Definitions.sys_strcpy, 0xe_7caa); /* call 0x10165ecf */
            ii(0x1007_e225, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_e228, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1007_e22b, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1007_e22e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_e230, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_e231, 1); pop(edi);                               /* pop edi */
            ii(0x1007_e232, 1); pop(esi);                               /* pop esi */
            ii(0x1007_e233, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_e234, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_e235, 1); ret();                                  /* ret */
        }
    }
}

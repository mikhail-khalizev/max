using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_350b-59869ebd")]
        public void Method_1009_350b()
        {
            ii(0x1009_350b, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_3510, 5); call(Definitions.sys_check_available_stack_size, 0xd_283d); /* call 0x10165d52 */
            ii(0x1009_3515, 1); push(ebx);                              /* push ebx */
            ii(0x1009_3516, 1); push(ecx);                              /* push ecx */
            ii(0x1009_3517, 1); push(esi);                              /* push esi */
            ii(0x1009_3518, 1); push(edi);                              /* push edi */
            ii(0x1009_3519, 1); push(ebp);                              /* push ebp */
            ii(0x1009_351a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_351c, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_3522, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_3525, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_3528, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_352b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_352e, 3); add(eax, 0x21);                         /* add eax, 0x21 */
            ii(0x1009_3531, 5); call(0x1009_c698, 0x9162);              /* call 0x1009c698 */
            ii(0x1009_3536, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_3539, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_353e, 5); call(0x100a_4d50, 0x1_180d);            /* call 0x100a4d50 */
            ii(0x1009_3543, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_3545, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_3546, 1); pop(edi);                               /* pop edi */
            ii(0x1009_3547, 1); pop(esi);                               /* pop esi */
            ii(0x1009_3548, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_3549, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_354a, 1); ret();                                  /* ret */
        }
    }
}

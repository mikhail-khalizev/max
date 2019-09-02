using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a414-d9eee5fa")]
        public void Method_100c_a414()
        {
            ii(0x100c_a414, 5); push(0x24);                             /* push 0x24 */
            ii(0x100c_a419, 5); call(Definitions.sys_check_available_stack_size, 0x9_b934); /* call 0x10165d52 */
            ii(0x100c_a41e, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a41f, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a420, 1); push(esi);                              /* push esi */
            ii(0x100c_a421, 1); push(edi);                              /* push edi */
            ii(0x100c_a422, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a423, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a425, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_a42b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a42e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100c_a431, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100c_a436, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a439, 5); call(Definitions.my_dtor_0x101b_6edc, 0x7_0807); /* call 0x1013ac45 */
            ii(0x100c_a43e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100c_a441, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100c_a444, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a447, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100c_a44a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a44c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a44d, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a44e, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a44f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a450, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a451, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fe27-e1db6112")]
        public void Method_1011_fe27()
        {
            ii(0x1011_fe27, 5); push(0x20);                             /* push 0x20 */
            ii(0x1011_fe2c, 5); call(Definitions.sys_check_available_stack_size, 0x4_5f21); /* call 0x10165d52 */
            ii(0x1011_fe31, 1); push(ebx);                              /* push ebx */
            ii(0x1011_fe32, 1); push(ecx);                              /* push ecx */
            ii(0x1011_fe33, 1); push(edx);                              /* push edx */
            ii(0x1011_fe34, 1); push(esi);                              /* push esi */
            ii(0x1011_fe35, 1); push(edi);                              /* push edi */
            ii(0x1011_fe36, 1); push(ebp);                              /* push ebp */
            ii(0x1011_fe37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fe39, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1011_fe3f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1011_fe42, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1011_fe45, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fe4a, 5); call(0x1011_e50b, -0x1944);             /* call 0x1011e50b */
            ii(0x1011_fe4f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fe51, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_fe52, 1); pop(edi);                               /* pop edi */
            ii(0x1011_fe53, 1); pop(esi);                               /* pop esi */
            ii(0x1011_fe54, 1); pop(edx);                               /* pop edx */
            ii(0x1011_fe55, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_fe56, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_fe57, 1); ret();                                  /* ret */
        }
    }
}

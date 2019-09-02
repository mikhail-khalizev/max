using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_8aaa-4045c1b4")]
        public void Method_1015_8aaa()
        {
            ii(0x1015_8aaa, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_8aaf, 5); call(Definitions.sys_check_available_stack_size, 0xd29e); /* call 0x10165d52 */
            ii(0x1015_8ab4, 1); push(ebx);                              /* push ebx */
            ii(0x1015_8ab5, 1); push(ecx);                              /* push ecx */
            ii(0x1015_8ab6, 1); push(esi);                              /* push esi */
            ii(0x1015_8ab7, 1); push(edi);                              /* push edi */
            ii(0x1015_8ab8, 1); push(ebp);                              /* push ebp */
            ii(0x1015_8ab9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_8abb, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_8ac1, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_8ac4, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_8ac7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_8aca, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1015_8acd, 5); mov(eax, 1);                            /* mov eax, 0x1 */
            ii(0x1015_8ad2, 5); call(0x100f_448c, -0x6_464b);           /* call 0x100f448c */
            ii(0x1015_8ad7, 5); mov(ebx, 0x18);                         /* mov ebx, 0x18 */
            ii(0x1015_8adc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_8ade, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1015_8ae1, 5); call(0x1016_3053, 0xa56d);              /* call 0x10163053 */
            ii(0x1015_8ae6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_8ae8, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_8ae9, 1); pop(edi);                               /* pop edi */
            ii(0x1015_8aea, 1); pop(esi);                               /* pop esi */
            ii(0x1015_8aeb, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_8aec, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_8aed, 1); ret();                                  /* ret */
        }
    }
}

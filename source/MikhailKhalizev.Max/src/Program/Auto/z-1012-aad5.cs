using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_aad5-2b76c954")]
        public void Method_1012_aad5()
        {
            ii(0x1012_aad5, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_aada, 5); call(Definitions.sys_check_available_stack_size, 0x3_b273); /* call 0x10165d52 */
            ii(0x1012_aadf, 1); push(ecx);                              /* push ecx */
            ii(0x1012_aae0, 1); push(esi);                              /* push esi */
            ii(0x1012_aae1, 1); push(edi);                              /* push edi */
            ii(0x1012_aae2, 1); push(ebp);                              /* push ebp */
            ii(0x1012_aae3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_aae5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_aaeb, 3); mov(memb[ss, ebp - 0x4], al);           /* mov [ebp-0x4], al */
            ii(0x1012_aaee, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1012_aaf1, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x1012_aaf4, 3); mov(al, memb[ss, ebp - 0x4]);           /* mov al, [ebp-0x4] */
            ii(0x1012_aaf7, 5); mov(memb[ds, 0x101c_5c1c], al);         /* mov [0x101c5c1c], al */
            ii(0x1012_aafc, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_aaff, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_ab05, 9); mov(memw[ds, 0x101c_5c1f], 0x6);        /* mov word [0x101c5c1f], 0x6 */
            ii(0x1012_ab0e, 7); mov(memd[ss, ebp - 0x10], 0x101c_5c21); /* mov dword [ebp-0x10], 0x101c5c21 */
            ii(0x1012_ab15, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_ab18, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_ab1b, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1012_ab1e, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1012_ab23, 5); call(0x1012_5be9, -0x4f3f);             /* call 0x10125be9 */
            ii(0x1012_ab28, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_ab2a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_ab2b, 1); pop(edi);                               /* pop edi */
            ii(0x1012_ab2c, 1); pop(esi);                               /* pop esi */
            ii(0x1012_ab2d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_ab2e, 1); ret();                                  /* ret */
        }
    }
}

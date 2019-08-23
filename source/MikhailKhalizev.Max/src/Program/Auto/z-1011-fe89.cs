using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fe89-a0188b3")]
        public void Method_1011_fe89()
        {
            ii(0x1011_fe89, 5); push(0x24);                             /* push 0x24 */
            ii(0x1011_fe8e, 5); call(Definitions.sys_check_available_stack_size, 0x4_5ebf); /* call 0x10165d52 */
            ii(0x1011_fe93, 1); push(ebx);                              /* push ebx */
            ii(0x1011_fe94, 1); push(ecx);                              /* push ecx */
            ii(0x1011_fe95, 1); push(edx);                              /* push edx */
            ii(0x1011_fe96, 1); push(esi);                              /* push esi */
            ii(0x1011_fe97, 1); push(edi);                              /* push edi */
            ii(0x1011_fe98, 1); push(ebp);                              /* push ebp */
            ii(0x1011_fe99, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fe9b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1011_fea1, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_fea4, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1011_fea8, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fead, 5); call(0x1011_de3c, -0x2076);             /* call 0x1011de3c */
            ii(0x1011_feb2, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_feb5, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_feb8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_feba, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_febb, 1); pop(edi);                               /* pop edi */
            ii(0x1011_febc, 1); pop(esi);                               /* pop esi */
            ii(0x1011_febd, 1); pop(edx);                               /* pop edx */
            ii(0x1011_febe, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_febf, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_fec0, 1); ret();                                  /* ret */
        }
    }
}

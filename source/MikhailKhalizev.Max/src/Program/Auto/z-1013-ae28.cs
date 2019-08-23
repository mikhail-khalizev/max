using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_ae28-cf8ef9e5")]
        public void Method_1013_ae28()
        {
            ii(0x1013_ae28, 5); push(0x20);                             /* push 0x20 */
            ii(0x1013_ae2d, 5); call(Definitions.sys_check_available_stack_size, 0x2_af20); /* call 0x10165d52 */
            ii(0x1013_ae32, 1); push(ebx);                              /* push ebx */
            ii(0x1013_ae33, 1); push(ecx);                              /* push ecx */
            ii(0x1013_ae34, 1); push(edx);                              /* push edx */
            ii(0x1013_ae35, 1); push(esi);                              /* push esi */
            ii(0x1013_ae36, 1); push(edi);                              /* push edi */
            ii(0x1013_ae37, 1); push(ebp);                              /* push ebp */
            ii(0x1013_ae38, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_ae3a, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1013_ae40, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_ae43, 4); cmp(memd[ss, ebp - 0x4], 0);            /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1013_ae47, 2); if(jz(0x1013_ae4f, 0x6)) goto l_0x1013_ae4f; /* jz 0x1013ae4f */
            ii(0x1013_ae49, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_ae4c, 3); inc(memw[ds, eax]);                     /* inc word [eax] */
        l_0x1013_ae4f:
            ii(0x1013_ae4f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_ae51, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_ae52, 1); pop(edi);                               /* pop edi */
            ii(0x1013_ae53, 1); pop(esi);                               /* pop esi */
            ii(0x1013_ae54, 1); pop(edx);                               /* pop edx */
            ii(0x1013_ae55, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_ae56, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_ae57, 1); ret();                                  /* ret */
        }
    }
}

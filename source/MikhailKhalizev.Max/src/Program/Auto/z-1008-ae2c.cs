using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_ae2c-85f9ac8a")]
        public void Method_1008_ae2c()
        {
            ii(0x1008_ae2c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_ae31, 5); call(Definitions.sys_check_available_stack_size, 0xd_af1c); /* call 0x10165d52 */
            ii(0x1008_ae36, 1); push(ebx);                              /* push ebx */
            ii(0x1008_ae37, 1); push(ecx);                              /* push ecx */
            ii(0x1008_ae38, 1); push(esi);                              /* push esi */
            ii(0x1008_ae39, 1); push(edi);                              /* push edi */
            ii(0x1008_ae3a, 1); push(ebp);                              /* push ebp */
            ii(0x1008_ae3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_ae3d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_ae43, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_ae46, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1008_ae49, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1008_ae4c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ae4f, 5); call(0x1007_6cd0, -0x1_4184);           /* call 0x10076cd0 */
            ii(0x1008_ae54, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1008_ae57, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1008_ae5a, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1008_ae5d, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1008_ae60, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1008_ae63, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1008_ae66, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_ae68, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_ae69, 1); pop(edi);                               /* pop edi */
            ii(0x1008_ae6a, 1); pop(esi);                               /* pop esi */
            ii(0x1008_ae6b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_ae6c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_ae6d, 1); ret();                                  /* ret */
        }
    }
}

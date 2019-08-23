using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_4bde-cc3929e7")]
        public void Method_1007_4bde()
        {
            ii(0x1007_4bde, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_4be3, 5); call(Definitions.sys_check_available_stack_size, 0xf_116a); /* call 0x10165d52 */
            ii(0x1007_4be8, 1); push(ebx);                              /* push ebx */
            ii(0x1007_4be9, 1); push(ecx);                              /* push ecx */
            ii(0x1007_4bea, 1); push(esi);                              /* push esi */
            ii(0x1007_4beb, 1); push(edi);                              /* push edi */
            ii(0x1007_4bec, 1); push(ebp);                              /* push ebp */
            ii(0x1007_4bed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_4bef, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_4bf5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_4bf8, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_4bfb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_4bfe, 3); mov(ebx, memd[ds, eax + 0x1a]);         /* mov ebx, [eax+0x1a] */
            ii(0x1007_4c01, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1007_4c04, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_4c07, 3); mov(edx, memd[ds, eax + 0x18]);         /* mov edx, [eax+0x18] */
            ii(0x1007_4c0a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1007_4c0d, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1007_4c10, 5); call(0x1007_6aac, 0x1e97);              /* call 0x10076aac */
            ii(0x1007_4c15, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1007_4c17, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_4c1a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_4c1d, 5); call(0x1007_4b2b, -0xf7);               /* call 0x10074b2b */
            ii(0x1007_4c22, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
            ii(0x1007_4c25, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x1007_4c28, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_4c2a, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_4c2b, 1); pop(edi);                               /* pop edi */
            ii(0x1007_4c2c, 1); pop(esi);                               /* pop esi */
            ii(0x1007_4c2d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_4c2e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_4c2f, 1); ret();                                  /* ret */
        }
    }
}

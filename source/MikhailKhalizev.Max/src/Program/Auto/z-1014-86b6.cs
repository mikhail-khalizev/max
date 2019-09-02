using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_86b6-833580e8")]
        public void Method_1014_86b6()
        {
            ii(0x1014_86b6, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_86bb, 5); call(Definitions.sys_check_available_stack_size, 0x1_d692); /* call 0x10165d52 */
            ii(0x1014_86c0, 1); push(ebx);                              /* push ebx */
            ii(0x1014_86c1, 1); push(ecx);                              /* push ecx */
            ii(0x1014_86c2, 1); push(esi);                              /* push esi */
            ii(0x1014_86c3, 1); push(edi);                              /* push edi */
            ii(0x1014_86c4, 1); push(ebp);                              /* push ebp */
            ii(0x1014_86c5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_86c7, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_86cd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_86d0, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1014_86d3, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1014_86d6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_86d9, 5); call(0x1014_8648, -0x96);               /* call 0x10148648 */
            ii(0x1014_86de, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_86e1, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1014_86e4, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_86e7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_86ea, 7); mov(memd[ds, eax + 2], 0x101b_7304);    /* mov dword [eax+0x2], 0x101b7304 */
            ii(0x1014_86f1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1014_86f4, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1014_86f7, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1014_86fa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_86fc, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_86fd, 1); pop(edi);                               /* pop edi */
            ii(0x1014_86fe, 1); pop(esi);                               /* pop esi */
            ii(0x1014_86ff, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_8700, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_8701, 1); ret();                                  /* ret */
        }
    }
}

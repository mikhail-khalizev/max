using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_f127-1dc97966")]
        public void Method_1007_f127()
        {
            ii(0x1007_f127, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_f12c, 5); call(Definitions.sys_check_available_stack_size, 0xe_6c21); /* call 0x10165d52 */
            ii(0x1007_f131, 1); push(ebx);                              /* push ebx */
            ii(0x1007_f132, 1); push(ecx);                              /* push ecx */
            ii(0x1007_f133, 1); push(edx);                              /* push edx */
            ii(0x1007_f134, 1); push(esi);                              /* push esi */
            ii(0x1007_f135, 1); push(edi);                              /* push edi */
            ii(0x1007_f136, 1); push(ebp);                              /* push ebp */
            ii(0x1007_f137, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f139, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_f13f, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1007_f142, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1007_f145, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_f148, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f14b, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1007_f14e, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1007_f151, 3); call_abs(memd[ds, edx + 0x4c]);         /* call dword [edx+0x4c] */
            ii(0x1007_f154, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f156, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_f157, 1); pop(edi);                               /* pop edi */
            ii(0x1007_f158, 1); pop(esi);                               /* pop esi */
            ii(0x1007_f159, 1); pop(edx);                               /* pop edx */
            ii(0x1007_f15a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_f15b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_f15c, 1); ret();                                  /* ret */
        }
    }
}

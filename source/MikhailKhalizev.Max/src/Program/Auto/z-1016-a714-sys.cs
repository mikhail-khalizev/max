using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_a714-8effc8d0")]
        public void /* sys */ Method_1016_a714()
        {
            ii(0x1016_a714, 1); push(esi);                              /* push esi */
            ii(0x1016_a715, 1); push(edi);                              /* push edi */
            ii(0x1016_a716, 1); push(ebp);                              /* push ebp */
            ii(0x1016_a717, 3); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1016_a71a, 2); mov(edi, eax);                          /* mov edi, eax */
            ii(0x1016_a71c, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_a71e, 3); mov(memd[ss, esp], ebx);                /* mov [esp], ebx */
            ii(0x1016_a721, 2); mov(ebp, ecx);                          /* mov ebp, ecx */
            ii(0x1016_a723, 4); mov(edx, memd[ss, esp + 0x1c]);         /* mov edx, [esp+0x1c] */
            ii(0x1016_a727, 1); push(edx);                              /* push edx */
            ii(0x1016_a728, 1); push(ecx);                              /* push ecx */
            ii(0x1016_a729, 4); mov(ebx, memd[ss, esp + 0x1c]);         /* mov ebx, [esp+0x1c] */
            ii(0x1016_a72d, 1); push(ebx);                              /* push ebx */
            ii(0x1016_a72e, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_a730, 4); mov(ebx, memd[ss, esp + 0xc]);          /* mov ebx, [esp+0xc] */
            ii(0x1016_a734, 5); call(/* sys */ 0x1016_a5a0, -0x199);    /* call 0x1016a5a0 */
            ii(0x1016_a739, 4); mov(ecx, memd[ss, esp + 0x20]);         /* mov ecx, [esp+0x20] */
            ii(0x1016_a73d, 1); push(ecx);                              /* push ecx */
            ii(0x1016_a73e, 4); mov(eax, memd[ss, esp + 0x1c]);         /* mov eax, [esp+0x1c] */
            ii(0x1016_a742, 4); mov(edx, memd[ss, esp + 0x18]);         /* mov edx, [esp+0x18] */
            ii(0x1016_a746, 1); push(eax);                              /* push eax */
            ii(0x1016_a747, 4); mov(ebx, memd[ss, esp + 0x8]);          /* mov ebx, [esp+0x8] */
            ii(0x1016_a74b, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x1016_a74d, 1); push(edx);                              /* push edx */
            ii(0x1016_a74e, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_a750, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_a752, 5); call(/* sys */ 0x1016_a5a0, -0x1b7);    /* call 0x1016a5a0 */
            ii(0x1016_a757, 4); mov(ebx, memd[ss, esp + 0x1c]);         /* mov ebx, [esp+0x1c] */
            ii(0x1016_a75b, 1); push(ebx);                              /* push ebx */
            ii(0x1016_a75c, 4); mov(ecx, memd[ss, esp + 0x1c]);         /* mov ecx, [esp+0x1c] */
            ii(0x1016_a760, 4); mov(eax, memd[ss, esp + 0x4]);          /* mov eax, [esp+0x4] */
            ii(0x1016_a764, 1); push(ecx);                              /* push ecx */
            ii(0x1016_a765, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_a767, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x1016_a769, 1); push(eax);                              /* push eax */
            ii(0x1016_a76a, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1016_a76c, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_a76e, 5); call(/* sys */ 0x1016_a5a0, -0x1d3);    /* call 0x1016a5a0 */
            ii(0x1016_a773, 4); mov(edx, memd[ss, esp + 0x20]);         /* mov edx, [esp+0x20] */
            ii(0x1016_a777, 1); push(edx);                              /* push edx */
            ii(0x1016_a778, 4); mov(ebx, memd[ss, esp + 0x1c]);         /* mov ebx, [esp+0x1c] */
            ii(0x1016_a77c, 4); mov(ecx, memd[ss, esp + 0x18]);         /* mov ecx, [esp+0x18] */
            ii(0x1016_a780, 1); push(ebx);                              /* push ebx */
            ii(0x1016_a781, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1016_a783, 2); mov(edx, esi);                          /* mov edx, esi */
            ii(0x1016_a785, 1); push(ecx);                              /* push ecx */
            ii(0x1016_a786, 4); mov(ebx, memd[ss, esp + 0x20]);         /* mov ebx, [esp+0x20] */
            ii(0x1016_a78a, 2); mov(ecx, ebp);                          /* mov ecx, ebp */
            ii(0x1016_a78c, 5); call(/* sys */ 0x1016_a5a0, -0x1f1);    /* call 0x1016a5a0 */
            ii(0x1016_a791, 3); add(esp, 0x4);                          /* add esp, 0x4 */
            ii(0x1016_a794, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_a795, 1); pop(edi);                               /* pop edi */
            ii(0x1016_a796, 1); pop(esi);                               /* pop esi */
            ii(0x1016_a797, 3); ret(0x10);                              /* ret 0x10 */
        }
    }
}

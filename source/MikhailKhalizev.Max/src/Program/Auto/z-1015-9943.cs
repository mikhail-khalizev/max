using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9943-905efb1a")]
        public void Method_1015_9943()
        {
            ii(0x1015_9943, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_9948, 5); call(Definitions.sys_check_available_stack_size, 0xc405); /* call 0x10165d52 */
            ii(0x1015_994d, 1); push(ebx);                              /* push ebx */
            ii(0x1015_994e, 1); push(ecx);                              /* push ecx */
            ii(0x1015_994f, 1); push(esi);                              /* push esi */
            ii(0x1015_9950, 1); push(edi);                              /* push edi */
            ii(0x1015_9951, 1); push(ebp);                              /* push ebp */
            ii(0x1015_9952, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9954, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_995a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_995d, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9960, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_9963, 4); cmp(memb[ds, eax + 0x3d], 0x7);         /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1015_9967, 2); if(jnz(0x1015_999f, 0x36)) goto l_0x1015_999f; /* jnz 0x1015999f */
            ii(0x1015_9969, 5); mov(eax, 0x1015_9906);                  /* mov eax, 0x10159906 */
            ii(0x1015_996e, 1); push(eax);                              /* push eax */
            ii(0x1015_996f, 5); mov(ecx, 0x31);                         /* mov ecx, 0x31 */
            ii(0x1015_9974, 5); mov(ebx, StringDefinitions.Resrch);     /* mov ebx, 0x101b2645 */
            ii(0x1015_9979, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_997b, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_997e, 5); call(0x1015_7ccf, -0x1cb4);             /* call 0x10157ccf */
            ii(0x1015_9983, 5); mov(eax, 0x1015_9712);                  /* mov eax, 0x10159712 */
            ii(0x1015_9988, 1); push(eax);                              /* push eax */
            ii(0x1015_9989, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1015_998e, 5); mov(ebx, StringDefinitions.Stop4);      /* mov ebx, 0x101b264c */
            ii(0x1015_9993, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9995, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9998, 5); call(0x1015_7ccf, -0x1cce);             /* call 0x10157ccf */
            ii(0x1015_999d, 2); jmp(0x1015_99b9, 0x1a); goto l_0x1015_99b9; /* jmp 0x101599b9 */
        l_0x1015_999f:
            ii(0x1015_999f, 5); mov(eax, 0x1015_9680);                  /* mov eax, 0x10159680 */
            ii(0x1015_99a4, 1); push(eax);                              /* push eax */
            ii(0x1015_99a5, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1015_99aa, 5); mov(ebx, StringDefinitions.Start2);     /* mov ebx, 0x101b2651 */
            ii(0x1015_99af, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_99b1, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_99b4, 5); call(0x1015_7ccf, -0x1cea);             /* call 0x10157ccf */
        l_0x1015_99b9:
            ii(0x1015_99b9, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1015_99bc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_99bf, 5); call(0x1015_8bbb, -0xe09);              /* call 0x10158bbb */
            ii(0x1015_99c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_99c6, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_99c7, 1); pop(edi);                               /* pop edi */
            ii(0x1015_99c8, 1); pop(esi);                               /* pop esi */
            ii(0x1015_99c9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_99ca, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_99cb, 1); ret();                                  /* ret */
        }
    }
}

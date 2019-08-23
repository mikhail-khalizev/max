using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0700-3967b14d")]
        public void Method_100d_0700()
        {
            ii(0x100d_0700, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_0705, 5); call(Definitions.sys_check_available_stack_size, 0x9_5648); /* call 0x10165d52 */
            ii(0x100d_070a, 1); push(ebx);                              /* push ebx */
            ii(0x100d_070b, 1); push(ecx);                              /* push ecx */
            ii(0x100d_070c, 1); push(esi);                              /* push esi */
            ii(0x100d_070d, 1); push(edi);                              /* push edi */
            ii(0x100d_070e, 1); push(ebp);                              /* push ebp */
            ii(0x100d_070f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0711, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100d_0717, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_071a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_071d, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0720, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_0723, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_0726, 3); mov(ecx, memd[ds, eax + 0x40]);         /* mov ecx, [eax+0x40] */
            ii(0x100d_0729, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_072c, 3); add(eax, 0x1e);                         /* add eax, 0x1e */
            ii(0x100d_072f, 5); call(Definitions.my_2_get_count, -0x4_53cc); /* call 0x1008b368 */
            ii(0x100d_0734, 3); movsx(ebx, ax);                         /* movsx ebx, ax */
            ii(0x100d_0737, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100d_073b, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_073e, 3); call_abs(memd[ds, ecx + 0x4]);          /* call dword [ecx+0x4] */
            ii(0x100d_0741, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_0743, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_0744, 1); pop(edi);                               /* pop edi */
            ii(0x100d_0745, 1); pop(esi);                               /* pop esi */
            ii(0x100d_0746, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0747, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_0748, 1); ret();                                  /* ret */
        }
    }
}

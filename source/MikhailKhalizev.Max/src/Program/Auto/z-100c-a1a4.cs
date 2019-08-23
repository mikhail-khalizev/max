using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a1a4-b0f74d57")]
        public void Method_100c_a1a4()
        {
            ii(0x100c_a1a4, 5); push(0x28);                             /* push 0x28 */
            ii(0x100c_a1a9, 5); call(Definitions.sys_check_available_stack_size, 0x9_bba4); /* call 0x10165d52 */
            ii(0x100c_a1ae, 1); push(ebx);                              /* push ebx */
            ii(0x100c_a1af, 1); push(ecx);                              /* push ecx */
            ii(0x100c_a1b0, 1); push(esi);                              /* push esi */
            ii(0x100c_a1b1, 1); push(edi);                              /* push edi */
            ii(0x100c_a1b2, 1); push(ebp);                              /* push ebp */
            ii(0x100c_a1b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_a1b5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100c_a1bb, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a1be, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a1c1, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_a1c4, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a1c7, 5); call(0x1013_aae7, 0x7_091b);            /* call 0x1013aae7 */
            ii(0x100c_a1cc, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a1cf, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100c_a1d2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100c_a1d5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_a1d8, 4); mov(dx, memw[ds, eax + 0x6]);           /* mov dx, [eax+0x6] */
            ii(0x100c_a1dc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a1df, 4); mov(memw[ds, eax + 0x6], dx);           /* mov [eax+0x6], dx */
            ii(0x100c_a1e3, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a1e6, 7); mov(memd[ds, eax + 0x2], 0x101b_5904);  /* mov dword [eax+0x2], 0x101b5904 */
            ii(0x100c_a1ed, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a1f0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_a1f3, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_a1f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_a1f8, 1); pop(ebp);                               /* pop ebp */
            ii(0x100c_a1f9, 1); pop(edi);                               /* pop edi */
            ii(0x100c_a1fa, 1); pop(esi);                               /* pop esi */
            ii(0x100c_a1fb, 1); pop(ecx);                               /* pop ecx */
            ii(0x100c_a1fc, 1); pop(ebx);                               /* pop ebx */
            ii(0x100c_a1fd, 1); ret();                                  /* ret */
        }
    }
}

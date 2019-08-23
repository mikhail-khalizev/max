using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_0617-e2307355")]
        public void Method_100d_0617()
        {
            ii(0x100d_0617, 5); push(0x30);                             /* push 0x30 */
            ii(0x100d_061c, 5); call(Definitions.sys_check_available_stack_size, 0x9_5731); /* call 0x10165d52 */
            ii(0x100d_0621, 1); push(ebx);                              /* push ebx */
            ii(0x100d_0622, 1); push(ecx);                              /* push ecx */
            ii(0x100d_0623, 1); push(esi);                              /* push esi */
            ii(0x100d_0624, 1); push(edi);                              /* push edi */
            ii(0x100d_0625, 1); push(ebp);                              /* push ebp */
            ii(0x100d_0626, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_0628, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x100d_062e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_0631, 3); mov(memb[ss, ebp - 0x4], dl);           /* mov [ebp-0x4], dl */
            ii(0x100d_0634, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100d_0636, 3); mov(bl, memb[ss, ebp - 0x4]);           /* mov bl, [ebp-0x4] */
            ii(0x100d_0639, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_063c, 3); lea(eax, memd[ss, ebp - 0x14]);         /* lea eax, [ebp-0x14] */
            ii(0x100d_063f, 5); call(0x100d_0a87, 0x443);               /* call 0x100d0a87 */
            ii(0x100d_0644, 5); mov(edx, 0x4ff);                        /* mov edx, 0x4ff */
            ii(0x100d_0649, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100d_064e, 5); call(0x1013_dc59, 0x6_d606);            /* call 0x1013dc59 */
            ii(0x100d_0653, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_0656, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x100d_0658, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100d_065b, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_065e, 3); mov(ebx, memd[ds, eax + 0x13]);         /* mov ebx, [eax+0x13] */
            ii(0x100d_0661, 3); lea(edx, memd[ss, ebp - 0x14]);         /* lea edx, [ebp-0x14] */
            ii(0x100d_0664, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100d_0667, 3); call_abs(memd[ds, ebx + 0x4]);          /* call dword [ebx+0x4] */
            ii(0x100d_066a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_066c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_066d, 1); pop(edi);                               /* pop edi */
            ii(0x100d_066e, 1); pop(esi);                               /* pop esi */
            ii(0x100d_066f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_0670, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_0671, 1); ret();                                  /* ret */
        }
    }
}

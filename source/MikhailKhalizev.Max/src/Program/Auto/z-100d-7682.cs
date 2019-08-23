using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_7682-3787e5d6")]
        public void Method_100d_7682()
        {
            ii(0x100d_7682, 5); push(0x24);                             /* push 0x24 */
            ii(0x100d_7687, 5); call(Definitions.sys_check_available_stack_size, 0x8_e6c6); /* call 0x10165d52 */
            ii(0x100d_768c, 1); push(ecx);                              /* push ecx */
            ii(0x100d_768d, 1); push(esi);                              /* push esi */
            ii(0x100d_768e, 1); push(edi);                              /* push edi */
            ii(0x100d_768f, 1); push(ebp);                              /* push ebp */
            ii(0x100d_7690, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_7692, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100d_7698, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_769b, 3); mov(memd[ss, ebp - 0x8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100d_769e, 3); mov(memd[ss, ebp - 0x4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100d_76a1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_76a4, 5); call(0x100d_4dc8, -0x28e1);             /* call 0x100d4dc8 */
            ii(0x100d_76a9, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100d_76ac, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100d_76af, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_76b2, 3); mov(memd[ds, edx + 0x4], eax);          /* mov [edx+0x4], eax */
            ii(0x100d_76b5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_76b8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x100d_76bb, 4); mov(memw[ds, edx + 0x8], ax);           /* mov [edx+0x8], ax */
            ii(0x100d_76bf, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_76c2, 6); mov(memd[ds, eax], 0x101b_5f84);        /* mov dword [eax], 0x101b5f84 */
            ii(0x100d_76c8, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100d_76cb, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100d_76ce, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100d_76d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_76d3, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_76d4, 1); pop(edi);                               /* pop edi */
            ii(0x100d_76d5, 1); pop(esi);                               /* pop esi */
            ii(0x100d_76d6, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_76d7, 1); ret();                                  /* ret */
        }
    }
}

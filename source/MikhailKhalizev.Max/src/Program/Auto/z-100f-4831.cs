using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4831-3cb335f3")]
        public void Method_100f_4831()
        {
            ii(0x100f_4831, 5); push(0x20);                             /* push 0x20 */
            ii(0x100f_4836, 5); call(Definitions.sys_check_available_stack_size, 0x7_1517); /* call 0x10165d52 */
            ii(0x100f_483b, 1); push(ebx);                              /* push ebx */
            ii(0x100f_483c, 1); push(ecx);                              /* push ecx */
            ii(0x100f_483d, 1); push(edx);                              /* push edx */
            ii(0x100f_483e, 1); push(esi);                              /* push esi */
            ii(0x100f_483f, 1); push(edi);                              /* push edi */
            ii(0x100f_4840, 1); push(ebp);                              /* push ebp */
            ii(0x100f_4841, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4843, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100f_4849, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x100f_484c, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x100f_484f, 5); mov(memb[ds, 0x101c_3889], al);         /* mov [0x101c3889], al */
            ii(0x100f_4854, 5); mov(al, memb[ds, 0x101c_3889]);         /* mov al, [0x101c3889] */
            ii(0x100f_4859, 5); mov(memb[ds, 0x101b_8837], al);         /* mov [0x101b8837], al */
            ii(0x100f_485e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4860, 6); mov(dl, memb[ds, 0x101c_3889]);         /* mov dl, [0x101c3889] */
            ii(0x100f_4866, 5); mov(eax, memd[ds, 0x101b_8833]);        /* mov eax, [0x101b8833] */
            ii(0x100f_486b, 5); call(0x100c_fb73, -0x2_4cfd);           /* call 0x100cfb73 */
            ii(0x100f_4870, 5); call(0x100f_f5c1, 0xad4c);              /* call 0x100ff5c1 */
            ii(0x100f_4875, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4877, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_4878, 1); pop(edi);                               /* pop edi */
            ii(0x100f_4879, 1); pop(esi);                               /* pop esi */
            ii(0x100f_487a, 1); pop(edx);                               /* pop edx */
            ii(0x100f_487b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_487c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_487d, 1); ret();                                  /* ret */
        }
    }
}

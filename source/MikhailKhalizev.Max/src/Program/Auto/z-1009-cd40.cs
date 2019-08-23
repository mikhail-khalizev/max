using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_cd40-c6fc4fa5")]
        public void Method_1009_cd40()
        {
            ii(0x1009_cd40, 5); push(0x20);                             /* push 0x20 */
            ii(0x1009_cd45, 5); call(Definitions.sys_check_available_stack_size, 0xc_9008); /* call 0x10165d52 */
            ii(0x1009_cd4a, 1); push(ebx);                              /* push ebx */
            ii(0x1009_cd4b, 1); push(ecx);                              /* push ecx */
            ii(0x1009_cd4c, 1); push(esi);                              /* push esi */
            ii(0x1009_cd4d, 1); push(edi);                              /* push edi */
            ii(0x1009_cd4e, 1); push(ebp);                              /* push ebp */
            ii(0x1009_cd4f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_cd51, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_cd57, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_cd5a, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_cd5d, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_cd60, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_cd63, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_cd66, 5); call(0x1008_ab1c, -0x1_224f);           /* call 0x1008ab1c */
            ii(0x1009_cd6b, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1009_cd6e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_cd71, 5); call(0x1015_27ed, 0xb_5a77);            /* call 0x101527ed */
            ii(0x1009_cd76, 5); call(0x1008_b0e4, -0x1_1c97);           /* call 0x1008b0e4 */
            ii(0x1009_cd7b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_cd7d, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x1009_cd7f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_cd82, 5); call(0x100a_297d, 0x5bf6);              /* call 0x100a297d */
            ii(0x1009_cd87, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_cd89, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_cd8a, 1); pop(edi);                               /* pop edi */
            ii(0x1009_cd8b, 1); pop(esi);                               /* pop esi */
            ii(0x1009_cd8c, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_cd8d, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_cd8e, 1); ret();                                  /* ret */
        }
    }
}

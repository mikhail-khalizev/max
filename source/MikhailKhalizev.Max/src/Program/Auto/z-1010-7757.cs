using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_7757-756c809b")]
        public void Method_1010_7757()
        {
            ii(0x1010_7757, 5); push(0x20);                             /* push 0x20 */
            ii(0x1010_775c, 5); call(Definitions.sys_check_available_stack_size, 0x5_e5f1); /* call 0x10165d52 */
            ii(0x1010_7761, 1); push(ebx);                              /* push ebx */
            ii(0x1010_7762, 1); push(ecx);                              /* push ecx */
            ii(0x1010_7763, 1); push(edx);                              /* push edx */
            ii(0x1010_7764, 1); push(esi);                              /* push esi */
            ii(0x1010_7765, 1); push(edi);                              /* push edi */
            ii(0x1010_7766, 1); push(ebp);                              /* push ebp */
            ii(0x1010_7767, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7769, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x1010_776f, 7); mov(memd[ss, ebp - 4], 0x101c_4da4);    /* mov dword [ebp-0x4], 0x101c4da4 */
            ii(0x1010_7776, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1010_7779, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_777b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_777c, 1); pop(edi);                               /* pop edi */
            ii(0x1010_777d, 1); pop(esi);                               /* pop esi */
            ii(0x1010_777e, 1); pop(edx);                               /* pop edx */
            ii(0x1010_777f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_7780, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_7781, 1); ret();                                  /* ret */
        }
    }
}

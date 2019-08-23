using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5360-6f3a482f")]
        public void Method_100d_5360()
        {
            ii(0x100d_5360, 1); push(ebx);                              /* push ebx */
            ii(0x100d_5361, 1); push(ecx);                              /* push ecx */
            ii(0x100d_5362, 1); push(edx);                              /* push edx */
            ii(0x100d_5363, 1); push(esi);                              /* push esi */
            ii(0x100d_5364, 1); push(edi);                              /* push edi */
            ii(0x100d_5365, 1); push(ebp);                              /* push ebp */
            ii(0x100d_5366, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5368, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100d_536e, 7); mov(memd[ss, ebp - 0x4], 0xffff_ffff);  /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x100d_5375, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5378, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_537a, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_537b, 1); pop(edi);                               /* pop edi */
            ii(0x100d_537c, 1); pop(esi);                               /* pop esi */
            ii(0x100d_537d, 1); pop(edx);                               /* pop edx */
            ii(0x100d_537e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_537f, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_5380, 1); ret();                                  /* ret */
        }
    }
}

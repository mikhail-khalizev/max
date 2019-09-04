using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_533c-6f3a482f")]
        public void Method_100d_533c()
        {
            ii(0x100d_533c, 1); push(ebx);                              /* push ebx */
            ii(0x100d_533d, 1); push(ecx);                              /* push ecx */
            ii(0x100d_533e, 1); push(edx);                              /* push edx */
            ii(0x100d_533f, 1); push(esi);                              /* push esi */
            ii(0x100d_5340, 1); push(edi);                              /* push edi */
            ii(0x100d_5341, 1); push(ebp);                              /* push ebp */
            ii(0x100d_5342, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_5344, 6); sub(esp, 4);                            /* sub esp, 0x4 */
            ii(0x100d_534a, 7); mov(memd[ss, ebp - 4], 0xffff_ffff);    /* mov dword [ebp-0x4], 0xffffffff */
            ii(0x100d_5351, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100d_5354, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_5356, 1); pop(ebp);                               /* pop ebp */
            ii(0x100d_5357, 1); pop(edi);                               /* pop edi */
            ii(0x100d_5358, 1); pop(esi);                               /* pop esi */
            ii(0x100d_5359, 1); pop(edx);                               /* pop edx */
            ii(0x100d_535a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100d_535b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100d_535c, 1); ret();                                  /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f234fee8-3c0a-4735-ab50-dbfabdcd6603")]
        public void Method_1009_963c()
        {
            ii(0x1009_963c, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_9641, 5); calld(Definitions.sys_check_available_stack_size, 0xc_c70c); /* call 0x10165d52 */
            ii(0x1009_9646, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_9647, 1); pushd(esi);                             /* push esi */
            ii(0x1009_9648, 1); pushd(edi);                             /* push edi */
            ii(0x1009_9649, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_964a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_964c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_9652, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_9655, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_9658, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x1009_965b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_965d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_965e, 1); popd(edi);                              /* pop edi */
            ii(0x1009_965f, 1); popd(esi);                              /* pop esi */
            ii(0x1009_9660, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_9661, 1); retd(); return;                         /* ret */
        }
    }
}

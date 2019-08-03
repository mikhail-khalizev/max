using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("bbe3c907-69ec-48c5-8f39-cf81a6c901ff")]
        public void Method_100e_0c54()
        {
            ii(0x100e_0c54, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_0c59, 5); calld(Definitions.sys_check_available_stack_size, 0x850f4); /* call 0x10165d52 */
            ii(0x100e_0c5e, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0c5f, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0c60, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0c61, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0c62, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0c63, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0c65, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_0c6b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0c6e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0c71, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_0c74, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0c77, 5); calld(0x1013_a66b, 0x599ef);            /* call 0x1013a66b */
            ii(0x100e_0c7c, 3); mov(memb_a32[ss, ebp - 0xc], al);       /* mov [ebp-0xc], al */
            ii(0x100e_0c7f, 3); mov(al, memb_a32[ss, ebp - 0xc]);       /* mov al, [ebp-0xc] */
            ii(0x100e_0c82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0c84, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0c85, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0c86, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0c87, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0c88, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0c89, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_9f78-803b37a8")]
        public void Method_100a_9f78()
        {
            ii(0x100a_9f78, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_9f7d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_bdd0); /* call 0x10165d52 */
            ii(0x100a_9f82, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_9f83, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_9f84, 1); pushd(esi);                             /* push esi */
            ii(0x100a_9f85, 1); pushd(edi);                             /* push edi */
            ii(0x100a_9f86, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_9f87, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_9f89, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_9f8f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_9f92, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_9f95, 3); mov(edi, memd_a32[ss, ebp - 0x8]);      /* mov edi, [ebp-0x8] */
            ii(0x100a_9f98, 3); mov(esi, memd_a32[ss, ebp - 0x4]);      /* mov esi, [ebp-0x4] */
            ii(0x100a_9f9b, 1); movsd_a32();                            /* movsd */
            ii(0x100a_9f9c, 1); movsd_a32();                            /* movsd */
            ii(0x100a_9f9d, 1); movsd_a32();                            /* movsd */
            ii(0x100a_9f9e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_9fa1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_9fa4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100a_9fa7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_9fa9, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_9faa, 1); popd(edi);                              /* pop edi */
            ii(0x100a_9fab, 1); popd(esi);                              /* pop esi */
            ii(0x100a_9fac, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_9fad, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_9fae, 1); retd();                                 /* ret */
        }
    }
}

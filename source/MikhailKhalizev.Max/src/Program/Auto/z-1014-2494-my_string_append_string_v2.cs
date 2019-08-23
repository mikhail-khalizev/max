using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_2494-5107f179")]
        public void my_string_append_string_v2()
        {
            ii(0x1014_2494, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_2499, 5); calld(Definitions.sys_check_available_stack_size, 0x2_38b4); /* call 0x10165d52 */
            ii(0x1014_249e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_249f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_24a0, 1); pushd(esi);                             /* push esi */
            ii(0x1014_24a1, 1); pushd(edi);                             /* push edi */
            ii(0x1014_24a2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_24a3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_24a5, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_24ab, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_24ae, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_24b1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_24b4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_24b7, 5); calld(Definitions.my_string_append_string, -0x833); /* call 0x10141c89 */
            ii(0x1014_24bc, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_24bf, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_24c2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_24c4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_24c5, 1); popd(edi);                              /* pop edi */
            ii(0x1014_24c6, 1); popd(esi);                              /* pop esi */
            ii(0x1014_24c7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_24c8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_24c9, 1); retd();                                 /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1e92-d8ca0a2b")]
        public void my_string_strstr_char_ptr()
        {
            ii(0x1014_1e92, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_1e97, 5); calld(Definitions.sys_check_available_stack_size, 0x2_3eb6); /* call 0x10165d52 */
            ii(0x1014_1e9c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1e9d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1e9e, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1e9f, 1); pushd(edi);                             /* push edi */
            ii(0x1014_1ea0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_1ea1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_1ea3, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_1ea9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1eac, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_1eaf, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_1eb2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1eb5, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_1eb7, 5); calld(Definitions.my_strobj_c_str, -0xb_86c0); /* call 0x100897fc */
            ii(0x1014_1ebc, 5); calld(Definitions.sys_strstr, 0x3_714f); /* call 0x10179010 */
            ii(0x1014_1ec1, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_1ec4, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_1ec7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1ec9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_1eca, 1); popd(edi);                              /* pop edi */
            ii(0x1014_1ecb, 1); popd(esi);                              /* pop esi */
            ii(0x1014_1ecc, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_1ecd, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_1ece, 1); retd(); return;                         /* ret */
        }
    }
}

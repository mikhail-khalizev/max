using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("720bb407-f676-40f1-8f74-ef843c83a835")]
        public void Method_100e_c30b()
        {
            ii(0x100e_c30b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_c310, 5); calld(Definitions.sys_check_available_stack_size, 0x7_9a3d); /* call 0x10165d52 */
            ii(0x100e_c315, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_c316, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_c317, 1); pushd(edx);                             /* push edx */
            ii(0x100e_c318, 1); pushd(esi);                             /* push esi */
            ii(0x100e_c319, 1); pushd(edi);                             /* push edi */
            ii(0x100e_c31a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_c31b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c31d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_c323, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_c326, 5); mov(edx, 0x101c_8184);                  /* mov edx, 0x101c8184 */
            ii(0x100e_c32b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c32f, 5); calld(0x100e_c26f, -0xc5);              /* call 0x100ec26f */
            ii(0x100e_c334, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100e_c336, 5); mov(edx, 0x101c_81a8);                  /* mov edx, 0x101c81a8 */
            ii(0x100e_c33b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c33f, 5); calld(0x100e_c26f, -0xd5);              /* call 0x100ec26f */
            ii(0x100e_c344, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_c346, 5); mov(edx, 0x101c_819c);                  /* mov edx, 0x101c819c */
            ii(0x100e_c34b, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c34f, 5); calld(0x100e_c26f, -0xe5);              /* call 0x100ec26f */
            ii(0x100e_c354, 2); add(ebx, eax);                          /* add ebx, eax */
            ii(0x100e_c356, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100e_c359, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_c35c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c35e, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_c35f, 1); popd(edi);                              /* pop edi */
            ii(0x100e_c360, 1); popd(esi);                              /* pop esi */
            ii(0x100e_c361, 1); popd(edx);                              /* pop edx */
            ii(0x100e_c362, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_c363, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_c364, 1); retd(); return;                         /* ret */
        }
    }
}

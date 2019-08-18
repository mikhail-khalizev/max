using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("45d59a1b-d0cf-4345-83a2-ac6de61aa46d")]
        public void Method_100c_893d()
        {
            ii(0x100c_893d, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_8942, 5); calld(Definitions.sys_check_available_stack_size, 0x9_d40b); /* call 0x10165d52 */
            ii(0x100c_8947, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_8948, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_8949, 1); pushd(esi);                             /* push esi */
            ii(0x100c_894a, 1); pushd(edi);                             /* push edi */
            ii(0x100c_894b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_894c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_894e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_8954, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_8957, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_895a, 5); mov(edx, StringDefinitions.FrontierDeterminingAssistant); /* mov edx, 0x101a1339 */
            ii(0x100c_895f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_8962, 5); calld(Definitions.sys_strcpy, 0x9_d568); /* call 0x10165ecf */
            ii(0x100c_8967, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_896a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_896d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_8970, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_8972, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_8973, 1); popd(edi);                              /* pop edi */
            ii(0x100c_8974, 1); popd(esi);                              /* pop esi */
            ii(0x100c_8975, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_8976, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_8977, 1); retd(); return;                         /* ret */
        }
    }
}

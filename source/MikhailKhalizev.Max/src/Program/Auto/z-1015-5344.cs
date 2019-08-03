using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("baa4f698-ee46-414e-ae32-9ad4ff77ecb9")]
        public void Method_1015_5344()
        {
            ii(0x1015_5344, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_5349, 5); calld(Definitions.sys_check_available_stack_size, 0x10a04); /* call 0x10165d52 */
            ii(0x1015_534e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_534f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_5350, 1); pushd(esi);                             /* push esi */
            ii(0x1015_5351, 1); pushd(edi);                             /* push edi */
            ii(0x1015_5352, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_5353, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_5355, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_535b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_535e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_5361, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_5364, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_5367, 5); calld(0x1013_acc5, -0x1a6a7);           /* call 0x1013acc5 */
            ii(0x1015_536c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_536f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1015_5372, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_5374, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_5375, 1); popd(edi);                              /* pop edi */
            ii(0x1015_5376, 1); popd(esi);                              /* pop esi */
            ii(0x1015_5377, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_5378, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_5379, 1); retd(); return;                         /* ret */
        }
    }
}
using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9936eb7-28d3-42d3-a790-bf60f4c5f248")]
        public void Method_1014_8028()
        {
            ii(0x1014_8028, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_802d, 5); calld(Definitions.sys_check_available_stack_size, 0x1_dd20); /* call 0x10165d52 */
            ii(0x1014_8032, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_8033, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_8034, 1); pushd(esi);                             /* push esi */
            ii(0x1014_8035, 1); pushd(edi);                             /* push edi */
            ii(0x1014_8036, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_8037, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_8039, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_803f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8042, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_8045, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_8048, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_804b, 5); calld(0x1013_ac03, -0xd44d);            /* call 0x1013ac03 */
            ii(0x1014_8050, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_8053, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_8056, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_8059, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_805c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_805f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_8062, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_8064, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_8065, 1); popd(edi);                              /* pop edi */
            ii(0x1014_8066, 1); popd(esi);                              /* pop esi */
            ii(0x1014_8067, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_8068, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_8069, 1); retd(); return;                         /* ret */
        }
    }
}
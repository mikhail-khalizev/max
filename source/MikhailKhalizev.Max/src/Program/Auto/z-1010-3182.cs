using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e19b8bbe-089a-4856-a1a5-5c35769408fe")]
        public void Method_1010_3182()
        {
            ii(0x1010_3182, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_3187, 5); calld(Definitions.sys_check_available_stack_size, 0x6_2bc6); /* call 0x10165d52 */
            ii(0x1010_318c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_318d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_318e, 1); pushd(esi);                             /* push esi */
            ii(0x1010_318f, 1); pushd(edi);                             /* push edi */
            ii(0x1010_3190, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_3191, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_3193, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_3199, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_319c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_319f, 5); mov(edx, StringDefinitions.X3);         /* mov edx, 0x101a3156 */
            ii(0x1010_31a4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_31a7, 5); calld(0x1014_60aa, 0x4_2efe);           /* call 0x101460aa */
            ii(0x1010_31ac, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_31ae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_31b1, 4); mov(memw_a32[ds, eax + 0x10], dx);      /* mov [eax+0x10], dx */
            ii(0x1010_31b5, 5); mov(edx, StringDefinitions.Y);          /* mov edx, 0x101a3158 */
            ii(0x1010_31ba, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_31bd, 5); calld(0x1014_60aa, 0x4_2ee8);           /* call 0x101460aa */
            ii(0x1010_31c2, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_31c4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_31c7, 4); mov(memw_a32[ds, eax + 0x12], dx);      /* mov [eax+0x12], dx */
            ii(0x1010_31cb, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_31ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_31d1, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1010_31d4, 5); calld(0x1010_2e9c, -0x33d);             /* call 0x10102e9c */
            ii(0x1010_31d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_31db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_31dc, 1); popd(edi);                              /* pop edi */
            ii(0x1010_31dd, 1); popd(esi);                              /* pop esi */
            ii(0x1010_31de, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_31df, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_31e0, 1); retd(); return;                         /* ret */
        }
    }
}

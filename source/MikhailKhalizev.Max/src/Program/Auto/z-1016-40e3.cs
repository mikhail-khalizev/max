using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da4604d2-c960-49bd-b94c-27962a9c546b")]
        public void Method_1016_40e3()
        {
            ii(0x1016_40e3, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_40e8, 5); calld(Definitions.sys_check_available_stack_size, 0x1c65); /* call 0x10165d52 */
            ii(0x1016_40ed, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_40ee, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_40ef, 1); pushd(esi);                             /* push esi */
            ii(0x1016_40f0, 1); pushd(edi);                             /* push edi */
            ii(0x1016_40f1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_40f2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_40f4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_40fa, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_40fd, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_4100, 5); mov(edx, StringDefinitions.Material);   /* mov edx, 0x101b2b7f */
            ii(0x1016_4105, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4108, 5); calld(0x1014_60aa, -0x1_e063);          /* call 0x101460aa */
            ii(0x1016_410d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_410f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4112, 4); mov(memw_a32[ds, eax + 0x8], dx);       /* mov [eax+0x8], dx */
            ii(0x1016_4116, 5); mov(edx, StringDefinitions.Fuel5);      /* mov edx, 0x101b2b88 */
            ii(0x1016_411b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_411e, 5); calld(0x1014_60aa, -0x1_e079);          /* call 0x101460aa */
            ii(0x1016_4123, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_4125, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4128, 4); mov(memw_a32[ds, eax + 0xa], dx);       /* mov [eax+0xa], dx */
            ii(0x1016_412c, 5); mov(edx, StringDefinitions.Gold7);      /* mov edx, 0x101b2b8d */
            ii(0x1016_4131, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4134, 5); calld(0x1014_60aa, -0x1_e08f);          /* call 0x101460aa */
            ii(0x1016_4139, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_413c, 4); mov(memw_a32[ds, edx + 0xc], ax);       /* mov [edx+0xc], ax */
            ii(0x1016_4140, 5); mov(edx, StringDefinitions.Power8);     /* mov edx, 0x101b2b92 */
            ii(0x1016_4145, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4148, 5); calld(0x1014_60aa, -0x1_e0a3);          /* call 0x101460aa */
            ii(0x1016_414d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_414f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4152, 4); mov(memw_a32[ds, eax + 0xe], dx);       /* mov [eax+0xe], dx */
            ii(0x1016_4156, 5); mov(edx, StringDefinitions.Workers4);   /* mov edx, 0x101b2b98 */
            ii(0x1016_415b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_415e, 5); calld(0x1014_60aa, -0x1_e0b9);          /* call 0x101460aa */
            ii(0x1016_4163, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_4166, 4); mov(memw_a32[ds, edx + 0x10], ax);      /* mov [edx+0x10], ax */
            ii(0x1016_416a, 5); mov(edx, StringDefinitions.Buildings);  /* mov edx, 0x101b2ba0 */
            ii(0x1016_416f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4172, 5); calld(0x1014_60aa, -0x1_e0cd);          /* call 0x101460aa */
            ii(0x1016_4177, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_417a, 4); mov(memw_a32[ds, edx + 0x12], ax);      /* mov [edx+0x12], ax */
            ii(0x1016_417e, 5); mov(edx, StringDefinitions.Id3);        /* mov edx, 0x101b2baa */
            ii(0x1016_4183, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4186, 5); calld(0x1014_60aa, -0x1_e0e1);          /* call 0x101460aa */
            ii(0x1016_418b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1016_418e, 4); mov(memw_a32[ds, edx + 0x14], ax);      /* mov [edx+0x14], ax */
            ii(0x1016_4192, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4194, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4195, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4196, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4197, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4198, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4199, 1); retd(); return;                         /* ret */
        }
    }
}

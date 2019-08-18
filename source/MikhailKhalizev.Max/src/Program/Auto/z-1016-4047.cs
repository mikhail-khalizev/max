using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("01c16580-4465-4fd9-83ff-ed458e3a0338")]
        public void Method_1016_4047()
        {
            ii(0x1016_4047, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_404c, 5); calld(Definitions.sys_check_available_stack_size, 0x1d01); /* call 0x10165d52 */
            ii(0x1016_4051, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_4052, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_4053, 1); pushd(esi);                             /* push esi */
            ii(0x1016_4054, 1); pushd(edi);                             /* push edi */
            ii(0x1016_4055, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_4056, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4058, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_405e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_4061, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_4064, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4067, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x1016_406a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_406d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4070, 5); calld(0x1013_c0fa, -0x2_7f7b);          /* call 0x1013c0fa */
            ii(0x1016_4075, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4078, 3); mov(edx, memd_a32[ds, eax + 0x8]);      /* mov edx, [eax+0x8] */
            ii(0x1016_407b, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_407e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4081, 5); calld(0x1013_c0fa, -0x2_7f8c);          /* call 0x1013c0fa */
            ii(0x1016_4086, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4089, 3); mov(edx, memd_a32[ds, eax + 0xa]);      /* mov edx, [eax+0xa] */
            ii(0x1016_408c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_408f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4092, 5); calld(0x1013_c0fa, -0x2_7f9d);          /* call 0x1013c0fa */
            ii(0x1016_4097, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_409a, 3); mov(edx, memd_a32[ds, eax + 0xc]);      /* mov edx, [eax+0xc] */
            ii(0x1016_409d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_40a0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_40a3, 5); calld(0x1013_c0fa, -0x2_7fae);          /* call 0x1013c0fa */
            ii(0x1016_40a8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_40ab, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1016_40ae, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_40b1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_40b4, 5); calld(0x1013_c0fa, -0x2_7fbf);          /* call 0x1013c0fa */
            ii(0x1016_40b9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_40bc, 3); mov(edx, memd_a32[ds, eax + 0x10]);     /* mov edx, [eax+0x10] */
            ii(0x1016_40bf, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_40c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_40c5, 5); calld(0x1013_c0fa, -0x2_7fd0);          /* call 0x1013c0fa */
            ii(0x1016_40ca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_40cd, 3); mov(edx, memd_a32[ds, eax + 0x12]);     /* mov edx, [eax+0x12] */
            ii(0x1016_40d0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1016_40d3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_40d6, 5); calld(0x1013_c0fa, -0x2_7fe1);          /* call 0x1013c0fa */
            ii(0x1016_40db, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_40dd, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_40de, 1); popd(edi);                              /* pop edi */
            ii(0x1016_40df, 1); popd(esi);                              /* pop esi */
            ii(0x1016_40e0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_40e1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_40e2, 1); retd(); return;                         /* ret */
        }
    }
}

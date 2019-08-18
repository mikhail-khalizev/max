using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f0dcdfe4-912a-4897-8458-b01e1341e2a1")]
        public void Method_1016_419a()
        {
            ii(0x1016_419a, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1016_419f, 5); calld(Definitions.sys_check_available_stack_size, 0x1bae); /* call 0x10165d52 */
            ii(0x1016_41a4, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_41a5, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_41a6, 1); pushd(esi);                             /* push esi */
            ii(0x1016_41a7, 1); pushd(edi);                             /* push edi */
            ii(0x1016_41a8, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_41a9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_41ab, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1016_41b1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_41b4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_41b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_41ba, 3); mov(ebx, memd_a32[ds, eax + 0x6]);      /* mov ebx, [eax+0x6] */
            ii(0x1016_41bd, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_41c0, 5); mov(edx, StringDefinitions.Material2);  /* mov edx, 0x101b2bad */
            ii(0x1016_41c5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_41c8, 5); calld(0x1014_74f5, -0x1_ccd8);          /* call 0x101474f5 */
            ii(0x1016_41cd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_41d0, 3); mov(ebx, memd_a32[ds, eax + 0x8]);      /* mov ebx, [eax+0x8] */
            ii(0x1016_41d3, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_41d6, 5); mov(edx, StringDefinitions.Fuel6);      /* mov edx, 0x101b2bb6 */
            ii(0x1016_41db, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_41de, 5); calld(0x1014_74f5, -0x1_ccee);          /* call 0x101474f5 */
            ii(0x1016_41e3, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_41e6, 3); mov(ebx, memd_a32[ds, eax + 0xa]);      /* mov ebx, [eax+0xa] */
            ii(0x1016_41e9, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_41ec, 5); mov(edx, StringDefinitions.Gold8);      /* mov edx, 0x101b2bbb */
            ii(0x1016_41f1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_41f4, 5); calld(0x1014_74f5, -0x1_cd04);          /* call 0x101474f5 */
            ii(0x1016_41f9, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_41fc, 3); mov(ebx, memd_a32[ds, eax + 0xc]);      /* mov ebx, [eax+0xc] */
            ii(0x1016_41ff, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_4202, 5); mov(edx, StringDefinitions.Power9);     /* mov edx, 0x101b2bc0 */
            ii(0x1016_4207, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_420a, 5); calld(0x1014_74f5, -0x1_cd1a);          /* call 0x101474f5 */
            ii(0x1016_420f, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1016_4212, 3); mov(ebx, memd_a32[ds, ebx + 0xe]);      /* mov ebx, [ebx+0xe] */
            ii(0x1016_4215, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_4218, 5); mov(edx, StringDefinitions.Workers5);   /* mov edx, 0x101b2bc6 */
            ii(0x1016_421d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4220, 5); calld(0x1014_74f5, -0x1_cd30);          /* call 0x101474f5 */
            ii(0x1016_4225, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1016_4228, 3); mov(ebx, memd_a32[ds, ebx + 0x10]);     /* mov ebx, [ebx+0x10] */
            ii(0x1016_422b, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_422e, 5); mov(edx, StringDefinitions.Buildings2); /* mov edx, 0x101b2bce */
            ii(0x1016_4233, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_4236, 5); calld(0x1014_74f5, -0x1_cd46);          /* call 0x101474f5 */
            ii(0x1016_423b, 3); mov(ebx, memd_a32[ss, ebp - 0x8]);      /* mov ebx, [ebp-0x8] */
            ii(0x1016_423e, 3); mov(ebx, memd_a32[ds, ebx + 0x12]);     /* mov ebx, [ebx+0x12] */
            ii(0x1016_4241, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1016_4244, 5); mov(edx, StringDefinitions.Id4);        /* mov edx, 0x101b2bd8 */
            ii(0x1016_4249, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1016_424c, 5); calld(0x1014_74f5, -0x1_cd5c);          /* call 0x101474f5 */
            ii(0x1016_4251, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4253, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4254, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4255, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4256, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4257, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4258, 1); retd(); return;                         /* ret */
        }
    }
}

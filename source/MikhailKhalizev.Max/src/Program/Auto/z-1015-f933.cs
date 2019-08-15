using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("436dc21b-d519-42d4-ad8c-83051bd08363")]
        public void Method_1015_f933()
        {
            ii(0x1015_f933, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_f938, 5); calld(Definitions.sys_check_available_stack_size, 0x6415); /* call 0x10165d52 */
            ii(0x1015_f93d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_f93e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_f93f, 1); pushd(edx);                             /* push edx */
            ii(0x1015_f940, 1); pushd(esi);                             /* push esi */
            ii(0x1015_f941, 1); pushd(edi);                             /* push edi */
            ii(0x1015_f942, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_f943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_f945, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1015_f94b, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_f94e, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f950, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f951, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1015_f953, 1); pushd(eax);                             /* push eax */
            ii(0x1015_f954, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_f956, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1015_f958, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f95b, 3); mov(edx, memd_a32[ds, eax + 0x1a]);     /* mov edx, [eax+0x1a] */
            ii(0x1015_f95e, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_f961, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f964, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1015_f967, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_f96a, 5); calld(0x1007_4395, -0xe_b5da);          /* call 0x10074395 */
            ii(0x1015_f96f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f972, 4); mov(memb_a32[ds, eax + 0x3f], 0);       /* mov byte [eax+0x3f], 0x0 */
            ii(0x1015_f976, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f979, 4); mov(memb_a32[ds, eax + 0x40], 0x1);     /* mov byte [eax+0x40], 0x1 */
            ii(0x1015_f97d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f980, 4); mov(memb_a32[ds, eax + 0x3d], 0x2);     /* mov byte [eax+0x3d], 0x2 */
            ii(0x1015_f984, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f987, 4); mov(memb_a32[ds, eax + 0x3e], 0);       /* mov byte [eax+0x3e], 0x0 */
            ii(0x1015_f98b, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_f98e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f991, 5); calld(0x1007_611c, -0xe_987a);          /* call 0x1007611c */
            ii(0x1015_f996, 5); calld(0x1008_a998, -0xd_5003);          /* call 0x1008a998 */
            ii(0x1015_f99b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_f99d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_f9a0, 5); calld(0x1008_a998, -0xd_500d);          /* call 0x1008a998 */
            ii(0x1015_f9a5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_f9a7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_f9a8, 1); popd(edi);                              /* pop edi */
            ii(0x1015_f9a9, 1); popd(esi);                              /* pop esi */
            ii(0x1015_f9aa, 1); popd(edx);                              /* pop edx */
            ii(0x1015_f9ab, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_f9ac, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_f9ad, 1); retd(); return;                         /* ret */
        }
    }
}

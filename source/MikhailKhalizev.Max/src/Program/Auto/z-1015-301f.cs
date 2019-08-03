using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("516344dd-ec62-4efb-a416-7dfa228da0c8")]
        public void Method_1015_301f()
        {
            ii(0x1015_301f, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_3024, 5); calld(Definitions.sys_check_available_stack_size, 0x12d29); /* call 0x10165d52 */
            ii(0x1015_3029, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_302a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_302b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_302c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_302d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_302e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_3030, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_3036, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_3039, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_303c, 3); mov(ecx, memd_a32[ss, ebp - 0x4]);      /* mov ecx, [ebp-0x4] */
            ii(0x1015_303f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3042, 6); mov(esi, memd_a32[ds, eax + 0xd3]);     /* mov esi, [eax+0xd3] */
            ii(0x1015_3048, 3); sar(esi, 0x10);                         /* sar esi, 0x10 */
            ii(0x1015_304b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_304e, 3); mov(ebx, memd_a32[ds, eax + 0x16]);     /* mov ebx, [eax+0x16] */
            ii(0x1015_3051, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1015_3054, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_3057, 3); mov(edx, memd_a32[ds, eax + 0x14]);     /* mov edx, [eax+0x14] */
            ii(0x1015_305a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1015_305d, 3); lea(eax, ebp - 0xc);                    /* lea eax, [ebp-0xc] */
            ii(0x1015_3060, 5); calld(0x1007_6aac, -0xdc5b9);           /* call 0x10076aac */
            ii(0x1015_3065, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1015_3067, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_306a, 2); mov(ebx, esi);                          /* mov ebx, esi */
            ii(0x1015_306c, 5); calld(0x1015_2f21, -0x150);             /* call 0x10152f21 */
            ii(0x1015_3071, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_3073, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_3074, 1); popd(edi);                              /* pop edi */
            ii(0x1015_3075, 1); popd(esi);                              /* pop esi */
            ii(0x1015_3076, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_3077, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_3078, 1); retd(); return;                         /* ret */
        }
    }
}
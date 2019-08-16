using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f6b1b87-0e2d-430b-9984-c0fdc4c82dc4")]
        public void Method_1007_6910()
        {
            ii(0x1007_6910, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6915, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f438); /* call 0x10165d52 */
            ii(0x1007_691a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_691b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_691c, 1); pushd(esi);                             /* push esi */
            ii(0x1007_691d, 1); pushd(edi);                             /* push edi */
            ii(0x1007_691e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_691f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6921, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_6927, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_692a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_692d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_6930, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6933, 5); calld(0x1013_ac03, 0xc_42cb);           /* call 0x1013ac03 */
            ii(0x1007_6938, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_693b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_693e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_6941, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6944, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_6947, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_694a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_694c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_694d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_694e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_694f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6950, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6951, 1); retd(); return;                         /* ret */
        }
    }
}
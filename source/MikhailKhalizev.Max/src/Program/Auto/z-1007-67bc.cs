using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("830a7ee0-b644-4260-a28b-268ff1b28706")]
        public void Method_1007_67bc()
        {
            ii(0x1007_67bc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_67c1, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f58c); /* call 0x10165d52 */
            ii(0x1007_67c6, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_67c7, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_67c8, 1); pushd(esi);                             /* push esi */
            ii(0x1007_67c9, 1); pushd(edi);                             /* push edi */
            ii(0x1007_67ca, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_67cb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_67cd, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_67d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_67d6, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_67d9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_67dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_67df, 5); calld(0x1013_ac03, 0xc_441f);           /* call 0x1013ac03 */
            ii(0x1007_67e4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_67e7, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_67ea, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_67ed, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_67f0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_67f3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_67f6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_67f8, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_67f9, 1); popd(edi);                              /* pop edi */
            ii(0x1007_67fa, 1); popd(esi);                              /* pop esi */
            ii(0x1007_67fb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_67fc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_67fd, 1); retd(); return;                         /* ret */
        }
    }
}

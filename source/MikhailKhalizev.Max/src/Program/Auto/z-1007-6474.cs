using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b3ca6049-5009-4d7e-9a31-5921db1f574c")]
        public void Method_1007_6474()
        {
            ii(0x1007_6474, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6479, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f8d4); /* call 0x10165d52 */
            ii(0x1007_647e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_647f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6480, 1); pushd(esi);                             /* push esi */
            ii(0x1007_6481, 1); pushd(edi);                             /* push edi */
            ii(0x1007_6482, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_6483, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6485, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1007_648b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_648e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_6491, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1007_6494, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_6497, 5); calld(0x1007_6cd0, 0x834);              /* call 0x10076cd0 */
            ii(0x1007_649c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_649f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1007_64a2, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_64a5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_64a8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1007_64ab, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1007_64ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_64b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_64b1, 1); popd(edi);                              /* pop edi */
            ii(0x1007_64b2, 1); popd(esi);                              /* pop esi */
            ii(0x1007_64b3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_64b4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_64b5, 1); retd(); return;                         /* ret */
        }
    }
}

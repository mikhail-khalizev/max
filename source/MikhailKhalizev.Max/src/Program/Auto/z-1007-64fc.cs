using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a8cc5550-1b36-4235-b1f5-8910e01cab64")]
        public void Method_1007_64fc()
        {
            ii(0x1007_64fc, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1007_6501, 5); calld(Definitions.sys_check_available_stack_size, 0xe_f84c); /* call 0x10165d52 */
            ii(0x1007_6506, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_6507, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_6508, 1); pushd(edx);                             /* push edx */
            ii(0x1007_6509, 1); pushd(esi);                             /* push esi */
            ii(0x1007_650a, 1); pushd(edi);                             /* push edi */
            ii(0x1007_650b, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_650c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_650e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6514, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6517, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_651a, 5); calld(0x1007_6d58, 0x839);              /* call 0x10076d58 */
            ii(0x1007_651f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_6522, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1007_6525, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_6528, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_652b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_652e, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_6531, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6533, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6534, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6535, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6536, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6537, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6538, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6539, 1); retd(); return;                         /* ret */
        }
    }
}

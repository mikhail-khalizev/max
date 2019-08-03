using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("81ca4fa4-417e-472b-9954-75648f53223b")]
        public void Method_1010_44b0()
        {
            ii(0x1010_44b0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1010_44b5, 5); calld(Definitions.sys_check_available_stack_size, 0x61898); /* call 0x10165d52 */
            ii(0x1010_44ba, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_44bb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_44bc, 1); pushd(edx);                             /* push edx */
            ii(0x1010_44bd, 1); pushd(esi);                             /* push esi */
            ii(0x1010_44be, 1); pushd(edi);                             /* push edi */
            ii(0x1010_44bf, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_44c0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_44c2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_44c8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_44cb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1010_44ce, 5); calld(0x1007_6c30, -0x8d8a3);           /* call 0x10076c30 */
            ii(0x1010_44d3, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_44d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_44d9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_44db, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_44dc, 1); popd(edi);                              /* pop edi */
            ii(0x1010_44dd, 1); popd(esi);                              /* pop esi */
            ii(0x1010_44de, 1); popd(edx);                              /* pop edx */
            ii(0x1010_44df, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_44e0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_44e1, 1); retd(); return;                         /* ret */
        }
    }
}
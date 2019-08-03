using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a9593dbc-dedf-47fc-beb6-19ae32d85ec1")]
        public void Method_1007_63d4()
        {
            ii(0x1007_63d4, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_63d9, 5); calld(Definitions.sys_check_available_stack_size, 0xef974); /* call 0x10165d52 */
            ii(0x1007_63de, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_63df, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_63e0, 1); pushd(edx);                             /* push edx */
            ii(0x1007_63e1, 1); pushd(esi);                             /* push esi */
            ii(0x1007_63e2, 1); pushd(edi);                             /* push edi */
            ii(0x1007_63e3, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_63e4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_63e6, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_63ec, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_63ef, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_63f2, 5); calld(0x1007_6c30, 0x839);              /* call 0x10076c30 */
            ii(0x1007_63f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_63fa, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_63fd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_63ff, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_6400, 1); popd(edi);                              /* pop edi */
            ii(0x1007_6401, 1); popd(esi);                              /* pop esi */
            ii(0x1007_6402, 1); popd(edx);                              /* pop edx */
            ii(0x1007_6403, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_6404, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_6405, 1); retd(); return;                         /* ret */
        }
    }
}

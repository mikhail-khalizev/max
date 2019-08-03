using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dced519e-af58-42db-9186-73995aa0718c")]
        public void Method_1007_5f2c()
        {
            ii(0x1007_5f2c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_5f31, 5); calld(Definitions.sys_check_available_stack_size, 0xefe1c); /* call 0x10165d52 */
            ii(0x1007_5f36, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_5f37, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_5f38, 1); pushd(esi);                             /* push esi */
            ii(0x1007_5f39, 1); pushd(edi);                             /* push edi */
            ii(0x1007_5f3a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_5f3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_5f3d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_5f43, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_5f46, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1007_5f49, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1007_5f4e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5f51, 5); calld(Definitions.my_dtor_0x101b6edc, 0xc4cef); /* call 0x1013ac45 */
            ii(0x1007_5f56, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1007_5f59, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1007_5f5c, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1007_5f5f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1007_5f62, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_5f64, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_5f65, 1); popd(edi);                              /* pop edi */
            ii(0x1007_5f66, 1); popd(esi);                              /* pop esi */
            ii(0x1007_5f67, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_5f68, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_5f69, 1); retd(); return;                         /* ret */
        }
    }
}

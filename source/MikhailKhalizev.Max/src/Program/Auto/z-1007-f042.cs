using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d5d2c3c7-e12e-45b9-8bd1-b0acb4dc41e1")]
        public void Method_1007_f042()
        {
            ii(0x1007_f042, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_f047, 5); calld(Definitions.sys_check_available_stack_size, 0xe_6d06); /* call 0x10165d52 */
            ii(0x1007_f04c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_f04d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_f04e, 1); pushd(edx);                             /* push edx */
            ii(0x1007_f04f, 1); pushd(esi);                             /* push esi */
            ii(0x1007_f050, 1); pushd(edi);                             /* push edi */
            ii(0x1007_f051, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_f052, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_f054, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_f05a, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_f05d, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_f061, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_f064, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_f066, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_f067, 1); popd(edi);                              /* pop edi */
            ii(0x1007_f068, 1); popd(esi);                              /* pop esi */
            ii(0x1007_f069, 1); popd(edx);                              /* pop edx */
            ii(0x1007_f06a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_f06b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_f06c, 1); retd(); return;                         /* ret */
        }
    }
}

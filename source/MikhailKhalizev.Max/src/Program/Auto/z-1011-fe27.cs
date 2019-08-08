using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4b2c67b6-1a23-4ab3-9097-87b9f6da8969")]
        public void Method_1011_fe27()
        {
            ii(0x1011_fe27, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_fe2c, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5f21); /* call 0x10165d52 */
            ii(0x1011_fe31, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fe32, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fe33, 1); pushd(edx);                             /* push edx */
            ii(0x1011_fe34, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fe35, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fe36, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fe37, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fe39, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_fe3f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_fe42, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1011_fe45, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fe4a, 5); calld(0x1011_e50b, -0x1944);            /* call 0x1011e50b */
            ii(0x1011_fe4f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_fe51, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fe52, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fe53, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fe54, 1); popd(edx);                              /* pop edx */
            ii(0x1011_fe55, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fe56, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fe57, 1); retd(); return;                         /* ret */
        }
    }
}

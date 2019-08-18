using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_9fa8-bc097388")]
        public void Method_1014_9fa8()
        {
            ii(0x1014_9fa8, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_9fad, 5); calld(Definitions.sys_check_available_stack_size, 0x1_bda0); /* call 0x10165d52 */
            ii(0x1014_9fb2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_9fb3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_9fb4, 1); pushd(edx);                             /* push edx */
            ii(0x1014_9fb5, 1); pushd(esi);                             /* push esi */
            ii(0x1014_9fb6, 1); pushd(edi);                             /* push edi */
            ii(0x1014_9fb7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_9fb8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_9fba, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_9fc0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_9fc3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9fc6, 5); add(eax, 0xc5);                         /* add eax, 0xc5 */
            ii(0x1014_9fcb, 5); calld(0x100f_f562, -0x4_aa6e);          /* call 0x100ff562 */
            ii(0x1014_9fd0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_9fd3, 5); add(eax, 0xb5);                         /* add eax, 0xb5 */
            ii(0x1014_9fd8, 5); calld(0x100f_f562, -0x4_aa7b);          /* call 0x100ff562 */
            ii(0x1014_9fdd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_9fdf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_9fe0, 1); popd(edi);                              /* pop edi */
            ii(0x1014_9fe1, 1); popd(esi);                              /* pop esi */
            ii(0x1014_9fe2, 1); popd(edx);                              /* pop edx */
            ii(0x1014_9fe3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_9fe4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_9fe5, 1); retd(); return;                         /* ret */
        }
    }
}

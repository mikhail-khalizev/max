using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("62d31cbc-157a-425d-8b59-46353230688f")]
        public void Method_1011_48a3()
        {
            ii(0x1011_48a3, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1011_48a8, 5); calld(Definitions.sys_check_available_stack_size, 0x5_14a5); /* call 0x10165d52 */
            ii(0x1011_48ad, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_48ae, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_48af, 1); pushd(edx);                             /* push edx */
            ii(0x1011_48b0, 1); pushd(esi);                             /* push esi */
            ii(0x1011_48b1, 1); pushd(edi);                             /* push edi */
            ii(0x1011_48b2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_48b3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_48b5, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1011_48bb, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1011_48be, 5); calld(0x1012_ad2f, 0x1_646c);           /* call 0x1012ad2f */
            ii(0x1011_48c3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1011_48c6, 7); mov(memd_a32[ds, eax + 0x4], 0x1b);     /* mov dword [eax+0x4], 0x1b */
            ii(0x1011_48cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_48cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_48d0, 1); popd(edi);                              /* pop edi */
            ii(0x1011_48d1, 1); popd(esi);                              /* pop esi */
            ii(0x1011_48d2, 1); popd(edx);                              /* pop edx */
            ii(0x1011_48d3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_48d4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_48d5, 1); retd(); return;                         /* ret */
        }
    }
}
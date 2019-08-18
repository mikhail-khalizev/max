using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b3c7628d-18d9-49e1-815c-2f87524636cd")]
        public void Method_1014_4ef4()
        {
            ii(0x1014_4ef4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_4ef9, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0e54); /* call 0x10165d52 */
            ii(0x1014_4efe, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_4eff, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_4f00, 1); pushd(edx);                             /* push edx */
            ii(0x1014_4f01, 1); pushd(esi);                             /* push esi */
            ii(0x1014_4f02, 1); pushd(edi);                             /* push edi */
            ii(0x1014_4f03, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_4f04, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_4f06, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_4f0c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_4f0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4f12, 5); calld(0x1014_811c, 0x3205);             /* call 0x1014811c */
            ii(0x1014_4f17, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_4f1a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1014_4f1d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_4f20, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4f23, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5768); /* mov dword [eax+0x2], 0x101b5768 */
            ii(0x1014_4f2a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_4f2d, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_4f30, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_4f33, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4f35, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_4f36, 1); popd(edi);                              /* pop edi */
            ii(0x1014_4f37, 1); popd(esi);                              /* pop esi */
            ii(0x1014_4f38, 1); popd(edx);                              /* pop edx */
            ii(0x1014_4f39, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_4f3a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_4f3b, 1); retd(); return;                         /* ret */
        }
    }
}

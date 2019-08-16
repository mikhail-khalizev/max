using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1fdcaa0a-374c-497b-8b77-b6f3df1037cd")]
        public void Method_100a_ae58()
        {
            ii(0x100a_ae58, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100a_ae5d, 5); calld(Definitions.sys_check_available_stack_size, 0xb_aef0); /* call 0x10165d52 */
            ii(0x100a_ae62, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_ae63, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_ae64, 1); pushd(esi);                             /* push esi */
            ii(0x100a_ae65, 1); pushd(edi);                             /* push edi */
            ii(0x100a_ae66, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_ae67, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ae69, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100a_ae6f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ae72, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100a_ae75, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_ae78, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ae7b, 5); calld(0x1013_ac03, 0x8_fd83);           /* call 0x1013ac03 */
            ii(0x100a_ae80, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_ae83, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100a_ae86, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100a_ae89, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_ae8c, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100a_ae8f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100a_ae92, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_ae94, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_ae95, 1); popd(edi);                              /* pop edi */
            ii(0x100a_ae96, 1); popd(esi);                              /* pop esi */
            ii(0x100a_ae97, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_ae98, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_ae99, 1); retd(); return;                         /* ret */
        }
    }
}
using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0c241bdd-f866-42ad-b3e9-b2a88b988ad3")]
        public void Method_1012_0548()
        {
            ii(0x1012_0548, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_054d, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5800); /* call 0x10165d52 */
            ii(0x1012_0552, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0553, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0554, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0555, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0556, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0557, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0559, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_055f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0562, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0565, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1012_0569, 3); imul(edx, eax, 0x6);                    /* imul edx, eax, 0x6 */
            ii(0x1012_056c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_056f, 3); mov(eax, memd_a32[ds, eax + 0x8]);      /* mov eax, [eax+0x8] */
            ii(0x1012_0572, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1012_0574, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0577, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_057a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_057c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_057d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_057e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_057f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0580, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0581, 1); retd(); return;                         /* ret */
        }
    }
}

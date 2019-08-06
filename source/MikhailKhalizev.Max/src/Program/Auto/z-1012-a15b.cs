using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9f3fcd15-602e-4e3d-90de-8a4fae4ac6a2")]
        public void Method_1012_a15b()
        {
            ii(0x1012_a15b, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_a160, 5); calld(Definitions.sys_check_available_stack_size, 0x3bbed); /* call 0x10165d52 */
            ii(0x1012_a165, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_a166, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_a167, 1); pushd(esi);                             /* push esi */
            ii(0x1012_a168, 1); pushd(edi);                             /* push edi */
            ii(0x1012_a169, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_a16a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_a16c, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_a172, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_a175, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_a178, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1012_a17c, 2); if(jnzd(0x1012_a18d, 0xf)) goto l_0x1012_a18d; /* jnz 0x1012a18d */
            ii(0x1012_a17e, 5); mov(edx, StringDefinitions.None);       /* mov edx, 0x101a83d7 */
            ii(0x1012_a183, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a186, 5); calld(Definitions.sys_strcpy, 0x3bd44); /* call 0x10165ecf */
            ii(0x1012_a18b, 2); jmpd(0x1012_a1a9, 0x1c); goto l_0x1012_a1a9; /* jmp 0x1012a1a9 */
        l_0x1012_a18d:
            ii(0x1012_a18d, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1012_a190, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a193, 3); mov(al, memb_a32[ds, eax + 0x27]);      /* mov al, [eax+0x27] */
            ii(0x1012_a196, 2); xor(ah, ah);                            /* xor ah, ah */
            ii(0x1012_a198, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1012_a19b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_a19e, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1012_a1a1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1012_a1a4, 5); calld(0x1012_a108, -0xa1);              /* call 0x1012a108 */
        l_0x1012_a1a9:
            ii(0x1012_a1a9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1012_a1ac, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_a1af, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_a1b2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_a1b4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_a1b5, 1); popd(edi);                              /* pop edi */
            ii(0x1012_a1b6, 1); popd(esi);                              /* pop esi */
            ii(0x1012_a1b7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_a1b8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_a1b9, 1); retd(); return;                         /* ret */
        }
    }
}

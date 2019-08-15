using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("86430d2d-d017-43ea-a870-98bd51906413")]
        public void Method_1009_a11e()
        {
            ii(0x1009_a11e, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1009_a123, 5); calld(Definitions.sys_check_available_stack_size, 0xc_bc2a); /* call 0x10165d52 */
            ii(0x1009_a128, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_a129, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_a12a, 1); pushd(esi);                             /* push esi */
            ii(0x1009_a12b, 1); pushd(edi);                             /* push edi */
            ii(0x1009_a12c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_a12d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a12f, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_a135, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_a138, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_a13b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a13d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a140, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a143, 5); calld(0x1013_ad11, 0xa_0bc9);           /* call 0x1013ad11 */
            ii(0x1009_a148, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a14a, 2); if(jzd(0x1009_a15b, 0xf)) goto l_0x1009_a15b; /* jz 0x1009a15b */
            ii(0x1009_a14c, 5); mov(edx, StringDefinitions.CompletedRubbleRemoval); /* mov edx, 0x101a06c5 */
            ii(0x1009_a151, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a154, 5); calld(Definitions.sys_strcpy, 0xc_bd76); /* call 0x10165ecf */
            ii(0x1009_a159, 2); jmpd(0x1009_a193, 0x38); goto l_0x1009_a193; /* jmp 0x1009a193 */
        l_0x1009_a15b:
            ii(0x1009_a15b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a15e, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a161, 5); calld(0x1007_6574, -0x2_3bf2);          /* call 0x10076574 */
            ii(0x1009_a166, 3); mov(eax, memd_a32[ds, eax + 0x1a]);     /* mov eax, [eax+0x1a] */
            ii(0x1009_a169, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_a16c, 1); inc(eax);                               /* inc eax */
            ii(0x1009_a16d, 1); pushd(eax);                             /* push eax */
            ii(0x1009_a16e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_a171, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_a174, 5); calld(0x1007_6574, -0x2_3c05);          /* call 0x10076574 */
            ii(0x1009_a179, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x1009_a17c, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1009_a17f, 1); inc(eax);                               /* inc eax */
            ii(0x1009_a180, 1); pushd(eax);                             /* push eax */
            ii(0x1009_a181, 5); mov(eax, StringDefinitions.RemoveRubbleFromII); /* mov eax, 0x101a06de */
            ii(0x1009_a186, 1); pushd(eax);                             /* push eax */
            ii(0x1009_a187, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a18a, 1); pushd(eax);                             /* push eax */
            ii(0x1009_a18b, 5); calld(Definitions.sys_sprintf, 0xc_bd71); /* call 0x10165f01 */
            ii(0x1009_a190, 3); add(esp, 0x10);                         /* add esp, 0x10 */
        l_0x1009_a193:
            ii(0x1009_a193, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_a196, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_a199, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_a19c, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a19e, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_a19f, 1); popd(edi);                              /* pop edi */
            ii(0x1009_a1a0, 1); popd(esi);                              /* pop esi */
            ii(0x1009_a1a1, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_a1a2, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_a1a3, 1); retd(); return;                         /* ret */
        }
    }
}

using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b958-e6e09d79")]
        public void Method_100c_b958()
        {
            ii(0x100c_b958, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100c_b95d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_a3f0); /* call 0x10165d52 */
            ii(0x100c_b962, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_b963, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_b964, 1); pushd(esi);                             /* push esi */
            ii(0x100c_b965, 1); pushd(edi);                             /* push edi */
            ii(0x100c_b966, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_b967, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_b969, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100c_b96f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_b972, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_b975, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_b977, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b97a, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_b97d, 5); calld(0x1013_ad11, 0x6_f38f);           /* call 0x1013ad11 */
            ii(0x100c_b982, 2); test(al, al);                           /* test al, al */
            ii(0x100c_b984, 2); if(jzd(0x100c_b995, 0xf)) goto l_0x100c_b995; /* jz 0x100cb995 */
            ii(0x100c_b986, 5); mov(edx, StringDefinitions.FinishedRepairTask); /* mov edx, 0x101a1424 */
            ii(0x100c_b98b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b98e, 5); calld(Definitions.sys_strcpy, 0x9_a53c); /* call 0x10165ecf */
            ii(0x100c_b993, 2); jmpd(0x100c_b9c4, 0x2f); goto l_0x100c_b9c4; /* jmp 0x100cb9c4 */
        l_0x100c_b995:
            ii(0x100c_b995, 5); mov(edx, StringDefinitions.Repair);     /* mov edx, 0x101a143a */
            ii(0x100c_b99a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b99d, 5); calld(Definitions.sys_strcpy, 0x9_a52d); /* call 0x10165ecf */
            ii(0x100c_b9a2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_b9a5, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100c_b9a8, 5); calld(0x1007_6574, -0x5_5439);          /* call 0x10076574 */
            ii(0x100c_b9ad, 3); mov(edx, memd_a32[ds, eax + 0x6]);      /* mov edx, [eax+0x6] */
            ii(0x100c_b9b0, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100c_b9b3, 3); imul(edx, edx, 0x33);                   /* imul edx, edx, 0x33 */
            ii(0x100c_b9b6, 6); mov(edx, memd_a32[ds, edx + 0x101c_81d7]); /* mov edx, [edx+0x101c81d7] */
            ii(0x100c_b9bc, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b9bf, 5); calld(Definitions.sys_strcat, 0x9_a56d); /* call 0x10165f31 */
        l_0x100c_b9c4:
            ii(0x100c_b9c4, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100c_b9c7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_b9ca, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_b9cd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_b9cf, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_b9d0, 1); popd(edi);                              /* pop edi */
            ii(0x100c_b9d1, 1); popd(esi);                              /* pop esi */
            ii(0x100c_b9d2, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_b9d3, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_b9d4, 1); retd();                                 /* ret */
        }
    }
}
